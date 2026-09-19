using DigiERP.Common;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DigiERP.UserControl.Production.Accessories
{
    // ── 專案應收沖款總覽：比照 PITS-2025.accdb「S-專案應收沖帳追蹤」，由
    //    「S-專案應收沖款」表單之「總覽」按鈕開啟。RecordSource 為查詢「專案應
    //    收沖帳追蹤」(專案應收沖款 LEFT JOIN 付款方式 LEFT JOIN C客戶設定)。
    //    「客戶篩選」下拉選取後依 客戶簡稱 重新查詢(比照原巨集 AfterUpdate 重
    //    開表單並帶 WhereCondition，此處簡化為重新呼叫 API)；「清除篩選」還原
    //    全部清單。雙擊「專案序號」開啟(或切換至)該專案的 ReceivablesControl
    //    分頁(比照原巨集 OpenForm S-專案應收沖款 + WhereCondition) ─────────────
    public partial class ReceivablesListControl : CommonUserControl
    {
        private Dictionary<string, string> _custNameToCode = new Dictionary<string, string>();

        public ReceivablesListControl()
        {
            InitializeComponent();
            DigiERP.Common.UIStyle.ApplyControlStyle(this);
            initCustomerFilterCombo();
            LoadData(null);
        }

        private void initCustomerFilterCombo()
        {
            var rep = new ReceivablesController().GetReceivablesCustomerFilterList();
            cmb客戶篩選.Items.Clear();
            _custNameToCode.Clear();
            if (string.IsNullOrEmpty(rep.ErrorMessage))
            {
                foreach (var c in rep.resultList ?? new List<零件單客戶篩選列表>())
                {
                    if (string.IsNullOrEmpty(c.COMPANY)) continue;
                    if (!_custNameToCode.ContainsKey(c.COMPANY)) _custNameToCode[c.COMPANY] = c.正航編號;
                    cmb客戶篩選.Items.Add(c.COMPANY);
                }
            }
        }

        private void LoadData(string custCode)
        {
            var rep = new ReceivablesController().GetReceivablesOverviewList(custCode);
            dataGridView1.Rows.Clear();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            foreach (var x in rep.resultList ?? new List<專案應收沖款總覽列表>())
            {
                int i = dataGridView1.Rows.Add();
                var row = dataGridView1.Rows[i];
                row.Cells[colProjectNo.Index].Value = x.專案序號;
                row.Cells[colCustCode.Index].Value = x.客戶簡稱;
                row.Cells[colCustName.Index].Value = x.客戶名稱;
                row.Cells[colModel.Index].Value = x.機台型號;
                row.Cells[colPaymentTerm.Index].Value = x.收款條件;
                row.Cells[colCurrency.Index].Value = x.幣別;
                row.Cells[colTotal.Index].Value = x.應收款合計;
                row.Cells[colBank.Index].Value = x.往來銀行;
                row.Cells[colPercent.Index].Value = x.累計收款比例;
            }
        }

        // ── 客戶篩選：AfterUpdate 依所選客戶重新查詢 ─────────────────────────
        private void cmb客戶篩選_SelectedIndexChanged(object sender, EventArgs e)
        {
            string company = cmb客戶篩選.Text;
            if (string.IsNullOrEmpty(company) || !_custNameToCode.TryGetValue(company, out var code)) return;
            LoadData(code);
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            cmb客戶篩選.Text = "";
            LoadData(null);
        }

        // ── 專案序號 OnDblClick：開啟(或切換至)該筆專案應收沖款分頁 ──────────────
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            string projectNo = dataGridView1.Rows[e.RowIndex].Cells[colProjectNo.Index].Value?.ToString();
            if (string.IsNullOrEmpty(projectNo)) return;

            if (!(Parent is TabPage) || !(((TabPage)Parent).Parent is TabControl))
            {
                var ctrlStandalone = new ReceivablesControl { Dock = DockStyle.Fill };
                ctrlStandalone.LoadData(projectNo);
                return;
            }
            TabControl tabControl = (TabControl)((TabPage)Parent).Parent;
            string tabName = "Receivables_" + projectNo;
            foreach (TabPage page in tabControl.TabPages)
            {
                if (page.Name == tabName)
                {
                    tabControl.SelectedTab = page;
                    return;
                }
            }
            var ctrl = new ReceivablesControl { Dock = DockStyle.Fill };
            var tab = new TabPage("收款進度查詢-" + projectNo) { Name = tabName };
            tab.Controls.Add(ctrl);
            tabControl.TabPages.Add(tab);
            tabControl.SelectedTab = tab;
            ctrl.LoadData(projectNo);
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
