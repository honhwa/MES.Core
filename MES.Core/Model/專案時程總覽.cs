namespace MES.Core.Model
{
    // ── 專案時程總覽：對應 PITS-2025.accdb「P-專案管制進度總覽」(Caption=
    //    "專案時程總覽")，RecordSource 為交叉資料表查詢「工令時程_交叉資料表」
    //    (工令時程表 依 工序代號 PIVOT，僅統合工段(A~E)五段，RIGHT JOIN 工令單
    //    取得全部專案，WHERE Left(專案序號,1)<>"G")。機台名稱/機台類型/訂單日期
    //    原表單另以 DLookUp(dbo_工令單) 取得，本畫面改為直接 JOIN 工令單 帶出 ──
    public class 專案時程總覽
    {
        public string? 專案序號 { get; set; }
        public string? 機台名稱 { get; set; }
        public string? 機台類型 { get; set; }
        public string? 訂單日期 { get; set; }
        public decimal? 合計預估工時 { get; set; }
        public decimal? A設計工時 { get; set; }
        public decimal? B加工工時 { get; set; }
        public decimal? C組裝工時 { get; set; }
        public decimal? D電控工時 { get; set; }
        public decimal? E試車工時 { get; set; }
    }
}
