namespace VegetableBox
{
    partial class FrmProduct
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
            LblProductName = new Label();
            LblProductTName = new Label();
            LblProductAlternateName = new Label();
            LblCategoryType = new Label();
            LblQtyType = new Label();
            LblCBORateMaster = new Label();
            TxtProductName = new TextBox();
            TxtProductTamilName = new TextBox();
            CmbCategoryType = new ComboBox();
            CmbQtyType = new ComboBox();
            CmbCBORateMaster = new ComboBox();
            label1 = new Label();
            TxtBarcode = new TextBox();
            CmbAllowRateChange = new ComboBox();
            label2 = new Label();
            TxtBarcode2 = new TextBox();
            TxtBarcode3 = new TextBox();
            TxtBarcode4 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            LblMaximumStock = new Label();
            TxtProductAlternateName = new TextBox();
            TxtMaximumStock = new TextBox();
            LblMinimumStock = new Label();
            TxtMinimumStock = new TextBox();
            LblMaintainStock = new Label();
            CmbMaintainStock = new ComboBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            BtnSave = new Button();
            BtnCancel = new Button();
            label9 = new Label();
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
            LblFilterCatType = new Label();
            CmbFilterCategoryType = new ComboBox();
            CmbFilterQtyType = new ComboBox();
            LblFilterActive = new Label();
            CmbFilterActive = new ComboBox();
            LblFilterProduct = new Label();
            TxtFilterProduct = new TextBox();
            LblFilters = new Label();
            LblFilterQtyType = new Label();
            label10 = new Label();
            CmbFilterMaintainStock = new ComboBox();
            ErrorProvider = new ErrorProvider(components);
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
            SuspendLayout();
            // 
            // TlpMain
            // 
            TlpMain.ColumnCount = 4;
            TlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 0.993365765F));
            TlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.36868F));
            TlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63.643528F));
            TlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 0.9944301F));
            TlpMain.Controls.Add(panel1, 1, 2);
            TlpMain.Controls.Add(panel2, 2, 1);
            TlpMain.Dock = DockStyle.Fill;
            TlpMain.Location = new Point(0, 0);
            TlpMain.Name = "TlpMain";
            TlpMain.RowCount = 5;
            TlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 2.88461542F));
            TlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 1.453958F));
            TlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 90.95315F));
            TlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 1.77705979F));
            TlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 2.88461542F));
            TlpMain.Size = new Size(1256, 645);
            TlpMain.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(15, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(425, 580);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 0.9835724F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.1297531F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55.8970032F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.989667F));
            tableLayoutPanel1.Controls.Add(LblProductName, 1, 1);
            tableLayoutPanel1.Controls.Add(LblProductTName, 1, 2);
            tableLayoutPanel1.Controls.Add(LblProductAlternateName, 1, 3);
            tableLayoutPanel1.Controls.Add(LblCategoryType, 1, 4);
            tableLayoutPanel1.Controls.Add(LblQtyType, 1, 5);
            tableLayoutPanel1.Controls.Add(LblCBORateMaster, 1, 6);
            tableLayoutPanel1.Controls.Add(TxtProductName, 2, 1);
            tableLayoutPanel1.Controls.Add(TxtProductTamilName, 2, 2);
            tableLayoutPanel1.Controls.Add(CmbCategoryType, 2, 4);
            tableLayoutPanel1.Controls.Add(CmbQtyType, 2, 5);
            tableLayoutPanel1.Controls.Add(CmbCBORateMaster, 2, 6);
            tableLayoutPanel1.Controls.Add(label1, 1, 8);
            tableLayoutPanel1.Controls.Add(TxtBarcode, 2, 8);
            tableLayoutPanel1.Controls.Add(CmbAllowRateChange, 2, 7);
            tableLayoutPanel1.Controls.Add(label2, 1, 7);
            tableLayoutPanel1.Controls.Add(TxtBarcode2, 2, 9);
            tableLayoutPanel1.Controls.Add(TxtBarcode3, 2, 10);
            tableLayoutPanel1.Controls.Add(TxtBarcode4, 2, 11);
            tableLayoutPanel1.Controls.Add(label3, 1, 9);
            tableLayoutPanel1.Controls.Add(label4, 1, 10);
            tableLayoutPanel1.Controls.Add(label5, 1, 11);
            tableLayoutPanel1.Controls.Add(LblMaximumStock, 1, 14);
            tableLayoutPanel1.Controls.Add(TxtProductAlternateName, 2, 3);
            tableLayoutPanel1.Controls.Add(TxtMaximumStock, 2, 14);
            tableLayoutPanel1.Controls.Add(LblMinimumStock, 1, 13);
            tableLayoutPanel1.Controls.Add(TxtMinimumStock, 2, 13);
            tableLayoutPanel1.Controls.Add(LblMaintainStock, 1, 12);
            tableLayoutPanel1.Controls.Add(CmbMaintainStock, 2, 12);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 2, 16);
            tableLayoutPanel1.Controls.Add(label9, 1, 15);
            tableLayoutPanel1.Controls.Add(CmbActive, 2, 15);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 18;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 0.2984319F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.21269655F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.21269655F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.21269655F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.21269655F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.21269655F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.21269655F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.21269655F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.21269655F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.21269655F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.21269655F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.21269655F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.21269655F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.21269655F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.21269655F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.21269655F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.21269655F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 0.298431873F));
            tableLayoutPanel1.Size = new Size(423, 578);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // LblProductName
            // 
            LblProductName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblProductName.AutoSize = true;
            LblProductName.ForeColor = Color.FromArgb(163, 0, 34);
            LblProductName.Location = new Point(7, 9);
            LblProductName.Name = "LblProductName";
            LblProductName.Size = new Size(163, 19);
            LblProductName.TabIndex = 0;
            LblProductName.Text = "Product Name";
            // 
            // LblProductTName
            // 
            LblProductTName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblProductTName.AutoSize = true;
            LblProductTName.ForeColor = Color.FromArgb(163, 0, 34);
            LblProductTName.Location = new Point(7, 44);
            LblProductTName.Name = "LblProductTName";
            LblProductTName.Size = new Size(163, 19);
            LblProductTName.TabIndex = 2;
            LblProductTName.Text = "Product Tamil Name";
            // 
            // LblProductAlternateName
            // 
            LblProductAlternateName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblProductAlternateName.AutoSize = true;
            LblProductAlternateName.ForeColor = Color.FromArgb(163, 0, 34);
            LblProductAlternateName.Location = new Point(7, 79);
            LblProductAlternateName.Name = "LblProductAlternateName";
            LblProductAlternateName.Size = new Size(163, 19);
            LblProductAlternateName.TabIndex = 4;
            LblProductAlternateName.Text = "Alternate Name";
            // 
            // LblCategoryType
            // 
            LblCategoryType.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblCategoryType.AutoSize = true;
            LblCategoryType.ForeColor = Color.FromArgb(163, 0, 34);
            LblCategoryType.Location = new Point(7, 114);
            LblCategoryType.Name = "LblCategoryType";
            LblCategoryType.Size = new Size(163, 19);
            LblCategoryType.TabIndex = 6;
            LblCategoryType.Text = "Category Type";
            // 
            // LblQtyType
            // 
            LblQtyType.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblQtyType.AutoSize = true;
            LblQtyType.ForeColor = Color.FromArgb(163, 0, 34);
            LblQtyType.Location = new Point(7, 149);
            LblQtyType.Name = "LblQtyType";
            LblQtyType.Size = new Size(163, 19);
            LblQtyType.TabIndex = 8;
            LblQtyType.Text = "QauntityType";
            // 
            // LblCBORateMaster
            // 
            LblCBORateMaster.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblCBORateMaster.AutoSize = true;
            LblCBORateMaster.ForeColor = Color.FromArgb(163, 0, 34);
            LblCBORateMaster.Location = new Point(7, 176);
            LblCBORateMaster.Name = "LblCBORateMaster";
            LblCBORateMaster.Size = new Size(163, 35);
            LblCBORateMaster.TabIndex = 10;
            LblCBORateMaster.Text = "Calc Based On Rate Master";
            // 
            // TxtProductName
            // 
            TxtProductName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtProductName.BackColor = Color.White;
            TxtProductName.ForeColor = Color.DarkGreen;
            TxtProductName.Location = new Point(176, 5);
            TxtProductName.Margin = new Padding(3, 2, 3, 2);
            TxtProductName.MaxLength = 50;
            TxtProductName.Name = "TxtProductName";
            TxtProductName.Size = new Size(230, 27);
            TxtProductName.TabIndex = 1;
            TxtProductName.TextChanged += TxtProductName_TextChanged;
            TxtProductName.Enter += TextBox_Enter;
            TxtProductName.Leave += TextBox_Leave;
            // 
            // TxtProductTamilName
            // 
            TxtProductTamilName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtProductTamilName.BackColor = Color.White;
            TxtProductTamilName.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            TxtProductTamilName.ForeColor = Color.DarkGreen;
            TxtProductTamilName.Location = new Point(176, 43);
            TxtProductTamilName.Margin = new Padding(3, 2, 3, 2);
            TxtProductTamilName.MaxLength = 50;
            TxtProductTamilName.Name = "TxtProductTamilName";
            TxtProductTamilName.Size = new Size(230, 21);
            TxtProductTamilName.TabIndex = 3;
            TxtProductTamilName.Enter += TextBox_Enter;
            TxtProductTamilName.Leave += TextBox_Leave;
            TxtProductTamilName.Validating += TxtProductTamilName_Validating;
            // 
            // CmbCategoryType
            // 
            CmbCategoryType.Anchor = AnchorStyles.Left;
            CmbCategoryType.BackColor = Color.White;
            CmbCategoryType.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbCategoryType.FlatStyle = FlatStyle.Flat;
            CmbCategoryType.ForeColor = Color.DarkGreen;
            CmbCategoryType.FormattingEnabled = true;
            CmbCategoryType.Location = new Point(176, 110);
            CmbCategoryType.Margin = new Padding(3, 2, 3, 2);
            CmbCategoryType.Name = "CmbCategoryType";
            CmbCategoryType.Size = new Size(106, 27);
            CmbCategoryType.TabIndex = 7;
            CmbCategoryType.SelectedIndexChanged += CmbCategoryType_SelectedIndexChanged;
            CmbCategoryType.Enter += ComboBox_Enter;
            CmbCategoryType.Leave += ComboBox_Leave;
            // 
            // CmbQtyType
            // 
            CmbQtyType.Anchor = AnchorStyles.Left;
            CmbQtyType.BackColor = Color.White;
            CmbQtyType.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbQtyType.FlatStyle = FlatStyle.Flat;
            CmbQtyType.ForeColor = Color.DarkGreen;
            CmbQtyType.FormattingEnabled = true;
            CmbQtyType.Location = new Point(176, 145);
            CmbQtyType.Margin = new Padding(3, 2, 3, 2);
            CmbQtyType.Name = "CmbQtyType";
            CmbQtyType.Size = new Size(106, 27);
            CmbQtyType.TabIndex = 9;
            CmbQtyType.SelectedIndexChanged += CmbQtyType_SelectedIndexChanged;
            CmbQtyType.Enter += ComboBox_Enter;
            CmbQtyType.Leave += ComboBox_Leave;
            // 
            // CmbCBORateMaster
            // 
            CmbCBORateMaster.Anchor = AnchorStyles.Left;
            CmbCBORateMaster.BackColor = Color.White;
            CmbCBORateMaster.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbCBORateMaster.FlatStyle = FlatStyle.Flat;
            CmbCBORateMaster.ForeColor = Color.DarkGreen;
            CmbCBORateMaster.FormattingEnabled = true;
            CmbCBORateMaster.Location = new Point(176, 180);
            CmbCBORateMaster.Margin = new Padding(3, 2, 3, 2);
            CmbCBORateMaster.Name = "CmbCBORateMaster";
            CmbCBORateMaster.Size = new Size(106, 27);
            CmbCBORateMaster.TabIndex = 11;
            CmbCBORateMaster.Enter += ComboBox_Enter;
            CmbCBORateMaster.Leave += ComboBox_Leave;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(163, 0, 34);
            label1.Location = new Point(7, 254);
            label1.Name = "label1";
            label1.Size = new Size(163, 19);
            label1.TabIndex = 14;
            label1.Text = "Barcode 1";
            // 
            // TxtBarcode
            // 
            TxtBarcode.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtBarcode.BackColor = Color.White;
            TxtBarcode.ForeColor = Color.DarkGreen;
            TxtBarcode.Location = new Point(176, 250);
            TxtBarcode.Margin = new Padding(3, 2, 3, 2);
            TxtBarcode.MaxLength = 50;
            TxtBarcode.Name = "TxtBarcode";
            TxtBarcode.Size = new Size(230, 27);
            TxtBarcode.TabIndex = 15;
            TxtBarcode.Enter += TextBox_Enter;
            TxtBarcode.Leave += TextBox_Leave;
            // 
            // CmbAllowRateChange
            // 
            CmbAllowRateChange.Anchor = AnchorStyles.Left;
            CmbAllowRateChange.BackColor = Color.White;
            CmbAllowRateChange.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbAllowRateChange.FlatStyle = FlatStyle.Flat;
            CmbAllowRateChange.ForeColor = Color.DarkGreen;
            CmbAllowRateChange.FormattingEnabled = true;
            CmbAllowRateChange.Location = new Point(176, 215);
            CmbAllowRateChange.Margin = new Padding(3, 2, 3, 2);
            CmbAllowRateChange.Name = "CmbAllowRateChange";
            CmbAllowRateChange.Size = new Size(106, 27);
            CmbAllowRateChange.TabIndex = 13;
            CmbAllowRateChange.Enter += ComboBox_Enter;
            CmbAllowRateChange.Leave += ComboBox_Leave;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(163, 0, 34);
            label2.Location = new Point(7, 211);
            label2.Name = "label2";
            label2.Size = new Size(163, 35);
            label2.TabIndex = 12;
            label2.Text = "Allow Rate Change in POS";
            // 
            // TxtBarcode2
            // 
            TxtBarcode2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtBarcode2.BackColor = Color.White;
            TxtBarcode2.ForeColor = Color.DarkGreen;
            TxtBarcode2.Location = new Point(176, 285);
            TxtBarcode2.Margin = new Padding(3, 2, 3, 2);
            TxtBarcode2.MaxLength = 50;
            TxtBarcode2.Name = "TxtBarcode2";
            TxtBarcode2.Size = new Size(230, 27);
            TxtBarcode2.TabIndex = 17;
            TxtBarcode2.Enter += TextBox_Enter;
            TxtBarcode2.Leave += TextBox_Leave;
            // 
            // TxtBarcode3
            // 
            TxtBarcode3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtBarcode3.BackColor = Color.White;
            TxtBarcode3.ForeColor = Color.DarkGreen;
            TxtBarcode3.Location = new Point(176, 320);
            TxtBarcode3.Margin = new Padding(3, 2, 3, 2);
            TxtBarcode3.MaxLength = 50;
            TxtBarcode3.Name = "TxtBarcode3";
            TxtBarcode3.Size = new Size(230, 27);
            TxtBarcode3.TabIndex = 19;
            TxtBarcode3.Enter += TextBox_Enter;
            TxtBarcode3.Leave += TextBox_Leave;
            // 
            // TxtBarcode4
            // 
            TxtBarcode4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtBarcode4.BackColor = Color.White;
            TxtBarcode4.ForeColor = Color.DarkGreen;
            TxtBarcode4.Location = new Point(176, 355);
            TxtBarcode4.Margin = new Padding(3, 2, 3, 2);
            TxtBarcode4.MaxLength = 50;
            TxtBarcode4.Name = "TxtBarcode4";
            TxtBarcode4.Size = new Size(230, 27);
            TxtBarcode4.TabIndex = 21;
            TxtBarcode4.Enter += TextBox_Enter;
            TxtBarcode4.Leave += TextBox_Leave;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(163, 0, 34);
            label3.Location = new Point(7, 289);
            label3.Name = "label3";
            label3.Size = new Size(163, 19);
            label3.TabIndex = 16;
            label3.Text = "Barcode 2";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(163, 0, 34);
            label4.Location = new Point(7, 324);
            label4.Name = "label4";
            label4.Size = new Size(163, 19);
            label4.TabIndex = 18;
            label4.Text = "Barcode 3";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(163, 0, 34);
            label5.Location = new Point(7, 359);
            label5.Name = "label5";
            label5.Size = new Size(163, 19);
            label5.TabIndex = 20;
            label5.Text = "Barcode 4";
            // 
            // LblMaximumStock
            // 
            LblMaximumStock.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblMaximumStock.AutoSize = true;
            LblMaximumStock.ForeColor = Color.FromArgb(163, 0, 34);
            LblMaximumStock.Location = new Point(7, 464);
            LblMaximumStock.Name = "LblMaximumStock";
            LblMaximumStock.Size = new Size(163, 19);
            LblMaximumStock.TabIndex = 26;
            LblMaximumStock.Text = "Maximum Stock";
            // 
            // TxtProductAlternateName
            // 
            TxtProductAlternateName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtProductAlternateName.BackColor = Color.White;
            TxtProductAlternateName.ForeColor = Color.DarkGreen;
            TxtProductAlternateName.Location = new Point(176, 75);
            TxtProductAlternateName.Margin = new Padding(3, 2, 3, 2);
            TxtProductAlternateName.MaxLength = 50;
            TxtProductAlternateName.Name = "TxtProductAlternateName";
            TxtProductAlternateName.Size = new Size(230, 27);
            TxtProductAlternateName.TabIndex = 5;
            TxtProductAlternateName.Enter += TextBox_Enter;
            TxtProductAlternateName.Leave += TextBox_Leave;
            // 
            // TxtMaximumStock
            // 
            TxtMaximumStock.Anchor = AnchorStyles.Left;
            TxtMaximumStock.BackColor = Color.White;
            TxtMaximumStock.ForeColor = Color.DarkGreen;
            TxtMaximumStock.Location = new Point(176, 460);
            TxtMaximumStock.Margin = new Padding(3, 2, 3, 2);
            TxtMaximumStock.MaxLength = 3;
            TxtMaximumStock.Name = "TxtMaximumStock";
            TxtMaximumStock.Size = new Size(106, 27);
            TxtMaximumStock.TabIndex = 27;
            TxtMaximumStock.TextAlign = HorizontalAlignment.Right;
            TxtMaximumStock.Enter += TextBox_Enter;
            TxtMaximumStock.KeyPress += Number_KeyPress;
            TxtMaximumStock.Leave += TextBox_Leave;
            // 
            // LblMinimumStock
            // 
            LblMinimumStock.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblMinimumStock.AutoSize = true;
            LblMinimumStock.ForeColor = Color.FromArgb(163, 0, 34);
            LblMinimumStock.Location = new Point(7, 429);
            LblMinimumStock.Name = "LblMinimumStock";
            LblMinimumStock.Size = new Size(163, 19);
            LblMinimumStock.TabIndex = 24;
            LblMinimumStock.Text = "Minimum Stock";
            // 
            // TxtMinimumStock
            // 
            TxtMinimumStock.Anchor = AnchorStyles.Left;
            TxtMinimumStock.BackColor = Color.White;
            TxtMinimumStock.ForeColor = Color.DarkGreen;
            TxtMinimumStock.Location = new Point(176, 425);
            TxtMinimumStock.Margin = new Padding(3, 2, 3, 2);
            TxtMinimumStock.MaxLength = 3;
            TxtMinimumStock.Name = "TxtMinimumStock";
            TxtMinimumStock.Size = new Size(106, 27);
            TxtMinimumStock.TabIndex = 25;
            TxtMinimumStock.TextAlign = HorizontalAlignment.Right;
            TxtMinimumStock.Enter += TextBox_Enter;
            TxtMinimumStock.KeyPress += Number_KeyPress;
            TxtMinimumStock.Leave += TextBox_Leave;
            // 
            // LblMaintainStock
            // 
            LblMaintainStock.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblMaintainStock.AutoSize = true;
            LblMaintainStock.ForeColor = Color.FromArgb(163, 0, 34);
            LblMaintainStock.Location = new Point(7, 394);
            LblMaintainStock.Name = "LblMaintainStock";
            LblMaintainStock.Size = new Size(163, 19);
            LblMaintainStock.TabIndex = 22;
            LblMaintainStock.Text = "Maintain Stock";
            // 
            // CmbMaintainStock
            // 
            CmbMaintainStock.Anchor = AnchorStyles.Left;
            CmbMaintainStock.BackColor = Color.White;
            CmbMaintainStock.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbMaintainStock.FlatStyle = FlatStyle.Flat;
            CmbMaintainStock.ForeColor = Color.DarkGreen;
            CmbMaintainStock.FormattingEnabled = true;
            CmbMaintainStock.Location = new Point(176, 392);
            CmbMaintainStock.Margin = new Padding(3, 2, 3, 2);
            CmbMaintainStock.Name = "CmbMaintainStock";
            CmbMaintainStock.Size = new Size(106, 27);
            CmbMaintainStock.TabIndex = 23;
            CmbMaintainStock.Enter += ComboBox_Enter;
            CmbMaintainStock.Leave += ComboBox_Leave;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tableLayoutPanel2.Controls.Add(BtnSave, 1, 0);
            tableLayoutPanel2.Controls.Add(BtnCancel, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(173, 526);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(236, 35);
            tableLayoutPanel2.TabIndex = 30;
            // 
            // BtnSave
            // 
            BtnSave.BackColor = SystemColors.Control;
            BtnSave.Dock = DockStyle.Fill;
            BtnSave.FlatStyle = FlatStyle.Popup;
            BtnSave.ForeColor = Color.DarkGreen;
            BtnSave.Location = new Point(26, 2);
            BtnSave.Margin = new Padding(3, 2, 3, 2);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(100, 31);
            BtnSave.TabIndex = 0;
            BtnSave.Text = "&Save";
            BtnSave.UseVisualStyleBackColor = false;
            BtnSave.Click += BtnSave_Click;
            // 
            // BtnCancel
            // 
            BtnCancel.BackColor = SystemColors.Control;
            BtnCancel.Dock = DockStyle.Fill;
            BtnCancel.FlatStyle = FlatStyle.Popup;
            BtnCancel.ForeColor = Color.Red;
            BtnCancel.Location = new Point(132, 2);
            BtnCancel.Margin = new Padding(3, 2, 3, 2);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(101, 31);
            BtnCancel.TabIndex = 1;
            BtnCancel.Text = "&Cancel";
            BtnCancel.UseVisualStyleBackColor = false;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.ForeColor = Color.FromArgb(163, 0, 34);
            label9.Location = new Point(7, 499);
            label9.Name = "label9";
            label9.Size = new Size(163, 19);
            label9.TabIndex = 28;
            label9.Text = "Active";
            // 
            // CmbActive
            // 
            CmbActive.Anchor = AnchorStyles.Left;
            CmbActive.BackColor = Color.White;
            CmbActive.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbActive.FlatStyle = FlatStyle.Flat;
            CmbActive.ForeColor = Color.DarkGreen;
            CmbActive.FormattingEnabled = true;
            CmbActive.Location = new Point(176, 497);
            CmbActive.Margin = new Padding(3, 2, 3, 2);
            CmbActive.Name = "CmbActive";
            CmbActive.Size = new Size(106, 27);
            CmbActive.TabIndex = 29;
            CmbActive.Enter += ComboBox_Enter;
            CmbActive.Leave += ComboBox_Leave;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(tableLayoutPanel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(446, 20);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            TlpMain.SetRowSpan(panel2, 3);
            panel2.Size = new Size(793, 602);
            panel2.TabIndex = 0;
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
            tableLayoutPanel3.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 73F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            tableLayoutPanel3.Size = new Size(791, 600);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // DGView
            // 
            DGView.AllowUserToAddRows = false;
            DGView.AllowUserToDeleteRows = false;
            DGView.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DGView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DGView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.SelectionForeColor = Color.ForestGreen;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DGView.DefaultCellStyle = dataGridViewCellStyle2;
            DGView.Dock = DockStyle.Fill;
            DGView.Location = new Point(4, 122);
            DGView.Margin = new Padding(4, 2, 3, 2);
            DGView.MultiSelect = false;
            DGView.Name = "DGView";
            DGView.ReadOnly = true;
            DGView.RowHeadersVisible = false;
            DGView.RowTemplate.Height = 25;
            DGView.Size = new Size(784, 434);
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
            tableLayoutPanel4.Location = new Point(3, 560);
            tableLayoutPanel4.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(785, 38);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // BtnExit
            // 
            BtnExit.BackColor = SystemColors.Control;
            BtnExit.Dock = DockStyle.Fill;
            BtnExit.ForeColor = Color.Crimson;
            BtnExit.Location = new Point(703, 2);
            BtnExit.Margin = new Padding(3, 2, 3, 2);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(79, 34);
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
            BtnEdit.Location = new Point(620, 2);
            BtnEdit.Margin = new Padding(3, 2, 3, 2);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(77, 34);
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
            BtnDelete.Location = new Point(537, 2);
            BtnDelete.Margin = new Padding(3, 2, 3, 2);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(77, 34);
            BtnDelete.TabIndex = 1;
            BtnDelete.Text = "Delete";
            BtnDelete.UseVisualStyleBackColor = false;
            BtnDelete.Visible = false;
            // 
            // LblHelp
            // 
            LblHelp.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblHelp.AutoSize = true;
            LblHelp.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LblHelp.Location = new Point(3, 11);
            LblHelp.Name = "LblHelp";
            LblHelp.Size = new Size(528, 15);
            LblHelp.TabIndex = 0;
            LblHelp.Text = "Focus : Ctrl + G => Grid View && F1 => Filter";
            // 
            // PanelFilter
            // 
            PanelFilter.BorderStyle = BorderStyle.FixedSingle;
            PanelFilter.Controls.Add(tableLayoutPanel5);
            PanelFilter.Dock = DockStyle.Fill;
            PanelFilter.Location = new Point(3, 2);
            PanelFilter.Margin = new Padding(3, 2, 3, 2);
            PanelFilter.Name = "PanelFilter";
            PanelFilter.Size = new Size(785, 116);
            PanelFilter.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 10;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.27260351F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.1506824F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.1506853F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.272603F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.1506853F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.1506853F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.276947F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.1506786F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.1518221F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.272603F));
            tableLayoutPanel5.Controls.Add(LblFilterCatType, 1, 1);
            tableLayoutPanel5.Controls.Add(CmbFilterCategoryType, 2, 1);
            tableLayoutPanel5.Controls.Add(CmbFilterQtyType, 5, 1);
            tableLayoutPanel5.Controls.Add(LblFilterActive, 1, 2);
            tableLayoutPanel5.Controls.Add(CmbFilterActive, 2, 2);
            tableLayoutPanel5.Controls.Add(LblFilterProduct, 4, 2);
            tableLayoutPanel5.Controls.Add(TxtFilterProduct, 5, 2);
            tableLayoutPanel5.Controls.Add(LblFilters, 0, 0);
            tableLayoutPanel5.Controls.Add(LblFilterQtyType, 4, 1);
            tableLayoutPanel5.Controls.Add(label10, 7, 1);
            tableLayoutPanel5.Controls.Add(CmbFilterMaintainStock, 8, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 3;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel5.Size = new Size(783, 114);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // LblFilterCatType
            // 
            LblFilterCatType.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblFilterCatType.AutoSize = true;
            LblFilterCatType.ForeColor = Color.FromArgb(163, 0, 34);
            LblFilterCatType.Location = new Point(20, 35);
            LblFilterCatType.Name = "LblFilterCatType";
            LblFilterCatType.Size = new Size(112, 19);
            LblFilterCatType.TabIndex = 1;
            LblFilterCatType.Text = "Category Type";
            // 
            // CmbFilterCategoryType
            // 
            CmbFilterCategoryType.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CmbFilterCategoryType.BackColor = Color.White;
            CmbFilterCategoryType.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbFilterCategoryType.FlatStyle = FlatStyle.Flat;
            CmbFilterCategoryType.ForeColor = Color.DarkGreen;
            CmbFilterCategoryType.FormattingEnabled = true;
            CmbFilterCategoryType.Location = new Point(138, 31);
            CmbFilterCategoryType.Margin = new Padding(3, 2, 3, 2);
            CmbFilterCategoryType.Name = "CmbFilterCategoryType";
            CmbFilterCategoryType.Size = new Size(112, 27);
            CmbFilterCategoryType.TabIndex = 2;
            CmbFilterCategoryType.SelectedIndexChanged += CmbFilterQtyType_SelectedIndexChanged;
            CmbFilterCategoryType.Enter += ComboBox_Enter;
            CmbFilterCategoryType.Leave += ComboBox_Leave;
            // 
            // CmbFilterQtyType
            // 
            CmbFilterQtyType.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CmbFilterQtyType.BackColor = Color.White;
            CmbFilterQtyType.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbFilterQtyType.FlatStyle = FlatStyle.Flat;
            CmbFilterQtyType.ForeColor = Color.DarkGreen;
            CmbFilterQtyType.FormattingEnabled = true;
            CmbFilterQtyType.Location = new Point(391, 31);
            CmbFilterQtyType.Margin = new Padding(3, 2, 3, 2);
            CmbFilterQtyType.Name = "CmbFilterQtyType";
            CmbFilterQtyType.Size = new Size(112, 27);
            CmbFilterQtyType.TabIndex = 4;
            CmbFilterQtyType.SelectedIndexChanged += CmbFilterQtyType_SelectedIndexChanged;
            CmbFilterQtyType.Enter += ComboBox_Enter;
            CmbFilterQtyType.Leave += ComboBox_Leave;
            // 
            // LblFilterActive
            // 
            LblFilterActive.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblFilterActive.AutoSize = true;
            LblFilterActive.ForeColor = Color.FromArgb(163, 0, 34);
            LblFilterActive.Location = new Point(20, 81);
            LblFilterActive.Name = "LblFilterActive";
            LblFilterActive.Size = new Size(112, 19);
            LblFilterActive.TabIndex = 7;
            LblFilterActive.Text = "Active";
            // 
            // CmbFilterActive
            // 
            CmbFilterActive.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CmbFilterActive.BackColor = Color.White;
            CmbFilterActive.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbFilterActive.FlatStyle = FlatStyle.Flat;
            CmbFilterActive.ForeColor = Color.DarkGreen;
            CmbFilterActive.FormattingEnabled = true;
            CmbFilterActive.Location = new Point(138, 77);
            CmbFilterActive.Margin = new Padding(3, 2, 3, 2);
            CmbFilterActive.Name = "CmbFilterActive";
            CmbFilterActive.Size = new Size(112, 27);
            CmbFilterActive.TabIndex = 8;
            CmbFilterActive.SelectedIndexChanged += CmbFilterQtyType_SelectedIndexChanged;
            CmbFilterActive.Enter += ComboBox_Enter;
            CmbFilterActive.Leave += ComboBox_Leave;
            // 
            // LblFilterProduct
            // 
            LblFilterProduct.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblFilterProduct.AutoSize = true;
            LblFilterProduct.ForeColor = Color.FromArgb(163, 0, 34);
            LblFilterProduct.Location = new Point(273, 71);
            LblFilterProduct.Name = "LblFilterProduct";
            LblFilterProduct.Size = new Size(112, 38);
            LblFilterProduct.TabIndex = 9;
            LblFilterProduct.Text = "Product Search";
            // 
            // TxtFilterProduct
            // 
            TxtFilterProduct.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtFilterProduct.BackColor = Color.White;
            tableLayoutPanel5.SetColumnSpan(TxtFilterProduct, 4);
            TxtFilterProduct.ForeColor = Color.DarkGreen;
            TxtFilterProduct.Location = new Point(391, 77);
            TxtFilterProduct.Margin = new Padding(3, 2, 3, 2);
            TxtFilterProduct.MaxLength = 25;
            TxtFilterProduct.Name = "TxtFilterProduct";
            TxtFilterProduct.Size = new Size(365, 27);
            TxtFilterProduct.TabIndex = 10;
            TxtFilterProduct.TextChanged += TxtFilterProduct_TextChanged;
            TxtFilterProduct.Enter += TextBox_Enter;
            TxtFilterProduct.Leave += TextBox_Leave;
            // 
            // LblFilters
            // 
            LblFilters.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblFilters.AutoSize = true;
            tableLayoutPanel5.SetColumnSpan(LblFilters, 2);
            LblFilters.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            LblFilters.ForeColor = Color.DarkGreen;
            LblFilters.Location = new Point(3, 1);
            LblFilters.Name = "LblFilters";
            LblFilters.Size = new Size(129, 19);
            LblFilters.TabIndex = 0;
            LblFilters.Text = "Filters";
            // 
            // LblFilterQtyType
            // 
            LblFilterQtyType.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblFilterQtyType.AutoSize = true;
            LblFilterQtyType.ForeColor = Color.FromArgb(163, 0, 34);
            LblFilterQtyType.Location = new Point(273, 35);
            LblFilterQtyType.Name = "LblFilterQtyType";
            LblFilterQtyType.Size = new Size(112, 19);
            LblFilterQtyType.TabIndex = 3;
            LblFilterQtyType.Text = "Quantity Type";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.ForeColor = Color.FromArgb(163, 0, 34);
            label10.Location = new Point(526, 25);
            label10.Name = "label10";
            label10.Size = new Size(112, 38);
            label10.TabIndex = 5;
            label10.Text = "Maintain Stock";
            // 
            // CmbFilterMaintainStock
            // 
            CmbFilterMaintainStock.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CmbFilterMaintainStock.BackColor = Color.White;
            CmbFilterMaintainStock.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbFilterMaintainStock.FlatStyle = FlatStyle.Flat;
            CmbFilterMaintainStock.ForeColor = Color.DarkGreen;
            CmbFilterMaintainStock.FormattingEnabled = true;
            CmbFilterMaintainStock.Location = new Point(644, 31);
            CmbFilterMaintainStock.Margin = new Padding(3, 2, 3, 2);
            CmbFilterMaintainStock.Name = "CmbFilterMaintainStock";
            CmbFilterMaintainStock.Size = new Size(112, 27);
            CmbFilterMaintainStock.TabIndex = 6;
            CmbFilterMaintainStock.SelectedIndexChanged += CmbFilterMaintainStock_SelectedIndexChanged;
            CmbFilterMaintainStock.Enter += ComboBox_Enter;
            CmbFilterMaintainStock.Leave += ComboBox_Leave;
            // 
            // ErrorProvider
            // 
            ErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            ErrorProvider.ContainerControl = this;
            // 
            // FrmProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1256, 645);
            Controls.Add(TlpMain);
            Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "FrmProduct";
            Text = "Product - Master";
            Activated += FrmProduct_Activated;
            Load += FrmProduct_Load;
            KeyDown += FrmProduct_KeyDown;
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
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TlpMain;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label LblProductName;
        private Label LblProductTName;
        private Label LblProductAlternateName;
        private Label LblCategoryType;
        private Label LblQtyType;
        private Label LblCBORateMaster;
        private TableLayoutPanel tableLayoutPanel2;
        private Button BtnSave;
        private Button BtnCancel;
        private TextBox TxtProductName;
        private TextBox TxtProductTamilName;
        private TextBox TxtProductAlternateName;
        private ComboBox CmbCategoryType;
        private ComboBox CmbQtyType;
        private ComboBox CmbCBORateMaster;
        private DataGridView DGView;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel4;
        private Button BtnEdit;
        private Button BtnDelete;
        private TableLayoutPanel tableLayoutPanel3;
        private Button BtnExit;
        private TableLayoutPanel tableLayoutPanel5;
        private Label LblFilterCatType;
        private Label LblFilterActive;
        private Label LblFilterProduct;
        private Label LblFilterQtyType;
        private ComboBox CmbFilterCategoryType;
        private ComboBox CmbFilterQtyType;
        private ComboBox CmbFilterActive;
        private TextBox TxtFilterProduct;
        private Panel PanelFilter;
        private Label LblFilters;
        private ErrorProvider ErrorProvider;
        private Label LblHelp;
        private Label label1;
        private TextBox TxtBarcode;
        private ComboBox CmbAllowRateChange;
        private Label label2;
        private TextBox TxtBarcode2;
        private TextBox TxtBarcode3;
        private TextBox TxtBarcode4;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label LblMinimumStock;
        private Label LblMaximumStock;
        private TextBox TxtMinimumStock;
        private TextBox TxtMaximumStock;
        private Label LblMaintainStock;
        private ComboBox CmbMaintainStock;
        private Label label9;
        private ComboBox CmbActive;
        private Label label10;
        private ComboBox CmbFilterMaintainStock;
    }
}