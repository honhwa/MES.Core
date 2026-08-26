using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.Project
{
    partial class ProjectFeedbackListControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼
        //
        // 版面比照 PITS-2025.accdb「P-專案待回報事項」(Caption="待回報事項")之
        // 控制項座標(twips/15=px)還原。配色亦比照原表單：表單首/尾為淡黃綠
        // RGB(242,255,179)，詳細資料區為白色(交錯列 RGB(242,242,242))。
        // 原表單為純唯讀清單(AllowEdits/AllowAdditions/AllowDeletions皆關閉)，
        // 僅一顆「關閉」按鈕，雙擊「專案序號」開啟該專案的會議履歷 ─────────────
        //
        private void InitializeComponent()
        {
            panelHeader = new Panel();
            lblTitle = new Label();
            btnExit = new Button();
            panelBody = new Panel();
            dataGridView1 = new DataGridView();
            colRecordNo = new DataGridViewTextBoxColumn();
            colProjectNo = new DataGridViewTextBoxColumn();
            colOrderDate = new DataGridViewTextBoxColumn();
            colCustName = new DataGridViewTextBoxColumn();
            colMachineType = new DataGridViewTextBoxColumn();
            colMachineModel = new DataGridViewTextBoxColumn();
            colTestDate = new DataGridViewTextBoxColumn();
            colOwnerUnit = new DataGridViewTextBoxColumn();
            colTopic = new DataGridViewTextBoxColumn();
            colResolution = new DataGridViewTextBoxColumn();
            colReplyPerson = new DataGridViewTextBoxColumn();
            colNeedReply = new DataGridViewCheckBoxColumn();
            colExpectDate = new DataGridViewTextBoxColumn();
            colActualDate = new DataGridViewTextBoxColumn();
            panelFooter = new Panel();
            lblHint = new Label();
            panelHeader.SuspendLayout();
            panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelFooter.SuspendLayout();
            SuspendLayout();
            //
            // panelHeader
            //
            panelHeader.BackColor = Color.FromArgb(242, 255, 179);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Controls.Add(btnExit);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1500, 40);
            panelHeader.TabIndex = 0;
            //
            // lblTitle
            //
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("微軟正黑體", 12F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(69, 98, 135);
            lblTitle.Location = new Point(11, 8);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(130, 24);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "專案待回報事項";
            //
            // btnExit (原Command69"關閉")
            //
            btnExit.BackColor = Color.FromArgb(69, 98, 135);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.ForeColor = Color.White;
            btnExit.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnExit.Location = new Point(1400, 6);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(90, 28);
            btnExit.TabIndex = 1;
            btnExit.Text = "關閉";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            //
            // panelBody
            //
            panelBody.BackColor = Color.White;
            panelBody.Controls.Add(dataGridView1);
            panelBody.Dock = DockStyle.Fill;
            panelBody.Location = new Point(0, 40);
            panelBody.Name = "panelBody";
            panelBody.Size = new Size(1500, 550);
            panelBody.TabIndex = 1;
            //
            // dataGridView1
            //
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(242, 242, 242);
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(242, 255, 179);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colRecordNo, colProjectNo, colOrderDate, colCustName, colMachineType, colMachineModel, colTestDate, colOwnerUnit, colTopic, colResolution, colReplyPerson, colNeedReply, colExpectDate, colActualDate });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Font = new Font("微軟正黑體", 9F);
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 26;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1500, 550);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            //
            // colRecordNo (隱藏欄，紀錄單號，供點選專案序號定位回對應會議紀錄)
            //
            colRecordNo.HeaderText = "紀錄單號"; colRecordNo.Name = "colRecordNo"; colRecordNo.ReadOnly = true; colRecordNo.Visible = false;
            //
            // colProjectNo
            //
            colProjectNo.HeaderText = "專案序號"; colProjectNo.Name = "colProjectNo"; colProjectNo.ReadOnly = true; colProjectNo.Width = 86;
            //
            // colOrderDate
            //
            colOrderDate.HeaderText = "訂單日期"; colOrderDate.Name = "colOrderDate"; colOrderDate.ReadOnly = true; colOrderDate.Width = 83;
            //
            // colCustName
            //
            colCustName.HeaderText = "客戶簡稱"; colCustName.Name = "colCustName"; colCustName.ReadOnly = true; colCustName.Width = 66;
            //
            // colMachineType
            //
            colMachineType.HeaderText = "機台類型"; colMachineType.Name = "colMachineType"; colMachineType.ReadOnly = true; colMachineType.Width = 56;
            //
            // colMachineModel
            //
            colMachineModel.HeaderText = "機台型號"; colMachineModel.Name = "colMachineModel"; colMachineModel.ReadOnly = true; colMachineModel.Width = 152;
            //
            // colTestDate
            //
            colTestDate.HeaderText = "驗機日期"; colTestDate.Name = "colTestDate"; colTestDate.ReadOnly = true; colTestDate.Width = 87;
            //
            // colOwnerUnit (原Label"主題"，ControlSource=權責處理單位)
            //
            colOwnerUnit.HeaderText = "主題"; colOwnerUnit.Name = "colOwnerUnit"; colOwnerUnit.ReadOnly = true; colOwnerUnit.Width = 139;
            //
            // colTopic (原Label"問題或討論事項"，ControlSource=登載或注意事項)
            //
            colTopic.HeaderText = "問題或討論事項"; colTopic.Name = "colTopic"; colTopic.ReadOnly = true; colTopic.Width = 198;
            //
            // colResolution (原Label"結論或執行方式"，ControlSource=決議)
            //
            colResolution.HeaderText = "結論或執行方式"; colResolution.Name = "colResolution"; colResolution.ReadOnly = true; colResolution.Width = 302;
            //
            // colReplyPerson (原Label"應回覆人員"，ControlSource=應回報人員)
            //
            colReplyPerson.HeaderText = "應回覆人員"; colReplyPerson.Name = "colReplyPerson"; colReplyPerson.ReadOnly = true; colReplyPerson.Width = 98;
            //
            // colNeedReply (原Label"回覆要求"，ControlSource=回報要求)
            //
            colNeedReply.HeaderText = "回覆要求"; colNeedReply.Name = "colNeedReply"; colNeedReply.ReadOnly = true; colNeedReply.Width = 54;
            //
            // colExpectDate (原Label"預計回覆日期"，ControlSource=預計回報日期)
            //
            colExpectDate.HeaderText = "預計回覆日期"; colExpectDate.Name = "colExpectDate"; colExpectDate.ReadOnly = true; colExpectDate.Width = 82;
            //
            // colActualDate (原Label"實際回覆日期"，ControlSource=實際回報日期)
            //
            colActualDate.HeaderText = "實際回覆日期"; colActualDate.Name = "colActualDate"; colActualDate.ReadOnly = true; colActualDate.Width = 83;
            //
            // panelFooter
            //
            panelFooter.BackColor = Color.FromArgb(242, 255, 179);
            panelFooter.Controls.Add(lblHint);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 590);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(1500, 38);
            panelFooter.TabIndex = 2;
            //
            // lblHint (原Label91)
            //
            lblHint.AutoSize = true;
            lblHint.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblHint.ForeColor = Color.Black;
            lblHint.Location = new Point(11, 9);
            lblHint.Name = "lblHint";
            lblHint.Size = new Size(560, 19);
            lblHint.TabIndex = 0;
            lblHint.Text = "※如欲開啟該項專案的會議履歷，請在該項的『專案序號』欄位點擊兩下！";
            //
            // ProjectFeedbackListControl
            //
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelBody);
            Controls.Add(panelFooter);
            Controls.Add(panelHeader);
            Font = new Font("微軟正黑體", 10F);
            Margin = new Padding(4);
            Name = "ProjectFeedbackListControl";
            Size = new Size(1500, 628);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelFooter.ResumeLayout(false);
            panelFooter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitle;
        private Button btnExit;
        private Panel panelBody;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colRecordNo;
        private DataGridViewTextBoxColumn colProjectNo;
        private DataGridViewTextBoxColumn colOrderDate;
        private DataGridViewTextBoxColumn colCustName;
        private DataGridViewTextBoxColumn colMachineType;
        private DataGridViewTextBoxColumn colMachineModel;
        private DataGridViewTextBoxColumn colTestDate;
        private DataGridViewTextBoxColumn colOwnerUnit;
        private DataGridViewTextBoxColumn colTopic;
        private DataGridViewTextBoxColumn colResolution;
        private DataGridViewTextBoxColumn colReplyPerson;
        private DataGridViewCheckBoxColumn colNeedReply;
        private DataGridViewTextBoxColumn colExpectDate;
        private DataGridViewTextBoxColumn colActualDate;
        private Panel panelFooter;
        private Label lblHint;
    }
}
