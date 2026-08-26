using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.Order
{
    partial class WorkOrderListControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkOrderListControl));
            panelHeader = new Panel();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            lblProjectNo = new Label();
            txtProjectNo = new TextBox();
            lblCustName = new Label();
            txtCustName = new TextBox();
            lblMachineType = new Label();
            cmbMachineType = new ComboBox();
            chkOnlyOpen = new CheckBox();
            btnQuery = new Button();
            btnAddFromOrder = new Button();
            btnCompare = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            btnExit = new Button();
            panelBody = new Panel();
            dataGridView1 = new DataGridView();
            colProjectNo = new DataGridViewTextBoxColumn();
            colOrderDate = new DataGridViewTextBoxColumn();
            colCustName = new DataGridViewTextBoxColumn();
            colCountry = new DataGridViewTextBoxColumn();
            colRefNo = new DataGridViewTextBoxColumn();
            colMachineType = new DataGridViewTextBoxColumn();
            colMachineModel = new DataGridViewTextBoxColumn();
            colMachineName = new DataGridViewTextBoxColumn();
            colTestDate = new DataGridViewTextBoxColumn();
            colFactoryTest = new DataGridViewTextBoxColumn();
            colDeliveryDate = new DataGridViewTextBoxColumn();
            colInstall = new DataGridViewTextBoxColumn();
            colClosed = new DataGridViewCheckBoxColumn();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.Moccasin;
            panelHeader.Controls.Add(pictureBox1);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Controls.Add(lblProjectNo);
            panelHeader.Controls.Add(txtProjectNo);
            panelHeader.Controls.Add(lblCustName);
            panelHeader.Controls.Add(txtCustName);
            panelHeader.Controls.Add(lblMachineType);
            panelHeader.Controls.Add(cmbMachineType);
            panelHeader.Controls.Add(chkOnlyOpen);
            panelHeader.Controls.Add(btnQuery);
            panelHeader.Controls.Add(btnAddFromOrder);
            panelHeader.Controls.Add(btnCompare);
            panelHeader.Controls.Add(btnAdd);
            panelHeader.Controls.Add(btnDelete);
            panelHeader.Controls.Add(btnExit);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1300, 90);
            panelHeader.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("微軟正黑體", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Firebrick;
            lblTitle.Location = new Point(58, 8);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(105, 24);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "工令單總覽";
            // 
            // lblProjectNo
            // 
            lblProjectNo.AutoSize = true;
            lblProjectNo.Location = new Point(60, 42);
            lblProjectNo.Name = "lblProjectNo";
            lblProjectNo.Size = new Size(64, 18);
            lblProjectNo.TabIndex = 2;
            lblProjectNo.Text = "專案序號";
            // 
            // txtProjectNo
            // 
            txtProjectNo.Location = new Point(136, 39);
            txtProjectNo.Name = "txtProjectNo";
            txtProjectNo.Size = new Size(110, 25);
            txtProjectNo.TabIndex = 3;
            // 
            // lblCustName
            // 
            lblCustName.AutoSize = true;
            lblCustName.Location = new Point(257, 42);
            lblCustName.Name = "lblCustName";
            lblCustName.Size = new Size(64, 18);
            lblCustName.TabIndex = 4;
            lblCustName.Text = "客戶簡稱";
            // 
            // txtCustName
            // 
            txtCustName.Location = new Point(331, 39);
            txtCustName.Name = "txtCustName";
            txtCustName.Size = new Size(120, 25);
            txtCustName.TabIndex = 5;
            // 
            // lblMachineType
            // 
            lblMachineType.AutoSize = true;
            lblMachineType.Location = new Point(464, 42);
            lblMachineType.Name = "lblMachineType";
            lblMachineType.Size = new Size(64, 18);
            lblMachineType.TabIndex = 6;
            lblMachineType.Text = "機台類型";
            // 
            // cmbMachineType
            // 
            cmbMachineType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMachineType.Items.AddRange(new object[] { "", "S", "PJ", "FB", "GT", "G", "M", "H" });
            cmbMachineType.Location = new Point(541, 39);
            cmbMachineType.Name = "cmbMachineType";
            cmbMachineType.Size = new Size(80, 25);
            cmbMachineType.TabIndex = 7;
            // 
            // chkOnlyOpen
            // 
            chkOnlyOpen.AutoSize = true;
            chkOnlyOpen.Location = new Point(640, 41);
            chkOnlyOpen.Name = "chkOnlyOpen";
            chkOnlyOpen.Size = new Size(111, 22);
            chkOnlyOpen.TabIndex = 8;
            chkOnlyOpen.Text = "僅顯示未結案";
            chkOnlyOpen.UseVisualStyleBackColor = true;
            // 
            // btnQuery
            // 
            btnQuery.BackColor = Color.LightSteelBlue;
            btnQuery.FlatStyle = FlatStyle.Flat;
            btnQuery.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnQuery.Location = new Point(808, 40);
            btnQuery.Name = "btnQuery";
            btnQuery.Size = new Size(70, 30);
            btnQuery.TabIndex = 9;
            btnQuery.Text = "查詢";
            btnQuery.UseVisualStyleBackColor = false;
            btnQuery.Click += btnQuery_Click;
            // 
            // btnAddFromOrder
            // 
            btnAddFromOrder.BackColor = Color.PaleGoldenrod;
            btnAddFromOrder.FlatStyle = FlatStyle.Flat;
            btnAddFromOrder.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnAddFromOrder.Location = new Point(808, 4);
            btnAddFromOrder.Name = "btnAddFromOrder";
            btnAddFromOrder.Size = new Size(112, 30);
            btnAddFromOrder.TabIndex = 13;
            btnAddFromOrder.Text = "自訂單新增機台";
            btnAddFromOrder.UseVisualStyleBackColor = false;
            btnAddFromOrder.Click += btnAddFromOrder_Click;
            // 
            // btnCompare
            // 
            btnCompare.BackColor = Color.LightCyan;
            btnCompare.FlatStyle = FlatStyle.Flat;
            btnCompare.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnCompare.Location = new Point(884, 40);
            btnCompare.Name = "btnCompare";
            btnCompare.Size = new Size(134, 30);
            btnCompare.TabIndex = 14;
            btnCompare.Text = "開啟對照工令單";
            btnCompare.UseVisualStyleBackColor = false;
            btnCompare.Click += btnCompare_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LightGreen;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnAdd.Location = new Point(924, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(128, 32);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "直接新增機台專案";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.LightCoral;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnDelete.Location = new Point(1060, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 32);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "刪除工令單";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Gainsboro;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnExit.Location = new Point(1196, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(90, 32);
            btnExit.TabIndex = 12;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // panelBody
            // 
            panelBody.Controls.Add(dataGridView1);
            panelBody.Dock = DockStyle.Fill;
            panelBody.Location = new Point(0, 90);
            panelBody.Name = "panelBody";
            panelBody.Size = new Size(1300, 566);
            panelBody.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colProjectNo, colOrderDate, colCustName, colCountry, colRefNo, colMachineType, colMachineModel, colMachineName, colTestDate, colFactoryTest, colDeliveryDate, colInstall, colClosed });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Font = new Font("微軟正黑體", 9F);
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 26;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1300, 566);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // colProjectNo
            // 
            colProjectNo.HeaderText = "專案序號";
            colProjectNo.Name = "colProjectNo";
            colProjectNo.ReadOnly = true;
            // 
            // colOrderDate
            // 
            colOrderDate.HeaderText = "訂單日期";
            colOrderDate.Name = "colOrderDate";
            colOrderDate.ReadOnly = true;
            // 
            // colCustName
            // 
            colCustName.HeaderText = "客戶簡稱";
            colCustName.Name = "colCustName";
            colCustName.ReadOnly = true;
            // 
            // colCountry
            // 
            colCountry.HeaderText = "國家地區";
            colCountry.Name = "colCountry";
            colCountry.ReadOnly = true;
            // 
            // colRefNo
            // 
            colRefNo.HeaderText = "參考序號";
            colRefNo.Name = "colRefNo";
            colRefNo.ReadOnly = true;
            // 
            // colMachineType
            // 
            colMachineType.HeaderText = "機台類型";
            colMachineType.Name = "colMachineType";
            colMachineType.ReadOnly = true;
            // 
            // colMachineModel
            // 
            colMachineModel.HeaderText = "機台型號";
            colMachineModel.Name = "colMachineModel";
            colMachineModel.ReadOnly = true;
            // 
            // colMachineName
            // 
            colMachineName.HeaderText = "機台名稱";
            colMachineName.Name = "colMachineName";
            colMachineName.ReadOnly = true;
            // 
            // colTestDate
            // 
            colTestDate.HeaderText = "驗機日期";
            colTestDate.Name = "colTestDate";
            colTestDate.ReadOnly = true;
            // 
            // colFactoryTest
            // 
            colFactoryTest.HeaderText = "廠驗";
            colFactoryTest.Name = "colFactoryTest";
            colFactoryTest.ReadOnly = true;
            // 
            // colDeliveryDate
            // 
            colDeliveryDate.HeaderText = "交貨日期";
            colDeliveryDate.Name = "colDeliveryDate";
            colDeliveryDate.ReadOnly = true;
            // 
            // colInstall
            // 
            colInstall.HeaderText = "裝機";
            colInstall.Name = "colInstall";
            colInstall.ReadOnly = true;
            // 
            // colClosed
            // 
            colClosed.HeaderText = "結案";
            colClosed.Name = "colClosed";
            colClosed.ReadOnly = true;
            // 
            // WorkOrderListControl
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelBody);
            Controls.Add(panelHeader);
            Font = new Font("微軟正黑體", 10F);
            Margin = new Padding(4);
            Name = "WorkOrderListControl";
            Size = new Size(1300, 656);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private PictureBox pictureBox1;
        private Label lblTitle;
        private Label lblProjectNo;
        private TextBox txtProjectNo;
        private Label lblCustName;
        private TextBox txtCustName;
        private Label lblMachineType;
        private ComboBox cmbMachineType;
        private CheckBox chkOnlyOpen;
        private Button btnQuery;
        private Button btnAddFromOrder;
        private Button btnCompare;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnExit;
        private Panel panelBody;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colProjectNo;
        private DataGridViewTextBoxColumn colOrderDate;
        private DataGridViewTextBoxColumn colCustName;
        private DataGridViewTextBoxColumn colCountry;
        private DataGridViewTextBoxColumn colRefNo;
        private DataGridViewTextBoxColumn colMachineType;
        private DataGridViewTextBoxColumn colMachineModel;
        private DataGridViewTextBoxColumn colMachineName;
        private DataGridViewTextBoxColumn colTestDate;
        private DataGridViewTextBoxColumn colFactoryTest;
        private DataGridViewTextBoxColumn colDeliveryDate;
        private DataGridViewTextBoxColumn colInstall;
        private DataGridViewCheckBoxColumn colClosed;
    }
}
