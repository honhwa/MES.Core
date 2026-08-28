
using Dapper;
using MES.Core.Model;
using MES.Core.Repository;
using MES.Core.Repository.Impl;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace MES.WebAPI.MiddleWare
{
    public class MfgMiddle
    {
        public string getMiscMfgNo()
        {
            string mfgNo = string.Empty;
            MiscMfgRepository miscMfgRepository = new MiscMfgRepository();
            try
            {
                mfgNo = miscMfgRepository.GetMiscMfgNo();
            }
            catch (Exception)
            {

                throw;
            }
            return mfgNo;
        }

        public int createMiscMfgOrder(零件申請單 form)
        {
            int execCnt = 0;
            MiscMfgRepository miscMfgRepository = new MiscMfgRepository();
            try
            {
                execCnt = miscMfgRepository.Insert(form);
            }
            catch (Exception)
            {

                throw;
            }
            return execCnt;
        }

        internal int updateSalesOrderMachineNo(零件申請單 form)
        {
            int execCnt = 0;
            MiscMfgRepository miscMfgRepository = new MiscMfgRepository();
            try
            {
                execCnt = miscMfgRepository.updateSalesOrderMachineNo(form);
            }
            catch (Exception)
            {

                throw;
            }
            return execCnt;
        }

        // ── 比照 PITS-2025.accdb「P-零件申請單」表單 ─────────────────────────
        public 零件申請單 getMiscMfgByNo(string orderNo)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    var header = conn.QueryFirstOrDefault<零件申請單>("SELECT * FROM 零件申請單 WHERE 單號=@單號", new { 單號 = orderNo });
                    if (header == null) return null;
                    header.detailList = conn.Query<零件申請明細>("SELECT * FROM 零件申請明細 WHERE 單號=@單號 ORDER BY 識別碼", new { 單號 = orderNo }).ToList();
                    return header;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int updateMiscMfgOrder(零件申請單 form)
        {
            MiscMfgRepository miscMfgRepository = new MiscMfgRepository();
            try
            {
                return miscMfgRepository.Update(form);
            }
            catch (Exception)
            {
                throw;
            }
        }

        // ── 生效 (原"生效")：需 業務權限.核准；已作廢或已生效者擋下。並比照原巨集
        //    的 5 個companion查詢一併執行(皆已於 CHINYO 確認資料表存在)：
        //      1. 零件申請轉採購 → INSERT B請購需求 (一律執行)
        //      2. 若 申請用途 IN (廠驗追加,售後維修,專案增購)：
        //         維修申請轉組測 → INSERT 專案模組用料清單
        //         維修明細轉組測 → INSERT 專案模組BOM明細
        //         (原查詢缺少 WHERE 單號=... 篩選，會把全部零件申請明細都灌入，
        //          判斷為原巨集之疏漏，此處已修正加上單號篩選，避免資料錯亂)
        //         若 單號=專案序號(該零件單本身即為獨立專案) → 零件工令新增 →
        //         INSERT 工令單(僅建立最基本欄位)
        //      3. 若 收費機制 屬於需收費類別 → 零件申請立帳 → INSERT 專案應收沖款
        // ────────────────────────────────────────────────────────────
        public int approveMiscMfg(string orderNo, string username)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    var current = conn.QueryFirstOrDefault<零件申請單>("SELECT 核准, 主旨, 申請用途, 收費機制, 專案序號 FROM 零件申請單 WHERE 單號=@單號", new { 單號 = orderNo });
                    if (current == null) throw new Exception("查無此零件申請單!");
                    if (current.主旨 == "此單作廢") throw new Exception("已作廢不能按生效核准");
                    if (!string.IsNullOrEmpty(current.核准)) throw new Exception("提醒您集中精神\n(已經生效,您按錯囉!)");

                    using (var tran = conn.BeginTransaction())
                    {
                        int cnt = conn.Execute(
                            "UPDATE 零件申請單 SET 核准=@核准, 核准日=@核准日 WHERE 單號=@單號",
                            new { 核准 = username, 核准日 = DateTime.Now.ToString("yyyy-MM-dd"), 單號 = orderNo }, tran);

                        // 1. 零件申請轉採購
                        conn.Execute(@"
                            INSERT INTO B請購需求 (品項編號, 品名規格, 註記, 數量, 用途, 日期, 請購類別, 請購人員)
                            SELECT D.零件號碼, D.品名, D.描述, D.數量, H.單號, H.申請日期, H.申請用途, H.申請人
                            FROM 零件申請明細 D LEFT JOIN 零件申請單 H ON D.單號 = H.單號
                            WHERE D.單號=@單號", new { 單號 = orderNo }, tran);

                        bool isRepairUse = current.申請用途 == "廠驗追加" || current.申請用途 == "售後維修" || current.申請用途 == "專案增購";
                        if (isRepairUse)
                        {
                            conn.Execute(@"
                                INSERT INTO 專案模組用料清單 (BOM編號, 專案序號, 模組名稱, 模組編碼, 製圖檔名, 圖檔發行日, 用途)
                                SELECT 單號, 專案序號, 機台型號, 'PR', 單號 + 申請用途, 申請日期, 申請用途
                                FROM 零件申請單
                                WHERE 單號=@單號 AND (申請用途='廠驗追加' OR 申請用途='售後維修' OR 申請用途='專案增購')",
                                new { 單號 = orderNo }, tran);

                            conn.Execute(@"
                                INSERT INTO 專案模組BOM明細 (BOM編號, 零件號碼, 品名, 描述, 數量)
                                SELECT 單號, 零件號碼, 品名, 描述, 數量
                                FROM 零件申請明細
                                WHERE 單號=@單號", new { 單號 = orderNo }, tran);

                            if (orderNo == current.專案序號)
                            {
                                conn.Execute(@"
                                    INSERT INTO 工令單 (專案序號, 訂單日期, 客戶簡稱, 備註, 交貨日期)
                                    SELECT 專案序號, 申請日期, 客戶編號, N'零件工令', 交貨日期
                                    FROM 零件申請單 WHERE 單號=@單號", new { 單號 = orderNo }, tran);
                            }
                        }

                        bool needBilling = current.收費機制 == "收費:廠內驗機追加" || current.收費機制 == "收費:超過保固期"
                                         || current.收費機制 == "收費:客戶自行汰換" || current.收費機制 == "收費:定期維修計畫";
                        if (needBilling)
                        {
                            conn.Execute(@"
                                INSERT INTO 專案應收沖款 (專案序號, 類別, 客戶簡稱, 機台類型, 機台型號, 機台名稱)
                                SELECT 單號, N'零件', 客戶編號, 機台類型, 機台型號, 機台名稱
                                FROM 零件申請單 WHERE 單號=@單號", new { 單號 = orderNo }, tran);
                        }

                        tran.Commit();
                        return cnt;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        // ── 取消生效：需 業務權限.核准；若該單已收款沖帳(專案應收沖款明細.
        //    實收金額>0)則擋下，比照原巨集之防呆。並比照原巨集查詢「零件申請轉
        //    採購刪除」，逐一刪除各明細列對應的 採購計畫(模組名稱=單號+附屬模組)
        //    紀錄 ──────────────────────────────────────────────────────
        public int unapproveMiscMfg(string orderNo)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    decimal received = conn.ExecuteScalar<decimal?>(
                        "SELECT SUM(實收金額) FROM 專案應收沖款明細 WHERE 專案序號=@單號", new { 單號 = orderNo }) ?? 0;
                    if (received > 0)
                    {
                        throw new Exception("本零件工令已經收款沖帳，無法取消生效！");
                    }

                    using (var tran = conn.BeginTransaction())
                    {
                        int cnt = conn.Execute(
                            "UPDATE 零件申請單 SET 核准=NULL, 核准日=NULL WHERE 單號=@單號", new { 單號 = orderNo }, tran);

                        var modules = conn.Query<string>(
                            "SELECT DISTINCT 附屬模組 FROM 零件申請明細 WHERE 單號=@單號 AND 附屬模組 IS NOT NULL AND 附屬模組<>''",
                            new { 單號 = orderNo }, tran).ToList();
                        foreach (var m in modules)
                        {
                            conn.Execute("DELETE FROM 採購計畫 WHERE 模組名稱=@模組名稱",
                                new { 模組名稱 = orderNo + m }, tran);
                        }

                        tran.Commit();
                        return cnt;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        // ── 紀錄作廢 (原Command136)：已生效者不得作廢，比照原巨集寫入
        //    主旨="此單作廢" ─────────────────────────────────────────────
        public int voidMiscMfg(string orderNo)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    string approved = conn.ExecuteScalar<string>("SELECT 核准 FROM 零件申請單 WHERE 單號=@單號", new { 單號 = orderNo });
                    if (!string.IsNullOrEmpty(approved))
                    {
                        throw new Exception("請主管先取消生效\n(已生效無法修改喔!)");
                    }
                    return conn.Execute("UPDATE 零件申請單 SET 主旨=@主旨 WHERE 單號=@單號", new { 主旨 = "此單作廢", 單號 = orderNo });
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        // ── 專案序號下拉：全部工令單(比照原ComboBox RowSource) ───────────────
        public List<工令單> getWorkOrderPickList()
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    return conn.Query<工令單>("SELECT 專案序號, 機台類型, 機台型號, 客戶簡稱 FROM 工令單 ORDER BY 專案序號 DESC").ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        // ── 查詢客戶專案機台零件 (原Command117→比照原查詢"BRG-零件")：依客戶簡稱
        //    +專案序號，將 採購計畫 中對應的模組零件暫存到 零件申請BRG，供
        //    P-零件申請選項 挑選 ─────────────────────────────────────────
        public int stageBRGParts(string orderNo, string custName, string projectNo)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    using (var tran = conn.BeginTransaction())
                    {
                        conn.Execute("DELETE FROM 零件申請BRG WHERE 單號=@單號", new { 單號 = orderNo }, tran);
                        int cnt = conn.Execute(@"
                            INSERT INTO 零件申請BRG (單號, 零件分類, 零件號碼, 附屬模組, 品名, 描述, 模組編碼, BOM表識別碼, BOM編號)
                            SELECT @單號, P.零件分類, P.零件號碼, P.模組名稱, P.品名, P.描述, P.模組編碼, P.BOM表識別碼, P.BOM編號
                            FROM 採購計畫 P INNER JOIN 工令單 W ON P.專案序號 = W.專案序號
                            WHERE W.客戶簡稱=@客戶簡稱 AND P.專案序號=@專案序號",
                            new { 單號 = orderNo, 客戶簡稱 = custName, 專案序號 = projectNo }, tran);
                        tran.Commit();
                        return cnt;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<零件申請BRG> getBRGPartsList(string orderNo)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    return conn.Query<零件申請BRG>("SELECT * FROM 零件申請BRG WHERE 單號=@單號", new { 單號 = orderNo }).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        // ── 依畫面勾選狀態回寫 零件申請BRG.選項，供確定轉入時篩選 ──────────────
        public int setBRGSelected(string orderNo, List<int> checkedIds)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    using (var tran = conn.BeginTransaction())
                    {
                        int cnt = conn.Execute("UPDATE 零件申請BRG SET 選項=0 WHERE 單號=@單號", new { 單號 = orderNo }, tran);
                        if (checkedIds != null && checkedIds.Count > 0)
                        {
                            cnt += conn.Execute("UPDATE 零件申請BRG SET 選項=1 WHERE 單號=@單號 AND 識別碼 IN @Ids",
                                new { 單號 = orderNo, Ids = checkedIds }, tran);
                        }
                        tran.Commit();
                        return cnt;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        // ── 確定 (原Command56)：比照原查詢"BRG-零件轉申請"，將已勾選(選項=Yes)的
        //    暫存列轉入 零件申請明細，再比照"BRG-零件選項刪除"清空暫存 ──────────
        public int confirmBRGSelection(string orderNo)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    using (var tran = conn.BeginTransaction())
                    {
                        int cnt = conn.Execute(@"
                            INSERT INTO 零件申請明細 (單號, 零件分類, 零件號碼, 附屬模組, 品名, 描述, 模組編碼, BOM表識別碼, BOM編號)
                            SELECT 單號, 零件分類, 零件號碼, 附屬模組, 品名, 描述, 模組編碼, BOM表識別碼, BOM編號
                            FROM 零件申請BRG WHERE 單號=@單號 AND 選項=1", new { 單號 = orderNo }, tran);
                        conn.Execute("DELETE FROM 零件申請BRG WHERE 單號=@單號", new { 單號 = orderNo }, tran);
                        tran.Commit();
                        return cnt;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        // ── 零件單客戶篩選：比照原查詢，來源為 C客戶設定(dbo_CUST)，篩=成交/未
        //    成交依 正航編號 是否有值判斷 ──────────────────────────────────
        public List<零件單客戶篩選列表> getCustomerSearchList(string keyword)
        {
            try
            {
                string sql = @"
                    SELECT COMPANY, 正航編號, CASE WHEN 正航編號 IS NULL THEN N'未成交' ELSE N'成交' END AS 篩
                    FROM C客戶設定
                    WHERE (@關鍵字 IS NULL OR COMPANY LIKE '%' + @關鍵字 + '%')
                    ORDER BY COMPANY, 正航編號 DESC";
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    return conn.Query<零件單客戶篩選列表>(sql, new { 關鍵字 = keyword }).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        // ── 零件申請單總覽：比照原查詢，零件申請單 LEFT JOIN 零件申請明細 ───────
        public List<零件申請總覽列表> getMiscMfgOverviewList()
        {
            try
            {
                string sql = @"
                    SELECT H.單號, H.申請人, H.客戶簡稱, H.專案序號, H.機台型號, H.機台名稱, H.收費機制,
                           H.申請日期, H.客戶編號, H.申請用途, H.核准,
                           D.零件分類, D.零件號碼, D.品名, D.數量
                    FROM 零件申請單 H LEFT JOIN 零件申請明細 D ON H.單號 = D.單號
                    ORDER BY H.單號 DESC";
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    return conn.Query<零件申請總覽列表>(sql).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
