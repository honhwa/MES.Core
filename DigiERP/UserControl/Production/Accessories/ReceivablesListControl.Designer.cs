using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.Production.Accessories
{
    partial class ReceivablesListControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼
        //
        // 比照 PITS-2025.accdb「S-專案應收沖帳追蹤」(Caption="專案應收沖款總覽")
        // 還原，由「S-專案應收沖款」總覽按鈕開啟。表單首淡黃 RGB(255,253,205)、
        // 明細列比照原 AlternateBackColor 淺灰 RGB(242,242,242)。「客戶篩選」
        // ComboBox 來源=C客戶設定(正航編號 not null)，選取後依 客戶簡稱 篩選；
        // 「收款條件」欄位顯示的是 JOIN 帶出的條文名稱(非代碼)。雙擊「專案序號」
        // 開啟(或切換至)該專案的 ReceivablesControl 分頁 ───────────────────────
        //
        private void InitializeComponent()
        {
            panelHeader = new Panel();
            lblTitle = new Label();
            lbl客戶篩選 = new Label();
            cmb客戶篩選 = new ComboBox();
            btnClearFilter = new Button();
            btnExit = new Button();
            dataGridView1 = new DataGridView();
            colProjectNo = new DataGridViewTextBoxColumn();
            colCustCode = new DataGridViewTextBoxColumn();
            colCustName = new DataGridViewTextBoxColumn();
            colModel = new DataGridViewTextBoxColumn();
            colPaymentTerm = new DataGridViewTextBoxColumn();
            colCurrency = new DataGridViewTextBoxColumn();
            colTotal = new DataGridViewTextBoxColumn();
            colBank = new DataGridViewTextBoxColumn();
            colPercent = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelHeader.SuspendLayout();
            SuspendLayout();
            //
            // panelHeader
            //
            panelHeader.BackColor = Color.FromArgb(255, 253, 205);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1160, 50);
            panelHeader.TabIndex = 0;
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Controls.Add(lbl客戶篩選);
            panelHeader.Controls.Add(cmb客戶篩選);
            panelHeader.Controls.Add(btnClearFilter);
            panelHeader.Controls.Add(btnExit);
            //
            // lblTitle
            //
            lblTitle.AutoSize = false;
            lblTitle.Font = new Font("微軟正黑體", 12F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(69, 98, 135);
            lblTitle.Location = new Point(11, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(220, 24);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "專案應收沖款總覽";
            //
            // lbl客戶篩選
            //
            lbl客戶篩選.AutoSize = false;
            lbl客戶篩選.Location = new Point(300, 14);
            lbl客戶篩選.Size = new Size(70, 21);
            lbl客戶篩選.Text = "客戶篩選";
            lbl客戶篩選.TextAlign = ContentAlignment.MiddleLeft;
            //
            // cmb客戶篩選
            //
            cmb客戶篩選.DropDownStyle = ComboBoxStyle.DropDown;
            cmb客戶篩選.Location = new Point(375, 12);
            cmb客戶篩選.Name = "cmb客戶篩選";
            cmb客戶篩選.Size = new Size(300, 25);
            cmb客戶篩選.TabIndex = 1;
            cmb客戶篩選.SelectedIndexChanged += cmb客戶篩選_SelectedIndexChanged;
            //
            // btnClearFilter
            //
            btnClearFilter.BackColor = Color.Gray;
            btnClearFilter.FlatStyle = FlatStyle.Flat;
            btnClearFilter.ForeColor = Color.White;
            btnClearFilter.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnClearFilter.Location = new Point(690, 11);
            btnClearFilter.Name = "btnClearFilter";
            btnClearFilter.Size = new Size(90, 27);
            btnClearFilter.TabIndex = 2;
            btnClearFilter.Text = "清除篩選";
            btnClearFilter.UseVisualStyleBackColor = false;
            btnClearFilter.Click += btnClearFilter_Click;
            //
            // btnExit
            //
            btnExit.BackColor = Color.SteelBlue;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.ForeColor = Color.White;
            btnExit.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnExit.Location = new Point(1060, 11);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(90, 27);
            btnExit.TabIndex = 3;
            btnExit.Text = "關閉";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            //
            // dataGridView1
            //
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AlternatingRowsDefaultCellStyle = new DataGridViewCellStyle { BackColor = Color.FromArgb(242, 242, 242) };
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle { BackColor = Color.FromArgb(255, 253, 205), Font = new Font("微軟正黑體", 9F, FontStyle.Bold) };
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colProjectNo, colCustCode, colCustName, colModel, colPaymentTerm, colCurrency, colTotal, colBank, colPercent });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Font = new Font("微軟正黑體", 9F);
            dataGridView1.Location = new Point(0, 50);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 26;
            dataGridView1.Size = new Size(1160, 550);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;

            colProjectNo.HeaderText = "專案序號"; colProjectNo.Name = "colProjectNo"; colProjectNo.Width = 130; colProjectNo.ReadOnly = true;
            colCustCode.HeaderText = "客戶簡稱"; colCustCode.Name = "colCustCode"; colCustCode.Width = 90; colCustCode.ReadOnly = true;
            colCustName.HeaderText = "客戶名稱"; colCustName.Name = "colCustName"; colCustName.Width = 280; colCustName.ReadOnly = true;
            colModel.HeaderText = "機台型號"; colModel.Name = "colModel"; colModel.Width = 150; colModel.ReadOnly = true;
            colPaymentTerm.HeaderText = "收款條件"; colPaymentTerm.Name = "colPaymentTerm"; colPaymentTerm.Width = 200; colPaymentTerm.ReadOnly = true;
            colCurrency.HeaderText = "幣別"; colCurrency.Name = "colCurrency"; colCurrency.Width = 60; colCurrency.ReadOnly = true;
            colTotal.HeaderText = "應收款合計"; colTotal.Name = "colTotal"; colTotal.Width = 100; colTotal.ReadOnly = true;
            colBank.HeaderText = "往來銀行"; colBank.Name = "colBank"; colBank.Width = 100; colBank.ReadOnly = true;
            colPercent.HeaderText = "累計收款比例"; colPercent.Name = "colPercent"; colPercent.Width = 100; colPercent.ReadOnly = true;
            //
            // ReceivablesListControl
            //
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(panelHeader);
            Font = new Font("微軟正黑體", 9F);
            Margin = new Padding(4);
            Name = "ReceivablesListControl";
            Size = new Size(1160, 600);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelHeader.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitle;
        private Label lbl客戶篩選;
        private ComboBox cmb客戶篩選;
        private Button btnClearFilter;
        private Button btnExit;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colProjectNo;
        private DataGridViewTextBoxColumn colCustCode;
        private DataGridViewTextBoxColumn colCustName;
        private DataGridViewTextBoxColumn colModel;
        private DataGridViewTextBoxColumn colPaymentTerm;
        private DataGridViewTextBoxColumn colCurrency;
        private DataGridViewTextBoxColumn colTotal;
        private DataGridViewTextBoxColumn colBank;
        private DataGridViewTextBoxColumn colPercent;
    }
}
