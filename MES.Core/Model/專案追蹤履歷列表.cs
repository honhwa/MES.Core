namespace MES.Core.Model
{
    // ── 專案追蹤履歷：對應 PITS-2025.accdb 查詢「專案追蹤履歷」，為
    //    專案管理紀錄明細 LEFT JOIN 專案管理紀錄表(依紀錄單號)，嵌入「P-會議」
    //    表單中央顯示的唯讀清單 ─────────────────────────────────────────
    public class 專案追蹤履歷列表
    {
        public string? 紀錄單號 { get; set; }
        public string? 日期 { get; set; }
        public string? 專案序號 { get; set; }
        public string? 紀錄類別 { get; set; }
        public string? 記錄人員 { get; set; }
        public string? 登載或注意事項 { get; set; }
        public string? 事項提議人 { get; set; }
        public string? 權責處理單位 { get; set; }
        public bool? 回報要求 { get; set; }
        public string? 應回報人員 { get; set; }
        public string? 預計回報日期 { get; set; }
        public string? 實際回報日期 { get; set; }
        public string? 回報說明 { get; set; }
        public bool? 管理者審閱 { get; set; }
        public string? 決議 { get; set; }
    }
}
