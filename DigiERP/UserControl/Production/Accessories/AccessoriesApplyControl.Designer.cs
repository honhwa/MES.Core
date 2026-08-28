using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.Production.Accessories
{
    partial class AccessoriesApplyControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼
        //
        // 版面比照 PITS-2025.accdb「P-零件申請單」及其子表單「P-零件申請明細」
        // 之控制項座標(twips/15=px)還原。配色亦比照原表單：表單首/尾為淡黃綠
        // RGB(242,254,214)，詳細資料區為白色 ─────────────────────────────
        //
        private void InitializeComponent()
        {
            panelHeader = new Panel();
            lblTitle = new Label();
            btnQueryParts = new Button();
            btnVoid = new Button();
            btnEdit = new Button();
            btnSave = new Button();
            btnApprove = new Button();
            btnUnapprove = new Button();
            btnPrint = new Button();
            btnOverview = new Button();
            btnExit = new Button();
            lbl申請用途 = new Label();
            cmb申請用途 = new ComboBox();
            lbl申請日期 = new Label();
            dt申請日期 = new DateTimePicker();
            lbl單號 = new Label();
            txt單號 = new TextBox();
            lbl收費機制 = new Label();
            cmb收費機制 = new ComboBox();
            lbl客戶編號 = new Label();
            txt客戶編號 = new TextBox();
            txt客戶簡稱 = new TextBox();
            btnPickCustomer = new Button();
            lbl專案序號 = new Label();
            cmb專案序號 = new ComboBox();
            lbl機台型號 = new Label();
            txt機台型號 = new TextBox();
            lbl機台名稱 = new Label();
            txt機台名稱 = new TextBox();
            lbl運送方式 = new Label();
            cmb運送方式 = new ComboBox();
            lbl交貨日期 = new Label();
            dt交貨日期 = new DateTimePicker();
            lbl保固效期 = new Label();
            dt保固效期 = new DateTimePicker();
            lbl主旨 = new Label();
            txt主旨 = new TextBox();
            lbl申請人 = new Label();
            cmb申請人 = new ComboBox();
            btnPaymentProgress = new Button();
            panelBody = new Panel();
            dataGridView1 = new DataGridView();
            colPartType = new DataGridViewComboBoxColumn();
            colPartNo = new DataGridViewTextBoxColumn();
            colItemName = new DataGridViewTextBoxColumn();
            colDesc = new DataGridViewTextBoxColumn();
            colUnit = new DataGridViewTextBoxColumn();
            colQty = new DataGridViewTextBoxColumn();
            colOwner = new DataGridViewTextBoxColumn();
            colRemark = new DataGridViewTextBoxColumn();
            panelFooter = new Panel();
            lblF核准人員 = new Label();
            txtF核准 = new TextBox();
            txtF核准日 = new TextBox();
            lblF修改人員 = new Label();
            txtF修改 = new TextBox();
            txtF修改日 = new TextBox();
            lblF建檔人員 = new Label();
            txtF建檔 = new TextBox();
            txtF建檔日 = new TextBox();
            panelHeader.SuspendLayout();
            panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelFooter.SuspendLayout();
            SuspendLayout();
            //
            // panelHeader
            //
            panelHeader.BackColor = Color.FromArgb(242, 254, 214);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Controls.Add(btnQueryParts);
            panelHeader.Controls.Add(btnVoid);
            panelHeader.Controls.Add(btnEdit);
            panelHeader.Controls.Add(btnSave);
            panelHeader.Controls.Add(btnApprove);
            panelHeader.Controls.Add(btnUnapprove);
            panelHeader.Controls.Add(btnPrint);
            panelHeader.Controls.Add(btnOverview);
            panelHeader.Controls.Add(btnExit);
            panelHeader.Controls.Add(lbl申請用途);
            panelHeader.Controls.Add(cmb申請用途);
            panelHeader.Controls.Add(lbl申請日期);
            panelHeader.Controls.Add(dt申請日期);
            panelHeader.Controls.Add(lbl單號);
            panelHeader.Controls.Add(txt單號);
            panelHeader.Controls.Add(lbl收費機制);
            panelHeader.Controls.Add(cmb收費機制);
            panelHeader.Controls.Add(lbl客戶編號);
            panelHeader.Controls.Add(txt客戶編號);
            panelHeader.Controls.Add(txt客戶簡稱);
            panelHeader.Controls.Add(btnPickCustomer);
            panelHeader.Controls.Add(lbl專案序號);
            panelHeader.Controls.Add(cmb專案序號);
            panelHeader.Controls.Add(lbl機台型號);
            panelHeader.Controls.Add(txt機台型號);
            panelHeader.Controls.Add(lbl機台名稱);
            panelHeader.Controls.Add(txt機台名稱);
            panelHeader.Controls.Add(lbl運送方式);
            panelHeader.Controls.Add(cmb運送方式);
            panelHeader.Controls.Add(lbl交貨日期);
            panelHeader.Controls.Add(dt交貨日期);
            panelHeader.Controls.Add(lbl保固效期);
            panelHeader.Controls.Add(dt保固效期);
            panelHeader.Controls.Add(lbl主旨);
            panelHeader.Controls.Add(txt主旨);
            panelHeader.Controls.Add(lbl申請人);
            panelHeader.Controls.Add(cmb申請人);
            panelHeader.Controls.Add(btnPaymentProgress);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1380, 220);
            panelHeader.TabIndex = 0;
            //
            // lblTitle
            //
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("微軟正黑體", 12F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(69, 98, 135);
            lblTitle.Location = new Point(11, 8);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(110, 24);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "零件申請單";
            //
            // btnQueryParts (原Command117"查詢客戶專案機台零件")
            //
            btnQueryParts.BackColor = Color.FromArgb(69, 98, 135);
            btnQueryParts.FlatStyle = FlatStyle.Flat;
            btnQueryParts.ForeColor = Color.White;
            btnQueryParts.Font = new Font("微軟正黑體", 8F, FontStyle.Bold);
            btnQueryParts.Location = new Point(250, 8);
            btnQueryParts.Name = "btnQueryParts";
            btnQueryParts.Size = new Size(159, 27);
            btnQueryParts.TabIndex = 1;
            btnQueryParts.Text = "查詢客戶專案機台零件";
            btnQueryParts.UseVisualStyleBackColor = false;
            btnQueryParts.Click += btnQueryParts_Click;
            //
            // btnVoid (原Command136"紀錄作廢")
            //
            btnVoid.BackColor = Color.Firebrick;
            btnVoid.FlatStyle = FlatStyle.Flat;
            btnVoid.ForeColor = Color.White;
            btnVoid.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnVoid.Location = new Point(483, 8);
            btnVoid.Name = "btnVoid";
            btnVoid.Size = new Size(72, 27);
            btnVoid.TabIndex = 2;
            btnVoid.Text = "紀錄作廢";
            btnVoid.UseVisualStyleBackColor = false;
            btnVoid.Click += btnVoid_Click;
            //
            // btnEdit (原Command276"修改")
            //
            btnEdit.BackColor = Color.SteelBlue;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.ForeColor = Color.White;
            btnEdit.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnEdit.Location = new Point(607, 8);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(49, 27);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "修改";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            //
            // btnSave (原Command363"儲存")
            //
            btnSave.BackColor = Color.SteelBlue;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnSave.Location = new Point(709, 8);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(49, 27);
            btnSave.TabIndex = 4;
            btnSave.Text = "儲存";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            //
            // btnApprove (原"生效")
            //
            btnApprove.BackColor = Color.SteelBlue;
            btnApprove.FlatStyle = FlatStyle.Flat;
            btnApprove.ForeColor = Color.White;
            btnApprove.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnApprove.Location = new Point(810, 8);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(49, 27);
            btnApprove.TabIndex = 5;
            btnApprove.Text = "生效";
            btnApprove.UseVisualStyleBackColor = false;
            btnApprove.Click += btnApprove_Click;
            //
            // btnUnapprove (原Command361"取消生效")
            //
            btnUnapprove.BackColor = Color.SteelBlue;
            btnUnapprove.FlatStyle = FlatStyle.Flat;
            btnUnapprove.ForeColor = Color.White;
            btnUnapprove.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnUnapprove.Location = new Point(911, 8);
            btnUnapprove.Name = "btnUnapprove";
            btnUnapprove.Size = new Size(69, 27);
            btnUnapprove.TabIndex = 6;
            btnUnapprove.Text = "取消生效";
            btnUnapprove.UseVisualStyleBackColor = false;
            btnUnapprove.Click += btnUnapprove_Click;
            //
            // btnPrint (原Command322"列印")
            //
            btnPrint.BackColor = Color.SteelBlue;
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.ForeColor = Color.White;
            btnPrint.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnPrint.Location = new Point(1033, 8);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(49, 27);
            btnPrint.TabIndex = 7;
            btnPrint.Text = "列印";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            //
            // btnOverview (原"總覽")
            //
            btnOverview.BackColor = Color.SteelBlue;
            btnOverview.FlatStyle = FlatStyle.Flat;
            btnOverview.ForeColor = Color.White;
            btnOverview.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnOverview.Location = new Point(1134, 8);
            btnOverview.Name = "btnOverview";
            btnOverview.Size = new Size(49, 27);
            btnOverview.TabIndex = 8;
            btnOverview.Text = "總覽";
            btnOverview.UseVisualStyleBackColor = false;
            btnOverview.Click += btnOverview_Click;
            //
            // btnExit (原Command362"關閉")
            //
            btnExit.BackColor = Color.SteelBlue;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.ForeColor = Color.White;
            btnExit.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnExit.Location = new Point(1236, 8);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(49, 27);
            btnExit.TabIndex = 9;
            btnExit.Text = "關閉";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            //
            // Row1 (y=40): 申請用途 / 申請日期 / 單號 / 收費機制
            //
            lbl申請用途.AutoSize = false; lbl申請用途.Location = new Point(11, 40); lbl申請用途.Size = new Size(72, 21);
            lbl申請用途.Text = "申請用途"; lbl申請用途.TextAlign = ContentAlignment.MiddleLeft;
            cmb申請用途.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb申請用途.Items.AddRange(new object[] { "專案增購", "廠驗追加", "售後維修", "客戶訂購", "安全庫存", "研發用途", "受託代工", "買賣批發" });
            cmb申請用途.Location = new Point(91, 40); cmb申請用途.Size = new Size(302, 23);

            lbl申請日期.AutoSize = false; lbl申請日期.Location = new Point(462, 40); lbl申請日期.Size = new Size(70, 21);
            lbl申請日期.Text = "申請日期"; lbl申請日期.TextAlign = ContentAlignment.MiddleLeft;
            dt申請日期.Format = DateTimePickerFormat.Short; dt申請日期.Location = new Point(537, 40); dt申請日期.Size = new Size(189, 23);

            lbl單號.AutoSize = false; lbl單號.Location = new Point(783, 40); lbl單號.Size = new Size(70, 21);
            lbl單號.Text = "單號"; lbl單號.TextAlign = ContentAlignment.MiddleLeft;
            txt單號.Location = new Point(862, 40); txt單號.Size = new Size(177, 23); txt單號.ReadOnly = true; txt單號.BackColor = SystemColors.Control;

            lbl收費機制.AutoSize = false; lbl收費機制.Location = new Point(1085, 40); lbl收費機制.Size = new Size(70, 21);
            lbl收費機制.Text = "收費機制"; lbl收費機制.TextAlign = ContentAlignment.MiddleLeft;
            cmb收費機制.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb收費機制.Items.AddRange(new object[] { "不收費:保固效期內", "不收費:特案處理", "不收費:廠內驗機追加", "收費:廠內驗機追加", "收費:超過保固期", "收費:客戶自行汰換", "收費:定期維修計畫" });
            cmb收費機制.Location = new Point(1160, 40); cmb收費機制.Size = new Size(201, 23);
            //
            // Row2 (y=70): 客戶編號 / 客戶簡稱 / 挑選按鈕 / 專案序號 / 機台型號
            //
            lbl客戶編號.AutoSize = false; lbl客戶編號.Location = new Point(11, 70); lbl客戶編號.Size = new Size(72, 21);
            lbl客戶編號.Text = "客戶編號"; lbl客戶編號.TextAlign = ContentAlignment.MiddleLeft;
            txt客戶編號.Location = new Point(91, 70); txt客戶編號.Size = new Size(76, 23);
            txt客戶簡稱.Location = new Point(170, 70); txt客戶簡稱.Size = new Size(556, 23);
            btnPickCustomer.FlatStyle = FlatStyle.Flat; btnPickCustomer.BackColor = Color.LightGray;
            btnPickCustomer.Location = new Point(737, 70); btnPickCustomer.Size = new Size(26, 23); btnPickCustomer.Text = "…";
            btnPickCustomer.TabIndex = 20; btnPickCustomer.UseVisualStyleBackColor = false; btnPickCustomer.Click += btnPickCustomer_Click;

            lbl專案序號.AutoSize = false; lbl專案序號.Location = new Point(784, 70); lbl專案序號.Size = new Size(70, 21);
            lbl專案序號.Text = "專案序號"; lbl專案序號.TextAlign = ContentAlignment.MiddleLeft;
            cmb專案序號.DropDownStyle = ComboBoxStyle.DropDown;
            cmb專案序號.Location = new Point(862, 70); cmb專案序號.Size = new Size(177, 23);

            lbl機台型號.AutoSize = false; lbl機台型號.Location = new Point(1085, 70); lbl機台型號.Size = new Size(70, 21);
            lbl機台型號.Text = "機台型號"; lbl機台型號.TextAlign = ContentAlignment.MiddleLeft;
            txt機台型號.Location = new Point(1160, 70); txt機台型號.Size = new Size(201, 23);
            //
            // Row3 (y=100): 機台名稱 / 運送方式 / 交貨日期 / 保固效期
            //
            lbl機台名稱.AutoSize = false; lbl機台名稱.Location = new Point(11, 100); lbl機台名稱.Size = new Size(72, 21);
            lbl機台名稱.Text = "機台名稱"; lbl機台名稱.TextAlign = ContentAlignment.MiddleLeft;
            txt機台名稱.Location = new Point(91, 100); txt機台名稱.Size = new Size(301, 23);

            lbl運送方式.AutoSize = false; lbl運送方式.Location = new Point(462, 100); lbl運送方式.Size = new Size(70, 21);
            lbl運送方式.Text = "運送方式"; lbl運送方式.TextAlign = ContentAlignment.MiddleLeft;
            cmb運送方式.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb運送方式.Items.AddRange(new object[] { "貨運:大慶自付", "貨運:客戶到付", "自行載運:大慶", "自行載運:客戶" });
            cmb運送方式.Location = new Point(536, 100); cmb運送方式.Size = new Size(190, 23);

            lbl交貨日期.AutoSize = false; lbl交貨日期.Location = new Point(783, 100); lbl交貨日期.Size = new Size(70, 21);
            lbl交貨日期.Text = "交貨日期"; lbl交貨日期.TextAlign = ContentAlignment.MiddleLeft;
            dt交貨日期.Format = DateTimePickerFormat.Short; dt交貨日期.Location = new Point(861, 100); dt交貨日期.Size = new Size(178, 23);

            lbl保固效期.AutoSize = false; lbl保固效期.Location = new Point(1085, 100); lbl保固效期.Size = new Size(70, 21);
            lbl保固效期.Text = "保固效期"; lbl保固效期.TextAlign = ContentAlignment.MiddleLeft;
            dt保固效期.Format = DateTimePickerFormat.Short; dt保固效期.Location = new Point(1160, 100); dt保固效期.Size = new Size(201, 23);
            //
            // Row4 (y=130): 狀況說明(主旨,多行) / 申請人
            //
            lbl主旨.AutoSize = false; lbl主旨.Location = new Point(11, 130); lbl主旨.Size = new Size(72, 21);
            lbl主旨.Text = "狀況說明"; lbl主旨.TextAlign = ContentAlignment.MiddleLeft;
            txt主旨.Multiline = true; txt主旨.Location = new Point(91, 130); txt主旨.Size = new Size(949, 56);

            lbl申請人.AutoSize = false; lbl申請人.Location = new Point(1084, 130); lbl申請人.Size = new Size(70, 21);
            lbl申請人.Text = "申請人"; lbl申請人.TextAlign = ContentAlignment.MiddleLeft;
            cmb申請人.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb申請人.Location = new Point(1159, 130); cmb申請人.Size = new Size(201, 23);
            //
            // btnPaymentProgress (原Command137"收款進度查詢")
            //
            btnPaymentProgress.FlatStyle = FlatStyle.Flat;
            btnPaymentProgress.BackColor = Color.LightGray;
            btnPaymentProgress.Font = new Font("微軟正黑體", 8F);
            btnPaymentProgress.Location = new Point(1159, 190); btnPaymentProgress.Size = new Size(110, 23);
            btnPaymentProgress.Text = "收款進度查詢"; btnPaymentProgress.TabIndex = 30;
            btnPaymentProgress.UseVisualStyleBackColor = false;
            btnPaymentProgress.Click += btnPaymentProgress_Click;
            //
            // panelBody (子表單「P-零件申請明細」)
            //
            panelBody.BackColor = Color.White;
            panelBody.Dock = DockStyle.Fill;
            panelBody.Location = new Point(0, 220);
            panelBody.Name = "panelBody";
            panelBody.Size = new Size(1380, 300);
            panelBody.TabIndex = 1;
            panelBody.Controls.Add(dataGridView1);
            //
            // dataGridView1
            //
            dataGridView1.AllowUserToAddRows = true;
            dataGridView1.AllowUserToDeleteRows = true;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colPartType, colPartNo, colItemName, colDesc, colUnit, colQty, colOwner, colRemark });
            dataGridView1.Font = new Font("微軟正黑體", 9F);
            dataGridView1.Location = new Point(11, 11);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 26;
            dataGridView1.Size = new Size(1358, 278);
            dataGridView1.TabIndex = 0;
            dataGridView1.DataError += dataGridView1_DataError;
            //
            // colPartType (原Label"零件分類")
            //
            colPartType.HeaderText = "零件分類"; colPartType.Name = "colPartType"; colPartType.Width = 91;
            colPartType.Items.AddRange(new object[] { "市購品", "庫存品", "自製/需購料", "自製/在庫料" });
            //
            // colPartNo (原Label"零件號碼")
            //
            colPartNo.HeaderText = "零件號碼"; colPartNo.Name = "colPartNo"; colPartNo.Width = 166;
            //
            // colItemName (原Label"品名")
            //
            colItemName.HeaderText = "品名"; colItemName.Name = "colItemName"; colItemName.Width = 250;
            //
            // colDesc (原Label"描述")
            //
            colDesc.HeaderText = "描述"; colDesc.Name = "colDesc"; colDesc.Width = 300;
            //
            // colUnit (原Label"單位")
            //
            colUnit.HeaderText = "單位"; colUnit.Name = "colUnit"; colUnit.Width = 55;
            //
            // colQty (原Label"數量")
            //
            colQty.HeaderText = "數量"; colQty.Name = "colQty"; colQty.Width = 55;
            //
            // colOwner (原Label"負責人"，ControlSource=附屬模組)
            //
            colOwner.HeaderText = "負責人"; colOwner.Name = "colOwner"; colOwner.Width = 100;
            //
            // colRemark (原Label"備註")
            //
            colRemark.HeaderText = "備註"; colRemark.Name = "colRemark"; colRemark.Width = 200;
            //
            // panelFooter
            //
            panelFooter.BackColor = Color.FromArgb(242, 254, 214);
            panelFooter.Controls.Add(lblF核准人員);
            panelFooter.Controls.Add(txtF核准);
            panelFooter.Controls.Add(txtF核准日);
            panelFooter.Controls.Add(lblF修改人員);
            panelFooter.Controls.Add(txtF修改);
            panelFooter.Controls.Add(txtF修改日);
            panelFooter.Controls.Add(lblF建檔人員);
            panelFooter.Controls.Add(txtF建檔);
            panelFooter.Controls.Add(txtF建檔日);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 520);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(1380, 34);
            panelFooter.TabIndex = 2;
            //
            // 核准人員
            //
            lblF核准人員.AutoSize = false; lblF核准人員.Location = new Point(19, 8); lblF核准人員.Size = new Size(72, 21);
            lblF核准人員.Text = "核准人員"; lblF核准人員.TextAlign = ContentAlignment.MiddleLeft;
            txtF核准.Location = new Point(87, 8); txtF核准.Size = new Size(87, 21); txtF核准.ReadOnly = true;
            txtF核准.BorderStyle = BorderStyle.None; txtF核准.BackColor = Color.FromArgb(242, 254, 214);
            txtF核准日.Location = new Point(177, 8); txtF核准日.Size = new Size(162, 21); txtF核准日.ReadOnly = true;
            txtF核准日.BorderStyle = BorderStyle.None; txtF核准日.BackColor = Color.FromArgb(242, 254, 214);
            //
            // 修改人員
            //
            lblF修改人員.AutoSize = false; lblF修改人員.Location = new Point(355, 8); lblF修改人員.Size = new Size(72, 21);
            lblF修改人員.Text = "修改人員"; lblF修改人員.TextAlign = ContentAlignment.MiddleLeft;
            txtF修改.Location = new Point(422, 8); txtF修改.Size = new Size(95, 21); txtF修改.ReadOnly = true;
            txtF修改.BorderStyle = BorderStyle.None; txtF修改.BackColor = Color.FromArgb(242, 254, 214);
            txtF修改日.Location = new Point(520, 8); txtF修改日.Size = new Size(166, 21); txtF修改日.ReadOnly = true;
            txtF修改日.BorderStyle = BorderStyle.None; txtF修改日.BackColor = Color.FromArgb(242, 254, 214);
            //
            // 建檔人員
            //
            lblF建檔人員.AutoSize = false; lblF建檔人員.Location = new Point(707, 8); lblF建檔人員.Size = new Size(72, 21);
            lblF建檔人員.Text = "建檔人員"; lblF建檔人員.TextAlign = ContentAlignment.MiddleLeft;
            txtF建檔.Location = new Point(770, 8); txtF建檔.Size = new Size(95, 21); txtF建檔.ReadOnly = true;
            txtF建檔.BorderStyle = BorderStyle.None; txtF建檔.BackColor = Color.FromArgb(242, 254, 214);
            txtF建檔日.Location = new Point(869, 8); txtF建檔日.Size = new Size(166, 21); txtF建檔日.ReadOnly = true;
            txtF建檔日.BorderStyle = BorderStyle.None; txtF建檔日.BackColor = Color.FromArgb(242, 254, 214);
            //
            // AccessoriesApplyControl
            //
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelBody);
            Controls.Add(panelFooter);
            Controls.Add(panelHeader);
            Font = new Font("微軟正黑體", 9F);
            Margin = new Padding(4);
            Name = "AccessoriesApplyControl";
            Size = new Size(1380, 554);
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
        private Button btnQueryParts;
        private Button btnVoid;
        private Button btnEdit;
        private Button btnSave;
        private Button btnApprove;
        private Button btnUnapprove;
        private Button btnPrint;
        private Button btnOverview;
        private Button btnExit;
        private Label lbl申請用途;
        private ComboBox cmb申請用途;
        private Label lbl申請日期;
        private DateTimePicker dt申請日期;
        private Label lbl單號;
        private TextBox txt單號;
        private Label lbl收費機制;
        private ComboBox cmb收費機制;
        private Label lbl客戶編號;
        private TextBox txt客戶編號;
        private TextBox txt客戶簡稱;
        private Button btnPickCustomer;
        private Label lbl專案序號;
        private ComboBox cmb專案序號;
        private Label lbl機台型號;
        private TextBox txt機台型號;
        private Label lbl機台名稱;
        private TextBox txt機台名稱;
        private Label lbl運送方式;
        private ComboBox cmb運送方式;
        private Label lbl交貨日期;
        private DateTimePicker dt交貨日期;
        private Label lbl保固效期;
        private DateTimePicker dt保固效期;
        private Label lbl主旨;
        private TextBox txt主旨;
        private Label lbl申請人;
        private ComboBox cmb申請人;
        private Button btnPaymentProgress;
        private Panel panelBody;
        private DataGridView dataGridView1;
        private DataGridViewComboBoxColumn colPartType;
        private DataGridViewTextBoxColumn colPartNo;
        private DataGridViewTextBoxColumn colItemName;
        private DataGridViewTextBoxColumn colDesc;
        private DataGridViewTextBoxColumn colUnit;
        private DataGridViewTextBoxColumn colQty;
        private DataGridViewTextBoxColumn colOwner;
        private DataGridViewTextBoxColumn colRemark;
        private Panel panelFooter;
        private Label lblF核准人員;
        private TextBox txtF核准;
        private TextBox txtF核准日;
        private Label lblF修改人員;
        private TextBox txtF修改;
        private TextBox txtF修改日;
        private Label lblF建檔人員;
        private TextBox txtF建檔;
        private TextBox txtF建檔日;
    }
}
