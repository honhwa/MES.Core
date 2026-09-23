using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.Project
{
    partial class ProjectMeetingControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼
        //
        // 版面比照 PITS-2025.accdb「P-會議」表單(Caption="專案會議履歷")之控制項
        // 座標(twips/15=px)還原，配色亦比照原表單：表單首/尾為淺灰
        // RGB(216,216,216)，詳細資料區為近白 RGB(255,255,249)，按鈕為深灰藍
        // RGB(69,98,135)配白字 ─────────────────────────────────────────
        //
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectMeetingControl));
            panelHeader = new Panel();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            btnAdd = new Button();
            btnRefresh = new Button();
            btnExit = new Button();
            panelBody = new Panel();
            dataGridView1 = new DataGridView();
            colRecordNo = new DataGridViewTextBoxColumn();
            colDate = new DataGridViewTextBoxColumn();
            colType = new DataGridViewTextBoxColumn();
            colRecorder = new DataGridViewTextBoxColumn();
            colProposer = new DataGridViewTextBoxColumn();
            colOwnerUnit = new DataGridViewTextBoxColumn();
            colTopic = new DataGridViewTextBoxColumn();
            colResolution = new DataGridViewTextBoxColumn();
            colNeedReply = new DataGridViewCheckBoxColumn();
            colReplyPerson = new DataGridViewTextBoxColumn();
            colExpectDate = new DataGridViewTextBoxColumn();
            colActualDate = new DataGridViewTextBoxColumn();
            colReplyDesc = new DataGridViewTextBoxColumn();
            colManagerReview = new DataGridViewCheckBoxColumn();
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
            lbl參考序號 = new Label();
            txt參考序號 = new TextBox();
            lbl電流 = new Label();
            txt電流 = new TextBox();
            lbl審圖需求 = new Label();
            txt圖面設計 = new TextBox();
            lbl驗機日期 = new Label();
            txt驗機日期 = new TextBox();
            lbl機台型號 = new Label();
            txt機台型號 = new TextBox();
            lbl焊接電壓 = new Label();
            txt焊接電壓v = new TextBox();
            txt焊接電壓hz = new TextBox();
            txt焊接電壓 = new TextBox();
            lbl安規要求 = new Label();
            txt安規要求 = new TextBox();
            lbl廠驗 = new Label();
            txt廠驗 = new TextBox();
            lbl機台類型 = new Label();
            txt機台類型 = new TextBox();
            lbl控制電壓 = new Label();
            txt焊接物 = new TextBox();
            lbl生產速率 = new Label();
            txt生產速率 = new TextBox();
            lbl交貨日期 = new Label();
            txt交貨日期 = new TextBox();
            lbl機台名稱 = new Label();
            txt機台名稱 = new TextBox();
            lbl裝機 = new Label();
            txt裝機 = new TextBox();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(216, 216, 216);
            panelHeader.Controls.Add(pictureBox1);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Controls.Add(btnAdd);
            panelHeader.Controls.Add(btnRefresh);
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
            lblTitle.ForeColor = Color.FromArgb(69, 98, 135);
            lblTitle.Location = new Point(73, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(106, 21);
            lblTitle.TabIndex = 1;
            lblTitle.Tag = "title";
            lblTitle.Text = "專案會議履歷";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(69, 98, 135);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(834, 7);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(98, 27);
            btnAdd.TabIndex = 2;
            btnAdd.Tag = "btn-modify";
            btnAdd.Text = "新增紀錄";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(69, 98, 135);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(940, 7);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(98, 27);
            btnRefresh.TabIndex = 3;
            btnRefresh.Tag = "btn-modify";
            btnRefresh.Text = "重新整理";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(69, 98, 135);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(1046, 7);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(98, 27);
            btnExit.TabIndex = 4;
            btnExit.Tag = "btn-modify";
            btnExit.Text = "關閉表單";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Visible = false;
            btnExit.Click += btnExit_Click;
            // 
            // panelBody
            // 
            panelBody.BackColor = Color.FromArgb(255, 255, 249);
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
            panelBody.Controls.Add(lbl參考序號);
            panelBody.Controls.Add(txt參考序號);
            panelBody.Controls.Add(lbl電流);
            panelBody.Controls.Add(txt電流);
            panelBody.Controls.Add(lbl審圖需求);
            panelBody.Controls.Add(txt圖面設計);
            panelBody.Controls.Add(lbl驗機日期);
            panelBody.Controls.Add(txt驗機日期);
            panelBody.Controls.Add(lbl機台型號);
            panelBody.Controls.Add(txt機台型號);
            panelBody.Controls.Add(lbl焊接電壓);
            panelBody.Controls.Add(txt焊接電壓v);
            panelBody.Controls.Add(txt焊接電壓hz);
            panelBody.Controls.Add(txt焊接電壓);
            panelBody.Controls.Add(lbl安規要求);
            panelBody.Controls.Add(txt安規要求);
            panelBody.Controls.Add(lbl廠驗);
            panelBody.Controls.Add(txt廠驗);
            panelBody.Controls.Add(lbl機台類型);
            panelBody.Controls.Add(txt機台類型);
            panelBody.Controls.Add(lbl控制電壓);
            panelBody.Controls.Add(txt焊接物);
            panelBody.Controls.Add(lbl生產速率);
            panelBody.Controls.Add(txt生產速率);
            panelBody.Controls.Add(lbl交貨日期);
            panelBody.Controls.Add(txt交貨日期);
            panelBody.Controls.Add(lbl機台名稱);
            panelBody.Controls.Add(txt機台名稱);
            panelBody.Controls.Add(lbl裝機);
            panelBody.Controls.Add(txt裝機);
            panelBody.Dock = DockStyle.Fill;
            panelBody.Location = new Point(0, 60);
            panelBody.Name = "panelBody";
            panelBody.Size = new Size(1360, 518);
            panelBody.TabIndex = 1;
            panelBody.Tag = "btn-modify";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colRecordNo, colDate, colType, colRecorder, colProposer, colOwnerUnit, colTopic, colResolution, colNeedReply, colReplyPerson, colExpectDate, colActualDate, colReplyDesc, colManagerReview });
            dataGridView1.Font = new Font("微軟正黑體", 9F);
            dataGridView1.Location = new Point(11, 167);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 26;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1338, 333);
            dataGridView1.TabIndex = 100;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // colRecordNo
            // 
            colRecordNo.HeaderText = "紀錄單號";
            colRecordNo.Name = "colRecordNo";
            colRecordNo.ReadOnly = true;
            colRecordNo.Width = 90;
            // 
            // colDate
            // 
            colDate.HeaderText = "日期";
            colDate.Name = "colDate";
            colDate.ReadOnly = true;
            colDate.Width = 80;
            // 
            // colType
            // 
            colType.HeaderText = "紀錄類別";
            colType.Name = "colType";
            colType.ReadOnly = true;
            colType.Width = 80;
            // 
            // colRecorder
            // 
            colRecorder.HeaderText = "記錄人員";
            colRecorder.Name = "colRecorder";
            colRecorder.ReadOnly = true;
            colRecorder.Width = 70;
            // 
            // colProposer
            // 
            colProposer.HeaderText = "事項提議人";
            colProposer.Name = "colProposer";
            colProposer.ReadOnly = true;
            colProposer.Width = 80;
            // 
            // colOwnerUnit
            // 
            colOwnerUnit.HeaderText = "主題";
            colOwnerUnit.Name = "colOwnerUnit";
            colOwnerUnit.ReadOnly = true;
            // 
            // colTopic
            // 
            colTopic.HeaderText = "問題或討論事項";
            colTopic.Name = "colTopic";
            colTopic.ReadOnly = true;
            colTopic.Width = 220;
            // 
            // colResolution
            // 
            colResolution.HeaderText = "結論或執行方式";
            colResolution.Name = "colResolution";
            colResolution.ReadOnly = true;
            colResolution.Width = 180;
            // 
            // colNeedReply
            // 
            colNeedReply.HeaderText = "需回覆";
            colNeedReply.Name = "colNeedReply";
            colNeedReply.ReadOnly = true;
            colNeedReply.Width = 50;
            // 
            // colReplyPerson
            // 
            colReplyPerson.HeaderText = "應回報人員";
            colReplyPerson.Name = "colReplyPerson";
            colReplyPerson.ReadOnly = true;
            colReplyPerson.Width = 80;
            // 
            // colExpectDate
            // 
            colExpectDate.HeaderText = "預計回報日期";
            colExpectDate.Name = "colExpectDate";
            colExpectDate.ReadOnly = true;
            colExpectDate.Width = 90;
            // 
            // colActualDate
            // 
            colActualDate.HeaderText = "實際回報日期";
            colActualDate.Name = "colActualDate";
            colActualDate.ReadOnly = true;
            colActualDate.Width = 90;
            // 
            // colReplyDesc
            // 
            colReplyDesc.HeaderText = "回覆說明";
            colReplyDesc.Name = "colReplyDesc";
            colReplyDesc.ReadOnly = true;
            colReplyDesc.Width = 150;
            // 
            // colManagerReview
            // 
            colManagerReview.HeaderText = "管理者審閱";
            colManagerReview.Name = "colManagerReview";
            colManagerReview.ReadOnly = true;
            colManagerReview.Width = 70;
            // 
            // lbl專案序號
            // 
            lbl專案序號.ForeColor = Color.DimGray;
            lbl專案序號.Location = new Point(11, 8);
            lbl專案序號.Name = "lbl專案序號";
            lbl專案序號.Size = new Size(72, 21);
            lbl專案序號.TabIndex = 101;
            lbl專案序號.Text = "專案序號";
            lbl專案序號.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt專案序號
            // 
            txt專案序號.BackColor = SystemColors.Control;
            txt專案序號.Location = new Point(86, 8);
            txt專案序號.Name = "txt專案序號";
            txt專案序號.ReadOnly = true;
            txt專案序號.Size = new Size(170, 23);
            txt專案序號.TabIndex = 102;
            // 
            // lbl訂單日期
            // 
            lbl訂單日期.ForeColor = Color.DimGray;
            lbl訂單日期.Location = new Point(273, 8);
            lbl訂單日期.Name = "lbl訂單日期";
            lbl訂單日期.Size = new Size(72, 21);
            lbl訂單日期.TabIndex = 103;
            lbl訂單日期.Text = "訂單日期";
            lbl訂單日期.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt訂單日期
            // 
            txt訂單日期.BackColor = SystemColors.Control;
            txt訂單日期.Location = new Point(347, 8);
            txt訂單日期.Name = "txt訂單日期";
            txt訂單日期.ReadOnly = true;
            txt訂單日期.Size = new Size(82, 23);
            txt訂單日期.TabIndex = 104;
            // 
            // lbl客戶簡稱
            // 
            lbl客戶簡稱.ForeColor = Color.DimGray;
            lbl客戶簡稱.Location = new Point(435, 8);
            lbl客戶簡稱.Name = "lbl客戶簡稱";
            lbl客戶簡稱.Size = new Size(60, 21);
            lbl客戶簡稱.TabIndex = 105;
            lbl客戶簡稱.Text = "客戶簡稱";
            lbl客戶簡稱.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt客戶簡稱
            // 
            txt客戶簡稱.BackColor = SystemColors.Control;
            txt客戶簡稱.Location = new Point(499, 8);
            txt客戶簡稱.Name = "txt客戶簡稱";
            txt客戶簡稱.ReadOnly = true;
            txt客戶簡稱.Size = new Size(87, 23);
            txt客戶簡稱.TabIndex = 106;
            // 
            // lbl客戶
            // 
            lbl客戶.ForeColor = Color.DimGray;
            lbl客戶.Location = new Point(628, 8);
            lbl客戶.Name = "lbl客戶";
            lbl客戶.Size = new Size(37, 21);
            lbl客戶.TabIndex = 107;
            lbl客戶.Text = "客戶";
            lbl客戶.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt客戶名稱
            // 
            txt客戶名稱.BackColor = SystemColors.Control;
            txt客戶名稱.Location = new Point(703, 8);
            txt客戶名稱.Name = "txt客戶名稱";
            txt客戶名稱.ReadOnly = true;
            txt客戶名稱.Size = new Size(182, 23);
            txt客戶名稱.TabIndex = 108;
            // 
            // lbl國家地區
            // 
            lbl國家地區.ForeColor = Color.DimGray;
            lbl國家地區.Location = new Point(899, 8);
            lbl國家地區.Name = "lbl國家地區";
            lbl國家地區.Size = new Size(68, 21);
            lbl國家地區.TabIndex = 109;
            lbl國家地區.Text = "國家地區";
            lbl國家地區.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt國家地區
            // 
            txt國家地區.BackColor = SystemColors.Control;
            txt國家地區.Location = new Point(972, 8);
            txt國家地區.Name = "txt國家地區";
            txt國家地區.ReadOnly = true;
            txt國家地區.Size = new Size(93, 23);
            txt國家地區.TabIndex = 110;
            // 
            // lbl結案
            // 
            lbl結案.ForeColor = Color.DimGray;
            lbl結案.Location = new Point(1073, 8);
            lbl結案.Name = "lbl結案";
            lbl結案.Size = new Size(44, 21);
            lbl結案.TabIndex = 111;
            lbl結案.Text = "結案";
            lbl結案.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // chk結案
            // 
            chk結案.Enabled = false;
            chk結案.Location = new Point(1120, 9);
            chk結案.Name = "chk結案";
            chk結案.Size = new Size(20, 18);
            chk結案.TabIndex = 112;
            // 
            // lbl參考序號
            // 
            lbl參考序號.ForeColor = Color.DimGray;
            lbl參考序號.Location = new Point(11, 37);
            lbl參考序號.Name = "lbl參考序號";
            lbl參考序號.Size = new Size(72, 21);
            lbl參考序號.TabIndex = 113;
            lbl參考序號.Text = "參考序號";
            lbl參考序號.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt參考序號
            // 
            txt參考序號.BackColor = SystemColors.Control;
            txt參考序號.Location = new Point(86, 37);
            txt參考序號.Name = "txt參考序號";
            txt參考序號.ReadOnly = true;
            txt參考序號.Size = new Size(170, 23);
            txt參考序號.TabIndex = 114;
            // 
            // lbl電流
            // 
            lbl電流.ForeColor = Color.DimGray;
            lbl電流.Location = new Point(273, 37);
            lbl電流.Name = "lbl電流";
            lbl電流.Size = new Size(72, 21);
            lbl電流.TabIndex = 115;
            lbl電流.Text = "電流";
            lbl電流.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt電流
            // 
            txt電流.BackColor = SystemColors.Control;
            txt電流.Location = new Point(348, 37);
            txt電流.Name = "txt電流";
            txt電流.ReadOnly = true;
            txt電流.Size = new Size(238, 23);
            txt電流.TabIndex = 116;
            // 
            // lbl審圖需求
            // 
            lbl審圖需求.ForeColor = Color.DimGray;
            lbl審圖需求.Location = new Point(628, 37);
            lbl審圖需求.Name = "lbl審圖需求";
            lbl審圖需求.Size = new Size(71, 21);
            lbl審圖需求.TabIndex = 117;
            lbl審圖需求.Text = "審圖需求";
            lbl審圖需求.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt圖面設計
            // 
            txt圖面設計.BackColor = SystemColors.Control;
            txt圖面設計.Location = new Point(703, 37);
            txt圖面設計.Name = "txt圖面設計";
            txt圖面設計.ReadOnly = true;
            txt圖面設計.Size = new Size(182, 23);
            txt圖面設計.TabIndex = 118;
            // 
            // lbl驗機日期
            // 
            lbl驗機日期.ForeColor = Color.DimGray;
            lbl驗機日期.Location = new Point(899, 37);
            lbl驗機日期.Name = "lbl驗機日期";
            lbl驗機日期.Size = new Size(72, 21);
            lbl驗機日期.TabIndex = 119;
            lbl驗機日期.Text = "驗機日期";
            lbl驗機日期.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt驗機日期
            // 
            txt驗機日期.BackColor = SystemColors.Control;
            txt驗機日期.Location = new Point(974, 37);
            txt驗機日期.Name = "txt驗機日期";
            txt驗機日期.ReadOnly = true;
            txt驗機日期.Size = new Size(181, 23);
            txt驗機日期.TabIndex = 120;
            // 
            // lbl機台型號
            // 
            lbl機台型號.ForeColor = Color.DimGray;
            lbl機台型號.Location = new Point(11, 66);
            lbl機台型號.Name = "lbl機台型號";
            lbl機台型號.Size = new Size(72, 21);
            lbl機台型號.TabIndex = 121;
            lbl機台型號.Text = "機台型號";
            lbl機台型號.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt機台型號
            // 
            txt機台型號.BackColor = SystemColors.Control;
            txt機台型號.Location = new Point(86, 66);
            txt機台型號.Name = "txt機台型號";
            txt機台型號.ReadOnly = true;
            txt機台型號.Size = new Size(170, 23);
            txt機台型號.TabIndex = 122;
            // 
            // lbl焊接電壓
            // 
            lbl焊接電壓.ForeColor = Color.DimGray;
            lbl焊接電壓.Location = new Point(273, 66);
            lbl焊接電壓.Name = "lbl焊接電壓";
            lbl焊接電壓.Size = new Size(72, 21);
            lbl焊接電壓.TabIndex = 123;
            lbl焊接電壓.Text = "焊接電壓";
            lbl焊接電壓.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt焊接電壓v
            // 
            txt焊接電壓v.BackColor = SystemColors.Control;
            txt焊接電壓v.Location = new Point(348, 66);
            txt焊接電壓v.Name = "txt焊接電壓v";
            txt焊接電壓v.ReadOnly = true;
            txt焊接電壓v.Size = new Size(69, 23);
            txt焊接電壓v.TabIndex = 124;
            // 
            // txt焊接電壓hz
            // 
            txt焊接電壓hz.BackColor = SystemColors.Control;
            txt焊接電壓hz.Location = new Point(423, 66);
            txt焊接電壓hz.Name = "txt焊接電壓hz";
            txt焊接電壓hz.ReadOnly = true;
            txt焊接電壓hz.Size = new Size(70, 23);
            txt焊接電壓hz.TabIndex = 125;
            // 
            // txt焊接電壓
            // 
            txt焊接電壓.BackColor = SystemColors.Control;
            txt焊接電壓.Location = new Point(499, 66);
            txt焊接電壓.Name = "txt焊接電壓";
            txt焊接電壓.ReadOnly = true;
            txt焊接電壓.Size = new Size(87, 23);
            txt焊接電壓.TabIndex = 126;
            // 
            // lbl安規要求
            // 
            lbl安規要求.ForeColor = Color.DimGray;
            lbl安規要求.Location = new Point(628, 66);
            lbl安規要求.Name = "lbl安規要求";
            lbl安規要求.Size = new Size(71, 21);
            lbl安規要求.TabIndex = 127;
            lbl安規要求.Text = "安規要求";
            lbl安規要求.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt安規要求
            // 
            txt安規要求.BackColor = SystemColors.Control;
            txt安規要求.Location = new Point(703, 66);
            txt安規要求.Name = "txt安規要求";
            txt安規要求.ReadOnly = true;
            txt安規要求.Size = new Size(182, 23);
            txt安規要求.TabIndex = 128;
            // 
            // lbl廠驗
            // 
            lbl廠驗.ForeColor = Color.DimGray;
            lbl廠驗.Location = new Point(899, 66);
            lbl廠驗.Name = "lbl廠驗";
            lbl廠驗.Size = new Size(72, 21);
            lbl廠驗.TabIndex = 129;
            lbl廠驗.Text = "廠驗";
            lbl廠驗.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt廠驗
            // 
            txt廠驗.BackColor = SystemColors.Control;
            txt廠驗.Location = new Point(975, 66);
            txt廠驗.Name = "txt廠驗";
            txt廠驗.ReadOnly = true;
            txt廠驗.Size = new Size(181, 23);
            txt廠驗.TabIndex = 130;
            // 
            // lbl機台類型
            // 
            lbl機台類型.ForeColor = Color.DimGray;
            lbl機台類型.Location = new Point(11, 95);
            lbl機台類型.Name = "lbl機台類型";
            lbl機台類型.Size = new Size(72, 21);
            lbl機台類型.TabIndex = 131;
            lbl機台類型.Text = "機台類型";
            lbl機台類型.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt機台類型
            // 
            txt機台類型.BackColor = SystemColors.Control;
            txt機台類型.Location = new Point(86, 95);
            txt機台類型.Name = "txt機台類型";
            txt機台類型.ReadOnly = true;
            txt機台類型.Size = new Size(170, 23);
            txt機台類型.TabIndex = 132;
            // 
            // lbl控制電壓
            // 
            lbl控制電壓.ForeColor = Color.DimGray;
            lbl控制電壓.Location = new Point(273, 95);
            lbl控制電壓.Name = "lbl控制電壓";
            lbl控制電壓.Size = new Size(71, 21);
            lbl控制電壓.TabIndex = 133;
            lbl控制電壓.Text = "控制電壓";
            lbl控制電壓.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt焊接物
            // 
            txt焊接物.BackColor = SystemColors.Control;
            txt焊接物.Location = new Point(348, 95);
            txt焊接物.Name = "txt焊接物";
            txt焊接物.ReadOnly = true;
            txt焊接物.Size = new Size(239, 23);
            txt焊接物.TabIndex = 134;
            // 
            // lbl生產速率
            // 
            lbl生產速率.ForeColor = Color.DimGray;
            lbl生產速率.Location = new Point(628, 95);
            lbl生產速率.Name = "lbl生產速率";
            lbl生產速率.Size = new Size(71, 21);
            lbl生產速率.TabIndex = 135;
            lbl生產速率.Text = "生產速率";
            lbl生產速率.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt生產速率
            // 
            txt生產速率.BackColor = SystemColors.Control;
            txt生產速率.Location = new Point(703, 95);
            txt生產速率.Name = "txt生產速率";
            txt生產速率.ReadOnly = true;
            txt生產速率.Size = new Size(182, 23);
            txt生產速率.TabIndex = 136;
            // 
            // lbl交貨日期
            // 
            lbl交貨日期.ForeColor = Color.DimGray;
            lbl交貨日期.Location = new Point(899, 95);
            lbl交貨日期.Name = "lbl交貨日期";
            lbl交貨日期.Size = new Size(72, 21);
            lbl交貨日期.TabIndex = 137;
            lbl交貨日期.Text = "交貨日期";
            lbl交貨日期.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt交貨日期
            // 
            txt交貨日期.BackColor = SystemColors.Control;
            txt交貨日期.Location = new Point(975, 95);
            txt交貨日期.Name = "txt交貨日期";
            txt交貨日期.ReadOnly = true;
            txt交貨日期.Size = new Size(181, 23);
            txt交貨日期.TabIndex = 138;
            // 
            // lbl機台名稱
            // 
            lbl機台名稱.ForeColor = Color.DimGray;
            lbl機台名稱.Location = new Point(11, 124);
            lbl機台名稱.Name = "lbl機台名稱";
            lbl機台名稱.Size = new Size(72, 21);
            lbl機台名稱.TabIndex = 139;
            lbl機台名稱.Text = "機台名稱";
            lbl機台名稱.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt機台名稱
            // 
            txt機台名稱.BackColor = SystemColors.Control;
            txt機台名稱.Location = new Point(86, 124);
            txt機台名稱.Name = "txt機台名稱";
            txt機台名稱.ReadOnly = true;
            txt機台名稱.Size = new Size(799, 23);
            txt機台名稱.TabIndex = 140;
            // 
            // lbl裝機
            // 
            lbl裝機.ForeColor = Color.DimGray;
            lbl裝機.Location = new Point(899, 124);
            lbl裝機.Name = "lbl裝機";
            lbl裝機.Size = new Size(72, 21);
            lbl裝機.TabIndex = 141;
            lbl裝機.Text = "裝機";
            lbl裝機.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt裝機
            // 
            txt裝機.BackColor = SystemColors.Control;
            txt裝機.Location = new Point(975, 124);
            txt裝機.Name = "txt裝機";
            txt裝機.ReadOnly = true;
            txt裝機.Size = new Size(181, 23);
            txt裝機.TabIndex = 142;
            // 
            // ProjectMeetingControl
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelBody);
            Controls.Add(panelHeader);
            Font = new Font("微軟正黑體", 9F);
            Margin = new Padding(4);
            Name = "ProjectMeetingControl";
            Size = new Size(1360, 578);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelBody.ResumeLayout(false);
            panelBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private PictureBox pictureBox1;
        private Label lblTitle;
        private Button btnAdd;
        private Button btnRefresh;
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
        private Label lbl參考序號;
        private TextBox txt參考序號;
        private Label lbl電流;
        private TextBox txt電流;
        private Label lbl審圖需求;
        private TextBox txt圖面設計;
        private Label lbl驗機日期;
        private TextBox txt驗機日期;
        private Label lbl機台型號;
        private TextBox txt機台型號;
        private Label lbl焊接電壓;
        private TextBox txt焊接電壓v;
        private TextBox txt焊接電壓hz;
        private TextBox txt焊接電壓;
        private Label lbl安規要求;
        private TextBox txt安規要求;
        private Label lbl廠驗;
        private TextBox txt廠驗;
        private Label lbl機台類型;
        private TextBox txt機台類型;
        private Label lbl控制電壓;
        private TextBox txt焊接物;
        private Label lbl生產速率;
        private TextBox txt生產速率;
        private Label lbl交貨日期;
        private TextBox txt交貨日期;
        private Label lbl機台名稱;
        private TextBox txt機台名稱;
        private Label lbl裝機;
        private TextBox txt裝機;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colRecordNo;
        private DataGridViewTextBoxColumn colDate;
        private DataGridViewTextBoxColumn colType;
        private DataGridViewTextBoxColumn colRecorder;
        private DataGridViewTextBoxColumn colProposer;
        private DataGridViewTextBoxColumn colOwnerUnit;
        private DataGridViewTextBoxColumn colTopic;
        private DataGridViewTextBoxColumn colResolution;
        private DataGridViewCheckBoxColumn colNeedReply;
        private DataGridViewTextBoxColumn colReplyPerson;
        private DataGridViewTextBoxColumn colExpectDate;
        private DataGridViewTextBoxColumn colActualDate;
        private DataGridViewTextBoxColumn colReplyDesc;
        private DataGridViewCheckBoxColumn colManagerReview;
    }
}
