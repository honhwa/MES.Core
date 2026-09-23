using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.Production.Accessories
{
    partial class AccessoriesApplyListControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼
        //
        // 比照 PITS-2025.accdb「P-零件申請單總覽」(Caption="零件申請總覽")。
        // 配色比照原表單：表單首淡黃綠 RGB(242,254,214)(與零件申請單同色系) ──────
        //
        private void InitializeComponent()
        {
            panelHeader = new Panel();
            picLogo = new PictureBox();
            lblTitle = new Label();
            lblProjectNo = new Label();
            txtProjectNo = new TextBox();
            lblCustName = new Label();
            txtCustName = new TextBox();
            lblItemName = new Label();
            txtItemName = new TextBox();
            btnQuery = new Button();
            btnClearFilter = new Button();
            btnExit = new Button();
            panelBody = new Panel();
            dataGridView1 = new DataGridView();
            colOrderNo = new DataGridViewTextBoxColumn();
            colApplyDate = new DataGridViewTextBoxColumn();
            colUse = new DataGridViewTextBoxColumn();
            colApplicant = new DataGridViewTextBoxColumn();
            colCustNo = new DataGridViewTextBoxColumn();
            colCustName = new DataGridViewTextBoxColumn();
            colProjectNo = new DataGridViewTextBoxColumn();
            colPartNo = new DataGridViewTextBoxColumn();
            colItemName = new DataGridViewTextBoxColumn();
            colPartType = new DataGridViewTextBoxColumn();
            colQty = new DataGridViewTextBoxColumn();
            colApprove = new DataGridViewTextBoxColumn();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(242, 254, 214);
            panelHeader.Controls.Add(picLogo);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Controls.Add(lblProjectNo);
            panelHeader.Controls.Add(txtProjectNo);
            panelHeader.Controls.Add(lblCustName);
            panelHeader.Controls.Add(txtCustName);
            panelHeader.Controls.Add(lblItemName);
            panelHeader.Controls.Add(txtItemName);
            panelHeader.Controls.Add(btnQuery);
            panelHeader.Controls.Add(btnClearFilter);
            panelHeader.Controls.Add(btnExit);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1300, 64);
            panelHeader.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.Image = Properties.Resources.AccessoriesApplyLogo;
            picLogo.Location = new Point(8, 8);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(48, 48);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 10;
            picLogo.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("微軟正黑體", 11F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(69, 98, 135);
            lblTitle.Location = new Point(64, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(99, 19);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "零件申請總覽";
            // 
            // lblProjectNo
            // 
            lblProjectNo.AutoSize = true;
            lblProjectNo.Location = new Point(236, 26);
            lblProjectNo.Name = "lblProjectNo";
            lblProjectNo.Size = new Size(64, 18);
            lblProjectNo.TabIndex = 1;
            lblProjectNo.Text = "專案序號";
            // 
            // txtProjectNo
            // 
            txtProjectNo.Location = new Point(301, 23);
            txtProjectNo.Name = "txtProjectNo";
            txtProjectNo.Size = new Size(100, 25);
            txtProjectNo.TabIndex = 2;
            // 
            // lblCustName
            // 
            lblCustName.AutoSize = true;
            lblCustName.Location = new Point(416, 26);
            lblCustName.Name = "lblCustName";
            lblCustName.Size = new Size(64, 18);
            lblCustName.TabIndex = 3;
            lblCustName.Text = "客戶名稱";
            // 
            // txtCustName
            // 
            txtCustName.Location = new Point(481, 23);
            txtCustName.Name = "txtCustName";
            txtCustName.Size = new Size(140, 25);
            txtCustName.TabIndex = 4;
            // 
            // lblItemName
            // 
            lblItemName.AutoSize = true;
            lblItemName.Location = new Point(636, 26);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(36, 18);
            lblItemName.TabIndex = 5;
            lblItemName.Text = "品名";
            // 
            // txtItemName
            // 
            txtItemName.Location = new Point(681, 23);
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new Size(140, 25);
            txtItemName.TabIndex = 6;
            // 
            // btnQuery
            // 
            btnQuery.BackColor = Color.FromArgb(69, 98, 135);
            btnQuery.FlatStyle = FlatStyle.Flat;
            btnQuery.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnQuery.ForeColor = Color.White;
            btnQuery.Location = new Point(836, 21);
            btnQuery.Name = "btnQuery";
            btnQuery.Size = new Size(70, 27);
            btnQuery.TabIndex = 7;
            btnQuery.Tag = "btn-modify";
            btnQuery.Text = "查詢";
            btnQuery.UseVisualStyleBackColor = false;
            btnQuery.Click += btnQuery_Click;
            // 
            // btnClearFilter
            // 
            btnClearFilter.BackColor = Color.Gray;
            btnClearFilter.FlatStyle = FlatStyle.Flat;
            btnClearFilter.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnClearFilter.ForeColor = Color.White;
            btnClearFilter.Location = new Point(912, 21);
            btnClearFilter.Name = "btnClearFilter";
            btnClearFilter.Size = new Size(90, 27);
            btnClearFilter.TabIndex = 8;
            btnClearFilter.Tag = "btn-modify";
            btnClearFilter.Text = "清除篩選";
            btnClearFilter.UseVisualStyleBackColor = false;
            btnClearFilter.Click += btnClearFilter_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(69, 98, 135);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(1212, 8);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(90, 27);
            btnExit.TabIndex = 9;
            btnExit.Text = "關閉";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Visible = false;
            btnExit.Click += btnExit_Click;
            // 
            // panelBody
            // 
            panelBody.Controls.Add(dataGridView1);
            panelBody.Dock = DockStyle.Fill;
            panelBody.Location = new Point(0, 64);
            panelBody.Name = "panelBody";
            panelBody.Size = new Size(1300, 536);
            panelBody.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colOrderNo, colApplyDate, colUse, colApplicant, colCustNo, colCustName, colProjectNo, colPartNo, colItemName, colPartType, colQty, colApprove });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Font = new Font("微軟正黑體", 9F);
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 26;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1300, 536);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // colOrderNo
            // 
            colOrderNo.HeaderText = "單號";
            colOrderNo.Name = "colOrderNo";
            colOrderNo.ReadOnly = true;
            // 
            // colApplyDate
            // 
            colApplyDate.HeaderText = "申請日期";
            colApplyDate.Name = "colApplyDate";
            colApplyDate.ReadOnly = true;
            colApplyDate.Width = 90;
            // 
            // colUse
            // 
            colUse.HeaderText = "申請用途";
            colUse.Name = "colUse";
            colUse.ReadOnly = true;
            colUse.Width = 90;
            // 
            // colApplicant
            // 
            colApplicant.HeaderText = "申請人";
            colApplicant.Name = "colApplicant";
            colApplicant.ReadOnly = true;
            colApplicant.Width = 80;
            // 
            // colCustNo
            // 
            colCustNo.HeaderText = "客戶編號";
            colCustNo.Name = "colCustNo";
            colCustNo.ReadOnly = true;
            colCustNo.Width = 90;
            // 
            // colCustName
            // 
            colCustName.HeaderText = "客戶名稱";
            colCustName.Name = "colCustName";
            colCustName.ReadOnly = true;
            colCustName.Width = 150;
            // 
            // colProjectNo
            // 
            colProjectNo.HeaderText = "專案序號";
            colProjectNo.Name = "colProjectNo";
            colProjectNo.ReadOnly = true;
            colProjectNo.Width = 90;
            // 
            // colPartNo
            // 
            colPartNo.HeaderText = "零件號碼";
            colPartNo.Name = "colPartNo";
            colPartNo.ReadOnly = true;
            colPartNo.Width = 120;
            // 
            // colItemName
            // 
            colItemName.HeaderText = "品名";
            colItemName.Name = "colItemName";
            colItemName.ReadOnly = true;
            colItemName.Width = 180;
            // 
            // colPartType
            // 
            colPartType.HeaderText = "零件分類";
            colPartType.Name = "colPartType";
            colPartType.ReadOnly = true;
            // 
            // colQty
            // 
            colQty.HeaderText = "數量";
            colQty.Name = "colQty";
            colQty.ReadOnly = true;
            colQty.Width = 55;
            // 
            // colApprove
            // 
            colApprove.HeaderText = "生效";
            colApprove.Name = "colApprove";
            colApprove.ReadOnly = true;
            colApprove.Width = 90;
            // 
            // AccessoriesApplyListControl
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelBody);
            Controls.Add(panelHeader);
            Font = new Font("微軟正黑體", 10F);
            Margin = new Padding(4);
            Name = "AccessoriesApplyListControl";
            Size = new Size(1300, 600);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            panelBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private PictureBox picLogo;
        private Label lblTitle;
        private Label lblProjectNo;
        private TextBox txtProjectNo;
        private Label lblCustName;
        private TextBox txtCustName;
        private Label lblItemName;
        private TextBox txtItemName;
        private Button btnQuery;
        private Button btnClearFilter;
        private Button btnExit;
        private Panel panelBody;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colOrderNo;
        private DataGridViewTextBoxColumn colApplyDate;
        private DataGridViewTextBoxColumn colUse;
        private DataGridViewTextBoxColumn colApplicant;
        private DataGridViewTextBoxColumn colCustNo;
        private DataGridViewTextBoxColumn colCustName;
        private DataGridViewTextBoxColumn colProjectNo;
        private DataGridViewTextBoxColumn colPartNo;
        private DataGridViewTextBoxColumn colItemName;
        private DataGridViewTextBoxColumn colPartType;
        private DataGridViewTextBoxColumn colQty;
        private DataGridViewTextBoxColumn colApprove;
    }
}
