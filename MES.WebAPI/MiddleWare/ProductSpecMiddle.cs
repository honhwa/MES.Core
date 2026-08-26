using Dapper;
using MES.Core.Model;
using MES.Core.Repository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace MES.WebAPI.MiddleWare
{
    // ── 產品規格單：對應 PITS-2025.accdb「P-規格」表單(列印報表名稱為「產品規格
    //    書」)。RecordSource 原查詢「產品規格查詢」為 工令單 LEFT JOIN 產品規格單
    //    (dbo_工令單/dbo_產品規格單 在 CHINYO 皆無 dbo_ 前綴)，畫面上半部為工令單
    //    唯讀參考欄位(已有 WorkOrderController.GetWorkOrderDetail 可重用)，本類別
    //    僅負責 產品規格單 本身的讀寫，以及 生效/取消生效 觸發的電控派案連動 ────
    public class ProductSpecMiddle
    {
        // ── 產品規格單總覽 (原巨集「總覽」→ P-規格總覽)：RecordSource 同「產品
        //    規格查詢」，排除專案序號開頭為"G"者；專案負責人(帳號)透過
        //    account.帳號 轉出姓名(比照 P-規格總覽 原欄位之 DLookUp("姓名",
        //    "dbo_account",...) 邏輯) ──────────────────────────────────
        public List<產品規格總覽列表> getProductSpecOverviewList()
        {
            try
            {
                string sql = @"
                    SELECT W.專案序號, W.訂單日期, W.客戶簡稱, W.客戶名稱, W.機台類型, W.機台型號, W.機台名稱,
                           A.姓名 AS 專案負責人, S.核准, W.結案
                    FROM 工令單 W
                    LEFT JOIN 產品規格單 S ON W.專案序號 = S.專案序號
                    LEFT JOIN account A ON S.專案負責人 = A.帳號
                    WHERE LEFT(W.專案序號,1)<>'G'
                    ORDER BY W.專案序號 DESC";
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    return conn.Query<產品規格總覽列表>(sql).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public 產品規格單 getProductSpecByProjectNo(string projectNo)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    string sql = @"
                        SELECT 專案序號, 專案負責人, 客戶需求陳述, 客製解決方法, 驗收物件規格,
                               驗收基本要求1, 驗收基本要求2, 客戶指定重點,
                               驗收規範項目1, 驗收規範說明1, 驗收規範項目2, 驗收規範說明2,
                               驗收規範項目3, 驗收規範說明3, 驗收規範項目4, 驗收規範說明4,
                               驗收規範項目5, 驗收規範說明5, 驗收規範項目6, 驗收規範說明6,
                               補充說明, 機台動作規劃1, 機台動作規劃2, 機台最大及最小能力,
                               強度, 尺寸, 外觀,
                               [MQC-油壓委外單元] AS MQC_油壓委外單元,
                               [MQC-自動化程控] AS MQC_自動化程控,
                               [MQC-變壓器] AS MQC_變壓器,
                               [IPQC-自主檢查] AS IPQC_自主檢查,
                               [FQC-製成參數] AS FQC_製成參數,
                               [OQC-出機檢查] AS OQC_出機檢查,
                               建檔, 修改, 核准, 建檔日, 修改日, 核准日, 流程路徑圖,
                               [I/O表] AS IO表, 電控迴路圖, PLC階梯圖原始檔, 人機介面原始檔, 電控箱配置圖, 電控用料表
                        FROM 產品規格單 WHERE 專案序號=@專案序號";
                    return conn.QueryFirstOrDefault<產品規格單>(sql, new { 專案序號 = projectNo });
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int insertProductSpec(產品規格單 t)
        {
            try
            {
                string sql = @"
                    INSERT INTO 產品規格單
                    (
                        專案序號, 專案負責人, 客戶需求陳述, 客製解決方法, 驗收物件規格,
                        驗收基本要求1, 驗收基本要求2, 客戶指定重點,
                        驗收規範項目1, 驗收規範說明1, 驗收規範項目2, 驗收規範說明2,
                        驗收規範項目3, 驗收規範說明3, 驗收規範項目4, 驗收規範說明4,
                        驗收規範項目5, 驗收規範說明5, 驗收規範項目6, 驗收規範說明6,
                        補充說明, 機台動作規劃1, 機台動作規劃2, 機台最大及最小能力,
                        強度, 尺寸, 外觀,
                        [MQC-油壓委外單元], [MQC-自動化程控], [MQC-變壓器],
                        [IPQC-自主檢查], [FQC-製成參數], [OQC-出機檢查],
                        建檔, 建檔日
                    )
                    VALUES
                    (
                        @專案序號, @專案負責人, @客戶需求陳述, @客製解決方法, @驗收物件規格,
                        @驗收基本要求1, @驗收基本要求2, @客戶指定重點,
                        @驗收規範項目1, @驗收規範說明1, @驗收規範項目2, @驗收規範說明2,
                        @驗收規範項目3, @驗收規範說明3, @驗收規範項目4, @驗收規範說明4,
                        @驗收規範項目5, @驗收規範說明5, @驗收規範項目6, @驗收規範說明6,
                        @補充說明, @機台動作規劃1, @機台動作規劃2, @機台最大及最小能力,
                        @強度, @尺寸, @外觀,
                        @MQC_油壓委外單元, @MQC_自動化程控, @MQC_變壓器,
                        @IPQC_自主檢查, @FQC_製成參數, @OQC_出機檢查,
                        @建檔, @建檔日
                    )";
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

        public int updateProductSpec(產品規格單 t)
        {
            try
            {
                string sql = @"
                    UPDATE 產品規格單 SET
                        專案負責人=@專案負責人, 客戶需求陳述=@客戶需求陳述, 客製解決方法=@客製解決方法,
                        驗收物件規格=@驗收物件規格, 驗收基本要求1=@驗收基本要求1, 驗收基本要求2=@驗收基本要求2,
                        客戶指定重點=@客戶指定重點,
                        驗收規範項目1=@驗收規範項目1, 驗收規範說明1=@驗收規範說明1,
                        驗收規範項目2=@驗收規範項目2, 驗收規範說明2=@驗收規範說明2,
                        驗收規範項目3=@驗收規範項目3, 驗收規範說明3=@驗收規範說明3,
                        驗收規範項目4=@驗收規範項目4, 驗收規範說明4=@驗收規範說明4,
                        驗收規範項目5=@驗收規範項目5, 驗收規範說明5=@驗收規範說明5,
                        驗收規範項目6=@驗收規範項目6, 驗收規範說明6=@驗收規範說明6,
                        補充說明=@補充說明, 機台動作規劃1=@機台動作規劃1, 機台動作規劃2=@機台動作規劃2,
                        機台最大及最小能力=@機台最大及最小能力, 強度=@強度, 尺寸=@尺寸, 外觀=@外觀,
                        [MQC-油壓委外單元]=@MQC_油壓委外單元, [MQC-自動化程控]=@MQC_自動化程控, [MQC-變壓器]=@MQC_變壓器,
                        [IPQC-自主檢查]=@IPQC_自主檢查, [FQC-製成參數]=@FQC_製成參數, [OQC-出機檢查]=@OQC_出機檢查,
                        修改=@修改, 修改日=@修改日
                    WHERE 專案序號=@專案序號";
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

        // ── 生效：寫入 核准/核准日；比照原巨集另呼叫「專案電控派案」查詢，依
        //    設計模組表 檢查分類="電控" 的每個模組名稱，於 專案電控排程 建立一筆
        //    待派工紀錄(與 ProgramControlListControl 共用同一張表) ─────────────
        public int approveProductSpec(string projectNo, string username)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    string approved = conn.ExecuteScalar<string>("SELECT 核准 FROM 產品規格單 WHERE 專案序號=@專案序號", new { 專案序號 = projectNo });
                    if (!string.IsNullOrEmpty(approved))
                    {
                        throw new Exception("提醒您集中精神\n(已經生效,您按錯囉!)");
                    }
                    using (var tran = conn.BeginTransaction())
                    {
                        int cnt = conn.Execute(
                            "UPDATE 產品規格單 SET 核准=@核准, 核准日=@核准日 WHERE 專案序號=@專案序號",
                            new { 核准 = username, 核准日 = DateTime.Now.ToString("yyyy-MM-dd"), 專案序號 = projectNo }, tran);

                        conn.Execute(@"
                            INSERT INTO 專案電控排程 (電控工序, 專案序號)
                            SELECT 模組名稱, @專案序號 FROM 設計模組表 WHERE 檢查分類=N'電控'",
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

        // ── 取消生效：清空 核准/核准日；比照原巨集另呼叫「電控排程收回」查詢，
        //    刪除該專案序號的全部 專案電控排程 紀錄 ────────────────────────
        public int unapproveProductSpec(string projectNo)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    using (var tran = conn.BeginTransaction())
                    {
                        int cnt = conn.Execute(
                            "UPDATE 產品規格單 SET 核准=NULL, 核准日=NULL WHERE 專案序號=@專案序號",
                            new { 專案序號 = projectNo }, tran);
                        conn.Execute("DELETE FROM 專案電控排程 WHERE 專案序號=@專案序號", new { 專案序號 = projectNo }, tran);
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
    }
}
