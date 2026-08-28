using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.Production.Accessories
{
    partial class ReceivablesControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼
        //
        // 比照 PITS-2025.accdb「S-專案應收沖款」表單(Caption="專案（零件）應收
        // 沖款")還原，含內嵌子表單「S-專案應收沖款明細」(LinkFields=專案序號)。
        // 版面依 Access 匯出之控制項座標/Caption 對照如下(已修正原設計中發現的
        // 3 組 Label/ControlSource 對應不符)：
        //   - 收款條件：ControlSource 實際存放 付款方式.條文編號(代碼)，畫面另以
        //     DLookUp 帶出 條文名稱；本畫面改以下拉選單直接顯示「代碼 - 名稱」，
        //     省去原本另一個唯讀顯示欄位。
        //   - 客戶簡稱：ControlSource 實際存放 C客戶設定.正航編號(代碼)，
        //     「客戶名稱」由 DLookUp(COMPANY) 帶出，非資料表實際欄位。
        //   - 實際成交價/追加增減額 欄位之畫面標題分別為「訂單成交價」「追認增減
        //     額」(與欄位名稱不同，已依標準作法採信 ControlSource 綁定，僅畫面
        //     文字改用原 Caption)。
        // 「立帳類別」ComboBox RowSource 為固定值清單「機台;零件」。COMMISSION/
        // AGENT 依賴之 dbo_C-QUODATA/佣金AGENT 資料表在 CHINYO 查無對應，維持
        // 空白唯讀。全部控制項座標一律採內嵌常數寫死(不使用自訂輔助方法) ─────────
        //
        private void InitializeComponent()
        {
            panelHeader = new Panel();
            panelFooter = new Panel();
            lblTitle = new Label();
            btnEdit = new Button();
            btnSave = new Button();
            btnPrint = new Button();
            btnOverview = new Button();
            btnExit = new Button();
            lbl專案序號 = new Label(); txt專案序號 = new TextBox();
            lbl收款條件 = new Label(); cmb收款條件 = new ComboBox();
            lbl機台類型 = new Label(); txt機台類型 = new TextBox();
            lbl客戶簡稱 = new Label(); txt客戶簡稱 = new TextBox();
            lbl客戶名稱 = new Label(); txt客戶名稱 = new TextBox();
            lbl機台型號 = new Label(); txt機台型號 = new TextBox();
            lbl機台名稱 = new Label(); txt機台名稱 = new TextBox();
            lbl幣別 = new Label(); cmb幣別 = new ComboBox();
            lbl合約報價 = new Label(); txt合約報價 = new TextBox();
            lbl實際成交價 = new Label(); txt實際成交價 = new TextBox();
            lbl追加增減額 = new Label(); txt追加增減額 = new TextBox();
            lbl類別 = new Label(); cmb類別 = new ComboBox();
            lbl加購價1st = new Label(); txt加購價1st = new TextBox();
            lbl加購價2nd = new Label(); txt加購價2nd = new TextBox();
            lbl加購價3rd = new Label(); txt加購價3rd = new TextBox();
            lbl報價單號1st = new Label(); txt報價單號1st = new TextBox();
            lbl報價單號2nd = new Label(); txt報價單號2nd = new TextBox();
            lbl報價單號3rd = new Label(); txt報價單號3rd = new TextBox();
            lbl應收款合計 = new Label(); txt應收款合計 = new TextBox();
            lbl報價設算匯率 = new Label(); txt報價設算匯率 = new TextBox();
            lbl專案營業額 = new Label(); txt專案營業額 = new TextBox();
            lbl累計收款比例 = new Label(); txt累計收款比例 = new TextBox();
            lbl往來銀行 = new Label(); cmb往來銀行 = new ComboBox();
            lbl收款帳戶 = new Label(); txt收款帳戶 = new TextBox();
            lblCommission = new Label(); txtCommission = new TextBox();
            lblAgent = new Label(); txtAgent = new TextBox();
            dataGridView1 = new DataGridView();
            colDate = new DataGridViewTextBoxColumn();
            colItem = new DataGridViewComboBoxColumn();
            colDeliveryType = new DataGridViewComboBoxColumn();
            colOffsetAmt = new DataGridViewTextBoxColumn();
            colReceivedAmt = new DataGridViewTextBoxColumn();
            colFee = new DataGridViewTextBoxColumn();
            colOtherDeduct = new DataGridViewTextBoxColumn();
            colDeductReason = new DataGridViewTextBoxColumn();
            colRemark = new DataGridViewTextBoxColumn();
            colHandler = new DataGridViewComboBoxColumn();
            colReview = new DataGridViewTextBoxColumn();
            lblSumCaption = new Label();
            txtSum = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelHeader.SuspendLayout();
            panelFooter.SuspendLayout();
            SuspendLayout();
            //
            // panelHeader
            //
            panelHeader.BackColor = Color.FromArgb(255, 253, 205);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1160, 400);
            panelHeader.TabIndex = 0;
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Controls.Add(btnEdit);
            panelHeader.Controls.Add(btnSave);
            panelHeader.Controls.Add(btnPrint);
            panelHeader.Controls.Add(btnOverview);
            panelHeader.Controls.Add(btnExit);
            panelHeader.Controls.Add(lbl專案序號); panelHeader.Controls.Add(txt專案序號);
            panelHeader.Controls.Add(lbl收款條件); panelHeader.Controls.Add(cmb收款條件);
            panelHeader.Controls.Add(lbl機台類型); panelHeader.Controls.Add(txt機台類型);
            panelHeader.Controls.Add(lbl客戶簡稱); panelHeader.Controls.Add(txt客戶簡稱);
            panelHeader.Controls.Add(lbl客戶名稱); panelHeader.Controls.Add(txt客戶名稱);
            panelHeader.Controls.Add(lbl機台型號); panelHeader.Controls.Add(txt機台型號);
            panelHeader.Controls.Add(lbl機台名稱); panelHeader.Controls.Add(txt機台名稱);
            panelHeader.Controls.Add(lbl幣別); panelHeader.Controls.Add(cmb幣別);
            panelHeader.Controls.Add(lbl合約報價); panelHeader.Controls.Add(txt合約報價);
            panelHeader.Controls.Add(lbl實際成交價); panelHeader.Controls.Add(txt實際成交價);
            panelHeader.Controls.Add(lbl追加增減額); panelHeader.Controls.Add(txt追加增減額);
            panelHeader.Controls.Add(lbl類別); panelHeader.Controls.Add(cmb類別);
            panelHeader.Controls.Add(lbl加購價1st); panelHeader.Controls.Add(txt加購價1st);
            panelHeader.Controls.Add(lbl加購價2nd); panelHeader.Controls.Add(txt加購價2nd);
            panelHeader.Controls.Add(lbl加購價3rd); panelHeader.Controls.Add(txt加購價3rd);
            panelHeader.Controls.Add(lbl報價單號1st); panelHeader.Controls.Add(txt報價單號1st);
            panelHeader.Controls.Add(lbl報價單號2nd); panelHeader.Controls.Add(txt報價單號2nd);
            panelHeader.Controls.Add(lbl報價單號3rd); panelHeader.Controls.Add(txt報價單號3rd);
            panelHeader.Controls.Add(lbl應收款合計); panelHeader.Controls.Add(txt應收款合計);
            panelHeader.Controls.Add(lbl報價設算匯率); panelHeader.Controls.Add(txt報價設算匯率);
            panelHeader.Controls.Add(lbl專案營業額); panelHeader.Controls.Add(txt專案營業額);
            panelHeader.Controls.Add(lbl累計收款比例); panelHeader.Controls.Add(txt累計收款比例);
            panelHeader.Controls.Add(lbl往來銀行); panelHeader.Controls.Add(cmb往來銀行);
            panelHeader.Controls.Add(lbl收款帳戶); panelHeader.Controls.Add(txt收款帳戶);
            panelHeader.Controls.Add(lblCommission); panelHeader.Controls.Add(txtCommission);
            panelHeader.Controls.Add(lblAgent); panelHeader.Controls.Add(txtAgent);
            //
            // lblTitle
            //
            lblTitle.AutoSize = false;
            lblTitle.Font = new Font("微軟正黑體", 12F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(69, 98, 135);
            lblTitle.Location = new Point(11, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(220, 24);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "專案（零件）應收沖款";
            //
            // 按鈕列：修改/儲存/生效/取消生效/列印/總覽/關閉
            //
            btnEdit.BackColor = Color.SteelBlue; btnEdit.FlatStyle = FlatStyle.Flat; btnEdit.ForeColor = Color.White;
            btnEdit.Font = new Font("微軟正黑體", 9F, FontStyle.Bold); btnEdit.Location = new Point(650, 8);
            btnEdit.Name = "btnEdit"; btnEdit.Size = new Size(70, 27); btnEdit.TabIndex = 1;
            btnEdit.Text = "修改"; btnEdit.UseVisualStyleBackColor = false; btnEdit.Click += btnEdit_Click;

            btnSave.BackColor = Color.SteelBlue; btnSave.FlatStyle = FlatStyle.Flat; btnSave.ForeColor = Color.White;
            btnSave.Font = new Font("微軟正黑體", 9F, FontStyle.Bold); btnSave.Location = new Point(725, 8);
            btnSave.Name = "btnSave"; btnSave.Size = new Size(70, 27); btnSave.TabIndex = 2;
            btnSave.Text = "儲存"; btnSave.UseVisualStyleBackColor = false; btnSave.Click += btnSave_Click;

            btnPrint.BackColor = Color.Gray; btnPrint.FlatStyle = FlatStyle.Flat; btnPrint.ForeColor = Color.White;
            btnPrint.Font = new Font("微軟正黑體", 9F, FontStyle.Bold); btnPrint.Location = new Point(800, 8);
            btnPrint.Name = "btnPrint"; btnPrint.Size = new Size(70, 27); btnPrint.TabIndex = 3;
            btnPrint.Text = "列印"; btnPrint.UseVisualStyleBackColor = false; btnPrint.Click += btnPrint_Click;

            btnOverview.BackColor = Color.Gray; btnOverview.FlatStyle = FlatStyle.Flat; btnOverview.ForeColor = Color.White;
            btnOverview.Font = new Font("微軟正黑體", 9F, FontStyle.Bold); btnOverview.Location = new Point(875, 8);
            btnOverview.Name = "btnOverview"; btnOverview.Size = new Size(70, 27); btnOverview.TabIndex = 4;
            btnOverview.Text = "總覽"; btnOverview.UseVisualStyleBackColor = false; btnOverview.Click += btnOverview_Click;

            btnExit.BackColor = Color.SteelBlue; btnExit.FlatStyle = FlatStyle.Flat; btnExit.ForeColor = Color.White;
            btnExit.Font = new Font("微軟正黑體", 9F, FontStyle.Bold); btnExit.Location = new Point(950, 8);
            btnExit.Name = "btnExit"; btnExit.Size = new Size(70, 27); btnExit.TabIndex = 5;
            btnExit.Text = "關閉"; btnExit.UseVisualStyleBackColor = false; btnExit.Click += btnExit_Click;
            //
            // Row1 (y=50): 專案序號 / 收款條件 / 機台類型
            //
            lbl專案序號.AutoSize = false; lbl專案序號.Location = new Point(8, 50); lbl專案序號.Size = new Size(90, 21);
            lbl專案序號.Text = "專案序號"; lbl專案序號.TextAlign = ContentAlignment.MiddleLeft;
            txt專案序號.Location = new Point(98, 50); txt專案序號.Size = new Size(280, 21); txt專案序號.ReadOnly = true; txt專案序號.BackColor = SystemColors.Control;

            lbl收款條件.AutoSize = false; lbl收款條件.Location = new Point(400, 50); lbl收款條件.Size = new Size(90, 21);
            lbl收款條件.Text = "收款條件"; lbl收款條件.TextAlign = ContentAlignment.MiddleLeft;
            cmb收款條件.Location = new Point(490, 50); cmb收款條件.Size = new Size(280, 23); cmb收款條件.DropDownStyle = ComboBoxStyle.DropDown;

            lbl機台類型.AutoSize = false; lbl機台類型.Location = new Point(792, 50); lbl機台類型.Size = new Size(90, 21);
            lbl機台類型.Text = "機台類型"; lbl機台類型.TextAlign = ContentAlignment.MiddleLeft;
            txt機台類型.Location = new Point(882, 50); txt機台類型.Size = new Size(200, 21); txt機台類型.ReadOnly = true; txt機台類型.BackColor = SystemColors.Control;
            //
            // Row2 (y=80): 客戶簡稱 / 客戶名稱 / 機台型號
            //
            lbl客戶簡稱.AutoSize = false; lbl客戶簡稱.Location = new Point(8, 80); lbl客戶簡稱.Size = new Size(90, 21);
            lbl客戶簡稱.Text = "客戶簡稱"; lbl客戶簡稱.TextAlign = ContentAlignment.MiddleLeft;
            txt客戶簡稱.Location = new Point(98, 80); txt客戶簡稱.Size = new Size(280, 21); txt客戶簡稱.ReadOnly = true; txt客戶簡稱.BackColor = SystemColors.Control;

            lbl客戶名稱.AutoSize = false; lbl客戶名稱.Location = new Point(400, 80); lbl客戶名稱.Size = new Size(90, 21);
            lbl客戶名稱.Text = "客戶名稱"; lbl客戶名稱.TextAlign = ContentAlignment.MiddleLeft;
            txt客戶名稱.Location = new Point(490, 80); txt客戶名稱.Size = new Size(280, 21); txt客戶名稱.ReadOnly = true; txt客戶名稱.BackColor = SystemColors.Control;

            lbl機台型號.AutoSize = false; lbl機台型號.Location = new Point(792, 80); lbl機台型號.Size = new Size(90, 21);
            lbl機台型號.Text = "機台型號"; lbl機台型號.TextAlign = ContentAlignment.MiddleLeft;
            txt機台型號.Location = new Point(882, 80); txt機台型號.Size = new Size(270, 21); txt機台型號.ReadOnly = true; txt機台型號.BackColor = SystemColors.Control;
            //
            // Row3 (y=110): 機台名稱(寬)
            //
            lbl機台名稱.AutoSize = false; lbl機台名稱.Location = new Point(8, 110); lbl機台名稱.Size = new Size(90, 21);
            lbl機台名稱.Text = "機台名稱"; lbl機台名稱.TextAlign = ContentAlignment.MiddleLeft;
            txt機台名稱.Location = new Point(98, 110); txt機台名稱.Size = new Size(1054, 21); txt機台名稱.ReadOnly = true; txt機台名稱.BackColor = SystemColors.Control;
            //
            // Row4 (y=145): 幣別 / 合約報價 / 訂單成交價
            //
            lbl幣別.AutoSize = false; lbl幣別.Location = new Point(8, 145); lbl幣別.Size = new Size(90, 21);
            lbl幣別.Text = "幣別"; lbl幣別.TextAlign = ContentAlignment.MiddleLeft;
            cmb幣別.Location = new Point(98, 145); cmb幣別.Size = new Size(150, 23); cmb幣別.DropDownStyle = ComboBoxStyle.DropDown;

            lbl合約報價.AutoSize = false; lbl合約報價.Location = new Point(400, 145); lbl合約報價.Size = new Size(90, 21);
            lbl合約報價.Text = "合約報價"; lbl合約報價.TextAlign = ContentAlignment.MiddleLeft;
            txt合約報價.Location = new Point(490, 145); txt合約報價.Size = new Size(280, 21);

            lbl實際成交價.AutoSize = false; lbl實際成交價.Location = new Point(792, 145); lbl實際成交價.Size = new Size(90, 21);
            lbl實際成交價.Text = "訂單成交價"; lbl實際成交價.TextAlign = ContentAlignment.MiddleLeft;
            txt實際成交價.Location = new Point(882, 145); txt實際成交價.Size = new Size(270, 21);
            //
            // Row5 (y=175): 追認增減額 / 立帳類別
            //
            lbl追加增減額.AutoSize = false; lbl追加增減額.Location = new Point(8, 175); lbl追加增減額.Size = new Size(90, 21);
            lbl追加增減額.Text = "追認增減額"; lbl追加增減額.TextAlign = ContentAlignment.MiddleLeft;
            txt追加增減額.Location = new Point(98, 175); txt追加增減額.Size = new Size(280, 21);

            lbl類別.AutoSize = false; lbl類別.Location = new Point(400, 175); lbl類別.Size = new Size(90, 21);
            lbl類別.Text = "立帳類別"; lbl類別.TextAlign = ContentAlignment.MiddleLeft;
            cmb類別.Location = new Point(490, 175); cmb類別.Size = new Size(150, 23); cmb類別.DropDownStyle = ComboBoxStyle.DropDownList;
            //
            // Row6a (y=205): 加購價1st/2nd/3rd
            //
            lbl加購價1st.AutoSize = false; lbl加購價1st.Location = new Point(8, 205); lbl加購價1st.Size = new Size(90, 21);
            lbl加購價1st.Text = "加購價1st"; lbl加購價1st.TextAlign = ContentAlignment.MiddleLeft;
            txt加購價1st.Location = new Point(98, 205); txt加購價1st.Size = new Size(280, 21);

            lbl加購價2nd.AutoSize = false; lbl加購價2nd.Location = new Point(400, 205); lbl加購價2nd.Size = new Size(90, 21);
            lbl加購價2nd.Text = "加購價2nd"; lbl加購價2nd.TextAlign = ContentAlignment.MiddleLeft;
            txt加購價2nd.Location = new Point(490, 205); txt加購價2nd.Size = new Size(280, 21);

            lbl加購價3rd.AutoSize = false; lbl加購價3rd.Location = new Point(792, 205); lbl加購價3rd.Size = new Size(90, 21);
            lbl加購價3rd.Text = "加購價3rd"; lbl加購價3rd.TextAlign = ContentAlignment.MiddleLeft;
            txt加購價3rd.Location = new Point(882, 205); txt加購價3rd.Size = new Size(270, 21);
            //
            // Row6b (y=235): 報價單號1st/2nd/3rd
            //
            lbl報價單號1st.AutoSize = false; lbl報價單號1st.Location = new Point(8, 235); lbl報價單號1st.Size = new Size(90, 21);
            lbl報價單號1st.Text = "報價單號1st"; lbl報價單號1st.TextAlign = ContentAlignment.MiddleLeft;
            txt報價單號1st.Location = new Point(98, 235); txt報價單號1st.Size = new Size(280, 21);

            lbl報價單號2nd.AutoSize = false; lbl報價單號2nd.Location = new Point(400, 235); lbl報價單號2nd.Size = new Size(90, 21);
            lbl報價單號2nd.Text = "報價單號2nd"; lbl報價單號2nd.TextAlign = ContentAlignment.MiddleLeft;
            txt報價單號2nd.Location = new Point(490, 235); txt報價單號2nd.Size = new Size(280, 21);

            lbl報價單號3rd.AutoSize = false; lbl報價單號3rd.Location = new Point(792, 235); lbl報價單號3rd.Size = new Size(90, 21);
            lbl報價單號3rd.Text = "報價單號3rd"; lbl報價單號3rd.TextAlign = ContentAlignment.MiddleLeft;
            txt報價單號3rd.Location = new Point(882, 235); txt報價單號3rd.Size = new Size(270, 21);
            //
            // Row7 (y=265): 應收款合計 / 報價設算匯率 / 專案營收NTD
            //
            lbl應收款合計.AutoSize = false; lbl應收款合計.Location = new Point(8, 265); lbl應收款合計.Size = new Size(90, 21);
            lbl應收款合計.Text = "應收款合計"; lbl應收款合計.TextAlign = ContentAlignment.MiddleLeft;
            txt應收款合計.Location = new Point(98, 265); txt應收款合計.Size = new Size(280, 21);

            lbl報價設算匯率.AutoSize = false; lbl報價設算匯率.Location = new Point(400, 265); lbl報價設算匯率.Size = new Size(90, 21);
            lbl報價設算匯率.Text = "報價設算匯率"; lbl報價設算匯率.TextAlign = ContentAlignment.MiddleLeft;
            txt報價設算匯率.Location = new Point(490, 265); txt報價設算匯率.Size = new Size(280, 21);

            lbl專案營業額.AutoSize = false; lbl專案營業額.Location = new Point(792, 265); lbl專案營業額.Size = new Size(90, 21);
            lbl專案營業額.Text = "專案營收NTD"; lbl專案營業額.TextAlign = ContentAlignment.MiddleLeft;
            txt專案營業額.Location = new Point(882, 265); txt專案營業額.Size = new Size(270, 21);
            //
            // Row8 (y=295): 累計收款比例 / 往來銀行 / 收款帳戶
            //
            lbl累計收款比例.AutoSize = false; lbl累計收款比例.Location = new Point(8, 295); lbl累計收款比例.Size = new Size(90, 21);
            lbl累計收款比例.Text = "累計收款比例"; lbl累計收款比例.TextAlign = ContentAlignment.MiddleLeft;
            txt累計收款比例.Location = new Point(98, 295); txt累計收款比例.Size = new Size(280, 21);

            lbl往來銀行.AutoSize = false; lbl往來銀行.Location = new Point(400, 295); lbl往來銀行.Size = new Size(90, 21);
            lbl往來銀行.Text = "往來銀行"; lbl往來銀行.TextAlign = ContentAlignment.MiddleLeft;
            cmb往來銀行.Location = new Point(490, 295); cmb往來銀行.Size = new Size(280, 23); cmb往來銀行.DropDownStyle = ComboBoxStyle.DropDown;

            lbl收款帳戶.AutoSize = false; lbl收款帳戶.Location = new Point(792, 295); lbl收款帳戶.Size = new Size(90, 21);
            lbl收款帳戶.Text = "收款帳戶"; lbl收款帳戶.TextAlign = ContentAlignment.MiddleLeft;
            txt收款帳戶.Location = new Point(882, 295); txt收款帳戶.Size = new Size(270, 21);
            //
            // Row9 (y=325): Commission / AGENT (依賴資料表在CHINYO查無對應，維持空白唯讀)
            //
            lblCommission.AutoSize = false; lblCommission.Location = new Point(400, 325); lblCommission.Size = new Size(90, 21);
            lblCommission.Text = "Commission"; lblCommission.TextAlign = ContentAlignment.MiddleLeft;
            txtCommission.Location = new Point(490, 325); txtCommission.Size = new Size(280, 21); txtCommission.ReadOnly = true; txtCommission.BackColor = SystemColors.Control;

            lblAgent.AutoSize = false; lblAgent.Location = new Point(792, 325); lblAgent.Size = new Size(90, 21);
            lblAgent.Text = "AGENT"; lblAgent.TextAlign = ContentAlignment.MiddleLeft;
            txtAgent.Location = new Point(882, 325); txtAgent.Size = new Size(270, 21); txtAgent.ReadOnly = true; txtAgent.BackColor = SystemColors.Control;
            //
            // dataGridView1 (子表單 S-專案應收沖款明細)
            //
            dataGridView1.AllowUserToAddRows = true;
            dataGridView1.AllowUserToDeleteRows = true;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle { BackColor = Color.FromArgb(255, 253, 205), Font = new Font("微軟正黑體", 9F, FontStyle.Bold) };
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colDate, colItem, colDeliveryType, colOffsetAmt, colReceivedAmt, colFee, colOtherDeduct, colDeductReason, colRemark, colHandler, colReview });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Font = new Font("微軟正黑體", 9F);
            dataGridView1.Location = new Point(0, 400);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 26;
            dataGridView1.Size = new Size(1160, 280);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            dataGridView1.CurrentCellDirtyStateChanged += dataGridView1_CurrentCellDirtyStateChanged;
            dataGridView1.DataError += dataGridView1_DataError;

            colDate.HeaderText = "收款日期"; colDate.Name = "colDate"; colDate.Width = 90;
            colItem.HeaderText = "收款項目"; colItem.Name = "colItem"; colItem.Width = 130;
            colDeliveryType.HeaderText = "交付形式"; colDeliveryType.Name = "colDeliveryType"; colDeliveryType.Width = 90;
            colOffsetAmt.HeaderText = "沖帳金額"; colOffsetAmt.Name = "colOffsetAmt"; colOffsetAmt.Width = 90;
            colReceivedAmt.HeaderText = "實收金額"; colReceivedAmt.Name = "colReceivedAmt"; colReceivedAmt.Width = 90;
            colFee.HeaderText = "手續費"; colFee.Name = "colFee"; colFee.Width = 80;
            colOtherDeduct.HeaderText = "其他折減額"; colOtherDeduct.Name = "colOtherDeduct"; colOtherDeduct.Width = 90;
            colDeductReason.HeaderText = "折減科目"; colDeductReason.Name = "colDeductReason"; colDeductReason.Width = 110;
            colRemark.HeaderText = "備註"; colRemark.Name = "colRemark"; colRemark.Width = 150;
            colHandler.HeaderText = "沖帳人員"; colHandler.Name = "colHandler"; colHandler.Width = 90;
            colReview.HeaderText = "業務覆核"; colReview.Name = "colReview"; colReview.Width = 90;
            //
            // panelFooter (沖帳金額合計；資料表已無 核准/建檔/修改 欄位，不再顯示簽核紀錄)
            //
            panelFooter.BackColor = Color.FromArgb(255, 253, 205);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 640);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(1160, 36);
            panelFooter.TabIndex = 2;
            panelFooter.Controls.Add(lblSumCaption);
            panelFooter.Controls.Add(txtSum);

            lblSumCaption.AutoSize = false; lblSumCaption.Location = new Point(792, 6); lblSumCaption.Size = new Size(110, 21);
            lblSumCaption.Text = "沖帳金額合計："; lblSumCaption.TextAlign = ContentAlignment.MiddleRight; lblSumCaption.ForeColor = Color.Firebrick; lblSumCaption.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            txtSum.Location = new Point(908, 6); txtSum.Size = new Size(150, 21); txtSum.ReadOnly = true; txtSum.BackColor = Color.White; txtSum.TextAlign = HorizontalAlignment.Right;
            //
            // ReceivablesControl
            //
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(panelFooter);
            Controls.Add(panelHeader);
            Font = new Font("微軟正黑體", 9F);
            Margin = new Padding(4);
            Name = "ReceivablesControl";
            Size = new Size(1160, 710);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelFooter.ResumeLayout(false);
            panelFooter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Panel panelFooter;
        private Label lblTitle;
        private Button btnEdit;
        private Button btnSave;
        private Button btnPrint;
        private Button btnOverview;
        private Button btnExit;
        private Label lbl專案序號; private TextBox txt專案序號;
        private Label lbl收款條件; private ComboBox cmb收款條件;
        private Label lbl機台類型; private TextBox txt機台類型;
        private Label lbl客戶簡稱; private TextBox txt客戶簡稱;
        private Label lbl客戶名稱; private TextBox txt客戶名稱;
        private Label lbl機台型號; private TextBox txt機台型號;
        private Label lbl機台名稱; private TextBox txt機台名稱;
        private Label lbl幣別; private ComboBox cmb幣別;
        private Label lbl合約報價; private TextBox txt合約報價;
        private Label lbl實際成交價; private TextBox txt實際成交價;
        private Label lbl追加增減額; private TextBox txt追加增減額;
        private Label lbl類別; private ComboBox cmb類別;
        private Label lbl加購價1st; private TextBox txt加購價1st;
        private Label lbl加購價2nd; private TextBox txt加購價2nd;
        private Label lbl加購價3rd; private TextBox txt加購價3rd;
        private Label lbl報價單號1st; private TextBox txt報價單號1st;
        private Label lbl報價單號2nd; private TextBox txt報價單號2nd;
        private Label lbl報價單號3rd; private TextBox txt報價單號3rd;
        private Label lbl應收款合計; private TextBox txt應收款合計;
        private Label lbl報價設算匯率; private TextBox txt報價設算匯率;
        private Label lbl專案營業額; private TextBox txt專案營業額;
        private Label lbl累計收款比例; private TextBox txt累計收款比例;
        private Label lbl往來銀行; private ComboBox cmb往來銀行;
        private Label lbl收款帳戶; private TextBox txt收款帳戶;
        private Label lblCommission; private TextBox txtCommission;
        private Label lblAgent; private TextBox txtAgent;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colDate;
        private DataGridViewComboBoxColumn colItem;
        private DataGridViewComboBoxColumn colDeliveryType;
        private DataGridViewTextBoxColumn colOffsetAmt;
        private DataGridViewTextBoxColumn colReceivedAmt;
        private DataGridViewTextBoxColumn colFee;
        private DataGridViewTextBoxColumn colOtherDeduct;
        private DataGridViewTextBoxColumn colDeductReason;
        private DataGridViewTextBoxColumn colRemark;
        private DataGridViewComboBoxColumn colHandler;
        private DataGridViewTextBoxColumn colReview;
        private Label lblSumCaption;
        private TextBox txtSum;
    }
}
