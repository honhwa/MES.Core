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
            panelHeader = new Panel();
            lblTitle = new Label();
            btnProgress = new Button();
            btnHoursStats = new Button();
            btnEdit = new Button();
            btnSave = new Button();
            btnOverview = new Button();
            btnExit = new Button();
            lbl專案序號 = new Label(); txt專案序號 = new TextBox();
            lbl機台類型 = new Label(); txt機台類型 = new TextBox();
            lbl機台型號 = new Label(); txt機台型號 = new TextBox();
            lbl廠驗 = new Label(); txt廠驗 = new TextBox();
            lbl裝機 = new Label(); txt裝機 = new TextBox();
            lbl訂單日期 = new Label(); txt訂單日期 = new TextBox();
            lbl交貨日期 = new Label(); txt交貨日期 = new TextBox();
            lbl機台名稱 = new Label(); txt機台名稱 = new TextBox();
            lbl驗機日期 = new Label(); txt驗機日期 = new TextBox();
            lbl客戶簡稱 = new Label(); txt客戶簡稱 = new TextBox();
            lbl客戶名稱 = new Label(); txt客戶名稱 = new TextBox();
            lbl結案 = new Label(); chk結案 = new CheckBox();
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelHeader.SuspendLayout();
            panelFooter.SuspendLayout();
            SuspendLayout();
            //
            // panelHeader
            //
            panelHeader.BackColor = Color.FromArgb(237, 247, 249);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1160, 140);
            panelHeader.TabIndex = 0;
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Controls.Add(btnProgress);
            panelHeader.Controls.Add(btnHoursStats);
            panelHeader.Controls.Add(btnEdit);
            panelHeader.Controls.Add(btnSave);
            panelHeader.Controls.Add(btnOverview);
            panelHeader.Controls.Add(btnExit);
            panelHeader.Controls.Add(lbl專案序號); panelHeader.Controls.Add(txt專案序號);
            panelHeader.Controls.Add(lbl機台類型); panelHeader.Controls.Add(txt機台類型);
            panelHeader.Controls.Add(lbl機台型號); panelHeader.Controls.Add(txt機台型號);
            panelHeader.Controls.Add(lbl廠驗); panelHeader.Controls.Add(txt廠驗);
            panelHeader.Controls.Add(lbl裝機); panelHeader.Controls.Add(txt裝機);
            panelHeader.Controls.Add(lbl訂單日期); panelHeader.Controls.Add(txt訂單日期);
            panelHeader.Controls.Add(lbl交貨日期); panelHeader.Controls.Add(txt交貨日期);
            panelHeader.Controls.Add(lbl機台名稱); panelHeader.Controls.Add(txt機台名稱);
            panelHeader.Controls.Add(lbl驗機日期); panelHeader.Controls.Add(txt驗機日期);
            panelHeader.Controls.Add(lbl客戶簡稱); panelHeader.Controls.Add(txt客戶簡稱);
            panelHeader.Controls.Add(lbl客戶名稱); panelHeader.Controls.Add(txt客戶名稱);
            panelHeader.Controls.Add(lbl結案); panelHeader.Controls.Add(chk結案);
            //
            // lblTitle
            //
            lblTitle.AutoSize = false;
            lblTitle.Font = new Font("微軟正黑體", 12F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(69, 98, 135);
            lblTitle.Location = new Point(11, 8);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(160, 24);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "機台管制表";
            //
            // 按鈕列：專案進度追蹤/日誌工時統計/修改/儲存/總覽/關閉
            //
            btnProgress.BackColor = Color.FromArgb(140, 140, 140); btnProgress.FlatStyle = FlatStyle.Flat; btnProgress.ForeColor = Color.White;
            btnProgress.Font = new Font("微軟正黑體", 9F, FontStyle.Bold); btnProgress.Location = new Point(260, 8);
            btnProgress.Name = "btnProgress"; btnProgress.Size = new Size(100, 27); btnProgress.TabIndex = 1;
            btnProgress.Text = "專案進度追蹤"; btnProgress.UseVisualStyleBackColor = false; btnProgress.Click += btnProgress_Click;

            btnHoursStats.BackColor = Color.FromArgb(59, 129, 148); btnHoursStats.FlatStyle = FlatStyle.Flat; btnHoursStats.ForeColor = Color.White;
            btnHoursStats.Font = new Font("微軟正黑體", 9F, FontStyle.Bold); btnHoursStats.Location = new Point(368, 8);
            btnHoursStats.Name = "btnHoursStats"; btnHoursStats.Size = new Size(100, 27); btnHoursStats.TabIndex = 2;
            btnHoursStats.Text = "日誌工時統計"; btnHoursStats.UseVisualStyleBackColor = false; btnHoursStats.Click += btnHoursStats_Click;

            btnEdit.BackColor = Color.FromArgb(140, 140, 140); btnEdit.FlatStyle = FlatStyle.Flat; btnEdit.ForeColor = Color.White;
            btnEdit.Font = new Font("微軟正黑體", 9F, FontStyle.Bold); btnEdit.Location = new Point(600, 8);
            btnEdit.Name = "btnEdit"; btnEdit.Size = new Size(80, 27); btnEdit.TabIndex = 3;
            btnEdit.Text = "修改"; btnEdit.UseVisualStyleBackColor = false; btnEdit.Click += btnEdit_Click;

            btnSave.BackColor = Color.FromArgb(140, 140, 140); btnSave.FlatStyle = FlatStyle.Flat; btnSave.ForeColor = Color.White;
            btnSave.Font = new Font("微軟正黑體", 9F, FontStyle.Bold); btnSave.Location = new Point(688, 8);
            btnSave.Name = "btnSave"; btnSave.Size = new Size(80, 27); btnSave.TabIndex = 4;
            btnSave.Text = "儲存"; btnSave.UseVisualStyleBackColor = false; btnSave.Click += btnSave_Click;

            btnOverview.BackColor = Color.FromArgb(59, 129, 148); btnOverview.FlatStyle = FlatStyle.Flat; btnOverview.ForeColor = Color.White;
            btnOverview.Font = new Font("微軟正黑體", 9F, FontStyle.Bold); btnOverview.Location = new Point(776, 8);
            btnOverview.Name = "btnOverview"; btnOverview.Size = new Size(80, 27); btnOverview.TabIndex = 5;
            btnOverview.Text = "總覽"; btnOverview.UseVisualStyleBackColor = false; btnOverview.Click += btnOverview_Click;

            btnExit.BackColor = Color.FromArgb(140, 140, 140); btnExit.FlatStyle = FlatStyle.Flat; btnExit.ForeColor = Color.White;
            btnExit.Font = new Font("微軟正黑體", 9F, FontStyle.Bold); btnExit.Location = new Point(864, 8);
            btnExit.Name = "btnExit"; btnExit.Size = new Size(80, 27); btnExit.TabIndex = 6;
            btnExit.Text = "關閉"; btnExit.UseVisualStyleBackColor = false; btnExit.Click += btnExit_Click;
            //
            // Row1 (y=42): 專案序號 / 機台類型 / 機台型號 / 廠驗 / 裝機
            //
            lbl專案序號.AutoSize = false; lbl專案序號.Location = new Point(8, 42); lbl專案序號.Size = new Size(80, 21);
            lbl專案序號.Text = "專案序號"; lbl專案序號.TextAlign = ContentAlignment.MiddleLeft;
            txt專案序號.Location = new Point(90, 42); txt專案序號.Size = new Size(150, 21); txt專案序號.ReadOnly = true; txt專案序號.BackColor = SystemColors.Control;

            lbl機台類型.AutoSize = false; lbl機台類型.Location = new Point(260, 42); lbl機台類型.Size = new Size(75, 21);
            lbl機台類型.Text = "機台類型"; lbl機台類型.TextAlign = ContentAlignment.MiddleLeft;
            txt機台類型.Location = new Point(337, 42); txt機台類型.Size = new Size(100, 21); txt機台類型.ReadOnly = true; txt機台類型.BackColor = SystemColors.Control;

            lbl機台型號.AutoSize = false; lbl機台型號.Location = new Point(460, 42); lbl機台型號.Size = new Size(75, 21);
            lbl機台型號.Text = "機台型號"; lbl機台型號.TextAlign = ContentAlignment.MiddleLeft;
            txt機台型號.Location = new Point(537, 42); txt機台型號.Size = new Size(300, 21); txt機台型號.ReadOnly = true; txt機台型號.BackColor = SystemColors.Control;

            lbl廠驗.AutoSize = false; lbl廠驗.Location = new Point(860, 42); lbl廠驗.Size = new Size(45, 21);
            lbl廠驗.Text = "廠驗"; lbl廠驗.TextAlign = ContentAlignment.MiddleLeft;
            txt廠驗.Location = new Point(907, 42); txt廠驗.Size = new Size(80, 21); txt廠驗.ReadOnly = true; txt廠驗.BackColor = SystemColors.Control;

            lbl裝機.AutoSize = false; lbl裝機.Location = new Point(1000, 42); lbl裝機.Size = new Size(45, 21);
            lbl裝機.Text = "裝機"; lbl裝機.TextAlign = ContentAlignment.MiddleLeft;
            txt裝機.Location = new Point(1047, 42); txt裝機.Size = new Size(105, 21); txt裝機.ReadOnly = true; txt裝機.BackColor = SystemColors.Control;
            //
            // Row2 (y=72): 訂單日期 / 交貨日期 / 機台名稱
            //
            lbl訂單日期.AutoSize = false; lbl訂單日期.Location = new Point(8, 72); lbl訂單日期.Size = new Size(80, 21);
            lbl訂單日期.Text = "訂單日期"; lbl訂單日期.TextAlign = ContentAlignment.MiddleLeft;
            txt訂單日期.Location = new Point(90, 72); txt訂單日期.Size = new Size(150, 21); txt訂單日期.ReadOnly = true; txt訂單日期.BackColor = SystemColors.Control;

            lbl交貨日期.AutoSize = false; lbl交貨日期.Location = new Point(260, 72); lbl交貨日期.Size = new Size(75, 21);
            lbl交貨日期.Text = "交貨日期"; lbl交貨日期.TextAlign = ContentAlignment.MiddleLeft;
            txt交貨日期.Location = new Point(337, 72); txt交貨日期.Size = new Size(100, 21); txt交貨日期.ReadOnly = true; txt交貨日期.BackColor = SystemColors.Control;

            lbl機台名稱.AutoSize = false; lbl機台名稱.Location = new Point(460, 72); lbl機台名稱.Size = new Size(75, 21);
            lbl機台名稱.Text = "機台名稱"; lbl機台名稱.TextAlign = ContentAlignment.MiddleLeft;
            txt機台名稱.Location = new Point(537, 72); txt機台名稱.Size = new Size(615, 21); txt機台名稱.ReadOnly = true; txt機台名稱.BackColor = SystemColors.Control;
            //
            // Row3 (y=102): 驗機日期 / 客戶編號(客戶簡稱) / 客戶(客戶名稱) / 結案
            //
            lbl驗機日期.AutoSize = false; lbl驗機日期.Location = new Point(8, 102); lbl驗機日期.Size = new Size(80, 21);
            lbl驗機日期.Text = "驗機日期"; lbl驗機日期.TextAlign = ContentAlignment.MiddleLeft;
            txt驗機日期.Location = new Point(90, 102); txt驗機日期.Size = new Size(150, 21); txt驗機日期.ReadOnly = true; txt驗機日期.BackColor = SystemColors.Control;

            lbl客戶簡稱.AutoSize = false; lbl客戶簡稱.Location = new Point(260, 102); lbl客戶簡稱.Size = new Size(75, 21);
            lbl客戶簡稱.Text = "客戶編號"; lbl客戶簡稱.TextAlign = ContentAlignment.MiddleLeft;
            txt客戶簡稱.Location = new Point(337, 102); txt客戶簡稱.Size = new Size(100, 21); txt客戶簡稱.ReadOnly = true; txt客戶簡稱.BackColor = SystemColors.Control;

            lbl客戶名稱.AutoSize = false; lbl客戶名稱.Location = new Point(460, 102); lbl客戶名稱.Size = new Size(75, 21);
            lbl客戶名稱.Text = "客戶"; lbl客戶名稱.TextAlign = ContentAlignment.MiddleLeft;
            txt客戶名稱.Location = new Point(537, 102); txt客戶名稱.Size = new Size(555, 21); txt客戶名稱.ReadOnly = true; txt客戶名稱.BackColor = SystemColors.Control;

            lbl結案.AutoSize = false; lbl結案.Location = new Point(1070, 102); lbl結案.Size = new Size(45, 21);
            lbl結案.Text = "結案"; lbl結案.TextAlign = ContentAlignment.MiddleLeft;
            chk結案.Location = new Point(1117, 105); chk結案.Size = new Size(20, 20); chk結案.Enabled = false;
            //
            // dataGridView1 (子表單 P-工令時程明細，RecordSource=dbo_工令時程表)
            //
            dataGridView1.AllowUserToAddRows = true;
            dataGridView1.AllowUserToDeleteRows = true;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle = new DataGridViewCellStyle { BackColor = Color.FromArgb(247, 249, 241) };
            dataGridView1.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle { BackColor = Color.FromArgb(237, 247, 249), Font = new Font("微軟正黑體", 9F, FontStyle.Bold) };
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colProcCode, colProcName, colEstHours, colHourCost, colCostSub, colStartDate, colEndDate, colConsolidated, colHandler, colModify, colModifyDate, colCreate, colCreateDate });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Font = new Font("微軟正黑體", 9F);
            dataGridView1.Location = new Point(0, 140);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 26;
            dataGridView1.Size = new Size(1160, 460);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            dataGridView1.CurrentCellDirtyStateChanged += dataGridView1_CurrentCellDirtyStateChanged;
            dataGridView1.DataError += dataGridView1_DataError;

            colProcCode.HeaderText = "工序代號"; colProcCode.Name = "colProcCode"; colProcCode.Width = 80;
            colProcName.HeaderText = "工序名稱"; colProcName.Name = "colProcName"; colProcName.Width = 130; colProcName.ReadOnly = true;
            colEstHours.HeaderText = "預估人工時"; colEstHours.Name = "colEstHours"; colEstHours.Width = 80;
            colHourCost.HeaderText = "工時單位成本"; colHourCost.Name = "colHourCost"; colHourCost.Width = 90;
            colCostSub.HeaderText = "工時成本小計"; colCostSub.Name = "colCostSub"; colCostSub.Width = 90; colCostSub.ReadOnly = true;
            colStartDate.HeaderText = "起始日"; colStartDate.Name = "colStartDate"; colStartDate.Width = 90;
            colEndDate.HeaderText = "完成日"; colEndDate.Name = "colEndDate"; colEndDate.Width = 90;
            colConsolidated.HeaderText = "統合工段"; colConsolidated.Name = "colConsolidated"; colConsolidated.Width = 70; colConsolidated.ReadOnly = true;
            colHandler.HeaderText = "執行人員"; colHandler.Name = "colHandler"; colHandler.Width = 100;
            colModify.HeaderText = "修改"; colModify.Name = "colModify"; colModify.Width = 70; colModify.ReadOnly = true;
            colModifyDate.HeaderText = "修改日"; colModifyDate.Name = "colModifyDate"; colModifyDate.Width = 90; colModifyDate.ReadOnly = true;
            colCreate.HeaderText = "建檔"; colCreate.Name = "colCreate"; colCreate.Width = 70; colCreate.ReadOnly = true;
            colCreateDate.HeaderText = "建檔日"; colCreateDate.Name = "colCreateDate"; colCreateDate.Width = 90; colCreateDate.ReadOnly = true;
            //
            // panelFooter (合計數：預估工時/工時成本小計 加總)
            //
            panelFooter.BackColor = Color.FromArgb(237, 247, 249);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 600);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(1160, 36);
            panelFooter.TabIndex = 2;
            panelFooter.Controls.Add(lblSumCaption);
            panelFooter.Controls.Add(txtSumEstHours);
            panelFooter.Controls.Add(txtSumCost);

            lblSumCaption.AutoSize = false; lblSumCaption.Location = new Point(8, 6); lblSumCaption.Size = new Size(80, 21);
            lblSumCaption.Text = "合計數："; lblSumCaption.ForeColor = Color.Firebrick; lblSumCaption.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            txtSumEstHours.Location = new Point(90, 6); txtSumEstHours.Size = new Size(100, 21); txtSumEstHours.ReadOnly = true; txtSumEstHours.BackColor = Color.White;
            txtSumCost.Location = new Point(310, 6); txtSumCost.Size = new Size(120, 21); txtSumCost.ReadOnly = true; txtSumCost.BackColor = Color.White;
            //
            // WorkOrderScheduleControl
            //
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(panelFooter);
            Controls.Add(panelHeader);
            Font = new Font("微軟正黑體", 9F);
            Margin = new Padding(4);
            Name = "WorkOrderScheduleControl";
            Size = new Size(1160, 636);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelFooter.ResumeLayout(false);
            panelFooter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
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
        private Label lbl訂單日期; private TextBox txt訂單日期;
        private Label lbl交貨日期; private TextBox txt交貨日期;
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
