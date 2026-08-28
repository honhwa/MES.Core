using System.ComponentModel.DataAnnotations;

namespace MES.Core.Model
{
    // ── 工令時程表：對應 PITS-2025.accdb「P-工令時程明細」子表單(嵌入於
    //    「P-工令時程表」，Caption誤植為"P-工程分析"，屬複製貼上殘留，實際
    //    RecordSource 為 dbo_工令時程表)。原表單另有 RSV1/RSV2 保留欄位未使用
    //    (略)。「執行人員」ComboBox 之 ControlSource 實際指向本欄位(執行單位)
    //    ，原表單存在同名之另一唯讀 DLookUp 顯示欄位(隸屬單位預覽)僅供UI提示、
    //    不寫入資料庫，本次未納入 ────────────────────────────────────────
    public class 工令時程表
    {
        [Key]
        public int 識別碼 { get; set; }
        public string? 專案序號 { get; set; }
        public string? 工序代號 { get; set; }
        public decimal? 預估工時 { get; set; }
        public decimal? 工時成本 { get; set; }
        public string? 起始日 { get; set; }
        public string? 完成日 { get; set; }
        public string? 執行單位 { get; set; }
        public string? 建檔 { get; set; }
        public string? 修改 { get; set; }
        public string? 建檔日 { get; set; }
        public string? 修改日 { get; set; }
    }
}
