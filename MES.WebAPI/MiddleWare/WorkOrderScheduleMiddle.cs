using Dapper;
using MES.Core.Model;
using MES.Core.Repository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace MES.WebAPI.MiddleWare
{
    // ── 工令時程：對應 PITS-2025.accdb「P-工令時程表」(Caption="機台管制表")
    //    及其內嵌子表單「P-工令時程明細」(RecordSource=dbo_工令時程表)。
    //    「日誌工時統計」對應「P-工令時程」表單，比較 工令時程表(預估) 與
    //    工作日誌/工作紀錄A(實際耗用) 兩邊工時；原巨集「專案工時查詢」之
    //    WHERE 條件為「任務分類<>"整機試車" OR 任務分類<>"機台驗收"」(恆真、
    //    形同無過濾，判斷為原設計錯誤，應為 AND，本次已修正為 NOT IN 排除
    //    試車/驗收工時，避免與 E 段(試車)重複計入) ─────────────────────────
    public class WorkOrderScheduleMiddle
    {
        public List<工令時程表> getScheduleList(string projectNo)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    string sql = @"
                        SELECT 識別碼, 專案序號, 工序代號, 預估工時, 工時成本, 起始日, 完成日,
                               執行單位, 建檔, 修改, 建檔日, 修改日
                        FROM 工令時程表 WHERE 專案序號=@專案序號 ORDER BY 起始日, 識別碼";
                    return conn.Query<工令時程表>(sql, new { 專案序號 = projectNo }).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int saveScheduleList(string projectNo, List<工令時程表> list)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    using (var tran = conn.BeginTransaction())
                    {
                        conn.Execute("DELETE FROM 工令時程表 WHERE 專案序號=@專案序號", new { 專案序號 = projectNo }, tran);
                        string insertSql = @"
                            INSERT INTO 工令時程表
                                (專案序號, 工序代號, 預估工時, 工時成本, 起始日, 完成日, 執行單位, 建檔, 修改, 建檔日, 修改日)
                            VALUES
                                (@專案序號, @工序代號, @預估工時, @工時成本, @起始日, @完成日, @執行單位, @建檔, @修改, @建檔日, @修改日)";
                        foreach (var d in list ?? new List<工令時程表>())
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

        // ── 工序代號下拉來源：比照 dbo_工序設定 ────────────────────────────────
        public List<工序設定> getProcedureList()
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    return conn.Query<工序設定>("SELECT 識別碼, 工序代號, 工序名稱, 統合工段, 隸屬單位 FROM 工序設定 ORDER BY 工序代號").ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        // ── 日誌工時統計：比照「P-工令時程」5段(A~E)預估/實際工時比較 ─────────────
        public List<工令時程統計> getHoursComparison(string projectNo)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    var est = conn.Query<PhaseSum>(
                        "SELECT 工序代號 AS Key1, CAST(SUM(預估工時) AS decimal(18,4)) AS Value1 FROM 工令時程表 WHERE 專案序號=@專案序號 AND 工序代號 IN ('A','B','C','D','E') GROUP BY 工序代號",
                        new { 專案序號 = projectNo }).ToDictionary(x => x.Key1, x => x.Value1 ?? 0m);

                    var actualByDuty = conn.Query<PhaseSum>(@"
                        SELECT L.職務 AS Key1, CAST(SUM(A.本日工時) AS decimal(18,4)) AS Value1
                        FROM 工作日誌 L LEFT JOIN 工作紀錄A A ON L.日誌單號 = A.日誌單號
                        WHERE A.專案序號=@專案序號 AND L.職務 IN ('設計','加工','組測','程控')
                          AND (A.任務分類 IS NULL OR A.任務分類 NOT IN ('整機試車','機台驗收'))
                        GROUP BY L.職務",
                        new { 專案序號 = projectNo }).ToDictionary(x => x.Key1, x => x.Value1 ?? 0m);

                    decimal actualE = conn.QueryFirstOrDefault<decimal?>(@"
                        SELECT SUM(A.本日工時)
                        FROM 工作日誌 L LEFT JOIN 工作紀錄A A ON L.日誌單號 = A.日誌單號
                        WHERE A.專案序號=@專案序號 AND A.任務分類 IN ('整機試車','機台驗收')",
                        new { 專案序號 = projectNo }) ?? 0m;

                    var phases = new (string Code, string Name, string Duty)[]
                    {
                        ("A", "設計", "設計"),
                        ("B", "加工", "加工"),
                        ("C", "組裝", "組測"),
                        ("D", "電控", "程控"),
                        ("E", "試車", null),
                    };

                    var result = new List<工令時程統計>();
                    foreach (var p in phases)
                    {
                        decimal estimated = est.TryGetValue(p.Code, out var e) ? e : 0m;
                        decimal actual = p.Duty == null ? actualE : (actualByDuty.TryGetValue(p.Duty, out var a) ? a : 0m);
                        result.Add(new 工令時程統計
                        {
                            工段代號 = p.Code,
                            工段名稱 = p.Name,
                            預估工時 = estimated,
                            耗用工時 = actual,
                            比率 = estimated == 0 ? (decimal?)null : Math.Round(actual / estimated, 4)
                        });
                    }
                    return result;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        // ── 專案時程總覽：比照「P-專案管制進度總覽」，交叉資料表查詢「工令時程_
        //    交叉資料表」(工令時程表 依工序代號 PIVOT A~E統合工段，RIGHT JOIN
        //    工令單 取得全部專案，排除專案序號開頭為"G"者) ─────────────────────
        public List<專案時程總覽> getProjectScheduleOverview()
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    var headers = conn.Query<專案時程總覽>(@"
                        SELECT 專案序號, 機台名稱, 機台類型, 訂單日期
                        FROM 工令單
                        WHERE LEFT(專案序號,1)<>'G'
                        ORDER BY 專案序號 DESC").ToList();

                    var phaseRows = conn.Query<PhaseRow>(@"
                        SELECT 專案序號 AS ProjectNo, 工序代號 AS Code, CAST(SUM(預估工時) AS decimal(18,4)) AS Hours
                        FROM 工令時程表
                        WHERE 工序代號 IN ('A','B','C','D','E')
                        GROUP BY 專案序號, 工序代號").ToList();

                    var lookup = phaseRows.ToLookup(x => x.ProjectNo);
                    foreach (var h in headers)
                    {
                        decimal a = 0, b = 0, c = 0, d = 0, e = 0;
                        foreach (var p in lookup[h.專案序號])
                        {
                            switch (p.Code)
                            {
                                case "A": a = p.Hours; break;
                                case "B": b = p.Hours; break;
                                case "C": c = p.Hours; break;
                                case "D": d = p.Hours; break;
                                case "E": e = p.Hours; break;
                            }
                        }
                        h.A設計工時 = a;
                        h.B加工工時 = b;
                        h.C組裝工時 = c;
                        h.D電控工時 = d;
                        h.E試車工時 = e;
                        h.合計預估工時 = a + b + c + d + e;
                    }
                    return headers;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        // ── 內部小型結果類別，用於 GROUP BY 彙總查詢的字典轉換 ──────────────────
        private class PhaseSum
        {
            public string Key1 { get; set; }
            public decimal? Value1 { get; set; }
        }

        private class PhaseRow
        {
            public string ProjectNo { get; set; }
            public string Code { get; set; }
            public decimal Hours { get; set; }
        }
    }
}
