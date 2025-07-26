namespace VegetableBox
{
    partial class FrmVendorMaster
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
            LblProductAlternateName = new Label();
            LblActive = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            BtnSave = new Button();
            BtnCancel = new Button();
            TxtProductName = new TextBox();
            TxtProductAlternateName = new TextBox();
            CmbActive = new ComboBox();
            label1 = new Label();
            TxtBarcode = new TextBox();
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
            LblFilterQtyType = new Label();
            CmbFilterCategoryType = new ComboBox();
            CmbFilterQtyType = new ComboBox();
            LblFilterActive = new Label();
            CmbFilterActive = new ComboBox();
            LblFilterProduct = new Label();
            TxtFilterProduct = new TextBox();
            LblFilters = new Label();
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
            TlpMain.Margin = new Padding(3, 4, 3, 4);
            TlpMain.Name = "TlpMain";
            TlpMain.RowCount = 5;
            TlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 2.88461542F));
            TlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 17.6090469F));
            TlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 60.4200325F));
            TlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 15.9935379F));
            TlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 2.88461542F));
            TlpMain.Size = new Size(1320, 619);
            TlpMain.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(16, 130);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(447, 366);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 0.9835724F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.1297531F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55.8970032F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.9896667F));
            tableLayoutPanel1.Controls.Add(LblProductName, 1, 1);
            tableLayoutPanel1.Controls.Add(LblProductAlternateName, 1, 3);
            tableLayoutPanel1.Controls.Add(LblActive, 1, 8);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 2, 9);
            tableLayoutPanel1.Controls.Add(TxtProductName, 2, 1);
            tableLayoutPanel1.Controls.Add(TxtProductAlternateName, 2, 3);
            tableLayoutPanel1.Controls.Add(CmbActive, 2, 8);
            tableLayoutPanel1.Controls.Add(label1, 1, 7);
            tableLayoutPanel1.Controls.Add(TxtBarcode, 2, 7);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 11;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 0.21691975F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.0629063F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.0629063F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.0629063F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.0629063F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.0629063F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.0629063F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.0629063F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.0629063F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.0629063F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 0.216919735F));
            tableLayoutPanel1.Size = new Size(445, 364);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // LblProductName
            // 
            LblProductName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblProductName.AutoSize = true;
            LblProductName.ForeColor = Color.FromArgb(163, 0, 34);
            LblProductName.Location = new Point(7, 10);
            LblProductName.Name = "LblProductName";
            LblProductName.Size = new Size(172, 19);
            LblProductName.TabIndex = 0;
            LblProductName.Text = "Product Name";
            // 
            // LblProductAlternateName
            // 
            LblProductAlternateName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblProductAlternateName.AutoSize = true;
            LblProductAlternateName.ForeColor = Color.FromArgb(163, 0, 34);
            LblProductAlternateName.Location = new Point(7, 90);
            LblProductAlternateName.Name = "LblProductAlternateName";
            LblProductAlternateName.Size = new Size(172, 19);
            LblProductAlternateName.TabIndex = 4;
            LblProductAlternateName.Text = "Alternate Name";
            // 
            // LblActive
            // 
            LblActive.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblActive.AutoSize = true;
            LblActive.ForeColor = Color.FromArgb(163, 0, 34);
            LblActive.Location = new Point(7, 290);
            LblActive.Name = "LblActive";
            LblActive.Size = new Size(172, 19);
            LblActive.TabIndex = 14;
            LblActive.Text = "Active";
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
            tableLayoutPanel2.Location = new Point(182, 320);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(248, 40);
            tableLayoutPanel2.TabIndex = 16;
            // 
            // BtnSave
            // 
            BtnSave.BackColor = Color.SeaGreen;
            BtnSave.Dock = DockStyle.Fill;
            BtnSave.FlatStyle = FlatStyle.Popup;
            BtnSave.ForeColor = Color.White;
            BtnSave.Location = new Point(27, 3);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(105, 34);
            BtnSave.TabIndex = 0;
            BtnSave.Text = "&Save";
            BtnSave.UseVisualStyleBackColor = false;
            BtnSave.Click += BtnSave_Click;
            // 
            // BtnCancel
            // 
            BtnCancel.BackColor = Color.SeaGreen;
            BtnCancel.Dock = DockStyle.Fill;
            BtnCancel.FlatStyle = FlatStyle.Popup;
            BtnCancel.ForeColor = Color.White;
            BtnCancel.Location = new Point(138, 3);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(107, 34);
            BtnCancel.TabIndex = 1;
            BtnCancel.Text = "&Cancel";
            BtnCancel.UseVisualStyleBackColor = false;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // TxtProductName
            // 
            TxtProductName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtProductName.BackColor = Color.White;
            TxtProductName.ForeColor = Color.DarkGreen;
            TxtProductName.Location = new Point(185, 6);
            TxtProductName.MaxLength = 50;
            TxtProductName.Name = "TxtProductName";
            TxtProductName.Size = new Size(242, 27);
            TxtProductName.TabIndex = 1;
            TxtProductName.TextChanged += TxtProductName_TextChanged;
            TxtProductName.Enter += TextBox_Enter;
            TxtProductName.Leave += TextBox_Leave;
            // 
            // TxtProductAlternateName
            // 
            TxtProductAlternateName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtProductAlternateName.BackColor = Color.White;
            TxtProductAlternateName.ForeColor = Color.DarkGreen;
            TxtProductAlternateName.Location = new Point(185, 86);
            TxtProductAlternateName.MaxLength = 50;
            TxtProductAlternateName.Name = "TxtProductAlternateName";
            TxtProductAlternateName.Size = new Size(242, 27);
            TxtProductAlternateName.TabIndex = 5;
            TxtProductAlternateName.Enter += TextBox_Enter;
            TxtProductAlternateName.Leave += TextBox_Leave;
            // 
            // CmbActive
            // 
            CmbActive.Anchor = AnchorStyles.Left;
            CmbActive.BackColor = Color.White;
            CmbActive.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbActive.FlatStyle = FlatStyle.Flat;
            CmbActive.ForeColor = Color.DarkGreen;
            CmbActive.FormattingEnabled = true;
            CmbActive.Location = new Point(185, 286);
            CmbActive.Name = "CmbActive";
            CmbActive.Size = new Size(121, 27);
            CmbActive.TabIndex = 15;
            CmbActive.Enter += ComboBox_Enter;
            CmbActive.Leave += ComboBox_Leave;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(163, 0, 34);
            label1.Location = new Point(7, 250);
            label1.Name = "label1";
            label1.Size = new Size(172, 19);
            label1.TabIndex = 12;
            label1.Text = "Barcode";
            // 
            // TxtBarcode
            // 
            TxtBarcode.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtBarcode.BackColor = Color.White;
            TxtBarcode.ForeColor = Color.DarkGreen;
            TxtBarcode.Location = new Point(185, 246);
            TxtBarcode.MaxLength = 50;
            TxtBarcode.Name = "TxtBarcode";
            TxtBarcode.Size = new Size(242, 27);
            TxtBarcode.TabIndex = 13;
            TxtBarcode.Enter += TextBox_Enter;
            TxtBarcode.Leave += TextBox_Leave;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(tableLayoutPanel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(469, 20);
            panel2.Name = "panel2";
            TlpMain.SetRowSpan(panel2, 3);
            panel2.Size = new Size(834, 576);
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
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 73F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            tableLayoutPanel3.Size = new Size(832, 574);
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
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.SelectionForeColor = Color.ForestGreen;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DGView.DefaultCellStyle = dataGridViewCellStyle2;
            DGView.Dock = DockStyle.Fill;
            DGView.Location = new Point(5, 117);
            DGView.Margin = new Padding(5, 3, 3, 3);
            DGView.MultiSelect = false;
            DGView.Name = "DGView";
            DGView.ReadOnly = true;
            DGView.RowHeadersVisible = false;
            DGView.RowTemplate.Height = 25;
            DGView.Size = new Size(824, 413);
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
            tableLayoutPanel4.Location = new Point(3, 536);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(826, 35);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // BtnExit
            // 
            BtnExit.BackColor = Color.SeaGreen;
            BtnExit.Dock = DockStyle.Fill;
            BtnExit.FlatStyle = FlatStyle.Popup;
            BtnExit.ForeColor = Color.White;
            BtnExit.Location = new Point(739, 3);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(84, 29);
            BtnExit.TabIndex = 0;
            BtnExit.Text = "E&xit";
            BtnExit.UseVisualStyleBackColor = false;
            BtnExit.Click += BtnExit_Click;
            // 
            // BtnEdit
            // 
            BtnEdit.BackColor = Color.SeaGreen;
            BtnEdit.Dock = DockStyle.Fill;
            BtnEdit.FlatStyle = FlatStyle.Popup;
            BtnEdit.ForeColor = Color.White;
            BtnEdit.Location = new Point(652, 3);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(81, 29);
            BtnEdit.TabIndex = 3;
            BtnEdit.Text = "&Edit";
            BtnEdit.UseVisualStyleBackColor = false;
            BtnEdit.Click += BtnEdit_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.BackColor = Color.SeaGreen;
            BtnDelete.Dock = DockStyle.Fill;
            BtnDelete.FlatStyle = FlatStyle.Popup;
            BtnDelete.ForeColor = Color.White;
            BtnDelete.Location = new Point(565, 3);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(81, 29);
            BtnDelete.TabIndex = 2;
            BtnDelete.Text = "Delete";
            BtnDelete.UseVisualStyleBackColor = false;
            BtnDelete.Visible = false;
            // 
            // LblHelp
            // 
            LblHelp.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblHelp.AutoSize = true;
            LblHelp.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LblHelp.Location = new Point(3, 10);
            LblHelp.Name = "LblHelp";
            LblHelp.Size = new Size(556, 15);
            LblHelp.TabIndex = 1;
            LblHelp.Text = "Focus : Ctrl + G => Grid View && F1 => Filter";
            // 
            // PanelFilter
            // 
            PanelFilter.BorderStyle = BorderStyle.FixedSingle;
            PanelFilter.Controls.Add(tableLayoutPanel5);
            PanelFilter.Dock = DockStyle.Fill;
            PanelFilter.Location = new Point(3, 3);
            PanelFilter.Name = "PanelFilter";
            PanelFilter.Size = new Size(826, 108);
            PanelFilter.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 8;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.752294F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.3486233F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.3486233F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.75229359F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.3486233F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.3486233F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.3486233F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.75229359F));
            tableLayoutPanel5.Controls.Add(LblFilterCatType, 1, 1);
            tableLayoutPanel5.Controls.Add(LblFilterQtyType, 4, 1);
            tableLayoutPanel5.Controls.Add(CmbFilterCategoryType, 2, 1);
            tableLayoutPanel5.Controls.Add(CmbFilterQtyType, 5, 1);
            tableLayoutPanel5.Controls.Add(LblFilterActive, 1, 2);
            tableLayoutPanel5.Controls.Add(CmbFilterActive, 2, 2);
            tableLayoutPanel5.Controls.Add(LblFilterProduct, 4, 2);
            tableLayoutPanel5.Controls.Add(TxtFilterProduct, 5, 2);
            tableLayoutPanel5.Controls.Add(LblFilters, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 3;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel5.Size = new Size(824, 106);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // LblFilterCatType
            // 
            LblFilterCatType.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblFilterCatType.AutoSize = true;
            LblFilterCatType.ForeColor = Color.FromArgb(163, 0, 34);
            LblFilterCatType.Location = new Point(25, 32);
            LblFilterCatType.Name = "LblFilterCatType";
            LblFilterCatType.Size = new Size(145, 19);
            LblFilterCatType.TabIndex = 1;
            LblFilterCatType.Text = "Category Type";
            // 
            // LblFilterQtyType
            // 
            LblFilterQtyType.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblFilterQtyType.AutoSize = true;
            LblFilterQtyType.ForeColor = Color.FromArgb(163, 0, 34);
            LblFilterQtyType.Location = new Point(349, 32);
            LblFilterQtyType.Name = "LblFilterQtyType";
            LblFilterQtyType.Size = new Size(145, 19);
            LblFilterQtyType.TabIndex = 3;
            LblFilterQtyType.Text = "Quantity Type";
            // 
            // CmbFilterCategoryType
            // 
            CmbFilterCategoryType.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CmbFilterCategoryType.BackColor = Color.White;
            CmbFilterCategoryType.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbFilterCategoryType.FlatStyle = FlatStyle.Flat;
            CmbFilterCategoryType.ForeColor = Color.DarkGreen;
            CmbFilterCategoryType.FormattingEnabled = true;
            CmbFilterCategoryType.Location = new Point(176, 30);
            CmbFilterCategoryType.Name = "CmbFilterCategoryType";
            CmbFilterCategoryType.Size = new Size(145, 27);
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
            CmbFilterQtyType.Location = new Point(500, 30);
            CmbFilterQtyType.Name = "CmbFilterQtyType";
            CmbFilterQtyType.Size = new Size(145, 27);
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
            LblFilterActive.Location = new Point(25, 75);
            LblFilterActive.Name = "LblFilterActive";
            LblFilterActive.Size = new Size(145, 19);
            LblFilterActive.TabIndex = 5;
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
            CmbFilterActive.Location = new Point(176, 73);
            CmbFilterActive.Name = "CmbFilterActive";
            CmbFilterActive.Size = new Size(145, 27);
            CmbFilterActive.TabIndex = 6;
            CmbFilterActive.SelectedIndexChanged += CmbFilterQtyType_SelectedIndexChanged;
            CmbFilterActive.Enter += ComboBox_Enter;
            CmbFilterActive.Leave += ComboBox_Leave;
            // 
            // LblFilterProduct
            // 
            LblFilterProduct.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblFilterProduct.AutoSize = true;
            LblFilterProduct.ForeColor = Color.FromArgb(163, 0, 34);
            LblFilterProduct.Location = new Point(349, 75);
            LblFilterProduct.Name = "LblFilterProduct";
            LblFilterProduct.Size = new Size(145, 19);
            LblFilterProduct.TabIndex = 7;
            LblFilterProduct.Text = "Product Search";
            // 
            // TxtFilterProduct
            // 
            TxtFilterProduct.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtFilterProduct.BackColor = Color.White;
            tableLayoutPanel5.SetColumnSpan(TxtFilterProduct, 2);
            TxtFilterProduct.ForeColor = Color.DarkGreen;
            TxtFilterProduct.Location = new Point(500, 71);
            TxtFilterProduct.MaxLength = 25;
            TxtFilterProduct.Name = "TxtFilterProduct";
            TxtFilterProduct.Size = new Size(296, 27);
            TxtFilterProduct.TabIndex = 8;
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
            LblFilters.Size = new Size(167, 19);
            LblFilters.TabIndex = 0;
            LblFilters.Text = "Filters";
            // 
            // ErrorProvider
            // 
            ErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            ErrorProvider.ContainerControl = this;
            // 
            // FrmVendorMaster
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1320, 619);
            Controls.Add(TlpMain);
            Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmVendorMaster";
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
        private Label LblProductAlternateName;
        private Label LblActive;
        private TableLayoutPanel tableLayoutPanel2;
        private Button BtnSave;
        private Button BtnCancel;
        private TextBox TxtProductName;
        private TextBox TxtProductAlternateName;
        private ComboBox CmbActive;
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
    }
}