namespace MES.Core.Model
{
    // ── 專案待回報事項：對應 PITS-2025.accdb 查詢「專案待回報事項」，為
    //    工令單 LEFT JOIN 專案管理紀錄表(依專案序號) LEFT JOIN 專案管理紀錄明細
    //    (依紀錄單號)，篩選條件僅「登載或注意事項 Is Not Null」，跨全部專案彙總
    //    顯示所有會議討論事項(非僅限單一專案) ────────────────────────────
    public class 專案待回報事項列表
    {
        // ── 紀錄單號：原查詢未 SELECT 此欄位(僅供畫面顯示用)，此處額外補上，
        //    供點選專案序號時定位回對應的會議紀錄(專案管理紀錄表) ──────────
        public string? 紀錄單號 { get; set; }
        public string? 專案序號 { get; set; }
        public string? 訂單日期 { get; set; }
        public string? 客戶簡稱 { get; set; }
        public string? 機台類型 { get; set; }
        public string? 機台型號 { get; set; }
        public string? 驗機日期 { get; set; }
        public string? 權責處理單位 { get; set; }
        public string? 登載或注意事項 { get; set; }
        public string? 決議 { get; set; }
        public string? 應回報人員 { get; set; }
        public bool? 回報要求 { get; set; }
        public string? 預計回報日期 { get; set; }
        public string? 實際回報日期 { get; set; }
    }
}
