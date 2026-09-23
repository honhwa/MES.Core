using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.Order
{
    partial class WorkOrderScheduleControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼
        //
        // 比照 PITS-2025.accdb「P-工令時程表」(Caption="機台管制表")還原，含內嵌
        // 子表單「P-工令時程明細」(Caption誤植"P-工程分析"，屬複製貼上殘留；
        // RecordSource=dbo_工令時程表)。配色比照原表單：表頭/表尾 RGB(237,247,
        // 249)、內容區 RGB(247,249,241)。按鈕列比照原巨集：
        //   專案進度追蹤 → 開啟既有 ProjectProgressDetailControl(LoadData)
        //   總覽         → 開啟既有 ProjectProgressControl(跨專案總覽)
        //   日誌工時統計 → 開啟新建 WorkOrderScheduleStatsControl(同資料夾)
        //   修改/儲存/關閉 → 標準編輯流程
        // 全部控制項座標一律採內嵌常數寫死(不使用自訂輔助方法) ─────────────────
        //
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panelHeader = new Panel();
            picLogo = new PictureBox();
            lblTitle = new Label();
            btnProgress = new Button();
            btnHoursStats = new Button();
            btnEdit = new Button();
            btnSave = new Button();
            btnOverview = new Button();
            btnExit = new Button();
            lbl專案序號 = new Label();
            txt專案序號 = new TextBox();
            lbl機台類型 = new Label();
            txt機台類型 = new TextBox();
            lbl機台型號 = new Label();
            txt機台型號 = new TextBox();
            lbl廠驗 = new Label();
            txt廠驗 = new TextBox();
            lbl裝機 = new Label();
            txt裝機 = new TextBox();
            lbl訂單日期 = new Label();
            txt訂單日期 = new DigiERP.Common.CommonDateTimePicker();
            lbl交貨日期 = new Label();
            txt交貨日期 = new DigiERP.Common.CommonDateTimePicker();
            lbl機台名稱 = new Label();
            txt機台名稱 = new TextBox();
            lbl驗機日期 = new Label();
            txt驗機日期 = new TextBox();
            lbl客戶簡稱 = new Label();
            txt客戶簡稱 = new TextBox();
            lbl客戶名稱 = new Label();
            txt客戶名稱 = new TextBox();
            lbl結案 = new Label();
            chk結案 = new CheckBox();
            dataGridView1 = new DataGridView();
            colProcCode = new DataGridViewComboBoxColumn();
            colProcName = new DataGridViewTextBoxColumn();
            colEstHours = new DataGridViewTextBoxColumn();
            colHourCost = new DataGridViewTextBoxColumn();
            colCostSub = new DataGridViewTextBoxColumn();
            colStartDate = new DataGridViewTextBoxColumn();
            colEndDate = new DataGridViewTextBoxColumn();
            colConsolidated = new DataGridViewCheckBoxColumn();
            colHandler = new DataGridViewComboBoxColumn();
            colModify = new DataGridViewTextBoxColumn();
            colModifyDate = new DataGridViewTextBoxColumn();
            colCreate = new DataGridViewTextBoxColumn();
            colCreateDate = new DataGridViewTextBoxColumn();
            panelFooter = new Panel();
            lblSumCaption = new Label();
            txtSumEstHours = new TextBox();
            txtSumCost = new TextBox();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelFooter.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(237, 247, 249);
            panelHeader.Controls.Add(picLogo);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Controls.Add(btnProgress);
            panelHeader.Controls.Add(btnHoursStats);
            panelHeader.Controls.Add(btnEdit);
            panelHeader.Controls.Add(btnSave);
            panelHeader.Controls.Add(btnOverview);
            panelHeader.Controls.Add(btnExit);
            panelHeader.Controls.Add(lbl專案序號);
            panelHeader.Controls.Add(txt專案序號);
            panelHeader.Controls.Add(lbl機台類型);
            panelHeader.Controls.Add(txt機台類型);
            panelHeader.Controls.Add(lbl機台型號);
            panelHeader.Controls.Add(txt機台型號);
            panelHeader.Controls.Add(lbl廠驗);
            panelHeader.Controls.Add(txt廠驗);
            panelHeader.Controls.Add(lbl裝機);
            panelHeader.Controls.Add(txt裝機);
            panelHeader.Controls.Add(lbl訂單日期);
            panelHeader.Controls.Add(txt訂單日期);
            panelHeader.Controls.Add(lbl交貨日期);
            panelHeader.Controls.Add(txt交貨日期);
            panelHeader.Controls.Add(lbl機台名稱);
            panelHeader.Controls.Add(txt機台名稱);
            panelHeader.Controls.Add(lbl驗機日期);
            panelHeader.Controls.Add(txt驗機日期);
            panelHeader.Controls.Add(lbl客戶簡稱);
            panelHeader.Controls.Add(txt客戶簡稱);
            panelHeader.Controls.Add(lbl客戶名稱);
            panelHeader.Controls.Add(txt客戶名稱);
            panelHeader.Controls.Add(lbl結案);
            panelHeader.Controls.Add(chk結案);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1228, 155);
            panelHeader.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.Image = Properties.Resources.WorkOrderScheduleLogo;
            picLogo.Location = new Point(8, 8);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(48, 48);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 31;
            picLogo.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("微軟正黑體", 12F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(69, 98, 135);
            lblTitle.Location = new Point(73, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(160, 24);
            lblTitle.TabIndex = 0;
            lblTitle.Tag = "title";
            lblTitle.Text = "機台管制表";
            // 
            // btnProgress
            // 
            btnProgress.BackColor = Color.FromArgb(140, 140, 140);
            btnProgress.FlatStyle = FlatStyle.Flat;
            btnProgress.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnProgress.ForeColor = Color.White;
            btnProgress.Location = new Point(460, 11);
            btnProgress.Name = "btnProgress";
            btnProgress.Size = new Size(100, 27);
            btnProgress.TabIndex = 1;
            btnProgress.Tag = "btn-modify";
            btnProgress.Text = "專案進度追蹤";
            btnProgress.UseVisualStyleBackColor = false;
            btnProgress.Click += btnProgress_Click;
            // 
            // btnHoursStats
            // 
            btnHoursStats.BackColor = Color.FromArgb(59, 129, 148);
            btnHoursStats.FlatStyle = FlatStyle.Flat;
            btnHoursStats.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnHoursStats.ForeColor = Color.White;
            btnHoursStats.Location = new Point(568, 11);
            btnHoursStats.Name = "btnHoursStats";
            btnHoursStats.Size = new Size(100, 27);
            btnHoursStats.TabIndex = 2;
            btnHoursStats.Tag = "btn-modify";
            btnHoursStats.Text = "日誌工時統計";
            btnHoursStats.UseVisualStyleBackColor = false;
            btnHoursStats.Click += btnHoursStats_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(140, 140, 140);
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(800, 11);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(80, 27);
            btnEdit.TabIndex = 3;
            btnEdit.Tag = "btn-modify";
            btnEdit.Text = "修改";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(140, 140, 140);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(888, 11);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(80, 27);
            btnSave.TabIndex = 4;
            btnSave.Tag = "btn-modify";
            btnSave.Text = "儲存";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnOverview
            // 
            btnOverview.BackColor = Color.FromArgb(59, 129, 148);
            btnOverview.FlatStyle = FlatStyle.Flat;
            btnOverview.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnOverview.ForeColor = Color.White;
            btnOverview.Location = new Point(976, 11);
            btnOverview.Name = "btnOverview";
            btnOverview.Size = new Size(80, 27);
            btnOverview.TabIndex = 5;
            btnOverview.Tag = "btn-modify";
            btnOverview.Text = "總覽";
            btnOverview.UseVisualStyleBackColor = false;
            btnOverview.Click += btnOverview_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(140, 140, 140);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(1064, 11);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(80, 27);
            btnExit.TabIndex = 6;
            btnExit.Tag = "btn-modify";
            btnExit.Text = "關閉";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Visible = false;
            btnExit.Click += btnExit_Click;
            // 
            // lbl專案序號
            // 
            lbl專案序號.Location = new Point(8, 64);
            lbl專案序號.Name = "lbl專案序號";
            lbl專案序號.Size = new Size(80, 21);
            lbl專案序號.TabIndex = 7;
            lbl專案序號.Text = "專案序號";
            lbl專案序號.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt專案序號
            // 
            txt專案序號.BackColor = SystemColors.Control;
            txt專案序號.Location = new Point(90, 64);
            txt專案序號.Name = "txt專案序號";
            txt專案序號.ReadOnly = true;
            txt專案序號.Size = new Size(150, 23);
            txt專案序號.TabIndex = 8;
            // 
            // lbl機台類型
            // 
            lbl機台類型.Location = new Point(260, 64);
            lbl機台類型.Name = "lbl機台類型";
            lbl機台類型.Size = new Size(75, 21);
            lbl機台類型.TabIndex = 9;
            lbl機台類型.Text = "機台類型";
            lbl機台類型.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt機台類型
            // 
            txt機台類型.BackColor = SystemColors.Control;
            txt機台類型.Location = new Point(337, 64);
            txt機台類型.Name = "txt機台類型";
            txt機台類型.ReadOnly = true;
            txt機台類型.Size = new Size(100, 23);
            txt機台類型.TabIndex = 10;
            // 
            // lbl機台型號
            // 
            lbl機台型號.Location = new Point(460, 64);
            lbl機台型號.Name = "lbl機台型號";
            lbl機台型號.Size = new Size(75, 21);
            lbl機台型號.TabIndex = 11;
            lbl機台型號.Text = "機台型號";
            lbl機台型號.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt機台型號
            // 
            txt機台型號.BackColor = SystemColors.Control;
            txt機台型號.Location = new Point(537, 64);
            txt機台型號.Name = "txt機台型號";
            txt機台型號.ReadOnly = true;
            txt機台型號.Size = new Size(300, 23);
            txt機台型號.TabIndex = 12;
            // 
            // lbl廠驗
            // 
            lbl廠驗.Location = new Point(860, 64);
            lbl廠驗.Name = "lbl廠驗";
            lbl廠驗.Size = new Size(45, 21);
            lbl廠驗.TabIndex = 13;
            lbl廠驗.Text = "廠驗";
            lbl廠驗.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt廠驗
            // 
            txt廠驗.BackColor = SystemColors.Control;
            txt廠驗.Location = new Point(907, 64);
            txt廠驗.Name = "txt廠驗";
            txt廠驗.ReadOnly = true;
            txt廠驗.Size = new Size(80, 23);
            txt廠驗.TabIndex = 14;
            // 
            // lbl裝機
            // 
            lbl裝機.Location = new Point(1000, 64);
            lbl裝機.Name = "lbl裝機";
            lbl裝機.Size = new Size(45, 21);
            lbl裝機.TabIndex = 15;
            lbl裝機.Text = "裝機";
            lbl裝機.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt裝機
            // 
            txt裝機.BackColor = SystemColors.Control;
            txt裝機.Location = new Point(1047, 64);
            txt裝機.Name = "txt裝機";
            txt裝機.ReadOnly = true;
            txt裝機.Size = new Size(118, 23);
            txt裝機.TabIndex = 16;
            // 
            // lbl訂單日期
            // 
            lbl訂單日期.Location = new Point(8, 94);
            lbl訂單日期.Name = "lbl訂單日期";
            lbl訂單日期.Size = new Size(80, 21);
            lbl訂單日期.TabIndex = 17;
            lbl訂單日期.Text = "訂單日期";
            lbl訂單日期.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt訂單日期
            // 
            txt訂單日期.Enabled = false;
            txt訂單日期.Format = DateTimePickerFormat.Short;
            txt訂單日期.Location = new Point(90, 94);
            txt訂單日期.Name = "txt訂單日期";
            txt訂單日期.Size = new Size(150, 23);
            txt訂單日期.TabIndex = 18;
            // 
            // lbl交貨日期
            // 
            lbl交貨日期.Location = new Point(260, 94);
            lbl交貨日期.Name = "lbl交貨日期";
            lbl交貨日期.Size = new Size(75, 21);
            lbl交貨日期.TabIndex = 19;
            lbl交貨日期.Text = "交貨日期";
            lbl交貨日期.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt交貨日期
            // 
            txt交貨日期.Enabled = false;
            txt交貨日期.Format = DateTimePickerFormat.Short;
            txt交貨日期.Location = new Point(337, 92);
            txt交貨日期.Name = "txt交貨日期";
            txt交貨日期.Size = new Size(100, 23);
            txt交貨日期.TabIndex = 20;
            // 
            // lbl機台名稱
            // 
            lbl機台名稱.Location = new Point(460, 94);
            lbl機台名稱.Name = "lbl機台名稱";
            lbl機台名稱.Size = new Size(75, 21);
            lbl機台名稱.TabIndex = 21;
            lbl機台名稱.Text = "機台名稱";
            lbl機台名稱.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt機台名稱
            // 
            txt機台名稱.BackColor = SystemColors.Control;
            txt機台名稱.Location = new Point(537, 94);
            txt機台名稱.Name = "txt機台名稱";
            txt機台名稱.ReadOnly = true;
            txt機台名稱.Size = new Size(628, 23);
            txt機台名稱.TabIndex = 22;
            // 
            // lbl驗機日期
            // 
            lbl驗機日期.Location = new Point(8, 124);
            lbl驗機日期.Name = "lbl驗機日期";
            lbl驗機日期.Size = new Size(80, 21);
            lbl驗機日期.TabIndex = 23;
            lbl驗機日期.Text = "驗機日期";
            lbl驗機日期.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt驗機日期
            // 
            txt驗機日期.BackColor = SystemColors.Control;
            txt驗機日期.Location = new Point(90, 124);
            txt驗機日期.Name = "txt驗機日期";
            txt驗機日期.ReadOnly = true;
            txt驗機日期.Size = new Size(150, 23);
            txt驗機日期.TabIndex = 24;
            // 
            // lbl客戶簡稱
            // 
            lbl客戶簡稱.Location = new Point(260, 124);
            lbl客戶簡稱.Name = "lbl客戶簡稱";
            lbl客戶簡稱.Size = new Size(75, 21);
            lbl客戶簡稱.TabIndex = 25;
            lbl客戶簡稱.Text = "客戶編號";
            lbl客戶簡稱.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt客戶簡稱
            // 
            txt客戶簡稱.BackColor = SystemColors.Control;
            txt客戶簡稱.Location = new Point(337, 124);
            txt客戶簡稱.Name = "txt客戶簡稱";
            txt客戶簡稱.ReadOnly = true;
            txt客戶簡稱.Size = new Size(100, 23);
            txt客戶簡稱.TabIndex = 26;
            // 
            // lbl客戶名稱
            // 
            lbl客戶名稱.Location = new Point(460, 124);
            lbl客戶名稱.Name = "lbl客戶名稱";
            lbl客戶名稱.Size = new Size(75, 21);
            lbl客戶名稱.TabIndex = 27;
            lbl客戶名稱.Text = "客戶";
            lbl客戶名稱.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt客戶名稱
            // 
            txt客戶名稱.BackColor = SystemColors.Control;
            txt客戶名稱.Location = new Point(537, 122);
            txt客戶名稱.Name = "txt客戶名稱";
            txt客戶名稱.ReadOnly = true;
            txt客戶名稱.Size = new Size(555, 23);
            txt客戶名稱.TabIndex = 28;
            // 
            // lbl結案
            // 
            lbl結案.Location = new Point(1098, 124);
            lbl結案.Name = "lbl結案";
            lbl結案.Size = new Size(45, 21);
            lbl結案.TabIndex = 29;
            lbl結案.Text = "結案";
            lbl結案.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // chk結案
            // 
            chk結案.Enabled = false;
            chk結案.Location = new Point(1145, 127);
            chk結案.Name = "chk結案";
            chk結案.Size = new Size(20, 20);
            chk結案.TabIndex = 30;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colProcCode, colProcName, colEstHours, colHourCost, colCostSub, colStartDate, colEndDate, colConsolidated, colHandler, colModify, colModifyDate, colCreate, colCreateDate });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Font = new Font("微軟正黑體", 9F);
            dataGridView1.Location = new Point(0, 155);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 26;
            dataGridView1.Size = new Size(1228, 445);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            dataGridView1.CurrentCellDirtyStateChanged += dataGridView1_CurrentCellDirtyStateChanged;
            dataGridView1.DataError += dataGridView1_DataError;
            // 
            // colProcCode
            // 
            colProcCode.HeaderText = "工序代號";
            colProcCode.Name = "colProcCode";
            colProcCode.Width = 80;
            // 
            // colProcName
            // 
            colProcName.HeaderText = "工序名稱";
            colProcName.Name = "colProcName";
            colProcName.ReadOnly = true;
            colProcName.Width = 130;
            // 
            // colEstHours
            // 
            colEstHours.HeaderText = "預估人工時";
            colEstHours.Name = "colEstHours";
            colEstHours.Width = 80;
            // 
            // colHourCost
            // 
            colHourCost.HeaderText = "工時單位成本";
            colHourCost.Name = "colHourCost";
            colHourCost.Width = 90;
            // 
            // colCostSub
            // 
            colCostSub.HeaderText = "工時成本小計";
            colCostSub.Name = "colCostSub";
            colCostSub.ReadOnly = true;
            colCostSub.Width = 90;
            // 
            // colStartDate
            // 
            colStartDate.HeaderText = "起始日";
            colStartDate.Name = "colStartDate";
            colStartDate.Width = 90;
            // 
            // colEndDate
            // 
            colEndDate.HeaderText = "完成日";
            colEndDate.Name = "colEndDate";
            colEndDate.Width = 90;
            // 
            // colConsolidated
            // 
            colConsolidated.HeaderText = "統合工段";
            colConsolidated.Name = "colConsolidated";
            colConsolidated.ReadOnly = true;
            colConsolidated.Width = 70;
            // 
            // colHandler
            // 
            colHandler.HeaderText = "執行人員";
            colHandler.Name = "colHandler";
            // 
            // colModify
            // 
            colModify.HeaderText = "修改";
            colModify.Name = "colModify";
            colModify.ReadOnly = true;
            colModify.Width = 70;
            // 
            // colModifyDate
            // 
            colModifyDate.HeaderText = "修改日";
            colModifyDate.Name = "colModifyDate";
            colModifyDate.ReadOnly = true;
            colModifyDate.Width = 90;
            // 
            // colCreate
            // 
            colCreate.HeaderText = "建檔";
            colCreate.Name = "colCreate";
            colCreate.ReadOnly = true;
            colCreate.Width = 70;
            // 
            // colCreateDate
            // 
            colCreateDate.HeaderText = "建檔日";
            colCreateDate.Name = "colCreateDate";
            colCreateDate.ReadOnly = true;
            colCreateDate.Width = 90;
            // 
            // panelFooter
            // 
            panelFooter.BackColor = Color.FromArgb(237, 247, 249);
            panelFooter.Controls.Add(lblSumCaption);
            panelFooter.Controls.Add(txtSumEstHours);
            panelFooter.Controls.Add(txtSumCost);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 600);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(1228, 36);
            panelFooter.TabIndex = 2;
            // 
            // lblSumCaption
            // 
            lblSumCaption.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            lblSumCaption.ForeColor = Color.Firebrick;
            lblSumCaption.Location = new Point(8, 6);
            lblSumCaption.Name = "lblSumCaption";
            lblSumCaption.Size = new Size(80, 21);
            lblSumCaption.TabIndex = 0;
            lblSumCaption.Text = "合計數：";
            // 
            // txtSumEstHours
            // 
            txtSumEstHours.BackColor = Color.White;
            txtSumEstHours.Location = new Point(90, 6);
            txtSumEstHours.Name = "txtSumEstHours";
            txtSumEstHours.ReadOnly = true;
            txtSumEstHours.Size = new Size(100, 23);
            txtSumEstHours.TabIndex = 1;
            // 
            // txtSumCost
            // 
            txtSumCost.BackColor = Color.White;
            txtSumCost.Location = new Point(310, 6);
            txtSumCost.Name = "txtSumCost";
            txtSumCost.ReadOnly = true;
            txtSumCost.Size = new Size(120, 23);
            txtSumCost.TabIndex = 2;
            // 
            // WorkOrderScheduleControl
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(panelFooter);
            Controls.Add(panelHeader);
            Font = new Font("微軟正黑體", 9F);
            Margin = new Padding(4);
            Name = "WorkOrderScheduleControl";
            Size = new Size(1228, 636);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelFooter.ResumeLayout(false);
            panelFooter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private PictureBox picLogo;
        private Label lblTitle;
        private Button btnProgress;
        private Button btnHoursStats;
        private Button btnEdit;
        private Button btnSave;
        private Button btnOverview;
        private Button btnExit;
        private Label lbl專案序號; private TextBox txt專案序號;
        private Label lbl機台類型; private TextBox txt機台類型;
        private Label lbl機台型號; private TextBox txt機台型號;
        private Label lbl廠驗; private TextBox txt廠驗;
        private Label lbl裝機; private TextBox txt裝機;
        private Label lbl訂單日期; private DigiERP.Common.CommonDateTimePicker txt訂單日期;
        private Label lbl交貨日期; private DigiERP.Common.CommonDateTimePicker txt交貨日期;
        private Label lbl機台名稱; private TextBox txt機台名稱;
        private Label lbl驗機日期; private TextBox txt驗機日期;
        private Label lbl客戶簡稱; private TextBox txt客戶簡稱;
        private Label lbl客戶名稱; private TextBox txt客戶名稱;
        private Label lbl結案; private CheckBox chk結案;
        private DataGridView dataGridView1;
        private DataGridViewComboBoxColumn colProcCode;
        private DataGridViewTextBoxColumn colProcName;
        private DataGridViewTextBoxColumn colEstHours;
        private DataGridViewTextBoxColumn colHourCost;
        private DataGridViewTextBoxColumn colCostSub;
        private DataGridViewTextBoxColumn colStartDate;
        private DataGridViewTextBoxColumn colEndDate;
        private DataGridViewCheckBoxColumn colConsolidated;
        private DataGridViewComboBoxColumn colHandler;
        private DataGridViewTextBoxColumn colModify;
        private DataGridViewTextBoxColumn colModifyDate;
        private DataGridViewTextBoxColumn colCreate;
        private DataGridViewTextBoxColumn colCreateDate;
        private Panel panelFooter;
        private Label lblSumCaption;
        private TextBox txtSumEstHours;
        private TextBox txtSumCost;
    }
}
