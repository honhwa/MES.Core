using DigiERP.Common;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DigiERP.UserControl.Production.Accessories
{
    // ── 專案（零件）應收沖款：比照 PITS-2025.accdb「S-專案應收沖款」表單，含
    //    內嵌子表單「S-專案應收沖款明細」(收款/沖帳明細 Grid)。「收款條件」下拉
    //    顯示「代碼 - 名稱」但實際儲存代碼；「客戶名稱」為 DLookUp 衍生顯示欄
    //    位，非資料表實際欄位。COMMISSION/AGENT 依賴之 dbo_C-QUODATA/佣金AGENT
    //    在 CHINYO 查無資料表，維持空白唯讀。「列印」對應之 Access Report 不存
    //    在(僅零件申請單/工令單/產品規格單/專案會議紀錄有對應報表)，「總覽」亦
    //    無對應原型物件，兩者暫以提示訊息取代。
    //    註：資料表 專案應收沖款 曾一度新增 核准/核准日/建檔/建檔日/修改/修改日
    //    6欄並提供生效/取消生效功能，惟資料表結構已變更、該6欄位已不存在，本
    //    畫面已同步移除生效/取消生效按鈕與簽核紀錄顯示 ─────────────────────────
    public partial class ReceivablesControl : CommonUserControl
    {
        private string _projectNo;
        private static string id = "4496AA86-54B0-4D92-8DC9-F6BAA614C01C"; 
        private static int _id;
        private bool _isNew;
        private List<付款方式> _paymentTerms = new List<付款方式>();
        private bool _loading;

        public ReceivablesControl()
        {
            if (!chkPrivilege(id))
            {
                MessageBox.Show("非授權使用者無法使用此功能!");
                Dispose();
                return;
            }
            InitializeComponent();
            DigiERP.Common.UIStyle.ApplyControlStyle(this);
            initComboList();
            SetEditable(false);
        }

        private void initComboList()
        {
            var termRep = new ReceivablesController().GetPaymentTermList();
            if (string.IsNullOrEmpty(termRep.ErrorMessage))
            {
                _paymentTerms = termRep.resultList ?? new List<付款方式>();
                cmb收款條件.Items.Clear();
                cmb收款條件.Items.AddRange(_paymentTerms.Select(FormatPaymentTerm).ToArray());
            }

            var curRep = new ReceivablesController().GetCurrencyList();
            if (string.IsNullOrEmpty(curRep.ErrorMessage))
            {
                cmb幣別.Items.Clear();
                cmb幣別.Items.AddRange((curRep.resultList ?? new List<string>()).ToArray());
            }

            cmb類別.Items.Clear();
            cmb類別.Items.AddRange(new object[] { "機台", "零件" });

            var staffRep = new GeneralExpensesController().GetActiveEmployeeList();
            var staffNames = string.IsNullOrEmpty(staffRep.ErrorMessage)
                ? (staffRep.resultList ?? new List<H員工清冊>()).Select(e => e.姓名).Where(n => !string.IsNullOrEmpty(n)).Distinct().ToArray()
                : new string[0];
            colHandler.Items.Clear();
            colHandler.Items.AddRange(staffNames);

            colItem.Items.Clear();
            colItem.Items.AddRange(new object[] { "全額預收", "合約訂金", "期中工程款", "交機出貨款", "驗收尾款" });

            colDeliveryType.Items.Clear();
            colDeliveryType.Items.AddRange(new object[] { "Cash", "T/T", "Sight L/C", "Usance L/C", "D/A", "D/P", "Check" });
        }

        private static string FormatPaymentTerm(付款方式 p) => string.IsNullOrEmpty(p.條文名稱) ? p.條文編號 : $"{p.條文編號} - {p.條文名稱}";

        private static string ExtractPaymentTermCode(string text)
        {
            if (string.IsNullOrEmpty(text)) return text;
            int idx = text.IndexOf(" - ");
            return idx > 0 ? text.Substring(0, idx) : text;
        }

        public void LoadData(string projectNo)
        {
            _loading = true;
            _projectNo = projectNo;
            var rep = new ReceivablesController().GetReceivablesByProjectNo(projectNo);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                _loading = false;
                return;
            }
            var t = rep.result;
            _isNew = t == null;
            if (t == null)
            {
                t = new 專案應收沖款 { 專案序號 = projectNo };
            }
            _id = t.識別碼;
            txt專案序號.Text = t.專案序號;
            txt機台類型.Text = t.機台類型;
            txt客戶簡稱.Text = t.客戶簡稱;
            txt機台型號.Text = t.機台型號;
            txt機台名稱.Text = t.機台名稱;

            var termMatch = _paymentTerms.FirstOrDefault(p => p.條文編號 == t.收款條件);
            cmb收款條件.Text = termMatch != null ? FormatPaymentTerm(termMatch) : t.收款條件;

            cmb幣別.Text = t.幣別;
            txt合約報價.Text = t.合約報價?.ToString();
            txt實際成交價.Text = t.實際成交價?.ToString();
            txt追加增減額.Text = t.追加增減額?.ToString();
            cmb類別.Text = t.類別;
            txt加購價1st.Text = t.加購價1st?.ToString();
            txt報價單號1st.Text = t.報價單號1st;
            txt加購價2nd.Text = t.加購價2nd?.ToString();
            txt報價單號2nd.Text = t.報價單號2nd;
            txt加購價3rd.Text = t.加購價3rd?.ToString();
            txt報價單號3rd.Text = t.報價單號3rd;
            txt應收款合計.Text = t.應收款合計?.ToString();
            txt報價設算匯率.Text = t.報價設算匯率?.ToString();
            txt專案營業額.Text = t.專案營業額_台幣?.ToString();
            txt累計收款比例.Text = t.累計收款比例?.ToString();
            cmb往來銀行.Text = t.往來銀行;
            txt收款帳戶.Text = t.收款帳戶;
            txtCommission.Text = "";
            txtAgent.Text = "";

            var custRep = new ReceivablesController().GetCustomerNameByCode(t.客戶簡稱);
            txt客戶名稱.Text = string.IsNullOrEmpty(custRep.ErrorMessage) ? custRep.result : "";

            LoadDetailGrid(projectNo);

            SetEditable(false);
            btnEdit.Enabled = true;
            btnSave.Enabled = false;
            _loading = false;
        }

        private void LoadDetailGrid(string projectNo)
        {
            dataGridView1.Rows.Clear();
            var detailRep = new ReceivablesController().GetReceivablesDetailList(projectNo);
            if (string.IsNullOrEmpty(detailRep.ErrorMessage))
            {
                foreach (var d in detailRep.resultList ?? new List<專案應收沖款明細>())
                {
                    int i = dataGridView1.Rows.Add();
                    var row = dataGridView1.Rows[i];
                    row.Cells[colDate.Index].Value = ShortDate(d.收款日期);
                    row.Cells[colItem.Index].Value = d.收款項目;
                    row.Cells[colDeliveryType.Index].Value = d.交付形式;
                    row.Cells[colOffsetAmt.Index].Value = d.沖帳金額;
                    row.Cells[colReceivedAmt.Index].Value = d.實收金額;
                    row.Cells[colFee.Index].Value = d.手續費;
                    row.Cells[colOtherDeduct.Index].Value = d.其他減項;
                    row.Cells[colDeductReason.Index].Value = d.折減事由;
                    row.Cells[colRemark.Index].Value = d.備註;
                    row.Cells[colHandler.Index].Value = d.沖帳人員;
                    row.Cells[colReview.Index].Value = d.業務複審;
                }
            }
            RecalcSum();
        }

        // ── 沖帳金額合計：比照原表單 Text47=Sum([沖帳金額]) ─────────────────────
        private void RecalcSum()
        {
            decimal sum = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;
                if (decimal.TryParse(row.Cells[colOffsetAmt.Index].Value?.ToString(), out var v)) sum += v;
            }
            txtSum.Text = sum.ToString();
        }

        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridView1.IsCurrentCellDirty) dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            RecalcSum();
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private static string ShortDate(string dt)
        {
            if (string.IsNullOrWhiteSpace(dt)) return "";
            int sp = dt.IndexOf(' ');
            return sp > 0 ? dt.Substring(0, sp) : dt;
        }

        private void SetEditable(bool editable)
        {
            cmb收款條件.Enabled = editable;
            cmb幣別.Enabled = editable;
            txt合約報價.ReadOnly = !editable;
            txt實際成交價.ReadOnly = !editable;
            txt追加增減額.ReadOnly = !editable;
            cmb類別.Enabled = editable;
            txt加購價1st.ReadOnly = !editable;
            txt報價單號1st.ReadOnly = !editable;
            txt加購價2nd.ReadOnly = !editable;
            txt報價單號2nd.ReadOnly = !editable;
            txt加購價3rd.ReadOnly = !editable;
            txt報價單號3rd.ReadOnly = !editable;
            txt應收款合計.ReadOnly = !editable;
            txt報價設算匯率.ReadOnly = !editable;
            txt專案營業額.ReadOnly = !editable;
            txt累計收款比例.ReadOnly = !editable;
            cmb往來銀行.Enabled = editable;
            txt收款帳戶.ReadOnly = !editable;
            dataGridView1.ReadOnly = !editable;
            dataGridView1.AllowUserToAddRows = editable;
            dataGridView1.AllowUserToDeleteRows = editable;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SetEditable(true);
            btnSave.Enabled = true;
        }

        private static decimal? ParseDec(string s) => decimal.TryParse(s, out var v) ? (decimal?)v : null;

        private void btnSave_Click(object sender, EventArgs e)
        {
            dataGridView1.EndEdit();

            var t = new 專案應收沖款
            {
                識別碼 = _id,
                專案序號 = _projectNo,
                類別 = cmb類別.Text,
                客戶簡稱 = txt客戶簡稱.Text,
                機台型號 = txt機台型號.Text,
                機台類型 = txt機台類型.Text,
                機台名稱 = txt機台名稱.Text,
                收款條件 = ExtractPaymentTermCode(cmb收款條件.Text),
                幣別 = cmb幣別.Text,
                合約報價 = ParseDec(txt合約報價.Text),
                實際成交價 = ParseDec(txt實際成交價.Text),
                追加增減額 = ParseDec(txt追加增減額.Text),
                加購價1st = ParseDec(txt加購價1st.Text),
                報價單號1st = txt報價單號1st.Text,
                加購價2nd = ParseDec(txt加購價2nd.Text),
                報價單號2nd = txt報價單號2nd.Text,
                加購價3rd = ParseDec(txt加購價3rd.Text),
                報價單號3rd = txt報價單號3rd.Text,
                應收款合計 = ParseDec(txt應收款合計.Text),
                報價設算匯率 = ParseDec(txt報價設算匯率.Text),
                專案營業額_台幣 = string.IsNullOrWhiteSpace(txt專案營業額.Text) ? (int?)null : (int.TryParse(txt專案營業額.Text, out var iv) ? iv : (int?)null),
                累計收款比例 = ParseDec(txt累計收款比例.Text),
                往來銀行 = cmb往來銀行.Text,
                收款帳戶 = txt收款帳戶.Text
            };

            var rep = new ReceivablesController().UpdateReceivables(t);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }

            var detailList = new List<專案應收沖款明細>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;
                bool allEmpty = row.Cells.Cast<DataGridViewCell>().All(c => c.Value == null || string.IsNullOrWhiteSpace(c.Value.ToString()));
                if (allEmpty) continue;
                detailList.Add(new 專案應收沖款明細
                {
                    收款日期 = row.Cells[colDate.Index].Value?.ToString(),
                    收款項目 = row.Cells[colItem.Index].Value?.ToString(),
                    交付形式 = row.Cells[colDeliveryType.Index].Value?.ToString(),
                    沖帳金額 = ParseDec(row.Cells[colOffsetAmt.Index].Value?.ToString()),
                    實收金額 = ParseDec(row.Cells[colReceivedAmt.Index].Value?.ToString()),
                    手續費 = ParseDec(row.Cells[colFee.Index].Value?.ToString()),
                    其他減項 = row.Cells[colOtherDeduct.Index].Value?.ToString(),
                    折減事由 = row.Cells[colDeductReason.Index].Value?.ToString(),
                    備註 = row.Cells[colRemark.Index].Value?.ToString(),
                    沖帳人員 = row.Cells[colHandler.Index].Value?.ToString(),
                    業務複審 = row.Cells[colReview.Index].Value?.ToString(),
                });
            }
            var detailRep = new ReceivablesController().SaveReceivablesDetailList(new SaveReceivablesDetailRequest { ProjectNo = _projectNo, DetailList = detailList });
            if (!string.IsNullOrEmpty(detailRep.ErrorMessage))
            {
                MessageBox.Show(detailRep.ErrorMessage);
                return;
            }

            MessageBox.Show("儲存成功!");
            SetEditable(false);
            LoadData(_projectNo);
        }

        // ── 列印：原表單雖有此按鈕，惟查無對應 Access Report，暫以提示訊息取代 ────
        private void btnPrint_Click(object sender, EventArgs e) => MessageBox.Show("此功能尚未開放(查無對應 Access Report)，如需要請另行告知");

        // ── 總覽：原巨集 OpenForm "S-專案應收沖帳追蹤"，開啟(或切換至) ReceivablesListControl 分頁 ──
        private void btnOverview_Click(object sender, EventArgs e)
        {
            if (!(Parent is TabPage) || !(((TabPage)Parent).Parent is TabControl))
            {
                var standalone = new ReceivablesListControl { Dock = DockStyle.Fill };
                return;
            }
            TabControl tabControl = (TabControl)((TabPage)Parent).Parent;
            const string tabName = "ReceivablesOverview";
            foreach (TabPage page in tabControl.TabPages)
            {
                if (page.Name == tabName)
                {
                    tabControl.SelectedTab = page;
                    return;
                }
            }
            var ctrl = new ReceivablesListControl { Dock = DockStyle.Fill };
            var tab = new TabPage("專案應收沖款總覽") { Name = tabName };
            tab.Controls.Add(ctrl);
            tabControl.TabPages.Add(tab);
            tabControl.SelectedTab = tab;
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
