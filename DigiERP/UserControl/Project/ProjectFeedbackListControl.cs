using DigiERP.Common;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DigiERP.UserControl.Project
{
    // ── 專案待回報事項：比照 PITS-2025.accdb「P-專案待回報事項」表單(Caption=
    //    "待回報事項")。純唯讀清單(原表單 AllowEdits/AllowAdditions/
    //    AllowDeletions皆關閉)，RecordSource 為查詢「專案待回報事項」= 工令單
    //    LEFT JOIN 專案管理紀錄表(依專案序號) LEFT JOIN 專案管理紀錄明細(依紀錄
    //    單號)，篩選條件僅「登載或注意事項 Is Not Null」，跨全部專案彙總顯示。
    //    原巨集僅一顆「關閉」按鈕；原巨集雙擊「專案序號」開啟該專案的會議履歷
    //    (P-會議)，此處依需求改為直接開啟該筆紀錄單號對應的
    //    ProjectMeetingManagementControl(P-專案管理紀錄表明細編輯畫面)，
    //    直接帶出該專案序號的會議資料 ────────────────────────────────────
    public partial class ProjectFeedbackListControl : CommonUserControl
    {
        private static string id = "431CABA2-4C63-440C-8005-66AAEA04049B";

        public ProjectFeedbackListControl()
        {
            if (!chkPrivilege(id))
            {
                MessageBox.Show("非授權使用者無法使用此功能!");
                Dispose();
                return;
            }
            InitializeComponent();
            DigiERP.Common.UIStyle.ApplyControlStyle(this);
            LoadData();
        }

        private void LoadData()
        {
            var rep = new ProjectMeetingController().GetPendingFeedbackList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            dataGridView1.Rows.Clear();
            foreach (var x in rep.resultList ?? new List<專案待回報事項列表>())
            {
                int i = dataGridView1.Rows.Add();
                var row = dataGridView1.Rows[i];
                row.Cells[colRecordNo.Index].Value = x.紀錄單號;
                row.Cells[colProjectNo.Index].Value = x.專案序號;
                row.Cells[colOrderDate.Index].Value = ShortDate(x.訂單日期);
                row.Cells[colCustName.Index].Value = x.客戶簡稱;
                row.Cells[colMachineType.Index].Value = x.機台類型;
                row.Cells[colMachineModel.Index].Value = x.機台型號;
                row.Cells[colTestDate.Index].Value = ShortDate(x.驗機日期);
                row.Cells[colOwnerUnit.Index].Value = x.權責處理單位;
                row.Cells[colTopic.Index].Value = x.登載或注意事項;
                row.Cells[colResolution.Index].Value = x.決議;
                row.Cells[colReplyPerson.Index].Value = x.應回報人員;
                row.Cells[colNeedReply.Index].Value = x.回報要求 ?? false;
                row.Cells[colExpectDate.Index].Value = ShortDate(x.預計回報日期);
                row.Cells[colActualDate.Index].Value = ShortDate(x.實際回報日期);
            }
        }

        private static string ShortDate(string dt)
        {
            if (string.IsNullOrWhiteSpace(dt)) return "";
            int sp = dt.IndexOf(' ');
            return sp > 0 ? dt.Substring(0, sp) : dt;
        }

        // ── 專案序號點選：直接開啟(或切換至)該筆紀錄單號對應的
        //    ProjectMeetingManagementControl，帶出該專案序號的會議資料 ─────────
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dataGridView1.Columns[e.ColumnIndex] != colProjectNo) return;
            string projectNo = dataGridView1.Rows[e.RowIndex].Cells[colProjectNo.Index].Value?.ToString();
            string recordNo = dataGridView1.Rows[e.RowIndex].Cells[colRecordNo.Index].Value?.ToString();
            if (string.IsNullOrEmpty(projectNo)) return;

            if (!(Parent is TabPage) || !(((TabPage)Parent).Parent is TabControl))
            {
                var ctrlStandalone = new ProjectMeetingManagementControl { Dock = DockStyle.Fill };
                ctrlStandalone.LoadData(projectNo, recordNo);
                return;
            }
            TabControl tabControl = (TabControl)((TabPage)Parent).Parent;
            string tabName = string.IsNullOrEmpty(recordNo) ? "MeetingMgmt_NEW_" + projectNo : "MeetingMgmt_" + recordNo;
            foreach (TabPage page in tabControl.TabPages)
            {
                if (page.Name == tabName)
                {
                    tabControl.SelectedTab = page;
                    return;
                }
            }
            var ctrl = new ProjectMeetingManagementControl { Dock = DockStyle.Fill };
            var tab = new TabPage("會議紀錄-" + (string.IsNullOrEmpty(recordNo) ? projectNo : recordNo)) { Name = tabName };
            tab.Controls.Add(ctrl);
            tabControl.TabPages.Add(tab);
            tabControl.SelectedTab = tab;
            ctrl.LoadData(projectNo, recordNo);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var parentCtrl = Parent;
            if (parentCtrl is TabPage tabPage && tabPage.Parent is TabControl tabControl)
            {
                tabControl.TabPages.Remove(tabPage);
                Dispose();
                return;
            }
            if (parentCtrl != null)
            {
                parentCtrl.Controls.Remove(this);
            }
            Dispose();
        }
    }
}
