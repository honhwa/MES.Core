using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.Order
{
    partial class ProjectProgressGanttControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼
        //
        // 比照 PITS-2025.accdb「P-專案管制進度」(Caption="專案管制進度")還原。
        // RecordSource="專案管制進度追蹤"(查詢，WHERE 專案序號=[Forms]![P-工令
        // 時程表]![專案序號]，即依父表單目前專案序號過濾，非透過 WhereCondition
        // 傳遞)。查詢以 dbo_工令時程表 LEFT JOIN dbo_工序設定 取得每筆時程列，
        // 並以 12 組 IIf() 計算欄位(1st Week~12th Week)相對「今天」滾動 12 週、
        // 逐週標示 Start/WIP/Finished/C(空白=尚未開始)，搭配格式化條件著色，呈現
        // 甘特圖式週進度總覽。本畫面改以單一 DataGridView 動態計算並著色呈現，
        // 邏輯對應相同：
        //   週狀態(週期[ws,we))：
        //     起始日>=we        → ""（尚未開始）
        //     ws<=起始日<we     → "Start"（本週起始）
        //     起始日<ws 且 完成日<ws  → "C"（本週之前已完工）
        //     起始日<ws 且 完成日<we  → "Finished"（本週內完工）
        //     起始日<ws 且 完成日>=we → "WIP"（本週仍進行中）
        // 全部控制項座標一律採內嵌常數寫死(不使用自訂輔助方法) ─────────────────
        //
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            panelHeader = new Panel();
            picLogo = new PictureBox();
            lblTitle = new Label();
            lbl專案序號 = new Label();
            txt專案序號 = new TextBox();
            btnExit = new Button();
            dataGridView1 = new DataGridView();
            colProjectNo = new DataGridViewTextBoxColumn();
            colProcCode = new DataGridViewTextBoxColumn();
            colProcName = new DataGridViewTextBoxColumn();
            colHours = new DataGridViewTextBoxColumn();
            colStartDate = new DataGridViewTextBoxColumn();
            colEndDate = new DataGridViewTextBoxColumn();
            colUnit = new DataGridViewTextBoxColumn();
            colHandler = new DataGridViewTextBoxColumn();
            colWeek1 = new DataGridViewTextBoxColumn();
            colWeek2 = new DataGridViewTextBoxColumn();
            colWeek3 = new DataGridViewTextBoxColumn();
            colWeek4 = new DataGridViewTextBoxColumn();
            colWeek5 = new DataGridViewTextBoxColumn();
            colWeek6 = new DataGridViewTextBoxColumn();
            colWeek7 = new DataGridViewTextBoxColumn();
            colWeek8 = new DataGridViewTextBoxColumn();
            colWeek9 = new DataGridViewTextBoxColumn();
            colWeek10 = new DataGridViewTextBoxColumn();
            colWeek11 = new DataGridViewTextBoxColumn();
            colWeek12 = new DataGridViewTextBoxColumn();
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
            panelHeader.Size = new Size(1442, 60);
            panelHeader.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.Image = Properties.Resources.WorkOrderScheduleLogo;
            picLogo.Location = new Point(8, 8);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(48, 48);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 4;
            picLogo.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("微軟正黑體", 11F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(69, 98, 135);
            lblTitle.Location = new Point(73, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(220, 24);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "專案管制進度追蹤";
            // 
            // lbl專案序號
            // 
            lbl專案序號.Location = new Point(287, 14);
            lbl專案序號.Name = "lbl專案序號";
            lbl專案序號.Size = new Size(75, 21);
            lbl專案序號.TabIndex = 1;
            lbl專案序號.Text = "專案序號";
            lbl專案序號.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt專案序號
            // 
            txt專案序號.BackColor = SystemColors.Control;
            txt專案序號.Location = new Point(366, 14);
            txt專案序號.Name = "txt專案序號";
            txt專案序號.ReadOnly = true;
            txt專案序號.Size = new Size(200, 23);
            txt專案序號.TabIndex = 2;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(140, 140, 140);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(1200, 34);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(80, 27);
            btnExit.TabIndex = 3;
            btnExit.Text = "關閉";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Visible = false;
            btnExit.Click += btnExit_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 40;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colProjectNo, colProcCode, colProcName, colHours, colStartDate, colEndDate, colUnit, colHandler, colWeek1, colWeek2, colWeek3, colWeek4, colWeek5, colWeek6, colWeek7, colWeek8, colWeek9, colWeek10, colWeek11, colWeek12 });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Font = new Font("微軟正黑體", 9F);
            dataGridView1.Location = new Point(0, 60);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 26;
            dataGridView1.Size = new Size(1442, 470);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            // 
            // colProjectNo
            // 
            colProjectNo.HeaderText = "專案序號";
            colProjectNo.Name = "colProjectNo";
            colProjectNo.ReadOnly = true;
            // 
            // colProcCode
            // 
            colProcCode.HeaderText = "工序";
            colProcCode.Name = "colProcCode";
            colProcCode.ReadOnly = true;
            // 
            // colProcName
            // 
            colProcName.HeaderText = "工序名稱";
            colProcName.Name = "colProcName";
            colProcName.ReadOnly = true;
            // 
            // colHours
            // 
            colHours.HeaderText = "工時";
            colHours.Name = "colHours";
            colHours.ReadOnly = true;
            // 
            // colStartDate
            // 
            colStartDate.HeaderText = "起始日";
            colStartDate.Name = "colStartDate";
            colStartDate.ReadOnly = true;
            // 
            // colEndDate
            // 
            colEndDate.HeaderText = "完成日";
            colEndDate.Name = "colEndDate";
            colEndDate.ReadOnly = true;
            // 
            // colUnit
            // 
            colUnit.HeaderText = "單位";
            colUnit.Name = "colUnit";
            colUnit.ReadOnly = true;
            // 
            // colHandler
            // 
            colHandler.HeaderText = "執行";
            colHandler.Name = "colHandler";
            colHandler.ReadOnly = true;
            // 
            // colWeek1
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colWeek1.DefaultCellStyle = dataGridViewCellStyle2;
            colWeek1.Name = "colWeek1";
            colWeek1.ReadOnly = true;
            colWeek1.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colWeek2
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colWeek2.DefaultCellStyle = dataGridViewCellStyle3;
            colWeek2.Name = "colWeek2";
            colWeek2.ReadOnly = true;
            colWeek2.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colWeek3
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colWeek3.DefaultCellStyle = dataGridViewCellStyle4;
            colWeek3.Name = "colWeek3";
            colWeek3.ReadOnly = true;
            colWeek3.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colWeek4
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colWeek4.DefaultCellStyle = dataGridViewCellStyle5;
            colWeek4.Name = "colWeek4";
            colWeek4.ReadOnly = true;
            colWeek4.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colWeek5
            // 
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colWeek5.DefaultCellStyle = dataGridViewCellStyle6;
            colWeek5.Name = "colWeek5";
            colWeek5.ReadOnly = true;
            colWeek5.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colWeek6
            // 
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colWeek6.DefaultCellStyle = dataGridViewCellStyle7;
            colWeek6.Name = "colWeek6";
            colWeek6.ReadOnly = true;
            colWeek6.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colWeek7
            // 
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colWeek7.DefaultCellStyle = dataGridViewCellStyle8;
            colWeek7.Name = "colWeek7";
            colWeek7.ReadOnly = true;
            colWeek7.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colWeek8
            // 
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colWeek8.DefaultCellStyle = dataGridViewCellStyle9;
            colWeek8.Name = "colWeek8";
            colWeek8.ReadOnly = true;
            colWeek8.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colWeek9
            // 
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colWeek9.DefaultCellStyle = dataGridViewCellStyle10;
            colWeek9.Name = "colWeek9";
            colWeek9.ReadOnly = true;
            colWeek9.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colWeek10
            // 
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colWeek10.DefaultCellStyle = dataGridViewCellStyle11;
            colWeek10.Name = "colWeek10";
            colWeek10.ReadOnly = true;
            colWeek10.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colWeek11
            // 
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colWeek11.DefaultCellStyle = dataGridViewCellStyle12;
            colWeek11.Name = "colWeek11";
            colWeek11.ReadOnly = true;
            colWeek11.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colWeek12
            // 
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colWeek12.DefaultCellStyle = dataGridViewCellStyle13;
            colWeek12.Name = "colWeek12";
            colWeek12.ReadOnly = true;
            colWeek12.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ProjectProgressGanttControl
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(panelHeader);
            Font = new Font("微軟正黑體", 9F);
            Margin = new Padding(4);
            Name = "ProjectProgressGanttControl";
            Size = new Size(1442, 530);
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
        private DataGridViewTextBoxColumn colProjectNo;
        private DataGridViewTextBoxColumn colProcCode;
        private DataGridViewTextBoxColumn colProcName;
        private DataGridViewTextBoxColumn colHours;
        private DataGridViewTextBoxColumn colStartDate;
        private DataGridViewTextBoxColumn colEndDate;
        private DataGridViewTextBoxColumn colUnit;
        private DataGridViewTextBoxColumn colHandler;
        private DataGridViewTextBoxColumn colWeek1;
        private DataGridViewTextBoxColumn colWeek2;
        private DataGridViewTextBoxColumn colWeek3;
        private DataGridViewTextBoxColumn colWeek4;
        private DataGridViewTextBoxColumn colWeek5;
        private DataGridViewTextBoxColumn colWeek6;
        private DataGridViewTextBoxColumn colWeek7;
        private DataGridViewTextBoxColumn colWeek8;
        private DataGridViewTextBoxColumn colWeek9;
        private DataGridViewTextBoxColumn colWeek10;
        private DataGridViewTextBoxColumn colWeek11;
        private DataGridViewTextBoxColumn colWeek12;
    }
}
