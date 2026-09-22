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
            panelHeader.Size = new Size(1360, 60);
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
            lblTitle.Font = new Font("微軟正黑體", 12F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Firebrick;
            lblTitle.Location = new Point(73, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(90, 21);
            lblTitle.TabIndex = 1;
            lblTitle.Tag = "title";
            lblTitle.Text = "工程分析表";
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.SteelBlue;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(562, 13);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(49, 27);
            btnEdit.TabIndex = 2;
            btnEdit.Tag = "btn-modify";
            btnEdit.Text = "修改";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.SteelBlue;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(633, 13);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(49, 27);
            btnSave.TabIndex = 3;
            btnSave.Tag = "btn-modify";
            btnSave.Text = "儲存";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnApprove
            // 
            btnApprove.BackColor = Color.SteelBlue;
            btnApprove.FlatStyle = FlatStyle.Flat;
            btnApprove.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnApprove.ForeColor = Color.White;
            btnApprove.Location = new Point(704, 13);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(49, 27);
            btnApprove.TabIndex = 4;
            btnApprove.Tag = "btn-modify";
            btnApprove.Text = "生效";
            btnApprove.UseVisualStyleBackColor = false;
            btnApprove.Click += btnApprove_Click;
            // 
            // btnUnapprove
            // 
            btnUnapprove.BackColor = Color.SteelBlue;
            btnUnapprove.FlatStyle = FlatStyle.Flat;
            btnUnapprove.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnUnapprove.ForeColor = Color.White;
            btnUnapprove.Location = new Point(775, 13);
            btnUnapprove.Name = "btnUnapprove";
            btnUnapprove.Size = new Size(69, 27);
            btnUnapprove.TabIndex = 5;
            btnUnapprove.Tag = "btn-modify";
            btnUnapprove.Text = "取消生效";
            btnUnapprove.UseVisualStyleBackColor = false;
            btnUnapprove.Click += btnUnapprove_Click;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.SteelBlue;
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnPrint.ForeColor = Color.White;
            btnPrint.Location = new Point(937, 13);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(49, 27);
            btnPrint.TabIndex = 6;
            btnPrint.Tag = "btn-modify";
            btnPrint.Text = "列印";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // btnOverview
            // 
            btnOverview.BackColor = Color.SteelBlue;
            btnOverview.FlatStyle = FlatStyle.Flat;
            btnOverview.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnOverview.ForeColor = Color.White;
            btnOverview.Location = new Point(866, 13);
            btnOverview.Name = "btnOverview";
            btnOverview.Size = new Size(49, 27);
            btnOverview.TabIndex = 7;
            btnOverview.Tag = "btn-modify";
            btnOverview.Text = "總覽";
            btnOverview.UseVisualStyleBackColor = false;
            btnOverview.Click += btnOverview_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(1008, 13);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(49, 27);
            btnExit.TabIndex = 8;
            btnExit.Tag = "";
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // panelBody
            // 
            panelBody.BackColor = Color.White;
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
            panelBody.Dock = DockStyle.Fill;
            panelBody.Location = new Point(0, 60);
            panelBody.Name = "panelBody";
            panelBody.Size = new Size(1360, 454);
            panelBody.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colModuleCode, colModuleName, colCheckCategory, colMakeType, colLeadDays, colDrawHours, colProcessHours, colAssembleHours, colElecHours, colTotalHours });
            dataGridView1.Font = new Font("微軟正黑體", 9F);
            dataGridView1.Location = new Point(11, 92);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 26;
            dataGridView1.Size = new Size(1338, 354);
            dataGridView1.TabIndex = 26;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            dataGridView1.CurrentCellDirtyStateChanged += dataGridView1_CurrentCellDirtyStateChanged;
            dataGridView1.DataError += dataGridView1_DataError;
            // 
            // colModuleCode
            // 
            colModuleCode.HeaderText = "模組編碼";
            colModuleCode.Items.AddRange(new object[] { "AA", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" });
            colModuleCode.Name = "colModuleCode";
            colModuleCode.ReadOnly = true;
            colModuleCode.Width = 90;
            // 
            // colModuleName
            // 
            colModuleName.HeaderText = "模組名稱";
            colModuleName.Name = "colModuleName";
            colModuleName.ReadOnly = true;
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
            colMakeType.Items.AddRange(new object[] { "自製", "外包", "部分委外", "外購" });
            colMakeType.Name = "colMakeType";
            colMakeType.ReadOnly = true;
            colMakeType.Width = 150;
            // 
            // colLeadDays
            // 
            colLeadDays.HeaderText = "採購前置天數";
            colLeadDays.Name = "colLeadDays";
            colLeadDays.ReadOnly = true;
            colLeadDays.Width = 110;
            // 
            // colDrawHours
            // 
            colDrawHours.HeaderText = "製圖工時";
            colDrawHours.Name = "colDrawHours";
            colDrawHours.ReadOnly = true;
            colDrawHours.Width = 90;
            // 
            // colProcessHours
            // 
            colProcessHours.HeaderText = "加工工時";
            colProcessHours.Name = "colProcessHours";
            colProcessHours.ReadOnly = true;
            colProcessHours.Width = 90;
            // 
            // colAssembleHours
            // 
            colAssembleHours.HeaderText = "組裝工時";
            colAssembleHours.Name = "colAssembleHours";
            colAssembleHours.ReadOnly = true;
            colAssembleHours.Width = 90;
            // 
            // colElecHours
            // 
            colElecHours.HeaderText = "電控工時";
            colElecHours.Name = "colElecHours";
            colElecHours.ReadOnly = true;
            colElecHours.Width = 90;
            // 
            // colTotalHours
            // 
            colTotalHours.HeaderText = "預估總工時";
            colTotalHours.Name = "colTotalHours";
            colTotalHours.ReadOnly = true;
            // 
            // lbl專案序號
            // 
            lbl專案序號.ForeColor = Color.DimGray;
            lbl專案序號.Location = new Point(11, 8);
            lbl專案序號.Name = "lbl專案序號";
            lbl專案序號.Size = new Size(57, 21);
            lbl專案序號.TabIndex = 27;
            lbl專案序號.Text = "專案序號";
            lbl專案序號.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt專案序號
            // 
            txt專案序號.BackColor = SystemColors.Control;
            txt專案序號.Location = new Point(86, 8);
            txt專案序號.Name = "txt專案序號";
            txt專案序號.ReadOnly = true;
            txt專案序號.Size = new Size(217, 23);
            txt專案序號.TabIndex = 28;
            // 
            // lbl訂單日期
            // 
            lbl訂單日期.ForeColor = Color.DimGray;
            lbl訂單日期.Location = new Point(321, 8);
            lbl訂單日期.Name = "lbl訂單日期";
            lbl訂單日期.Size = new Size(57, 21);
            lbl訂單日期.TabIndex = 29;
            lbl訂單日期.Text = "訂單日期";
            lbl訂單日期.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt訂單日期
            // 
            txt訂單日期.BackColor = SystemColors.Control;
            txt訂單日期.Location = new Point(396, 8);
            txt訂單日期.Name = "txt訂單日期";
            txt訂單日期.ReadOnly = true;
            txt訂單日期.Size = new Size(109, 23);
            txt訂單日期.TabIndex = 30;
            // 
            // lbl客戶簡稱
            // 
            lbl客戶簡稱.ForeColor = Color.DimGray;
            lbl客戶簡稱.Location = new Point(511, 8);
            lbl客戶簡稱.Name = "lbl客戶簡稱";
            lbl客戶簡稱.Size = new Size(57, 21);
            lbl客戶簡稱.TabIndex = 31;
            lbl客戶簡稱.Text = "客戶簡稱";
            lbl客戶簡稱.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt客戶簡稱
            // 
            txt客戶簡稱.BackColor = SystemColors.Control;
            txt客戶簡稱.Location = new Point(586, 8);
            txt客戶簡稱.Name = "txt客戶簡稱";
            txt客戶簡稱.ReadOnly = true;
            txt客戶簡稱.Size = new Size(88, 23);
            txt客戶簡稱.TabIndex = 32;
            // 
            // lbl客戶
            // 
            lbl客戶.ForeColor = Color.DimGray;
            lbl客戶.Location = new Point(688, 9);
            lbl客戶.Name = "lbl客戶";
            lbl客戶.Size = new Size(41, 21);
            lbl客戶.TabIndex = 33;
            lbl客戶.Text = "客戶";
            lbl客戶.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt客戶名稱
            // 
            txt客戶名稱.BackColor = SystemColors.Control;
            txt客戶名稱.Location = new Point(766, 8);
            txt客戶名稱.Name = "txt客戶名稱";
            txt客戶名稱.ReadOnly = true;
            txt客戶名稱.Size = new Size(185, 23);
            txt客戶名稱.TabIndex = 34;
            // 
            // lbl國家地區
            // 
            lbl國家地區.ForeColor = Color.DimGray;
            lbl國家地區.Location = new Point(975, 8);
            lbl國家地區.Name = "lbl國家地區";
            lbl國家地區.Size = new Size(55, 21);
            lbl國家地區.TabIndex = 35;
            lbl國家地區.Text = "國家地區";
            lbl國家地區.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt國家地區
            // 
            txt國家地區.BackColor = SystemColors.Control;
            txt國家地區.Location = new Point(1051, 6);
            txt國家地區.Name = "txt國家地區";
            txt國家地區.ReadOnly = true;
            txt國家地區.Size = new Size(117, 23);
            txt國家地區.TabIndex = 36;
            // 
            // lbl結案
            // 
            lbl結案.ForeColor = Color.DimGray;
            lbl結案.Location = new Point(1174, 7);
            lbl結案.Name = "lbl結案";
            lbl結案.Size = new Size(44, 21);
            lbl結案.TabIndex = 37;
            lbl結案.Text = "結案";
            lbl結案.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // chk結案
            // 
            chk結案.Enabled = false;
            chk結案.Location = new Point(1224, 7);
            chk結案.Name = "chk結案";
            chk結案.Size = new Size(20, 20);
            chk結案.TabIndex = 38;
            // 
            // lbl機台型號
            // 
            lbl機台型號.ForeColor = Color.DimGray;
            lbl機台型號.Location = new Point(11, 36);
            lbl機台型號.Name = "lbl機台型號";
            lbl機台型號.Size = new Size(57, 21);
            lbl機台型號.TabIndex = 39;
            lbl機台型號.Text = "機台型號";
            lbl機台型號.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt機台型號
            // 
            txt機台型號.BackColor = SystemColors.Control;
            txt機台型號.Location = new Point(86, 36);
            txt機台型號.Name = "txt機台型號";
            txt機台型號.ReadOnly = true;
            txt機台型號.Size = new Size(217, 23);
            txt機台型號.TabIndex = 40;
            // 
            // lbl機台類型
            // 
            lbl機台類型.ForeColor = Color.DimGray;
            lbl機台類型.Location = new Point(321, 36);
            lbl機台類型.Name = "lbl機台類型";
            lbl機台類型.Size = new Size(57, 21);
            lbl機台類型.TabIndex = 41;
            lbl機台類型.Text = "機台類型";
            lbl機台類型.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt機台類型
            // 
            txt機台類型.BackColor = SystemColors.Control;
            txt機台類型.Location = new Point(396, 36);
            txt機台類型.Name = "txt機台類型";
            txt機台類型.ReadOnly = true;
            txt機台類型.Size = new Size(278, 23);
            txt機台類型.TabIndex = 42;
            // 
            // lbl驗機日期
            // 
            lbl驗機日期.ForeColor = Color.DimGray;
            lbl驗機日期.Location = new Point(688, 37);
            lbl驗機日期.Name = "lbl驗機日期";
            lbl驗機日期.Size = new Size(65, 21);
            lbl驗機日期.TabIndex = 43;
            lbl驗機日期.Text = "驗機日期";
            lbl驗機日期.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt驗機日期
            // 
            txt驗機日期.BackColor = SystemColors.Control;
            txt驗機日期.Location = new Point(766, 36);
            txt驗機日期.Name = "txt驗機日期";
            txt驗機日期.ReadOnly = true;
            txt驗機日期.Size = new Size(185, 23);
            txt驗機日期.TabIndex = 44;
            // 
            // lbl交貨日期
            // 
            lbl交貨日期.ForeColor = Color.DimGray;
            lbl交貨日期.Location = new Point(975, 36);
            lbl交貨日期.Name = "lbl交貨日期";
            lbl交貨日期.Size = new Size(55, 21);
            lbl交貨日期.TabIndex = 45;
            lbl交貨日期.Text = "交貨日期";
            lbl交貨日期.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt交貨日期
            // 
            txt交貨日期.BackColor = SystemColors.Control;
            txt交貨日期.Location = new Point(1051, 36);
            txt交貨日期.Name = "txt交貨日期";
            txt交貨日期.ReadOnly = true;
            txt交貨日期.Size = new Size(213, 23);
            txt交貨日期.TabIndex = 46;
            // 
            // lbl機台名稱
            // 
            lbl機台名稱.ForeColor = Color.DimGray;
            lbl機台名稱.Location = new Point(11, 64);
            lbl機台名稱.Name = "lbl機台名稱";
            lbl機台名稱.Size = new Size(57, 21);
            lbl機台名稱.TabIndex = 47;
            lbl機台名稱.Text = "機台名稱";
            lbl機台名稱.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt機台名稱
            // 
            txt機台名稱.BackColor = SystemColors.Control;
            txt機台名稱.Location = new Point(86, 64);
            txt機台名稱.Name = "txt機台名稱";
            txt機台名稱.ReadOnly = true;
            txt機台名稱.Size = new Size(866, 23);
            txt機台名稱.TabIndex = 48;
            // 
            // lbl廠驗
            // 
            lbl廠驗.ForeColor = Color.DimGray;
            lbl廠驗.Location = new Point(975, 64);
            lbl廠驗.Name = "lbl廠驗";
            lbl廠驗.Size = new Size(36, 21);
            lbl廠驗.TabIndex = 49;
            lbl廠驗.Text = "廠驗";
            lbl廠驗.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt廠驗
            // 
            txt廠驗.BackColor = SystemColors.Control;
            txt廠驗.Location = new Point(1051, 64);
            txt廠驗.Name = "txt廠驗";
            txt廠驗.ReadOnly = true;
            txt廠驗.Size = new Size(98, 23);
            txt廠驗.TabIndex = 50;
            // 
            // lbl裝機
            // 
            lbl裝機.ForeColor = Color.DimGray;
            lbl裝機.Location = new Point(1157, 64);
            lbl裝機.Name = "lbl裝機";
            lbl裝機.Size = new Size(36, 21);
            lbl裝機.TabIndex = 51;
            lbl裝機.Text = "裝機";
            lbl裝機.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt裝機
            // 
            txt裝機.BackColor = SystemColors.Control;
            txt裝機.Location = new Point(1199, 64);
            txt裝機.Name = "txt裝機";
            txt裝機.ReadOnly = true;
            txt裝機.Size = new Size(65, 23);
            txt裝機.TabIndex = 52;
            // 
            // panelFooter
            // 
            panelFooter.BackColor = Color.FromArgb(252, 230, 212);
            panelFooter.Controls.Add(lblF核准人員);
            panelFooter.Controls.Add(txtF核准);
            panelFooter.Controls.Add(txtF核准日);
            panelFooter.Controls.Add(lblF修改人員);
            panelFooter.Controls.Add(txtF修改);
            panelFooter.Controls.Add(txtF修改日);
            panelFooter.Controls.Add(lblF建檔人員);
            panelFooter.Controls.Add(txtF建檔);
            panelFooter.Controls.Add(txtF建檔日);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 514);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(1360, 34);
            panelFooter.TabIndex = 2;
            // 
            // lblF核准人員
            // 
            lblF核准人員.Location = new Point(26, 8);
            lblF核准人員.Name = "lblF核准人員";
            lblF核准人員.Size = new Size(57, 21);
            lblF核准人員.TabIndex = 0;
            lblF核准人員.Text = "核准人員";
            lblF核准人員.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtF核准
            // 
            txtF核准.BackColor = Color.FromArgb(252, 230, 212);
            txtF核准.BorderStyle = BorderStyle.None;
            txtF核准.Location = new Point(102, 8);
            txtF核准.Name = "txtF核准";
            txtF核准.ReadOnly = true;
            txtF核准.Size = new Size(95, 16);
            txtF核准.TabIndex = 1;
            // 
            // txtF核准日
            // 
            txtF核准日.BackColor = Color.FromArgb(252, 230, 212);
            txtF核准日.BorderStyle = BorderStyle.None;
            txtF核准日.Location = new Point(200, 8);
            txtF核准日.Name = "txtF核准日";
            txtF核准日.ReadOnly = true;
            txtF核准日.Size = new Size(166, 16);
            txtF核准日.TabIndex = 2;
            // 
            // lblF修改人員
            // 
            lblF修改人員.Location = new Point(386, 8);
            lblF修改人員.Name = "lblF修改人員";
            lblF修改人員.Size = new Size(57, 21);
            lblF修改人員.TabIndex = 3;
            lblF修改人員.Text = "修改人員";
            lblF修改人員.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtF修改
            // 
            txtF修改.BackColor = Color.FromArgb(252, 230, 212);
            txtF修改.BorderStyle = BorderStyle.None;
            txtF修改.Location = new Point(461, 8);
            txtF修改.Name = "txtF修改";
            txtF修改.ReadOnly = true;
            txtF修改.Size = new Size(95, 16);
            txtF修改.TabIndex = 4;
            // 
            // txtF修改日
            // 
            txtF修改日.BackColor = Color.FromArgb(252, 230, 212);
            txtF修改日.BorderStyle = BorderStyle.None;
            txtF修改日.Location = new Point(559, 8);
            txtF修改日.Name = "txtF修改日";
            txtF修改日.ReadOnly = true;
            txtF修改日.Size = new Size(166, 16);
            txtF修改日.TabIndex = 5;
            // 
            // lblF建檔人員
            // 
            lblF建檔人員.Location = new Point(748, 8);
            lblF建檔人員.Name = "lblF建檔人員";
            lblF建檔人員.Size = new Size(55, 21);
            lblF建檔人員.TabIndex = 6;
            lblF建檔人員.Text = "建檔人員";
            lblF建檔人員.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtF建檔
            // 
            txtF建檔.BackColor = Color.FromArgb(252, 230, 212);
            txtF建檔.BorderStyle = BorderStyle.None;
            txtF建檔.Location = new Point(823, 8);
            txtF建檔.Name = "txtF建檔";
            txtF建檔.ReadOnly = true;
            txtF建檔.Size = new Size(95, 16);
            txtF建檔.TabIndex = 7;
            // 
            // txtF建檔日
            // 
            txtF建檔日.BackColor = Color.FromArgb(252, 230, 212);
            txtF建檔日.BorderStyle = BorderStyle.None;
            txtF建檔日.Location = new Point(922, 8);
            txtF建檔日.Name = "txtF建檔日";
            txtF建檔日.ReadOnly = true;
            txtF建檔日.Size = new Size(166, 16);
            txtF建檔日.TabIndex = 8;
            // 
            // EngineeringAnalysisControl
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
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
            panelBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelFooter.ResumeLayout(false);
            panelFooter.PerformLayout();
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
