using System.ComponentModel.DataAnnotations;

namespace MES.Core.Model
{
    // ── 專案管理紀錄明細：對應 PITS-2025.accdb「P-專案管理紀錄明細」子表單，
    //    嵌入「P-專案管理紀錄表」中，每筆為一項會議討論事項與其回覆追蹤狀態 ──
    public class 專案管理紀錄明細
    {
        [Key]
        public int 識別碼 { get; set; }
        public string? 紀錄單號 { get; set; }
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
