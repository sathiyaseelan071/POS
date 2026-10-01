namespace VegetableBox
{
    partial class FrmPriceUpdate
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            LblPurchaseRatePerKgPcs = new Label();
            LblLastPurchaseRate = new Label();
            TxtCurPurchaseRate = new TextBox();
            TxtProductSearch = new TextBox();
            label1 = new Label();
            DgvProductSearch = new DataGridView();
            tableLayoutPanel3 = new TableLayoutPanel();
            BtnExit = new Button();
            BtnUpdate = new Button();
            btnCancel = new Button();
            label6 = new Label();
            label7 = new Label();
            TxtProductName = new TextBox();
            TxtProductTamilName = new TextBox();
            label5 = new Label();
            CmbProductCategory = new ComboBox();
            TxtNewMrp = new TextBox();
            TxtNewSellingRate = new TextBox();
            TxtCurMrp = new TextBox();
            label2 = new Label();
            TxtCurSellingRate = new TextBox();
            label3 = new Label();
            TxtNewPurchaseRate = new TextBox();
            label4 = new Label();
            LblCurPurRate = new Label();
            ErrorProvider = new ErrorProvider(components);
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvProductSearch).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel6, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1199, 590);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Controls.Add(panel1, 0, 1);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(402, 3);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 3;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 1.30293155F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 95.60261F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 2.931596F));
            tableLayoutPanel6.Size = new Size(393, 584);
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
            panel1.Size = new Size(387, 553);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(LblPurchaseRatePerKgPcs, 0, 10);
            tableLayoutPanel2.Controls.Add(LblLastPurchaseRate, 0, 11);
            tableLayoutPanel2.Controls.Add(TxtCurPurchaseRate, 1, 6);
            tableLayoutPanel2.Controls.Add(TxtProductSearch, 1, 1);
            tableLayoutPanel2.Controls.Add(label1, 0, 1);
            tableLayoutPanel2.Controls.Add(DgvProductSearch, 1, 2);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 1, 12);
            tableLayoutPanel2.Controls.Add(label6, 0, 3);
            tableLayoutPanel2.Controls.Add(label7, 0, 4);
            tableLayoutPanel2.Controls.Add(TxtProductName, 1, 3);
            tableLayoutPanel2.Controls.Add(TxtProductTamilName, 1, 4);
            tableLayoutPanel2.Controls.Add(label5, 0, 5);
            tableLayoutPanel2.Controls.Add(CmbProductCategory, 1, 5);
            tableLayoutPanel2.Controls.Add(TxtNewMrp, 1, 10);
            tableLayoutPanel2.Controls.Add(TxtNewSellingRate, 1, 11);
            tableLayoutPanel2.Controls.Add(TxtCurMrp, 1, 7);
            tableLayoutPanel2.Controls.Add(label2, 0, 8);
            tableLayoutPanel2.Controls.Add(TxtCurSellingRate, 1, 8);
            tableLayoutPanel2.Controls.Add(label3, 0, 9);
            tableLayoutPanel2.Controls.Add(TxtNewPurchaseRate, 1, 9);
            tableLayoutPanel2.Controls.Add(label4, 0, 7);
            tableLayoutPanel2.Controls.Add(LblCurPurRate, 0, 6);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 14;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 2.75257659F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 6.9222126F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 18.35051F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 6.9222126F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 6.9222126F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 6.9222126F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 6.9222126F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 6.9222126F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 6.9222126F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 6.9222126F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 6.9222126F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 6.9222126F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 6.9222126F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 2.75257659F));
            tableLayoutPanel2.Size = new Size(379, 545);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // LblPurchaseRatePerKgPcs
            // 
            LblPurchaseRatePerKgPcs.Anchor = AnchorStyles.Left;
            LblPurchaseRatePerKgPcs.AutoSize = true;
            LblPurchaseRatePerKgPcs.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblPurchaseRatePerKgPcs.Location = new Point(3, 420);
            LblPurchaseRatePerKgPcs.Name = "LblPurchaseRatePerKgPcs";
            LblPurchaseRatePerKgPcs.Size = new Size(69, 18);
            LblPurchaseRatePerKgPcs.TabIndex = 17;
            LblPurchaseRatePerKgPcs.Text = "New MRP";
            LblPurchaseRatePerKgPcs.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblLastPurchaseRate
            // 
            LblLastPurchaseRate.Anchor = AnchorStyles.Left;
            LblLastPurchaseRate.AutoSize = true;
            LblLastPurchaseRate.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblLastPurchaseRate.Location = new Point(3, 457);
            LblLastPurchaseRate.Name = "LblLastPurchaseRate";
            LblLastPurchaseRate.Size = new Size(113, 18);
            LblLastPurchaseRate.TabIndex = 19;
            LblLastPurchaseRate.Text = "New Selling Rate";
            LblLastPurchaseRate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TxtCurPurchaseRate
            // 
            TxtCurPurchaseRate.Anchor = AnchorStyles.Left;
            TxtCurPurchaseRate.BackColor = Color.WhiteSmoke;
            TxtCurPurchaseRate.ForeColor = Color.ForestGreen;
            TxtCurPurchaseRate.Location = new Point(157, 268);
            TxtCurPurchaseRate.MaxLength = 10;
            TxtCurPurchaseRate.Name = "TxtCurPurchaseRate";
            TxtCurPurchaseRate.Size = new Size(100, 27);
            TxtCurPurchaseRate.TabIndex = 10;
            TxtCurPurchaseRate.TextAlign = HorizontalAlignment.Right;
            TxtCurPurchaseRate.Enter += TextBox_Enter;
            TxtCurPurchaseRate.KeyPress += ReadOnlyTextBox_KeyPress;
            TxtCurPurchaseRate.Leave += TextBox_Leave;
            // 
            // TxtProductSearch
            // 
            TxtProductSearch.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtProductSearch.BackColor = Color.WhiteSmoke;
            TxtProductSearch.ForeColor = Color.ForestGreen;
            TxtProductSearch.Location = new Point(154, 20);
            TxtProductSearch.Margin = new Padding(0);
            TxtProductSearch.Name = "TxtProductSearch";
            TxtProductSearch.PlaceholderText = "Search for Product";
            TxtProductSearch.Size = new Size(225, 27);
            TxtProductSearch.TabIndex = 1;
            TxtProductSearch.TextChanged += TxtProductSearch_TextChanged;
            TxtProductSearch.Enter += TextBox_Enter;
            TxtProductSearch.KeyDown += TxtProductSearch_KeyDown;
            TxtProductSearch.Leave += TextBox_Leave;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(3, 24);
            label1.Name = "label1";
            label1.Size = new Size(148, 19);
            label1.TabIndex = 0;
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(0, 64, 64);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(244, 244, 244);
            dataGridViewCellStyle1.SelectionForeColor = Color.ForestGreen;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            DgvProductSearch.DefaultCellStyle = dataGridViewCellStyle1;
            DgvProductSearch.Dock = DockStyle.Fill;
            DgvProductSearch.GridColor = Color.White;
            DgvProductSearch.Location = new Point(154, 52);
            DgvProductSearch.Margin = new Padding(0);
            DgvProductSearch.MultiSelect = false;
            DgvProductSearch.Name = "DgvProductSearch";
            DgvProductSearch.ReadOnly = true;
            DgvProductSearch.RowHeadersVisible = false;
            DgvProductSearch.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            DgvProductSearch.Size = new Size(225, 100);
            DgvProductSearch.TabIndex = 2;
            DgvProductSearch.KeyDown += DgvProductSearch_KeyDown;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Controls.Add(BtnExit, 2, 0);
            tableLayoutPanel3.Controls.Add(BtnUpdate, 0, 0);
            tableLayoutPanel3.Controls.Add(btnCancel, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(154, 485);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(225, 37);
            tableLayoutPanel3.TabIndex = 21;
            // 
            // BtnExit
            // 
            BtnExit.Dock = DockStyle.Fill;
            BtnExit.ForeColor = Color.Crimson;
            BtnExit.Location = new Point(151, 3);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(71, 31);
            BtnExit.TabIndex = 1;
            BtnExit.Text = "E&xit";
            BtnExit.UseVisualStyleBackColor = true;
            BtnExit.Click += BtnExit_Click;
            // 
            // BtnUpdate
            // 
            BtnUpdate.Dock = DockStyle.Fill;
            BtnUpdate.ForeColor = Color.DarkGreen;
            BtnUpdate.Location = new Point(3, 3);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(68, 31);
            BtnUpdate.TabIndex = 0;
            BtnUpdate.Text = "&Update";
            BtnUpdate.UseVisualStyleBackColor = true;
            BtnUpdate.Click += BtnUpdate_Click;
            // 
            // btnCancel
            // 
            btnCancel.Dock = DockStyle.Fill;
            btnCancel.ForeColor = Color.Crimson;
            btnCancel.Location = new Point(77, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(68, 31);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cance&l";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(3, 161);
            label6.Name = "label6";
            label6.Size = new Size(148, 19);
            label6.TabIndex = 3;
            label6.Text = "Product Name";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(3, 198);
            label7.Name = "label7";
            label7.Size = new Size(148, 19);
            label7.TabIndex = 5;
            label7.Text = "Product Tamil Name";
            // 
            // TxtProductName
            // 
            TxtProductName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtProductName.BackColor = Color.WhiteSmoke;
            TxtProductName.ForeColor = Color.ForestGreen;
            TxtProductName.Location = new Point(154, 157);
            TxtProductName.Margin = new Padding(0);
            TxtProductName.Name = "TxtProductName";
            TxtProductName.Size = new Size(225, 27);
            TxtProductName.TabIndex = 4;
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
            TxtProductTamilName.Location = new Point(154, 194);
            TxtProductTamilName.Margin = new Padding(0);
            TxtProductTamilName.Name = "TxtProductTamilName";
            TxtProductTamilName.Size = new Size(225, 27);
            TxtProductTamilName.TabIndex = 6;
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
            label5.Location = new Point(3, 235);
            label5.Name = "label5";
            label5.Size = new Size(148, 19);
            label5.TabIndex = 7;
            label5.Text = "Product Category";
            // 
            // CmbProductCategory
            // 
            CmbProductCategory.Anchor = AnchorStyles.Left;
            CmbProductCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbProductCategory.Enabled = false;
            CmbProductCategory.FormattingEnabled = true;
            CmbProductCategory.Location = new Point(156, 233);
            CmbProductCategory.Margin = new Padding(2);
            CmbProductCategory.Name = "CmbProductCategory";
            CmbProductCategory.Size = new Size(101, 27);
            CmbProductCategory.TabIndex = 8;
            // 
            // TxtNewMrp
            // 
            TxtNewMrp.Anchor = AnchorStyles.Left;
            TxtNewMrp.BackColor = Color.WhiteSmoke;
            TxtNewMrp.ForeColor = Color.ForestGreen;
            TxtNewMrp.Location = new Point(157, 416);
            TxtNewMrp.MaxLength = 10;
            TxtNewMrp.Name = "TxtNewMrp";
            TxtNewMrp.Size = new Size(100, 27);
            TxtNewMrp.TabIndex = 18;
            TxtNewMrp.TextAlign = HorizontalAlignment.Right;
            TxtNewMrp.Enter += TextBox_Enter;
            TxtNewMrp.KeyPress += Decimal_KeyPress;
            TxtNewMrp.Leave += TextBox_Leave;
            TxtNewMrp.Validated += TxtNewMrp_Validated;
            // 
            // TxtNewSellingRate
            // 
            TxtNewSellingRate.Anchor = AnchorStyles.Left;
            TxtNewSellingRate.BackColor = Color.WhiteSmoke;
            TxtNewSellingRate.ForeColor = Color.ForestGreen;
            TxtNewSellingRate.Location = new Point(157, 453);
            TxtNewSellingRate.MaxLength = 10;
            TxtNewSellingRate.Name = "TxtNewSellingRate";
            TxtNewSellingRate.Size = new Size(100, 27);
            TxtNewSellingRate.TabIndex = 20;
            TxtNewSellingRate.TextAlign = HorizontalAlignment.Right;
            TxtNewSellingRate.Enter += TextBox_Enter;
            TxtNewSellingRate.KeyPress += Decimal_KeyPress;
            TxtNewSellingRate.Leave += TextBox_Leave;
            TxtNewSellingRate.Validated += TxtNewSellingRate_Validated;
            // 
            // TxtCurMrp
            // 
            TxtCurMrp.Anchor = AnchorStyles.Left;
            TxtCurMrp.BackColor = Color.WhiteSmoke;
            TxtCurMrp.ForeColor = Color.ForestGreen;
            TxtCurMrp.Location = new Point(157, 305);
            TxtCurMrp.MaxLength = 10;
            TxtCurMrp.Name = "TxtCurMrp";
            TxtCurMrp.Size = new Size(100, 27);
            TxtCurMrp.TabIndex = 12;
            TxtCurMrp.TextAlign = HorizontalAlignment.Right;
            TxtCurMrp.Enter += TextBox_Enter;
            TxtCurMrp.KeyPress += ReadOnlyTextBox_KeyPress;
            TxtCurMrp.Leave += TextBox_Leave;
            TxtCurMrp.Validated += TxtSellingRate_Validated;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Crimson;
            label2.Location = new Point(3, 346);
            label2.Name = "label2";
            label2.Size = new Size(131, 18);
            label2.TabIndex = 13;
            label2.Text = "Current Selling Rate";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TxtCurSellingRate
            // 
            TxtCurSellingRate.Anchor = AnchorStyles.Left;
            TxtCurSellingRate.BackColor = Color.WhiteSmoke;
            TxtCurSellingRate.ForeColor = Color.ForestGreen;
            TxtCurSellingRate.Location = new Point(157, 342);
            TxtCurSellingRate.MaxLength = 10;
            TxtCurSellingRate.Name = "TxtCurSellingRate";
            TxtCurSellingRate.Size = new Size(100, 27);
            TxtCurSellingRate.TabIndex = 14;
            TxtCurSellingRate.TextAlign = HorizontalAlignment.Right;
            TxtCurSellingRate.Enter += TextBox_Enter;
            TxtCurSellingRate.KeyPress += ReadOnlyTextBox_KeyPress;
            TxtCurSellingRate.Leave += TextBox_Leave;
            TxtCurSellingRate.Validated += TxtSellingRate_Validated;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(3, 383);
            label3.Name = "label3";
            label3.Size = new Size(127, 18);
            label3.TabIndex = 15;
            label3.Text = "New Purchase Rate";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TxtNewPurchaseRate
            // 
            TxtNewPurchaseRate.Anchor = AnchorStyles.Left;
            TxtNewPurchaseRate.BackColor = Color.WhiteSmoke;
            TxtNewPurchaseRate.ForeColor = Color.ForestGreen;
            TxtNewPurchaseRate.Location = new Point(157, 379);
            TxtNewPurchaseRate.MaxLength = 10;
            TxtNewPurchaseRate.Name = "TxtNewPurchaseRate";
            TxtNewPurchaseRate.Size = new Size(100, 27);
            TxtNewPurchaseRate.TabIndex = 16;
            TxtNewPurchaseRate.TextAlign = HorizontalAlignment.Right;
            TxtNewPurchaseRate.Enter += TextBox_Enter;
            TxtNewPurchaseRate.KeyPress += Decimal_KeyPress;
            TxtNewPurchaseRate.Leave += TextBox_Leave;
            TxtNewPurchaseRate.Validated += TxtNewPurchaseRate_Validated;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Crimson;
            label4.Location = new Point(3, 309);
            label4.Name = "label4";
            label4.Size = new Size(87, 18);
            label4.TabIndex = 11;
            label4.Text = "Current MRP";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblCurPurRate
            // 
            LblCurPurRate.Anchor = AnchorStyles.Left;
            LblCurPurRate.AutoSize = true;
            LblCurPurRate.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblCurPurRate.ForeColor = Color.Crimson;
            LblCurPurRate.Location = new Point(3, 272);
            LblCurPurRate.Name = "LblCurPurRate";
            LblCurPurRate.Size = new Size(145, 18);
            LblCurPurRate.TabIndex = 9;
            LblCurPurRate.Text = "Current Purchase Rate";
            LblCurPurRate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ErrorProvider
            // 
            ErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            ErrorProvider.ContainerControl = this;
            // 
            // FrmPriceUpdate
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1199, 590);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(0, 64, 64);
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmPriceUpdate";
            Text = "Price Update";
            Load += FrmPurchaseEnty_Load;
            KeyDown += FrmPurchaseEnty_KeyDown;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvProductSearch).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ErrorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Label label4;
        private Label LblPurchaseRatePerKgPcs;
        private TextBox TxtProductSearch;
        private DataGridView DgvProductSearch;
        private TextBox TxtNewMrp;
        private TextBox TxtNewSellingRate;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel6;
        private ErrorProvider ErrorProvider;
        private Label label6;
        private Label label7;
        private TextBox TxtProductName;
        private TextBox TxtProductTamilName;
        private Label label5;
        private ComboBox CmbProductCategory;
        private TableLayoutPanel tableLayoutPanel3;
        private Button BtnExit;
        private Button BtnUpdate;
        private Label LblCurPurRate;
        private TextBox TxtCurMrp;
        private TextBox TxtCurPurchaseRate;
        private Label LblLastPurchaseRate;
        private Label label2;
        private TextBox TxtCurSellingRate;
        private Label label3;
        private TextBox TxtNewPurchaseRate;
        private Button btnCancel;
    }
}