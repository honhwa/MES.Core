namespace MES.Core.Model
{
    // ── 零件單客戶篩選：比照 PITS-2025.accdb 查詢「零件單客戶篩選」，來源為
    //    C客戶設定(dbo_CUST)，篩="成交"表示正航編號已建檔，"未成交"則否 ────────
    public class 零件單客戶篩選列表
    {
        public string? COMPANY { get; set; }
        public string? 正航編號 { get; set; }
        public string? 篩 { get; set; }
    }
}
