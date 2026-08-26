namespace MES.Core.Model
{
    // ── 產品規格單總覽：比照 PITS-2025.accdb「P-規格總覽」，RecordSource 同「P-規
    //    格」之「產品規格查詢」(工令單 LEFT JOIN 產品規格單)，此列表另外把
    //    專案負責人(帳號)透過 account.帳號 轉出姓名顯示 ─────────────────────
    public class 產品規格總覽列表
    {
        public string? 專案序號 { get; set; }
        public string? 訂單日期 { get; set; }
        public string? 客戶簡稱 { get; set; }
        public string? 客戶名稱 { get; set; }
        public string? 機台類型 { get; set; }
        public string? 機台型號 { get; set; }
        public string? 機台名稱 { get; set; }
        public string? 專案負責人 { get; set; }
        public string? 核准 { get; set; }
        public string? 結案 { get; set; }
    }
}
