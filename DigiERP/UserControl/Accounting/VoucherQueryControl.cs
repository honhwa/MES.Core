using DigiERP.Common;
using DigiERP.UserControl.Inventory.StockIn;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Linq;
using System.Windows.Forms;

namespace DigiERP.UserControl.Accounting
{
    // ── 會計傳票查詢作業：複式條件篩選（畫面未輸入的條件不代入SQL），點選主檔列帶出明細 ──
    public partial class VoucherQueryControl : CommonUserControl
    {
        public static readonly Guid Id = new Guid("2F6A8C13-9B4D-4E71-8A5F-3D6C9B1E4F72");

        public VoucherQueryControl()
        {
            InitializeComponent();
            cboStatus.Items.Add("");
            cboStatus.Items.Add("登錄");
            cboStatus.Items.Add("過帳");
            cboStatus.SelectedIndex = 0;
            LoadQuery();
        }

        // ── 複式條件篩選：畫面上有輸入才代入SQL條件。比照 Access「F-會計傳票查詢」
        //    Command74巨集：只填「起」未填「迄」時，迄=起(單日查詢)；原巨集僅
        //    單向處理(只填迄未填起時，起維持Null，等同 日期>=Null 恆為假、查無
        //    資料)，判斷為原設計疏漏，本畫面已修正為雙向對稱套用同一規則。
        //    「狀態」原巨集在未選擇時會設成字面值"Not Null"(比對不到任何真實
        //    狀態值、形同誤將全部資料濾空)，同屬原設計錯誤，本畫面修正為未選擇
        //    時不套用狀態限制(顯示全部狀態) ─────────────────────────────────
        private void LoadQuery()
        {
            string dateFrom = dtDateFrom.Checked ? dtDateFrom.Value.ToString("yyyy-MM-dd") : "";
            string dateTo = dtDateTo.Checked ? dtDateTo.Value.ToString("yyyy-MM-dd") : "";
            if (!string.IsNullOrEmpty(dateFrom) && string.IsNullOrEmpty(dateTo)) dateTo = dateFrom;
            else if (!string.IsNullOrEmpty(dateTo) && string.IsNullOrEmpty(dateFrom)) dateFrom = dateTo;
            string accountCode = txtAccountCode.Text.Trim();
            string status = cboStatus.SelectedItem?.ToString() ?? "";

            var rep = new VoucherController().GetVoucherQueryList(dateFrom, dateTo, accountCode, status);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            BindMaster(rep.resultList?.GroupBy(x => x.單號).Select(g => g.First()).ToList());
        }

        private void BindMaster(System.Collections.Generic.List<會計傳票查詢清單> list)
        {
            dgvMaster.Rows.Clear();
            dgvDetail.Rows.Clear();
            txtSumDebit.Text = "";
            txtSumCredit.Text = "";
            if (list == null) return;

            foreach (var item in list)
            {
                int idx = dgvMaster.Rows.Add();
                var row = dgvMaster.Rows[idx];
                row.Cells[colNo.Index].Value = item.單號;
                row.Cells[colDate.Index].Value = item.日期;
                row.Cells[colStatus.Index].Value = item.狀態;
                row.Cells[colRegistrar.Index].Value = item.登錄人員;
                row.Cells[colPost.Index].Value = item.過帳;
                row.Cells[colPostDate.Index].Value = item.過帳日;
            }
        }

        private void btnMultiFilter_Click(object sender, EventArgs e) => LoadQuery();

        // ── 傳票編號模糊篩選 ─────────────────────────────────────────────
        private void btnFuzzySearch_Click(object sender, EventArgs e)
        {
            if (!has查詢(Id.ToString())) return;
            string pattern = txtVoucherNoFuzzy.Text.Trim();
            if (string.IsNullOrEmpty(pattern))
            {
                //MessageBox.Show("請輸入傳票編號");
                //return;
            }
            var rep = new VoucherController().GetVoucherQueryListByNoLike(pattern);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            BindMaster(rep.resultList);
        }

        // ── 點選主檔列，帶出明細（含會科名稱）並統計借貸合計 ────────────────────
        private void dgvMaster_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            string no = dgvMaster.Rows[e.RowIndex].Cells[colNo.Index].Value?.ToString();
            if (string.IsNullOrEmpty(no)) return;

            var rep = new VoucherController().GetVoucherDetailForQuery(no);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }

            dgvDetail.Rows.Clear();
            decimal sumDebit = 0, sumCredit = 0;
            foreach (var item in rep.resultList ?? new System.Collections.Generic.List<F會計傳票明細>())
            {
                int idx = dgvDetail.Rows.Add();
                var row = dgvDetail.Rows[idx];
                row.Cells[colDetailNo.Index].Value = item.單號;
                row.Cells[colAccountCode.Index].Value = item.會科代碼;
                row.Cells[colAccountName.Index].Value = item.會計科目;
                row.Cells[colSummary.Index].Value = item.摘要;
                row.Cells[colDebit.Index].Value = item.借方;
                row.Cells[colCredit.Index].Value = item.貸方;
                row.Cells[colSourceDoc.Index].Value = item.來源單據;
                row.Cells[colNote.Index].Value = item.備註;
                sumDebit += item.借方;
                sumCredit += item.貸方;
            }
            txtSumDebit.Text = sumDebit.ToString("0.##");
            txtSumCredit.Text = sumCredit.ToString("0.##");
        }

        // ── 點選明細列的單號，直接顯示該筆會計傳票資料視窗（不關閉本查詢頁籤） ──────
        private void dgvDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            string no = dgvDetail.Rows[e.RowIndex].Cells[colDetailNo.Index].Value?.ToString();
            if (string.IsNullOrEmpty(no)) return;

            using var frm = new FrmVoucher();
            frm.CallerControl = this;
            frm.LoadExisting(no);
            frm.ShowDialog(this);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (Parent is TabPage tabPage && tabPage.Parent is TabControl tabControl)
            {
                tabControl.TabPages.Remove(tabPage);
                tabPage.Dispose();
            }
        }
    }
}
