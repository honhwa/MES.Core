using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.Production.Engineering
{
    partial class EngineeringAnalysisControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼
        //
        // 版面比照 PITS-2025.accdb「P-工程」表單之控制項座標(twips/15=px)還原。
        // RecordSource 直接就是 工令單(非另建資料表)，故畫面全為工令單既有欄位
        // 的唯讀參考顯示，加上 建檔_工程/修改_工程/核准_工程 等工程部門專屬簽核
        // 欄位 ──────────────────────────────────────────────────────────
        //
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EngineeringAnalysisControl));
            panelHeader = new Panel();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            btnEdit = new Button();
            btnSave = new Button();
            btnApprove = new Button();
            btnUnapprove = new Button();
            btnPrint = new Button();
            btnOverview = new Button();
            btnExit = new Button();
            panelBody = new Panel();
            lbl專案序號 = new Label();
            txt專案序號 = new TextBox();
            lbl訂單日期 = new Label();
            txt訂單日期 = new TextBox();
            lbl客戶簡稱 = new Label();
            txt客戶簡稱 = new TextBox();
            lbl客戶 = new Label();
            txt客戶名稱 = new TextBox();
            lbl國家地區 = new Label();
            txt國家地區 = new TextBox();
            lbl結案 = new Label();
            chk結案 = new CheckBox();
            lbl機台型號 = new Label();
            txt機台型號 = new TextBox();
            lbl機台類型 = new Label();
            txt機台類型 = new TextBox();
            lbl驗機日期 = new Label();
            txt驗機日期 = new TextBox();
            lbl交貨日期 = new Label();
            txt交貨日期 = new TextBox();
            lbl機台名稱 = new Label();
            txt機台名稱 = new TextBox();
            lbl廠驗 = new Label();
            txt廠驗 = new TextBox();
            lbl裝機 = new Label();
            txt裝機 = new TextBox();
            dataGridView1 = new DataGridView();
            colModuleCode = new DataGridViewComboBoxColumn();
            colModuleName = new DataGridViewComboBoxColumn();
            colCheckCategory = new DataGridViewTextBoxColumn();
            colMakeType = new DataGridViewComboBoxColumn();
            colLeadDays = new DataGridViewTextBoxColumn();
            colDrawHours = new DataGridViewTextBoxColumn();
            colProcessHours = new DataGridViewTextBoxColumn();
            colAssembleHours = new DataGridViewTextBoxColumn();
            colElecHours = new DataGridViewTextBoxColumn();
            colTotalHours = new DataGridViewTextBoxColumn();
            panelFooter = new Panel();
            lblF核准人員 = new Label();
            txtF核准 = new TextBox();
            txtF核准日 = new TextBox();
            lblF修改人員 = new Label();
            txtF修改 = new TextBox();
            txtF修改日 = new TextBox();
            lblF建檔人員 = new Label();
            txtF建檔 = new TextBox();
            txtF建檔日 = new TextBox();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelFooter.SuspendLayout();
            SuspendLayout();
            //
            // panelHeader
            //
            panelHeader.BackColor = Color.FromArgb(252, 230, 212);
            panelHeader.Controls.Add(pictureBox1);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Controls.Add(btnEdit);
            panelHeader.Controls.Add(btnSave);
            panelHeader.Controls.Add(btnApprove);
            panelHeader.Controls.Add(btnUnapprove);
            panelHeader.Controls.Add(btnPrint);
            panelHeader.Controls.Add(btnOverview);
            panelHeader.Controls.Add(btnExit);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1360, 44);
            panelHeader.TabIndex = 0;
            //
            // pictureBox1
            //
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            //
            // lblTitle
            //
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("微軟正黑體", 12F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Firebrick;
            lblTitle.Location = new Point(42, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(110, 24);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "工程分析表";
            //
            // btnEdit (原Command276「修改」)
            //
            btnEdit.BackColor = Color.SteelBlue;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.ForeColor = Color.White;
            btnEdit.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnEdit.Location = new Point(563, 8);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(49, 27);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "修改";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            //
            // btnSave (原"儲存")
            //
            btnSave.BackColor = Color.SteelBlue;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnSave.Location = new Point(634, 8);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(49, 27);
            btnSave.TabIndex = 3;
            btnSave.Text = "儲存";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            //
            // btnApprove (原"生效")
            //
            btnApprove.BackColor = Color.SteelBlue;
            btnApprove.FlatStyle = FlatStyle.Flat;
            btnApprove.ForeColor = Color.White;
            btnApprove.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnApprove.Location = new Point(705, 8);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(49, 27);
            btnApprove.TabIndex = 4;
            btnApprove.Text = "生效";
            btnApprove.UseVisualStyleBackColor = false;
            btnApprove.Click += btnApprove_Click;
            //
            // btnUnapprove (原Command361「取消生效」)
            //
            btnUnapprove.BackColor = Color.SteelBlue;
            btnUnapprove.FlatStyle = FlatStyle.Flat;
            btnUnapprove.ForeColor = Color.White;
            btnUnapprove.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnUnapprove.Location = new Point(776, 8);
            btnUnapprove.Name = "btnUnapprove";
            btnUnapprove.Size = new Size(69, 27);
            btnUnapprove.TabIndex = 5;
            btnUnapprove.Text = "取消生效";
            btnUnapprove.UseVisualStyleBackColor = false;
            btnUnapprove.Click += btnUnapprove_Click;
            //
            // btnPrint (原"列印"，原巨集未附加任何動作)
            //
            btnPrint.BackColor = Color.SteelBlue;
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.ForeColor = Color.White;
            btnPrint.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnPrint.Location = new Point(938, 8);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(49, 27);
            btnPrint.TabIndex = 6;
            btnPrint.Text = "列印";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            //
            // btnOverview (原"總覽"，開啟 P-工程總覽)
            //
            btnOverview.BackColor = Color.SteelBlue;
            btnOverview.FlatStyle = FlatStyle.Flat;
            btnOverview.ForeColor = Color.White;
            btnOverview.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnOverview.Location = new Point(867, 8);
            btnOverview.Name = "btnOverview";
            btnOverview.Size = new Size(49, 27);
            btnOverview.TabIndex = 7;
            btnOverview.Text = "總覽";
            btnOverview.UseVisualStyleBackColor = false;
            btnOverview.Click += btnOverview_Click;
            //
            // btnExit (原Command298「關閉」)
            //
            btnExit.BackColor = Color.SteelBlue;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.ForeColor = Color.White;
            btnExit.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnExit.Location = new Point(1009, 8);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(49, 27);
            btnExit.TabIndex = 8;
            btnExit.Text = "關閉";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            //
            // panelBody
            //
            panelBody.BackColor = Color.White;
            panelBody.Dock = DockStyle.Fill;
            panelBody.Location = new Point(0, 44);
            panelBody.Name = "panelBody";
            panelBody.Size = new Size(1360, 470);
            panelBody.TabIndex = 1;
            panelBody.Controls.Add(dataGridView1);
            panelBody.Controls.Add(lbl專案序號);
            panelBody.Controls.Add(txt專案序號);
            panelBody.Controls.Add(lbl訂單日期);
            panelBody.Controls.Add(txt訂單日期);
            panelBody.Controls.Add(lbl客戶簡稱);
            panelBody.Controls.Add(txt客戶簡稱);
            panelBody.Controls.Add(lbl客戶);
            panelBody.Controls.Add(txt客戶名稱);
            panelBody.Controls.Add(lbl國家地區);
            panelBody.Controls.Add(txt國家地區);
            panelBody.Controls.Add(lbl結案);
            panelBody.Controls.Add(chk結案);
            panelBody.Controls.Add(lbl機台型號);
            panelBody.Controls.Add(txt機台型號);
            panelBody.Controls.Add(lbl機台類型);
            panelBody.Controls.Add(txt機台類型);
            panelBody.Controls.Add(lbl驗機日期);
            panelBody.Controls.Add(txt驗機日期);
            panelBody.Controls.Add(lbl交貨日期);
            panelBody.Controls.Add(txt交貨日期);
            panelBody.Controls.Add(lbl機台名稱);
            panelBody.Controls.Add(txt機台名稱);
            panelBody.Controls.Add(lbl廠驗);
            panelBody.Controls.Add(txt廠驗);
            panelBody.Controls.Add(lbl裝機);
            panelBody.Controls.Add(txt裝機);
            //
            // 專案序號
            //
            lbl專案序號.AutoSize = false;
            lbl專案序號.Location = new Point(11, 8);
            lbl專案序號.Size = new Size(72, 21);
            lbl專案序號.Text = "專案序號";
            lbl專案序號.ForeColor = Color.DimGray;
            lbl專案序號.TextAlign = ContentAlignment.MiddleLeft;
            txt專案序號.Location = new Point(86, 8);
            txt專案序號.Size = new Size(217, 23);
            txt專案序號.ReadOnly = true;
            txt專案序號.BackColor = SystemColors.Control;
            //
            // 訂單日期
            //
            lbl訂單日期.AutoSize = false;
            lbl訂單日期.Location = new Point(321, 8);
            lbl訂單日期.Size = new Size(72, 21);
            lbl訂單日期.Text = "訂單日期";
            lbl訂單日期.ForeColor = Color.DimGray;
            lbl訂單日期.TextAlign = ContentAlignment.MiddleLeft;
            txt訂單日期.Location = new Point(396, 8);
            txt訂單日期.Size = new Size(147, 23);
            txt訂單日期.ReadOnly = true;
            txt訂單日期.BackColor = SystemColors.Control;
            //
            // 客戶簡稱
            //
            lbl客戶簡稱.AutoSize = false;
            lbl客戶簡稱.Location = new Point(555, 8);
            lbl客戶簡稱.Size = new Size(72, 21);
            lbl客戶簡稱.Text = "客戶簡稱";
            lbl客戶簡稱.ForeColor = Color.DimGray;
            lbl客戶簡稱.TextAlign = ContentAlignment.MiddleLeft;
            txt客戶簡稱.Location = new Point(630, 8);
            txt客戶簡稱.Size = new Size(88, 23);
            txt客戶簡稱.ReadOnly = true;
            txt客戶簡稱.BackColor = SystemColors.Control;
            //
            // 客戶(客戶名稱)
            //
            lbl客戶.AutoSize = false;
            lbl客戶.Location = new Point(721, 8);
            lbl客戶.Size = new Size(41, 21);
            lbl客戶.Text = "客戶";
            lbl客戶.ForeColor = Color.DimGray;
            lbl客戶.TextAlign = ContentAlignment.MiddleLeft;
            txt客戶名稱.Location = new Point(766, 8);
            txt客戶名稱.Size = new Size(318, 23);
            txt客戶名稱.ReadOnly = true;
            txt客戶名稱.BackColor = SystemColors.Control;
            //
            // 國家地區
            //
            lbl國家地區.AutoSize = false;
            lbl國家地區.Location = new Point(1088, 8);
            lbl國家地區.Size = new Size(68, 21);
            lbl國家地區.Text = "國家地區";
            lbl國家地區.ForeColor = Color.DimGray;
            lbl國家地區.TextAlign = ContentAlignment.MiddleLeft;
            txt國家地區.Location = new Point(1161, 8);
            txt國家地區.Size = new Size(93, 23);
            txt國家地區.ReadOnly = true;
            txt國家地區.BackColor = SystemColors.Control;
            //
            // 結案
            //
            lbl結案.AutoSize = false;
            lbl結案.Location = new Point(1258, 8);
            lbl結案.Size = new Size(44, 21);
            lbl結案.Text = "結案";
            lbl結案.ForeColor = Color.DimGray;
            lbl結案.TextAlign = ContentAlignment.MiddleLeft;
            chk結案.Location = new Point(1305, 12);
            chk結案.Size = new Size(20, 20);
            chk結案.Enabled = false;
            //
            // 機台型號
            //
            lbl機台型號.AutoSize = false;
            lbl機台型號.Location = new Point(11, 36);
            lbl機台型號.Size = new Size(72, 21);
            lbl機台型號.Text = "機台型號";
            lbl機台型號.ForeColor = Color.DimGray;
            lbl機台型號.TextAlign = ContentAlignment.MiddleLeft;
            txt機台型號.Location = new Point(86, 36);
            txt機台型號.Size = new Size(217, 23);
            txt機台型號.ReadOnly = true;
            txt機台型號.BackColor = SystemColors.Control;
            //
            // 機台類型
            //
            lbl機台類型.AutoSize = false;
            lbl機台類型.Location = new Point(321, 36);
            lbl機台類型.Size = new Size(72, 21);
            lbl機台類型.Text = "機台類型";
            lbl機台類型.ForeColor = Color.DimGray;
            lbl機台類型.TextAlign = ContentAlignment.MiddleLeft;
            txt機台類型.Location = new Point(396, 36);
            txt機台類型.Size = new Size(232, 23);
            txt機台類型.ReadOnly = true;
            txt機台類型.BackColor = SystemColors.Control;
            //
            // 驗機日期
            //
            lbl驗機日期.AutoSize = false;
            lbl驗機日期.Location = new Point(651, 36);
            lbl驗機日期.Size = new Size(72, 21);
            lbl驗機日期.Text = "驗機日期";
            lbl驗機日期.ForeColor = Color.DimGray;
            lbl驗機日期.TextAlign = ContentAlignment.MiddleLeft;
            txt驗機日期.Location = new Point(726, 36);
            txt驗機日期.Size = new Size(225, 23);
            txt驗機日期.ReadOnly = true;
            txt驗機日期.BackColor = SystemColors.Control;
            //
            // 交貨日期
            //
            lbl交貨日期.AutoSize = false;
            lbl交貨日期.Location = new Point(975, 36);
            lbl交貨日期.Size = new Size(72, 21);
            lbl交貨日期.Text = "交貨日期";
            lbl交貨日期.ForeColor = Color.DimGray;
            lbl交貨日期.TextAlign = ContentAlignment.MiddleLeft;
            txt交貨日期.Location = new Point(1051, 36);
            txt交貨日期.Size = new Size(272, 23);
            txt交貨日期.ReadOnly = true;
            txt交貨日期.BackColor = SystemColors.Control;
            //
            // 機台名稱
            //
            lbl機台名稱.AutoSize = false;
            lbl機台名稱.Location = new Point(11, 64);
            lbl機台名稱.Size = new Size(72, 21);
            lbl機台名稱.Text = "機台名稱";
            lbl機台名稱.ForeColor = Color.DimGray;
            lbl機台名稱.TextAlign = ContentAlignment.MiddleLeft;
            txt機台名稱.Location = new Point(86, 64);
            txt機台名稱.Size = new Size(866, 23);
            txt機台名稱.ReadOnly = true;
            txt機台名稱.BackColor = SystemColors.Control;
            //
            // 廠驗
            //
            lbl廠驗.AutoSize = false;
            lbl廠驗.Location = new Point(975, 64);
            lbl廠驗.Size = new Size(42, 21);
            lbl廠驗.Text = "廠驗";
            lbl廠驗.ForeColor = Color.DimGray;
            lbl廠驗.TextAlign = ContentAlignment.MiddleLeft;
            txt廠驗.Location = new Point(1020, 64);
            txt廠驗.Size = new Size(129, 23);
            txt廠驗.ReadOnly = true;
            txt廠驗.BackColor = SystemColors.Control;
            //
            // 裝機
            //
            lbl裝機.AutoSize = false;
            lbl裝機.Location = new Point(1157, 64);
            lbl裝機.Size = new Size(38, 21);
            lbl裝機.Text = "裝機";
            lbl裝機.ForeColor = Color.DimGray;
            lbl裝機.TextAlign = ContentAlignment.MiddleLeft;
            txt裝機.Location = new Point(1199, 64);
            txt裝機.Size = new Size(124, 23);
            txt裝機.ReadOnly = true;
            txt裝機.BackColor = SystemColors.Control;
            //
            // dataGridView1 (子表單「P-工程分析」：模組工時拆解清單)
            //
            dataGridView1.AllowUserToAddRows = true;
            dataGridView1.AllowUserToDeleteRows = true;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colModuleCode, colModuleName, colCheckCategory, colMakeType, colLeadDays, colDrawHours, colProcessHours, colAssembleHours, colElecHours, colTotalHours });
            dataGridView1.Font = new Font("微軟正黑體", 9F);
            dataGridView1.Location = new Point(11, 92);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = true;
            dataGridView1.RowTemplate.Height = 26;
            dataGridView1.Size = new Size(1338, 370);
            dataGridView1.TabIndex = 26;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            dataGridView1.CurrentCellDirtyStateChanged += dataGridView1_CurrentCellDirtyStateChanged;
            dataGridView1.DataError += dataGridView1_DataError;
            //
            // colModuleCode
            //
            colModuleCode.HeaderText = "模組編碼";
            colModuleCode.Name = "colModuleCode";
            colModuleCode.Width = 90;
            colModuleCode.Items.AddRange(new object[] { "AA", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" });
            //
            // colModuleName
            //
            colModuleName.HeaderText = "模組名稱";
            colModuleName.Name = "colModuleName";
            colModuleName.Width = 260;
            //
            // colCheckCategory
            //
            colCheckCategory.HeaderText = "檢查分類";
            colCheckCategory.Name = "colCheckCategory";
            colCheckCategory.ReadOnly = true;
            colCheckCategory.Width = 120;
            //
            // colMakeType
            //
            colMakeType.HeaderText = "製作區分";
            colMakeType.Name = "colMakeType";
            colMakeType.Width = 150;
            colMakeType.Items.AddRange(new object[] { "自製", "外包", "部分委外", "外購" });
            //
            // colLeadDays
            //
            colLeadDays.HeaderText = "採購前置天數";
            colLeadDays.Name = "colLeadDays";
            colLeadDays.Width = 110;
            //
            // colDrawHours
            //
            colDrawHours.HeaderText = "製圖工時";
            colDrawHours.Name = "colDrawHours";
            colDrawHours.Width = 90;
            //
            // colProcessHours
            //
            colProcessHours.HeaderText = "加工工時";
            colProcessHours.Name = "colProcessHours";
            colProcessHours.Width = 90;
            //
            // colAssembleHours
            //
            colAssembleHours.HeaderText = "組裝工時";
            colAssembleHours.Name = "colAssembleHours";
            colAssembleHours.Width = 90;
            //
            // colElecHours
            //
            colElecHours.HeaderText = "電控工時";
            colElecHours.Name = "colElecHours";
            colElecHours.Width = 90;
            //
            // colTotalHours
            //
            colTotalHours.HeaderText = "預估總工時";
            colTotalHours.Name = "colTotalHours";
            colTotalHours.ReadOnly = true;
            colTotalHours.Width = 100;
            //
            // panelFooter
            //
            panelFooter.BackColor = Color.FromArgb(252, 230, 212);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 514);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(1360, 34);
            panelFooter.TabIndex = 2;
            panelFooter.Controls.Add(lblF核准人員);
            panelFooter.Controls.Add(txtF核准);
            panelFooter.Controls.Add(txtF核准日);
            panelFooter.Controls.Add(lblF修改人員);
            panelFooter.Controls.Add(txtF修改);
            panelFooter.Controls.Add(txtF修改日);
            panelFooter.Controls.Add(lblF建檔人員);
            panelFooter.Controls.Add(txtF建檔);
            panelFooter.Controls.Add(txtF建檔日);
            //
            // 核准人員
            //
            lblF核准人員.AutoSize = false;
            lblF核准人員.Location = new Point(26, 8);
            lblF核准人員.Size = new Size(72, 21);
            lblF核准人員.Text = "核准人員";
            lblF核准人員.TextAlign = ContentAlignment.MiddleLeft;
            txtF核准.Location = new Point(102, 8);
            txtF核准.Size = new Size(95, 21);
            txtF核准.ReadOnly = true;
            txtF核准.BorderStyle = BorderStyle.None;
            txtF核准.BackColor = Color.FromArgb(252, 230, 212);
            txtF核准日.Location = new Point(200, 8);
            txtF核准日.Size = new Size(166, 21);
            txtF核准日.ReadOnly = true;
            txtF核准日.BorderStyle = BorderStyle.None;
            txtF核准日.BackColor = Color.FromArgb(252, 230, 212);
            //
            // 修改人員
            //
            lblF修改人員.AutoSize = false;
            lblF修改人員.Location = new Point(386, 8);
            lblF修改人員.Size = new Size(72, 21);
            lblF修改人員.Text = "修改人員";
            lblF修改人員.TextAlign = ContentAlignment.MiddleLeft;
            txtF修改.Location = new Point(461, 8);
            txtF修改.Size = new Size(95, 21);
            txtF修改.ReadOnly = true;
            txtF修改.BorderStyle = BorderStyle.None;
            txtF修改.BackColor = Color.FromArgb(252, 230, 212);
            txtF修改日.Location = new Point(559, 8);
            txtF修改日.Size = new Size(166, 21);
            txtF修改日.ReadOnly = true;
            txtF修改日.BorderStyle = BorderStyle.None;
            txtF修改日.BackColor = Color.FromArgb(252, 230, 212);
            //
            // 建檔人員
            //
            lblF建檔人員.AutoSize = false;
            lblF建檔人員.Location = new Point(748, 8);
            lblF建檔人員.Size = new Size(72, 21);
            lblF建檔人員.Text = "建檔人員";
            lblF建檔人員.TextAlign = ContentAlignment.MiddleLeft;
            txtF建檔.Location = new Point(823, 8);
            txtF建檔.Size = new Size(95, 21);
            txtF建檔.ReadOnly = true;
            txtF建檔.BorderStyle = BorderStyle.None;
            txtF建檔.BackColor = Color.FromArgb(252, 230, 212);
            txtF建檔日.Location = new Point(922, 8);
            txtF建檔日.Size = new Size(166, 21);
            txtF建檔日.ReadOnly = true;
            txtF建檔日.BorderStyle = BorderStyle.None;
            txtF建檔日.BackColor = Color.FromArgb(252, 230, 212);
            //
            // EngineeringAnalysisControl
            //
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelBody);
            Controls.Add(panelFooter);
            Controls.Add(panelHeader);
            Font = new Font("微軟正黑體", 9F);
            Margin = new Padding(4);
            Name = "EngineeringAnalysisControl";
            Size = new Size(1360, 548);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelFooter.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private PictureBox pictureBox1;
        private Label lblTitle;
        private Button btnEdit;
        private Button btnSave;
        private Button btnApprove;
        private Button btnUnapprove;
        private Button btnPrint;
        private Button btnOverview;
        private Button btnExit;
        private Panel panelBody;
        private Label lbl專案序號;
        private TextBox txt專案序號;
        private Label lbl訂單日期;
        private TextBox txt訂單日期;
        private Label lbl客戶簡稱;
        private TextBox txt客戶簡稱;
        private Label lbl客戶;
        private TextBox txt客戶名稱;
        private Label lbl國家地區;
        private TextBox txt國家地區;
        private Label lbl結案;
        private CheckBox chk結案;
        private Label lbl機台型號;
        private TextBox txt機台型號;
        private Label lbl機台類型;
        private TextBox txt機台類型;
        private Label lbl驗機日期;
        private TextBox txt驗機日期;
        private Label lbl交貨日期;
        private TextBox txt交貨日期;
        private Label lbl機台名稱;
        private TextBox txt機台名稱;
        private Label lbl廠驗;
        private TextBox txt廠驗;
        private Label lbl裝機;
        private TextBox txt裝機;
        private DataGridView dataGridView1;
        private DataGridViewComboBoxColumn colModuleCode;
        private DataGridViewComboBoxColumn colModuleName;
        private DataGridViewTextBoxColumn colCheckCategory;
        private DataGridViewComboBoxColumn colMakeType;
        private DataGridViewTextBoxColumn colLeadDays;
        private DataGridViewTextBoxColumn colDrawHours;
        private DataGridViewTextBoxColumn colProcessHours;
        private DataGridViewTextBoxColumn colAssembleHours;
        private DataGridViewTextBoxColumn colElecHours;
        private DataGridViewTextBoxColumn colTotalHours;
        private Panel panelFooter;
        private Label lblF核准人員;
        private TextBox txtF核准;
        private TextBox txtF核准日;
        private Label lblF修改人員;
        private TextBox txtF修改;
        private TextBox txtF修改日;
        private Label lblF建檔人員;
        private TextBox txtF建檔;
        private TextBox txtF建檔日;
    }
}
