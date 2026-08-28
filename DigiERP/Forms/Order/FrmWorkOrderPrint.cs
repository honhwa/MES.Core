using DigiERP.Forms.Reports;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DigiERP.Forms.Order
{
    // ── 工令單列印預覽：比照 PITS-2025.accdb Report「工令單內容-H」，其
    //    RecordSource 為查詢「工令單內容-Others」(工令單 LEFT JOIN 產品規格單
    //    WHERE 機台類型="H")。因欄位數量龐大(60餘個技術規格欄位)，改用
    //    ReportLayoutHelper 於執行期動態產生「標題:唯讀值」網格，而非逐一在
    //    Designer.cs 手刻座標。PM 欄位原為 DLookUp("姓名","dbo_account",
    //    "帳號 = " & 專案負責人) 之計算欄位，惟本系統之 產品規格單.專案負責人
    //    已直接存放姓名(而非帳號，見 ProductSpecControl.cmb_專案負責人 之綁定
    //    方式)，故此處直接取用，不再另行查表 ────────────────────────────────
    public partial class FrmWorkOrderPrint : DigiERP.Forms.CommonForm
    {
        private readonly string _projectNo;

        public FrmWorkOrderPrint(string projectNo)
        {
            InitializeComponent();
            _projectNo = projectNo;
            BuildContent();
        }

        private void BuildContent()
        {
            var rep = new WorkOrderController().GetWorkOrderDetail(_projectNo);
            if (!string.IsNullOrEmpty(rep.ErrorMessage) || rep.result == null)
            {
                MessageBox.Show(string.IsNullOrEmpty(rep.ErrorMessage) ? "查無此工令單資料!" : rep.ErrorMessage);
                return;
            }
            var m = rep.result;

            string pm = "";
            var specRep = new ProductSpecController().GetProductSpecDetail(_projectNo);
            if (string.IsNullOrEmpty(specRep.ErrorMessage) && specRep.result != null)
            {
                pm = specRep.result.專案負責人;
            }

            lblTitle.Text = "工令單 － " + m.專案序號;
            int width = pnlContent.Width;
            int y = 8;

            y = ReportLayoutHelper.AddSectionTitle(pnlContent, "基本資料", y, width);
            y = ReportLayoutHelper.AddFieldGrid(pnlContent, new List<(string, string)>
            {
                ("專案序號", m.專案序號), ("訂單日期", ShortDate(m.訂單日期)), ("PM", pm),
                ("客戶簡稱", m.客戶簡稱), ("客戶名稱", m.客戶名稱), ("國家地區", m.國家地區),
                ("參考序號", m.參考序號), ("機台型號", m.機台型號), ("機台名稱", m.機台名稱),
                ("驗機日期", ShortDate(m.驗機日期)), ("交貨日期", ShortDate(m.交貨日期)), ("結案", m.結案),
            }, y, 3, 280);

            y = ReportLayoutHelper.AddSectionTitle(pnlContent, "交機／品保", y, width);
            y = ReportLayoutHelper.AddFieldGrid(pnlContent, new List<(string, string)>
            {
                ("廠驗", m.廠驗), ("裝機", m.裝機), ("生產速率", m.生產速率),
                ("安規要求", m.安規要求), ("圖面設計", m.圖面設計), ("顏色", m.顏色),
            }, y, 3, 280);

            y = ReportLayoutHelper.AddSectionTitle(pnlContent, "電氣規格", y, width);
            y = ReportLayoutHelper.AddFieldGrid(pnlContent, new List<(string, string)>
            {
                ("電流", m.電流), ("焊接電壓", m.焊接電壓), ("焊接電壓V", m.焊接電壓v),
                ("焊接電壓HZ", m.焊接電壓hz), ("焊接物", m.焊接物), ("變壓器數量", m.變壓器數量),
            }, y, 3, 280);

            y = ReportLayoutHelper.AddSectionTitle(pnlContent, "機構／電控配置", y, width);
            y = ReportLayoutHelper.AddFieldGrid(pnlContent, new List<(string, string)>
            {
                ("操作控制箱", m.操作控制箱), ("操作控制箱ps", m.操作控制箱ps), ("三點組合", m.三點組合),
                ("PLC控制器", m.PLC控制器), ("入力線方向", m.入力線方向), ("焊接控制器Y13", m.焊接控制器Y13),
                ("安全光照簾", m.安全光照簾), ("安全光照簾ps", m.安全光照簾ps), ("安全柵欄", m.安全柵欄),
                ("安全門火花檔板", m.安全門火花檔板), ("蜂鳴器", m.蜂鳴器), ("無熔絲開關", m.無熔絲開關),
                ("無熔絲開關ps", m.無熔絲開關ps), ("三色燈", m.三色燈), ("三色燈ps", m.三色燈ps),
                ("水流浮球", m.水流浮球), ("水流水壓", m.水流水壓), ("冰水機/熱交換器", m.冰水機_熱交換器),
                ("馬達", m.馬達), ("馬達ps", m.馬達ps), ("啟動方式", m.啟動方式),
                ("啟動方式ps", m.啟動方式ps), ("其他氣缸電磁閥", m.其他氣缸電磁閥), ("其他氣缸", m.其他氣缸),
                ("風壓壓力開關", m.風壓壓力開關), ("壓力比例閥", m.壓力比例閥), ("氣壓配管", m.氣壓配管),
                ("空氣儲存桶", m.空氣儲存桶), ("空氣儲存桶ps", m.空氣儲存桶ps), ("人機介面", m.人機介面),
                ("人機介面ps", m.人機介面ps),
            }, y, 3, 280);

            y = ReportLayoutHelper.AddSectionTitle(pnlContent, "說明／備註", y, width);
            y = ReportLayoutHelper.AddLongTextBlock(pnlContent, "說明", m.說明, y, width);
            y = ReportLayoutHelper.AddLongTextBlock(pnlContent, "備註", m.備註, y, width);

            y = ReportLayoutHelper.AddSectionTitle(pnlContent, "簽核紀錄", y, width);
            y = ReportLayoutHelper.AddFieldGrid(pnlContent, new List<(string, string)>
            {
                ("建檔", m.建檔), ("建檔日", ShortDate(m.建檔日)),
                ("修改", m.修改), ("修改日", ShortDate(m.修改日)),
                ("核准", m.核准), ("核准日", ShortDate(m.核准日)),
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
            ReportLayoutHelper.PreviewAndExportPdf(pnlContent, $"工令單{_projectNo}_{DateTime.Now:yyyyMMddHHmmssfff}.pdf");
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
