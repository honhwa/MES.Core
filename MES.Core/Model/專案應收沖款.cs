using System.ComponentModel.DataAnnotations;

namespace MES.Core.Model
{
    // ── 專案應收沖款：對應 PITS-2025.accdb「S-專案應收沖款」表單(Caption=
    //    "專案應收沖款")。專案序號 為多型鍵，可能來自 工令單.專案序號(機台立帳)
    //    或 零件申請單.單號(零件立帳)，故機台類型/型號/名稱/客戶簡稱皆已直接
    //    存於本表，不需再關聯查詢。
    //    註：曾一度以 ALTER TABLE 補上 核准/核准日/建檔/建檔日/修改/修改日 欄位
    //    並提供生效/取消生效功能，惟資料表結構已變更、該6欄位已不存在，故本模
    //    型與相關 API、畫面皆已同步移除對應功能(不再提供生效/取消生效) ────────
    public class 專案應收沖款
    {
        [Key]
        public int 識別碼 { get; set; }
        public string? 專案序號 { get; set; }
        public string? 收款條件 { get; set; }
        public string? 幣別 { get; set; }
        public decimal? 合約報價 { get; set; }
        public decimal? 實際成交價 { get; set; }
        public decimal? 追加增減額 { get; set; }
        public decimal? 加購價1st { get; set; }
        public string? 報價單號1st { get; set; }
        public decimal? 加購價2nd { get; set; }
        public string? 報價單號2nd { get; set; }
        public decimal? 加購價3rd { get; set; }
        public string? 報價單號3rd { get; set; }
        public decimal? 應收款合計 { get; set; }
        public decimal? 報價設算匯率 { get; set; }
        public int? 專案營業額_台幣 { get; set; }
        public string? 往來銀行 { get; set; }
        public string? 收款帳戶 { get; set; }
        public decimal? 累計收款比例 { get; set; }
        public string? 類別 { get; set; }
        public string? 客戶簡稱 { get; set; }
        public string? 機台型號 { get; set; }
        public string? 機台類型 { get; set; }
        public string? 機台名稱 { get; set; }
    }
}
