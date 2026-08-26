using Dapper;
using MES.Core.Model;
using MES.Core.Repository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace MES.WebAPI.MiddleWare
{
    // ── 專案會議履歷：對應 PITS-2025.accdb「P-會議」(Caption="專案會議履歷")
    //    及其「新增紀錄」按鈕開啟的「P-專案管理紀錄表」+ 子表單
    //    「P-專案管理紀錄明細」。查詢「專案追蹤履歷」為 專案管理紀錄明細
    //    LEFT JOIN 專案管理紀錄表(依紀錄單號) ──────────────────────────────
    public class ProjectMeetingMiddle
    {
        // ── P-會議 中央清單：依專案序號篩選 專案追蹤履歷 ─────────────────────
        public List<專案追蹤履歷列表> getMeetingTrackList(string projectNo)
        {
            try
            {
                string sql = @"
                    SELECT D.紀錄單號, M.日期, M.專案序號, M.紀錄類別, M.記錄人員,
                           D.登載或注意事項, D.事項提議人, D.權責處理單位, D.回報要求, D.應回報人員,
                           D.預計回報日期, D.實際回報日期, D.回報說明, D.管理者審閱, D.決議
                    FROM 專案管理紀錄明細 D
                    LEFT JOIN 專案管理紀錄表 M ON D.紀錄單號 = M.紀錄單號
                    WHERE M.專案序號=@專案序號
                    ORDER BY M.日期 DESC, D.識別碼";
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    return conn.Query<專案追蹤履歷列表>(sql, new { 專案序號 = projectNo }).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public 專案管理紀錄表 getMeetingRecord(string recordNo)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    return conn.QueryFirstOrDefault<專案管理紀錄表>(
                        "SELECT * FROM 專案管理紀錄表 WHERE 紀錄單號=@紀錄單號", new { 紀錄單號 = recordNo });
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int insertMeetingRecord(專案管理紀錄表 t)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    int exists = conn.ExecuteScalar<int>("SELECT COUNT(*) FROM 專案管理紀錄表 WHERE 紀錄單號=@紀錄單號", new { t.紀錄單號 });
                    if (exists > 0)
                    {
                        throw new Exception("紀錄單號「" + t.紀錄單號 + "」已存在，請重新輸入!");
                    }
                    return conn.Execute(
                        "INSERT INTO 專案管理紀錄表 (紀錄單號, 日期, 專案序號, 紀錄類別, 記錄人員, 備註) VALUES (@紀錄單號, @日期, @專案序號, @紀錄類別, @記錄人員, @備註)",
                        t);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int updateMeetingRecord(專案管理紀錄表 t)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    return conn.Execute(
                        "UPDATE 專案管理紀錄表 SET 日期=@日期, 紀錄類別=@紀錄類別, 記錄人員=@記錄人員, 備註=@備註 WHERE 紀錄單號=@紀錄單號",
                        t);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<專案管理紀錄明細> getMeetingDetailList(string recordNo)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    return conn.Query<專案管理紀錄明細>(
                        "SELECT * FROM 專案管理紀錄明細 WHERE 紀錄單號=@紀錄單號 ORDER BY 識別碼",
                        new { 紀錄單號 = recordNo }).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        // ── 儲存明細：先刪除該紀錄單號的全部舊紀錄再重新新增；識別碼非
        //    identity/PK，改於程式端自算遞增值 ─────────────────────────────
        public int saveMeetingDetailList(string recordNo, List<專案管理紀錄明細> list)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    using (var tran = conn.BeginTransaction())
                    {
                        int cnt = conn.Execute("DELETE FROM 專案管理紀錄明細 WHERE 紀錄單號=@紀錄單號", new { 紀錄單號 = recordNo }, tran);
                        int nextId = conn.ExecuteScalar<int?>("SELECT MAX(識別碼) FROM 專案管理紀錄明細", null, tran) ?? 0;
                        foreach (var item in list ?? new List<專案管理紀錄明細>())
                        {
                            nextId++;
                            item.識別碼 = nextId;
                            item.紀錄單號 = recordNo;
                            cnt += conn.Execute(@"
                                INSERT INTO 專案管理紀錄明細
                                (識別碼, 紀錄單號, 登載或注意事項, 事項提議人, 權責處理單位, 回報要求, 應回報人員, 預計回報日期, 實際回報日期, 回報說明, 管理者審閱, 決議)
                                VALUES
                                (@識別碼, @紀錄單號, @登載或注意事項, @事項提議人, @權責處理單位, @回報要求, @應回報人員, @預計回報日期, @實際回報日期, @回報說明, @管理者審閱, @決議)",
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

        // ── 專案待回報事項 (P-專案待回報事項)：跨全部專案彙總所有會議討論事項，
        //    篩選條件僅「登載或注意事項 Is Not Null」(非僅限尚未回覆者，忠實比照
        //    原查詢) ──────────────────────────────────────────────────
        public List<專案待回報事項列表> getPendingFeedbackList()
        {
            try
            {
                string sql = @"
                    SELECT M.紀錄單號, W.專案序號, W.訂單日期, W.客戶簡稱, W.機台類型, W.機台型號, W.驗機日期,
                           D.權責處理單位, D.登載或注意事項, D.決議, D.應回報人員, D.回報要求,
                           D.預計回報日期, D.實際回報日期
                    FROM (工令單 W LEFT JOIN 專案管理紀錄表 M ON W.專案序號 = M.專案序號)
                        LEFT JOIN 專案管理紀錄明細 D ON M.紀錄單號 = D.紀錄單號
                    WHERE D.登載或注意事項 IS NOT NULL
                    ORDER BY W.專案序號 DESC";
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    return conn.Query<專案待回報事項列表>(sql).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        // ── 事項提議人/應回報人員下拉：全部未停用之 account 帳號。原 Access
        //    RowSource 篩選條件為「停用 Is Null」，但 CHINYO 之 停用 欄位已migrate
        //    為 bit NOT NULL(僅 0/1，實際查無 NULL 值)，故改以 ISNULL(停用,0)=0
        //    對應「未停用」的真實語意 ──────────────────────────────────────
        public List<account> getActiveAccountList()
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    return conn.Query<account>("SELECT 帳號, 姓名 FROM account WHERE ISNULL(停用,0)=0 ORDER BY 姓名").ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
