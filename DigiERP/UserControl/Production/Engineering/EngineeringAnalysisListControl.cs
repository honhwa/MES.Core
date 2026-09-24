using DigiERP.Common;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DigiERP.UserControl.Production.Engineering
{
    // ── 工程分析表篩選單：比照 PITS-2025.accdb「P-工程總覽」表單，純唯讀清單
    //    (原表單 AllowEdits/AllowAdditions 皆為 NotDefault)。RecordSource 直接
    //    就是 工令單，且原表單無任何 Filter/WHERE 篩選(與工令單總覽/產品規格
    //    總覽刻意排除"G"開頭專案序號不同)，故此處忠實比照、不做篩選。
    //    「生效」欄位 ControlSource 為 核准(Format=Yes/No)，即工令單本身的
    //    業務核准狀態，並非 核准_工程；原巨集僅一顆 EXIT 按鈕，雙擊「專案序號」
    //    開啟 P-工程 ──────────────────────────────────────────────────
    public partial class EngineeringAnalysisListControl : CommonUserControl
    {
        private static string id = "94536306-165E-4091-9573-A4E75EBFD17A";

        public EngineeringAnalysisListControl()
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
            var rep = new WorkOrderController().GetEngineeringOverviewList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            dataGridView1.Rows.Clear();
            foreach (var x in rep.resultList ?? new List<工令單>())
            {
                int i = dataGridView1.Rows.Add();
                var row = dataGridView1.Rows[i];
                row.Cells[colProjectNo.Index].Value = x.專案序號;
                row.Cells[colOrderDate.Index].Value = ShortDate(x.訂單日期);
                row.Cells[colCustName.Index].Value = x.客戶簡稱;
                row.Cells[colCustFullName.Index].Value = x.客戶名稱;
                row.Cells[colCountry.Index].Value = x.國家地區;
                row.Cells[colMachineType.Index].Value = x.機台類型;
                row.Cells[colMachineModel.Index].Value = x.機台型號;
                row.Cells[colMachineName.Index].Value = x.機台名稱;
                row.Cells[colApprove.Index].Value = x.核准;
                row.Cells[colClosed.Index].Value = ToBool(x.結案);
            }
        }

        private static string ShortDate(string dt)
        {
            if (string.IsNullOrWhiteSpace(dt)) return "";
            int sp = dt.IndexOf(' ');
            return sp > 0 ? dt.Substring(0, sp) : dt;
        }

        private static bool ToBool(string v)
        {
            if (string.IsNullOrWhiteSpace(v)) return false;
            if (bool.TryParse(v, out bool b)) return b;
            return v == "1";
        }

        // ── 專案序號 OnDblClick：開啟(或切換至)工程分析表分頁 ─────────────────
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            string projectNo = dataGridView1.Rows[e.RowIndex].Cells[colProjectNo.Index].Value?.ToString();
            if (string.IsNullOrEmpty(projectNo)) return;

            if (!(Parent is TabPage) || !(((TabPage)Parent).Parent is TabControl))
            {
                var ctrlStandalone = new EngineeringAnalysisControl { Dock = DockStyle.Fill };
                ctrlStandalone.LoadData(projectNo);
                return;
            }
            TabControl tabControl = (TabControl)((TabPage)Parent).Parent;
            string tabName = "Engineering_" + projectNo;
            DigiERP.Common.TabNavigator.Open(tabControl, tabName, "工程分析表-" + projectNo, () =>
            {
                var ctrl = new EngineeringAnalysisControl { Dock = DockStyle.Fill };
                ctrl.LoadData(projectNo);
                return ctrl;
            });
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
