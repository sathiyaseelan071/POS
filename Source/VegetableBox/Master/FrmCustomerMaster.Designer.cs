namespace VegetableBox
{
    partial class FrmCustomerMaster
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            TlpMain = new TableLayoutPanel();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            LblVendorName = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            BtnSave = new Button();
            BtnCancel = new Button();
            TxtCustomerName = new TextBox();
            LblMobileNo = new Label();
            TxtMobileNo = new TextBox();
            LblAddress = new Label();
            TxtAddress = new TextBox();
            LblActive = new Label();
            CmbActive = new ComboBox();
            panel2 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            DGView = new DataGridView();
            tableLayoutPanel4 = new TableLayoutPanel();
            BtnExit = new Button();
            BtnEdit = new Button();
            BtnDelete = new Button();
            LblHelp = new Label();
            PanelFilter = new Panel();
            tableLayoutPanel5 = new TableLayoutPanel();
            LblFilters = new Label();
            LblFilterVendor = new Label();
            TxtFilterVendor = new TextBox();
            CmbFilterActive = new ComboBox();
            LblFilterActive = new Label();
            ErrorProvider = new ErrorProvider(components);
            TlpForm = new TableLayoutPanel();
            TlpMain.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGView).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            PanelFilter.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ErrorProvider).BeginInit();
            TlpForm.SuspendLayout();
            SuspendLayout();
            // 
            // TlpMain
            // 
            TlpMain.BackColor = SystemColors.Control;
            TlpMain.ColumnCount = 4;
            TlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 0.9933658F));
            TlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.36868F));
            TlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63.643528F));
            TlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 0.9944301F));
            TlpMain.Controls.Add(panel1, 1, 2);
            TlpMain.Controls.Add(panel2, 2, 1);
            TlpMain.Dock = DockStyle.Fill;
            TlpMain.ForeColor = SystemColors.ControlText;
            TlpMain.Location = new Point(5, 5);
            TlpMain.Margin = new Padding(5);
            TlpMain.Name = "TlpMain";
            TlpMain.RowCount = 5;
            TlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 7.86933374F));
            TlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 21.1320019F));
            TlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 44.6154556F));
            TlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 18.51388F));
            TlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 7.86933374F));
            TlpMain.Size = new Size(1129, 492);
            TlpMain.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(14, 145);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(382, 211);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3.022623F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 93.95475F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3.022624F));
            tableLayoutPanel1.Controls.Add(LblVendorName, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 2, 6);
            tableLayoutPanel1.Controls.Add(TxtCustomerName, 2, 1);
            tableLayoutPanel1.Controls.Add(LblMobileNo, 1, 2);
            tableLayoutPanel1.Controls.Add(TxtMobileNo, 2, 2);
            tableLayoutPanel1.Controls.Add(LblAddress, 1, 3);
            tableLayoutPanel1.Controls.Add(TxtAddress, 2, 3);
            tableLayoutPanel1.Controls.Add(LblActive, 1, 4);
            tableLayoutPanel1.Controls.Add(CmbActive, 2, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 1.935238F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.0232639F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.0232639F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.0232639F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.0171947F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.0232754F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.0192642F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 1.935238F));
            tableLayoutPanel1.Size = new Size(380, 209);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // LblVendorName
            // 
            LblVendorName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblVendorName.AutoSize = true;
            LblVendorName.ForeColor = Color.FromArgb(163, 0, 34);
            LblVendorName.Location = new Point(10, 11);
            LblVendorName.Name = "LblVendorName";
            LblVendorName.Size = new Size(115, 18);
            LblVendorName.TabIndex = 0;
            LblVendorName.Text = "Customer Name*";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.181818F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.9090919F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.9090919F));
            tableLayoutPanel2.Controls.Add(BtnSave, 1, 0);
            tableLayoutPanel2.Controls.Add(BtnCancel, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(128, 169);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(243, 33);
            tableLayoutPanel2.TabIndex = 10;
            // 
            // BtnSave
            // 
            BtnSave.BackColor = SystemColors.Control;
            BtnSave.Dock = DockStyle.Fill;
            BtnSave.ForeColor = Color.DarkGreen;
            BtnSave.Location = new Point(47, 3);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(93, 27);
            BtnSave.TabIndex = 0;
            BtnSave.Text = "&Save";
            BtnSave.UseVisualStyleBackColor = false;
            BtnSave.Click += BtnSave_Click;
            // 
            // BtnCancel
            // 
            BtnCancel.BackColor = SystemColors.Control;
            BtnCancel.Dock = DockStyle.Fill;
            BtnCancel.ForeColor = Color.Red;
            BtnCancel.Location = new Point(146, 3);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(94, 27);
            BtnCancel.TabIndex = 1;
            BtnCancel.Text = "&Cancel";
            BtnCancel.UseVisualStyleBackColor = false;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // TxtCustomerName
            // 
            TxtCustomerName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtCustomerName.BackColor = Color.White;
            TxtCustomerName.ForeColor = Color.DarkGreen;
            TxtCustomerName.Location = new Point(131, 7);
            TxtCustomerName.MaxLength = 100;
            TxtCustomerName.Name = "TxtCustomerName";
            TxtCustomerName.Size = new Size(237, 26);
            TxtCustomerName.TabIndex = 1;
            TxtCustomerName.Enter += TextBox_Enter;
            TxtCustomerName.Leave += TextBox_Leave;
            // 
            // LblMobileNo
            // 
            LblMobileNo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblMobileNo.AutoSize = true;
            LblMobileNo.ForeColor = Color.FromArgb(163, 0, 34);
            LblMobileNo.Location = new Point(10, 44);
            LblMobileNo.Name = "LblMobileNo";
            LblMobileNo.Size = new Size(115, 18);
            LblMobileNo.TabIndex = 4;
            LblMobileNo.Text = "Mobile No";
            // 
            // TxtMobileNo
            // 
            TxtMobileNo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtMobileNo.BackColor = Color.White;
            TxtMobileNo.ForeColor = Color.DarkGreen;
            TxtMobileNo.Location = new Point(131, 40);
            TxtMobileNo.MaxLength = 10;
            TxtMobileNo.Name = "TxtMobileNo";
            TxtMobileNo.Size = new Size(237, 26);
            TxtMobileNo.TabIndex = 5;
            TxtMobileNo.Enter += TextBox_Enter;
            TxtMobileNo.KeyPress += Number_KeyPress;
            TxtMobileNo.Leave += TextBox_Leave;
            // 
            // LblAddress
            // 
            LblAddress.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblAddress.AutoSize = true;
            LblAddress.ForeColor = Color.FromArgb(163, 0, 34);
            LblAddress.Location = new Point(10, 77);
            LblAddress.Name = "LblAddress";
            LblAddress.Size = new Size(115, 18);
            LblAddress.TabIndex = 6;
            LblAddress.Text = "Address";
            // 
            // TxtAddress
            // 
            TxtAddress.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtAddress.BackColor = Color.White;
            TxtAddress.ForeColor = Color.DarkGreen;
            TxtAddress.Location = new Point(131, 73);
            TxtAddress.MaxLength = 200;
            TxtAddress.Name = "TxtAddress";
            TxtAddress.Size = new Size(237, 26);
            TxtAddress.TabIndex = 7;
            TxtAddress.Enter += TextBox_Enter;
            TxtAddress.Leave += TextBox_Leave;
            // 
            // LblActive
            // 
            LblActive.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblActive.AutoSize = true;
            LblActive.ForeColor = Color.FromArgb(163, 0, 34);
            LblActive.Location = new Point(10, 110);
            LblActive.Name = "LblActive";
            LblActive.Size = new Size(115, 18);
            LblActive.TabIndex = 8;
            LblActive.Text = "Active*";
            // 
            // CmbActive
            // 
            CmbActive.Anchor = AnchorStyles.Left;
            CmbActive.BackColor = Color.White;
            CmbActive.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbActive.FlatStyle = FlatStyle.Flat;
            CmbActive.ForeColor = Color.DarkGreen;
            CmbActive.FormattingEnabled = true;
            CmbActive.Location = new Point(131, 108);
            CmbActive.Name = "CmbActive";
            CmbActive.Size = new Size(121, 26);
            CmbActive.TabIndex = 9;
            CmbActive.Enter += ComboBox_Enter;
            CmbActive.Leave += ComboBox_Leave;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(tableLayoutPanel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(402, 41);
            panel2.Name = "panel2";
            TlpMain.SetRowSpan(panel2, 3);
            panel2.Size = new Size(712, 407);
            panel2.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(DGView, 0, 1);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 2);
            tableLayoutPanel3.Controls.Add(PanelFilter, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.3909779F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 73.93939F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 9.69697F));
            tableLayoutPanel3.Size = new Size(710, 405);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // DGView
            // 
            DGView.AllowUserToAddRows = false;
            DGView.AllowUserToDeleteRows = false;
            DGView.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DGView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DGView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.SelectionForeColor = Color.ForestGreen;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DGView.DefaultCellStyle = dataGridViewCellStyle2;
            DGView.Dock = DockStyle.Fill;
            DGView.Location = new Point(5, 69);
            DGView.Margin = new Padding(5, 3, 3, 3);
            DGView.MultiSelect = false;
            DGView.Name = "DGView";
            DGView.ReadOnly = true;
            DGView.RowHeadersVisible = false;
            DGView.RowTemplate.Height = 25;
            DGView.Size = new Size(702, 293);
            DGView.TabIndex = 0;
            DGView.CellEnter += DGView_CellEnter;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 4;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.0851059F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.638298F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.638298F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.638298F));
            tableLayoutPanel4.Controls.Add(BtnExit, 3, 0);
            tableLayoutPanel4.Controls.Add(BtnEdit, 2, 0);
            tableLayoutPanel4.Controls.Add(BtnDelete, 1, 0);
            tableLayoutPanel4.Controls.Add(LblHelp, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 368);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(704, 34);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // BtnExit
            // 
            BtnExit.BackColor = SystemColors.Control;
            BtnExit.Dock = DockStyle.Fill;
            BtnExit.ForeColor = Color.Crimson;
            BtnExit.Location = new Point(630, 3);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(71, 28);
            BtnExit.TabIndex = 3;
            BtnExit.Text = "E&xit";
            BtnExit.UseVisualStyleBackColor = false;
            BtnExit.Click += BtnExit_Click;
            // 
            // BtnEdit
            // 
            BtnEdit.BackColor = SystemColors.Control;
            BtnEdit.Dock = DockStyle.Fill;
            BtnEdit.ForeColor = Color.Brown;
            BtnEdit.Location = new Point(556, 3);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(68, 28);
            BtnEdit.TabIndex = 2;
            BtnEdit.Text = "&Edit";
            BtnEdit.UseVisualStyleBackColor = false;
            BtnEdit.Click += BtnEdit_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.BackColor = SystemColors.Control;
            BtnDelete.Dock = DockStyle.Fill;
            BtnDelete.ForeColor = Color.IndianRed;
            BtnDelete.Location = new Point(482, 3);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(68, 28);
            BtnDelete.TabIndex = 1;
            BtnDelete.Text = "&Delete";
            BtnDelete.UseVisualStyleBackColor = false;
            BtnDelete.Visible = false;
            // 
            // LblHelp
            // 
            LblHelp.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblHelp.AutoSize = true;
            LblHelp.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LblHelp.ForeColor = Color.DarkRed;
            LblHelp.Location = new Point(3, 9);
            LblHelp.Name = "LblHelp";
            LblHelp.Size = new Size(473, 15);
            LblHelp.TabIndex = 0;
            LblHelp.Text = "Focus : Ctrl + G => Grid View && F1 => Filter";
            // 
            // PanelFilter
            // 
            PanelFilter.BorderStyle = BorderStyle.FixedSingle;
            PanelFilter.Controls.Add(tableLayoutPanel5);
            PanelFilter.Dock = DockStyle.Fill;
            PanelFilter.Location = new Point(3, 3);
            PanelFilter.Name = "PanelFilter";
            PanelFilter.Size = new Size(704, 60);
            PanelFilter.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 8;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3.5638814F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.9053421F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.60825F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4.435489F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.5973148F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.8897228F));
            tableLayoutPanel5.Controls.Add(LblFilters, 0, 1);
            tableLayoutPanel5.Controls.Add(LblFilterVendor, 1, 2);
            tableLayoutPanel5.Controls.Add(TxtFilterVendor, 2, 2);
            tableLayoutPanel5.Controls.Add(CmbFilterActive, 6, 2);
            tableLayoutPanel5.Controls.Add(LblFilterActive, 5, 2);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 4;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 10.7382545F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 26.1744957F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 52.34899F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 10.7382565F));
            tableLayoutPanel5.Size = new Size(702, 58);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // LblFilters
            // 
            LblFilters.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblFilters.AutoSize = true;
            tableLayoutPanel5.SetColumnSpan(LblFilters, 2);
            LblFilters.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            LblFilters.ForeColor = Color.DarkGreen;
            LblFilters.Location = new Point(3, 6);
            LblFilters.Name = "LblFilters";
            LblFilters.Size = new Size(130, 15);
            LblFilters.TabIndex = 0;
            LblFilters.Text = "Filters";
            // 
            // LblFilterVendor
            // 
            LblFilterVendor.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblFilterVendor.AutoSize = true;
            LblFilterVendor.ForeColor = Color.FromArgb(163, 0, 34);
            LblFilterVendor.Location = new Point(21, 27);
            LblFilterVendor.Name = "LblFilterVendor";
            LblFilterVendor.Size = new Size(112, 18);
            LblFilterVendor.TabIndex = 1;
            LblFilterVendor.Text = "Customer Search";
            // 
            // TxtFilterVendor
            // 
            TxtFilterVendor.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtFilterVendor.BackColor = Color.White;
            tableLayoutPanel5.SetColumnSpan(TxtFilterVendor, 2);
            TxtFilterVendor.ForeColor = Color.DarkGreen;
            TxtFilterVendor.Location = new Point(139, 24);
            TxtFilterVendor.MaxLength = 25;
            TxtFilterVendor.Name = "TxtFilterVendor";
            TxtFilterVendor.Size = new Size(283, 26);
            TxtFilterVendor.TabIndex = 2;
            TxtFilterVendor.TextChanged += TxtFilterProduct_TextChanged;
            TxtFilterVendor.Enter += TextBox_Enter;
            TxtFilterVendor.Leave += TextBox_Leave;
            // 
            // CmbFilterActive
            // 
            CmbFilterActive.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CmbFilterActive.BackColor = Color.White;
            CmbFilterActive.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbFilterActive.FlatStyle = FlatStyle.Flat;
            CmbFilterActive.ForeColor = Color.DarkGreen;
            CmbFilterActive.FormattingEnabled = true;
            CmbFilterActive.Location = new Point(504, 24);
            CmbFilterActive.Name = "CmbFilterActive";
            CmbFilterActive.Size = new Size(82, 26);
            CmbFilterActive.TabIndex = 4;
            CmbFilterActive.SelectedIndexChanged += CmbFilterQtyType_SelectedIndexChanged;
            CmbFilterActive.Enter += ComboBox_Enter;
            CmbFilterActive.Leave += ComboBox_Leave;
            // 
            // LblFilterActive
            // 
            LblFilterActive.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblFilterActive.AutoSize = true;
            LblFilterActive.ForeColor = Color.FromArgb(163, 0, 34);
            LblFilterActive.Location = new Point(451, 27);
            LblFilterActive.Name = "LblFilterActive";
            LblFilterActive.Size = new Size(47, 18);
            LblFilterActive.TabIndex = 3;
            LblFilterActive.Text = "Active";
            // 
            // ErrorProvider
            // 
            ErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            ErrorProvider.ContainerControl = this;
            // 
            // TlpForm
            // 
            TlpForm.BackColor = Color.WhiteSmoke;
            TlpForm.ColumnCount = 1;
            TlpForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TlpForm.Controls.Add(TlpMain, 0, 0);
            TlpForm.Dock = DockStyle.Fill;
            TlpForm.ForeColor = SystemColors.ControlText;
            TlpForm.Location = new Point(5, 5);
            TlpForm.Name = "TlpForm";
            TlpForm.RowCount = 1;
            TlpForm.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TlpForm.Size = new Size(1139, 502);
            TlpForm.TabIndex = 1;
            // 
            // FrmCustomerMaster
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1149, 512);
            Controls.Add(TlpForm);
            Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(0, 64, 0);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmCustomerMaster";
            Padding = new Padding(5);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Customer - Master";
            Activated += FrmCustomerMaster_Activated;
            Load += FrmCustomerMaster_Load;
            KeyDown += FrmCustomerMaster_KeyDown;
            TlpMain.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGView).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            PanelFilter.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ErrorProvider).EndInit();
            TlpForm.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TlpMain;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label LblVendorName;
        private Label LblActive;
        private TableLayoutPanel tableLayoutPanel2;
        private Button BtnSave;
        private Button BtnCancel;
        private TextBox TxtCustomerName;
        private ComboBox CmbActive;
        private DataGridView DGView;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel4;
        private Button BtnEdit;
        private Button BtnDelete;
        private TableLayoutPanel tableLayoutPanel3;
        private Button BtnExit;
        private TableLayoutPanel tableLayoutPanel5;
        private Label LblFilterActive;
        private Label LblFilterVendor;
        private ComboBox CmbFilterActive;
        private TextBox TxtFilterVendor;
        private Panel PanelFilter;
        private Label LblFilters;
        private ErrorProvider ErrorProvider;
        private Label LblHelp;
        private Label LblMobileNo;
        private TextBox TxtMobileNo;
        private Label LblAddress;
        private TextBox TxtAddress;
        private TableLayoutPanel TlpForm;
    }
}