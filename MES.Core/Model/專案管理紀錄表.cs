using System.ComponentModel.DataAnnotations;

namespace MES.Core.Model
{
    // ── 專案管理紀錄表：對應 PITS-2025.accdb「P-專案管理紀錄表」(原「工令單」
    //    畫面「專案會議紀錄」按鈕開啟之「P-會議」表單中，按「新增紀錄」所開啟
    //    的會議紀錄主檔) ──────────────────────────────────────────────
    public class 專案管理紀錄表
    {
        [Key]
        public string? 紀錄單號 { get; set; }
        public string? 日期 { get; set; }
        public string? 專案序號 { get; set; }
        public string? 紀錄類別 { get; set; }
        public string? 記錄人員 { get; set; }
        public string? 備註 { get; set; }
    }
}
