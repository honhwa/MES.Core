using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.Order
{
    partial class WorkOrderScheduleStatsControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼
        //
        // 比照 PITS-2025.accdb「P-工令時程」(Caption="工令時程")還原，畫面標題
        // 「工令時程預估工時與實際耗用工時比較表」。原表單以5組獨立DLookUp文字
        // 方塊(專案工段-A~E預估工時 / 專案工段總和-A~E實際耗用工時)逐列呈現，本
        // 畫面改以單一唯讀 DataGridView 呈現5列(設計/加工/組裝/電控/試車)，邏輯
        // 對應相同 ──────────────────────────────────────────────────────────
        //
        private void InitializeComponent()
        {
            panelHeader = new Panel();
            lblTitle = new Label();
            lbl專案序號 = new Label();
            txt專案序號 = new TextBox();
            btnExit = new Button();
            dataGridView1 = new DataGridView();
            colPhase = new DataGridViewTextBoxColumn();
            colEst = new DataGridViewTextBoxColumn();
            colActual = new DataGridViewTextBoxColumn();
            colRatio = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelHeader.SuspendLayout();
            SuspendLayout();
            //
            // panelHeader
            //
            panelHeader.BackColor = Color.FromArgb(237, 247, 249);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(700, 70);
            panelHeader.TabIndex = 0;
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Controls.Add(lbl專案序號);
            panelHeader.Controls.Add(txt專案序號);
            panelHeader.Controls.Add(btnExit);
            //
            // lblTitle
            //
            lblTitle.AutoSize = false;
            lblTitle.Font = new Font("微軟正黑體", 11F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(69, 98, 135);
            lblTitle.Location = new Point(11, 8);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(560, 24);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "工令時程預估工時與實際耗用工時比較表";
            //
            // lbl專案序號
            //
            lbl專案序號.AutoSize = false;
            lbl專案序號.Location = new Point(11, 38);
            lbl專案序號.Size = new Size(75, 21);
            lbl專案序號.Text = "專案序號";
            lbl專案序號.TextAlign = ContentAlignment.MiddleLeft;
            //
            // txt專案序號
            //
            txt專案序號.Location = new Point(90, 38);
            txt專案序號.Name = "txt專案序號";
            txt專案序號.ReadOnly = true;
            txt專案序號.BackColor = SystemColors.Control;
            txt專案序號.Size = new Size(200, 21);
            //
            // btnExit
            //
            btnExit.BackColor = Color.FromArgb(140, 140, 140);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.ForeColor = Color.White;
            btnExit.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnExit.Location = new Point(600, 34);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(80, 27);
            btnExit.TabIndex = 1;
            btnExit.Text = "關閉";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            //
            // dataGridView1
            //
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle { BackColor = Color.FromArgb(237, 247, 249), Font = new Font("微軟正黑體", 9F, FontStyle.Bold) };
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colPhase, colEst, colActual, colRatio });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Font = new Font("微軟正黑體", 9F);
            dataGridView1.Location = new Point(0, 70);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.Size = new Size(700, 210);
            dataGridView1.TabIndex = 1;

            colPhase.HeaderText = "工段"; colPhase.Name = "colPhase"; colPhase.Width = 100; colPhase.ReadOnly = true;
            colEst.HeaderText = "預估工時"; colEst.Name = "colEst"; colEst.Width = 150; colEst.ReadOnly = true;
            colActual.HeaderText = "實際耗用工時"; colActual.Name = "colActual"; colActual.Width = 150; colActual.ReadOnly = true;
            colRatio.HeaderText = "實際/預估比率"; colRatio.Name = "colRatio"; colRatio.Width = 150; colRatio.ReadOnly = true;
            //
            // WorkOrderScheduleStatsControl
            //
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(panelHeader);
            Font = new Font("微軟正黑體", 9F);
            Margin = new Padding(4);
            Name = "WorkOrderScheduleStatsControl";
            Size = new Size(700, 280);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitle;
        private Label lbl專案序號;
        private TextBox txt專案序號;
        private Button btnExit;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colPhase;
        private DataGridViewTextBoxColumn colEst;
        private DataGridViewTextBoxColumn colActual;
        private DataGridViewTextBoxColumn colRatio;
    }
}
