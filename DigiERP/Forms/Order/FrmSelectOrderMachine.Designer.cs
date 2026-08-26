using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.Forms.Order
{
    partial class FrmSelectOrderMachine
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panelToolbar = new Panel();
            lblTitle = new Label();
            btnConvert = new Button();
            btnCancel = new Button();
            dataGridView1 = new DataGridView();
            colProjectNo = new DataGridViewTextBoxColumn();
            colOrderDate = new DataGridViewTextBoxColumn();
            colCustNo = new DataGridViewTextBoxColumn();
            colCustName = new DataGridViewTextBoxColumn();
            colMachineType = new DataGridViewTextBoxColumn();
            colMachineModel = new DataGridViewTextBoxColumn();
            colMachineName = new DataGridViewTextBoxColumn();
            panelToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            //
            // panelToolbar
            //
            panelToolbar.BackColor = Color.FromArgb(230, 230, 250);
            panelToolbar.Controls.Add(lblTitle);
            panelToolbar.Controls.Add(btnConvert);
            panelToolbar.Controls.Add(btnCancel);
            panelToolbar.Dock = DockStyle.Top;
            panelToolbar.Location = new Point(0, 0);
            panelToolbar.Name = "panelToolbar";
            panelToolbar.Size = new Size(1000, 48);
            panelToolbar.TabIndex = 0;
            //
            // lblTitle
            //
            lblTitle.Font = new Font("微軟正黑體", 12F, FontStyle.Bold);
            lblTitle.Location = new Point(16, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(220, 24);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "專案機台一覽(自訂單新增機台)";
            //
            // btnConvert
            //
            btnConvert.BackColor = Color.FromArgb(198, 216, 255);
            btnConvert.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnConvert.Location = new Point(760, 6);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(110, 36);
            btnConvert.TabIndex = 1;
            btnConvert.Text = "轉開工令單";
            btnConvert.UseVisualStyleBackColor = false;
            btnConvert.Click += btnConvert_Click;
            //
            // btnCancel
            //
            btnCancel.BackColor = Color.Gainsboro;
            btnCancel.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnCancel.Location = new Point(878, 6);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(90, 36);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "取消";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            //
            // dataGridView1
            //
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(230, 230, 250);
            dataGridViewCellStyle1.Font = new Font("微軟正黑體", 10F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colProjectNo, colOrderDate, colCustNo, colCustName, colMachineType, colMachineModel, colMachineName });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Font = new Font("微軟正黑體", 10F);
            dataGridView1.Location = new Point(0, 48);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1000, 452);
            dataGridView1.TabIndex = 1;
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
            //
            // colCustNo
            //
            colCustNo.HeaderText = "客戶編號";
            colCustNo.Name = "colCustNo";
            colCustNo.ReadOnly = true;
            //
            // colCustName
            //
            colCustName.HeaderText = "客戶名稱";
            colCustName.Name = "colCustName";
            colCustName.ReadOnly = true;
            //
            // colMachineType
            //
            colMachineType.HeaderText = "機台類型";
            colMachineType.Name = "colMachineType";
            colMachineType.ReadOnly = true;
            //
            // colMachineModel
            //
            colMachineModel.HeaderText = "機台型號";
            colMachineModel.Name = "colMachineModel";
            colMachineModel.ReadOnly = true;
            //
            // colMachineName
            //
            colMachineName.HeaderText = "機台名稱";
            colMachineName.Name = "colMachineName";
            colMachineName.ReadOnly = true;
            //
            // FrmSelectOrderMachine
            //
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 500);
            Controls.Add(dataGridView1);
            Controls.Add(panelToolbar);
            Font = new Font("微軟正黑體", 10F);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MinimumSize = new Size(800, 400);
            Name = "FrmSelectOrderMachine";
            StartPosition = FormStartPosition.CenterParent;
            Text = "專案機台一覽";
            panelToolbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelToolbar;
        private Label lblTitle;
        private Button btnConvert;
        private Button btnCancel;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colProjectNo;
        private DataGridViewTextBoxColumn colOrderDate;
        private DataGridViewTextBoxColumn colCustNo;
        private DataGridViewTextBoxColumn colCustName;
        private DataGridViewTextBoxColumn colMachineType;
        private DataGridViewTextBoxColumn colMachineModel;
        private DataGridViewTextBoxColumn colMachineName;
    }
}
