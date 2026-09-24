using DigiERP.Common;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DigiERP.UserControl.Order
{
    // ── 專案時程總覽：比照 PITS-2025.accdb「P-專案管制進度總覽」，由「P-工令
    //    時程表」(WorkOrderScheduleControl)「總覽」按鈕開啟(原巨集 Command
    //    「總覽」，先前系統缺漏此頁面，本次新建)。RecordSource 為交叉資料表
    //    查詢「工令時程_交叉資料表」，列出全部專案(排除專案序號開頭為"G"者)之
    //    A~E統合工段(設計/加工/組裝/電控/試車)預估工時，並帶出機台名稱/類型/
    //    開單日期。雙擊「專案序號」比照原表單 OnDblClick 巨集，開啟(唯讀切換
    //    至)該專案的 WorkOrderScheduleControl ───────────────────────────────
    public partial class ProjectScheduleListControl : CommonUserControl
    {
        private static string id = "39C352BC-3A38-40AB-9E6B-4CA0681614BF";

        public ProjectScheduleListControl()
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

        public void LoadData()
        {
            var rep = new WorkOrderScheduleController().GetProjectScheduleOverview();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }

            dataGridView1.Rows.Clear();
            foreach (var x in rep.resultList ?? new List<專案時程總覽>())
            {
                int r = dataGridView1.Rows.Add();
                var row = dataGridView1.Rows[r];
                row.Cells[colProjectNo.Index].Value = x.專案序號;
                row.Cells[colMachineName.Index].Value = x.機台名稱;
                row.Cells[colMachineType.Index].Value = x.機台類型;
                row.Cells[colOrderDate.Index].Value = ShortDate(x.訂單日期);
                row.Cells[colSumHours.Index].Value = x.合計預估工時;
                row.Cells[colA.Index].Value = x.A設計工時;
                row.Cells[colB.Index].Value = x.B加工工時;
                row.Cells[colC.Index].Value = x.C組裝工時;
                row.Cells[colD.Index].Value = x.D電控工時;
                row.Cells[colE.Index].Value = x.E試車工時;
            }
        }

        private static string ShortDate(string dt)
        {
            if (string.IsNullOrWhiteSpace(dt)) return "";
            int sp = dt.IndexOf(' ');
            return sp > 0 ? dt.Substring(0, sp) : dt;
        }

        // ── 雙擊專案序號：比照原表單 OnDblClick 巨集，開啟(或切換至)既有
        //    WorkOrderScheduleControl(該專案，唯讀帶入) ─────────────────────
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            string projectNo = dataGridView1.Rows[e.RowIndex].Cells[colProjectNo.Index].Value?.ToString();
            if (string.IsNullOrEmpty(projectNo)) return;

            OpenInTab("WorkOrderSchedule_" + projectNo, projectNo + " 機台管制表",
                () => { var ctrl = new WorkOrderScheduleControl { Dock = DockStyle.Fill }; ctrl.LoadData(projectNo); return ctrl; });
        }

        // ── 共用：於同一 TabControl 開啟(或切換至)指定名稱的分頁。關閉時自動切回
        //    開啟當下所在的來源分頁，邏輯見 DigiERP.Common.TabNavigator ────────
        private void OpenInTab(string tabName, string tabTitle, Func<Control> createControl)
        {
            if (!(Parent is TabPage) || !(((TabPage)Parent).Parent is TabControl))
            {
                var standalone = createControl();
                standalone.Dock = DockStyle.Fill;
                return;
            }
            TabControl tabControl = (TabControl)((TabPage)Parent).Parent;
            DigiERP.Common.TabNavigator.Open(tabControl, tabName, tabTitle, createControl);
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
