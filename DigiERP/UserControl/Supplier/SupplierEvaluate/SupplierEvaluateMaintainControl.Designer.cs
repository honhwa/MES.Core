namespace DigiERP.UserControl.Supplier.SupplierManage
{
    partial class SupplierEvaluateMaintainControl
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
            panelToolbar = new Panel();
            lblMode = new Label();
            btnDelete = new Button();
            btnAdd = new Button();
            btnModify = new Button();
            btnSave = new Button();
            btnApprove = new Button();
            btnCancelApprove = new Button();
            btnPrint = new Button();
            btnOverview = new Button();
            btnBack = new Button();
            panelHeader = new Panel();
            lblDate = new Label();
            dtpDate = new DateTimePicker();
            lblFormNo = new Label();
            txtFormNo = new TextBox();
            lblSupplierNo = new Label();
            txtSupplierNo = new TextBox();
            btnPickSupplier = new Button();
            lblShortName = new Label();
            txtShortName = new TextBox();
            lblEvaluator = new Label();
            cboEvaluator = new ComboBox();
            lblTaxNo = new Label();
            txtTaxNo = new TextBox();
            lblIndustry = new Label();
            txtIndustry = new TextBox();
            lblSupplierName = new Label();
            txtSupplierName = new TextBox();
            lblReviewer = new Label();
            cboReviewer = new ComboBox();
            lblFactoryAddr = new Label();
            txtFactoryAddr = new TextBox();
            lblCompanyAddr = new Label();
            txtCompanyAddr = new TextBox();
            lblReviewDate = new Label();
            dtpReviewDate = new DateTimePicker();
            panelScoreHeader = new Panel();
            lblScoreTitle = new Label();
            panelScore = new Panel();
            lblCapCriteria = new Label();
            lblCapScore = new Label();
            lblCapRemark = new Label();
            lblTotal = new Label();
            lblTotalValue = new Label();
            lbl達成客戶要求的能力 = new Label();
            txt達成客戶要求的能力 = new TextBox();
            lblCode達 = new Label();
            txtRemark達 = new TextBox();
            lbl提升經營效能的企圖 = new Label();
            txt提升經營效能的企圖 = new TextBox();
            lblCode提 = new Label();
            txtRemark提 = new TextBox();
            lbl勞動安全與職工福利 = new Label();
            txt勞動安全與職工福利 = new TextBox();
            lblCode勞 = new Label();
            txtRemark勞 = new TextBox();
            lbl能迅速處理客戶抱怨 = new Label();
            txt能迅速處理客戶抱怨 = new TextBox();
            lblCode能 = new Label();
            txtRemark能 = new TextBox();
            lbl設備的產能與準確度 = new Label();
            txt設備的產能與準確度 = new TextBox();
            lblCode設 = new Label();
            txtRemark設 = new TextBox();
            lbl足夠的人力資源條件 = new Label();
            txt足夠的人力資源條件 = new TextBox();
            lblCode足 = new Label();
            txtRemark足 = new TextBox();
            lbl產銷接單適當無過載 = new Label();
            txt產銷接單適當無過載 = new TextBox();
            lblCode產 = new Label();
            txtRemark產 = new TextBox();
            lbl健全的產品驗證系統 = new Label();
            txt健全的產品驗證系統 = new TextBox();
            lblCode健 = new Label();
            txtRemark健 = new TextBox();
            lbl符合訂單的品質要求 = new Label();
            txt符合訂單的品質要求 = new TextBox();
            lblCode符 = new Label();
            txtRemark符 = new TextBox();
            lbl依產品標準進行檢測 = new Label();
            txt依產品標準進行檢測 = new TextBox();
            lblCode依 = new Label();
            txtRemark依 = new TextBox();
            panelFooter = new Panel();
            txtModifyDate = new TextBox();
            txtModifier = new TextBox();
            lbl修改F = new Label();
            txtCreateDate = new TextBox();
            txtCreator = new TextBox();
            lbl建檔F = new Label();
            txtApproveDate = new TextBox();
            txtApprover = new TextBox();
            lbl核准F = new Label();
            panelToolbar.SuspendLayout();
            panelHeader.SuspendLayout();
            panelScoreHeader.SuspendLayout();
            panelScore.SuspendLayout();
            panelFooter.SuspendLayout();
            SuspendLayout();
            // 
            // panelToolbar
            // 
            panelToolbar.BackColor = Color.FromArgb(255, 222, 173);
            panelToolbar.Controls.Add(lblMode);
            panelToolbar.Controls.Add(btnDelete);
            panelToolbar.Controls.Add(btnAdd);
            panelToolbar.Controls.Add(btnModify);
            panelToolbar.Controls.Add(btnSave);
            panelToolbar.Controls.Add(btnApprove);
            panelToolbar.Controls.Add(btnCancelApprove);
            panelToolbar.Controls.Add(btnPrint);
            panelToolbar.Controls.Add(btnOverview);
            panelToolbar.Controls.Add(btnBack);
            panelToolbar.Dock = DockStyle.Top;
            panelToolbar.Location = new Point(0, 0);
            panelToolbar.Name = "panelToolbar";
            panelToolbar.Size = new Size(1497, 60);
            panelToolbar.TabIndex = 0;
            // 
            // lblMode
            // 
            lblMode.Font = new Font("微軟正黑體", 14F, FontStyle.Bold);
            lblMode.ForeColor = Color.FromArgb(60, 60, 120);
            lblMode.Location = new Point(8, 14);
            lblMode.Name = "lblMode";
            lblMode.Size = new Size(80, 32);
            lblMode.TabIndex = 0;
            lblMode.Text = "修改";
            lblMode.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.IndianRed;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(582, 8);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 44);
            btnDelete.TabIndex = 1;
            btnDelete.Tag = "btn-delete";
            btnDelete.Text = "刪除紀錄";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(70, 160, 70);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(690, 8);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 44);
            btnAdd.TabIndex = 2;
            btnAdd.Tag = "btn-modify";
            btnAdd.Text = "新增";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Visible = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnModify
            // 
            btnModify.BackColor = Color.Olive;
            btnModify.FlatStyle = FlatStyle.Flat;
            btnModify.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnModify.ForeColor = Color.White;
            btnModify.Location = new Point(788, 8);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(90, 44);
            btnModify.TabIndex = 3;
            btnModify.Tag = "btn-modify";
            btnModify.Text = "修改";
            btnModify.UseVisualStyleBackColor = false;
            btnModify.Click += btnModify_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.CornflowerBlue;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(886, 8);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(90, 44);
            btnSave.TabIndex = 4;
            btnSave.Tag = "btn-modify";
            btnSave.Text = "儲存";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnApprove
            // 
            btnApprove.BackColor = Color.MediumSeaGreen;
            btnApprove.FlatStyle = FlatStyle.Flat;
            btnApprove.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnApprove.ForeColor = Color.White;
            btnApprove.Location = new Point(984, 8);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(90, 44);
            btnApprove.TabIndex = 5;
            btnApprove.Tag = "btn-modify";
            btnApprove.Text = "生效";
            btnApprove.UseVisualStyleBackColor = false;
            btnApprove.Click += btnApprove_Click;
            // 
            // btnCancelApprove
            // 
            btnCancelApprove.BackColor = Color.SteelBlue;
            btnCancelApprove.FlatStyle = FlatStyle.Flat;
            btnCancelApprove.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnCancelApprove.ForeColor = Color.White;
            btnCancelApprove.Location = new Point(1082, 8);
            btnCancelApprove.Name = "btnCancelApprove";
            btnCancelApprove.Size = new Size(100, 44);
            btnCancelApprove.TabIndex = 6;
            btnCancelApprove.Tag = "btn-modify";
            btnCancelApprove.Text = "取消生效";
            btnCancelApprove.UseVisualStyleBackColor = false;
            btnCancelApprove.Click += btnCancelApprove_Click;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.Gray;
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnPrint.ForeColor = Color.White;
            btnPrint.Location = new Point(1190, 8);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(90, 44);
            btnPrint.TabIndex = 7;
            btnPrint.Tag = "btn-modify";
            btnPrint.Text = "列印";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // btnOverview
            // 
            btnOverview.BackColor = Color.DarkSlateGray;
            btnOverview.FlatStyle = FlatStyle.Flat;
            btnOverview.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnOverview.ForeColor = Color.White;
            btnOverview.Location = new Point(1288, 8);
            btnOverview.Name = "btnOverview";
            btnOverview.Size = new Size(90, 44);
            btnOverview.TabIndex = 8;
            btnOverview.Tag = "btn-modify";
            btnOverview.Text = "總覽";
            btnOverview.UseVisualStyleBackColor = false;
            btnOverview.Click += btnOverview_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Red;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(1389, 8);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(100, 44);
            btnBack.TabIndex = 9;
            btnBack.Text = "EXIT";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(255, 248, 240);
            panelHeader.Controls.Add(lblDate);
            panelHeader.Controls.Add(dtpDate);
            panelHeader.Controls.Add(lblFormNo);
            panelHeader.Controls.Add(txtFormNo);
            panelHeader.Controls.Add(lblSupplierNo);
            panelHeader.Controls.Add(txtSupplierNo);
            panelHeader.Controls.Add(btnPickSupplier);
            panelHeader.Controls.Add(lblShortName);
            panelHeader.Controls.Add(txtShortName);
            panelHeader.Controls.Add(lblEvaluator);
            panelHeader.Controls.Add(cboEvaluator);
            panelHeader.Controls.Add(lblTaxNo);
            panelHeader.Controls.Add(txtTaxNo);
            panelHeader.Controls.Add(lblIndustry);
            panelHeader.Controls.Add(txtIndustry);
            panelHeader.Controls.Add(lblSupplierName);
            panelHeader.Controls.Add(txtSupplierName);
            panelHeader.Controls.Add(lblReviewer);
            panelHeader.Controls.Add(cboReviewer);
            panelHeader.Controls.Add(lblFactoryAddr);
            panelHeader.Controls.Add(txtFactoryAddr);
            panelHeader.Controls.Add(lblCompanyAddr);
            panelHeader.Controls.Add(txtCompanyAddr);
            panelHeader.Controls.Add(lblReviewDate);
            panelHeader.Controls.Add(dtpReviewDate);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 60);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1497, 132);
            panelHeader.TabIndex = 1;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("微軟正黑體", 10F);
            lblDate.Location = new Point(8, 12);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(36, 18);
            lblDate.TabIndex = 0;
            lblDate.Text = "日期";
            // 
            // dtpDate
            // 
            dtpDate.CustomFormat = "yyyy/MM/dd";
            dtpDate.Font = new Font("微軟正黑體", 10F);
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.Location = new Point(72, 8);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(140, 25);
            dtpDate.TabIndex = 1;
            // 
            // lblFormNo
            // 
            lblFormNo.AutoSize = true;
            lblFormNo.Font = new Font("微軟正黑體", 10F);
            lblFormNo.Location = new Point(230, 12);
            lblFormNo.Name = "lblFormNo";
            lblFormNo.Size = new Size(36, 18);
            lblFormNo.TabIndex = 2;
            lblFormNo.Text = "單號";
            // 
            // txtFormNo
            // 
            txtFormNo.BackColor = Color.WhiteSmoke;
            txtFormNo.Font = new Font("微軟正黑體", 10F);
            txtFormNo.Location = new Point(294, 8);
            txtFormNo.Name = "txtFormNo";
            txtFormNo.ReadOnly = true;
            txtFormNo.Size = new Size(118, 25);
            txtFormNo.TabIndex = 3;
            // 
            // lblSupplierNo
            // 
            lblSupplierNo.AutoSize = true;
            lblSupplierNo.Font = new Font("微軟正黑體", 10F);
            lblSupplierNo.Location = new Point(428, 11);
            lblSupplierNo.Name = "lblSupplierNo";
            lblSupplierNo.Size = new Size(64, 18);
            lblSupplierNo.TabIndex = 4;
            lblSupplierNo.Text = "廠商編號";
            // 
            // txtSupplierNo
            // 
            txtSupplierNo.BackColor = Color.WhiteSmoke;
            txtSupplierNo.Font = new Font("微軟正黑體", 10F);
            txtSupplierNo.Location = new Point(498, 7);
            txtSupplierNo.Name = "txtSupplierNo";
            txtSupplierNo.ReadOnly = true;
            txtSupplierNo.Size = new Size(98, 25);
            txtSupplierNo.TabIndex = 5;
            // 
            // btnPickSupplier
            // 
            btnPickSupplier.FlatStyle = FlatStyle.Flat;
            btnPickSupplier.Font = new Font("Segoe MDL2 Assets", 10F);
            btnPickSupplier.Location = new Point(596, 7);
            btnPickSupplier.Name = "btnPickSupplier";
            btnPickSupplier.Size = new Size(28, 25);
            btnPickSupplier.TabIndex = 6;
            btnPickSupplier.UseVisualStyleBackColor = true;
            btnPickSupplier.Click += btnPickSupplier_Click;
            // 
            // lblShortName
            // 
            lblShortName.AutoSize = true;
            lblShortName.Font = new Font("微軟正黑體", 10F);
            lblShortName.Location = new Point(634, 11);
            lblShortName.Name = "lblShortName";
            lblShortName.Size = new Size(64, 18);
            lblShortName.TabIndex = 7;
            lblShortName.Text = "廠商簡稱";
            // 
            // txtShortName
            // 
            txtShortName.BackColor = Color.WhiteSmoke;
            txtShortName.Font = new Font("微軟正黑體", 10F);
            txtShortName.Location = new Point(698, 7);
            txtShortName.Name = "txtShortName";
            txtShortName.ReadOnly = true;
            txtShortName.Size = new Size(140, 25);
            txtShortName.TabIndex = 8;
            // 
            // lblEvaluator
            // 
            lblEvaluator.AutoSize = true;
            lblEvaluator.Font = new Font("微軟正黑體", 10F);
            lblEvaluator.Location = new Point(848, 11);
            lblEvaluator.Name = "lblEvaluator";
            lblEvaluator.Size = new Size(64, 18);
            lblEvaluator.TabIndex = 9;
            lblEvaluator.Text = "評鑑人員";
            // 
            // cboEvaluator
            // 
            cboEvaluator.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEvaluator.Font = new Font("微軟正黑體", 10F);
            cboEvaluator.Location = new Point(912, 7);
            cboEvaluator.Name = "cboEvaluator";
            cboEvaluator.Size = new Size(128, 25);
            cboEvaluator.TabIndex = 10;
            // 
            // lblTaxNo
            // 
            lblTaxNo.AutoSize = true;
            lblTaxNo.Font = new Font("微軟正黑體", 10F);
            lblTaxNo.Location = new Point(8, 52);
            lblTaxNo.Name = "lblTaxNo";
            lblTaxNo.Size = new Size(64, 18);
            lblTaxNo.TabIndex = 11;
            lblTaxNo.Text = "統一編號";
            // 
            // txtTaxNo
            // 
            txtTaxNo.BackColor = Color.WhiteSmoke;
            txtTaxNo.Font = new Font("微軟正黑體", 10F);
            txtTaxNo.Location = new Point(72, 48);
            txtTaxNo.Name = "txtTaxNo";
            txtTaxNo.ReadOnly = true;
            txtTaxNo.Size = new Size(140, 25);
            txtTaxNo.TabIndex = 12;
            // 
            // lblIndustry
            // 
            lblIndustry.AutoSize = true;
            lblIndustry.Font = new Font("微軟正黑體", 10F);
            lblIndustry.Location = new Point(230, 52);
            lblIndustry.Name = "lblIndustry";
            lblIndustry.Size = new Size(64, 18);
            lblIndustry.TabIndex = 13;
            lblIndustry.Text = "所屬業別";
            // 
            // txtIndustry
            // 
            txtIndustry.BackColor = Color.WhiteSmoke;
            txtIndustry.Font = new Font("微軟正黑體", 10F);
            txtIndustry.Location = new Point(294, 48);
            txtIndustry.Name = "txtIndustry";
            txtIndustry.ReadOnly = true;
            txtIndustry.Size = new Size(118, 25);
            txtIndustry.TabIndex = 14;
            // 
            // lblSupplierName
            // 
            lblSupplierName.AutoSize = true;
            lblSupplierName.Font = new Font("微軟正黑體", 10F);
            lblSupplierName.Location = new Point(428, 51);
            lblSupplierName.Name = "lblSupplierName";
            lblSupplierName.Size = new Size(64, 18);
            lblSupplierName.TabIndex = 15;
            lblSupplierName.Text = "廠商名稱";
            // 
            // txtSupplierName
            // 
            txtSupplierName.BackColor = Color.WhiteSmoke;
            txtSupplierName.Font = new Font("微軟正黑體", 10F);
            txtSupplierName.Location = new Point(498, 47);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.ReadOnly = true;
            txtSupplierName.Size = new Size(340, 25);
            txtSupplierName.TabIndex = 16;
            // 
            // lblReviewer
            // 
            lblReviewer.AutoSize = true;
            lblReviewer.Font = new Font("微軟正黑體", 10F);
            lblReviewer.Location = new Point(848, 51);
            lblReviewer.Name = "lblReviewer";
            lblReviewer.Size = new Size(64, 18);
            lblReviewer.TabIndex = 17;
            lblReviewer.Text = "覆審人員";
            // 
            // cboReviewer
            // 
            cboReviewer.DropDownStyle = ComboBoxStyle.DropDownList;
            cboReviewer.Font = new Font("微軟正黑體", 10F);
            cboReviewer.Location = new Point(912, 47);
            cboReviewer.Name = "cboReviewer";
            cboReviewer.Size = new Size(128, 25);
            cboReviewer.TabIndex = 18;
            // 
            // lblFactoryAddr
            // 
            lblFactoryAddr.AutoSize = true;
            lblFactoryAddr.Font = new Font("微軟正黑體", 10F);
            lblFactoryAddr.Location = new Point(8, 92);
            lblFactoryAddr.Name = "lblFactoryAddr";
            lblFactoryAddr.Size = new Size(64, 18);
            lblFactoryAddr.TabIndex = 19;
            lblFactoryAddr.Text = "工廠地址";
            // 
            // txtFactoryAddr
            // 
            txtFactoryAddr.BackColor = Color.WhiteSmoke;
            txtFactoryAddr.Font = new Font("微軟正黑體", 10F);
            txtFactoryAddr.Location = new Point(72, 88);
            txtFactoryAddr.Name = "txtFactoryAddr";
            txtFactoryAddr.ReadOnly = true;
            txtFactoryAddr.Size = new Size(340, 25);
            txtFactoryAddr.TabIndex = 20;
            // 
            // lblCompanyAddr
            // 
            lblCompanyAddr.AutoSize = true;
            lblCompanyAddr.Font = new Font("微軟正黑體", 10F);
            lblCompanyAddr.Location = new Point(428, 91);
            lblCompanyAddr.Name = "lblCompanyAddr";
            lblCompanyAddr.Size = new Size(64, 18);
            lblCompanyAddr.TabIndex = 21;
            lblCompanyAddr.Text = "公司地址";
            // 
            // txtCompanyAddr
            // 
            txtCompanyAddr.BackColor = Color.WhiteSmoke;
            txtCompanyAddr.Font = new Font("微軟正黑體", 10F);
            txtCompanyAddr.Location = new Point(498, 87);
            txtCompanyAddr.Name = "txtCompanyAddr";
            txtCompanyAddr.ReadOnly = true;
            txtCompanyAddr.Size = new Size(340, 25);
            txtCompanyAddr.TabIndex = 22;
            // 
            // lblReviewDate
            // 
            lblReviewDate.AutoSize = true;
            lblReviewDate.Font = new Font("微軟正黑體", 10F);
            lblReviewDate.Location = new Point(848, 91);
            lblReviewDate.Name = "lblReviewDate";
            lblReviewDate.Size = new Size(64, 18);
            lblReviewDate.TabIndex = 23;
            lblReviewDate.Text = "覆審日期";
            // 
            // dtpReviewDate
            // 
            dtpReviewDate.CustomFormat = "yyyy/MM/dd";
            dtpReviewDate.Font = new Font("微軟正黑體", 10F);
            dtpReviewDate.Format = DateTimePickerFormat.Custom;
            dtpReviewDate.Location = new Point(912, 87);
            dtpReviewDate.Name = "dtpReviewDate";
            dtpReviewDate.Size = new Size(128, 25);
            dtpReviewDate.TabIndex = 24;
            // 
            // panelScoreHeader
            // 
            panelScoreHeader.BackColor = Color.FromArgb(40, 100, 160);
            panelScoreHeader.Controls.Add(lblScoreTitle);
            panelScoreHeader.Dock = DockStyle.Top;
            panelScoreHeader.Location = new Point(0, 192);
            panelScoreHeader.Name = "panelScoreHeader";
            panelScoreHeader.Size = new Size(1497, 30);
            panelScoreHeader.TabIndex = 2;
            // 
            // lblScoreTitle
            // 
            lblScoreTitle.AutoSize = true;
            lblScoreTitle.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblScoreTitle.ForeColor = Color.White;
            lblScoreTitle.Location = new Point(8, 6);
            lblScoreTitle.Name = "lblScoreTitle";
            lblScoreTitle.Size = new Size(64, 18);
            lblScoreTitle.TabIndex = 0;
            lblScoreTitle.Text = "評鑑項目";
            // 
            // panelScore
            // 
            panelScore.AutoScroll = true;
            panelScore.BackColor = Color.White;
            panelScore.Controls.Add(lblCapCriteria);
            panelScore.Controls.Add(lblCapScore);
            panelScore.Controls.Add(lblCapRemark);
            panelScore.Controls.Add(lblTotal);
            panelScore.Controls.Add(lblTotalValue);
            panelScore.Controls.Add(lbl達成客戶要求的能力);
            panelScore.Controls.Add(txt達成客戶要求的能力);
            panelScore.Controls.Add(lblCode達);
            panelScore.Controls.Add(txtRemark達);
            panelScore.Controls.Add(lbl提升經營效能的企圖);
            panelScore.Controls.Add(txt提升經營效能的企圖);
            panelScore.Controls.Add(lblCode提);
            panelScore.Controls.Add(txtRemark提);
            panelScore.Controls.Add(lbl勞動安全與職工福利);
            panelScore.Controls.Add(txt勞動安全與職工福利);
            panelScore.Controls.Add(lblCode勞);
            panelScore.Controls.Add(txtRemark勞);
            panelScore.Controls.Add(lbl能迅速處理客戶抱怨);
            panelScore.Controls.Add(txt能迅速處理客戶抱怨);
            panelScore.Controls.Add(lblCode能);
            panelScore.Controls.Add(txtRemark能);
            panelScore.Controls.Add(lbl設備的產能與準確度);
            panelScore.Controls.Add(txt設備的產能與準確度);
            panelScore.Controls.Add(lblCode設);
            panelScore.Controls.Add(txtRemark設);
            panelScore.Controls.Add(lbl足夠的人力資源條件);
            panelScore.Controls.Add(txt足夠的人力資源條件);
            panelScore.Controls.Add(lblCode足);
            panelScore.Controls.Add(txtRemark足);
            panelScore.Controls.Add(lbl產銷接單適當無過載);
            panelScore.Controls.Add(txt產銷接單適當無過載);
            panelScore.Controls.Add(lblCode產);
            panelScore.Controls.Add(txtRemark產);
            panelScore.Controls.Add(lbl健全的產品驗證系統);
            panelScore.Controls.Add(txt健全的產品驗證系統);
            panelScore.Controls.Add(lblCode健);
            panelScore.Controls.Add(txtRemark健);
            panelScore.Controls.Add(lbl符合訂單的品質要求);
            panelScore.Controls.Add(txt符合訂單的品質要求);
            panelScore.Controls.Add(lblCode符);
            panelScore.Controls.Add(txtRemark符);
            panelScore.Controls.Add(lbl依產品標準進行檢測);
            panelScore.Controls.Add(txt依產品標準進行檢測);
            panelScore.Controls.Add(lblCode依);
            panelScore.Controls.Add(txtRemark依);
            panelScore.Dock = DockStyle.Fill;
            panelScore.Location = new Point(0, 222);
            panelScore.Name = "panelScore";
            panelScore.Size = new Size(1497, 510);
            panelScore.TabIndex = 3;
            // 
            // lblCapCriteria
            // 
            lblCapCriteria.AutoSize = true;
            lblCapCriteria.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblCapCriteria.Location = new Point(8, 4);
            lblCapCriteria.Name = "lblCapCriteria";
            lblCapCriteria.Size = new Size(64, 18);
            lblCapCriteria.TabIndex = 0;
            lblCapCriteria.Text = "評鑑項目";
            // 
            // lblCapScore
            // 
            lblCapScore.AutoSize = true;
            lblCapScore.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblCapScore.Location = new Point(296, 4);
            lblCapScore.Name = "lblCapScore";
            lblCapScore.Size = new Size(36, 18);
            lblCapScore.TabIndex = 1;
            lblCapScore.Text = "分數";
            // 
            // lblCapRemark
            // 
            lblCapRemark.AutoSize = true;
            lblCapRemark.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblCapRemark.Location = new Point(384, 4);
            lblCapRemark.Name = "lblCapRemark";
            lblCapRemark.Size = new Size(36, 18);
            lblCapRemark.TabIndex = 2;
            lblCapRemark.Text = "備註";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblTotal.Location = new Point(8, 336);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(64, 18);
            lblTotal.TabIndex = 3;
            lblTotal.Text = "評分合計";
            // 
            // lblTotalValue
            // 
            lblTotalValue.AutoSize = true;
            lblTotalValue.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblTotalValue.ForeColor = Color.FromArgb(160, 40, 40);
            lblTotalValue.Location = new Point(296, 336);
            lblTotalValue.Name = "lblTotalValue";
            lblTotalValue.Size = new Size(16, 18);
            lblTotalValue.TabIndex = 4;
            lblTotalValue.Text = "0";
            // 
            // lbl達成客戶要求的能力
            // 
            lbl達成客戶要求的能力.Font = new Font("微軟正黑體", 10F);
            lbl達成客戶要求的能力.Location = new Point(8, 33);
            lbl達成客戶要求的能力.Name = "lbl達成客戶要求的能力";
            lbl達成客戶要求的能力.Size = new Size(280, 20);
            lbl達成客戶要求的能力.TabIndex = 5;
            lbl達成客戶要求的能力.Text = "達成客戶要求的能力";
            // 
            // txt達成客戶要求的能力
            // 
            txt達成客戶要求的能力.Font = new Font("微軟正黑體", 10F);
            txt達成客戶要求的能力.Location = new Point(296, 30);
            txt達成客戶要求的能力.Name = "txt達成客戶要求的能力";
            txt達成客戶要求的能力.Size = new Size(70, 25);
            txt達成客戶要求的能力.TabIndex = 6;
            txt達成客戶要求的能力.TextAlign = HorizontalAlignment.Center;
            txt達成客戶要求的能力.TextChanged += ScoreBox_TextChanged;
            // 
            // lblCode達
            // 
            lblCode達.AutoSize = true;
            lblCode達.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblCode達.Location = new Point(384, 33);
            lblCode達.Name = "lblCode達";
            lblCode達.Size = new Size(22, 18);
            lblCode達.TabIndex = 7;
            lblCode達.Text = "達";
            // 
            // txtRemark達
            // 
            txtRemark達.Font = new Font("微軟正黑體", 10F);
            txtRemark達.Location = new Point(408, 30);
            txtRemark達.Name = "txtRemark達";
            txtRemark達.Size = new Size(400, 25);
            txtRemark達.TabIndex = 8;
            // 
            // lbl提升經營效能的企圖
            // 
            lbl提升經營效能的企圖.Font = new Font("微軟正黑體", 10F);
            lbl提升經營效能的企圖.Location = new Point(8, 63);
            lbl提升經營效能的企圖.Name = "lbl提升經營效能的企圖";
            lbl提升經營效能的企圖.Size = new Size(280, 20);
            lbl提升經營效能的企圖.TabIndex = 9;
            lbl提升經營效能的企圖.Text = "提升經營效能的企圖";
            // 
            // txt提升經營效能的企圖
            // 
            txt提升經營效能的企圖.Font = new Font("微軟正黑體", 10F);
            txt提升經營效能的企圖.Location = new Point(296, 60);
            txt提升經營效能的企圖.Name = "txt提升經營效能的企圖";
            txt提升經營效能的企圖.Size = new Size(70, 25);
            txt提升經營效能的企圖.TabIndex = 10;
            txt提升經營效能的企圖.TextAlign = HorizontalAlignment.Center;
            txt提升經營效能的企圖.TextChanged += ScoreBox_TextChanged;
            // 
            // lblCode提
            // 
            lblCode提.AutoSize = true;
            lblCode提.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblCode提.Location = new Point(384, 63);
            lblCode提.Name = "lblCode提";
            lblCode提.Size = new Size(22, 18);
            lblCode提.TabIndex = 11;
            lblCode提.Text = "提";
            // 
            // txtRemark提
            // 
            txtRemark提.Font = new Font("微軟正黑體", 10F);
            txtRemark提.Location = new Point(408, 60);
            txtRemark提.Name = "txtRemark提";
            txtRemark提.Size = new Size(400, 25);
            txtRemark提.TabIndex = 12;
            // 
            // lbl勞動安全與職工福利
            // 
            lbl勞動安全與職工福利.Font = new Font("微軟正黑體", 10F);
            lbl勞動安全與職工福利.Location = new Point(8, 93);
            lbl勞動安全與職工福利.Name = "lbl勞動安全與職工福利";
            lbl勞動安全與職工福利.Size = new Size(280, 20);
            lbl勞動安全與職工福利.TabIndex = 13;
            lbl勞動安全與職工福利.Text = "勞動安全與職工福利";
            // 
            // txt勞動安全與職工福利
            // 
            txt勞動安全與職工福利.Font = new Font("微軟正黑體", 10F);
            txt勞動安全與職工福利.Location = new Point(296, 90);
            txt勞動安全與職工福利.Name = "txt勞動安全與職工福利";
            txt勞動安全與職工福利.Size = new Size(70, 25);
            txt勞動安全與職工福利.TabIndex = 14;
            txt勞動安全與職工福利.TextAlign = HorizontalAlignment.Center;
            txt勞動安全與職工福利.TextChanged += ScoreBox_TextChanged;
            // 
            // lblCode勞
            // 
            lblCode勞.AutoSize = true;
            lblCode勞.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblCode勞.Location = new Point(384, 93);
            lblCode勞.Name = "lblCode勞";
            lblCode勞.Size = new Size(22, 18);
            lblCode勞.TabIndex = 15;
            lblCode勞.Text = "勞";
            // 
            // txtRemark勞
            // 
            txtRemark勞.Font = new Font("微軟正黑體", 10F);
            txtRemark勞.Location = new Point(408, 90);
            txtRemark勞.Name = "txtRemark勞";
            txtRemark勞.Size = new Size(400, 25);
            txtRemark勞.TabIndex = 16;
            // 
            // lbl能迅速處理客戶抱怨
            // 
            lbl能迅速處理客戶抱怨.Font = new Font("微軟正黑體", 10F);
            lbl能迅速處理客戶抱怨.Location = new Point(8, 123);
            lbl能迅速處理客戶抱怨.Name = "lbl能迅速處理客戶抱怨";
            lbl能迅速處理客戶抱怨.Size = new Size(280, 20);
            lbl能迅速處理客戶抱怨.TabIndex = 17;
            lbl能迅速處理客戶抱怨.Text = "能迅速處理客戶抱怨";
            // 
            // txt能迅速處理客戶抱怨
            // 
            txt能迅速處理客戶抱怨.Font = new Font("微軟正黑體", 10F);
            txt能迅速處理客戶抱怨.Location = new Point(296, 120);
            txt能迅速處理客戶抱怨.Name = "txt能迅速處理客戶抱怨";
            txt能迅速處理客戶抱怨.Size = new Size(70, 25);
            txt能迅速處理客戶抱怨.TabIndex = 18;
            txt能迅速處理客戶抱怨.TextAlign = HorizontalAlignment.Center;
            txt能迅速處理客戶抱怨.TextChanged += ScoreBox_TextChanged;
            // 
            // lblCode能
            // 
            lblCode能.AutoSize = true;
            lblCode能.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblCode能.Location = new Point(384, 123);
            lblCode能.Name = "lblCode能";
            lblCode能.Size = new Size(22, 18);
            lblCode能.TabIndex = 19;
            lblCode能.Text = "能";
            // 
            // txtRemark能
            // 
            txtRemark能.Font = new Font("微軟正黑體", 10F);
            txtRemark能.Location = new Point(408, 120);
            txtRemark能.Name = "txtRemark能";
            txtRemark能.Size = new Size(400, 25);
            txtRemark能.TabIndex = 20;
            // 
            // lbl設備的產能與準確度
            // 
            lbl設備的產能與準確度.Font = new Font("微軟正黑體", 10F);
            lbl設備的產能與準確度.Location = new Point(8, 153);
            lbl設備的產能與準確度.Name = "lbl設備的產能與準確度";
            lbl設備的產能與準確度.Size = new Size(280, 20);
            lbl設備的產能與準確度.TabIndex = 21;
            lbl設備的產能與準確度.Text = "設備的產能與準確度";
            // 
            // txt設備的產能與準確度
            // 
            txt設備的產能與準確度.Font = new Font("微軟正黑體", 10F);
            txt設備的產能與準確度.Location = new Point(296, 150);
            txt設備的產能與準確度.Name = "txt設備的產能與準確度";
            txt設備的產能與準確度.Size = new Size(70, 25);
            txt設備的產能與準確度.TabIndex = 22;
            txt設備的產能與準確度.TextAlign = HorizontalAlignment.Center;
            txt設備的產能與準確度.TextChanged += ScoreBox_TextChanged;
            // 
            // lblCode設
            // 
            lblCode設.AutoSize = true;
            lblCode設.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblCode設.Location = new Point(384, 153);
            lblCode設.Name = "lblCode設";
            lblCode設.Size = new Size(22, 18);
            lblCode設.TabIndex = 23;
            lblCode設.Text = "設";
            // 
            // txtRemark設
            // 
            txtRemark設.Font = new Font("微軟正黑體", 10F);
            txtRemark設.Location = new Point(408, 150);
            txtRemark設.Name = "txtRemark設";
            txtRemark設.Size = new Size(400, 25);
            txtRemark設.TabIndex = 24;
            // 
            // lbl足夠的人力資源條件
            // 
            lbl足夠的人力資源條件.Font = new Font("微軟正黑體", 10F);
            lbl足夠的人力資源條件.Location = new Point(8, 183);
            lbl足夠的人力資源條件.Name = "lbl足夠的人力資源條件";
            lbl足夠的人力資源條件.Size = new Size(280, 20);
            lbl足夠的人力資源條件.TabIndex = 25;
            lbl足夠的人力資源條件.Text = "足夠的人力資源條件";
            // 
            // txt足夠的人力資源條件
            // 
            txt足夠的人力資源條件.Font = new Font("微軟正黑體", 10F);
            txt足夠的人力資源條件.Location = new Point(296, 180);
            txt足夠的人力資源條件.Name = "txt足夠的人力資源條件";
            txt足夠的人力資源條件.Size = new Size(70, 25);
            txt足夠的人力資源條件.TabIndex = 26;
            txt足夠的人力資源條件.TextAlign = HorizontalAlignment.Center;
            txt足夠的人力資源條件.TextChanged += ScoreBox_TextChanged;
            // 
            // lblCode足
            // 
            lblCode足.AutoSize = true;
            lblCode足.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblCode足.Location = new Point(384, 183);
            lblCode足.Name = "lblCode足";
            lblCode足.Size = new Size(22, 18);
            lblCode足.TabIndex = 27;
            lblCode足.Text = "足";
            // 
            // txtRemark足
            // 
            txtRemark足.Font = new Font("微軟正黑體", 10F);
            txtRemark足.Location = new Point(408, 180);
            txtRemark足.Name = "txtRemark足";
            txtRemark足.Size = new Size(400, 25);
            txtRemark足.TabIndex = 28;
            // 
            // lbl產銷接單適當無過載
            // 
            lbl產銷接單適當無過載.Font = new Font("微軟正黑體", 10F);
            lbl產銷接單適當無過載.Location = new Point(8, 213);
            lbl產銷接單適當無過載.Name = "lbl產銷接單適當無過載";
            lbl產銷接單適當無過載.Size = new Size(280, 20);
            lbl產銷接單適當無過載.TabIndex = 29;
            lbl產銷接單適當無過載.Text = "產銷接單適當無過載";
            // 
            // txt產銷接單適當無過載
            // 
            txt產銷接單適當無過載.Font = new Font("微軟正黑體", 10F);
            txt產銷接單適當無過載.Location = new Point(296, 210);
            txt產銷接單適當無過載.Name = "txt產銷接單適當無過載";
            txt產銷接單適當無過載.Size = new Size(70, 25);
            txt產銷接單適當無過載.TabIndex = 30;
            txt產銷接單適當無過載.TextAlign = HorizontalAlignment.Center;
            txt產銷接單適當無過載.TextChanged += ScoreBox_TextChanged;
            // 
            // lblCode產
            // 
            lblCode產.AutoSize = true;
            lblCode產.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblCode產.Location = new Point(384, 213);
            lblCode產.Name = "lblCode產";
            lblCode產.Size = new Size(22, 18);
            lblCode產.TabIndex = 31;
            lblCode產.Text = "產";
            // 
            // txtRemark產
            // 
            txtRemark產.Font = new Font("微軟正黑體", 10F);
            txtRemark產.Location = new Point(408, 210);
            txtRemark產.Name = "txtRemark產";
            txtRemark產.Size = new Size(400, 25);
            txtRemark產.TabIndex = 32;
            // 
            // lbl健全的產品驗證系統
            // 
            lbl健全的產品驗證系統.Font = new Font("微軟正黑體", 10F);
            lbl健全的產品驗證系統.Location = new Point(8, 243);
            lbl健全的產品驗證系統.Name = "lbl健全的產品驗證系統";
            lbl健全的產品驗證系統.Size = new Size(280, 20);
            lbl健全的產品驗證系統.TabIndex = 33;
            lbl健全的產品驗證系統.Text = "健全的產品驗證系統";
            // 
            // txt健全的產品驗證系統
            // 
            txt健全的產品驗證系統.Font = new Font("微軟正黑體", 10F);
            txt健全的產品驗證系統.Location = new Point(296, 240);
            txt健全的產品驗證系統.Name = "txt健全的產品驗證系統";
            txt健全的產品驗證系統.Size = new Size(70, 25);
            txt健全的產品驗證系統.TabIndex = 34;
            txt健全的產品驗證系統.TextAlign = HorizontalAlignment.Center;
            txt健全的產品驗證系統.TextChanged += ScoreBox_TextChanged;
            // 
            // lblCode健
            // 
            lblCode健.AutoSize = true;
            lblCode健.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblCode健.Location = new Point(384, 243);
            lblCode健.Name = "lblCode健";
            lblCode健.Size = new Size(22, 18);
            lblCode健.TabIndex = 35;
            lblCode健.Text = "健";
            // 
            // txtRemark健
            // 
            txtRemark健.Font = new Font("微軟正黑體", 10F);
            txtRemark健.Location = new Point(408, 240);
            txtRemark健.Name = "txtRemark健";
            txtRemark健.Size = new Size(400, 25);
            txtRemark健.TabIndex = 36;
            // 
            // lbl符合訂單的品質要求
            // 
            lbl符合訂單的品質要求.Font = new Font("微軟正黑體", 10F);
            lbl符合訂單的品質要求.Location = new Point(8, 273);
            lbl符合訂單的品質要求.Name = "lbl符合訂單的品質要求";
            lbl符合訂單的品質要求.Size = new Size(280, 20);
            lbl符合訂單的品質要求.TabIndex = 37;
            lbl符合訂單的品質要求.Text = "符合訂單的品質要求";
            // 
            // txt符合訂單的品質要求
            // 
            txt符合訂單的品質要求.Font = new Font("微軟正黑體", 10F);
            txt符合訂單的品質要求.Location = new Point(296, 270);
            txt符合訂單的品質要求.Name = "txt符合訂單的品質要求";
            txt符合訂單的品質要求.Size = new Size(70, 25);
            txt符合訂單的品質要求.TabIndex = 38;
            txt符合訂單的品質要求.TextAlign = HorizontalAlignment.Center;
            txt符合訂單的品質要求.TextChanged += ScoreBox_TextChanged;
            // 
            // lblCode符
            // 
            lblCode符.AutoSize = true;
            lblCode符.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblCode符.Location = new Point(384, 273);
            lblCode符.Name = "lblCode符";
            lblCode符.Size = new Size(22, 18);
            lblCode符.TabIndex = 39;
            lblCode符.Text = "符";
            // 
            // txtRemark符
            // 
            txtRemark符.Font = new Font("微軟正黑體", 10F);
            txtRemark符.Location = new Point(408, 270);
            txtRemark符.Name = "txtRemark符";
            txtRemark符.Size = new Size(400, 25);
            txtRemark符.TabIndex = 40;
            // 
            // lbl依產品標準進行檢測
            // 
            lbl依產品標準進行檢測.Font = new Font("微軟正黑體", 10F);
            lbl依產品標準進行檢測.Location = new Point(8, 303);
            lbl依產品標準進行檢測.Name = "lbl依產品標準進行檢測";
            lbl依產品標準進行檢測.Size = new Size(280, 20);
            lbl依產品標準進行檢測.TabIndex = 41;
            lbl依產品標準進行檢測.Text = "依產品標準進行檢測";
            // 
            // txt依產品標準進行檢測
            // 
            txt依產品標準進行檢測.Font = new Font("微軟正黑體", 10F);
            txt依產品標準進行檢測.Location = new Point(296, 300);
            txt依產品標準進行檢測.Name = "txt依產品標準進行檢測";
            txt依產品標準進行檢測.Size = new Size(70, 25);
            txt依產品標準進行檢測.TabIndex = 42;
            txt依產品標準進行檢測.TextAlign = HorizontalAlignment.Center;
            txt依產品標準進行檢測.TextChanged += ScoreBox_TextChanged;
            // 
            // lblCode依
            // 
            lblCode依.AutoSize = true;
            lblCode依.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblCode依.Location = new Point(384, 303);
            lblCode依.Name = "lblCode依";
            lblCode依.Size = new Size(22, 18);
            lblCode依.TabIndex = 43;
            lblCode依.Text = "依";
            // 
            // txtRemark依
            // 
            txtRemark依.Font = new Font("微軟正黑體", 10F);
            txtRemark依.Location = new Point(408, 300);
            txtRemark依.Name = "txtRemark依";
            txtRemark依.Size = new Size(400, 25);
            txtRemark依.TabIndex = 44;
            // 
            // panelFooter
            // 
            panelFooter.BackColor = Color.FromArgb(230, 230, 250);
            panelFooter.Controls.Add(txtModifyDate);
            panelFooter.Controls.Add(txtModifier);
            panelFooter.Controls.Add(lbl修改F);
            panelFooter.Controls.Add(txtCreateDate);
            panelFooter.Controls.Add(txtCreator);
            panelFooter.Controls.Add(lbl建檔F);
            panelFooter.Controls.Add(txtApproveDate);
            panelFooter.Controls.Add(txtApprover);
            panelFooter.Controls.Add(lbl核准F);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 732);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(1497, 32);
            panelFooter.TabIndex = 4;
            // 
            // txtModifyDate
            // 
            txtModifyDate.BackColor = Color.WhiteSmoke;
            txtModifyDate.Font = new Font("微軟正黑體", 9F);
            txtModifyDate.Location = new Point(696, 5);
            txtModifyDate.Name = "txtModifyDate";
            txtModifyDate.ReadOnly = true;
            txtModifyDate.Size = new Size(110, 23);
            txtModifyDate.TabIndex = 0;
            // 
            // txtModifier
            // 
            txtModifier.BackColor = Color.WhiteSmoke;
            txtModifier.Font = new Font("微軟正黑體", 9F);
            txtModifier.Location = new Point(582, 5);
            txtModifier.Name = "txtModifier";
            txtModifier.ReadOnly = true;
            txtModifier.Size = new Size(110, 23);
            txtModifier.TabIndex = 1;
            // 
            // lbl修改F
            // 
            lbl修改F.AutoSize = true;
            lbl修改F.Font = new Font("微軟正黑體", 9F);
            lbl修改F.Location = new Point(548, 8);
            lbl修改F.Name = "lbl修改F";
            lbl修改F.Size = new Size(31, 16);
            lbl修改F.TabIndex = 2;
            lbl修改F.Text = "修改";
            // 
            // txtCreateDate
            // 
            txtCreateDate.BackColor = Color.WhiteSmoke;
            txtCreateDate.Font = new Font("微軟正黑體", 9F);
            txtCreateDate.Location = new Point(428, 5);
            txtCreateDate.Name = "txtCreateDate";
            txtCreateDate.ReadOnly = true;
            txtCreateDate.Size = new Size(110, 23);
            txtCreateDate.TabIndex = 3;
            // 
            // txtCreator
            // 
            txtCreator.BackColor = Color.WhiteSmoke;
            txtCreator.Font = new Font("微軟正黑體", 9F);
            txtCreator.Location = new Point(314, 5);
            txtCreator.Name = "txtCreator";
            txtCreator.ReadOnly = true;
            txtCreator.Size = new Size(110, 23);
            txtCreator.TabIndex = 4;
            // 
            // lbl建檔F
            // 
            lbl建檔F.AutoSize = true;
            lbl建檔F.Font = new Font("微軟正黑體", 9F);
            lbl建檔F.Location = new Point(280, 8);
            lbl建檔F.Name = "lbl建檔F";
            lbl建檔F.Size = new Size(31, 16);
            lbl建檔F.TabIndex = 5;
            lbl建檔F.Text = "建檔";
            // 
            // txtApproveDate
            // 
            txtApproveDate.BackColor = Color.WhiteSmoke;
            txtApproveDate.Font = new Font("微軟正黑體", 9F);
            txtApproveDate.Location = new Point(156, 5);
            txtApproveDate.Name = "txtApproveDate";
            txtApproveDate.ReadOnly = true;
            txtApproveDate.Size = new Size(110, 23);
            txtApproveDate.TabIndex = 6;
            // 
            // txtApprover
            // 
            txtApprover.BackColor = Color.WhiteSmoke;
            txtApprover.Font = new Font("微軟正黑體", 9F);
            txtApprover.Location = new Point(42, 5);
            txtApprover.Name = "txtApprover";
            txtApprover.ReadOnly = true;
            txtApprover.Size = new Size(110, 23);
            txtApprover.TabIndex = 7;
            // 
            // lbl核准F
            // 
            lbl核准F.AutoSize = true;
            lbl核准F.Font = new Font("微軟正黑體", 9F);
            lbl核准F.Location = new Point(8, 8);
            lbl核准F.Name = "lbl核准F";
            lbl核准F.Size = new Size(31, 16);
            lbl核准F.TabIndex = 8;
            lbl核准F.Text = "核准";
            // 
            // SupplierEvaluateMaintainControl
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelScore);
            Controls.Add(panelScoreHeader);
            Controls.Add(panelFooter);
            Controls.Add(panelHeader);
            Controls.Add(panelToolbar);
            Font = new Font("微軟正黑體", 10F);
            Margin = new Padding(4);
            Name = "SupplierEvaluateMaintainControl";
            Size = new Size(1497, 764);
            panelToolbar.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelScoreHeader.ResumeLayout(false);
            panelScoreHeader.PerformLayout();
            panelScore.ResumeLayout(false);
            panelScore.PerformLayout();
            panelFooter.ResumeLayout(false);
            panelFooter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelToolbar;
        private Label lblMode;
        private Button btnDelete;
        private Button btnAdd;
        private Button btnModify;
        private Button btnSave;
        private Button btnApprove;
        private Button btnCancelApprove;
        private Button btnPrint;
        private Button btnOverview;
        private Button btnBack;

        private Panel panelHeader;
        private Label lblDate;
        private DateTimePicker dtpDate;
        private Label lblFormNo;
        private TextBox txtFormNo;
        private Label lblSupplierNo;
        private TextBox txtSupplierNo;
        private Button btnPickSupplier;
        private Label lblShortName;
        private TextBox txtShortName;
        private Label lblEvaluator;
        private ComboBox cboEvaluator;
        private Label lblTaxNo;
        private TextBox txtTaxNo;
        private Label lblIndustry;
        private TextBox txtIndustry;
        private Label lblSupplierName;
        private TextBox txtSupplierName;
        private Label lblReviewer;
        private ComboBox cboReviewer;
        private Label lblFactoryAddr;
        private TextBox txtFactoryAddr;
        private Label lblCompanyAddr;
        private TextBox txtCompanyAddr;
        private Label lblReviewDate;
        private DateTimePicker dtpReviewDate;

        private Panel panelScoreHeader;
        private Label lblScoreTitle;

        private Panel panelScore;
        private Label lblCapCriteria;
        private Label lblCapScore;
        private Label lblCapRemark;

        private Label lbl達成客戶要求的能力;
        private TextBox txt達成客戶要求的能力;
        private Label lblCode達;
        private TextBox txtRemark達;
        private Label lbl提升經營效能的企圖;
        private TextBox txt提升經營效能的企圖;
        private Label lblCode提;
        private TextBox txtRemark提;
        private Label lbl勞動安全與職工福利;
        private TextBox txt勞動安全與職工福利;
        private Label lblCode勞;
        private TextBox txtRemark勞;
        private Label lbl能迅速處理客戶抱怨;
        private TextBox txt能迅速處理客戶抱怨;
        private Label lblCode能;
        private TextBox txtRemark能;
        private Label lbl設備的產能與準確度;
        private TextBox txt設備的產能與準確度;
        private Label lblCode設;
        private TextBox txtRemark設;
        private Label lbl足夠的人力資源條件;
        private TextBox txt足夠的人力資源條件;
        private Label lblCode足;
        private TextBox txtRemark足;
        private Label lbl產銷接單適當無過載;
        private TextBox txt產銷接單適當無過載;
        private Label lblCode產;
        private TextBox txtRemark產;
        private Label lbl健全的產品驗證系統;
        private TextBox txt健全的產品驗證系統;
        private Label lblCode健;
        private TextBox txtRemark健;
        private Label lbl符合訂單的品質要求;
        private TextBox txt符合訂單的品質要求;
        private Label lblCode符;
        private TextBox txtRemark符;
        private Label lbl依產品標準進行檢測;
        private TextBox txt依產品標準進行檢測;
        private Label lblCode依;
        private TextBox txtRemark依;

        private Label lblTotal;
        private Label lblTotalValue;

        private Panel panelFooter;
        private Label lbl核准F;
        private TextBox txtApprover;
        private TextBox txtApproveDate;
        private Label lbl建檔F;
        private TextBox txtCreator;
        private TextBox txtCreateDate;
        private Label lbl修改F;
        private TextBox txtModifier;
        private TextBox txtModifyDate;
    }
}
