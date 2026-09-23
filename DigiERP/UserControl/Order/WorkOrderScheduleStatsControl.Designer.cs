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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panelHeader = new Panel();
            picLogo = new PictureBox();
            lblTitle = new Label();
            lbl專案序號 = new Label();
            txt專案序號 = new TextBox();
            btnExit = new Button();
            dataGridView1 = new DataGridView();
            colPhase = new DataGridViewTextBoxColumn();
            colEst = new DataGridViewTextBoxColumn();
            colActual = new DataGridViewTextBoxColumn();
            colRatio = new DataGridViewTextBoxColumn();
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
            panelHeader.Controls.Add(lbl專案序號);
            panelHeader.Controls.Add(txt專案序號);
            panelHeader.Controls.Add(btnExit);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(700, 60);
            panelHeader.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.Image = Properties.Resources.ScheduleStatsLogo;
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
            lblTitle.Location = new Point(73, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(287, 24);
            lblTitle.TabIndex = 0;
            lblTitle.Tag = "title";
            lblTitle.Text = "工令時程預估工時與實際耗用工時比較表";
            // 
            // lbl專案序號
            // 
            lbl專案序號.Location = new Point(403, 14);
            lbl專案序號.Name = "lbl專案序號";
            lbl專案序號.Size = new Size(75, 21);
            lbl專案序號.TabIndex = 3;
            lbl專案序號.Text = "專案序號";
            lbl專案序號.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt專案序號
            // 
            txt專案序號.BackColor = SystemColors.Control;
            txt專案序號.Location = new Point(482, 14);
            txt專案序號.Name = "txt專案序號";
            txt專案序號.ReadOnly = true;
            txt專案序號.Size = new Size(200, 23);
            txt專案序號.TabIndex = 4;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(140, 140, 140);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(600, 60);
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colPhase, colEst, colActual, colRatio });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Font = new Font("微軟正黑體", 9F);
            dataGridView1.Location = new Point(0, 60);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.Size = new Size(700, 220);
            dataGridView1.TabIndex = 1;
            // 
            // colPhase
            // 
            colPhase.HeaderText = "工段";
            colPhase.Name = "colPhase";
            colPhase.ReadOnly = true;
            // 
            // colEst
            // 
            colEst.HeaderText = "預估工時";
            colEst.Name = "colEst";
            colEst.ReadOnly = true;
            colEst.Width = 150;
            // 
            // colActual
            // 
            colActual.HeaderText = "實際耗用工時";
            colActual.Name = "colActual";
            colActual.ReadOnly = true;
            colActual.Width = 150;
            // 
            // colRatio
            // 
            colRatio.HeaderText = "實際/預估比率";
            colRatio.Name = "colRatio";
            colRatio.ReadOnly = true;
            colRatio.Width = 150;
            // 
            // WorkOrderScheduleStatsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(panelHeader);
            Font = new Font("微軟正黑體", 9F);
            Margin = new Padding(4);
            Name = "WorkOrderScheduleStatsControl";
            Size = new Size(700, 280);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private PictureBox picLogo;
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
