namespace MES.Core.Model
{
    // ── 工令時程統計：對應「P-工令時程」表單(Caption="工令時程"，畫面標題
    //    "工令時程預估工時與實際耗用工時比較表")。原表單以5組查詢(專案工段-A~E
    //    /專案工段總和-A~E)分別逐段DLookUp組合而成，本類別將5段結果統一為一份
    //    清單。工段代號 A~E 對應原表單 Label 顯示：A=設計,B=加工,C=組裝(職務=
    //    組測),D=電控(職務=程控),E=試車(任務分類=整機試車/機台驗收) ────────────
    public class 工令時程統計
    {
        public string? 工段代號 { get; set; }
        public string? 工段名稱 { get; set; }
        public decimal? 預估工時 { get; set; }
        public decimal? 耗用工時 { get; set; }
        public decimal? 比率 { get; set; }
    }
}
