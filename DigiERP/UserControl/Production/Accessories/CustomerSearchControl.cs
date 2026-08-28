using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DigiERP.UserControl.Production.Accessories
{
    // ── 零件單客戶篩選：比照 PITS-2025.accdb「P-零件單客戶篩選」。由 AccessoriesApplyControl
    //    客戶欄位旁"…"按鈕開啟。雙擊「客戶名稱」欄位，將 客戶名稱/正航編號 回傳
    //    給呼叫端(比照原巨集寫回 [Forms]![P-零件申請單]![客戶簡稱]/[正航編號]) ────
    public partial class CustomerSearchControl : System.Windows.Forms.UserControl
    {
        public string SelectedCompany { get; private set; }
        public string SelectedCustNo { get; private set; }
        public event Action<string, string> Picked;

        public CustomerSearchControl()
        {
            InitializeComponent();
            LoadData(null);
        }

        private void LoadData(string keyword)
        {
            var rep = new MfgController().GetCustomerSearchList(keyword);
            dataGridView1.Rows.Clear();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            foreach (var x in rep.resultList ?? new List<零件單客戶篩選列表>())
            {
                int i = dataGridView1.Rows.Add();
                var row = dataGridView1.Rows[i];
                row.Cells[colCompany.Index].Value = x.COMPANY;
                row.Cells[colCustNo.Index].Value = x.正航編號;
                row.Cells[colFilter.Index].Value = x.篩;
            }
        }

        // ── 客戶查詢：AfterUpdate 重新查詢(比照原巨集，改為按Enter觸發) ─────────
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadData(txtSearch.Text.Trim());
                e.SuppressKeyPress = true;
            }
        }

        // ── 客戶名稱 OnDblClick：回傳選取的客戶名稱/正航編號 ────────────────────
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            SelectedCompany = dataGridView1.Rows[e.RowIndex].Cells[colCompany.Index].Value?.ToString();
            SelectedCustNo = dataGridView1.Rows[e.RowIndex].Cells[colCustNo.Index].Value?.ToString();
            Picked?.Invoke(SelectedCompany, SelectedCustNo);
        }
    }
}
