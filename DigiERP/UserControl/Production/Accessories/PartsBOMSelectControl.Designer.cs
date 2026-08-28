using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.Production.Accessories
{
    partial class PartsBOMSelectControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼
        //
        // 比照 PITS-2025.accdb「P-零件申請選項」(Caption="專案零件選項")。
        // 配色比照原表單：表單首深綠 RGB(56,87,35)配白字 ───────────────────
        //
        private void InitializeComponent()
        {
            panelHeader = new Panel();
            lblHint = new Label();
            btnConfirm = new Button();
            btnCancel = new Button();
            dataGridView1 = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colCheck = new DataGridViewCheckBoxColumn();
            colOrderNo = new DataGridViewTextBoxColumn();
            colPartNo = new DataGridViewTextBoxColumn();
            colPartType = new DataGridViewTextBoxColumn();
            colItemName = new DataGridViewTextBoxColumn();
            colDesc = new DataGridViewTextBoxColumn();
            colModule = new DataGridViewTextBoxColumn();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            //
            // panelHeader
            //
            panelHeader.BackColor = Color.FromArgb(56, 87, 35);
            panelHeader.Controls.Add(lblHint);
            panelHeader.Controls.Add(btnConfirm);
            panelHeader.Controls.Add(btnCancel);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1100, 44);
            panelHeader.TabIndex = 0;
            //
            // lblHint (原Label57)
            //
            lblHint.AutoSize = true;
            lblHint.ForeColor = Color.White;
            lblHint.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblHint.Location = new Point(11, 14);
            lblHint.Name = "lblHint";
            lblHint.Size = new Size(400, 19);
            lblHint.TabIndex = 0;
            lblHint.Text = "※請選擇您所要申請的專案零件以填入申請單，謝謝！";
            //
            // btnConfirm (原Command56"確定")
            //
            btnConfirm.BackColor = Color.SeaGreen;
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.ForeColor = Color.White;
            btnConfirm.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnConfirm.Location = new Point(880, 7);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(100, 30);
            btnConfirm.TabIndex = 1;
            btnConfirm.Text = "確定";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            //
            // btnCancel (原Command58"離開")
            //
            btnCancel.BackColor = Color.Gray;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.White;
            btnCancel.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnCancel.Location = new Point(986, 7);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 30);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "離開";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            //
            // dataGridView1
            //
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colId, colCheck, colOrderNo, colPartNo, colPartType, colItemName, colDesc, colModule });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Font = new Font("微軟正黑體", 9F);
            dataGridView1.Location = new Point(0, 44);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 26;
            dataGridView1.Size = new Size(1100, 456);
            dataGridView1.TabIndex = 1;
            //
            // colId (隱藏欄，零件申請BRG.識別碼)
            //
            colId.HeaderText = "識別碼"; colId.Name = "colId"; colId.Visible = false;
            //
            // colCheck (原"選項")
            //
            colCheck.HeaderText = "選項"; colCheck.Name = "colCheck"; colCheck.Width = 55;
            //
            // colOrderNo
            //
            colOrderNo.HeaderText = "單號"; colOrderNo.Name = "colOrderNo"; colOrderNo.ReadOnly = true; colOrderNo.Width = 100;
            //
            // colPartNo
            //
            colPartNo.HeaderText = "零件號碼"; colPartNo.Name = "colPartNo"; colPartNo.ReadOnly = true; colPartNo.Width = 150;
            //
            // colPartType
            //
            colPartType.HeaderText = "零件分類"; colPartType.Name = "colPartType"; colPartType.ReadOnly = true; colPartType.Width = 100;
            //
            // colItemName
            //
            colItemName.HeaderText = "品名"; colItemName.Name = "colItemName"; colItemName.ReadOnly = true; colItemName.Width = 200;
            //
            // colDesc
            //
            colDesc.HeaderText = "描述"; colDesc.Name = "colDesc"; colDesc.ReadOnly = true; colDesc.Width = 250;
            //
            // colModule (原"附屬模組")
            //
            colModule.HeaderText = "附屬模組"; colModule.Name = "colModule"; colModule.ReadOnly = true; colModule.Width = 150;
            //
            // PartsBOMSelectControl
            //
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(panelHeader);
            Font = new Font("微軟正黑體", 9F);
            Margin = new Padding(4);
            Name = "PartsBOMSelectControl";
            Size = new Size(1100, 500);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblHint;
        private Button btnConfirm;
        private Button btnCancel;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewCheckBoxColumn colCheck;
        private DataGridViewTextBoxColumn colOrderNo;
        private DataGridViewTextBoxColumn colPartNo;
        private DataGridViewTextBoxColumn colPartType;
        private DataGridViewTextBoxColumn colItemName;
        private DataGridViewTextBoxColumn colDesc;
        private DataGridViewTextBoxColumn colModule;
    }
}
