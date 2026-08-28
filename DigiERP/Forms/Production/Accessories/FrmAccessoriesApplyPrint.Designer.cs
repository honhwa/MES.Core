using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.Forms.Production.Accessories
{
    partial class FrmAccessoriesApplyPrint
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        //
        // 比照 PITS-2025.accdb Report「零件工令單」(Caption="零件工令單"，
        // RecordSource=dbo_零件申請單)還原：頁首「申請日期/申請人/申請用途」
        // 與報表首「單號/專案序號/客戶名稱/運送方式/收費機制/交貨日期/機台名稱/
        // 保固效期/機台型號/主旨」原分屬 PageHeaderSection 與 ReportHeader 兩個
        // 各自Top=0起算的區段，本畫面為單一預覽視窗不做分頁，故合併為一連續
        // 表頭區塊呈現。明細改用 DataGridView 呈現子報表「Report.零件申請明細」。
        // 「會簽」8欄(廠長/設計/電控/製造/組測/物管/採購/管理)原為留白簽名格，
        // 比照原樣以框線Panel呈現。核准人員/建檔人員 依 ControlSource 分別對應
        // 核准/建檔欄位(與版面上Label文字不同，已依標準作法採信 ControlSource)。
        // 「預覽列印」比照既有 FrmPrintSalesOrderPT.cs 之 PdfSharp 全畫面點陣圖
        // 匯出PDF作法。全部控制項座標一律採內嵌常數寫死(不使用自訂輔助方法)，
        // 以避免 Visual Studio 表單設計工具重新序列化時遺失版面資訊 ────────────
        //
        private void InitializeComponent()
        {
            pnlContent = new Panel();
            lblTitle = new Label();
            lbl單號 = new Label();
            txt單號 = new TextBox();
            lbl申請日期 = new Label();
            txt申請日期 = new TextBox();
            lbl申請用途 = new Label();
            txt申請用途 = new TextBox();
            lbl專案序號 = new Label();
            txt專案序號 = new TextBox();
            lbl客戶名稱 = new Label();
            txt客戶名稱 = new TextBox();
            lbl申請人 = new Label();
            txt申請人 = new TextBox();
            lbl運送方式 = new Label();
            txt運送方式 = new TextBox();
            lbl收費機制 = new Label();
            txt收費機制 = new TextBox();
            lbl交貨日期 = new Label();
            txt交貨日期 = new TextBox();
            lbl機台名稱 = new Label();
            txt機台名稱 = new TextBox();
            lbl保固效期 = new Label();
            txt保固效期 = new TextBox();
            lbl機台型號 = new Label();
            txt機台型號 = new TextBox();
            lbl主旨 = new Label();
            txt主旨 = new TextBox();
            dataGridView1 = new DataGridView();
            colPartType = new DataGridViewTextBoxColumn();
            colPartNo = new DataGridViewTextBoxColumn();
            colItemName = new DataGridViewTextBoxColumn();
            colDesc = new DataGridViewTextBoxColumn();
            colUnit = new DataGridViewTextBoxColumn();
            colQty = new DataGridViewTextBoxColumn();
            colOwner = new DataGridViewTextBoxColumn();
            colRemark = new DataGridViewTextBoxColumn();
            lblSign = new Label();
            pnl廠長 = new Panel();
            lbl廠長 = new Label();
            pnl設計 = new Panel();
            lbl設計 = new Label();
            pnl電控 = new Panel();
            lbl電控 = new Label();
            pnl製造 = new Panel();
            lbl製造 = new Label();
            pnl組測 = new Panel();
            lbl組測 = new Label();
            pnl物管 = new Panel();
            lbl物管 = new Label();
            pnl採購 = new Panel();
            lbl採購 = new Label();
            pnl管理 = new Panel();
            lbl管理 = new Label();
            pnl總經理 = new Panel();
            lbl總經理 = new Label();
            lbl核准人員 = new Label();
            txt核准人員 = new TextBox();
            lbl核准日 = new Label();
            txt核准日 = new TextBox();
            lbl建檔人員 = new Label();
            txt建檔人員 = new TextBox();
            lbl建檔日 = new Label();
            txt建檔日 = new TextBox();
            lblNote = new Label();
            btnPreviewPrint = new Button();
            btnPrint = new Button();
            btnExit = new Button();
            pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            pnl廠長.SuspendLayout();
            pnl設計.SuspendLayout();
            pnl電控.SuspendLayout();
            pnl製造.SuspendLayout();
            pnl組測.SuspendLayout();
            pnl物管.SuspendLayout();
            pnl採購.SuspendLayout();
            pnl管理.SuspendLayout();
            pnl總經理.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContent
            // 
            pnlContent.BackColor = SystemColors.ButtonHighlight;
            pnlContent.Controls.Add(lblTitle);
            pnlContent.Controls.Add(lbl單號);
            pnlContent.Controls.Add(txt單號);
            pnlContent.Controls.Add(lbl申請日期);
            pnlContent.Controls.Add(txt申請日期);
            pnlContent.Controls.Add(lbl申請用途);
            pnlContent.Controls.Add(txt申請用途);
            pnlContent.Controls.Add(lbl專案序號);
            pnlContent.Controls.Add(txt專案序號);
            pnlContent.Controls.Add(lbl客戶名稱);
            pnlContent.Controls.Add(txt客戶名稱);
            pnlContent.Controls.Add(lbl申請人);
            pnlContent.Controls.Add(txt申請人);
            pnlContent.Controls.Add(lbl運送方式);
            pnlContent.Controls.Add(txt運送方式);
            pnlContent.Controls.Add(lbl收費機制);
            pnlContent.Controls.Add(txt收費機制);
            pnlContent.Controls.Add(lbl交貨日期);
            pnlContent.Controls.Add(txt交貨日期);
            pnlContent.Controls.Add(lbl機台名稱);
            pnlContent.Controls.Add(txt機台名稱);
            pnlContent.Controls.Add(lbl保固效期);
            pnlContent.Controls.Add(txt保固效期);
            pnlContent.Controls.Add(lbl機台型號);
            pnlContent.Controls.Add(txt機台型號);
            pnlContent.Controls.Add(lbl主旨);
            pnlContent.Controls.Add(txt主旨);
            pnlContent.Controls.Add(dataGridView1);
            pnlContent.Controls.Add(lblSign);
            pnlContent.Controls.Add(pnl廠長);
            pnlContent.Controls.Add(pnl設計);
            pnlContent.Controls.Add(pnl電控);
            pnlContent.Controls.Add(pnl製造);
            pnlContent.Controls.Add(pnl組測);
            pnlContent.Controls.Add(pnl物管);
            pnlContent.Controls.Add(pnl採購);
            pnlContent.Controls.Add(pnl管理);
            pnlContent.Controls.Add(pnl總經理);
            pnlContent.Controls.Add(lbl核准人員);
            pnlContent.Controls.Add(txt核准人員);
            pnlContent.Controls.Add(lbl核准日);
            pnlContent.Controls.Add(txt核准日);
            pnlContent.Controls.Add(lbl建檔人員);
            pnlContent.Controls.Add(txt建檔人員);
            pnlContent.Controls.Add(lbl建檔日);
            pnlContent.Controls.Add(txt建檔日);
            pnlContent.Controls.Add(lblNote);
            pnlContent.Location = new Point(0, 0);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(956, 780);
            pnlContent.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("標楷體", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(300, 8);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(220, 36);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "零件工令單";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl單號
            // 
            lbl單號.Location = new Point(8, 50);
            lbl單號.Name = "lbl單號";
            lbl單號.Size = new Size(75, 21);
            lbl單號.TabIndex = 1;
            lbl單號.Text = "單號";
            lbl單號.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt單號
            // 
            txt單號.Location = new Point(87, 50);
            txt單號.Name = "txt單號";
            txt單號.ReadOnly = true;
            txt單號.Size = new Size(200, 23);
            txt單號.TabIndex = 2;
            // 
            // lbl申請日期
            // 
            lbl申請日期.Location = new Point(300, 50);
            lbl申請日期.Name = "lbl申請日期";
            lbl申請日期.Size = new Size(75, 21);
            lbl申請日期.TabIndex = 3;
            lbl申請日期.Text = "申請日期";
            lbl申請日期.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt申請日期
            // 
            txt申請日期.Location = new Point(379, 50);
            txt申請日期.Name = "txt申請日期";
            txt申請日期.ReadOnly = true;
            txt申請日期.Size = new Size(170, 23);
            txt申請日期.TabIndex = 4;
            // 
            // lbl申請用途
            // 
            lbl申請用途.Location = new Point(560, 50);
            lbl申請用途.Name = "lbl申請用途";
            lbl申請用途.Size = new Size(75, 21);
            lbl申請用途.TabIndex = 5;
            lbl申請用途.Text = "申請用途";
            lbl申請用途.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt申請用途
            // 
            txt申請用途.Location = new Point(639, 50);
            txt申請用途.Name = "txt申請用途";
            txt申請用途.ReadOnly = true;
            txt申請用途.Size = new Size(230, 23);
            txt申請用途.TabIndex = 6;
            // 
            // lbl專案序號
            // 
            lbl專案序號.Location = new Point(8, 80);
            lbl專案序號.Name = "lbl專案序號";
            lbl專案序號.Size = new Size(75, 21);
            lbl專案序號.TabIndex = 7;
            lbl專案序號.Text = "專案序號";
            lbl專案序號.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt專案序號
            // 
            txt專案序號.Location = new Point(87, 80);
            txt專案序號.Name = "txt專案序號";
            txt專案序號.ReadOnly = true;
            txt專案序號.Size = new Size(200, 23);
            txt專案序號.TabIndex = 8;
            // 
            // lbl客戶名稱
            // 
            lbl客戶名稱.Location = new Point(300, 80);
            lbl客戶名稱.Name = "lbl客戶名稱";
            lbl客戶名稱.Size = new Size(75, 21);
            lbl客戶名稱.TabIndex = 9;
            lbl客戶名稱.Text = "客戶名稱";
            lbl客戶名稱.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt客戶名稱
            // 
            txt客戶名稱.Location = new Point(379, 80);
            txt客戶名稱.Name = "txt客戶名稱";
            txt客戶名稱.ReadOnly = true;
            txt客戶名稱.Size = new Size(230, 23);
            txt客戶名稱.TabIndex = 10;
            // 
            // lbl申請人
            // 
            lbl申請人.Location = new Point(620, 80);
            lbl申請人.Name = "lbl申請人";
            lbl申請人.Size = new Size(75, 21);
            lbl申請人.TabIndex = 11;
            lbl申請人.Text = "申請人";
            lbl申請人.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt申請人
            // 
            txt申請人.Location = new Point(699, 80);
            txt申請人.Name = "txt申請人";
            txt申請人.ReadOnly = true;
            txt申請人.Size = new Size(120, 23);
            txt申請人.TabIndex = 12;
            // 
            // lbl運送方式
            // 
            lbl運送方式.Location = new Point(8, 110);
            lbl運送方式.Name = "lbl運送方式";
            lbl運送方式.Size = new Size(75, 21);
            lbl運送方式.TabIndex = 13;
            lbl運送方式.Text = "運送方式";
            lbl運送方式.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt運送方式
            // 
            txt運送方式.Location = new Point(87, 110);
            txt運送方式.Name = "txt運送方式";
            txt運送方式.ReadOnly = true;
            txt運送方式.Size = new Size(200, 23);
            txt運送方式.TabIndex = 14;
            // 
            // lbl收費機制
            // 
            lbl收費機制.Location = new Point(300, 110);
            lbl收費機制.Name = "lbl收費機制";
            lbl收費機制.Size = new Size(75, 21);
            lbl收費機制.TabIndex = 15;
            lbl收費機制.Text = "收費機制";
            lbl收費機制.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt收費機制
            // 
            txt收費機制.Location = new Point(379, 110);
            txt收費機制.Name = "txt收費機制";
            txt收費機制.ReadOnly = true;
            txt收費機制.Size = new Size(170, 23);
            txt收費機制.TabIndex = 16;
            // 
            // lbl交貨日期
            // 
            lbl交貨日期.Location = new Point(560, 110);
            lbl交貨日期.Name = "lbl交貨日期";
            lbl交貨日期.Size = new Size(75, 21);
            lbl交貨日期.TabIndex = 17;
            lbl交貨日期.Text = "交貨日期";
            lbl交貨日期.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt交貨日期
            // 
            txt交貨日期.Location = new Point(639, 110);
            txt交貨日期.Name = "txt交貨日期";
            txt交貨日期.ReadOnly = true;
            txt交貨日期.Size = new Size(230, 23);
            txt交貨日期.TabIndex = 18;
            // 
            // lbl機台名稱
            // 
            lbl機台名稱.Location = new Point(8, 140);
            lbl機台名稱.Name = "lbl機台名稱";
            lbl機台名稱.Size = new Size(75, 21);
            lbl機台名稱.TabIndex = 19;
            lbl機台名稱.Text = "機台名稱";
            lbl機台名稱.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt機台名稱
            // 
            txt機台名稱.Location = new Point(87, 140);
            txt機台名稱.Name = "txt機台名稱";
            txt機台名稱.ReadOnly = true;
            txt機台名稱.Size = new Size(550, 23);
            txt機台名稱.TabIndex = 20;
            // 
            // lbl保固效期
            // 
            lbl保固效期.Location = new Point(660, 140);
            lbl保固效期.Name = "lbl保固效期";
            lbl保固效期.Size = new Size(75, 21);
            lbl保固效期.TabIndex = 21;
            lbl保固效期.Text = "保固效期";
            lbl保固效期.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt保固效期
            // 
            txt保固效期.Location = new Point(739, 140);
            txt保固效期.Name = "txt保固效期";
            txt保固效期.ReadOnly = true;
            txt保固效期.Size = new Size(130, 23);
            txt保固效期.TabIndex = 22;
            // 
            // lbl機台型號
            // 
            lbl機台型號.Location = new Point(8, 170);
            lbl機台型號.Name = "lbl機台型號";
            lbl機台型號.Size = new Size(75, 21);
            lbl機台型號.TabIndex = 23;
            lbl機台型號.Text = "機台型號";
            lbl機台型號.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt機台型號
            // 
            txt機台型號.Location = new Point(87, 170);
            txt機台型號.Name = "txt機台型號";
            txt機台型號.ReadOnly = true;
            txt機台型號.Size = new Size(550, 23);
            txt機台型號.TabIndex = 24;
            // 
            // lbl主旨
            // 
            lbl主旨.Location = new Point(8, 200);
            lbl主旨.Name = "lbl主旨";
            lbl主旨.Size = new Size(75, 55);
            lbl主旨.TabIndex = 25;
            lbl主旨.Text = "主旨說明";
            lbl主旨.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt主旨
            // 
            txt主旨.BorderStyle = BorderStyle.FixedSingle;
            txt主旨.Location = new Point(87, 200);
            txt主旨.Multiline = true;
            txt主旨.Name = "txt主旨";
            txt主旨.ReadOnly = true;
            txt主旨.Size = new Size(662, 55);
            txt主旨.TabIndex = 26;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colPartType, colPartNo, colItemName, colDesc, colUnit, colQty, colOwner, colRemark });
            dataGridView1.Location = new Point(8, 265);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new Size(936, 300);
            dataGridView1.TabIndex = 27;
            // 
            // colPartType
            // 
            colPartType.HeaderText = "零件分類";
            colPartType.Name = "colPartType";
            colPartType.ReadOnly = true;
            colPartType.Width = 80;
            // 
            // colPartNo
            // 
            colPartNo.HeaderText = "零件號碼";
            colPartNo.Name = "colPartNo";
            colPartNo.ReadOnly = true;
            colPartNo.Width = 130;
            // 
            // colItemName
            // 
            colItemName.HeaderText = "品名";
            colItemName.Name = "colItemName";
            colItemName.ReadOnly = true;
            colItemName.Width = 160;
            // 
            // colDesc
            // 
            colDesc.HeaderText = "描述";
            colDesc.Name = "colDesc";
            colDesc.ReadOnly = true;
            colDesc.Width = 160;
            // 
            // colUnit
            // 
            colUnit.HeaderText = "單位";
            colUnit.Name = "colUnit";
            colUnit.ReadOnly = true;
            colUnit.Width = 50;
            // 
            // colQty
            // 
            colQty.HeaderText = "數量";
            colQty.Name = "colQty";
            colQty.ReadOnly = true;
            colQty.Width = 60;
            // 
            // colOwner
            // 
            colOwner.HeaderText = "附屬模組";
            colOwner.Name = "colOwner";
            colOwner.ReadOnly = true;
            colOwner.Width = 80;
            // 
            // colRemark
            // 
            colRemark.HeaderText = "備註";
            colRemark.Name = "colRemark";
            colRemark.ReadOnly = true;
            // 
            // lblSign
            // 
            lblSign.BorderStyle = BorderStyle.FixedSingle;
            lblSign.Location = new Point(8, 575);
            lblSign.Name = "lblSign";
            lblSign.Size = new Size(40, 60);
            lblSign.TabIndex = 28;
            lblSign.Text = "會簽";
            lblSign.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnl廠長
            // 
            pnl廠長.BorderStyle = BorderStyle.FixedSingle;
            pnl廠長.Controls.Add(lbl廠長);
            pnl廠長.Location = new Point(48, 575);
            pnl廠長.Name = "pnl廠長";
            pnl廠長.Size = new Size(85, 60);
            pnl廠長.TabIndex = 29;
            // 
            // lbl廠長
            // 
            lbl廠長.Dock = DockStyle.Top;
            lbl廠長.Location = new Point(0, 0);
            lbl廠長.Name = "lbl廠長";
            lbl廠長.Size = new Size(83, 20);
            lbl廠長.TabIndex = 0;
            lbl廠長.Text = "廠長";
            lbl廠長.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnl設計
            // 
            pnl設計.BorderStyle = BorderStyle.FixedSingle;
            pnl設計.Controls.Add(lbl設計);
            pnl設計.Location = new Point(138, 575);
            pnl設計.Name = "pnl設計";
            pnl設計.Size = new Size(85, 60);
            pnl設計.TabIndex = 30;
            // 
            // lbl設計
            // 
            lbl設計.Dock = DockStyle.Top;
            lbl設計.Location = new Point(0, 0);
            lbl設計.Name = "lbl設計";
            lbl設計.Size = new Size(83, 20);
            lbl設計.TabIndex = 0;
            lbl設計.Text = "設計";
            lbl設計.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnl電控
            // 
            pnl電控.BorderStyle = BorderStyle.FixedSingle;
            pnl電控.Controls.Add(lbl電控);
            pnl電控.Location = new Point(228, 575);
            pnl電控.Name = "pnl電控";
            pnl電控.Size = new Size(85, 60);
            pnl電控.TabIndex = 31;
            // 
            // lbl電控
            // 
            lbl電控.Dock = DockStyle.Top;
            lbl電控.Location = new Point(0, 0);
            lbl電控.Name = "lbl電控";
            lbl電控.Size = new Size(83, 20);
            lbl電控.TabIndex = 0;
            lbl電控.Text = "電控";
            lbl電控.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnl製造
            // 
            pnl製造.BorderStyle = BorderStyle.FixedSingle;
            pnl製造.Controls.Add(lbl製造);
            pnl製造.Location = new Point(318, 575);
            pnl製造.Name = "pnl製造";
            pnl製造.Size = new Size(85, 60);
            pnl製造.TabIndex = 32;
            // 
            // lbl製造
            // 
            lbl製造.Dock = DockStyle.Top;
            lbl製造.Location = new Point(0, 0);
            lbl製造.Name = "lbl製造";
            lbl製造.Size = new Size(83, 20);
            lbl製造.TabIndex = 0;
            lbl製造.Text = "製造";
            lbl製造.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnl組測
            // 
            pnl組測.BorderStyle = BorderStyle.FixedSingle;
            pnl組測.Controls.Add(lbl組測);
            pnl組測.Location = new Point(408, 575);
            pnl組測.Name = "pnl組測";
            pnl組測.Size = new Size(85, 60);
            pnl組測.TabIndex = 33;
            // 
            // lbl組測
            // 
            lbl組測.Dock = DockStyle.Top;
            lbl組測.Location = new Point(0, 0);
            lbl組測.Name = "lbl組測";
            lbl組測.Size = new Size(83, 20);
            lbl組測.TabIndex = 0;
            lbl組測.Text = "組測";
            lbl組測.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnl物管
            // 
            pnl物管.BorderStyle = BorderStyle.FixedSingle;
            pnl物管.Controls.Add(lbl物管);
            pnl物管.Location = new Point(498, 575);
            pnl物管.Name = "pnl物管";
            pnl物管.Size = new Size(85, 60);
            pnl物管.TabIndex = 34;
            // 
            // lbl物管
            // 
            lbl物管.Dock = DockStyle.Top;
            lbl物管.Location = new Point(0, 0);
            lbl物管.Name = "lbl物管";
            lbl物管.Size = new Size(83, 20);
            lbl物管.TabIndex = 0;
            lbl物管.Text = "物管";
            lbl物管.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnl採購
            // 
            pnl採購.BorderStyle = BorderStyle.FixedSingle;
            pnl採購.Controls.Add(lbl採購);
            pnl採購.Location = new Point(588, 575);
            pnl採購.Name = "pnl採購";
            pnl採購.Size = new Size(85, 60);
            pnl採購.TabIndex = 35;
            // 
            // lbl採購
            // 
            lbl採購.Dock = DockStyle.Top;
            lbl採購.Location = new Point(0, 0);
            lbl採購.Name = "lbl採購";
            lbl採購.Size = new Size(83, 20);
            lbl採購.TabIndex = 0;
            lbl採購.Text = "採購";
            lbl採購.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnl管理
            // 
            pnl管理.BorderStyle = BorderStyle.FixedSingle;
            pnl管理.Controls.Add(lbl管理);
            pnl管理.Location = new Point(678, 575);
            pnl管理.Name = "pnl管理";
            pnl管理.Size = new Size(85, 60);
            pnl管理.TabIndex = 36;
            // 
            // lbl管理
            // 
            lbl管理.Dock = DockStyle.Top;
            lbl管理.Location = new Point(0, 0);
            lbl管理.Name = "lbl管理";
            lbl管理.Size = new Size(83, 20);
            lbl管理.TabIndex = 0;
            lbl管理.Text = "管理";
            lbl管理.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnl總經理
            // 
            pnl總經理.BorderStyle = BorderStyle.FixedSingle;
            pnl總經理.Controls.Add(lbl總經理);
            pnl總經理.Location = new Point(8, 690);
            pnl總經理.Name = "pnl總經理";
            pnl總經理.Size = new Size(160, 40);
            pnl總經理.TabIndex = 37;
            // 
            // lbl總經理
            // 
            lbl總經理.Dock = DockStyle.Fill;
            lbl總經理.Location = new Point(0, 0);
            lbl總經理.Name = "lbl總經理";
            lbl總經理.Size = new Size(158, 38);
            lbl總經理.TabIndex = 0;
            lbl總經理.Text = "總經理";
            // 
            // lbl核准人員
            // 
            lbl核准人員.Location = new Point(8, 645);
            lbl核准人員.Name = "lbl核准人員";
            lbl核准人員.Size = new Size(70, 21);
            lbl核准人員.TabIndex = 38;
            lbl核准人員.Text = "核准人員";
            lbl核准人員.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt核准人員
            // 
            txt核准人員.Location = new Point(80, 645);
            txt核准人員.Name = "txt核准人員";
            txt核准人員.ReadOnly = true;
            txt核准人員.Size = new Size(160, 23);
            txt核准人員.TabIndex = 39;
            // 
            // lbl核准日
            // 
            lbl核准日.Location = new Point(250, 690);
            lbl核准日.Name = "lbl核准日";
            lbl核准日.Size = new Size(70, 21);
            lbl核准日.TabIndex = 40;
            lbl核准日.Text = "核准日";
            lbl核准日.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt核准日
            // 
            txt核准日.Location = new Point(322, 690);
            txt核准日.Name = "txt核准日";
            txt核准日.ReadOnly = true;
            txt核准日.Size = new Size(160, 23);
            txt核准日.TabIndex = 41;
            // 
            // lbl建檔人員
            // 
            lbl建檔人員.Location = new Point(500, 690);
            lbl建檔人員.Name = "lbl建檔人員";
            lbl建檔人員.Size = new Size(70, 21);
            lbl建檔人員.TabIndex = 42;
            lbl建檔人員.Text = "建檔人員";
            lbl建檔人員.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt建檔人員
            // 
            txt建檔人員.Location = new Point(572, 690);
            txt建檔人員.Name = "txt建檔人員";
            txt建檔人員.ReadOnly = true;
            txt建檔人員.Size = new Size(160, 23);
            txt建檔人員.TabIndex = 43;
            // 
            // lbl建檔日
            // 
            lbl建檔日.Location = new Point(250, 645);
            lbl建檔日.Name = "lbl建檔日";
            lbl建檔日.Size = new Size(70, 21);
            lbl建檔日.TabIndex = 44;
            lbl建檔日.Text = "建檔日";
            lbl建檔日.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt建檔日
            // 
            txt建檔日.Location = new Point(322, 645);
            txt建檔日.Name = "txt建檔日";
            txt建檔日.ReadOnly = true;
            txt建檔日.Size = new Size(160, 23);
            txt建檔日.TabIndex = 45;
            // 
            // lblNote
            // 
            lblNote.ForeColor = Color.DimGray;
            lblNote.Location = new Point(8, 740);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(775, 24);
            lblNote.TabIndex = 46;
            lblNote.Text = "說明：總經理審核→會辦簽收→正本留存→各部門執行→物件回饋物管→物管填入庫單→業務填銷貨單";
            // 
            // btnPreviewPrint
            // 
            btnPreviewPrint.BackColor = Color.FromArgb(69, 98, 135);
            btnPreviewPrint.FlatStyle = FlatStyle.Flat;
            btnPreviewPrint.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnPreviewPrint.ForeColor = Color.White;
            btnPreviewPrint.Location = new Point(560, 8);
            btnPreviewPrint.Name = "btnPreviewPrint";
            btnPreviewPrint.Size = new Size(110, 30);
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
            btnPrint.Location = new Point(680, 8);
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
            btnExit.Location = new Point(770, 8);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(90, 30);
            btnExit.TabIndex = 3;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // FrmAccessoriesApplyPrint
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(963, 798);
            Controls.Add(pnlContent);
            Controls.Add(btnPreviewPrint);
            Controls.Add(btnPrint);
            Controls.Add(btnExit);
            Font = new Font("微軟正黑體", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmAccessoriesApplyPrint";
            StartPosition = FormStartPosition.CenterParent;
            Text = "零件工令單 - 預覽列印";
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            pnl廠長.ResumeLayout(false);
            pnl設計.ResumeLayout(false);
            pnl電控.ResumeLayout(false);
            pnl製造.ResumeLayout(false);
            pnl組測.ResumeLayout(false);
            pnl物管.ResumeLayout(false);
            pnl採購.ResumeLayout(false);
            pnl管理.ResumeLayout(false);
            pnl總經理.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlContent;
        private Label lblTitle;
        private Button btnPreviewPrint;
        private Button btnPrint;
        private Button btnExit;
        private Label lbl單號; private TextBox txt單號;
        private Label lbl申請日期; private TextBox txt申請日期;
        private Label lbl申請用途; private TextBox txt申請用途;
        private Label lbl專案序號; private TextBox txt專案序號;
        private Label lbl客戶名稱; private TextBox txt客戶名稱;
        private Label lbl申請人; private TextBox txt申請人;
        private Label lbl運送方式; private TextBox txt運送方式;
        private Label lbl收費機制; private TextBox txt收費機制;
        private Label lbl交貨日期; private TextBox txt交貨日期;
        private Label lbl機台名稱; private TextBox txt機台名稱;
        private Label lbl保固效期; private TextBox txt保固效期;
        private Label lbl機台型號; private TextBox txt機台型號;
        private Label lbl主旨; private TextBox txt主旨;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colPartType;
        private DataGridViewTextBoxColumn colPartNo;
        private DataGridViewTextBoxColumn colItemName;
        private DataGridViewTextBoxColumn colDesc;
        private DataGridViewTextBoxColumn colUnit;
        private DataGridViewTextBoxColumn colQty;
        private DataGridViewTextBoxColumn colOwner;
        private DataGridViewTextBoxColumn colRemark;
        private Label lblSign;
        private Panel pnl廠長; private Label lbl廠長;
        private Panel pnl設計; private Label lbl設計;
        private Panel pnl電控; private Label lbl電控;
        private Panel pnl製造; private Label lbl製造;
        private Panel pnl組測; private Label lbl組測;
        private Panel pnl物管; private Label lbl物管;
        private Panel pnl採購; private Label lbl採購;
        private Panel pnl管理; private Label lbl管理;
        private Panel pnl總經理; private Label lbl總經理;
        private Label lbl核准人員; private TextBox txt核准人員;
        private Label lbl核准日; private TextBox txt核准日;
        private Label lbl建檔人員; private TextBox txt建檔人員;
        private Label lbl建檔日; private TextBox txt建檔日;
        private Label lblNote;
    }
}
