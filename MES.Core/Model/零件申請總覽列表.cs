namespace MES.Core.Model
{
    // ── 零件申請單總覽：比照 PITS-2025.accdb「P-零件申請單總覽」(Caption=
    //    "零件申請總覽")，RecordSource 為 零件申請單 LEFT JOIN 零件申請明細 ──────
    public class 零件申請總覽列表
    {
        public string? 單號 { get; set; }
        public string? 申請人 { get; set; }
        public string? 客戶簡稱 { get; set; }
        public string? 專案序號 { get; set; }
        public string? 機台型號 { get; set; }
        public string? 機台名稱 { get; set; }
        public string? 收費機制 { get; set; }
        public string? 申請日期 { get; set; }
        public string? 客戶編號 { get; set; }
        public string? 申請用途 { get; set; }
        public string? 核准 { get; set; }
        public string? 零件分類 { get; set; }
        public string? 零件號碼 { get; set; }
        public string? 品名 { get; set; }
        public int? 數量 { get; set; }
    }
}
