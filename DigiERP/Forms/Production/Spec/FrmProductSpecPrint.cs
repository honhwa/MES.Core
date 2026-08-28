using DigiERP.Forms.Reports;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DigiERP.Forms.Production.Spec
{
    // ── 產品規格書列印預覽：比照 PITS-2025.accdb Report「產品規格書」，其
    //    RecordSource 為查詢「產品規格查詢」(工令單 LEFT JOIN 產品規格單)。
    //    版面內容改用 ReportLayoutHelper 於執行期動態產生，理由與
    //    FrmWorkOrderPrint 相同(欄位/長文字區塊數量龐大)。「驗收規範項目/說明」
    //    共6組，比照原報表逐組並列呈現 ────────────────────────────────────
    public partial class FrmProductSpecPrint : DigiERP.Forms.CommonForm
    {
        private readonly string _projectNo;

        public FrmProductSpecPrint(string projectNo)
        {
            InitializeComponent();
            _projectNo = projectNo;
            BuildContent();
        }

        private void BuildContent()
        {
            var woRep = new WorkOrderController().GetWorkOrderDetail(_projectNo);
            工令單 w = (!string.IsNullOrEmpty(woRep.ErrorMessage) || woRep.result == null) ? new 工令單() : woRep.result;

            var specRep = new ProductSpecController().GetProductSpecDetail(_projectNo);
            if (!string.IsNullOrEmpty(specRep.ErrorMessage) || specRep.result == null)
            {
                MessageBox.Show(string.IsNullOrEmpty(specRep.ErrorMessage) ? "查無此產品規格單資料!" : specRep.ErrorMessage);
                return;
            }
            var s = specRep.result;

            lblTitle.Text = "產品規格書 － " + _projectNo;
            int width = pnlContent.Width;
            int y = 8;

            y = ReportLayoutHelper.AddSectionTitle(pnlContent, "基本資料", y, width);
            y = ReportLayoutHelper.AddFieldGrid(pnlContent, new List<(string, string)>
            {
                ("專案序號", w.專案序號), ("訂單日期", ShortDate(w.訂單日期)), ("PM", s.專案負責人),
                ("客戶簡稱", w.客戶簡稱), ("客戶名稱", w.客戶名稱), ("國家地區", w.國家地區),
                ("參考序號", w.參考序號), ("機台型號", w.機台型號), ("機台名稱", w.機台名稱),
                ("驗機日期", ShortDate(w.驗機日期)), ("交貨日期", ShortDate(w.交貨日期)), ("結案", w.結案),
            }, y, 3, 280);

            y = ReportLayoutHelper.AddSectionTitle(pnlContent, "交機／技術規格", y, width);
            y = ReportLayoutHelper.AddFieldGrid(pnlContent, new List<(string, string)>
            {
                ("廠驗", w.廠驗), ("裝機", w.裝機), ("生產速率", w.生產速率),
                ("安規要求", w.安規要求), ("圖面設計", w.圖面設計), ("電流", w.電流),
                ("焊接電壓", w.焊接電壓), ("焊接電壓V", w.焊接電壓v), ("焊接電壓HZ", w.焊接電壓hz),
                ("焊接物", w.焊接物),
            }, y, 3, 280);

            y = ReportLayoutHelper.AddSectionTitle(pnlContent, "客戶需求與解決方案", y, width);
            y = ReportLayoutHelper.AddLongTextBlock(pnlContent, "客戶需求陳述", s.客戶需求陳述, y, width);
            y = ReportLayoutHelper.AddLongTextBlock(pnlContent, "客製解決方法", s.客製解決方法, y, width);
            y = ReportLayoutHelper.AddLongTextBlock(pnlContent, "驗收物件規格", s.驗收物件規格, y, width);
            y = ReportLayoutHelper.AddLongTextBlock(pnlContent, "驗收基本要求1", s.驗收基本要求1, y, width);
            y = ReportLayoutHelper.AddLongTextBlock(pnlContent, "驗收基本要求2", s.驗收基本要求2, y, width);
            y = ReportLayoutHelper.AddLongTextBlock(pnlContent, "客戶指定重點", s.客戶指定重點, y, width);

            y = ReportLayoutHelper.AddSectionTitle(pnlContent, "驗收規範明細", y, width);
            y = ReportLayoutHelper.AddLongTextBlock(pnlContent, "驗收規範項目1：" + s.驗收規範項目1, s.驗收規範說明1, y, width);
            y = ReportLayoutHelper.AddLongTextBlock(pnlContent, "驗收規範項目2：" + s.驗收規範項目2, s.驗收規範說明2, y, width);
            y = ReportLayoutHelper.AddLongTextBlock(pnlContent, "驗收規範項目3：" + s.驗收規範項目3, s.驗收規範說明3, y, width);
            y = ReportLayoutHelper.AddLongTextBlock(pnlContent, "驗收規範項目4：" + s.驗收規範項目4, s.驗收規範說明4, y, width);
            y = ReportLayoutHelper.AddLongTextBlock(pnlContent, "驗收規範項目5：" + s.驗收規範項目5, s.驗收規範說明5, y, width);
            y = ReportLayoutHelper.AddLongTextBlock(pnlContent, "驗收規範項目6：" + s.驗收規範項目6, s.驗收規範說明6, y, width);

            y = ReportLayoutHelper.AddSectionTitle(pnlContent, "補充說明與機台規劃", y, width);
            y = ReportLayoutHelper.AddLongTextBlock(pnlContent, "補充說明", s.補充說明, y, width);
            y = ReportLayoutHelper.AddLongTextBlock(pnlContent, "機台動作規劃1", s.機台動作規劃1, y, width);
            y = ReportLayoutHelper.AddLongTextBlock(pnlContent, "機台動作規劃2", s.機台動作規劃2, y, width);
            y = ReportLayoutHelper.AddFieldGrid(pnlContent, new List<(string, string)>
            {
                ("機台最大及最小能力", s.機台最大及最小能力), ("強度", s.強度), ("尺寸", s.尺寸), ("外觀", s.外觀),
            }, y, 2, 420);

            y = ReportLayoutHelper.AddSectionTitle(pnlContent, "品保檢驗", y, width);
            y = ReportLayoutHelper.AddFieldGrid(pnlContent, new List<(string, string)>
            {
                ("MQC-油壓委外單元", s.MQC_油壓委外單元), ("MQC-自動化程控", s.MQC_自動化程控), ("MQC-變壓器", s.MQC_變壓器),
                ("IPQC-自主檢查", s.IPQC_自主檢查), ("FQC-製成參數", s.FQC_製成參數), ("OQC-出機檢查", s.OQC_出機檢查),
            }, y, 3, 280);

            y = ReportLayoutHelper.AddSectionTitle(pnlContent, "簽核紀錄", y, width);
            y = ReportLayoutHelper.AddFieldGrid(pnlContent, new List<(string, string)>
            {
                ("建檔", s.建檔), ("建檔日", ShortDate(s.建檔日)),
                ("修改", s.修改), ("修改日", ShortDate(s.修改日)),
                ("核准", s.核准), ("核准日", ShortDate(s.核准日)),
            }, y, 3, 280);

            pnlContent.Height = y + 10;
        }

        private static string ShortDate(string dt)
        {
            if (string.IsNullOrWhiteSpace(dt)) return "";
            int sp = dt.IndexOf(' ');
            return sp > 0 ? dt.Substring(0, sp) : dt;
        }

        private void btnPreviewPrint_Click(object sender, EventArgs e)
        {
            ReportLayoutHelper.PreviewAndExportPdf(pnlContent, $"產品規格書{_projectNo}_{DateTime.Now:yyyyMMddHHmmssfff}.pdf");
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            ReportLayoutHelper.PrintDirect(pnlContent);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
