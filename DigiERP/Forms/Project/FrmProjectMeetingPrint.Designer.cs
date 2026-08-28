using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.Forms.Project
{
    partial class FrmProjectMeetingPrint
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        //
        // 比照 PITS-2025.accdb Report「專案管理紀錄表」(RecordSource=
        // dbo_專案管理紀錄表 LEFT JOIN dbo_工令單，內嵌子報表
        // Report.專案管理紀錄明細)還原。全部控制項座標一律採內嵌常數寫死(不使
        // 用自訂輔助方法)，以避免 Visual Studio 表單設計工具重新序列化時遺失
        // 版面資訊 ──────────────────────────────────────────────────────
        //
        private void InitializeComponent()
        {
            pnlContent = new Panel();
            lblTitle = new Label();
            btnPreviewPrint = new Button();
            btnPrint = new Button();
            btnExit = new Button();
            lbl紀錄單號 = new Label(); txt紀錄單號 = new TextBox();
            lbl日期 = new Label(); txt日期 = new TextBox();
            lbl紀錄類別 = new Label(); txt紀錄類別 = new TextBox();
            lbl專案序號 = new Label(); txt專案序號 = new TextBox();
            lbl客戶名稱 = new Label(); txt客戶名稱 = new TextBox();
            lbl機台型號 = new Label(); txt機台型號 = new TextBox();
            lbl機台類型 = new Label(); txt機台類型 = new TextBox();
            lbl機台名稱 = new Label(); txt機台名稱 = new TextBox();
            lbl記錄人員 = new Label(); txt記錄人員 = new TextBox();
            lbl備註 = new Label(); txt備註 = new TextBox();
            dataGridView1 = new DataGridView();
            colAgenda = new DataGridViewTextBoxColumn();
            colProblem = new DataGridViewTextBoxColumn();
            colConclusion = new DataGridViewTextBoxColumn();
            colOwner = new DataGridViewTextBoxColumn();
            colReplyNeeded = new DataGridViewCheckBoxColumn();
            colExpDate = new DataGridViewTextBoxColumn();
            colActDate = new DataGridViewTextBoxColumn();
            colResult = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            pnlContent.SuspendLayout();
            SuspendLayout();
            //
            // pnlContent
            //
            pnlContent.BackColor = Color.White;
            pnlContent.Location = new Point(0, 0);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1100, 700);
            pnlContent.TabIndex = 0;
            pnlContent.Controls.Add(lblTitle);
            pnlContent.Controls.Add(lbl紀錄單號); pnlContent.Controls.Add(txt紀錄單號);
            pnlContent.Controls.Add(lbl日期); pnlContent.Controls.Add(txt日期);
            pnlContent.Controls.Add(lbl紀錄類別); pnlContent.Controls.Add(txt紀錄類別);
            pnlContent.Controls.Add(lbl專案序號); pnlContent.Controls.Add(txt專案序號);
            pnlContent.Controls.Add(lbl客戶名稱); pnlContent.Controls.Add(txt客戶名稱);
            pnlContent.Controls.Add(lbl機台型號); pnlContent.Controls.Add(txt機台型號);
            pnlContent.Controls.Add(lbl機台類型); pnlContent.Controls.Add(txt機台類型);
            pnlContent.Controls.Add(lbl機台名稱); pnlContent.Controls.Add(txt機台名稱);
            pnlContent.Controls.Add(lbl記錄人員); pnlContent.Controls.Add(txt記錄人員);
            pnlContent.Controls.Add(lbl備註); pnlContent.Controls.Add(txt備註);
            pnlContent.Controls.Add(dataGridView1);
            //
            // lblTitle
            //
            lblTitle.AutoSize = false;
            lblTitle.Font = new Font("標楷體", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(400, 8);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(280, 36);
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Text = "Project Meetings";
            //
            // Row1: 紀錄單號/日期/紀錄類別 (y=50)
            //
            lbl紀錄單號.AutoSize = false; lbl紀錄單號.Location = new Point(8, 50); lbl紀錄單號.Size = new Size(75, 21);
            lbl紀錄單號.Text = "紀錄單號"; lbl紀錄單號.TextAlign = ContentAlignment.MiddleLeft;
            txt紀錄單號.Location = new Point(87, 50); txt紀錄單號.Size = new Size(170, 21); txt紀錄單號.ReadOnly = true;

            lbl日期.AutoSize = false; lbl日期.Location = new Point(280, 50); lbl日期.Size = new Size(50, 21);
            lbl日期.Text = "日期"; lbl日期.TextAlign = ContentAlignment.MiddleLeft;
            txt日期.Location = new Point(335, 50); txt日期.Size = new Size(150, 21); txt日期.ReadOnly = true;

            lbl紀錄類別.AutoSize = false; lbl紀錄類別.Location = new Point(510, 50); lbl紀錄類別.Size = new Size(75, 21);
            lbl紀錄類別.Text = "紀錄類別"; lbl紀錄類別.TextAlign = ContentAlignment.MiddleLeft;
            txt紀錄類別.Location = new Point(589, 50); txt紀錄類別.Size = new Size(150, 21); txt紀錄類別.ReadOnly = true;

            lbl記錄人員.AutoSize = false; lbl記錄人員.Location = new Point(770, 50); lbl記錄人員.Size = new Size(75, 21);
            lbl記錄人員.Text = "記錄人員"; lbl記錄人員.TextAlign = ContentAlignment.MiddleLeft;
            txt記錄人員.Location = new Point(849, 50); txt記錄人員.Size = new Size(150, 21); txt記錄人員.ReadOnly = true;
            //
            // Row2: 專案序號/客戶名稱 (y=80)
            //
            lbl專案序號.AutoSize = false; lbl專案序號.Location = new Point(8, 80); lbl專案序號.Size = new Size(75, 21);
            lbl專案序號.Text = "專案序號"; lbl專案序號.TextAlign = ContentAlignment.MiddleLeft;
            txt專案序號.Location = new Point(87, 80); txt專案序號.Size = new Size(170, 21); txt專案序號.ReadOnly = true;

            lbl客戶名稱.AutoSize = false; lbl客戶名稱.Location = new Point(280, 80); lbl客戶名稱.Size = new Size(75, 21);
            lbl客戶名稱.Text = "客戶名稱"; lbl客戶名稱.TextAlign = ContentAlignment.MiddleLeft;
            txt客戶名稱.Location = new Point(359, 80); txt客戶名稱.Size = new Size(300, 21); txt客戶名稱.ReadOnly = true;
            //
            // Row3: 機台型號/機台類型/機台名稱 (y=110)
            //
            lbl機台型號.AutoSize = false; lbl機台型號.Location = new Point(8, 110); lbl機台型號.Size = new Size(75, 21);
            lbl機台型號.Text = "機台型號"; lbl機台型號.TextAlign = ContentAlignment.MiddleLeft;
            txt機台型號.Location = new Point(87, 110); txt機台型號.Size = new Size(220, 21); txt機台型號.ReadOnly = true;

            lbl機台類型.AutoSize = false; lbl機台類型.Location = new Point(320, 110); lbl機台類型.Size = new Size(75, 21);
            lbl機台類型.Text = "機台類型"; lbl機台類型.TextAlign = ContentAlignment.MiddleLeft;
            txt機台類型.Location = new Point(399, 110); txt機台類型.Size = new Size(100, 21); txt機台類型.ReadOnly = true;

            lbl機台名稱.AutoSize = false; lbl機台名稱.Location = new Point(510, 110); lbl機台名稱.Size = new Size(75, 21);
            lbl機台名稱.Text = "機台名稱"; lbl機台名稱.TextAlign = ContentAlignment.MiddleLeft;
            txt機台名稱.Location = new Point(589, 110); txt機台名稱.Size = new Size(410, 21); txt機台名稱.ReadOnly = true;
            //
            // Row4: 備註 (多行, y=140)
            //
            lbl備註.AutoSize = false; lbl備註.Location = new Point(8, 140); lbl備註.Size = new Size(75, 40);
            lbl備註.Text = "備註"; lbl備註.TextAlign = ContentAlignment.MiddleLeft;
            txt備註.Location = new Point(87, 140); txt備註.Size = new Size(912, 40);
            txt備註.Multiline = true; txt備註.ReadOnly = true; txt備註.BorderStyle = BorderStyle.FixedSingle;
            //
            // dataGridView1 (子報表 Report.專案管理紀錄明細)
            //
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Location = new Point(8, 190);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1080, 460);
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colAgenda, colProblem, colConclusion, colOwner, colReplyNeeded, colExpDate, colActDate, colResult });
            colAgenda.HeaderText = "權責處理單位"; colAgenda.Name = "colAgenda"; colAgenda.Width = 110; colAgenda.ReadOnly = true;
            colProblem.HeaderText = "登載或注意事項"; colProblem.Name = "colProblem"; colProblem.Width = 200; colProblem.ReadOnly = true;
            colConclusion.HeaderText = "決議"; colConclusion.Name = "colConclusion"; colConclusion.Width = 200; colConclusion.ReadOnly = true;
            colOwner.HeaderText = "應回報人員"; colOwner.Name = "colOwner"; colOwner.Width = 90; colOwner.ReadOnly = true;
            colReplyNeeded.HeaderText = "回報要求"; colReplyNeeded.Name = "colReplyNeeded"; colReplyNeeded.Width = 70; colReplyNeeded.ReadOnly = true;
            colExpDate.HeaderText = "預計回報日期"; colExpDate.Name = "colExpDate"; colExpDate.Width = 90; colExpDate.ReadOnly = true;
            colActDate.HeaderText = "實際回報日期"; colActDate.Name = "colActDate"; colActDate.Width = 90; colActDate.ReadOnly = true;
            colResult.HeaderText = "回報說明"; colResult.Name = "colResult"; colResult.Width = 200; colResult.ReadOnly = true;
            //
            // btnPreviewPrint
            //
            btnPreviewPrint.BackColor = Color.FromArgb(69, 98, 135);
            btnPreviewPrint.FlatStyle = FlatStyle.Flat;
            btnPreviewPrint.ForeColor = Color.White;
            btnPreviewPrint.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnPreviewPrint.Location = new Point(800, 8);
            btnPreviewPrint.Name = "btnPreviewPrint";
            btnPreviewPrint.Size = new Size(100, 30);
            btnPreviewPrint.Text = "匯出PDF";
            btnPreviewPrint.UseVisualStyleBackColor = false;
            btnPreviewPrint.Click += btnPreviewPrint_Click;
            //
            // btnPrint
            //
            btnPrint.BackColor = Color.FromArgb(69, 98, 135);
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.ForeColor = Color.White;
            btnPrint.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnPrint.Location = new Point(905, 8);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(70, 30);
            btnPrint.Text = "列印";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            //
            // btnExit
            //
            btnExit.BackColor = Color.Gray;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.ForeColor = Color.White;
            btnExit.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnExit.Location = new Point(980, 8);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(100, 30);
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            //
            // FrmProjectMeetingPrint
            //
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 700);
            Controls.Add(pnlContent);
            Controls.Add(btnPreviewPrint);
            Controls.Add(btnPrint);
            Controls.Add(btnExit);
            Font = new Font("微軟正黑體", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmProjectMeetingPrint";
            StartPosition = FormStartPosition.CenterParent;
            Text = "專案會議紀錄 - 預覽列印";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            ResumeLayout(false);

            // ── 修正：pnlContent 依 Controls.Add 順序(較早加入=較前景)會蓋住其後
            //    加入的按鈕，故顯式將按鈕移至最前景 ─────────────────────────────
            btnPreviewPrint.BringToFront();
            btnPrint.BringToFront();
            btnExit.BringToFront();
        }

        #endregion

        private Panel pnlContent;
        private Label lblTitle;
        private Button btnPreviewPrint;
        private Button btnPrint;
        private Button btnExit;
        private Label lbl紀錄單號; private TextBox txt紀錄單號;
        private Label lbl日期; private TextBox txt日期;
        private Label lbl紀錄類別; private TextBox txt紀錄類別;
        private Label lbl專案序號; private TextBox txt專案序號;
        private Label lbl客戶名稱; private TextBox txt客戶名稱;
        private Label lbl機台型號; private TextBox txt機台型號;
        private Label lbl機台類型; private TextBox txt機台類型;
        private Label lbl機台名稱; private TextBox txt機台名稱;
        private Label lbl記錄人員; private TextBox txt記錄人員;
        private Label lbl備註; private TextBox txt備註;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colAgenda;
        private DataGridViewTextBoxColumn colProblem;
        private DataGridViewTextBoxColumn colConclusion;
        private DataGridViewTextBoxColumn colOwner;
        private DataGridViewCheckBoxColumn colReplyNeeded;
        private DataGridViewTextBoxColumn colExpDate;
        private DataGridViewTextBoxColumn colActDate;
        private DataGridViewTextBoxColumn colResult;
    }
}
