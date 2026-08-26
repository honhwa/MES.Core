using Dapper;
using MES.Core.Model;
using MES.Core.Repository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;

namespace MES.WebAPI.MiddleWare
{
    // ── 工令單總覽 / 工令單明細：比照 PITS-2025.accdb「P-工令單總覽」及其依機台類型
    //    (S&PJ/FB/GT/M/H) 分出的 5 個編輯畫面 P-工令單S&PJ、P-工令單FB、P-工令單GT、
    //    P-工令單M、P-工令單H。經比對確認 5 個畫面皆只是同一張 工令單 資料表(113
    //    欄位)不同欄位子集的版面配置，並無各自的明細子表，故此處以「單一資料表、
    //    單一編輯畫面」實作，不再依機台類型拆成 5 個獨立畫面。
    //    RecordSource 原查詢「工令單專案查詢」之 dbo_工令單 在 CHINYO 不存在，已依
    //    此專案慣例修正為 工令單。────────────────────────────────────────────
    public class WorkOrderMiddle
    {
        private static readonly PropertyInfo[] _props = typeof(工令單).GetProperties();
        private const string KeyCol = "專案序號";

        // ── 總覽清單：比照原查詢排除 備註="零件工令"(另有專屬零件申請單物件) 及
        //    專案序號開頭為"G"(機台類型 G 另由 P-工令單GT 維護)，並加上簡易查詢
        //    條件(專案序號/客戶簡稱/機台類型/僅顯示未結案)，原巨集無此查詢框，
        //    為方便維護大量資料而新增 ─────────────────────────────────────
        public List<工令單> getWorkOrderOverviewList(string projectNo, string custName, string machineType, bool onlyOpen)
        {
            var list = new List<工令單>();
            try
            {
                var where = new StringBuilder(" WHERE (備註<>N'零件工令' OR 備註 IS NULL) AND LEFT(專案序號,1)<>'G' ");
                var pars = new DynamicParameters();
                if (!string.IsNullOrWhiteSpace(projectNo))
                {
                    where.Append(" AND 專案序號 LIKE @projectNo ");
                    pars.Add("projectNo", "%" + projectNo.Trim() + "%");
                }
                if (!string.IsNullOrWhiteSpace(custName))
                {
                    where.Append(" AND (客戶簡稱 LIKE @custName OR 客戶名稱 LIKE @custName) ");
                    pars.Add("custName", "%" + custName.Trim() + "%");
                }
                if (!string.IsNullOrWhiteSpace(machineType))
                {
                    where.Append(" AND 機台類型=@machineType ");
                    pars.Add("machineType", machineType.Trim());
                }
                if (onlyOpen)
                {
                    where.Append(" AND (結案=0 OR 結案 IS NULL) ");
                }
                string sql = "SELECT * FROM 工令單 " + where + " ORDER BY 專案序號 DESC";
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    list = conn.Query<工令單>(sql, pars).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return list;
        }

        public 工令單 getWorkOrderByProjectNo(string projectNo)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    return conn.QueryFirstOrDefault<工令單>("SELECT * FROM 工令單 WHERE 專案序號=@專案序號", new { 專案序號 = projectNo });
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        // ── 新增機台專案：比照原巨集 Command66「直接新增機台專案」，Access 並無自動
        //    編號邏輯，專案序號由使用者自行輸入，故此處僅檢查是否重複 ───────────
        public int insertWorkOrder(工令單 t)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(t.專案序號))
                {
                    throw new Exception("專案序號不可空白!");
                }
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    int exists = conn.ExecuteScalar<int>("SELECT COUNT(*) FROM 工令單 WHERE 專案序號=@專案序號", new { t.專案序號 });
                    if (exists > 0)
                    {
                        throw new Exception("專案序號「" + t.專案序號 + "」已存在，請重新輸入!");
                    }
                    string colList = string.Join(",", _props.Select(p => "[" + p.Name + "]"));
                    string paramList = string.Join(",", _props.Select(p => "@" + p.Name));
                    string sql = $"INSERT INTO 工令單 ({colList}) VALUES ({paramList})";
                    return conn.Execute(sql, new DynamicParameters(t));
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        // ── 刪除工令單：比照原巨集 Command76「刪除工令單」，若 核准 已填(已生效核准)
        //    則不允許刪除 ───────────────────────────────────────────────
        public int updateWorkOrder(工令單 t)
        {
            try
            {
                string setClause = string.Join(",", _props.Where(p => p.Name != KeyCol).Select(p => "[" + p.Name + "]=@" + p.Name));
                string sql = $"UPDATE 工令單 SET {setClause} WHERE [{KeyCol}]=@{KeyCol}";
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    return conn.Execute(sql, new DynamicParameters(t));
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int deleteWorkOrder(string projectNo)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    string approved = conn.ExecuteScalar<string>("SELECT 核准 FROM 工令單 WHERE 專案序號=@專案序號", new { 專案序號 = projectNo });
                    if (!string.IsNullOrEmpty(approved))
                    {
                        throw new Exception("此工令單已經生效核准，無法刪除囉!");
                    }
                    return conn.Execute("DELETE FROM 工令單 WHERE 專案序號=@專案序號", new { 專案序號 = projectNo });
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        // ── 生效 (原"生效")：比照原巨集寫入 核准/核准日；原巨集另會檢查專案應收
        //    沖款是否已建立、若無則觸發「專案機台立帳」查詢自動建立應收帳款，
        //    本次簡化未實作此自動立帳流程 ──────────────────────────────────
        public int approveWorkOrder(string projectNo, string username)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    return conn.Execute(
                        "UPDATE 工令單 SET 核准=@核准, 核准日=@核准日 WHERE 專案序號=@專案序號",
                        new { 核准 = username, 核准日 = DateTime.Now.ToString("yyyy-MM-dd"), 專案序號 = projectNo });
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        // ── 取消生效 (原Command361)：清空 核准/核准日 ────────────────────────
        public int unapproveWorkOrder(string projectNo)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    return conn.Execute(
                        "UPDATE 工令單 SET 核准=NULL, 核准日=NULL WHERE 專案序號=@專案序號",
                        new { 專案序號 = projectNo });
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        // ── 結案：比照原巨集(專案序號 OnDblClick)，原本透過隱藏表單「P-規格」間接
        //    寫入 結案=Yes 再關閉存檔，此處簡化為直接 UPDATE ───────────────────
        public int closeWorkOrder(string projectNo, bool closed)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    return conn.Execute("UPDATE 工令單 SET 結案=@結案 WHERE 專案序號=@專案序號", new { 結案 = closed, 專案序號 = projectNo });
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        // ── 工程分析表總覽 (P-工程總覽)：原表單 RecordSource 直接就是 工令單，
        //    無任何 Filter/WHERE 篩選，故此處亦不加篩選(與工令單總覽/產品規格
        //    總覽刻意排除"G"開頭專案序號不同，此為忠實比照原表單) ─────────────
        public List<工令單> getEngineeringOverviewList()
        {
            try
            {
                string sql = @"
                    SELECT 專案序號, 訂單日期, 客戶簡稱, 客戶名稱, 國家地區, 機台類型, 機台型號, 機台名稱, 核准, 結案
                    FROM 工令單
                    ORDER BY 專案序號 DESC";
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    return conn.Query<工令單>(sql).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        // ── 工程分析表 (P-工程)：RecordSource 直接就是 工令單，畫面只多了
        //    建檔_工程/修改_工程/核准_工程 等簽核欄位，故不做全欄位覆寫，僅局部
        //    更新這 4 個欄位，避免誤清空其他業務欄位 ──────────────────────
        public int updateEngineeringAudit(string projectNo, string createdBy, string createdDate, string modifiedBy, string modifiedDate)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    return conn.Execute(
                        "UPDATE 工令單 SET 建檔_工程=@建檔_工程, 建檔日_工程=@建檔日_工程, 修改_工程=@修改_工程, 修改日_工程=@修改日_工程 WHERE 專案序號=@專案序號",
                        new { 建檔_工程 = createdBy, 建檔日_工程 = createdDate, 修改_工程 = modifiedBy, 修改日_工程 = modifiedDate, 專案序號 = projectNo });
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        // ── 工程分析表生效 (原"生效"，經 RunMacro 共用標準生效巨集寫入 核准_工程/
        //    核准日_工程)：另比照原巨集查詢「設計派案移轉」，將 工程分析表 中
        //    製圖>0 的模組(INNER JOIN 設計模組表 取檢查分類)一併轉入 設計派案，
        //    作為後續設計派工的依據 ──────────────────────────────────────
        public int approveEngineering(string projectNo, string username)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    string approved = conn.ExecuteScalar<string>("SELECT 核准_工程 FROM 工令單 WHERE 專案序號=@專案序號", new { 專案序號 = projectNo });
                    if (!string.IsNullOrEmpty(approved))
                    {
                        throw new Exception("抱歉：非經授權，不得進入！\n(已生效，請勿重複按下)");
                    }
                    using (var tran = conn.BeginTransaction())
                    {
                        int cnt = conn.Execute(
                            "UPDATE 工令單 SET 核准_工程=@核准_工程, 核准日_工程=@核准日_工程 WHERE 專案序號=@專案序號",
                            new { 核准_工程 = username, 核准日_工程 = DateTime.Now.ToString("yyyy-MM-dd"), 專案序號 = projectNo }, tran);

                        conn.Execute(@"
                            INSERT INTO 設計派案 (專案序號, 模組編碼, 模組名稱, 檢查分類, 製圖, 工程表識別碼)
                            SELECT E.專案序號, E.模組編碼, E.模組名稱, M.檢查分類, E.製圖,
                                   E.專案序號 + E.模組編碼 + CAST(E.識別碼 AS nvarchar(20))
                            FROM 設計模組表 M INNER JOIN 工程分析表 E ON M.模組名稱 = E.模組名稱
                            WHERE E.專案序號=@專案序號 AND E.製圖>0",
                            new { 專案序號 = projectNo }, tran);

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

        // ── 工程分析表取消生效：清空 核准_工程/核准日_工程；比照原巨集查詢「設計
        //    派案收回」，僅刪除尚未實際作業(製圖檔名/實際開工日/設變皆為空)的
        //    設計派案紀錄，避免刪掉已在進行中的設計工作 ────────────────────
        public int unapproveEngineering(string projectNo)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    using (var tran = conn.BeginTransaction())
                    {
                        int cnt = conn.Execute(
                            "UPDATE 工令單 SET 核准_工程=NULL, 核准日_工程=NULL WHERE 專案序號=@專案序號",
                            new { 專案序號 = projectNo }, tran);

                        conn.Execute(@"
                            DELETE FROM 設計派案
                            WHERE 專案序號=@專案序號 AND 製圖檔名 IS NULL AND 實際開工日 IS NULL AND 設變 IS NULL",
                            new { 專案序號 = projectNo }, tran);

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

        // ── 自訂單新增機台2025 (Command81 → P-專案機台一覽2025)：比照原
        //    RecordSource，列出 C訂單明細(dbo_D訂單明細) 中已填專案序號、訂單
        //    日期 700 天內、且尚未建立工令單(工令單.建檔 為 Null)者。
        //    dbo_D訂單明細→C訂單明細、dbo_D訂單→C訂單、dbo_CUST→C客戶設定，皆依
        //    此專案既有慣例(參照 SalesTrackingMiddle.cs)修正 ─────────────────
        public List<訂單機台候選> getUnconvertedOrderMachineList()
        {
            try
            {
                string sql = @"
                    SELECT 訂明.專案序號, 訂.日期 AS 訂單日期, 訂.客戶編號, 客.COMPANY AS 客戶名稱,
                           訂明.MTYPE AS 機台類型, 訂明.產品編號 AS 機台型號, 訂明.品名規格 AS 機台名稱
                    FROM (C訂單明細 訂明
                        LEFT JOIN C訂單 訂 ON 訂明.單號 = 訂.單號)
                        LEFT JOIN C客戶設定 客 ON 訂.客戶編號 = 客.正航編號
                        LEFT JOIN 工令單 W ON 訂明.專案序號 = W.專案序號
                    WHERE 訂明.專案序號 IS NOT NULL
                      AND 訂.日期 > DATEADD(day,-700,GETDATE())
                      AND W.建檔 IS NULL
                    ORDER BY 訂明.專案序號 DESC";
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    return conn.Query<訂單機台候選>(sql).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        // ── 轉開工令單 (Command1「轉開工令單」)：比照原查詢「成交機台轉工令2025」
        //    +「成交機台轉產規2025」，於同一交易內依序建立 工令單 及 產品規格單。
        //    原查詢未限制單一訂單明細，若同專案序號有多筆訂單明細(實際資料確實
        //    存在重複)，因 工令單.專案序號 為 PK，改取 TOP 1 避免主鍵衝突 ──────
        public int convertOrderMachineToWorkOrder(string projectNo, string username)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    using (var tran = conn.BeginTransaction())
                    {
                        string mtype = conn.ExecuteScalar<string>(
                            "SELECT TOP 1 MTYPE FROM C訂單明細 WHERE 專案序號=@專案序號", new { 專案序號 = projectNo }, tran);
                        if (string.IsNullOrEmpty(mtype))
                        {
                            throw new Exception("機台類型尚未指定，請回訂單輸入後再轉工令!");
                        }

                        int exists = conn.ExecuteScalar<int>(
                            "SELECT COUNT(*) FROM 工令單 WHERE 專案序號=@專案序號", new { 專案序號 = projectNo }, tran);
                        if (exists > 0)
                        {
                            throw new Exception("此專案序號已建立工令單，請勿重複轉入!");
                        }

                        string sqlWorkOrder = @"
                            INSERT INTO 工令單 (機台類型, 機台型號, 專案序號, 訂單日期, 客戶簡稱, 國家地區, 機台名稱, 客戶名稱)
                            SELECT TOP 1 訂明.MTYPE, 訂明.產品編號, 訂明.專案序號, 訂.日期, 訂.客戶編號, 客.COUNTRY, 訂明.品名規格, 客.COMPANY
                            FROM (C訂單明細 訂明
                                LEFT JOIN C訂單 訂 ON 訂明.單號 = 訂.單號)
                                LEFT JOIN C客戶設定 客 ON 訂.客戶編號 = 客.正航編號
                            WHERE 訂明.專案序號=@專案序號";
                        conn.Execute(sqlWorkOrder, new { 專案序號 = projectNo }, tran);

                        int specExists = conn.ExecuteScalar<int>(
                            "SELECT COUNT(*) FROM 產品規格單 WHERE 專案序號=@專案序號", new { 專案序號 = projectNo }, tran);
                        if (specExists == 0)
                        {
                            conn.Execute(
                                "INSERT INTO 產品規格單 (專案序號, 建檔, 建檔日) VALUES (@專案序號, @建檔, GETDATE())",
                                new { 專案序號 = projectNo, 建檔 = username }, tran);
                        }

                        tran.Commit();
                    }
                }
                return 1;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
