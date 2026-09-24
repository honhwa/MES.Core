using DigiERP.Common;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DigiERP.UserControl.Production.Spec
{
    // ── 產品規格單總覽：比照 PITS-2025.accdb「P-規格總覽」表單，純唯讀清單
    //    (原表單 AllowEdits/AllowAdditions 皆為 NotDefault)，RecordSource 同
    //    「P-規格」之「產品規格查詢」(工令單 LEFT JOIN 產品規格單，排除專案
    //    序號開頭為"G"者)。專案負責人欄位原以 DLookUp("姓名","dbo_account",
    //    "帳號='"&[專案負責人]&"'") 轉出姓名，已於後端 SQL 完成同等轉換。
    //    原巨集僅一顆 EXIT 按鈕，及 專案序號 欄位 OnDblClick 開啟 P-規格 ────
    public partial class ProductSpecListControl : CommonUserControl
    {
        private static string id = "8D859D48-720B-4ED4-803F-5373143E089B";

        public ProductSpecListControl()
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
            var rep = new ProductSpecController().GetProductSpecOverviewList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            dataGridView1.Rows.Clear();
            foreach (var x in rep.resultList ?? new List<產品規格總覽列表>())
            {
                int i = dataGridView1.Rows.Add();
                var row = dataGridView1.Rows[i];
                row.Cells[colProjectNo.Index].Value = x.專案序號;
                row.Cells[colOrderDate.Index].Value = ShortDate(x.訂單日期);
                row.Cells[colCustName.Index].Value = x.客戶簡稱;
                row.Cells[colCustFullName.Index].Value = x.客戶名稱;
                row.Cells[colMachineType.Index].Value = x.機台類型;
                row.Cells[colMachineModel.Index].Value = x.機台型號;
                row.Cells[colMachineName.Index].Value = x.機台名稱;
                row.Cells[colOwner.Index].Value = x.專案負責人;
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

        // ── 專案序號 OnDblClick：開啟(或切換至)產品規格單分頁 ─────────────────
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            string projectNo = dataGridView1.Rows[e.RowIndex].Cells[colProjectNo.Index].Value?.ToString();
            if (string.IsNullOrEmpty(projectNo)) return;

            if (!(Parent is TabPage) || !(((TabPage)Parent).Parent is TabControl))
            {
                var ctrlStandalone = new ProductSpecControl { Dock = DockStyle.Fill };
                ctrlStandalone.LoadData(projectNo);
                return;
            }
            TabControl tabControl = (TabControl)((TabPage)Parent).Parent;
            string tabName = "ProductSpec_" + projectNo;
            DigiERP.Common.TabNavigator.Open(tabControl, tabName, "產品規格單-" + projectNo, () =>
            {
                var ctrl = new ProductSpecControl { Dock = DockStyle.Fill };
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
