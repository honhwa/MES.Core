using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.Production.Engineering
{
    partial class EngineeringAnalysisListControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EngineeringAnalysisListControl));
            panelHeader = new Panel();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            lblHint = new Label();
            btnExit = new Button();
            panelBody = new Panel();
            dataGridView1 = new DataGridView();
            colProjectNo = new DataGridViewTextBoxColumn();
            colOrderDate = new DataGridViewTextBoxColumn();
            colCustName = new DataGridViewTextBoxColumn();
            colCustFullName = new DataGridViewTextBoxColumn();
            colCountry = new DataGridViewTextBoxColumn();
            colMachineType = new DataGridViewTextBoxColumn();
            colMachineModel = new DataGridViewTextBoxColumn();
            colMachineName = new DataGridViewTextBoxColumn();
            colApprove = new DataGridViewTextBoxColumn();
            colClosed = new DataGridViewCheckBoxColumn();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(252, 230, 212);
            panelHeader.Controls.Add(pictureBox1);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Controls.Add(lblHint);
            panelHeader.Controls.Add(btnExit);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1300, 60);
            panelHeader.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(8, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("微軟正黑體", 13F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Firebrick;
            lblTitle.Location = new Point(62, 8);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(154, 23);
            lblTitle.TabIndex = 1;
            lblTitle.Tag = "title";
            lblTitle.Text = "工程分析表篩選單";
            // 
            // lblHint
            // 
            lblHint.AutoSize = true;
            lblHint.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            lblHint.ForeColor = Color.Firebrick;
            lblHint.Location = new Point(266, 24);
            lblHint.Name = "lblHint";
            lblHint.Size = new Size(377, 16);
            lblHint.TabIndex = 2;
            lblHint.Text = "※請在下方清單中點擊兩下您所要選擇之專案序號，開啟工程分析表！";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Gainsboro;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnExit.Location = new Point(1197, 8);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(90, 32);
            btnExit.TabIndex = 3;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Visible = false;
            btnExit.Click += btnExit_Click;
            // 
            // panelBody
            // 
            panelBody.Controls.Add(dataGridView1);
            panelBody.Dock = DockStyle.Fill;
            panelBody.Location = new Point(0, 60);
            panelBody.Name = "panelBody";
            panelBody.Size = new Size(1300, 596);
            panelBody.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colProjectNo, colOrderDate, colCustName, colCustFullName, colCountry, colMachineType, colMachineModel, colMachineName, colApprove, colClosed });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Font = new Font("微軟正黑體", 9F);
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 26;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1300, 596);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // colProjectNo
            // 
            colProjectNo.HeaderText = "專案序號";
            colProjectNo.Name = "colProjectNo";
            colProjectNo.ReadOnly = true;
            // 
            // colOrderDate
            // 
            colOrderDate.HeaderText = "訂單日期";
            colOrderDate.Name = "colOrderDate";
            colOrderDate.ReadOnly = true;
            colOrderDate.Width = 90;
            // 
            // colCustName
            // 
            colCustName.HeaderText = "客戶簡稱";
            colCustName.Name = "colCustName";
            colCustName.ReadOnly = true;
            colCustName.Width = 90;
            // 
            // colCustFullName
            // 
            colCustFullName.HeaderText = "客戶名稱";
            colCustFullName.Name = "colCustFullName";
            colCustFullName.ReadOnly = true;
            colCustFullName.Width = 180;
            // 
            // colCountry
            // 
            colCountry.HeaderText = "國家地區";
            colCountry.Name = "colCountry";
            colCountry.ReadOnly = true;
            colCountry.Width = 90;
            // 
            // colMachineType
            // 
            colMachineType.HeaderText = "機型";
            colMachineType.Name = "colMachineType";
            colMachineType.ReadOnly = true;
            colMachineType.Width = 55;
            // 
            // colMachineModel
            // 
            colMachineModel.HeaderText = "機台型號";
            colMachineModel.Name = "colMachineModel";
            colMachineModel.ReadOnly = true;
            colMachineModel.Width = 120;
            // 
            // colMachineName
            // 
            colMachineName.HeaderText = "機台名稱";
            colMachineName.Name = "colMachineName";
            colMachineName.ReadOnly = true;
            colMachineName.Width = 220;
            // 
            // colApprove
            // 
            colApprove.HeaderText = "生效";
            colApprove.Name = "colApprove";
            colApprove.ReadOnly = true;
            colApprove.Width = 90;
            // 
            // colClosed
            // 
            colClosed.HeaderText = "結案";
            colClosed.Name = "colClosed";
            colClosed.ReadOnly = true;
            colClosed.Width = 55;
            // 
            // EngineeringAnalysisListControl
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelBody);
            Controls.Add(panelHeader);
            Font = new Font("微軟正黑體", 10F);
            Margin = new Padding(4);
            Name = "EngineeringAnalysisListControl";
            Size = new Size(1300, 656);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private PictureBox pictureBox1;
        private Label lblTitle;
        private Label lblHint;
        private Button btnExit;
        private Panel panelBody;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colProjectNo;
        private DataGridViewTextBoxColumn colOrderDate;
        private DataGridViewTextBoxColumn colCustName;
        private DataGridViewTextBoxColumn colCustFullName;
        private DataGridViewTextBoxColumn colCountry;
        private DataGridViewTextBoxColumn colMachineType;
        private DataGridViewTextBoxColumn colMachineModel;
        private DataGridViewTextBoxColumn colMachineName;
        private DataGridViewTextBoxColumn colApprove;
        private DataGridViewCheckBoxColumn colClosed;
    }
}
