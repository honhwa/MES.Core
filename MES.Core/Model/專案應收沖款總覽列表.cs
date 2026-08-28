namespace MES.Core.Model
{
    // ── 專案應收沖款總覽：對應 PITS-2025.accdb 查詢「專案應收沖款總覽追蹤」
    //    (專案應收沖款 LEFT JOIN 付款方式 ON 收款條件=條文編號 LEFT JOIN
    //    C客戶設定 ON 客戶簡稱=正航編號)。畫面上「收款條件」欄位實際顯示的是
    //    JOIN 帶出的 條文名稱(非代碼)，「客戶名稱」則為 COMPANY ─────────────
    public class 專案應收沖款總覽列表
    {
        public string? 專案序號 { get; set; }
        public string? 客戶簡稱 { get; set; }
        public string? 客戶名稱 { get; set; }
        public string? 機台型號 { get; set; }
        public string? 收款條件 { get; set; }
        public string? 幣別 { get; set; }
        public decimal? 應收款合計 { get; set; }
        public string? 往來銀行 { get; set; }
        public decimal? 累計收款比例 { get; set; }
    }
}
