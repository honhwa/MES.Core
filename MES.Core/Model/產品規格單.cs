using System.ComponentModel.DataAnnotations;

namespace MES.Core.Model
{
    // ── 產品規格單：對應 PITS-2025.accdb「P-規格」表單(原巨集印出的報表名稱為
    //    「產品規格書」)。真實資料表 產品規格單 有 4 個欄位名稱含連字號/斜線
    //    (MQC-油壓委外單元、MQC-自動化程控、MQC-變壓器、IPQC-自主檢查、
    //    FQC-製成參數、OQC-出機檢查、I/O表)，C# 屬性無法使用該字元，故以底線
    //    命名，並在 Middle 層手動撰寫 INSERT/UPDATE SQL 對應真實欄位名稱 ──────
    public class 產品規格單
    {
        [Key]
        public string? 專案序號 { get; set; }
        public string? 專案負責人 { get; set; }
        public string? 客戶需求陳述 { get; set; }
        public string? 客製解決方法 { get; set; }
        public string? 驗收物件規格 { get; set; }
        public string? 驗收基本要求1 { get; set; }
        public string? 驗收基本要求2 { get; set; }
        public string? 客戶指定重點 { get; set; }
        public string? 驗收規範項目1 { get; set; }
        public string? 驗收規範說明1 { get; set; }
        public string? 驗收規範項目2 { get; set; }
        public string? 驗收規範說明2 { get; set; }
        public string? 驗收規範項目3 { get; set; }
        public string? 驗收規範說明3 { get; set; }
        public string? 驗收規範項目4 { get; set; }
        public string? 驗收規範說明4 { get; set; }
        public string? 驗收規範項目5 { get; set; }
        public string? 驗收規範說明5 { get; set; }
        public string? 驗收規範項目6 { get; set; }
        public string? 驗收規範說明6 { get; set; }
        public string? 補充說明 { get; set; }
        public string? 機台動作規劃1 { get; set; }
        public string? 機台動作規劃2 { get; set; }
        public string? 機台最大及最小能力 { get; set; }
        public string? 強度 { get; set; }
        public string? 尺寸 { get; set; }
        public string? 外觀 { get; set; }
        public string? MQC_油壓委外單元 { get; set; }
        public string? MQC_自動化程控 { get; set; }
        public string? MQC_變壓器 { get; set; }
        public string? IPQC_自主檢查 { get; set; }
        public string? FQC_製成參數 { get; set; }
        public string? OQC_出機檢查 { get; set; }
        public string? 建檔 { get; set; }
        public string? 修改 { get; set; }
        public string? 核准 { get; set; }
        public string? 建檔日 { get; set; }
        public string? 修改日 { get; set; }
        public string? 核准日 { get; set; }
        public string? 流程路徑圖 { get; set; }
        public string? IO表 { get; set; }
        public string? 電控迴路圖 { get; set; }
        public string? PLC階梯圖原始檔 { get; set; }
        public string? 人機介面原始檔 { get; set; }
        public string? 電控箱配置圖 { get; set; }
        public string? 電控用料表 { get; set; }
    }
}
