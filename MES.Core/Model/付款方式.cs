namespace MES.Core.Model
{
    // ── 付款方式：對應 S-專案應收沖款「收款條件」ComboBox 之 RowSource
    //    (SELECT 條文編號, 條文名稱 FROM dbo_付款方式)。專案應收沖款.收款條件
    //    欄位實際存放「條文編號」(代碼)，畫面顯示則另由 DLookUp 帶出「條文名稱」──
    public class 付款方式
    {
        public int 識別碼 { get; set; }
        public string? 條文編號 { get; set; }
        public string? 條文名稱 { get; set; }
    }
}
