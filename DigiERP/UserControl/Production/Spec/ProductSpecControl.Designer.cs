using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.Production.Spec
{
    partial class ProductSpecControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼
        //
        // 版面完全比照 PITS-2025.accdb「P-規格」表單之控制項座標(twips/15=px)還原：
        // 表單首(按鈕列+提示訊息)、詳細資料(工令單唯讀參考欄位+產品規格單可編輯
        // 欄位)、表單尾(核准/修改/建檔簽核列)。
        //
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductSpecControl));
            panelHeader = new Panel();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            lblHint = new Label();
            btnClose2 = new Button();
            btnReopen = new Button();
            btnEdit = new Button();
            btnSave = new Button();
            btnApprove = new Button();
            btnUnapprove = new Button();
            btnPrint = new Button();
            btnOverview = new Button();
            btnExit = new Button();
            panelBody = new Panel();
            lbl_專案負責人 = new Label();
            cmb_專案負責人 = new ComboBox();
            lbl_機台重點 = new Label();
            txt_客戶需求陳述 = new TextBox();
            lbl_驗收物件規格 = new Label();
            txt_驗收物件規格 = new TextBox();
            lbl_設計參考及機構說明 = new Label();
            txt_驗收基本要求1 = new TextBox();
            lbl_機台能力區間 = new Label();
            txt_機台最大及最小能力 = new TextBox();
            lbl_出貨相關要求 = new Label();
            txt_補充說明 = new TextBox();
            txt_機台動作規劃1 = new TextBox();
            cmb_MQC_油壓委外單元 = new ComboBox();
            cmb_MQC_自動化程控 = new ComboBox();
            cmb_MQC_變壓器 = new ComboBox();
            cmb_FQC_製成參數 = new ComboBox();
            cmb_OQC_出機檢查 = new ComboBox();
            lbl_電控與程控注意事項 = new Label();
            lbl_MQC油壓單元 = new Label();
            lbl_MQC程控系統 = new Label();
            lbl_FQC製成參數 = new Label();
            lbl_MQC變壓器 = new Label();
            lbl_OQC出機檢查 = new Label();
            lbl_流程路徑圖 = new Label();
            lbl_專案序號 = new Label();
            txt_專案序號 = new TextBox();
            lbl_參考序號 = new Label();
            txt_參考序號 = new TextBox();
            lbl_機台型號 = new Label();
            txt_機台型號 = new TextBox();
            lbl_機台名稱 = new Label();
            txt_機台名稱 = new TextBox();
            lbl_驗機日期 = new Label();
            txt_驗機日期 = new TextBox();
            lbl_交貨日期 = new Label();
            txt_交貨日期 = new TextBox();
            txt_生產速率 = new TextBox();
            lbl_廠驗 = new Label();
            lbl_裝機 = new Label();
            lbl_電流 = new Label();
            lbl_焊接電壓 = new Label();
            lbl_審圖需求 = new Label();
            lbl_安規要求 = new Label();
            lbl_生產速率 = new Label();
            txt_廠驗 = new TextBox();
            txt_裝機 = new TextBox();
            txt_圖面設計 = new TextBox();
            txt_安規要求 = new TextBox();
            txt_電流 = new TextBox();
            txt_焊接電壓 = new TextBox();
            txt_焊接物 = new TextBox();
            lbl_機台類型 = new Label();
            txt_機台類型 = new TextBox();
            txt_驗收規範說明1 = new TextBox();
            txt_驗收規範說明2 = new TextBox();
            txt_驗收規範說明3 = new TextBox();
            txt_驗收規範說明4 = new TextBox();
            txt_驗收規範說明5 = new TextBox();
            txt_驗收規範說明6 = new TextBox();
            chk_結案 = new CheckBox();
            lbl_結案 = new Label();
            lbl_訂單日期 = new Label();
            txt_訂單日期 = new TextBox();
            lbl_國家地區 = new Label();
            txt_國家地區 = new TextBox();
            lbl_客戶 = new Label();
            txt_客戶名稱 = new TextBox();
            lbl_客戶簡稱 = new Label();
            txt_客戶簡稱 = new TextBox();
            txt_焊接電壓v = new TextBox();
            txt_焊接電壓hz = new TextBox();
            txt_流程路徑圖 = new TextBox();
            txt_驗收規範項目3 = new TextBox();
            txt_驗收規範項目4 = new TextBox();
            txt_驗收規範項目5 = new TextBox();
            txt_驗收規範項目6 = new TextBox();
            lbl_機台驗收規範 = new Label();
            lbl_機台驗收規範2 = new Label();
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
            lbl_控制電壓 = new Label();
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
            panelHeader.Controls.Add(lblHint);
            panelHeader.Controls.Add(btnClose2);
            panelHeader.Controls.Add(btnReopen);
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
            panelHeader.Size = new Size(1419, 60);
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
            lblTitle.Text = "產品規格單";
            // 
            // lblHint
            // 
            lblHint.Font = new Font("微軟正黑體", 8F, FontStyle.Bold);
            lblHint.ForeColor = Color.Firebrick;
            lblHint.Location = new Point(234, 12);
            lblHint.Name = "lblHint";
            lblHint.Size = new Size(305, 23);
            lblHint.TabIndex = 2;
            lblHint.Text = "※此表單按生效後，才會進行電控派案喔！";
            // 
            // btnClose2
            // 
            btnClose2.BackColor = Color.Firebrick;
            btnClose2.FlatStyle = FlatStyle.Flat;
            btnClose2.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnClose2.ForeColor = Color.White;
            btnClose2.Location = new Point(654, 7);
            btnClose2.Name = "btnClose2";
            btnClose2.Size = new Size(49, 27);
            btnClose2.TabIndex = 4;
            btnClose2.Tag = "btn-modify";
            btnClose2.Text = "結案";
            btnClose2.UseVisualStyleBackColor = false;
            btnClose2.Click += btnClose2_Click;
            // 
            // btnReopen
            // 
            btnReopen.BackColor = Color.Firebrick;
            btnReopen.FlatStyle = FlatStyle.Flat;
            btnReopen.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnReopen.ForeColor = Color.White;
            btnReopen.Location = new Point(563, 7);
            btnReopen.Name = "btnReopen";
            btnReopen.Size = new Size(68, 27);
            btnReopen.TabIndex = 3;
            btnReopen.Tag = "btn-modify";
            btnReopen.Text = "取消結案";
            btnReopen.UseVisualStyleBackColor = false;
            btnReopen.Click += btnReopen_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.SteelBlue;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(763, 8);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(49, 27);
            btnEdit.TabIndex = 5;
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
            btnSave.Location = new Point(839, 8);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(49, 27);
            btnSave.TabIndex = 6;
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
            btnApprove.Location = new Point(914, 8);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(49, 27);
            btnApprove.TabIndex = 7;
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
            btnUnapprove.Location = new Point(989, 8);
            btnUnapprove.Name = "btnUnapprove";
            btnUnapprove.Size = new Size(69, 27);
            btnUnapprove.TabIndex = 8;
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
            btnPrint.Location = new Point(1160, 8);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(49, 27);
            btnPrint.TabIndex = 10;
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
            btnOverview.Location = new Point(1085, 8);
            btnOverview.Name = "btnOverview";
            btnOverview.Size = new Size(65, 27);
            btnOverview.TabIndex = 9;
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
            btnExit.Location = new Point(1235, 8);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(49, 27);
            btnExit.TabIndex = 11;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // panelBody
            // 
            panelBody.AutoScroll = true;
            panelBody.BackColor = Color.White;
            panelBody.Controls.Add(lbl_專案負責人);
            panelBody.Controls.Add(cmb_專案負責人);
            panelBody.Controls.Add(lbl_機台重點);
            panelBody.Controls.Add(txt_客戶需求陳述);
            panelBody.Controls.Add(lbl_驗收物件規格);
            panelBody.Controls.Add(txt_驗收物件規格);
            panelBody.Controls.Add(lbl_設計參考及機構說明);
            panelBody.Controls.Add(txt_驗收基本要求1);
            panelBody.Controls.Add(lbl_機台能力區間);
            panelBody.Controls.Add(txt_機台最大及最小能力);
            panelBody.Controls.Add(lbl_出貨相關要求);
            panelBody.Controls.Add(txt_補充說明);
            panelBody.Controls.Add(txt_機台動作規劃1);
            panelBody.Controls.Add(cmb_MQC_油壓委外單元);
            panelBody.Controls.Add(cmb_MQC_自動化程控);
            panelBody.Controls.Add(cmb_MQC_變壓器);
            panelBody.Controls.Add(cmb_FQC_製成參數);
            panelBody.Controls.Add(cmb_OQC_出機檢查);
            panelBody.Controls.Add(lbl_電控與程控注意事項);
            panelBody.Controls.Add(lbl_MQC油壓單元);
            panelBody.Controls.Add(lbl_MQC程控系統);
            panelBody.Controls.Add(lbl_FQC製成參數);
            panelBody.Controls.Add(lbl_MQC變壓器);
            panelBody.Controls.Add(lbl_OQC出機檢查);
            panelBody.Controls.Add(lbl_流程路徑圖);
            panelBody.Controls.Add(lbl_專案序號);
            panelBody.Controls.Add(txt_專案序號);
            panelBody.Controls.Add(lbl_參考序號);
            panelBody.Controls.Add(txt_參考序號);
            panelBody.Controls.Add(lbl_機台型號);
            panelBody.Controls.Add(txt_機台型號);
            panelBody.Controls.Add(lbl_機台名稱);
            panelBody.Controls.Add(txt_機台名稱);
            panelBody.Controls.Add(lbl_驗機日期);
            panelBody.Controls.Add(txt_驗機日期);
            panelBody.Controls.Add(lbl_交貨日期);
            panelBody.Controls.Add(txt_交貨日期);
            panelBody.Controls.Add(txt_生產速率);
            panelBody.Controls.Add(lbl_廠驗);
            panelBody.Controls.Add(lbl_裝機);
            panelBody.Controls.Add(lbl_電流);
            panelBody.Controls.Add(lbl_焊接電壓);
            panelBody.Controls.Add(lbl_控制電壓);
            panelBody.Controls.Add(lbl_審圖需求);
            panelBody.Controls.Add(lbl_安規要求);
            panelBody.Controls.Add(lbl_生產速率);
            panelBody.Controls.Add(txt_廠驗);
            panelBody.Controls.Add(txt_裝機);
            panelBody.Controls.Add(txt_圖面設計);
            panelBody.Controls.Add(txt_安規要求);
            panelBody.Controls.Add(txt_電流);
            panelBody.Controls.Add(txt_焊接電壓);
            panelBody.Controls.Add(txt_焊接物);
            panelBody.Controls.Add(lbl_機台類型);
            panelBody.Controls.Add(txt_機台類型);
            panelBody.Controls.Add(txt_驗收規範說明1);
            panelBody.Controls.Add(txt_驗收規範說明2);
            panelBody.Controls.Add(txt_驗收規範說明3);
            panelBody.Controls.Add(txt_驗收規範說明4);
            panelBody.Controls.Add(txt_驗收規範說明5);
            panelBody.Controls.Add(txt_驗收規範說明6);
            panelBody.Controls.Add(chk_結案);
            panelBody.Controls.Add(lbl_結案);
            panelBody.Controls.Add(lbl_訂單日期);
            panelBody.Controls.Add(txt_訂單日期);
            panelBody.Controls.Add(lbl_國家地區);
            panelBody.Controls.Add(txt_國家地區);
            panelBody.Controls.Add(lbl_客戶);
            panelBody.Controls.Add(txt_客戶名稱);
            panelBody.Controls.Add(lbl_客戶簡稱);
            panelBody.Controls.Add(txt_客戶簡稱);
            panelBody.Controls.Add(txt_焊接電壓v);
            panelBody.Controls.Add(txt_焊接電壓hz);
            panelBody.Controls.Add(txt_流程路徑圖);
            panelBody.Controls.Add(txt_驗收規範項目3);
            panelBody.Controls.Add(txt_驗收規範項目4);
            panelBody.Controls.Add(txt_驗收規範項目5);
            panelBody.Controls.Add(txt_驗收規範項目6);
            panelBody.Controls.Add(lbl_機台驗收規範);
            panelBody.Controls.Add(lbl_機台驗收規範2);
            panelBody.Dock = DockStyle.Fill;
            panelBody.Location = new Point(0, 60);
            panelBody.Name = "panelBody";
            panelBody.Size = new Size(1419, 744);
            panelBody.TabIndex = 1;
            // 
            // lbl_專案負責人
            // 
            lbl_專案負責人.ForeColor = Color.DimGray;
            lbl_專案負責人.Location = new Point(12, 143);
            lbl_專案負責人.Name = "lbl_專案負責人";
            lbl_專案負責人.Size = new Size(68, 23);
            lbl_專案負責人.TabIndex = 0;
            lbl_專案負責人.Text = "專案負責人";
            lbl_專案負責人.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmb_專案負責人
            // 
            cmb_專案負責人.Location = new Point(129, 143);
            cmb_專案負責人.Name = "cmb_專案負責人";
            cmb_專案負責人.Size = new Size(166, 24);
            cmb_專案負責人.TabIndex = 1;
            cmb_專案負責人.DropDown += cmb_專案負責人_DropDown;
            // 
            // lbl_機台重點
            // 
            lbl_機台重點.ForeColor = Color.DimGray;
            lbl_機台重點.Location = new Point(11, 173);
            lbl_機台重點.Name = "lbl_機台重點";
            lbl_機台重點.Size = new Size(69, 23);
            lbl_機台重點.TabIndex = 2;
            lbl_機台重點.Text = "機台重點";
            lbl_機台重點.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_客戶需求陳述
            // 
            txt_客戶需求陳述.Location = new Point(128, 173);
            txt_客戶需求陳述.Name = "txt_客戶需求陳述";
            txt_客戶需求陳述.Size = new Size(1179, 23);
            txt_客戶需求陳述.TabIndex = 3;
            // 
            // lbl_驗收物件規格
            // 
            lbl_驗收物件規格.ForeColor = Color.DimGray;
            lbl_驗收物件規格.Location = new Point(11, 204);
            lbl_驗收物件規格.Name = "lbl_驗收物件規格";
            lbl_驗收物件規格.Size = new Size(85, 23);
            lbl_驗收物件規格.TabIndex = 4;
            lbl_驗收物件規格.Text = "驗收物件規格";
            lbl_驗收物件規格.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_驗收物件規格
            // 
            txt_驗收物件規格.Location = new Point(128, 204);
            txt_驗收物件規格.Name = "txt_驗收物件規格";
            txt_驗收物件規格.Size = new Size(1180, 23);
            txt_驗收物件規格.TabIndex = 5;
            // 
            // lbl_設計參考及機構說明
            // 
            lbl_設計參考及機構說明.ForeColor = Color.DimGray;
            lbl_設計參考及機構說明.Location = new Point(11, 296);
            lbl_設計參考及機構說明.Name = "lbl_設計參考及機構說明";
            lbl_設計參考及機構說明.Size = new Size(26, 279);
            lbl_設計參考及機構說明.TabIndex = 6;
            lbl_設計參考及機構說明.Text = "　　設計參考及機構說明";
            lbl_設計參考及機構說明.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_驗收基本要求1
            // 
            txt_驗收基本要求1.Location = new Point(45, 296);
            txt_驗收基本要求1.Multiline = true;
            txt_驗收基本要求1.Name = "txt_驗收基本要求1";
            txt_驗收基本要求1.Size = new Size(602, 252);
            txt_驗收基本要求1.TabIndex = 7;
            // 
            // lbl_機台能力區間
            // 
            lbl_機台能力區間.ForeColor = Color.DimGray;
            lbl_機台能力區間.Location = new Point(11, 234);
            lbl_機台能力區間.Name = "lbl_機台能力區間";
            lbl_機台能力區間.Size = new Size(85, 23);
            lbl_機台能力區間.TabIndex = 8;
            lbl_機台能力區間.Text = "機台能力區間";
            lbl_機台能力區間.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_機台最大及最小能力
            // 
            txt_機台最大及最小能力.Location = new Point(128, 234);
            txt_機台最大及最小能力.Name = "txt_機台最大及最小能力";
            txt_機台最大及最小能力.Size = new Size(1180, 23);
            txt_機台最大及最小能力.TabIndex = 9;
            // 
            // lbl_出貨相關要求
            // 
            lbl_出貨相關要求.ForeColor = Color.DimGray;
            lbl_出貨相關要求.Location = new Point(12, 264);
            lbl_出貨相關要求.Name = "lbl_出貨相關要求";
            lbl_出貨相關要求.Size = new Size(84, 23);
            lbl_出貨相關要求.TabIndex = 10;
            lbl_出貨相關要求.Text = "出貨相關要求";
            lbl_出貨相關要求.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_補充說明
            // 
            txt_補充說明.Location = new Point(130, 264);
            txt_補充說明.Name = "txt_補充說明";
            txt_補充說明.Size = new Size(1178, 23);
            txt_補充說明.TabIndex = 11;
            // 
            // txt_機台動作規劃1
            // 
            txt_機台動作規劃1.Location = new Point(703, 295);
            txt_機台動作規劃1.Multiline = true;
            txt_機台動作規劃1.Name = "txt_機台動作規劃1";
            txt_機台動作規劃1.Size = new Size(605, 253);
            txt_機台動作規劃1.TabIndex = 12;
            // 
            // cmb_MQC_油壓委外單元
            // 
            cmb_MQC_油壓委外單元.Items.AddRange(new object[] { "油壓單元結案單" });
            cmb_MQC_油壓委外單元.Location = new Point(128, 722);
            cmb_MQC_油壓委外單元.Name = "cmb_MQC_油壓委外單元";
            cmb_MQC_油壓委外單元.Size = new Size(136, 24);
            cmb_MQC_油壓委外單元.TabIndex = 13;
            // 
            // cmb_MQC_自動化程控
            // 
            cmb_MQC_自動化程控.Items.AddRange(new object[] { "自動化程控確認單" });
            cmb_MQC_自動化程控.Location = new Point(389, 722);
            cmb_MQC_自動化程控.Name = "cmb_MQC_自動化程控";
            cmb_MQC_自動化程控.Size = new Size(136, 24);
            cmb_MQC_自動化程控.TabIndex = 14;
            // 
            // cmb_MQC_變壓器
            // 
            cmb_MQC_變壓器.Items.AddRange(new object[] { "變壓器電流測試表", "變頻變壓器輸出數據表", "交流變壓器輸出數據表" });
            cmb_MQC_變壓器.Location = new Point(650, 722);
            cmb_MQC_變壓器.Name = "cmb_MQC_變壓器";
            cmb_MQC_變壓器.Size = new Size(136, 24);
            cmb_MQC_變壓器.TabIndex = 15;
            // 
            // cmb_FQC_製成參數
            // 
            cmb_FQC_製成參數.Items.AddRange(new object[] { "充電式機台焊接", "點焊/浮凸焊接", "輪焊", "閃碰焊", "格柵板焊接", "剎車皮輪焊", "剎車皮滾圓" });
            cmb_FQC_製成參數.Location = new Point(910, 722);
            cmb_FQC_製成參數.Name = "cmb_FQC_製成參數";
            cmb_FQC_製成參數.Size = new Size(136, 24);
            cmb_FQC_製成參數.TabIndex = 16;
            // 
            // cmb_OQC_出機檢查
            // 
            cmb_OQC_出機檢查.Items.AddRange(new object[] { "組立點檢表" });
            cmb_OQC_出機檢查.Location = new Point(1171, 722);
            cmb_OQC_出機檢查.Name = "cmb_OQC_出機檢查";
            cmb_OQC_出機檢查.Size = new Size(136, 24);
            cmb_OQC_出機檢查.TabIndex = 17;
            // 
            // lbl_電控與程控注意事項
            // 
            lbl_電控與程控注意事項.ForeColor = Color.DimGray;
            lbl_電控與程控注意事項.Location = new Point(669, 295);
            lbl_電控與程控注意事項.Name = "lbl_電控與程控注意事項";
            lbl_電控與程控注意事項.Size = new Size(26, 280);
            lbl_電控與程控注意事項.TabIndex = 18;
            lbl_電控與程控注意事項.Text = "　　電控與程控注意事項";
            lbl_電控與程控注意事項.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_MQC油壓單元
            // 
            lbl_MQC油壓單元.ForeColor = Color.DimGray;
            lbl_MQC油壓單元.Location = new Point(11, 722);
            lbl_MQC油壓單元.Name = "lbl_MQC油壓單元";
            lbl_MQC油壓單元.Size = new Size(113, 26);
            lbl_MQC油壓單元.TabIndex = 19;
            lbl_MQC油壓單元.Text = "MQC-油壓單元";
            lbl_MQC油壓單元.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_MQC程控系統
            // 
            lbl_MQC程控系統.ForeColor = Color.DimGray;
            lbl_MQC程控系統.Location = new Point(272, 722);
            lbl_MQC程控系統.Name = "lbl_MQC程控系統";
            lbl_MQC程控系統.Size = new Size(113, 26);
            lbl_MQC程控系統.TabIndex = 20;
            lbl_MQC程控系統.Text = "MQC-程控系統";
            lbl_MQC程控系統.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_FQC製成參數
            // 
            lbl_FQC製成參數.ForeColor = Color.DimGray;
            lbl_FQC製成參數.Location = new Point(794, 722);
            lbl_FQC製成參數.Name = "lbl_FQC製成參數";
            lbl_FQC製成參數.Size = new Size(113, 26);
            lbl_FQC製成參數.TabIndex = 21;
            lbl_FQC製成參數.Text = "FQC-製成參數";
            lbl_FQC製成參數.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_MQC變壓器
            // 
            lbl_MQC變壓器.ForeColor = Color.DimGray;
            lbl_MQC變壓器.Location = new Point(533, 722);
            lbl_MQC變壓器.Name = "lbl_MQC變壓器";
            lbl_MQC變壓器.Size = new Size(113, 26);
            lbl_MQC變壓器.TabIndex = 22;
            lbl_MQC變壓器.Text = "MQC-變壓器";
            lbl_MQC變壓器.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_OQC出機檢查
            // 
            lbl_OQC出機檢查.ForeColor = Color.DimGray;
            lbl_OQC出機檢查.Location = new Point(1054, 722);
            lbl_OQC出機檢查.Name = "lbl_OQC出機檢查";
            lbl_OQC出機檢查.Size = new Size(113, 26);
            lbl_OQC出機檢查.TabIndex = 23;
            lbl_OQC出機檢查.Text = "OQC-出機檢查";
            lbl_OQC出機檢查.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_流程路徑圖
            // 
            lbl_流程路徑圖.ForeColor = Color.DimGray;
            lbl_流程路徑圖.Location = new Point(298, 143);
            lbl_流程路徑圖.Name = "lbl_流程路徑圖";
            lbl_流程路徑圖.Size = new Size(116, 23);
            lbl_流程路徑圖.TabIndex = 24;
            lbl_流程路徑圖.Text = "流程路徑圖";
            lbl_流程路徑圖.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_專案序號
            // 
            lbl_專案序號.ForeColor = Color.DimGray;
            lbl_專案序號.Location = new Point(11, 8);
            lbl_專案序號.Name = "lbl_專案序號";
            lbl_專案序號.Size = new Size(59, 19);
            lbl_專案序號.TabIndex = 25;
            lbl_專案序號.Text = "專案序號";
            lbl_專案序號.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_專案序號
            // 
            txt_專案序號.BackColor = SystemColors.Control;
            txt_專案序號.Location = new Point(86, 8);
            txt_專案序號.Name = "txt_專案序號";
            txt_專案序號.ReadOnly = true;
            txt_專案序號.Size = new Size(209, 23);
            txt_專案序號.TabIndex = 26;
            // 
            // lbl_參考序號
            // 
            lbl_參考序號.ForeColor = Color.DimGray;
            lbl_參考序號.Location = new Point(11, 36);
            lbl_參考序號.Name = "lbl_參考序號";
            lbl_參考序號.Size = new Size(59, 19);
            lbl_參考序號.TabIndex = 27;
            lbl_參考序號.Text = "參考序號";
            lbl_參考序號.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_參考序號
            // 
            txt_參考序號.BackColor = SystemColors.Control;
            txt_參考序號.Location = new Point(86, 35);
            txt_參考序號.Name = "txt_參考序號";
            txt_參考序號.ReadOnly = true;
            txt_參考序號.Size = new Size(209, 23);
            txt_參考序號.TabIndex = 28;
            // 
            // lbl_機台型號
            // 
            lbl_機台型號.ForeColor = Color.DimGray;
            lbl_機台型號.Location = new Point(11, 62);
            lbl_機台型號.Name = "lbl_機台型號";
            lbl_機台型號.Size = new Size(59, 19);
            lbl_機台型號.TabIndex = 29;
            lbl_機台型號.Text = "機台型號";
            lbl_機台型號.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_機台型號
            // 
            txt_機台型號.BackColor = SystemColors.Control;
            txt_機台型號.Location = new Point(86, 62);
            txt_機台型號.Name = "txt_機台型號";
            txt_機台型號.ReadOnly = true;
            txt_機台型號.Size = new Size(209, 23);
            txt_機台型號.TabIndex = 30;
            // 
            // lbl_機台名稱
            // 
            lbl_機台名稱.ForeColor = Color.DimGray;
            lbl_機台名稱.Location = new Point(11, 115);
            lbl_機台名稱.Name = "lbl_機台名稱";
            lbl_機台名稱.Size = new Size(59, 19);
            lbl_機台名稱.TabIndex = 31;
            lbl_機台名稱.Text = "機台名稱";
            lbl_機台名稱.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_機台名稱
            // 
            txt_機台名稱.BackColor = SystemColors.Control;
            txt_機台名稱.Location = new Point(86, 115);
            txt_機台名稱.Name = "txt_機台名稱";
            txt_機台名稱.ReadOnly = true;
            txt_機台名稱.Size = new Size(888, 23);
            txt_機台名稱.TabIndex = 32;
            // 
            // lbl_驗機日期
            // 
            lbl_驗機日期.ForeColor = Color.DimGray;
            lbl_驗機日期.Location = new Point(998, 37);
            lbl_驗機日期.Name = "lbl_驗機日期";
            lbl_驗機日期.Size = new Size(60, 19);
            lbl_驗機日期.TabIndex = 33;
            lbl_驗機日期.Text = "驗機日期";
            lbl_驗機日期.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_驗機日期
            // 
            txt_驗機日期.BackColor = SystemColors.Control;
            txt_驗機日期.Location = new Point(1073, 36);
            txt_驗機日期.Name = "txt_驗機日期";
            txt_驗機日期.ReadOnly = true;
            txt_驗機日期.Size = new Size(230, 23);
            txt_驗機日期.TabIndex = 34;
            // 
            // lbl_交貨日期
            // 
            lbl_交貨日期.ForeColor = Color.DimGray;
            lbl_交貨日期.Location = new Point(998, 90);
            lbl_交貨日期.Name = "lbl_交貨日期";
            lbl_交貨日期.Size = new Size(60, 19);
            lbl_交貨日期.TabIndex = 35;
            lbl_交貨日期.Text = "交貨日期";
            lbl_交貨日期.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_交貨日期
            // 
            txt_交貨日期.BackColor = SystemColors.Control;
            txt_交貨日期.Location = new Point(1073, 90);
            txt_交貨日期.Name = "txt_交貨日期";
            txt_交貨日期.ReadOnly = true;
            txt_交貨日期.Size = new Size(230, 23);
            txt_交貨日期.TabIndex = 36;
            // 
            // txt_生產速率
            // 
            txt_生產速率.BackColor = SystemColors.Control;
            txt_生產速率.Location = new Point(741, 89);
            txt_生產速率.Name = "txt_生產速率";
            txt_生產速率.ReadOnly = true;
            txt_生產速率.Size = new Size(235, 23);
            txt_生產速率.TabIndex = 37;
            // 
            // lbl_廠驗
            // 
            lbl_廠驗.ForeColor = Color.DimGray;
            lbl_廠驗.Location = new Point(998, 62);
            lbl_廠驗.Name = "lbl_廠驗";
            lbl_廠驗.Size = new Size(60, 19);
            lbl_廠驗.TabIndex = 38;
            lbl_廠驗.Text = "廠驗";
            lbl_廠驗.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_裝機
            // 
            lbl_裝機.ForeColor = Color.DimGray;
            lbl_裝機.Location = new Point(998, 115);
            lbl_裝機.Name = "lbl_裝機";
            lbl_裝機.Size = new Size(60, 19);
            lbl_裝機.TabIndex = 39;
            lbl_裝機.Text = "裝機";
            lbl_裝機.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_電流
            // 
            lbl_電流.ForeColor = Color.DimGray;
            lbl_電流.Location = new Point(316, 36);
            lbl_電流.Name = "lbl_電流";
            lbl_電流.Size = new Size(53, 19);
            lbl_電流.TabIndex = 40;
            lbl_電流.Text = "電流";
            lbl_電流.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_焊接電壓
            // 
            lbl_焊接電壓.ForeColor = Color.DimGray;
            lbl_焊接電壓.Location = new Point(316, 62);
            lbl_焊接電壓.Name = "lbl_焊接電壓";
            lbl_焊接電壓.Size = new Size(69, 19);
            lbl_焊接電壓.TabIndex = 41;
            lbl_焊接電壓.Text = "焊接電壓";
            lbl_焊接電壓.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_審圖需求
            // 
            lbl_審圖需求.ForeColor = Color.DimGray;
            lbl_審圖需求.Location = new Point(666, 36);
            lbl_審圖需求.Name = "lbl_審圖需求";
            lbl_審圖需求.Size = new Size(63, 19);
            lbl_審圖需求.TabIndex = 43;
            lbl_審圖需求.Text = "審圖需求";
            lbl_審圖需求.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_安規要求
            // 
            lbl_安規要求.ForeColor = Color.DimGray;
            lbl_安規要求.Location = new Point(666, 62);
            lbl_安規要求.Name = "lbl_安規要求";
            lbl_安規要求.Size = new Size(63, 19);
            lbl_安規要求.TabIndex = 44;
            lbl_安規要求.Text = "安規要求";
            lbl_安規要求.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_生產速率
            // 
            lbl_生產速率.ForeColor = Color.DimGray;
            lbl_生產速率.Location = new Point(666, 89);
            lbl_生產速率.Name = "lbl_生產速率";
            lbl_生產速率.Size = new Size(63, 19);
            lbl_生產速率.TabIndex = 45;
            lbl_生產速率.Text = "生產速率";
            lbl_生產速率.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_廠驗
            // 
            txt_廠驗.BackColor = SystemColors.Control;
            txt_廠驗.Location = new Point(1073, 62);
            txt_廠驗.Name = "txt_廠驗";
            txt_廠驗.ReadOnly = true;
            txt_廠驗.Size = new Size(230, 23);
            txt_廠驗.TabIndex = 46;
            // 
            // txt_裝機
            // 
            txt_裝機.BackColor = SystemColors.Control;
            txt_裝機.Location = new Point(1074, 115);
            txt_裝機.Name = "txt_裝機";
            txt_裝機.ReadOnly = true;
            txt_裝機.Size = new Size(230, 23);
            txt_裝機.TabIndex = 47;
            // 
            // txt_圖面設計
            // 
            txt_圖面設計.BackColor = SystemColors.Control;
            txt_圖面設計.Location = new Point(741, 35);
            txt_圖面設計.Name = "txt_圖面設計";
            txt_圖面設計.ReadOnly = true;
            txt_圖面設計.Size = new Size(235, 23);
            txt_圖面設計.TabIndex = 48;
            // 
            // txt_安規要求
            // 
            txt_安規要求.BackColor = SystemColors.Control;
            txt_安規要求.Location = new Point(741, 62);
            txt_安規要求.Name = "txt_安規要求";
            txt_安規要求.ReadOnly = true;
            txt_安規要求.Size = new Size(235, 23);
            txt_安規要求.TabIndex = 49;
            // 
            // txt_電流
            // 
            txt_電流.BackColor = SystemColors.Control;
            txt_電流.Location = new Point(391, 34);
            txt_電流.Name = "txt_電流";
            txt_電流.ReadOnly = true;
            txt_電流.Size = new Size(269, 23);
            txt_電流.TabIndex = 50;
            // 
            // txt_焊接電壓
            // 
            txt_焊接電壓.BackColor = SystemColors.Control;
            txt_焊接電壓.Location = new Point(563, 61);
            txt_焊接電壓.Name = "txt_焊接電壓";
            txt_焊接電壓.ReadOnly = true;
            txt_焊接電壓.Size = new Size(97, 23);
            txt_焊接電壓.TabIndex = 51;
            // 
            // txt_焊接物
            // 
            txt_焊接物.BackColor = SystemColors.Control;
            txt_焊接物.Location = new Point(391, 88);
            txt_焊接物.Name = "txt_焊接物";
            txt_焊接物.ReadOnly = true;
            txt_焊接物.Size = new Size(269, 23);
            txt_焊接物.TabIndex = 52;
            // 
            // lbl_機台類型
            // 
            lbl_機台類型.ForeColor = Color.DimGray;
            lbl_機台類型.Location = new Point(11, 89);
            lbl_機台類型.Name = "lbl_機台類型";
            lbl_機台類型.Size = new Size(59, 19);
            lbl_機台類型.TabIndex = 53;
            lbl_機台類型.Text = "機台類型";
            lbl_機台類型.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_機台類型
            // 
            txt_機台類型.BackColor = SystemColors.Control;
            txt_機台類型.Location = new Point(86, 89);
            txt_機台類型.Name = "txt_機台類型";
            txt_機台類型.ReadOnly = true;
            txt_機台類型.Size = new Size(209, 23);
            txt_機台類型.TabIndex = 54;
            // 
            // txt_驗收規範說明1
            // 
            txt_驗收規範說明1.Location = new Point(45, 567);
            txt_驗收規範說明1.Multiline = true;
            txt_驗收規範說明1.Name = "txt_驗收規範說明1";
            txt_驗收規範說明1.Size = new Size(605, 23);
            txt_驗收規範說明1.TabIndex = 55;
            // 
            // txt_驗收規範說明2
            // 
            txt_驗收規範說明2.Location = new Point(45, 597);
            txt_驗收規範說明2.Name = "txt_驗收規範說明2";
            txt_驗收規範說明2.Size = new Size(605, 23);
            txt_驗收規範說明2.TabIndex = 56;
            // 
            // txt_驗收規範說明3
            // 
            txt_驗收規範說明3.Location = new Point(45, 627);
            txt_驗收規範說明3.Name = "txt_驗收規範說明3";
            txt_驗收規範說明3.Size = new Size(605, 23);
            txt_驗收規範說明3.TabIndex = 57;
            // 
            // txt_驗收規範說明4
            // 
            txt_驗收規範說明4.Location = new Point(45, 658);
            txt_驗收規範說明4.Name = "txt_驗收規範說明4";
            txt_驗收規範說明4.Size = new Size(605, 23);
            txt_驗收規範說明4.TabIndex = 58;
            // 
            // txt_驗收規範說明5
            // 
            txt_驗收規範說明5.Location = new Point(45, 688);
            txt_驗收規範說明5.Name = "txt_驗收規範說明5";
            txt_驗收規範說明5.Size = new Size(605, 23);
            txt_驗收規範說明5.TabIndex = 59;
            // 
            // txt_驗收規範說明6
            // 
            txt_驗收規範說明6.Location = new Point(703, 567);
            txt_驗收規範說明6.Name = "txt_驗收規範說明6";
            txt_驗收規範說明6.Size = new Size(605, 23);
            txt_驗收規範說明6.TabIndex = 60;
            // 
            // chk_結案
            // 
            chk_結案.Enabled = false;
            chk_結案.Location = new Point(1290, 9);
            chk_結案.Name = "chk_結案";
            chk_結案.Size = new Size(20, 20);
            chk_結案.TabIndex = 61;
            // 
            // lbl_結案
            // 
            lbl_結案.ForeColor = Color.DimGray;
            lbl_結案.Location = new Point(1243, 7);
            lbl_結案.Name = "lbl_結案";
            lbl_結案.Size = new Size(44, 19);
            lbl_結案.TabIndex = 62;
            lbl_結案.Text = "結案";
            lbl_結案.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_訂單日期
            // 
            lbl_訂單日期.ForeColor = Color.DimGray;
            lbl_訂單日期.Location = new Point(316, 8);
            lbl_訂單日期.Name = "lbl_訂單日期";
            lbl_訂單日期.Size = new Size(69, 19);
            lbl_訂單日期.TabIndex = 63;
            lbl_訂單日期.Text = "訂單日期";
            lbl_訂單日期.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_訂單日期
            // 
            txt_訂單日期.BackColor = SystemColors.Control;
            txt_訂單日期.Location = new Point(391, 7);
            txt_訂單日期.Name = "txt_訂單日期";
            txt_訂單日期.ReadOnly = true;
            txt_訂單日期.Size = new Size(110, 23);
            txt_訂單日期.TabIndex = 64;
            // 
            // lbl_國家地區
            // 
            lbl_國家地區.ForeColor = Color.DimGray;
            lbl_國家地區.Location = new Point(1073, 7);
            lbl_國家地區.Name = "lbl_國家地區";
            lbl_國家地區.Size = new Size(56, 19);
            lbl_國家地區.TabIndex = 65;
            lbl_國家地區.Text = "國家地區";
            lbl_國家地區.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_國家地區
            // 
            txt_國家地區.BackColor = SystemColors.Control;
            txt_國家地區.Location = new Point(1146, 7);
            txt_國家地區.Name = "txt_國家地區";
            txt_國家地區.ReadOnly = true;
            txt_國家地區.Size = new Size(93, 23);
            txt_國家地區.TabIndex = 66;
            // 
            // lbl_客戶
            // 
            lbl_客戶.ForeColor = Color.DimGray;
            lbl_客戶.Location = new Point(669, 7);
            lbl_客戶.Name = "lbl_客戶";
            lbl_客戶.Size = new Size(41, 19);
            lbl_客戶.TabIndex = 67;
            lbl_客戶.Text = "客戶";
            lbl_客戶.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_客戶名稱
            // 
            txt_客戶名稱.BackColor = SystemColors.Control;
            txt_客戶名稱.Location = new Point(741, 8);
            txt_客戶名稱.Name = "txt_客戶名稱";
            txt_客戶名稱.ReadOnly = true;
            txt_客戶名稱.Size = new Size(235, 23);
            txt_客戶名稱.TabIndex = 68;
            // 
            // lbl_客戶簡稱
            // 
            lbl_客戶簡稱.ForeColor = Color.DimGray;
            lbl_客戶簡稱.Location = new Point(507, 7);
            lbl_客戶簡稱.Name = "lbl_客戶簡稱";
            lbl_客戶簡稱.Size = new Size(56, 19);
            lbl_客戶簡稱.TabIndex = 69;
            lbl_客戶簡稱.Text = "客戶簡稱";
            lbl_客戶簡稱.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_客戶簡稱
            // 
            txt_客戶簡稱.BackColor = SystemColors.Control;
            txt_客戶簡稱.Location = new Point(569, 7);
            txt_客戶簡稱.Name = "txt_客戶簡稱";
            txt_客戶簡稱.ReadOnly = true;
            txt_客戶簡稱.Size = new Size(91, 23);
            txt_客戶簡稱.TabIndex = 70;
            // 
            // txt_焊接電壓v
            // 
            txt_焊接電壓v.BackColor = SystemColors.Control;
            txt_焊接電壓v.Location = new Point(391, 61);
            txt_焊接電壓v.Name = "txt_焊接電壓v";
            txt_焊接電壓v.ReadOnly = true;
            txt_焊接電壓v.Size = new Size(74, 23);
            txt_焊接電壓v.TabIndex = 71;
            // 
            // txt_焊接電壓hz
            // 
            txt_焊接電壓hz.BackColor = SystemColors.Control;
            txt_焊接電壓hz.Location = new Point(471, 61);
            txt_焊接電壓hz.Name = "txt_焊接電壓hz";
            txt_焊接電壓hz.ReadOnly = true;
            txt_焊接電壓hz.Size = new Size(86, 23);
            txt_焊接電壓hz.TabIndex = 72;
            // 
            // txt_流程路徑圖
            // 
            txt_流程路徑圖.Location = new Point(420, 143);
            txt_流程路徑圖.Name = "txt_流程路徑圖";
            txt_流程路徑圖.Size = new Size(885, 23);
            txt_流程路徑圖.TabIndex = 73;
            // 
            // txt_驗收規範項目3
            // 
            txt_驗收規範項目3.Location = new Point(703, 597);
            txt_驗收規範項目3.Name = "txt_驗收規範項目3";
            txt_驗收規範項目3.Size = new Size(605, 23);
            txt_驗收規範項目3.TabIndex = 74;
            // 
            // txt_驗收規範項目4
            // 
            txt_驗收規範項目4.Location = new Point(703, 627);
            txt_驗收規範項目4.Name = "txt_驗收規範項目4";
            txt_驗收規範項目4.Size = new Size(605, 23);
            txt_驗收規範項目4.TabIndex = 75;
            // 
            // txt_驗收規範項目5
            // 
            txt_驗收規範項目5.Location = new Point(703, 658);
            txt_驗收規範項目5.Name = "txt_驗收規範項目5";
            txt_驗收規範項目5.Size = new Size(605, 23);
            txt_驗收規範項目5.TabIndex = 76;
            // 
            // txt_驗收規範項目6
            // 
            txt_驗收規範項目6.Location = new Point(703, 688);
            txt_驗收規範項目6.Name = "txt_驗收規範項目6";
            txt_驗收規範項目6.Size = new Size(605, 23);
            txt_驗收規範項目6.TabIndex = 77;
            // 
            // lbl_機台驗收規範
            // 
            lbl_機台驗收規範.ForeColor = Color.DimGray;
            lbl_機台驗收規範.Location = new Point(11, 567);
            lbl_機台驗收規範.Name = "lbl_機台驗收規範";
            lbl_機台驗收規範.Size = new Size(26, 144);
            lbl_機台驗收規範.TabIndex = 78;
            lbl_機台驗收規範.Text = " 機台驗收規範";
            lbl_機台驗收規範.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_機台驗收規範2
            // 
            lbl_機台驗收規範2.ForeColor = Color.DimGray;
            lbl_機台驗收規範2.Location = new Point(669, 567);
            lbl_機台驗收規範2.Name = "lbl_機台驗收規範2";
            lbl_機台驗收規範2.Size = new Size(26, 144);
            lbl_機台驗收規範2.TabIndex = 79;
            lbl_機台驗收規範2.Text = " 機台驗收規範";
            lbl_機台驗收規範2.TextAlign = ContentAlignment.MiddleLeft;
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
            panelFooter.Location = new Point(0, 804);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(1419, 34);
            panelFooter.TabIndex = 2;
            // 
            // lblF_核准人員
            // 
            lblF_核准人員.Location = new Point(8, 8);
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
            txtF_核准.Location = new Point(83, 8);
            txtF_核准.Name = "txtF_核准";
            txtF_核准.ReadOnly = true;
            txtF_核准.Size = new Size(95, 16);
            txtF_核准.TabIndex = 1;
            // 
            // lblF_修改人員
            // 
            lblF_修改人員.Location = new Point(359, 8);
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
            txtF_修改.Location = new Point(435, 8);
            txtF_修改.Name = "txtF_修改";
            txtF_修改.ReadOnly = true;
            txtF_修改.Size = new Size(95, 16);
            txtF_修改.TabIndex = 3;
            // 
            // lblF_建檔人員
            // 
            lblF_建檔人員.Location = new Point(714, 8);
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
            txtF_建檔.Location = new Point(790, 8);
            txtF_建檔.Name = "txtF_建檔";
            txtF_建檔.ReadOnly = true;
            txtF_建檔.Size = new Size(95, 16);
            txtF_建檔.TabIndex = 5;
            // 
            // txtF_核准日
            // 
            txtF_核准日.BackColor = Color.FromArgb(252, 230, 212);
            txtF_核准日.BorderStyle = BorderStyle.None;
            txtF_核准日.Location = new Point(182, 8);
            txtF_核准日.Name = "txtF_核准日";
            txtF_核准日.ReadOnly = true;
            txtF_核准日.Size = new Size(166, 16);
            txtF_核准日.TabIndex = 6;
            // 
            // txtF_修改日
            // 
            txtF_修改日.BackColor = Color.FromArgb(252, 230, 212);
            txtF_修改日.BorderStyle = BorderStyle.None;
            txtF_修改日.Location = new Point(533, 8);
            txtF_修改日.Name = "txtF_修改日";
            txtF_修改日.ReadOnly = true;
            txtF_修改日.Size = new Size(166, 16);
            txtF_修改日.TabIndex = 7;
            // 
            // txtF_建檔日
            // 
            txtF_建檔日.BackColor = Color.FromArgb(252, 230, 212);
            txtF_建檔日.BorderStyle = BorderStyle.None;
            txtF_建檔日.Location = new Point(888, 8);
            txtF_建檔日.Name = "txtF_建檔日";
            txtF_建檔日.ReadOnly = true;
            txtF_建檔日.Size = new Size(166, 16);
            txtF_建檔日.TabIndex = 8;
            // 
            // lbl_控制電壓
            // 
            lbl_控制電壓.ForeColor = Color.DimGray;
            lbl_控制電壓.Location = new Point(316, 89);
            lbl_控制電壓.Name = "lbl_控制電壓";
            lbl_控制電壓.Size = new Size(69, 19);
            lbl_控制電壓.TabIndex = 42;
            lbl_控制電壓.Text = "控制電壓";
            lbl_控制電壓.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ProductSpecControl
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelBody);
            Controls.Add(panelFooter);
            Controls.Add(panelHeader);
            Font = new Font("微軟正黑體", 9F);
            Margin = new Padding(4);
            Name = "ProductSpecControl";
            Size = new Size(1419, 838);
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
        private Label lblHint;
        private Button btnClose2;
        private Button btnReopen;
        private Button btnEdit;
        private Button btnSave;
        private Button btnApprove;
        private Button btnUnapprove;
        private Button btnPrint;
        private Button btnOverview;
        private Button btnExit;
        private Panel panelBody;
                private Label lbl_專案負責人;
                private ComboBox cmb_專案負責人;
                private Label lbl_機台重點;
                private TextBox txt_客戶需求陳述;
                private Label lbl_驗收物件規格;
                private TextBox txt_驗收物件規格;
                private Label lbl_設計參考及機構說明;
                private TextBox txt_驗收基本要求1;
                private Label lbl_機台能力區間;
                private TextBox txt_機台最大及最小能力;
                private Label lbl_出貨相關要求;
                private TextBox txt_補充說明;
                private TextBox txt_機台動作規劃1;
                private ComboBox cmb_MQC_油壓委外單元;
                private ComboBox cmb_MQC_自動化程控;
                private ComboBox cmb_MQC_變壓器;
                private ComboBox cmb_FQC_製成參數;
                private ComboBox cmb_OQC_出機檢查;
                private Label lbl_電控與程控注意事項;
                private Label lbl_MQC油壓單元;
                private Label lbl_MQC程控系統;
                private Label lbl_FQC製成參數;
                private Label lbl_MQC變壓器;
                private Label lbl_OQC出機檢查;
                private Label lbl_流程路徑圖;
                private Label lbl_專案序號;
                private TextBox txt_專案序號;
                private Label lbl_參考序號;
                private TextBox txt_參考序號;
                private Label lbl_機台型號;
                private TextBox txt_機台型號;
                private Label lbl_機台名稱;
                private TextBox txt_機台名稱;
                private Label lbl_驗機日期;
                private TextBox txt_驗機日期;
                private Label lbl_交貨日期;
                private TextBox txt_交貨日期;
                private TextBox txt_生產速率;
                private Label lbl_廠驗;
                private Label lbl_裝機;
                private Label lbl_電流;
                private Label lbl_焊接電壓;
                private Label lbl_控制電壓;
                private Label lbl_審圖需求;
                private Label lbl_安規要求;
                private Label lbl_生產速率;
                private TextBox txt_廠驗;
                private TextBox txt_裝機;
                private TextBox txt_圖面設計;
                private TextBox txt_安規要求;
                private TextBox txt_電流;
                private TextBox txt_焊接電壓;
                private TextBox txt_焊接物;
                private Label lbl_機台類型;
                private TextBox txt_機台類型;
                private TextBox txt_驗收規範說明1;
                private TextBox txt_驗收規範說明2;
                private TextBox txt_驗收規範說明3;
                private TextBox txt_驗收規範說明4;
                private TextBox txt_驗收規範說明5;
                private TextBox txt_驗收規範說明6;
                private CheckBox chk_結案;
                private Label lbl_結案;
                private Label lbl_訂單日期;
                private TextBox txt_訂單日期;
                private Label lbl_國家地區;
                private TextBox txt_國家地區;
                private Label lbl_客戶;
                private TextBox txt_客戶名稱;
                private Label lbl_客戶簡稱;
                private TextBox txt_客戶簡稱;
                private TextBox txt_焊接電壓v;
                private TextBox txt_焊接電壓hz;
                private TextBox txt_流程路徑圖;
                private TextBox txt_驗收規範項目3;
                private TextBox txt_驗收規範項目4;
                private TextBox txt_驗收規範項目5;
                private TextBox txt_驗收規範項目6;
                private Label lbl_機台驗收規範;
                private Label lbl_機台驗收規範2;
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
