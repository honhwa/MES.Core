namespace MES.Core.Model
{
    // ── 自訂單新增機台2025：比照 PITS-2025.accdb「P-專案機台一覽2025」，列出業務
    //    訂單明細(C訂單明細)中已填專案序號、但尚未建立工令單者，供轉開工令單用 ──
    public class 訂單機台候選
    {
        public string? 專案序號 { get; set; }
        public string? 訂單日期 { get; set; }
        public string? 客戶編號 { get; set; }
        public string? 客戶名稱 { get; set; }
        public string? 機台類型 { get; set; }
        public string? 機台型號 { get; set; }
        public string? 機台名稱 { get; set; }
    }
}
