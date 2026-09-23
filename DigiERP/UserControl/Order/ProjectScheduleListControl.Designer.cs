using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.Order
{
    partial class ProjectScheduleListControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼
        //
        // 比照 PITS-2025.accdb「P-專案管制進度總覽」(Caption="專案時程總覽")還
        // 原，由「P-工令時程表」(WorkOrderScheduleControl)「總覽」按鈕開啟(原
        // 巨集開啟本表單後即 Close 呼叫端 P-工令時程表)。RecordSource 為交叉資
        // 料表查詢「工令時程_交叉資料表」(工令時程表 依工序代號 PIVOT，僅
        // A~E統合工段五段，RIGHT JOIN 工令單 取全部專案，WHERE 專案序號開頭
        // <>"G")。雙擊「專案序號」欄比照原表單 OnDblClick 巨集，開啟(或切換至)
        // 既有 WorkOrderScheduleControl(唯讀帶入該專案序號)。
        // 全部控制項座標一律採內嵌常數寫死(不使用自訂輔助方法) ─────────────────
        //
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panelHeader = new Panel();
            picLogo = new PictureBox();
            lblTitle = new Label();
            btnExit = new Button();
            dataGridView1 = new DataGridView();
            colProjectNo = new DataGridViewTextBoxColumn();
            colMachineName = new DataGridViewTextBoxColumn();
            colMachineType = new DataGridViewTextBoxColumn();
            colOrderDate = new DataGridViewTextBoxColumn();
            colSumHours = new DataGridViewTextBoxColumn();
            colA = new DataGridViewTextBoxColumn();
            colB = new DataGridViewTextBoxColumn();
            colC = new DataGridViewTextBoxColumn();
            colD = new DataGridViewTextBoxColumn();
            colE = new DataGridViewTextBoxColumn();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(237, 247, 249);
            panelHeader.Controls.Add(picLogo);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Controls.Add(btnExit);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1100, 64);
            panelHeader.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.Image = Properties.Resources.ScheduleListLogo;
            picLogo.Location = new Point(8, 8);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(48, 48);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 2;
            picLogo.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("微軟正黑體", 11F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(69, 98, 135);
            lblTitle.Location = new Point(64, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(160, 24);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "專案時程總覽";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(140, 140, 140);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(1000, 18);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(80, 27);
            btnExit.TabIndex = 1;
            btnExit.Text = "關閉";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Visible = false;
            btnExit.Click += btnExit_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colProjectNo, colMachineName, colMachineType, colOrderDate, colSumHours, colA, colB, colC, colD, colE });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Font = new Font("微軟正黑體", 9F);
            dataGridView1.Location = new Point(0, 64);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 26;
            dataGridView1.Size = new Size(1100, 466);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // colProjectNo
            // 
            colProjectNo.HeaderText = "專案序號";
            colProjectNo.Name = "colProjectNo";
            colProjectNo.ReadOnly = true;
            colProjectNo.Width = 110;
            // 
            // colMachineName
            // 
            colMachineName.HeaderText = "機台名稱";
            colMachineName.Name = "colMachineName";
            colMachineName.ReadOnly = true;
            colMachineName.Width = 260;
            // 
            // colMachineType
            // 
            colMachineType.HeaderText = "類型";
            colMachineType.Name = "colMachineType";
            colMachineType.ReadOnly = true;
            // 
            // colOrderDate
            // 
            colOrderDate.HeaderText = "開單日期";
            colOrderDate.Name = "colOrderDate";
            colOrderDate.ReadOnly = true;
            colOrderDate.Width = 90;
            // 
            // colSumHours
            // 
            colSumHours.HeaderText = "預估工時合計";
            colSumHours.Name = "colSumHours";
            colSumHours.ReadOnly = true;
            colSumHours.Width = 90;
            // 
            // colA
            // 
            colA.HeaderText = "A:設計工時";
            colA.Name = "colA";
            colA.ReadOnly = true;
            colA.Width = 85;
            // 
            // colB
            // 
            colB.HeaderText = "B:加工工時";
            colB.Name = "colB";
            colB.ReadOnly = true;
            colB.Width = 85;
            // 
            // colC
            // 
            colC.HeaderText = "C:組裝工時";
            colC.Name = "colC";
            colC.ReadOnly = true;
            colC.Width = 85;
            // 
            // colD
            // 
            colD.HeaderText = "D:電控工時";
            colD.Name = "colD";
            colD.ReadOnly = true;
            colD.Width = 85;
            // 
            // colE
            // 
            colE.HeaderText = "E:試車工時";
            colE.Name = "colE";
            colE.ReadOnly = true;
            colE.Width = 85;
            // 
            // ProjectScheduleListControl
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(panelHeader);
            Font = new Font("微軟正黑體", 9F);
            Margin = new Padding(4);
            Name = "ProjectScheduleListControl";
            Size = new Size(1100, 530);
            panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private PictureBox picLogo;
        private Label lblTitle;
        private Button btnExit;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colProjectNo;
        private DataGridViewTextBoxColumn colMachineName;
        private DataGridViewTextBoxColumn colMachineType;
        private DataGridViewTextBoxColumn colOrderDate;
        private DataGridViewTextBoxColumn colSumHours;
        private DataGridViewTextBoxColumn colA;
        private DataGridViewTextBoxColumn colB;
        private DataGridViewTextBoxColumn colC;
        private DataGridViewTextBoxColumn colD;
        private DataGridViewTextBoxColumn colE;
    }
}
