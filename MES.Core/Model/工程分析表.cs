using System.ComponentModel.DataAnnotations;

namespace MES.Core.Model
{
    // ── 工程分析表：對應 PITS-2025.accdb「P-工程分析」表單(以子表單方式嵌入
    //    「P-工程」表單中央的模組工時清單)。每筆為一個模組(模組編碼A-Z)在該
    //    專案下的預估工時拆解，供 生效 時轉入 設計派案 派工使用 ─────────────
    public class 工程分析表
    {
        [Key]
        public int 識別碼 { get; set; }
        public string? 專案序號 { get; set; }
        public string? 模組編碼 { get; set; }
        public string? 模組名稱 { get; set; }
        public string? 製作區分 { get; set; }
        public int? 採購前置天數 { get; set; }
        public decimal? 製圖 { get; set; }
        public decimal? 加工 { get; set; }
        public decimal? 組裝 { get; set; }
        public decimal? 電控 { get; set; }
        public decimal? 預估總工時 { get; set; }
        public bool? 設計派工 { get; set; }
    }
}
