using Dapper;
using MES.Core.Model;
using MES.Core.Repository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace MES.WebAPI.MiddleWare
{
    // ── 工程分析表明細(子表單「P-工程分析」)：每個專案序號下各模組(A-Z)的預估
    //    工時拆解清單，嵌入「P-工程」表單中央。模組名稱下拉來源為 設計模組表，
    //    檢查分類為依模組名稱查表所得的顯示欄位(非本表儲存欄位) ──────────────
    public class EngineeringAnalysisMiddle
    {
        public List<工程分析表> getModuleList(string projectNo)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    return conn.Query<工程分析表>(
                        "SELECT * FROM 工程分析表 WHERE 專案序號=@專案序號 ORDER BY 模組編碼",
                        new { 專案序號 = projectNo }).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        // ── 模組名稱下拉來源：設計模組表 全部模組(含檢查分類，供查表顯示) ────────
        public List<設計模組表> getAllDesignModuleList()
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    return conn.Query<設計模組表>("SELECT * FROM 設計模組表 ORDER BY 模組名稱").ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        // ── 儲存：比照既有明細表慣例，先刪除該專案序號的全部舊紀錄再重新新增 ────
        public int saveModuleList(string projectNo, List<工程分析表> list)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    using (var tran = conn.BeginTransaction())
                    {
                        int cnt = conn.Execute("DELETE FROM 工程分析表 WHERE 專案序號=@專案序號", new { 專案序號 = projectNo }, tran);
                        foreach (var item in list ?? new List<工程分析表>())
                        {
                            item.專案序號 = projectNo;
                            cnt += conn.Execute(@"
                                INSERT INTO 工程分析表
                                (專案序號, 模組編碼, 模組名稱, 製作區分, 採購前置天數, 製圖, 加工, 組裝, 電控, 預估總工時)
                                VALUES
                                (@專案序號, @模組編碼, @模組名稱, @製作區分, @採購前置天數, @製圖, @加工, @組裝, @電控, @預估總工時)",
                                item, tran);
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
    }
}
