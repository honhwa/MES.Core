using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.Order
{
    partial class WorkOrderControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼
        //
        // 版面完全比照 PITS-2025.accdb「P-工令單H」表單之控制項座標(twips/15=px)，
        // 逐一還原：表單首(按鈕列)、詳細資料(全部欄位，含最上方專案序號列)、
        // 表單尾(核准/修改/建檔簽核列)。因原表單 5 種機台類型(H/M/FB/GT/S&PJ)
        // 欄位配置各異但共用同一張 工令單 資料表，此處以 H 型版面為準統一呈現。
        //
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkOrderControl));
            panelHeader = new Panel();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            btnProductSpec = new Button();
            btnEngAnalysis = new Button();
            btnMeetingLog = new Button();
            btnEdit = new Button();
            btnSave = new Button();
            btnApprove = new Button();
            btnUnapprove = new Button();
            btnPrint = new Button();
            btnBackToList = new Button();
            btnExit = new Button();
            panelBody = new Panel();
            lbl_專案序號 = new Label();
            txt_專案序號 = new TextBox();
            lbl_訂單日期 = new Label();
            txt_訂單日期 = new TextBox();
            lbl_參考序號 = new Label();
            txt_參考序號 = new TextBox();
            lbl_機台型號 = new Label();
            txt_機台型號 = new TextBox();
            lbl_機台類型 = new Label();
            cmb_機台類型 = new ComboBox();
            lbl_機台名稱 = new Label();
            txt_機台名稱 = new TextBox();
            cmb_操作控制箱 = new ComboBox();
            lbl_操作控制箱 = new Label();
            cmb_三點組合 = new ComboBox();
            lbl_三點組合 = new Label();
            cmb_PLC控制器 = new ComboBox();
            lbl_PLC控制器 = new Label();
            cmb_入力線方向 = new ComboBox();
            lbl_入力線方向 = new Label();
            cmb_安全光照簾 = new ComboBox();
            lbl_安全光照簾 = new Label();
            cmb_安全柵欄 = new ComboBox();
            lbl_安全柵欄 = new Label();
            cmb_安全門火花檔板 = new ComboBox();
            lbl_安全門火花擋板 = new Label();
            cmb_蜂鳴器 = new ComboBox();
            lbl_蜂鳴器 = new Label();
            cmb_無熔絲開關 = new ComboBox();
            lbl_無熔絲開關 = new Label();
            cmb_三色燈 = new ComboBox();
            lbl_三色燈 = new Label();
            cmb_水流浮球 = new ComboBox();
            lbl_水流顯示器 = new Label();
            cmb_水流水壓 = new ComboBox();
            lbl_水流開關 = new Label();
            cmb_冰水機_熱交換器 = new ComboBox();
            lbl_冰水機熱交換器 = new Label();
            cmb_馬達 = new ComboBox();
            lbl_馬達 = new Label();
            cmb_顏色 = new ComboBox();
            lbl_顏色 = new Label();
            cmb_啟動方式 = new ComboBox();
            lbl_啟動方式 = new Label();
            cmb_其他氣缸電磁閥 = new ComboBox();
            lbl_氣缸電磁閥 = new Label();
            cmb_其他氣缸 = new ComboBox();
            lbl_氣缸 = new Label();
            cmb_風壓壓力開關 = new ComboBox();
            lbl_風壓壓力開關 = new Label();
            cmb_壓力比例閥 = new ComboBox();
            lbl_壓力比例閥 = new Label();
            cmb_氣壓配管 = new ComboBox();
            lbl_氣壓配管 = new Label();
            cmb_空氣儲存桶 = new ComboBox();
            lbl_空氣儲存桶 = new Label();
            cmb_空氣儲存桶ps = new ComboBox();
            cmb_啟動方式ps = new ComboBox();
            cmb_操作控制箱ps = new ComboBox();
            cmb_安全光照簾ps = new ComboBox();
            cmb_無熔絲開關ps = new ComboBox();
            cmb_馬達ps = new ComboBox();
            cmb_三色燈ps = new ComboBox();
            cmb_人機介面 = new ComboBox();
            lbl_人機介面 = new Label();
            cmb_人機介面ps = new ComboBox();
            lbl_機構說明 = new Label();
            txt_說明 = new TextBox();
            lbl_電控元件說明 = new Label();
            txt_備註 = new TextBox();
            chk_結案 = new CheckBox();
            lbl_結案 = new Label();
            lbl_國家地區 = new Label();
            txt_國家地區 = new TextBox();
            lbl_客戶 = new Label();
            txt_客戶名稱 = new TextBox();
            lbl_客戶簡稱 = new Label();
            txt_客戶簡稱 = new TextBox();
            cmb_焊接控制器Y13 = new ComboBox();
            lbl_驗機日期 = new Label();
            txt_驗機日期 = new TextBox();
            lbl_交貨日期 = new Label();
            txt_交貨日期 = new TextBox();
            cmb_廠驗 = new ComboBox();
            cmb_裝機 = new ComboBox();
            cmb_電流 = new ComboBox();
            cmb_焊接電壓v = new ComboBox();
            cmb_焊接物 = new ComboBox();
            cmb_圖面設計 = new ComboBox();
            cmb_安規要求 = new ComboBox();
            txt_生產速率 = new TextBox();
            lbl_廠驗 = new Label();
            lbl_裝機 = new Label();
            lbl_電流 = new Label();
            lbl_入力電壓 = new Label();
            lbl_控制電壓 = new Label();
            lbl_審圖需求 = new Label();
            lbl_安規要求 = new Label();
            lbl_生產速率 = new Label();
            cmb_焊接電壓hz = new ComboBox();
            cmb_焊接電壓 = new ComboBox();
            txtOrphan_PLCTYPE = new TextBox();
            panelFooter = new Panel();
            lblF_核准人員 = new Label();
            txtF_核准 = new TextBox();
            lblF_修改人員 = new Label();
            txtF_修改 = new TextBox();
            lblF_建檔人員 = new Label();
            txtF_建檔 = new TextBox();
            txtF_核准日 = new TextBox();
            txtF_修改日 = new TextBox();
            txtF_建檔日 = new TextBox();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelBody.SuspendLayout();
            panelFooter.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(252, 230, 212);
            panelHeader.Controls.Add(pictureBox1);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Controls.Add(btnProductSpec);
            panelHeader.Controls.Add(btnEngAnalysis);
            panelHeader.Controls.Add(btnMeetingLog);
            panelHeader.Controls.Add(btnEdit);
            panelHeader.Controls.Add(btnSave);
            panelHeader.Controls.Add(btnApprove);
            panelHeader.Controls.Add(btnUnapprove);
            panelHeader.Controls.Add(btnPrint);
            panelHeader.Controls.Add(btnBackToList);
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
            pictureBox1.Location = new Point(4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 34);
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
            lblTitle.Size = new Size(58, 21);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "工令單";
            // 
            // btnProductSpec
            // 
            btnProductSpec.BackColor = Color.LightSteelBlue;
            btnProductSpec.FlatStyle = FlatStyle.Flat;
            btnProductSpec.Font = new Font("微軟正黑體", 8F, FontStyle.Bold);
            btnProductSpec.Location = new Point(189, 7);
            btnProductSpec.Name = "btnProductSpec";
            btnProductSpec.Size = new Size(99, 33);
            btnProductSpec.TabIndex = 2;
            btnProductSpec.Text = "產品規格單";
            btnProductSpec.UseVisualStyleBackColor = false;
            btnProductSpec.Click += btnProductSpec_Click;
            // 
            // btnEngAnalysis
            // 
            btnEngAnalysis.BackColor = Color.LightSteelBlue;
            btnEngAnalysis.FlatStyle = FlatStyle.Flat;
            btnEngAnalysis.Font = new Font("微軟正黑體", 8F, FontStyle.Bold);
            btnEngAnalysis.Location = new Point(302, 7);
            btnEngAnalysis.Name = "btnEngAnalysis";
            btnEngAnalysis.Size = new Size(99, 33);
            btnEngAnalysis.TabIndex = 3;
            btnEngAnalysis.Text = "工程分析表";
            btnEngAnalysis.UseVisualStyleBackColor = false;
            btnEngAnalysis.Click += btnEngAnalysis_Click;
            // 
            // btnMeetingLog
            // 
            btnMeetingLog.BackColor = Color.LightSteelBlue;
            btnMeetingLog.FlatStyle = FlatStyle.Flat;
            btnMeetingLog.Font = new Font("微軟正黑體", 8F, FontStyle.Bold);
            btnMeetingLog.Location = new Point(415, 7);
            btnMeetingLog.Name = "btnMeetingLog";
            btnMeetingLog.Size = new Size(99, 33);
            btnMeetingLog.TabIndex = 4;
            btnMeetingLog.Text = "專案會議紀錄";
            btnMeetingLog.UseVisualStyleBackColor = false;
            btnMeetingLog.Click += btnMeetingLog_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.SteelBlue;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(624, 8);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(60, 32);
            btnEdit.TabIndex = 5;
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
            btnSave.Location = new Point(696, 8);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(65, 32);
            btnSave.TabIndex = 6;
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
            btnApprove.Location = new Point(772, 8);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(60, 32);
            btnApprove.TabIndex = 7;
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
            btnUnapprove.Location = new Point(850, 8);
            btnUnapprove.Name = "btnUnapprove";
            btnUnapprove.Size = new Size(80, 32);
            btnUnapprove.TabIndex = 8;
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
            btnPrint.Location = new Point(941, 8);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(60, 32);
            btnPrint.TabIndex = 9;
            btnPrint.Text = "列印";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // btnBackToList
            // 
            btnBackToList.BackColor = Color.SteelBlue;
            btnBackToList.FlatStyle = FlatStyle.Flat;
            btnBackToList.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnBackToList.ForeColor = Color.White;
            btnBackToList.Location = new Point(1015, 8);
            btnBackToList.Name = "btnBackToList";
            btnBackToList.Size = new Size(65, 32);
            btnBackToList.TabIndex = 10;
            btnBackToList.Text = "總覽";
            btnBackToList.UseVisualStyleBackColor = false;
            btnBackToList.Click += btnBackToList_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.SteelBlue;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(1089, 8);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(60, 32);
            btnExit.TabIndex = 11;
            btnExit.Text = "關閉";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // panelBody
            // 
            panelBody.AutoScroll = true;
            panelBody.BackColor = Color.White;
            panelBody.Controls.Add(lbl_專案序號);
            panelBody.Controls.Add(txt_專案序號);
            panelBody.Controls.Add(lbl_訂單日期);
            panelBody.Controls.Add(txt_訂單日期);
            panelBody.Controls.Add(lbl_參考序號);
            panelBody.Controls.Add(txt_參考序號);
            panelBody.Controls.Add(lbl_機台型號);
            panelBody.Controls.Add(txt_機台型號);
            panelBody.Controls.Add(lbl_機台類型);
            panelBody.Controls.Add(cmb_機台類型);
            panelBody.Controls.Add(lbl_機台名稱);
            panelBody.Controls.Add(txt_機台名稱);
            panelBody.Controls.Add(cmb_操作控制箱);
            panelBody.Controls.Add(lbl_操作控制箱);
            panelBody.Controls.Add(cmb_三點組合);
            panelBody.Controls.Add(lbl_三點組合);
            panelBody.Controls.Add(cmb_PLC控制器);
            panelBody.Controls.Add(lbl_PLC控制器);
            panelBody.Controls.Add(cmb_入力線方向);
            panelBody.Controls.Add(lbl_入力線方向);
            panelBody.Controls.Add(cmb_安全光照簾);
            panelBody.Controls.Add(lbl_安全光照簾);
            panelBody.Controls.Add(cmb_安全柵欄);
            panelBody.Controls.Add(lbl_安全柵欄);
            panelBody.Controls.Add(cmb_安全門火花檔板);
            panelBody.Controls.Add(lbl_安全門火花擋板);
            panelBody.Controls.Add(cmb_蜂鳴器);
            panelBody.Controls.Add(lbl_蜂鳴器);
            panelBody.Controls.Add(cmb_無熔絲開關);
            panelBody.Controls.Add(lbl_無熔絲開關);
            panelBody.Controls.Add(cmb_三色燈);
            panelBody.Controls.Add(lbl_三色燈);
            panelBody.Controls.Add(cmb_水流浮球);
            panelBody.Controls.Add(lbl_水流顯示器);
            panelBody.Controls.Add(cmb_水流水壓);
            panelBody.Controls.Add(lbl_水流開關);
            panelBody.Controls.Add(cmb_冰水機_熱交換器);
            panelBody.Controls.Add(lbl_冰水機熱交換器);
            panelBody.Controls.Add(cmb_馬達);
            panelBody.Controls.Add(lbl_馬達);
            panelBody.Controls.Add(cmb_顏色);
            panelBody.Controls.Add(lbl_顏色);
            panelBody.Controls.Add(cmb_啟動方式);
            panelBody.Controls.Add(lbl_啟動方式);
            panelBody.Controls.Add(cmb_其他氣缸電磁閥);
            panelBody.Controls.Add(lbl_氣缸電磁閥);
            panelBody.Controls.Add(cmb_其他氣缸);
            panelBody.Controls.Add(lbl_氣缸);
            panelBody.Controls.Add(cmb_風壓壓力開關);
            panelBody.Controls.Add(lbl_風壓壓力開關);
            panelBody.Controls.Add(cmb_壓力比例閥);
            panelBody.Controls.Add(lbl_壓力比例閥);
            panelBody.Controls.Add(cmb_氣壓配管);
            panelBody.Controls.Add(lbl_氣壓配管);
            panelBody.Controls.Add(cmb_空氣儲存桶);
            panelBody.Controls.Add(lbl_空氣儲存桶);
            panelBody.Controls.Add(cmb_空氣儲存桶ps);
            panelBody.Controls.Add(cmb_啟動方式ps);
            panelBody.Controls.Add(cmb_操作控制箱ps);
            panelBody.Controls.Add(cmb_安全光照簾ps);
            panelBody.Controls.Add(cmb_無熔絲開關ps);
            panelBody.Controls.Add(cmb_馬達ps);
            panelBody.Controls.Add(cmb_三色燈ps);
            panelBody.Controls.Add(cmb_人機介面);
            panelBody.Controls.Add(lbl_人機介面);
            panelBody.Controls.Add(cmb_人機介面ps);
            panelBody.Controls.Add(lbl_機構說明);
            panelBody.Controls.Add(txt_說明);
            panelBody.Controls.Add(lbl_電控元件說明);
            panelBody.Controls.Add(txt_備註);
            panelBody.Controls.Add(chk_結案);
            panelBody.Controls.Add(lbl_結案);
            panelBody.Controls.Add(lbl_國家地區);
            panelBody.Controls.Add(txt_國家地區);
            panelBody.Controls.Add(lbl_客戶);
            panelBody.Controls.Add(txt_客戶名稱);
            panelBody.Controls.Add(lbl_客戶簡稱);
            panelBody.Controls.Add(txt_客戶簡稱);
            panelBody.Controls.Add(cmb_焊接控制器Y13);
            panelBody.Controls.Add(lbl_驗機日期);
            panelBody.Controls.Add(txt_驗機日期);
            panelBody.Controls.Add(lbl_交貨日期);
            panelBody.Controls.Add(txt_交貨日期);
            panelBody.Controls.Add(cmb_廠驗);
            panelBody.Controls.Add(cmb_裝機);
            panelBody.Controls.Add(cmb_電流);
            panelBody.Controls.Add(cmb_焊接電壓v);
            panelBody.Controls.Add(cmb_焊接物);
            panelBody.Controls.Add(cmb_圖面設計);
            panelBody.Controls.Add(cmb_安規要求);
            panelBody.Controls.Add(txt_生產速率);
            panelBody.Controls.Add(lbl_廠驗);
            panelBody.Controls.Add(lbl_裝機);
            panelBody.Controls.Add(lbl_電流);
            panelBody.Controls.Add(lbl_入力電壓);
            panelBody.Controls.Add(lbl_控制電壓);
            panelBody.Controls.Add(lbl_審圖需求);
            panelBody.Controls.Add(lbl_安規要求);
            panelBody.Controls.Add(lbl_生產速率);
            panelBody.Controls.Add(cmb_焊接電壓hz);
            panelBody.Controls.Add(cmb_焊接電壓);
            panelBody.Controls.Add(txtOrphan_PLCTYPE);
            panelBody.Dock = DockStyle.Fill;
            panelBody.Location = new Point(0, 60);
            panelBody.Name = "panelBody";
            panelBody.Size = new Size(1360, 584);
            panelBody.TabIndex = 1;
            // 
            // lbl_專案序號
            // 
            lbl_專案序號.ForeColor = Color.DimGray;
            lbl_專案序號.Location = new Point(11, 7);
            lbl_專案序號.Name = "lbl_專案序號";
            lbl_專案序號.Size = new Size(72, 24);
            lbl_專案序號.TabIndex = 0;
            lbl_專案序號.Text = "專案序號";
            lbl_專案序號.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_專案序號
            // 
            txt_專案序號.Location = new Point(87, 7);
            txt_專案序號.Name = "txt_專案序號";
            txt_專案序號.Size = new Size(204, 23);
            txt_專案序號.TabIndex = 1;
            // 
            // lbl_訂單日期
            // 
            lbl_訂單日期.ForeColor = Color.DimGray;
            lbl_訂單日期.Location = new Point(306, 8);
            lbl_訂單日期.Name = "lbl_訂單日期";
            lbl_訂單日期.Size = new Size(72, 24);
            lbl_訂單日期.TabIndex = 2;
            lbl_訂單日期.Text = "訂單日期";
            lbl_訂單日期.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_訂單日期
            // 
            txt_訂單日期.Location = new Point(381, 8);
            txt_訂單日期.Name = "txt_訂單日期";
            txt_訂單日期.Size = new Size(148, 23);
            txt_訂單日期.TabIndex = 3;
            // 
            // lbl_參考序號
            // 
            lbl_參考序號.ForeColor = Color.DimGray;
            lbl_參考序號.Location = new Point(11, 35);
            lbl_參考序號.Name = "lbl_參考序號";
            lbl_參考序號.Size = new Size(72, 24);
            lbl_參考序號.TabIndex = 4;
            lbl_參考序號.Text = "參考序號";
            lbl_參考序號.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_參考序號
            // 
            txt_參考序號.Location = new Point(87, 35);
            txt_參考序號.Name = "txt_參考序號";
            txt_參考序號.Size = new Size(174, 23);
            txt_參考序號.TabIndex = 5;
            // 
            // lbl_機台型號
            // 
            lbl_機台型號.ForeColor = Color.DimGray;
            lbl_機台型號.Location = new Point(11, 63);
            lbl_機台型號.Name = "lbl_機台型號";
            lbl_機台型號.Size = new Size(72, 23);
            lbl_機台型號.TabIndex = 6;
            lbl_機台型號.Text = "機台型號";
            lbl_機台型號.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_機台型號
            // 
            txt_機台型號.Location = new Point(87, 63);
            txt_機台型號.Name = "txt_機台型號";
            txt_機台型號.Size = new Size(204, 23);
            txt_機台型號.TabIndex = 7;
            // 
            // lbl_機台類型
            // 
            lbl_機台類型.ForeColor = Color.DimGray;
            lbl_機台類型.Location = new Point(11, 90);
            lbl_機台類型.Name = "lbl_機台類型";
            lbl_機台類型.Size = new Size(72, 23);
            lbl_機台類型.TabIndex = 8;
            lbl_機台類型.Text = "機台類型";
            lbl_機台類型.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmb_機台類型
            // 
            cmb_機台類型.Items.AddRange(new object[] { "H", "M", "FB", "GT", "G", "S", "PJ" });
            cmb_機台類型.Location = new Point(87, 90);
            cmb_機台類型.Name = "cmb_機台類型";
            cmb_機台類型.Size = new Size(204, 24);
            cmb_機台類型.TabIndex = 9;
            // 
            // lbl_機台名稱
            // 
            lbl_機台名稱.ForeColor = Color.DimGray;
            lbl_機台名稱.Location = new Point(11, 119);
            lbl_機台名稱.Name = "lbl_機台名稱";
            lbl_機台名稱.Size = new Size(72, 23);
            lbl_機台名稱.TabIndex = 10;
            lbl_機台名稱.Text = "機台名稱";
            lbl_機台名稱.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_機台名稱
            // 
            txt_機台名稱.Location = new Point(87, 119);
            txt_機台名稱.Name = "txt_機台名稱";
            txt_機台名稱.Size = new Size(798, 23);
            txt_機台名稱.TabIndex = 11;
            // 
            // cmb_操作控制箱
            // 
            cmb_操作控制箱.Items.AddRange(new object[] { "固定", "懸吊", "其他" });
            cmb_操作控制箱.Location = new Point(1035, 147);
            cmb_操作控制箱.Name = "cmb_操作控制箱";
            cmb_操作控制箱.Size = new Size(152, 24);
            cmb_操作控制箱.TabIndex = 12;
            // 
            // lbl_操作控制箱
            // 
            lbl_操作控制箱.ForeColor = Color.DimGray;
            lbl_操作控制箱.Location = new Point(907, 147);
            lbl_操作控制箱.Name = "lbl_操作控制箱";
            lbl_操作控制箱.Size = new Size(124, 23);
            lbl_操作控制箱.TabIndex = 13;
            lbl_操作控制箱.Text = "操作控制箱";
            lbl_操作控制箱.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmb_三點組合
            // 
            cmb_三點組合.Items.AddRange(new object[] { "無", "金器", "SMC", "Airtec", "FESTO" });
            cmb_三點組合.Location = new Point(1035, 333);
            cmb_三點組合.Name = "cmb_三點組合";
            cmb_三點組合.Size = new Size(303, 24);
            cmb_三點組合.TabIndex = 14;
            // 
            // lbl_三點組合
            // 
            lbl_三點組合.ForeColor = Color.DimGray;
            lbl_三點組合.Location = new Point(907, 333);
            lbl_三點組合.Name = "lbl_三點組合";
            lbl_三點組合.Size = new Size(124, 23);
            lbl_三點組合.TabIndex = 15;
            lbl_三點組合.Text = "三點組合";
            lbl_三點組合.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmb_PLC控制器
            // 
            cmb_PLC控制器.Items.AddRange(new object[] { "無", "三菱FX", "永宏", "洛克威爾AB", "西門子Simense", "三菱iQ", "台達" });
            cmb_PLC控制器.Location = new Point(140, 200);
            cmb_PLC控制器.Name = "cmb_PLC控制器";
            cmb_PLC控制器.Size = new Size(155, 24);
            cmb_PLC控制器.TabIndex = 16;
            // 
            // lbl_PLC控制器
            // 
            lbl_PLC控制器.ForeColor = Color.DimGray;
            lbl_PLC控制器.Location = new Point(12, 200);
            lbl_PLC控制器.Name = "lbl_PLC控制器";
            lbl_PLC控制器.Size = new Size(124, 23);
            lbl_PLC控制器.TabIndex = 17;
            lbl_PLC控制器.Text = "PLC 控制器";
            lbl_PLC控制器.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmb_入力線方向
            // 
            cmb_入力線方向.Items.AddRange(new object[] { "由上入", "由下入" });
            cmb_入力線方向.Location = new Point(1035, 200);
            cmb_入力線方向.Name = "cmb_入力線方向";
            cmb_入力線方向.Size = new Size(303, 24);
            cmb_入力線方向.TabIndex = 18;
            // 
            // lbl_入力線方向
            // 
            lbl_入力線方向.ForeColor = Color.DimGray;
            lbl_入力線方向.Location = new Point(907, 200);
            lbl_入力線方向.Name = "lbl_入力線方向";
            lbl_入力線方向.Size = new Size(124, 23);
            lbl_入力線方向.TabIndex = 19;
            lbl_入力線方向.Text = "入力線方向";
            lbl_入力線方向.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmb_安全光照簾
            // 
            cmb_安全光照簾.Items.AddRange(new object[] { "無", "帥風Schumersal", "西克Sick", "邦納Banner", "皮爾磁Pilz", "基恩斯Keyence" });
            cmb_安全光照簾.Location = new Point(140, 227);
            cmb_安全光照簾.Name = "cmb_安全光照簾";
            cmb_安全光照簾.Size = new Size(155, 24);
            cmb_安全光照簾.TabIndex = 20;
            // 
            // lbl_安全光照簾
            // 
            lbl_安全光照簾.ForeColor = Color.DimGray;
            lbl_安全光照簾.Location = new Point(12, 227);
            lbl_安全光照簾.Name = "lbl_安全光照簾";
            lbl_安全光照簾.Size = new Size(124, 23);
            lbl_安全光照簾.TabIndex = 21;
            lbl_安全光照簾.Text = "安全光照簾";
            lbl_安全光照簾.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmb_安全柵欄
            // 
            cmb_安全柵欄.Items.AddRange(new object[] { "提供", "不提供" });
            cmb_安全柵欄.Location = new Point(592, 227);
            cmb_安全柵欄.Name = "cmb_安全柵欄";
            cmb_安全柵欄.Size = new Size(304, 24);
            cmb_安全柵欄.TabIndex = 22;
            // 
            // lbl_安全柵欄
            // 
            lbl_安全柵欄.ForeColor = Color.DimGray;
            lbl_安全柵欄.Location = new Point(463, 227);
            lbl_安全柵欄.Name = "lbl_安全柵欄";
            lbl_安全柵欄.Size = new Size(124, 23);
            lbl_安全柵欄.TabIndex = 23;
            lbl_安全柵欄.Text = "安全柵欄";
            lbl_安全柵欄.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmb_安全門火花檔板
            // 
            cmb_安全門火花檔板.Location = new Point(1035, 227);
            cmb_安全門火花檔板.Name = "cmb_安全門火花檔板";
            cmb_安全門火花檔板.Size = new Size(303, 24);
            cmb_安全門火花檔板.TabIndex = 24;
            // 
            // lbl_安全門火花擋板
            // 
            lbl_安全門火花擋板.ForeColor = Color.DimGray;
            lbl_安全門火花擋板.Location = new Point(907, 227);
            lbl_安全門火花擋板.Name = "lbl_安全門火花擋板";
            lbl_安全門火花擋板.Size = new Size(124, 23);
            lbl_安全門火花擋板.TabIndex = 25;
            lbl_安全門火花擋板.Text = "安全門火花擋板";
            lbl_安全門火花擋板.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmb_蜂鳴器
            // 
            cmb_蜂鳴器.Items.AddRange(new object[] { "提供" });
            cmb_蜂鳴器.Location = new Point(140, 253);
            cmb_蜂鳴器.Name = "cmb_蜂鳴器";
            cmb_蜂鳴器.Size = new Size(310, 24);
            cmb_蜂鳴器.TabIndex = 26;
            // 
            // lbl_蜂鳴器
            // 
            lbl_蜂鳴器.ForeColor = Color.DimGray;
            lbl_蜂鳴器.Location = new Point(12, 253);
            lbl_蜂鳴器.Name = "lbl_蜂鳴器";
            lbl_蜂鳴器.Size = new Size(124, 23);
            lbl_蜂鳴器.TabIndex = 27;
            lbl_蜂鳴器.Text = "蜂鳴器";
            lbl_蜂鳴器.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmb_無熔絲開關
            // 
            cmb_無熔絲開關.Items.AddRange(new object[] { "提供", "不提供" });
            cmb_無熔絲開關.Location = new Point(592, 253);
            cmb_無熔絲開關.Name = "cmb_無熔絲開關";
            cmb_無熔絲開關.Size = new Size(156, 24);
            cmb_無熔絲開關.TabIndex = 28;
            // 
            // lbl_無熔絲開關
            // 
            lbl_無熔絲開關.ForeColor = Color.DimGray;
            lbl_無熔絲開關.Location = new Point(463, 253);
            lbl_無熔絲開關.Name = "lbl_無熔絲開關";
            lbl_無熔絲開關.Size = new Size(124, 23);
            lbl_無熔絲開關.TabIndex = 29;
            lbl_無熔絲開關.Text = "無熔絲開關";
            lbl_無熔絲開關.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmb_三色燈
            // 
            cmb_三色燈.Items.AddRange(new object[] { "提供", "不提供" });
            cmb_三色燈.Location = new Point(1035, 253);
            cmb_三色燈.Name = "cmb_三色燈";
            cmb_三色燈.Size = new Size(152, 24);
            cmb_三色燈.TabIndex = 30;
            // 
            // lbl_三色燈
            // 
            lbl_三色燈.ForeColor = Color.DimGray;
            lbl_三色燈.Location = new Point(907, 253);
            lbl_三色燈.Name = "lbl_三色燈";
            lbl_三色燈.Size = new Size(124, 23);
            lbl_三色燈.TabIndex = 31;
            lbl_三色燈.Text = "三色燈";
            lbl_三色燈.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmb_水流浮球
            // 
            cmb_水流浮球.Items.AddRange(new object[] { "提供", "不提供" });
            cmb_水流浮球.Location = new Point(140, 280);
            cmb_水流浮球.Name = "cmb_水流浮球";
            cmb_水流浮球.Size = new Size(310, 24);
            cmb_水流浮球.TabIndex = 32;
            // 
            // lbl_水流顯示器
            // 
            lbl_水流顯示器.ForeColor = Color.DimGray;
            lbl_水流顯示器.Location = new Point(12, 280);
            lbl_水流顯示器.Name = "lbl_水流顯示器";
            lbl_水流顯示器.Size = new Size(124, 23);
            lbl_水流顯示器.TabIndex = 33;
            lbl_水流顯示器.Text = "水流顯示器";
            lbl_水流顯示器.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmb_水流水壓
            // 
            cmb_水流水壓.Items.AddRange(new object[] { "不提供", "提供 台製 壓力開關", "提供 SMC 壓力開關", "提供 台製 水流開關", "提供 SMC 流量計" });
            cmb_水流水壓.Location = new Point(592, 280);
            cmb_水流水壓.Name = "cmb_水流水壓";
            cmb_水流水壓.Size = new Size(304, 24);
            cmb_水流水壓.TabIndex = 34;
            // 
            // lbl_水流開關
            // 
            lbl_水流開關.ForeColor = Color.DimGray;
            lbl_水流開關.Location = new Point(463, 280);
            lbl_水流開關.Name = "lbl_水流開關";
            lbl_水流開關.Size = new Size(124, 23);
            lbl_水流開關.TabIndex = 35;
            lbl_水流開關.Text = "水流開關";
            lbl_水流開關.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmb_冰水機_熱交換器
            // 
            cmb_冰水機_熱交換器.Items.AddRange(new object[] { "不提供", "提供冰水機 三相", "提供熱交換器 單相" });
            cmb_冰水機_熱交換器.Location = new Point(1035, 280);
            cmb_冰水機_熱交換器.Name = "cmb_冰水機_熱交換器";
            cmb_冰水機_熱交換器.Size = new Size(303, 24);
            cmb_冰水機_熱交換器.TabIndex = 36;
            // 
            // lbl_冰水機熱交換器
            // 
            lbl_冰水機熱交換器.ForeColor = Color.DimGray;
            lbl_冰水機熱交換器.Location = new Point(907, 280);
            lbl_冰水機熱交換器.Name = "lbl_冰水機熱交換器";
            lbl_冰水機熱交換器.Size = new Size(124, 23);
            lbl_冰水機熱交換器.TabIndex = 37;
            lbl_冰水機熱交換器.Text = "冰水機/熱交換器";
            lbl_冰水機熱交換器.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmb_馬達
            // 
            cmb_馬達.Items.AddRange(new object[] { "伺服馬達", "交流馬達", "變頻馬達", "直流馬達", "無" });
            cmb_馬達.Location = new Point(591, 147);
            cmb_馬達.Name = "cmb_馬達";
            cmb_馬達.Size = new Size(156, 24);
            cmb_馬達.TabIndex = 38;
            // 
            // lbl_馬達
            // 
            lbl_馬達.ForeColor = Color.DimGray;
            lbl_馬達.Location = new Point(462, 147);
            lbl_馬達.Name = "lbl_馬達";
            lbl_馬達.Size = new Size(124, 23);
            lbl_馬達.TabIndex = 39;
            lbl_馬達.Text = "馬達";
            lbl_馬達.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmb_顏色
            // 
            cmb_顏色.Items.AddRange(new object[] { "灰色", "水藍色", "蘋果綠", "其他" });
            cmb_顏色.Location = new Point(1035, 306);
            cmb_顏色.Name = "cmb_顏色";
            cmb_顏色.Size = new Size(303, 24);
            cmb_顏色.TabIndex = 40;
            // 
            // lbl_顏色
            // 
            lbl_顏色.ForeColor = Color.DimGray;
            lbl_顏色.Location = new Point(907, 306);
            lbl_顏色.Name = "lbl_顏色";
            lbl_顏色.Size = new Size(38, 23);
            lbl_顏色.TabIndex = 41;
            lbl_顏色.Text = "顏色";
            lbl_顏色.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmb_啟動方式
            // 
            cmb_啟動方式.Items.AddRange(new object[] { "腳踏開關", "手動啟動", "外部訊號" });
            cmb_啟動方式.Location = new Point(139, 174);
            cmb_啟動方式.Name = "cmb_啟動方式";
            cmb_啟動方式.Size = new Size(156, 24);
            cmb_啟動方式.TabIndex = 42;
            // 
            // lbl_啟動方式
            // 
            lbl_啟動方式.ForeColor = Color.DimGray;
            lbl_啟動方式.Location = new Point(11, 174);
            lbl_啟動方式.Name = "lbl_啟動方式";
            lbl_啟動方式.Size = new Size(124, 23);
            lbl_啟動方式.TabIndex = 43;
            lbl_啟動方式.Text = "啟動方式";
            lbl_啟動方式.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmb_其他氣缸電磁閥
            // 
            cmb_其他氣缸電磁閥.Items.AddRange(new object[] { "無", "金器", "Fontal", "SMC", "Airtec", "FESTO" });
            cmb_其他氣缸電磁閥.Location = new Point(591, 174);
            cmb_其他氣缸電磁閥.Name = "cmb_其他氣缸電磁閥";
            cmb_其他氣缸電磁閥.Size = new Size(304, 24);
            cmb_其他氣缸電磁閥.TabIndex = 44;
            // 
            // lbl_氣缸電磁閥
            // 
            lbl_氣缸電磁閥.ForeColor = Color.DimGray;
            lbl_氣缸電磁閥.Location = new Point(462, 174);
            lbl_氣缸電磁閥.Name = "lbl_氣缸電磁閥";
            lbl_氣缸電磁閥.Size = new Size(124, 23);
            lbl_氣缸電磁閥.TabIndex = 45;
            lbl_氣缸電磁閥.Text = "氣缸電磁閥";
            lbl_氣缸電磁閥.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmb_其他氣缸
            // 
            cmb_其他氣缸.Items.AddRange(new object[] { "無", "金器", "SMC", "Airtec", "FESTO" });
            cmb_其他氣缸.Location = new Point(139, 147);
            cmb_其他氣缸.Name = "cmb_其他氣缸";
            cmb_其他氣缸.Size = new Size(311, 24);
            cmb_其他氣缸.TabIndex = 46;
            // 
            // lbl_氣缸
            // 
            lbl_氣缸.ForeColor = Color.DimGray;
            lbl_氣缸.Location = new Point(11, 147);
            lbl_氣缸.Name = "lbl_氣缸";
            lbl_氣缸.Size = new Size(124, 23);
            lbl_氣缸.TabIndex = 47;
            lbl_氣缸.Text = "氣缸";
            lbl_氣缸.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmb_風壓壓力開關
            // 
            cmb_風壓壓力開關.Items.AddRange(new object[] { "無", "金器", "SMC", "Airtec", "FESTO", "台灣" });
            cmb_風壓壓力開關.Location = new Point(139, 306);
            cmb_風壓壓力開關.Name = "cmb_風壓壓力開關";
            cmb_風壓壓力開關.Size = new Size(310, 24);
            cmb_風壓壓力開關.TabIndex = 48;
            // 
            // lbl_風壓壓力開關
            // 
            lbl_風壓壓力開關.ForeColor = Color.DimGray;
            lbl_風壓壓力開關.Location = new Point(11, 306);
            lbl_風壓壓力開關.Name = "lbl_風壓壓力開關";
            lbl_風壓壓力開關.Size = new Size(124, 23);
            lbl_風壓壓力開關.TabIndex = 49;
            lbl_風壓壓力開關.Text = "風壓壓力開關";
            lbl_風壓壓力開關.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmb_壓力比例閥
            // 
            cmb_壓力比例閥.Items.AddRange(new object[] { "無", "SMC", "FESTO" });
            cmb_壓力比例閥.Location = new Point(591, 306);
            cmb_壓力比例閥.Name = "cmb_壓力比例閥";
            cmb_壓力比例閥.Size = new Size(304, 24);
            cmb_壓力比例閥.TabIndex = 50;
            // 
            // lbl_壓力比例閥
            // 
            lbl_壓力比例閥.ForeColor = Color.DimGray;
            lbl_壓力比例閥.Location = new Point(462, 306);
            lbl_壓力比例閥.Name = "lbl_壓力比例閥";
            lbl_壓力比例閥.Size = new Size(124, 23);
            lbl_壓力比例閥.TabIndex = 51;
            lbl_壓力比例閥.Text = "壓力比例閥";
            lbl_壓力比例閥.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmb_氣壓配管
            // 
            cmb_氣壓配管.Items.AddRange(new object[] { "軟式", "硬式" });
            cmb_氣壓配管.Location = new Point(139, 332);
            cmb_氣壓配管.Name = "cmb_氣壓配管";
            cmb_氣壓配管.Size = new Size(310, 24);
            cmb_氣壓配管.TabIndex = 52;
            // 
            // lbl_氣壓配管
            // 
            lbl_氣壓配管.ForeColor = Color.DimGray;
            lbl_氣壓配管.Location = new Point(11, 332);
            lbl_氣壓配管.Name = "lbl_氣壓配管";
            lbl_氣壓配管.Size = new Size(124, 23);
            lbl_氣壓配管.TabIndex = 53;
            lbl_氣壓配管.Text = "氣壓配管";
            lbl_氣壓配管.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmb_空氣儲存桶
            // 
            cmb_空氣儲存桶.Items.AddRange(new object[] { "提供", "不提供" });
            cmb_空氣儲存桶.Location = new Point(589, 332);
            cmb_空氣儲存桶.Name = "cmb_空氣儲存桶";
            cmb_空氣儲存桶.Size = new Size(158, 24);
            cmb_空氣儲存桶.TabIndex = 54;
            // 
            // lbl_空氣儲存桶
            // 
            lbl_空氣儲存桶.ForeColor = Color.DimGray;
            lbl_空氣儲存桶.Location = new Point(462, 332);
            lbl_空氣儲存桶.Name = "lbl_空氣儲存桶";
            lbl_空氣儲存桶.Size = new Size(124, 23);
            lbl_空氣儲存桶.TabIndex = 55;
            lbl_空氣儲存桶.Text = "空氣儲存桶";
            lbl_空氣儲存桶.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmb_空氣儲存桶ps
            // 
            cmb_空氣儲存桶ps.Location = new Point(752, 332);
            cmb_空氣儲存桶ps.Name = "cmb_空氣儲存桶ps";
            cmb_空氣儲存桶ps.Size = new Size(143, 24);
            cmb_空氣儲存桶ps.TabIndex = 56;
            // 
            // cmb_啟動方式ps
            // 
            cmb_啟動方式ps.Location = new Point(299, 174);
            cmb_啟動方式ps.Name = "cmb_啟動方式ps";
            cmb_啟動方式ps.Size = new Size(150, 24);
            cmb_啟動方式ps.TabIndex = 57;
            // 
            // cmb_操作控制箱ps
            // 
            cmb_操作控制箱ps.Location = new Point(1191, 147);
            cmb_操作控制箱ps.Name = "cmb_操作控制箱ps";
            cmb_操作控制箱ps.Size = new Size(147, 24);
            cmb_操作控制箱ps.TabIndex = 58;
            // 
            // cmb_安全光照簾ps
            // 
            cmb_安全光照簾ps.Location = new Point(299, 227);
            cmb_安全光照簾ps.Name = "cmb_安全光照簾ps";
            cmb_安全光照簾ps.Size = new Size(151, 24);
            cmb_安全光照簾ps.TabIndex = 59;
            // 
            // cmb_無熔絲開關ps
            // 
            cmb_無熔絲開關ps.Location = new Point(752, 253);
            cmb_無熔絲開關ps.Name = "cmb_無熔絲開關ps";
            cmb_無熔絲開關ps.Size = new Size(143, 24);
            cmb_無熔絲開關ps.TabIndex = 60;
            // 
            // cmb_馬達ps
            // 
            cmb_馬達ps.Location = new Point(752, 147);
            cmb_馬達ps.Name = "cmb_馬達ps";
            cmb_馬達ps.Size = new Size(143, 24);
            cmb_馬達ps.TabIndex = 61;
            // 
            // cmb_三色燈ps
            // 
            cmb_三色燈ps.Location = new Point(1191, 253);
            cmb_三色燈ps.Name = "cmb_三色燈ps";
            cmb_三色燈ps.Size = new Size(148, 24);
            cmb_三色燈ps.TabIndex = 62;
            // 
            // cmb_人機介面
            // 
            cmb_人機介面.Items.AddRange(new object[] { "無", "普羅菲斯Proface", "威綸Wintek", "洛克威爾AB", "西門子Simense", "士林 10\" SMB", "三菱" });
            cmb_人機介面.Location = new Point(592, 200);
            cmb_人機介面.Name = "cmb_人機介面";
            cmb_人機介面.Size = new Size(158, 24);
            cmb_人機介面.TabIndex = 63;
            // 
            // lbl_人機介面
            // 
            lbl_人機介面.ForeColor = Color.DimGray;
            lbl_人機介面.Location = new Point(463, 200);
            lbl_人機介面.Name = "lbl_人機介面";
            lbl_人機介面.Size = new Size(124, 23);
            lbl_人機介面.TabIndex = 64;
            lbl_人機介面.Text = "人機介面";
            lbl_人機介面.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmb_人機介面ps
            // 
            cmb_人機介面ps.Items.AddRange(new object[] { "5.7吋", "7吋", "10吋", "12吋", "15吋" });
            cmb_人機介面ps.Location = new Point(753, 200);
            cmb_人機介面ps.Name = "cmb_人機介面ps";
            cmb_人機介面ps.Size = new Size(142, 24);
            cmb_人機介面ps.TabIndex = 65;
            // 
            // lbl_機構說明
            // 
            lbl_機構說明.ForeColor = Color.DimGray;
            lbl_機構說明.Location = new Point(11, 359);
            lbl_機構說明.Name = "lbl_機構說明";
            lbl_機構說明.Size = new Size(26, 227);
            lbl_機構說明.TabIndex = 66;
            lbl_機構說明.Text = "機構說明";
            lbl_機構說明.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_說明
            // 
            txt_說明.Location = new Point(42, 364);
            txt_說明.Multiline = true;
            txt_說明.Name = "txt_說明";
            txt_說明.Size = new Size(658, 212);
            txt_說明.TabIndex = 67;
            // 
            // lbl_電控元件說明
            // 
            lbl_電控元件說明.ForeColor = Color.DimGray;
            lbl_電控元件說明.Location = new Point(710, 359);
            lbl_電控元件說明.Name = "lbl_電控元件說明";
            lbl_電控元件說明.Size = new Size(26, 227);
            lbl_電控元件說明.TabIndex = 68;
            lbl_電控元件說明.Text = "電控元件說明";
            lbl_電控元件說明.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_備註
            // 
            txt_備註.Location = new Point(740, 359);
            txt_備註.Multiline = true;
            txt_備註.Name = "txt_備註";
            txt_備註.Size = new Size(598, 217);
            txt_備註.TabIndex = 69;
            // 
            // chk_結案
            // 
            chk_結案.Location = new Point(1290, 13);
            chk_結案.Name = "chk_結案";
            chk_結案.Size = new Size(20, 20);
            chk_結案.TabIndex = 70;
            // 
            // lbl_結案
            // 
            lbl_結案.ForeColor = Color.DimGray;
            lbl_結案.Location = new Point(1243, 8);
            lbl_結案.Name = "lbl_結案";
            lbl_結案.Size = new Size(44, 23);
            lbl_結案.TabIndex = 71;
            lbl_結案.Text = "結案";
            lbl_結案.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_國家地區
            // 
            lbl_國家地區.ForeColor = Color.DimGray;
            lbl_國家地區.Location = new Point(1073, 8);
            lbl_國家地區.Name = "lbl_國家地區";
            lbl_國家地區.Size = new Size(68, 24);
            lbl_國家地區.TabIndex = 72;
            lbl_國家地區.Text = "國家地區";
            lbl_國家地區.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_國家地區
            // 
            txt_國家地區.Location = new Point(1146, 8);
            txt_國家地區.Name = "txt_國家地區";
            txt_國家地區.Size = new Size(93, 23);
            txt_國家地區.TabIndex = 73;
            // 
            // lbl_客戶
            // 
            lbl_客戶.ForeColor = Color.DimGray;
            lbl_客戶.Location = new Point(703, 8);
            lbl_客戶.Name = "lbl_客戶";
            lbl_客戶.Size = new Size(41, 24);
            lbl_客戶.TabIndex = 74;
            lbl_客戶.Text = "客戶";
            lbl_客戶.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_客戶名稱
            // 
            txt_客戶名稱.Location = new Point(748, 8);
            txt_客戶名稱.Name = "txt_客戶名稱";
            txt_客戶名稱.Size = new Size(321, 23);
            txt_客戶名稱.TabIndex = 75;
            // 
            // lbl_客戶簡稱
            // 
            lbl_客戶簡稱.ForeColor = Color.DimGray;
            lbl_客戶簡稱.Location = new Point(537, 8);
            lbl_客戶簡稱.Name = "lbl_客戶簡稱";
            lbl_客戶簡稱.Size = new Size(72, 24);
            lbl_客戶簡稱.TabIndex = 76;
            lbl_客戶簡稱.Text = "客戶簡稱";
            lbl_客戶簡稱.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_客戶簡稱
            // 
            txt_客戶簡稱.Location = new Point(612, 8);
            txt_客戶簡稱.Name = "txt_客戶簡稱";
            txt_客戶簡稱.Size = new Size(88, 23);
            txt_客戶簡稱.TabIndex = 77;
            // 
            // cmb_焊接控制器Y13
            // 
            cmb_焊接控制器Y13.Items.AddRange(new object[] { "不指定", "客戶指定" });
            cmb_焊接控制器Y13.Location = new Point(949, 306);
            cmb_焊接控制器Y13.Name = "cmb_焊接控制器Y13";
            cmb_焊接控制器Y13.Size = new Size(83, 24);
            cmb_焊接控制器Y13.TabIndex = 78;
            // 
            // lbl_驗機日期
            // 
            lbl_驗機日期.ForeColor = Color.DimGray;
            lbl_驗機日期.Location = new Point(987, 35);
            lbl_驗機日期.Name = "lbl_驗機日期";
            lbl_驗機日期.Size = new Size(72, 23);
            lbl_驗機日期.TabIndex = 79;
            lbl_驗機日期.Text = "驗機日期";
            lbl_驗機日期.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_驗機日期
            // 
            txt_驗機日期.Location = new Point(1062, 35);
            txt_驗機日期.Name = "txt_驗機日期";
            txt_驗機日期.Size = new Size(245, 23);
            txt_驗機日期.TabIndex = 80;
            // 
            // lbl_交貨日期
            // 
            lbl_交貨日期.ForeColor = Color.DimGray;
            lbl_交貨日期.Location = new Point(987, 90);
            lbl_交貨日期.Name = "lbl_交貨日期";
            lbl_交貨日期.Size = new Size(72, 23);
            lbl_交貨日期.TabIndex = 81;
            lbl_交貨日期.Text = "交貨日期";
            lbl_交貨日期.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_交貨日期
            // 
            txt_交貨日期.Location = new Point(1062, 90);
            txt_交貨日期.Name = "txt_交貨日期";
            txt_交貨日期.Size = new Size(245, 23);
            txt_交貨日期.TabIndex = 82;
            // 
            // cmb_廠驗
            // 
            cmb_廠驗.Items.AddRange(new object[] { "到廠", "不到廠" });
            cmb_廠驗.Location = new Point(1062, 63);
            cmb_廠驗.Name = "cmb_廠驗";
            cmb_廠驗.Size = new Size(245, 24);
            cmb_廠驗.TabIndex = 83;
            // 
            // cmb_裝機
            // 
            cmb_裝機.Items.AddRange(new object[] { "前往", "不需前往" });
            cmb_裝機.Location = new Point(1062, 119);
            cmb_裝機.Name = "cmb_裝機";
            cmb_裝機.Size = new Size(245, 24);
            cmb_裝機.TabIndex = 84;
            // 
            // cmb_電流
            // 
            cmb_電流.Items.AddRange(new object[] { "交流", "變頻直流", "整流式直流" });
            cmb_電流.Location = new Point(381, 34);
            cmb_電流.Name = "cmb_電流";
            cmb_電流.Size = new Size(236, 24);
            cmb_電流.TabIndex = 85;
            // 
            // cmb_焊接電壓v
            // 
            cmb_焊接電壓v.Items.AddRange(new object[] { "220V", "380V", "415V", "440V", "480V" });
            cmb_焊接電壓v.Location = new Point(381, 62);
            cmb_焊接電壓v.Name = "cmb_焊接電壓v";
            cmb_焊接電壓v.Size = new Size(73, 24);
            cmb_焊接電壓v.TabIndex = 86;
            // 
            // cmb_焊接物
            // 
            cmb_焊接物.Items.AddRange(new object[] { "220V", "DC24" });
            cmb_焊接物.Location = new Point(381, 90);
            cmb_焊接物.Name = "cmb_焊接物";
            cmb_焊接物.Size = new Size(235, 24);
            cmb_焊接物.TabIndex = 87;
            // 
            // cmb_圖面設計
            // 
            cmb_圖面設計.Items.AddRange(new object[] { "需要", "不需要" });
            cmb_圖面設計.Location = new Point(722, 35);
            cmb_圖面設計.Name = "cmb_圖面設計";
            cmb_圖面設計.Size = new Size(235, 24);
            cmb_圖面設計.TabIndex = 88;
            // 
            // cmb_安規要求
            // 
            cmb_安規要求.Items.AddRange(new object[] { "CE 安規", "UL 規格", "Tenneco 規格", "無" });
            cmb_安規要求.Location = new Point(722, 63);
            cmb_安規要求.Name = "cmb_安規要求";
            cmb_安規要求.Size = new Size(235, 24);
            cmb_安規要求.TabIndex = 89;
            // 
            // txt_生產速率
            // 
            txt_生產速率.Location = new Point(722, 90);
            txt_生產速率.Name = "txt_生產速率";
            txt_生產速率.Size = new Size(235, 23);
            txt_生產速率.TabIndex = 90;
            // 
            // lbl_廠驗
            // 
            lbl_廠驗.ForeColor = Color.DimGray;
            lbl_廠驗.Location = new Point(987, 63);
            lbl_廠驗.Name = "lbl_廠驗";
            lbl_廠驗.Size = new Size(72, 23);
            lbl_廠驗.TabIndex = 91;
            lbl_廠驗.Text = "廠驗";
            lbl_廠驗.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_裝機
            // 
            lbl_裝機.ForeColor = Color.DimGray;
            lbl_裝機.Location = new Point(987, 119);
            lbl_裝機.Name = "lbl_裝機";
            lbl_裝機.Size = new Size(72, 23);
            lbl_裝機.TabIndex = 92;
            lbl_裝機.Text = "裝機";
            lbl_裝機.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_電流
            // 
            lbl_電流.ForeColor = Color.DimGray;
            lbl_電流.Location = new Point(307, 34);
            lbl_電流.Name = "lbl_電流";
            lbl_電流.Size = new Size(72, 23);
            lbl_電流.TabIndex = 93;
            lbl_電流.Text = "電流";
            lbl_電流.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_入力電壓
            // 
            lbl_入力電壓.ForeColor = Color.DimGray;
            lbl_入力電壓.Location = new Point(307, 62);
            lbl_入力電壓.Name = "lbl_入力電壓";
            lbl_入力電壓.Size = new Size(72, 23);
            lbl_入力電壓.TabIndex = 94;
            lbl_入力電壓.Text = "入力電壓";
            lbl_入力電壓.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_控制電壓
            // 
            lbl_控制電壓.ForeColor = Color.DimGray;
            lbl_控制電壓.Location = new Point(307, 90);
            lbl_控制電壓.Name = "lbl_控制電壓";
            lbl_控制電壓.Size = new Size(71, 23);
            lbl_控制電壓.TabIndex = 95;
            lbl_控制電壓.Text = "控制電壓";
            lbl_控制電壓.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_審圖需求
            // 
            lbl_審圖需求.ForeColor = Color.DimGray;
            lbl_審圖需求.Location = new Point(647, 35);
            lbl_審圖需求.Name = "lbl_審圖需求";
            lbl_審圖需求.Size = new Size(71, 23);
            lbl_審圖需求.TabIndex = 96;
            lbl_審圖需求.Text = "審圖需求";
            lbl_審圖需求.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_安規要求
            // 
            lbl_安規要求.ForeColor = Color.DimGray;
            lbl_安規要求.Location = new Point(647, 63);
            lbl_安規要求.Name = "lbl_安規要求";
            lbl_安規要求.Size = new Size(71, 23);
            lbl_安規要求.TabIndex = 97;
            lbl_安規要求.Text = "安規要求";
            lbl_安規要求.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_生產速率
            // 
            lbl_生產速率.ForeColor = Color.DimGray;
            lbl_生產速率.Location = new Point(647, 90);
            lbl_生產速率.Name = "lbl_生產速率";
            lbl_生產速率.Size = new Size(71, 23);
            lbl_生產速率.TabIndex = 98;
            lbl_生產速率.Text = "生產速率";
            lbl_生產速率.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmb_焊接電壓hz
            // 
            cmb_焊接電壓hz.Items.AddRange(new object[] { "50Hz", "60Hz" });
            cmb_焊接電壓hz.Location = new Point(458, 62);
            cmb_焊接電壓hz.Name = "cmb_焊接電壓hz";
            cmb_焊接電壓hz.Size = new Size(73, 24);
            cmb_焊接電壓hz.TabIndex = 99;
            // 
            // cmb_焊接電壓
            // 
            cmb_焊接電壓.Items.AddRange(new object[] { "PNP", "NPN" });
            cmb_焊接電壓.Location = new Point(533, 62);
            cmb_焊接電壓.Name = "cmb_焊接電壓";
            cmb_焊接電壓.Size = new Size(85, 24);
            cmb_焊接電壓.TabIndex = 100;
            // 
            // txtOrphan_PLCTYPE
            // 
            txtOrphan_PLCTYPE.Location = new Point(299, 200);
            txtOrphan_PLCTYPE.Name = "txtOrphan_PLCTYPE";
            txtOrphan_PLCTYPE.Size = new Size(151, 23);
            txtOrphan_PLCTYPE.TabIndex = 101;
            // 
            // panelFooter
            // 
            panelFooter.BackColor = Color.FromArgb(252, 230, 212);
            panelFooter.Controls.Add(lblF_核准人員);
            panelFooter.Controls.Add(txtF_核准);
            panelFooter.Controls.Add(lblF_修改人員);
            panelFooter.Controls.Add(txtF_修改);
            panelFooter.Controls.Add(lblF_建檔人員);
            panelFooter.Controls.Add(txtF_建檔);
            panelFooter.Controls.Add(txtF_核准日);
            panelFooter.Controls.Add(txtF_修改日);
            panelFooter.Controls.Add(txtF_建檔日);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 644);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(1360, 34);
            panelFooter.TabIndex = 2;
            // 
            // lblF_核准人員
            // 
            lblF_核准人員.Location = new Point(38, 4);
            lblF_核准人員.Name = "lblF_核准人員";
            lblF_核准人員.Size = new Size(72, 24);
            lblF_核准人員.TabIndex = 0;
            lblF_核准人員.Text = "核准人員";
            lblF_核准人員.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtF_核准
            // 
            txtF_核准.BackColor = Color.FromArgb(252, 230, 212);
            txtF_核准.BorderStyle = BorderStyle.None;
            txtF_核准.Location = new Point(113, 4);
            txtF_核准.Name = "txtF_核准";
            txtF_核准.ReadOnly = true;
            txtF_核准.Size = new Size(95, 16);
            txtF_核准.TabIndex = 1;
            // 
            // lblF_修改人員
            // 
            lblF_修改人員.Location = new Point(446, 4);
            lblF_修改人員.Name = "lblF_修改人員";
            lblF_修改人員.Size = new Size(72, 24);
            lblF_修改人員.TabIndex = 2;
            lblF_修改人員.Text = "修改人員";
            lblF_修改人員.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtF_修改
            // 
            txtF_修改.BackColor = Color.FromArgb(252, 230, 212);
            txtF_修改.BorderStyle = BorderStyle.None;
            txtF_修改.Location = new Point(521, 4);
            txtF_修改.Name = "txtF_修改";
            txtF_修改.ReadOnly = true;
            txtF_修改.Size = new Size(95, 16);
            txtF_修改.TabIndex = 3;
            // 
            // lblF_建檔人員
            // 
            lblF_建檔人員.Location = new Point(842, 4);
            lblF_建檔人員.Name = "lblF_建檔人員";
            lblF_建檔人員.Size = new Size(72, 24);
            lblF_建檔人員.TabIndex = 4;
            lblF_建檔人員.Text = "建檔人員";
            lblF_建檔人員.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtF_建檔
            // 
            txtF_建檔.BackColor = Color.FromArgb(252, 230, 212);
            txtF_建檔.BorderStyle = BorderStyle.None;
            txtF_建檔.Location = new Point(917, 4);
            txtF_建檔.Name = "txtF_建檔";
            txtF_建檔.ReadOnly = true;
            txtF_建檔.Size = new Size(95, 16);
            txtF_建檔.TabIndex = 5;
            // 
            // txtF_核准日
            // 
            txtF_核准日.BackColor = Color.FromArgb(252, 230, 212);
            txtF_核准日.BorderStyle = BorderStyle.None;
            txtF_核准日.Location = new Point(212, 4);
            txtF_核准日.Name = "txtF_核准日";
            txtF_核准日.ReadOnly = true;
            txtF_核准日.Size = new Size(166, 16);
            txtF_核准日.TabIndex = 6;
            // 
            // txtF_修改日
            // 
            txtF_修改日.BackColor = Color.FromArgb(252, 230, 212);
            txtF_修改日.BorderStyle = BorderStyle.None;
            txtF_修改日.Location = new Point(619, 4);
            txtF_修改日.Name = "txtF_修改日";
            txtF_修改日.ReadOnly = true;
            txtF_修改日.Size = new Size(166, 16);
            txtF_修改日.TabIndex = 7;
            // 
            // txtF_建檔日
            // 
            txtF_建檔日.BackColor = Color.FromArgb(252, 230, 212);
            txtF_建檔日.BorderStyle = BorderStyle.None;
            txtF_建檔日.Location = new Point(1016, 4);
            txtF_建檔日.Name = "txtF_建檔日";
            txtF_建檔日.ReadOnly = true;
            txtF_建檔日.Size = new Size(166, 16);
            txtF_建檔日.TabIndex = 8;
            // 
            // WorkOrderControl
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelBody);
            Controls.Add(panelFooter);
            Controls.Add(panelHeader);
            Font = new Font("微軟正黑體", 9F);
            Margin = new Padding(4);
            Name = "WorkOrderControl";
            Size = new Size(1360, 678);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelBody.ResumeLayout(false);
            panelBody.PerformLayout();
            panelFooter.ResumeLayout(false);
            panelFooter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private PictureBox pictureBox1;
        private Label lblTitle;
        private Button btnProductSpec;
        private Button btnEngAnalysis;
        private Button btnMeetingLog;
        private Button btnEdit;
        private Button btnSave;
        private Button btnApprove;
        private Button btnUnapprove;
        private Button btnPrint;
        private Button btnBackToList;
        private Button btnExit;
        private Panel panelBody;
                private Label lbl_專案序號;
                private TextBox txt_專案序號;
                private Label lbl_訂單日期;
                private TextBox txt_訂單日期;
                private Label lbl_參考序號;
                private TextBox txt_參考序號;
                private Label lbl_機台型號;
                private TextBox txt_機台型號;
                private Label lbl_機台類型;
                private ComboBox cmb_機台類型;
                private Label lbl_機台名稱;
                private TextBox txt_機台名稱;
                private ComboBox cmb_操作控制箱;
                private Label lbl_操作控制箱;
                private ComboBox cmb_三點組合;
                private Label lbl_三點組合;
                private ComboBox cmb_PLC控制器;
                private Label lbl_PLC控制器;
                private ComboBox cmb_入力線方向;
                private Label lbl_入力線方向;
                private ComboBox cmb_安全光照簾;
                private Label lbl_安全光照簾;
                private ComboBox cmb_安全柵欄;
                private Label lbl_安全柵欄;
                private ComboBox cmb_安全門火花檔板;
                private Label lbl_安全門火花擋板;
                private ComboBox cmb_蜂鳴器;
                private Label lbl_蜂鳴器;
                private ComboBox cmb_無熔絲開關;
                private Label lbl_無熔絲開關;
                private ComboBox cmb_三色燈;
                private Label lbl_三色燈;
                private ComboBox cmb_水流浮球;
                private Label lbl_水流顯示器;
                private ComboBox cmb_水流水壓;
                private Label lbl_水流開關;
                private ComboBox cmb_冰水機_熱交換器;
                private Label lbl_冰水機熱交換器;
                private ComboBox cmb_馬達;
                private Label lbl_馬達;
                private ComboBox cmb_顏色;
                private Label lbl_顏色;
                private ComboBox cmb_啟動方式;
                private Label lbl_啟動方式;
                private ComboBox cmb_其他氣缸電磁閥;
                private Label lbl_氣缸電磁閥;
                private ComboBox cmb_其他氣缸;
                private Label lbl_氣缸;
                private ComboBox cmb_風壓壓力開關;
                private Label lbl_風壓壓力開關;
                private ComboBox cmb_壓力比例閥;
                private Label lbl_壓力比例閥;
                private ComboBox cmb_氣壓配管;
                private Label lbl_氣壓配管;
                private ComboBox cmb_空氣儲存桶;
                private Label lbl_空氣儲存桶;
                private ComboBox cmb_空氣儲存桶ps;
                private ComboBox cmb_啟動方式ps;
                private ComboBox cmb_操作控制箱ps;
                private ComboBox cmb_安全光照簾ps;
                private ComboBox cmb_無熔絲開關ps;
                private ComboBox cmb_馬達ps;
                private ComboBox cmb_三色燈ps;
                private ComboBox cmb_人機介面;
                private Label lbl_人機介面;
                private ComboBox cmb_人機介面ps;
                private Label lbl_機構說明;
                private TextBox txt_說明;
                private Label lbl_電控元件說明;
                private TextBox txt_備註;
                private CheckBox chk_結案;
                private Label lbl_結案;
                private Label lbl_國家地區;
                private TextBox txt_國家地區;
                private Label lbl_客戶;
                private TextBox txt_客戶名稱;
                private Label lbl_客戶簡稱;
                private TextBox txt_客戶簡稱;
                private ComboBox cmb_焊接控制器Y13;
                private Label lbl_驗機日期;
                private TextBox txt_驗機日期;
                private Label lbl_交貨日期;
                private TextBox txt_交貨日期;
                private ComboBox cmb_廠驗;
                private ComboBox cmb_裝機;
                private ComboBox cmb_電流;
                private ComboBox cmb_焊接電壓v;
                private ComboBox cmb_焊接物;
                private ComboBox cmb_圖面設計;
                private ComboBox cmb_安規要求;
                private TextBox txt_生產速率;
                private Label lbl_廠驗;
                private Label lbl_裝機;
                private Label lbl_電流;
                private Label lbl_入力電壓;
                private Label lbl_控制電壓;
                private Label lbl_審圖需求;
                private Label lbl_安規要求;
                private Label lbl_生產速率;
                private ComboBox cmb_焊接電壓hz;
                private ComboBox cmb_焊接電壓;
                private TextBox txtOrphan_PLCTYPE; // 原Access欄位PLCTYPE，CHINYO資料庫無對應欄位，僅保留版面、不綁定資料
        private Panel panelFooter;
                private Label lblF_核准人員;
                private TextBox txtF_核准;
                private Label lblF_修改人員;
                private TextBox txtF_修改;
                private Label lblF_建檔人員;
                private TextBox txtF_建檔;
                private TextBox txtF_核准日;
                private TextBox txtF_修改日;
                private TextBox txtF_建檔日;
    }
}
