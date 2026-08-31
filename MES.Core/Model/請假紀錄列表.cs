namespace MES.Core.Model
{
    // ── 請假紀錄列表：對應 PITS-2025.accdb 查詢「請假紀錄查詢」(H請假紀錄
    //    LEFT JOIN H員工清冊 ON 員工編號=工號)，供「H-日曆休假表」內嵌子表單
    //    「H-請假紀錄查詢」依日期查詢。請假扣款乘數=事假+病假(比照原查詢計算
    //    欄位，命名雖為"乘數"但實際僅為兩者相加，維持原樣) ─────────────────
    public class 請假紀錄列表
    {
        public string? 日期 { get; set; }
        public string? 員工編號 { get; set; }
        public string? 姓名 { get; set; }
        public float? 事假 { get; set; }
        public float? 病假 { get; set; }
        public float? 特休假 { get; set; }
        public float? 產假 { get; set; }
        public float? 公假 { get; set; }
        public float? 生理假 { get; set; }
        public float? 親情假 { get; set; }
        public float? 曠職 { get; set; }
        public string? 備註 { get; set; }
        public float? 請假扣款乘數 { get; set; }
    }
}
