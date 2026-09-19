using DigiERP.Common;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DigiERP.UserControl.Production.Accessories
{
    // ── 零件申請單總覽：比照 PITS-2025.accdb「P-零件申請單總覽」(Caption="零件
    //    申請總覽")，純唯讀清單。原表單有 專案序號/客戶名稱/申請日期/申請人/
    //    品名 5 個篩選文字框，各自 AfterUpdate 重新查詢；此處簡化為 3 個常用篩
    //    選(專案序號/客戶名稱/品名)，載入全部清單後於畫面端即時篩選，並提供
    //    「清除篩選」按鈕。雙擊「單號」開啟(或切換至)該筆零件申請單分頁 ────────
    public partial class AccessoriesApplyListControl : CommonUserControl
    {
        private static string id = "3496AA86-54B0-4D92-8DC9-F6BAA614C01C";

        private List<零件申請總覽列表> _allRows = new List<零件申請總覽列表>();

        public AccessoriesApplyListControl()
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
            var rep = new MfgController().GetMiscMfgOverviewList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            _allRows = rep.resultList ?? new List<零件申請總覽列表>();
            ApplyFilter();
        }

        private void ApplyFilter()
        {
            IEnumerable<零件申請總覽列表> query = _allRows;
            string projectNo = txtProjectNo.Text.Trim();
            string custName = txtCustName.Text.Trim();
            string itemName = txtItemName.Text.Trim();
            if (!string.IsNullOrEmpty(projectNo))
                query = query.Where(x => (x.專案序號 ?? "").Contains(projectNo));
            if (!string.IsNullOrEmpty(custName))
                query = query.Where(x => (x.客戶簡稱 ?? "").Contains(custName));
            if (!string.IsNullOrEmpty(itemName))
                query = query.Where(x => (x.品名 ?? "").Contains(itemName));

            dataGridView1.Rows.Clear();
            foreach (var x in query)
            {
                int i = dataGridView1.Rows.Add();
                var row = dataGridView1.Rows[i];
                row.Cells[colOrderNo.Index].Value = x.單號;
                row.Cells[colApplyDate.Index].Value = ShortDate(x.申請日期);
                row.Cells[colUse.Index].Value = x.申請用途;
                row.Cells[colApplicant.Index].Value = x.申請人;
                row.Cells[colCustNo.Index].Value = x.客戶編號;
                row.Cells[colCustName.Index].Value = x.客戶簡稱;
                row.Cells[colProjectNo.Index].Value = x.專案序號;
                row.Cells[colPartNo.Index].Value = x.零件號碼;
                row.Cells[colItemName.Index].Value = x.品名;
                row.Cells[colPartType.Index].Value = x.零件分類;
                row.Cells[colQty.Index].Value = x.數量;
                row.Cells[colApprove.Index].Value = x.核准;
            }
        }

        private static string ShortDate(string dt)
        {
            if (string.IsNullOrWhiteSpace(dt)) return "";
            int sp = dt.IndexOf(' ');
            return sp > 0 ? dt.Substring(0, sp) : dt;
        }

        private void btnQuery_Click(object sender, EventArgs e) => ApplyFilter();

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            txtProjectNo.Text = "";
            txtCustName.Text = "";
            txtItemName.Text = "";
            ApplyFilter();
        }

        // ── 單號 OnDblClick：開啟(或切換至)該筆零件申請單分頁 ─────────────────
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            string orderNo = dataGridView1.Rows[e.RowIndex].Cells[colOrderNo.Index].Value?.ToString();
            if (string.IsNullOrEmpty(orderNo)) return;

            if (!(Parent is TabPage) || !(((TabPage)Parent).Parent is TabControl))
            {
                var ctrlStandalone = new AccessoriesApplyControl { Dock = DockStyle.Fill };
                ctrlStandalone.LoadData(orderNo);
                return;
            }
            TabControl tabControl = (TabControl)((TabPage)Parent).Parent;
            string tabName = "AccessoriesApply_" + orderNo;
            foreach (TabPage page in tabControl.TabPages)
            {
                if (page.Name == tabName)
                {
                    tabControl.SelectedTab = page;
                    return;
                }
            }
            var ctrl = new AccessoriesApplyControl { Dock = DockStyle.Fill };
            var tab = new TabPage("零件申請單-" + orderNo) { Name = tabName };
            tab.Controls.Add(ctrl);
            tabControl.TabPages.Add(tab);
            tabControl.SelectedTab = tab;
            ctrl.LoadData(orderNo);
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
