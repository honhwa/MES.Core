using Dapper;
using MES.Core.Model;
using MES.Core.Repository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace MES.WebAPI.MiddleWare
{
    // ── 專案應收沖款：對應 PITS-2025.accdb「S-專案應收沖款」表單。紀錄由
    //    工令單「生效」(專案機台立帳)或零件申請單「生效」(零件申請立帳)自動建立
    //    ，本畫面用於後續維護收款/報價明細。「收款條件」ComboBox 實際存放
    //    付款方式.條文編號(代碼)，畫面另以 DLookUp 帶出 條文名稱 顯示；
    //    「客戶簡稱」欄位實際存放 C客戶設定.正航編號(代碼)，「客戶名稱」則由
    //    DLookUp(COMPANY) 帶出。COMMISSION/AGENT 依賴之 dbo_C-QUODATA/佣金AGENT
    //    在 CHINYO 查無資料表，未納入(維持空白唯讀)。
    //    註：資料表曾一度新增 核准/核准日/建檔/建檔日/修改/修改日 6 欄並提供
    //    生效/取消生效功能，惟資料表結構已變更、該6欄位已不存在，本檔已同步
    //    移除對應查詢/更新邏輯 ─────────────────────────────────────────────
    public class ReceivablesMiddle
    {
        public 專案應收沖款 getByProjectNo(string projectNo)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    string sql = @"
                        SELECT TOP 1 識別碼, 專案序號, 收款條件, 幣別, 合約報價, 實際成交價, 追加增減額,
                               加購價1st, 報價單號1st, 加購價2nd, 報價單號2nd, 加購價3rd, 報價單號3rd,
                               應收款合計, 報價設算匯率, [專案營業額-台幣] AS 專案營業額_台幣,
                               往來銀行, 收款帳戶, 累計收款比例, 類別, 客戶簡稱, 機台型號, 機台類型, 機台名稱
                        FROM 專案應收沖款 WHERE 專案序號=@專案序號";
                    return conn.QueryFirstOrDefault<專案應收沖款>(sql, new { 專案序號 = projectNo });
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int updateReceivables(專案應收沖款 t)
        {
            try
            {
                string sql = @"
                    UPDATE 專案應收沖款 SET
                        收款條件=@收款條件, 幣別=@幣別, 合約報價=@合約報價, 實際成交價=@實際成交價,
                        追加增減額=@追加增減額, 加購價1st=@加購價1st, 報價單號1st=@報價單號1st,
                        加購價2nd=@加購價2nd, 報價單號2nd=@報價單號2nd, 加購價3rd=@加購價3rd, 報價單號3rd=@報價單號3rd,
                        應收款合計=@應收款合計, 報價設算匯率=@報價設算匯率, [專案營業額-台幣]=@專案營業額_台幣,
                        往來銀行=@往來銀行, 收款帳戶=@收款帳戶, 累計收款比例=@累計收款比例, 類別=@類別
                    WHERE 識別碼=@識別碼";
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    return conn.Execute(sql, t);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        // ── 收款條件下拉來源：比照 dbo_付款方式 RowSource(條文編號+條文名稱)，
        //    ControlSource 實際存放條文編號 ──────────────────────────────────
        public List<付款方式> getPaymentTermList()
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    return conn.Query<付款方式>("SELECT 識別碼, 條文編號, 條文名稱 FROM 付款方式 WHERE 條文編號 IS NOT NULL ORDER BY 條文編號").ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        // ── 幣別下拉來源：比照 dbo_CURRENCY→F幣別.CURRENCY ──────────────────────
        public List<string> getCurrencyList()
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    return conn.Query<string>("SELECT DISTINCT CURRENCY FROM F幣別 WHERE CURRENCY IS NOT NULL ORDER BY CURRENCY").ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        // ── 客戶名稱：比照 DLookUp("COMPANY","dbo_CUST","正航編號 = " & [客戶簡稱])，
        //    專案應收沖款.客戶簡稱 欄位實際存放 正航編號代碼 ─────────────────────
        public string getCustomerNameByCode(string custCode)
        {
            try
            {
                if (string.IsNullOrEmpty(custCode)) return "";
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    return conn.QueryFirstOrDefault<string>(
                        "SELECT TOP 1 COMPANY FROM C客戶設定 WHERE 正航編號=@正航編號", new { 正航編號 = custCode }) ?? "";
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        // ── 收款/沖帳明細：對應 S-專案應收沖款明細 子表單(LinkFields=專案序號)。
        //    識別碼為 IDENTITY，delete-then-reinsert 不寫入該欄，交由資料庫產生 ──
        public List<專案應收沖款明細> getDetailList(string projectNo)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    string sql = @"
                        SELECT 識別碼, 專案序號, 收款日期, 收款項目, 交付形式, 沖帳金額, 實收金額,
                               手續費, 其他減項, 折減事由, 備註, 沖帳人員, 業務複審
                        FROM 專案應收沖款明細 WHERE 專案序號=@專案序號 ORDER BY 識別碼";
                    return conn.Query<專案應收沖款明細>(sql, new { 專案序號 = projectNo }).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        // ── 總覽：對應「S-專案應收沖帳追蹤」，其 RecordSource 查詢「專案應收沖帳
        //    追蹤」為 專案應收沖款 LEFT JOIN 付款方式(收款條件=條文編號) LEFT
        //    JOIN C客戶設定(客戶簡稱=正航編號)。原表單「收款條件」欄位顯示的是
        //    JOIN 帶出的條文名稱(非代碼) ────────────────────────────────────
        public List<專案應收沖款總覽列表> getOverviewList(string custCode)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    string sql = @"
                        SELECT R.專案序號, R.客戶簡稱, C.COMPANY AS 客戶名稱, R.機台型號,
                               P.條文名稱 AS 收款條件, R.幣別, R.應收款合計, R.往來銀行, R.累計收款比例
                        FROM 專案應收沖款 R
                        LEFT JOIN 付款方式 P ON R.收款條件 = P.條文編號
                        LEFT JOIN C客戶設定 C ON R.客戶簡稱 = C.正航編號
                        WHERE (@客戶簡稱 IS NULL OR R.客戶簡稱 = @客戶簡稱)
                        ORDER BY R.專案序號";
                    return conn.Query<專案應收沖款總覽列表>(sql, new { 客戶簡稱 = custCode }).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        // ── 客戶篩選下拉來源：比照 S-專案應收沖帳追蹤「選號」ComboBox
        //    (SELECT 正航編號, COMPANY FROM dbo_CUST WHERE 正航編號 Is Not Null) ──
        public List<零件單客戶篩選列表> getCustomerFilterList()
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    return conn.Query<零件單客戶篩選列表>(
                        "SELECT COMPANY, 正航編號 FROM C客戶設定 WHERE 正航編號 IS NOT NULL ORDER BY COMPANY").ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int saveDetailList(string projectNo, List<專案應收沖款明細> list)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    using (var tran = conn.BeginTransaction())
                    {
                        conn.Execute("DELETE FROM 專案應收沖款明細 WHERE 專案序號=@專案序號", new { 專案序號 = projectNo }, tran);
                        string insertSql = @"
                            INSERT INTO 專案應收沖款明細
                                (專案序號, 收款日期, 收款項目, 交付形式, 沖帳金額, 實收金額, 手續費, 其他減項, 折減事由, 備註, 沖帳人員, 業務複審)
                            VALUES
                                (@專案序號, @收款日期, @收款項目, @交付形式, @沖帳金額, @實收金額, @手續費, @其他減項, @折減事由, @備註, @沖帳人員, @業務複審)";
                        foreach (var d in list ?? new List<專案應收沖款明細>())
                        {
                            d.專案序號 = projectNo;
                            conn.Execute(insertSql, d, tran);
                        }
                        tran.Commit();
                        return list?.Count ?? 0;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
