using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.Production.Accessories
{
    partial class CustomerSearchControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼
        //
        // 比照 PITS-2025.accdb「P-零件單客戶篩選」。配色比照原表單：表單首淺灰
        // RGB(242,242,242) ────────────────────────────────────────────
        //
        private void InitializeComponent()
        {
            panelHeader = new Panel();
            lblTitle = new Label();
            lblSearch = new Label();
            txtSearch = new TextBox();
            lblHint = new Label();
            dataGridView1 = new DataGridView();
            colCompany = new DataGridViewTextBoxColumn();
            colCustNo = new DataGridViewTextBoxColumn();
            colFilter = new DataGridViewTextBoxColumn();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            //
            // panelHeader
            //
            panelHeader.BackColor = Color.FromArgb(242, 242, 242);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Controls.Add(lblSearch);
            panelHeader.Controls.Add(txtSearch);
            panelHeader.Controls.Add(lblHint);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(900, 66);
            panelHeader.TabIndex = 0;
            //
            // lblTitle
            //
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("微軟正黑體", 11F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(69, 98, 135);
            lblTitle.Location = new Point(11, 6);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(120, 22);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "零件單客戶篩選";
            //
            // lblSearch (原Label69"客戶查詢")
            //
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(11, 34);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(70, 19);
            lblSearch.TabIndex = 1;
            lblSearch.Text = "客戶查詢";
            //
            // txtSearch (原"查客")
            //
            txtSearch.Location = new Point(87, 31);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(280, 25);
            txtSearch.TabIndex = 2;
            txtSearch.KeyDown += txtSearch_KeyDown;
            //
            // lblHint (原Label13)
            //
            lblHint.AutoSize = true;
            lblHint.ForeColor = Color.Firebrick;
            lblHint.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            lblHint.Location = new Point(380, 34);
            lblHint.Name = "lblHint";
            lblHint.Size = new Size(280, 19);
            lblHint.TabIndex = 3;
            lblHint.Text = "※選擇客戶名稱，在該欄位點擊兩下！";
            //
            // dataGridView1
            //
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colCompany, colCustNo, colFilter });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Font = new Font("微軟正黑體", 9F);
            dataGridView1.Location = new Point(0, 66);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 26;
            dataGridView1.Size = new Size(900, 434);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            //
            // colCompany (原"客戶名稱")
            //
            colCompany.HeaderText = "客戶名稱"; colCompany.Name = "colCompany"; colCompany.ReadOnly = true; colCompany.Width = 400;
            //
            // colCustNo (原"正航編號")
            //
            colCustNo.HeaderText = "正航編號"; colCustNo.Name = "colCustNo"; colCustNo.ReadOnly = true; colCustNo.Width = 150;
            //
            // colFilter (原"篩")
            //
            colFilter.HeaderText = "篩"; colFilter.Name = "colFilter"; colFilter.ReadOnly = true; colFilter.Width = 100;
            //
            // CustomerSearchControl
            //
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(panelHeader);
            Font = new Font("微軟正黑體", 9F);
            Margin = new Padding(4);
            Name = "CustomerSearchControl";
            Size = new Size(900, 500);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitle;
        private Label lblSearch;
        private TextBox txtSearch;
        private Label lblHint;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colCompany;
        private DataGridViewTextBoxColumn colCustNo;
        private DataGridViewTextBoxColumn colFilter;
    }
}
