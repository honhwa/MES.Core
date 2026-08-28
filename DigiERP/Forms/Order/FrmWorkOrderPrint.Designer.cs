using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.Forms.Order
{
    partial class FrmWorkOrderPrint
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        //
        // 比照 PITS-2025.accdb Report「工令單內容-H」(RecordSource=查詢
        // 工令單內容-Others，WHERE 機台類型="H")還原。因欄位數量龐大(60餘欄)，
        // 版面內容改由 DigiERP.Forms.Common.ReportLayoutHelper 於 FrmWorkOrderPrint.cs
        // (非本檔)執行期動態產生，本檔僅保留外層容器(pnlScroll/pnlContent)與固
        // 定按鈕列，避免 Visual Studio 表單設計工具因無法序列化動態版面而遺失
        // 內容 ──────────────────────────────────────────────────────────
        //
        private void InitializeComponent()
        {
            pnlTop = new Panel();
            lblTitle = new Label();
            btnPreviewPrint = new Button();
            btnPrint = new Button();
            btnExit = new Button();
            pnlScroll = new Panel();
            pnlContent = new Panel();
            pnlTop.SuspendLayout();
            pnlScroll.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(240, 240, 240);
            pnlTop.Controls.Add(lblTitle);
            pnlTop.Controls.Add(btnPreviewPrint);
            pnlTop.Controls.Add(btnPrint);
            pnlTop.Controls.Add(btnExit);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(900, 46);
            pnlTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("標楷體", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(12, 8);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(300, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "工令單";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnPreviewPrint
            // 
            btnPreviewPrint.BackColor = Color.FromArgb(69, 98, 135);
            btnPreviewPrint.FlatStyle = FlatStyle.Flat;
            btnPreviewPrint.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnPreviewPrint.ForeColor = Color.White;
            btnPreviewPrint.Location = new Point(560, 8);
            btnPreviewPrint.Name = "btnPreviewPrint";
            btnPreviewPrint.Size = new Size(100, 30);
            btnPreviewPrint.TabIndex = 1;
            btnPreviewPrint.Text = "匯出PDF";
            btnPreviewPrint.UseVisualStyleBackColor = false;
            btnPreviewPrint.Click += btnPreviewPrint_Click;
            //
            // btnPrint
            //
            btnPrint.BackColor = Color.FromArgb(69, 98, 135);
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnPrint.ForeColor = Color.White;
            btnPrint.Location = new Point(670, 8);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(80, 30);
            btnPrint.TabIndex = 2;
            btnPrint.Text = "列印";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            //
            // btnExit
            //
            btnExit.BackColor = Color.Gray;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(760, 8);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(100, 30);
            btnExit.TabIndex = 3;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // pnlScroll
            // 
            pnlScroll.AutoScroll = true;
            pnlScroll.BackColor = Color.Gainsboro;
            pnlScroll.Controls.Add(pnlContent);
            pnlScroll.Dock = DockStyle.Fill;
            pnlScroll.Location = new Point(0, 46);
            pnlScroll.Name = "pnlScroll";
            pnlScroll.Size = new Size(900, 942);
            pnlScroll.TabIndex = 1;
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.White;
            pnlContent.Location = new Point(8, 8);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(870, 900);
            pnlContent.TabIndex = 0;
            // 
            // FrmWorkOrderPrint
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 988);
            Controls.Add(pnlScroll);
            Controls.Add(pnlTop);
            Font = new Font("微軟正黑體", 9F);
            MinimumSize = new Size(700, 400);
            Name = "FrmWorkOrderPrint";
            StartPosition = FormStartPosition.CenterParent;
            Text = "工令單 - 預覽列印";
            pnlTop.ResumeLayout(false);
            pnlScroll.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTop;
        private Label lblTitle;
        private Button btnPreviewPrint;
        private Button btnPrint;
        private Button btnExit;
        private Panel pnlScroll;
        private Panel pnlContent;
    }
}
