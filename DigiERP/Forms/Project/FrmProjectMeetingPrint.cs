using DigiERP.Forms.Reports;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DigiERP.Forms.Project
{
    // ── 專案會議紀錄列印預覽：比照 PITS-2025.accdb Report「專案管理紀錄表」
    //    (RecordSource= dbo_專案管理紀錄表 LEFT JOIN dbo_工令單 取得 客戶名稱/
    //    機台型號/機台類型/機台名稱，內嵌子報表 Report.專案管理紀錄明細)。資料
    //    來源沿用既有 ProjectMeetingController.GetMeetingRecord/
    //    GetMeetingDetailList，與 ProjectMeetingManagementControl 相同 ─────────
    public partial class FrmProjectMeetingPrint : DigiERP.Forms.CommonForm
    {
        private readonly string _recordNo;

        public FrmProjectMeetingPrint(string recordNo)
        {
            InitializeComponent();
            _recordNo = recordNo;
            initData();
        }

        private void initData()
        {
            var rep = new ProjectMeetingController().GetMeetingRecord(_recordNo);
            if (!string.IsNullOrEmpty(rep.ErrorMessage) || rep.result == null)
            {
                MessageBox.Show(string.IsNullOrEmpty(rep.ErrorMessage) ? "查無此會議紀錄資料!" : rep.ErrorMessage);
                return;
            }
            var m = rep.result;

            工令單 w = new 工令單();
            if (!string.IsNullOrEmpty(m.專案序號))
            {
                var woRep = new WorkOrderController().GetWorkOrderDetail(m.專案序號);
                if (string.IsNullOrEmpty(woRep.ErrorMessage) && woRep.result != null) w = woRep.result;
            }

            txt紀錄單號.Text = m.紀錄單號;
            txt日期.Text = ShortDate(m.日期);
            txt紀錄類別.Text = m.紀錄類別;
            txt記錄人員.Text = m.記錄人員;
            txt專案序號.Text = m.專案序號;
            txt備註.Text = m.備註;
            txt客戶名稱.Text = w.客戶名稱;
            txt機台型號.Text = w.機台型號;
            txt機台類型.Text = w.機台類型;
            txt機台名稱.Text = w.機台名稱;

            var detailRep = new ProjectMeetingController().GetMeetingDetailList(_recordNo);
            dataGridView1.Rows.Clear();
            if (string.IsNullOrEmpty(detailRep.ErrorMessage))
            {
                foreach (var x in detailRep.resultList ?? new List<專案管理紀錄明細>())
                {
                    int i = dataGridView1.Rows.Add();
                    var row = dataGridView1.Rows[i];
                    row.Cells[colAgenda.Index].Value = x.權責處理單位;
                    row.Cells[colProblem.Index].Value = x.登載或注意事項;
                    row.Cells[colConclusion.Index].Value = x.決議;
                    row.Cells[colOwner.Index].Value = x.應回報人員;
                    row.Cells[colReplyNeeded.Index].Value = x.回報要求 ?? false;
                    row.Cells[colExpDate.Index].Value = ShortDate(x.預計回報日期);
                    row.Cells[colActDate.Index].Value = ShortDate(x.實際回報日期);
                    row.Cells[colResult.Index].Value = x.回報說明;
                }
            }
        }

        private static string ShortDate(string dt)
        {
            if (string.IsNullOrWhiteSpace(dt)) return "";
            int sp = dt.IndexOf(' ');
            return sp > 0 ? dt.Substring(0, sp) : dt;
        }

        private void btnPreviewPrint_Click(object sender, EventArgs e)
        {
            ReportLayoutHelper.PreviewAndExportPdf(pnlContent, $"專案會議紀錄{_recordNo}_{DateTime.Now:yyyyMMddHHmmssfff}.pdf");
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
