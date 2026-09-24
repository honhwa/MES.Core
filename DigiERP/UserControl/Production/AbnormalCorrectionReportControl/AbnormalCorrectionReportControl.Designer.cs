using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.Production
{
    partial class AbnormalCorrectionReportControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AbnormalCorrectionReportControl));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            btnEdit = new Button();
            btnSave = new Button();
            btnActivate = new Button();
            btnDeactivate = new Button();
            btnPrint = new Button();
            btnOverview = new Button();
            btnExit = new Button();
            panelContext = new Panel();
            panelLeft = new Panel();
            panelRight = new Panel();
            panelFooter = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Cornsilk;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(btnActivate);
            panel1.Controls.Add(btnDeactivate);
            panel1.Controls.Add(btnPrint);
            panel1.Controls.Add(btnOverview);
            panel1.Controls.Add(btnExit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1900, 60);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(8, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("微軟正黑體", 13F, FontStyle.Bold);
            lblTitle.Location = new Point(76, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(154, 23);
            lblTitle.TabIndex = 0;
            lblTitle.Tag = "title";
            lblTitle.Text = "異常矯正措施報告";
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.LightSteelBlue;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnEdit.Location = new Point(948, 12);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(90, 32);
            btnEdit.TabIndex = 1;
            btnEdit.Tag = "btn-modify";
            btnEdit.Text = "修改";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.LightSteelBlue;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnSave.Location = new Point(1046, 12);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(90, 32);
            btnSave.TabIndex = 2;
            btnSave.Tag = "btn-modify";
            btnSave.Text = "儲存";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnActivate
            // 
            btnActivate.BackColor = Color.LightGreen;
            btnActivate.FlatStyle = FlatStyle.Flat;
            btnActivate.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnActivate.Location = new Point(1144, 12);
            btnActivate.Name = "btnActivate";
            btnActivate.Size = new Size(80, 32);
            btnActivate.TabIndex = 3;
            btnActivate.Tag = "btn-modify";
            btnActivate.Text = "生效";
            btnActivate.UseVisualStyleBackColor = false;
            btnActivate.Click += btnActivate_Click;
            // 
            // btnDeactivate
            // 
            btnDeactivate.BackColor = Color.LightGray;
            btnDeactivate.FlatStyle = FlatStyle.Flat;
            btnDeactivate.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnDeactivate.Location = new Point(1232, 12);
            btnDeactivate.Name = "btnDeactivate";
            btnDeactivate.Size = new Size(90, 32);
            btnDeactivate.TabIndex = 4;
            btnDeactivate.Tag = "btn-modify";
            btnDeactivate.Text = "取消生效";
            btnDeactivate.UseVisualStyleBackColor = false;
            btnDeactivate.Click += btnDeactivate_Click;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.LightGray;
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnPrint.Location = new Point(1330, 12);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(80, 32);
            btnPrint.TabIndex = 5;
            btnPrint.Tag = "btn-modify";
            btnPrint.Text = "列印";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // btnOverview
            // 
            btnOverview.BackColor = Color.LightGray;
            btnOverview.FlatStyle = FlatStyle.Flat;
            btnOverview.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnOverview.Location = new Point(1418, 12);
            btnOverview.Name = "btnOverview";
            btnOverview.Size = new Size(80, 32);
            btnOverview.TabIndex = 6;
            btnOverview.Tag = "btn-modify";
            btnOverview.Text = "總覽";
            btnOverview.UseVisualStyleBackColor = false;
            btnOverview.Click += btnOverview_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.LightSteelBlue;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnExit.Location = new Point(1506, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(98, 32);
            btnExit.TabIndex = 7;
            btnExit.Tag = "btn-modify";
            btnExit.Text = "關閉";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // panelContext
            // 
            panelContext.BackColor = Color.Cornsilk;
            panelContext.Dock = DockStyle.Top;
            panelContext.Location = new Point(0, 60);
            panelContext.Name = "panelContext";
            panelContext.Size = new Size(1900, 176);
            panelContext.TabIndex = 1;
            // 
            // panelLeft
            // 
            panelLeft.Dock = DockStyle.Fill;
            panelLeft.Location = new Point(0, 236);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(1489, 424);
            panelLeft.TabIndex = 2;
            // 
            // panelRight
            // 
            panelRight.BackColor = Color.WhiteSmoke;
            panelRight.Dock = DockStyle.Right;
            panelRight.Location = new Point(1489, 236);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(411, 424);
            panelRight.TabIndex = 3;
            // 
            // panelFooter
            // 
            panelFooter.BackColor = Color.Cornsilk;
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 660);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(1900, 42);
            panelFooter.TabIndex = 4;
            // 
            // AbnormalCorrectionReportControl
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelLeft);
            Controls.Add(panelRight);
            Controls.Add(panelFooter);
            Controls.Add(panelContext);
            Controls.Add(panel1);
            Font = new Font("微軟正黑體", 10F);
            Margin = new Padding(4);
            Name = "AbnormalCorrectionReportControl";
            Size = new Size(1900, 702);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblTitle;
        private Button btnEdit;
        private Button btnSave;
        private Button btnActivate;
        private Button btnDeactivate;
        private Button btnPrint;
        private Button btnOverview;
        private Button btnExit;
        private Panel panelContext;
        private Panel panelLeft;
        private Panel panelRight;
        private Panel panelFooter;
        private PictureBox pictureBox1;
    }
}
