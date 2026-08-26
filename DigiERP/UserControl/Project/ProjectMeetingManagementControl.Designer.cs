using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.Project
{
    partial class ProjectMeetingManagementControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼
        //
        // 版面比照 PITS-2025.accdb「P-專案管理紀錄表」(表單首標題"專案管理紀錄
        // 表")及其子表單「P-專案管理紀錄明細」之控制項座標(twips/15=px)還原；
        // 配色亦比照原表單：表單首淺藍灰 RGB(223,229,237)，詳細資料區近白
        // RGB(254,251,248)，按鈕灰色系 RGB(166,166,166)配白字；原表單無表單尾
        // (Height=0)，故本畫面亦不設footer ─────────────────────────────────
        //
        private void InitializeComponent()
        {
            panelHeader = new Panel();
            lblTitle = new Label();
            lbl專案序號 = new Label();
            txt專案序號 = new TextBox();
            lbl日期 = new Label();
            dt日期 = new DateTimePicker();
            lbl紀錄單號 = new Label();
            txt紀錄單號 = new TextBox();
            lbl紀錄類別 = new Label();
            cmb紀錄類別 = new ComboBox();
            lbl記錄人員 = new Label();
            txt記錄人員 = new TextBox();
            lbl備註 = new Label();
            txt備註 = new TextBox();
            btnSave = new Button();
            btnPrint = new Button();
            btnExit = new Button();
            panelBody = new Panel();
            dataGridView1 = new DataGridView();
            colProposer = new DataGridViewComboBoxColumn();
            colOwnerUnit = new DataGridViewTextBoxColumn();
            colTopic = new DataGridViewTextBoxColumn();
            colResolution = new DataGridViewTextBoxColumn();
            colNeedReply = new DataGridViewCheckBoxColumn();
            colReplyPerson = new DataGridViewComboBoxColumn();
            colExpectDate = new DataGridViewTextBoxColumn();
            colActualDate = new DataGridViewTextBoxColumn();
            colReplyDesc = new DataGridViewTextBoxColumn();
            colManagerReview = new DataGridViewCheckBoxColumn();
            panelHeader.SuspendLayout();
            panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            //
            // panelHeader
            //
            panelHeader.BackColor = Color.FromArgb(223, 229, 237);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Controls.Add(lbl專案序號);
            panelHeader.Controls.Add(txt專案序號);
            panelHeader.Controls.Add(lbl日期);
            panelHeader.Controls.Add(dt日期);
            panelHeader.Controls.Add(lbl紀錄單號);
            panelHeader.Controls.Add(txt紀錄單號);
            panelHeader.Controls.Add(lbl紀錄類別);
            panelHeader.Controls.Add(cmb紀錄類別);
            panelHeader.Controls.Add(lbl記錄人員);
            panelHeader.Controls.Add(txt記錄人員);
            panelHeader.Controls.Add(lbl備註);
            panelHeader.Controls.Add(txt備註);
            panelHeader.Controls.Add(btnSave);
            panelHeader.Controls.Add(btnPrint);
            panelHeader.Controls.Add(btnExit);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1360, 100);
            panelHeader.TabIndex = 0;
            //
            // lblTitle
            //
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("微軟正黑體", 12F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(69, 98, 135);
            lblTitle.Location = new Point(11, 8);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(150, 24);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "專案管理紀錄表";
            //
            // lbl專案序號
            //
            lbl專案序號.AutoSize = false;
            lbl專案序號.Location = new Point(11, 44);
            lbl專案序號.Size = new Size(72, 21);
            lbl專案序號.Text = "專案序號";
            lbl專案序號.TextAlign = ContentAlignment.MiddleLeft;
            //
            // txt專案序號
            //
            txt專案序號.Location = new Point(83, 44);
            txt專案序號.Size = new Size(136, 23);
            txt專案序號.ReadOnly = true;
            txt專案序號.BackColor = SystemColors.Control;
            //
            // lbl日期
            //
            lbl日期.AutoSize = false;
            lbl日期.Location = new Point(227, 44);
            lbl日期.Size = new Size(60, 21);
            lbl日期.Text = "日期";
            lbl日期.TextAlign = ContentAlignment.MiddleLeft;
            //
            // dt日期
            //
            dt日期.Format = DateTimePickerFormat.Short;
            dt日期.Location = new Point(298, 44);
            dt日期.Size = new Size(136, 23);
            //
            // lbl紀錄單號
            //
            lbl紀錄單號.AutoSize = false;
            lbl紀錄單號.Location = new Point(458, 44);
            lbl紀錄單號.Size = new Size(70, 21);
            lbl紀錄單號.Text = "紀錄單號";
            lbl紀錄單號.TextAlign = ContentAlignment.MiddleLeft;
            //
            // txt紀錄單號
            //
            txt紀錄單號.Location = new Point(529, 44);
            txt紀錄單號.Size = new Size(167, 23);
            //
            // lbl紀錄類別
            //
            lbl紀錄類別.AutoSize = false;
            lbl紀錄類別.Location = new Point(11, 72);
            lbl紀錄類別.Size = new Size(72, 21);
            lbl紀錄類別.Text = "紀錄類別";
            lbl紀錄類別.TextAlign = ContentAlignment.MiddleLeft;
            //
            // cmb紀錄類別
            //
            cmb紀錄類別.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb紀錄類別.Items.AddRange(new object[] { "開案會議", "內部討論", "追蹤反饋", "進度紀錄", "改善計畫", "客戶驗收" });
            cmb紀錄類別.Location = new Point(83, 72);
            cmb紀錄類別.Size = new Size(136, 23);
            //
            // lbl記錄人員
            //
            lbl記錄人員.AutoSize = false;
            lbl記錄人員.Location = new Point(227, 72);
            lbl記錄人員.Size = new Size(60, 21);
            lbl記錄人員.Text = "記錄人員";
            lbl記錄人員.TextAlign = ContentAlignment.MiddleLeft;
            //
            // txt記錄人員
            //
            txt記錄人員.Location = new Point(298, 72);
            txt記錄人員.Size = new Size(136, 23);
            //
            // lbl備註
            //
            lbl備註.AutoSize = false;
            lbl備註.Location = new Point(458, 72);
            lbl備註.Size = new Size(70, 21);
            lbl備註.Text = "備註";
            lbl備註.TextAlign = ContentAlignment.MiddleLeft;
            //
            // txt備註
            //
            txt備註.Location = new Point(529, 72);
            txt備註.Size = new Size(420, 23);
            //
            // btnSave (原Command37"儲存")
            //
            btnSave.BackColor = Color.FromArgb(166, 166, 166);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnSave.Location = new Point(1090, 8);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(80, 27);
            btnSave.TabIndex = 20;
            btnSave.Text = "儲存";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            //
            // btnPrint (原Command39"列印")
            //
            btnPrint.BackColor = Color.FromArgb(166, 166, 166);
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.ForeColor = Color.White;
            btnPrint.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnPrint.Location = new Point(1176, 8);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(80, 27);
            btnPrint.TabIndex = 21;
            btnPrint.Text = "列印";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            //
            // btnExit (原Command38"關閉")
            //
            btnExit.BackColor = Color.FromArgb(166, 166, 166);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.ForeColor = Color.White;
            btnExit.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnExit.Location = new Point(1262, 8);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(80, 27);
            btnExit.TabIndex = 22;
            btnExit.Text = "關閉";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            //
            // panelBody
            //
            panelBody.BackColor = Color.FromArgb(254, 251, 248);
            panelBody.Dock = DockStyle.Fill;
            panelBody.Location = new Point(0, 100);
            panelBody.Name = "panelBody";
            panelBody.Size = new Size(1360, 420);
            panelBody.TabIndex = 1;
            panelBody.Controls.Add(dataGridView1);
            //
            // dataGridView1 (子表單「P-專案管理紀錄明細」)
            //
            dataGridView1.AllowUserToAddRows = true;
            dataGridView1.AllowUserToDeleteRows = true;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colProposer, colOwnerUnit, colTopic, colResolution, colNeedReply, colReplyPerson, colExpectDate, colActualDate, colReplyDesc, colManagerReview });
            dataGridView1.Font = new Font("微軟正黑體", 9F);
            dataGridView1.Location = new Point(11, 11);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 26;
            dataGridView1.Size = new Size(1338, 398);
            dataGridView1.TabIndex = 30;
            dataGridView1.DataError += dataGridView1_DataError;
            //
            // colProposer
            //
            colProposer.HeaderText = "事項提議人"; colProposer.Name = "colProposer"; colProposer.Width = 90;
            //
            // colOwnerUnit (原Label"主題"，ControlSource=權責處理單位)
            //
            colOwnerUnit.HeaderText = "主題"; colOwnerUnit.Name = "colOwnerUnit"; colOwnerUnit.Width = 130;
            //
            // colTopic (原Label"問題或討論事項"，ControlSource=登載或注意事項)
            //
            colTopic.HeaderText = "問題或討論事項"; colTopic.Name = "colTopic"; colTopic.Width = 280;
            //
            // colResolution (原Label"結論或執行方式"，ControlSource=決議)
            //
            colResolution.HeaderText = "結論或執行方式"; colResolution.Name = "colResolution"; colResolution.Width = 220;
            //
            // colNeedReply (原Label"回覆要求"，ControlSource=回報要求)
            //
            colNeedReply.HeaderText = "需回覆"; colNeedReply.Name = "colNeedReply"; colNeedReply.Width = 60;
            //
            // colReplyPerson (原Label"應回覆人"，ControlSource=應回報人員)
            //
            colReplyPerson.HeaderText = "應回報人員"; colReplyPerson.Name = "colReplyPerson"; colReplyPerson.Width = 90;
            //
            // colExpectDate (原Label"預計回報日")
            //
            colExpectDate.HeaderText = "預計回報日期"; colExpectDate.Name = "colExpectDate"; colExpectDate.Width = 90;
            //
            // colActualDate (原Label"實際回報日")
            //
            colActualDate.HeaderText = "實際回報日期"; colActualDate.Name = "colActualDate"; colActualDate.Width = 90;
            //
            // colReplyDesc (原Label"回覆說明"，ControlSource=回報說明)
            //
            colReplyDesc.HeaderText = "回覆說明"; colReplyDesc.Name = "colReplyDesc"; colReplyDesc.Width = 200;
            //
            // colManagerReview
            //
            colManagerReview.HeaderText = "管理者審閱"; colManagerReview.Name = "colManagerReview"; colManagerReview.Width = 70;
            //
            // ProjectMeetingManagementControl
            //
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelBody);
            Controls.Add(panelHeader);
            Font = new Font("微軟正黑體", 9F);
            Margin = new Padding(4);
            Name = "ProjectMeetingManagementControl";
            Size = new Size(1360, 520);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitle;
        private Label lbl專案序號;
        private TextBox txt專案序號;
        private Label lbl日期;
        private DateTimePicker dt日期;
        private Label lbl紀錄單號;
        private TextBox txt紀錄單號;
        private Label lbl紀錄類別;
        private ComboBox cmb紀錄類別;
        private Label lbl記錄人員;
        private TextBox txt記錄人員;
        private Label lbl備註;
        private TextBox txt備註;
        private Button btnSave;
        private Button btnPrint;
        private Button btnExit;
        private Panel panelBody;
        private DataGridView dataGridView1;
        private DataGridViewComboBoxColumn colProposer;
        private DataGridViewTextBoxColumn colOwnerUnit;
        private DataGridViewTextBoxColumn colTopic;
        private DataGridViewTextBoxColumn colResolution;
        private DataGridViewCheckBoxColumn colNeedReply;
        private DataGridViewComboBoxColumn colReplyPerson;
        private DataGridViewTextBoxColumn colExpectDate;
        private DataGridViewTextBoxColumn colActualDate;
        private DataGridViewTextBoxColumn colReplyDesc;
        private DataGridViewCheckBoxColumn colManagerReview;
    }
}
