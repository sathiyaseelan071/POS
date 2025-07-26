namespace VegetableBox
{
    partial class FrmPurchaseEntry
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            DGVPurchaseCart = new DataGridView();
            tableLayoutPanel5 = new TableLayoutPanel();
            BtnSave = new Button();
            BtnExit = new Button();
            label3 = new Label();
            LblTotalAmt = new Label();
            tableLayoutPanel6 = new TableLayoutPanel();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            DtpPurchaseDate = new DateTimePicker();
            label2 = new Label();
            TxtProductSearch = new TextBox();
            label1 = new Label();
            DgvProductSearch = new DataGridView();
            tableLayoutPanel3 = new TableLayoutPanel();
            BtnClear = new Button();
            BtnAdd = new Button();
            label6 = new Label();
            label7 = new Label();
            TxtProductName = new TextBox();
            TxtProductTamilName = new TextBox();
            label5 = new Label();
            CmbProductCategory = new ComboBox();
            tableLayoutPanel8 = new TableLayoutPanel();
            LblPurchaseRatePerKgPcs = new Label();
            label4 = new Label();
            tableLayoutPanel7 = new TableLayoutPanel();
            TxtTotPurchaseQty = new TextBox();
            LblQtyType = new Label();
            LblPurchaseWtPcs = new Label();
            TxtTotPurchaseRate = new TextBox();
            TxtPurchaseRatePerQty = new TextBox();
            LblDiscPerFromMRP = new Label();
            TxtDiscPerFromMRP = new TextBox();
            LblSellingMarginPercentage = new Label();
            TxtSellingMarginPer = new TextBox();
            LblSellingRate = new Label();
            LblMrp = new Label();
            TxtSellingRate = new TextBox();
            TxtMrp = new TextBox();
            LblDiscRateFromMRP = new Label();
            TxtDiscRateFromMRP = new TextBox();
            TxtLastPurchaseRate = new TextBox();
            TxtCurrentSellingRate = new TextBox();
            LblLastPurchaseRate = new Label();
            LblCurrentSellingRate = new Label();
            ErrorProvider = new ErrorProvider(components);
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVPurchaseCart).BeginInit();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvProductSearch).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.782608F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65.21739F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel6, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1199, 590);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(DGVPurchaseCart, 0, 1);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 3);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(420, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 5;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 62.5454559F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 7.15630865F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 8.6629F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 11.2994347F));
            tableLayoutPanel4.Size = new Size(776, 584);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // DGVPurchaseCart
            // 
            DGVPurchaseCart.AllowUserToAddRows = false;
            DGVPurchaseCart.AllowUserToDeleteRows = false;
            DGVPurchaseCart.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.IndianRed;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.SelectionForeColor = Color.IndianRed;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DGVPurchaseCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DGVPurchaseCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel4.SetColumnSpan(DGVPurchaseCart, 2);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(0, 64, 64);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.SelectionForeColor = Color.ForestGreen;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DGVPurchaseCart.DefaultCellStyle = dataGridViewCellStyle2;
            DGVPurchaseCart.Dock = DockStyle.Fill;
            DGVPurchaseCart.Location = new Point(3, 61);
            DGVPurchaseCart.MultiSelect = false;
            DGVPurchaseCart.Name = "DGVPurchaseCart";
            DGVPurchaseCart.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Maroon;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            DGVPurchaseCart.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            DGVPurchaseCart.RowHeadersVisible = false;
            tableLayoutPanel4.SetRowSpan(DGVPurchaseCart, 2);
            DGVPurchaseCart.RowTemplate.Height = 25;
            DGVPurchaseCart.Size = new Size(770, 401);
            DGVPurchaseCart.TabIndex = 0;
            DGVPurchaseCart.CellClick += DGVPurchaseCart_CellClick;
            DGVPurchaseCart.CellDoubleClick += DGVPurchaseCart_CellDoubleClick;
            DGVPurchaseCart.CellEnter += DGVPurchaseCart_CellEnter;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 5;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.Controls.Add(BtnSave, 3, 0);
            tableLayoutPanel5.Controls.Add(BtnExit, 4, 0);
            tableLayoutPanel5.Controls.Add(label3, 0, 0);
            tableLayoutPanel5.Controls.Add(LblTotalAmt, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 468);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(770, 44);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // BtnSave
            // 
            BtnSave.Dock = DockStyle.Fill;
            BtnSave.ForeColor = Color.Maroon;
            BtnSave.Location = new Point(465, 3);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(148, 38);
            BtnSave.TabIndex = 2;
            BtnSave.Text = "&Save";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // BtnExit
            // 
            BtnExit.Dock = DockStyle.Fill;
            BtnExit.ForeColor = Color.Purple;
            BtnExit.Location = new Point(619, 3);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(148, 38);
            BtnExit.TabIndex = 3;
            BtnExit.Text = "E&xit";
            BtnExit.UseVisualStyleBackColor = true;
            BtnExit.Click += BtnExit_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(2, 0);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(150, 44);
            label3.TabIndex = 0;
            label3.Text = "Total Amount : ";
            // 
            // LblTotalAmt
            // 
            LblTotalAmt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblTotalAmt.AutoSize = true;
            LblTotalAmt.Font = new Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblTotalAmt.ForeColor = Color.Crimson;
            LblTotalAmt.Location = new Point(156, 5);
            LblTotalAmt.Margin = new Padding(2, 0, 2, 0);
            LblTotalAmt.Name = "LblTotalAmt";
            LblTotalAmt.Size = new Size(150, 33);
            LblTotalAmt.TabIndex = 1;
            LblTotalAmt.Text = "...";
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Controls.Add(panel1, 0, 1);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 3);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 3;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 1.30293155F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 95.60261F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 2.931596F));
            tableLayoutPanel6.Size = new Size(411, 584);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 10);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(3);
            panel1.Size = new Size(405, 553);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tableLayoutPanel2.Controls.Add(DtpPurchaseDate, 1, 1);
            tableLayoutPanel2.Controls.Add(label2, 0, 1);
            tableLayoutPanel2.Controls.Add(TxtProductSearch, 1, 2);
            tableLayoutPanel2.Controls.Add(label1, 0, 2);
            tableLayoutPanel2.Controls.Add(DgvProductSearch, 1, 3);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 1, 8);
            tableLayoutPanel2.Controls.Add(label6, 0, 4);
            tableLayoutPanel2.Controls.Add(label7, 0, 5);
            tableLayoutPanel2.Controls.Add(TxtProductName, 1, 4);
            tableLayoutPanel2.Controls.Add(TxtProductTamilName, 1, 5);
            tableLayoutPanel2.Controls.Add(label5, 0, 6);
            tableLayoutPanel2.Controls.Add(CmbProductCategory, 1, 6);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel8, 0, 7);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 10;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 4.72776556F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7.293356F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7.293356F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 17.9756565F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7.293356F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7.293356F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7.293356F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 28.8086777F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7.293356F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 4.72776556F));
            tableLayoutPanel2.Size = new Size(397, 545);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // DtpPurchaseDate
            // 
            DtpPurchaseDate.Anchor = AnchorStyles.Left;
            DtpPurchaseDate.CustomFormat = "dd-MMM-yyyy";
            DtpPurchaseDate.Enabled = false;
            DtpPurchaseDate.Format = DateTimePickerFormat.Custom;
            DtpPurchaseDate.Location = new Point(141, 31);
            DtpPurchaseDate.Name = "DtpPurchaseDate";
            DtpPurchaseDate.Size = new Size(132, 27);
            DtpPurchaseDate.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(3, 35);
            label2.Name = "label2";
            label2.Size = new Size(132, 19);
            label2.TabIndex = 0;
            label2.Text = "Date";
            // 
            // TxtProductSearch
            // 
            TxtProductSearch.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtProductSearch.BackColor = Color.WhiteSmoke;
            TxtProductSearch.ForeColor = Color.ForestGreen;
            TxtProductSearch.Location = new Point(138, 70);
            TxtProductSearch.Margin = new Padding(0);
            TxtProductSearch.Name = "TxtProductSearch";
            TxtProductSearch.PlaceholderText = "Search for Product";
            TxtProductSearch.Size = new Size(259, 27);
            TxtProductSearch.TabIndex = 3;
            TxtProductSearch.TextChanged += TxtProductSearch_TextChanged;
            TxtProductSearch.Enter += TextBox_Enter;
            TxtProductSearch.KeyDown += TxtProductSearch_KeyDown;
            TxtProductSearch.Leave += TextBox_Leave;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(3, 74);
            label1.Name = "label1";
            label1.Size = new Size(132, 19);
            label1.TabIndex = 2;
            label1.Text = "Product  Search";
            // 
            // DgvProductSearch
            // 
            DgvProductSearch.AllowUserToAddRows = false;
            DgvProductSearch.AllowUserToDeleteRows = false;
            DgvProductSearch.AllowUserToResizeColumns = false;
            DgvProductSearch.AllowUserToResizeRows = false;
            DgvProductSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvProductSearch.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DgvProductSearch.BackgroundColor = SystemColors.Control;
            DgvProductSearch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvProductSearch.ColumnHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(0, 64, 64);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(244, 244, 244);
            dataGridViewCellStyle4.SelectionForeColor = Color.ForestGreen;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            DgvProductSearch.DefaultCellStyle = dataGridViewCellStyle4;
            DgvProductSearch.Dock = DockStyle.Fill;
            DgvProductSearch.GridColor = Color.White;
            DgvProductSearch.Location = new Point(138, 103);
            DgvProductSearch.Margin = new Padding(0);
            DgvProductSearch.MultiSelect = false;
            DgvProductSearch.Name = "DgvProductSearch";
            DgvProductSearch.ReadOnly = true;
            DgvProductSearch.RowHeadersVisible = false;
            DgvProductSearch.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            DgvProductSearch.Size = new Size(259, 97);
            DgvProductSearch.TabIndex = 4;
            DgvProductSearch.KeyDown += DgvProductSearch_KeyDown;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.5686283F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39.2156868F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39.2156868F));
            tableLayoutPanel3.Controls.Add(BtnClear, 2, 0);
            tableLayoutPanel3.Controls.Add(BtnAdd, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(138, 474);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(259, 39);
            tableLayoutPanel3.TabIndex = 12;
            // 
            // BtnClear
            // 
            BtnClear.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            BtnClear.ForeColor = Color.Purple;
            BtnClear.Location = new Point(159, 3);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(97, 33);
            BtnClear.TabIndex = 1;
            BtnClear.Text = "&Clear";
            BtnClear.UseVisualStyleBackColor = true;
            BtnClear.Click += BtnClear_Click;
            // 
            // BtnAdd
            // 
            BtnAdd.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            BtnAdd.ForeColor = Color.DarkGreen;
            BtnAdd.Location = new Point(58, 3);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(95, 33);
            BtnAdd.TabIndex = 0;
            BtnAdd.Text = "&Add";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(3, 210);
            label6.Name = "label6";
            label6.Size = new Size(132, 19);
            label6.TabIndex = 5;
            label6.Text = "Product Name";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(3, 239);
            label7.Name = "label7";
            label7.Size = new Size(132, 38);
            label7.TabIndex = 7;
            label7.Text = "Product Tamil Name";
            // 
            // TxtProductName
            // 
            TxtProductName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtProductName.BackColor = Color.WhiteSmoke;
            TxtProductName.ForeColor = Color.ForestGreen;
            TxtProductName.Location = new Point(138, 206);
            TxtProductName.Margin = new Padding(0);
            TxtProductName.Name = "TxtProductName";
            TxtProductName.Size = new Size(259, 27);
            TxtProductName.TabIndex = 6;
            TxtProductName.TextChanged += TxtProductSearch_TextChanged;
            TxtProductName.Enter += TextBox_Enter;
            TxtProductName.KeyDown += TxtProductSearch_KeyDown;
            TxtProductName.KeyPress += ReadOnlyTextBox_KeyPress;
            TxtProductName.Leave += TextBox_Leave;
            // 
            // TxtProductTamilName
            // 
            TxtProductTamilName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtProductTamilName.BackColor = Color.WhiteSmoke;
            TxtProductTamilName.ForeColor = Color.ForestGreen;
            TxtProductTamilName.Location = new Point(138, 245);
            TxtProductTamilName.Margin = new Padding(0);
            TxtProductTamilName.Name = "TxtProductTamilName";
            TxtProductTamilName.Size = new Size(259, 27);
            TxtProductTamilName.TabIndex = 8;
            TxtProductTamilName.TextChanged += TxtProductSearch_TextChanged;
            TxtProductTamilName.Enter += TextBox_Enter;
            TxtProductTamilName.KeyDown += TxtProductSearch_KeyDown;
            TxtProductTamilName.KeyPress += ReadOnlyTextBox_KeyPress;
            TxtProductTamilName.Leave += TextBox_Leave;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(3, 288);
            label5.Name = "label5";
            label5.Size = new Size(132, 19);
            label5.TabIndex = 9;
            label5.Text = "Product Category";
            // 
            // CmbProductCategory
            // 
            CmbProductCategory.Anchor = AnchorStyles.Left;
            CmbProductCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbProductCategory.Enabled = false;
            CmbProductCategory.FormattingEnabled = true;
            CmbProductCategory.Location = new Point(140, 286);
            CmbProductCategory.Margin = new Padding(2);
            CmbProductCategory.Name = "CmbProductCategory";
            CmbProductCategory.Size = new Size(101, 27);
            CmbProductCategory.TabIndex = 10;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel8.ColumnCount = 5;
            tableLayoutPanel2.SetColumnSpan(tableLayoutPanel8, 2);
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel8.Controls.Add(LblPurchaseRatePerKgPcs, 2, 0);
            tableLayoutPanel8.Controls.Add(label4, 1, 0);
            tableLayoutPanel8.Controls.Add(tableLayoutPanel7, 0, 1);
            tableLayoutPanel8.Controls.Add(LblPurchaseWtPcs, 0, 0);
            tableLayoutPanel8.Controls.Add(TxtTotPurchaseRate, 1, 1);
            tableLayoutPanel8.Controls.Add(TxtPurchaseRatePerQty, 2, 1);
            tableLayoutPanel8.Controls.Add(LblDiscPerFromMRP, 3, 2);
            tableLayoutPanel8.Controls.Add(TxtDiscPerFromMRP, 3, 3);
            tableLayoutPanel8.Controls.Add(LblSellingMarginPercentage, 2, 2);
            tableLayoutPanel8.Controls.Add(TxtSellingMarginPer, 2, 3);
            tableLayoutPanel8.Controls.Add(LblSellingRate, 1, 2);
            tableLayoutPanel8.Controls.Add(LblMrp, 0, 2);
            tableLayoutPanel8.Controls.Add(TxtSellingRate, 1, 3);
            tableLayoutPanel8.Controls.Add(TxtMrp, 0, 3);
            tableLayoutPanel8.Controls.Add(LblDiscRateFromMRP, 4, 2);
            tableLayoutPanel8.Controls.Add(TxtDiscRateFromMRP, 4, 3);
            tableLayoutPanel8.Controls.Add(TxtLastPurchaseRate, 3, 1);
            tableLayoutPanel8.Controls.Add(TxtCurrentSellingRate, 4, 1);
            tableLayoutPanel8.Controls.Add(LblLastPurchaseRate, 3, 0);
            tableLayoutPanel8.Controls.Add(LblCurrentSellingRate, 4, 0);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tableLayoutPanel8.Location = new Point(2, 319);
            tableLayoutPanel8.Margin = new Padding(2);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 4;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel8.Size = new Size(393, 153);
            tableLayoutPanel8.TabIndex = 11;
            // 
            // LblPurchaseRatePerKgPcs
            // 
            LblPurchaseRatePerKgPcs.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblPurchaseRatePerKgPcs.AutoSize = true;
            LblPurchaseRatePerKgPcs.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblPurchaseRatePerKgPcs.Location = new Point(160, 1);
            LblPurchaseRatePerKgPcs.Name = "LblPurchaseRatePerKgPcs";
            LblPurchaseRatePerKgPcs.Size = new Size(71, 37);
            LblPurchaseRatePerKgPcs.TabIndex = 2;
            LblPurchaseRatePerKgPcs.Text = "Purchase Rate Per Qty";
            LblPurchaseRatePerKgPcs.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Crimson;
            label4.Location = new Point(82, 1);
            label4.Name = "label4";
            label4.Size = new Size(71, 37);
            label4.TabIndex = 1;
            label4.Text = "Total Purchase Amount*";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel7.Controls.Add(TxtTotPurchaseQty, 0, 0);
            tableLayoutPanel7.Controls.Add(LblQtyType, 1, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(1, 39);
            tableLayoutPanel7.Margin = new Padding(0);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Size = new Size(77, 37);
            tableLayoutPanel7.TabIndex = 5;
            // 
            // TxtTotPurchaseQty
            // 
            TxtTotPurchaseQty.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtTotPurchaseQty.BackColor = Color.WhiteSmoke;
            TxtTotPurchaseQty.ForeColor = Color.ForestGreen;
            TxtTotPurchaseQty.Location = new Point(5, 5);
            TxtTotPurchaseQty.Margin = new Padding(5, 3, 5, 3);
            TxtTotPurchaseQty.MaxLength = 10;
            TxtTotPurchaseQty.Name = "TxtTotPurchaseQty";
            TxtTotPurchaseQty.Size = new Size(43, 27);
            TxtTotPurchaseQty.TabIndex = 0;
            TxtTotPurchaseQty.TextAlign = HorizontalAlignment.Center;
            TxtTotPurchaseQty.TextChanged += TxtPurchaseWt_TextChanged;
            TxtTotPurchaseQty.Enter += TextBox_Enter;
            TxtTotPurchaseQty.KeyDown += TxtPurchaseWt_KeyDown;
            TxtTotPurchaseQty.KeyPress += Decimal_KeyPress;
            TxtTotPurchaseQty.Leave += TextBox_Leave;
            TxtTotPurchaseQty.Validated += TxtPurchaseWt_Validated;
            // 
            // LblQtyType
            // 
            LblQtyType.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblQtyType.AutoSize = true;
            LblQtyType.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblQtyType.ForeColor = Color.Green;
            LblQtyType.Location = new Point(55, 9);
            LblQtyType.Margin = new Padding(2, 0, 2, 0);
            LblQtyType.Name = "LblQtyType";
            LblQtyType.Size = new Size(20, 18);
            LblQtyType.TabIndex = 1;
            LblQtyType.Text = "...";
            // 
            // LblPurchaseWtPcs
            // 
            LblPurchaseWtPcs.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblPurchaseWtPcs.AutoSize = true;
            LblPurchaseWtPcs.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblPurchaseWtPcs.ForeColor = Color.Crimson;
            LblPurchaseWtPcs.Location = new Point(4, 1);
            LblPurchaseWtPcs.Name = "LblPurchaseWtPcs";
            LblPurchaseWtPcs.Size = new Size(71, 37);
            LblPurchaseWtPcs.TabIndex = 0;
            LblPurchaseWtPcs.Text = "Total Purchase Qty*";
            LblPurchaseWtPcs.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TxtTotPurchaseRate
            // 
            TxtTotPurchaseRate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtTotPurchaseRate.BackColor = Color.WhiteSmoke;
            TxtTotPurchaseRate.ForeColor = Color.ForestGreen;
            TxtTotPurchaseRate.Location = new Point(89, 44);
            TxtTotPurchaseRate.Margin = new Padding(10, 3, 10, 3);
            TxtTotPurchaseRate.MaxLength = 10;
            TxtTotPurchaseRate.Name = "TxtTotPurchaseRate";
            TxtTotPurchaseRate.Size = new Size(57, 27);
            TxtTotPurchaseRate.TabIndex = 6;
            TxtTotPurchaseRate.TextAlign = HorizontalAlignment.Center;
            TxtTotPurchaseRate.TextChanged += TxtPurchaseRate_TextChanged;
            TxtTotPurchaseRate.Enter += TextBox_Enter;
            TxtTotPurchaseRate.KeyDown += TxtPurchaseRate_KeyDown;
            TxtTotPurchaseRate.KeyPress += Decimal_KeyPress;
            TxtTotPurchaseRate.Leave += TextBox_Leave;
            TxtTotPurchaseRate.Validated += TxtPurchaseRate_Validated;
            // 
            // TxtPurchaseRatePerQty
            // 
            TxtPurchaseRatePerQty.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtPurchaseRatePerQty.BackColor = Color.WhiteSmoke;
            TxtPurchaseRatePerQty.ForeColor = Color.ForestGreen;
            TxtPurchaseRatePerQty.Location = new Point(167, 44);
            TxtPurchaseRatePerQty.Margin = new Padding(10, 3, 10, 3);
            TxtPurchaseRatePerQty.MaxLength = 10;
            TxtPurchaseRatePerQty.Name = "TxtPurchaseRatePerQty";
            TxtPurchaseRatePerQty.Size = new Size(57, 27);
            TxtPurchaseRatePerQty.TabIndex = 7;
            TxtPurchaseRatePerQty.TextAlign = HorizontalAlignment.Center;
            TxtPurchaseRatePerQty.Enter += TextBox_Enter;
            TxtPurchaseRatePerQty.KeyDown += TxtPurchaseRatePerKg_KeyDown;
            TxtPurchaseRatePerQty.KeyPress += ReadOnlyTextBox_KeyPress;
            TxtPurchaseRatePerQty.Leave += TextBox_Leave;
            // 
            // LblDiscPerFromMRP
            // 
            LblDiscPerFromMRP.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblDiscPerFromMRP.AutoSize = true;
            LblDiscPerFromMRP.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblDiscPerFromMRP.Location = new Point(238, 77);
            LblDiscPerFromMRP.Name = "LblDiscPerFromMRP";
            LblDiscPerFromMRP.Size = new Size(71, 37);
            LblDiscPerFromMRP.TabIndex = 13;
            LblDiscPerFromMRP.Text = "Disc % From MRP";
            LblDiscPerFromMRP.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TxtDiscPerFromMRP
            // 
            TxtDiscPerFromMRP.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtDiscPerFromMRP.BackColor = Color.WhiteSmoke;
            TxtDiscPerFromMRP.ForeColor = Color.ForestGreen;
            TxtDiscPerFromMRP.Location = new Point(245, 120);
            TxtDiscPerFromMRP.Margin = new Padding(10, 3, 10, 3);
            TxtDiscPerFromMRP.MaxLength = 10;
            TxtDiscPerFromMRP.Name = "TxtDiscPerFromMRP";
            TxtDiscPerFromMRP.Size = new Size(57, 27);
            TxtDiscPerFromMRP.TabIndex = 18;
            TxtDiscPerFromMRP.TextAlign = HorizontalAlignment.Center;
            TxtDiscPerFromMRP.Enter += TextBox_Enter;
            TxtDiscPerFromMRP.KeyDown += TxtDiscFromMRP_KeyDown;
            TxtDiscPerFromMRP.KeyPress += ReadOnlyTextBox_KeyPress;
            TxtDiscPerFromMRP.Leave += TextBox_Leave;
            // 
            // LblSellingMarginPercentage
            // 
            LblSellingMarginPercentage.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblSellingMarginPercentage.AutoSize = true;
            LblSellingMarginPercentage.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblSellingMarginPercentage.Location = new Point(160, 77);
            LblSellingMarginPercentage.Name = "LblSellingMarginPercentage";
            LblSellingMarginPercentage.Size = new Size(71, 36);
            LblSellingMarginPercentage.TabIndex = 12;
            LblSellingMarginPercentage.Text = "Selling Margin %";
            LblSellingMarginPercentage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TxtSellingMarginPer
            // 
            TxtSellingMarginPer.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtSellingMarginPer.BackColor = Color.WhiteSmoke;
            TxtSellingMarginPer.ForeColor = Color.ForestGreen;
            TxtSellingMarginPer.Location = new Point(167, 120);
            TxtSellingMarginPer.Margin = new Padding(10, 3, 10, 3);
            TxtSellingMarginPer.MaxLength = 10;
            TxtSellingMarginPer.Name = "TxtSellingMarginPer";
            TxtSellingMarginPer.Size = new Size(57, 27);
            TxtSellingMarginPer.TabIndex = 17;
            TxtSellingMarginPer.TextAlign = HorizontalAlignment.Center;
            TxtSellingMarginPer.Enter += TextBox_Enter;
            TxtSellingMarginPer.KeyDown += TxtSellingMarginPercentage_KeyDown;
            TxtSellingMarginPer.KeyPress += ReadOnlyTextBox_KeyPress;
            TxtSellingMarginPer.Leave += TextBox_Leave;
            // 
            // LblSellingRate
            // 
            LblSellingRate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblSellingRate.AutoSize = true;
            LblSellingRate.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblSellingRate.ForeColor = Color.Crimson;
            LblSellingRate.Location = new Point(82, 77);
            LblSellingRate.Name = "LblSellingRate";
            LblSellingRate.Size = new Size(71, 36);
            LblSellingRate.TabIndex = 11;
            LblSellingRate.Text = "Selling Rate*";
            LblSellingRate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblMrp
            // 
            LblMrp.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblMrp.AutoSize = true;
            LblMrp.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblMrp.ForeColor = Color.Crimson;
            LblMrp.Location = new Point(4, 86);
            LblMrp.Name = "LblMrp";
            LblMrp.Size = new Size(71, 18);
            LblMrp.TabIndex = 10;
            LblMrp.Text = "MRP*";
            LblMrp.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TxtSellingRate
            // 
            TxtSellingRate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtSellingRate.BackColor = Color.WhiteSmoke;
            TxtSellingRate.ForeColor = Color.ForestGreen;
            TxtSellingRate.Location = new Point(89, 120);
            TxtSellingRate.Margin = new Padding(10, 3, 10, 3);
            TxtSellingRate.MaxLength = 10;
            TxtSellingRate.Name = "TxtSellingRate";
            TxtSellingRate.Size = new Size(57, 27);
            TxtSellingRate.TabIndex = 16;
            TxtSellingRate.TextAlign = HorizontalAlignment.Center;
            TxtSellingRate.TextChanged += TxtSellingRate_TextChanged;
            TxtSellingRate.Enter += TextBox_Enter;
            TxtSellingRate.KeyDown += TxtSellingRate_KeyDown;
            TxtSellingRate.KeyPress += Decimal_KeyPress;
            TxtSellingRate.Leave += TextBox_Leave;
            TxtSellingRate.Validated += TxtSellingRate_Validated;
            // 
            // TxtMrp
            // 
            TxtMrp.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtMrp.BackColor = Color.WhiteSmoke;
            TxtMrp.ForeColor = Color.ForestGreen;
            TxtMrp.Location = new Point(11, 120);
            TxtMrp.Margin = new Padding(10, 3, 10, 3);
            TxtMrp.MaxLength = 10;
            TxtMrp.Name = "TxtMrp";
            TxtMrp.Size = new Size(57, 27);
            TxtMrp.TabIndex = 15;
            TxtMrp.TextAlign = HorizontalAlignment.Center;
            TxtMrp.EnabledChanged += TxtMrp_EnabledChanged;
            TxtMrp.Enter += TextBox_Enter;
            TxtMrp.KeyDown += TxtMrp_KeyDown;
            TxtMrp.KeyPress += Decimal_KeyPress;
            TxtMrp.Leave += TextBox_Leave;
            TxtMrp.Validated += TxtMrp_Validated;
            // 
            // LblDiscRateFromMRP
            // 
            LblDiscRateFromMRP.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblDiscRateFromMRP.AutoSize = true;
            LblDiscRateFromMRP.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblDiscRateFromMRP.Location = new Point(316, 77);
            LblDiscRateFromMRP.Name = "LblDiscRateFromMRP";
            LblDiscRateFromMRP.Size = new Size(73, 36);
            LblDiscRateFromMRP.TabIndex = 14;
            LblDiscRateFromMRP.Text = "Disc Rate From MRP";
            LblDiscRateFromMRP.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TxtDiscRateFromMRP
            // 
            TxtDiscRateFromMRP.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtDiscRateFromMRP.BackColor = Color.WhiteSmoke;
            TxtDiscRateFromMRP.ForeColor = Color.ForestGreen;
            TxtDiscRateFromMRP.Location = new Point(323, 120);
            TxtDiscRateFromMRP.Margin = new Padding(10, 3, 10, 3);
            TxtDiscRateFromMRP.MaxLength = 10;
            TxtDiscRateFromMRP.Name = "TxtDiscRateFromMRP";
            TxtDiscRateFromMRP.Size = new Size(59, 27);
            TxtDiscRateFromMRP.TabIndex = 19;
            TxtDiscRateFromMRP.TextAlign = HorizontalAlignment.Center;
            TxtDiscRateFromMRP.Enter += TextBox_Enter;
            TxtDiscRateFromMRP.KeyDown += TxtDiscFromMRP_KeyDown;
            TxtDiscRateFromMRP.KeyPress += ReadOnlyTextBox_KeyPress;
            TxtDiscRateFromMRP.Leave += TextBox_Leave;
            // 
            // TxtLastPurchaseRate
            // 
            TxtLastPurchaseRate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtLastPurchaseRate.BackColor = Color.WhiteSmoke;
            TxtLastPurchaseRate.ForeColor = Color.ForestGreen;
            TxtLastPurchaseRate.Location = new Point(245, 44);
            TxtLastPurchaseRate.Margin = new Padding(10, 3, 10, 3);
            TxtLastPurchaseRate.MaxLength = 10;
            TxtLastPurchaseRate.Name = "TxtLastPurchaseRate";
            TxtLastPurchaseRate.Size = new Size(57, 27);
            TxtLastPurchaseRate.TabIndex = 8;
            TxtLastPurchaseRate.TextAlign = HorizontalAlignment.Center;
            TxtLastPurchaseRate.Enter += TextBox_Enter;
            TxtLastPurchaseRate.KeyDown += TxtLastPurchaseRate_KeyDown;
            TxtLastPurchaseRate.KeyPress += ReadOnlyTextBox_KeyPress;
            TxtLastPurchaseRate.Leave += TextBox_Leave;
            // 
            // TxtCurrentSellingRate
            // 
            TxtCurrentSellingRate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtCurrentSellingRate.BackColor = Color.WhiteSmoke;
            TxtCurrentSellingRate.ForeColor = Color.ForestGreen;
            TxtCurrentSellingRate.Location = new Point(323, 44);
            TxtCurrentSellingRate.Margin = new Padding(10, 3, 10, 3);
            TxtCurrentSellingRate.MaxLength = 10;
            TxtCurrentSellingRate.Name = "TxtCurrentSellingRate";
            TxtCurrentSellingRate.Size = new Size(59, 27);
            TxtCurrentSellingRate.TabIndex = 9;
            TxtCurrentSellingRate.TextAlign = HorizontalAlignment.Center;
            TxtCurrentSellingRate.Enter += TextBox_Enter;
            TxtCurrentSellingRate.KeyDown += TxtCurrentSellingRate_KeyDown;
            TxtCurrentSellingRate.KeyPress += ReadOnlyTextBox_KeyPress;
            TxtCurrentSellingRate.Leave += TextBox_Leave;
            // 
            // LblLastPurchaseRate
            // 
            LblLastPurchaseRate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblLastPurchaseRate.AutoSize = true;
            LblLastPurchaseRate.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblLastPurchaseRate.Location = new Point(238, 1);
            LblLastPurchaseRate.Name = "LblLastPurchaseRate";
            LblLastPurchaseRate.Size = new Size(71, 37);
            LblLastPurchaseRate.TabIndex = 3;
            LblLastPurchaseRate.Text = "Last Purchase Rate";
            LblLastPurchaseRate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblCurrentSellingRate
            // 
            LblCurrentSellingRate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblCurrentSellingRate.AutoSize = true;
            LblCurrentSellingRate.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblCurrentSellingRate.Location = new Point(316, 1);
            LblCurrentSellingRate.Name = "LblCurrentSellingRate";
            LblCurrentSellingRate.Size = new Size(73, 37);
            LblCurrentSellingRate.TabIndex = 4;
            LblCurrentSellingRate.Text = "Current Selling Rate";
            LblCurrentSellingRate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ErrorProvider
            // 
            ErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            ErrorProvider.ContainerControl = this;
            // 
            // FrmPurchaseEntry
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1199, 590);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(0, 64, 64);
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmPurchaseEntry";
            Text = "Purchase Enty";
            Activated += FrmPurchaseEntry_Activated;
            Load += FrmPurchaseEnty_Load;
            KeyDown += FrmPurchaseEnty_KeyDown;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGVPurchaseCart).EndInit();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvProductSearch).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ErrorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Label label2;
        private Label LblPurchaseWtPcs;
        private Label label4;
        private Label LblPurchaseRatePerKgPcs;
        private TextBox TxtProductSearch;
        private DataGridView DgvProductSearch;
        private DateTimePicker DtpPurchaseDate;
        private TextBox TxtTotPurchaseQty;
        private TextBox TxtTotPurchaseRate;
        private TextBox TxtPurchaseRatePerQty;
        private TableLayoutPanel tableLayoutPanel4;
        private DataGridView DGVPurchaseCart;
        private TableLayoutPanel tableLayoutPanel5;
        private Button BtnSave;
        private Button BtnExit;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel6;
        private ErrorProvider ErrorProvider;
        private Label label6;
        private Label label7;
        private TextBox TxtProductName;
        private TextBox TxtProductTamilName;
        private Label LblQtyType;
        private Label label3;
        private Label LblTotalAmt;
        private Label label5;
        private ComboBox CmbProductCategory;
        private TableLayoutPanel tableLayoutPanel3;
        private Button BtnClear;
        private Button BtnAdd;
        private TableLayoutPanel tableLayoutPanel8;
        private TableLayoutPanel tableLayoutPanel7;
        private Label LblSellingRate;
        private Label LblSellingMarginPercentage;
        private Label LblMrp;
        private TextBox TxtSellingRate;
        private TextBox TxtSellingMarginPer;
        private TextBox TxtMrp;
        private Label LblCurrentSellingRate;
        private TextBox TxtCurrentSellingRate;
        private Label LblDiscPerFromMRP;
        private TextBox TxtDiscPerFromMRP;
        private Label LblDiscRateFromMRP;
        private TextBox TxtDiscRateFromMRP;
        private TextBox TxtLastPurchaseRate;
        private Label LblLastPurchaseRate;
    }
}