namespace MES.Core.Model
{
    // ── 工序設定：對應「P-工令時程明細」子表單「工序代號」ComboBox 之
    //    RowSource(SELECT 工序代號,工序名稱,隸屬單位 FROM dbo_工序設定) ─────────
    public class 工序設定
    {
        public int 識別碼 { get; set; }
        public string? 工序代號 { get; set; }
        public string? 工序名稱 { get; set; }
        public bool? 統合工段 { get; set; }
        public string? 隸屬單位 { get; set; }
    }
}
