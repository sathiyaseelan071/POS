namespace VegetableBox
{
    partial class FrmRateMaster
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
            tableLayoutPanel3 = new TableLayoutPanel();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            BtnBulkUpdate = new Button();
            LblBulkCatType = new Label();
            CmbBulkCatType = new ComboBox();
            LblBulkUpload = new Label();
            LblBulkPercentage = new Label();
            TxtBulkPercentage = new TextBox();
            DGView = new DataGridView();
            tableLayoutPanel4 = new TableLayoutPanel();
            BtnExit = new Button();
            LblHelp = new Label();
            BtnCancel = new Button();
            BtnSave = new Button();
            BtnPrint = new Button();
            PanelFilter = new Panel();
            tableLayoutPanel5 = new TableLayoutPanel();
            LblFilterCatType = new Label();
            LblFilterQtyType = new Label();
            CmbFilterCategoryType = new ComboBox();
            CmbFilterQtyType = new ComboBox();
            LblFilters = new Label();
            LblFilterProduct = new Label();
            TxtFilterProduct = new TextBox();
            ErrorProvider = new ErrorProvider(components);
            TlpMain.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGView).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            PanelFilter.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // TlpMain
            // 
            TlpMain.ColumnCount = 3;
            TlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2F));
            TlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 96F));
            TlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2F));
            TlpMain.Controls.Add(tableLayoutPanel3, 1, 1);
            TlpMain.Dock = DockStyle.Fill;
            TlpMain.Location = new Point(0, 0);
            TlpMain.Margin = new Padding(3, 4, 3, 4);
            TlpMain.Name = "TlpMain";
            TlpMain.RowCount = 3;
            TlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 2F));
            TlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 96F));
            TlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 2F));
            TlpMain.Size = new Size(1320, 619);
            TlpMain.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(panel1, 0, 1);
            tableLayoutPanel3.Controls.Add(DGView, 0, 2);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 3);
            tableLayoutPanel3.Controls.Add(PanelFilter, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(29, 15);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 81.1111145F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 7.77777767F));
            tableLayoutPanel3.Size = new Size(1261, 588);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 58);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1261, 58);
            panel1.TabIndex = 1;
            panel1.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 10;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.415459F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.0772943F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.0772943F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.41545916F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.0772943F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.0772943F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.41545916F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.0772943F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.95169F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.41545916F));
            tableLayoutPanel1.Controls.Add(BtnBulkUpdate, 7, 1);
            tableLayoutPanel1.Controls.Add(LblBulkCatType, 1, 1);
            tableLayoutPanel1.Controls.Add(CmbBulkCatType, 2, 1);
            tableLayoutPanel1.Controls.Add(LblBulkUpload, 0, 0);
            tableLayoutPanel1.Controls.Add(LblBulkPercentage, 4, 1);
            tableLayoutPanel1.Controls.Add(TxtBulkPercentage, 5, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 66.6666641F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1259, 56);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // BtnBulkUpdate
            // 
            BtnBulkUpdate.Anchor = AnchorStyles.Left;
            BtnBulkUpdate.BackColor = Color.SeaGreen;
            BtnBulkUpdate.FlatStyle = FlatStyle.Popup;
            BtnBulkUpdate.ForeColor = Color.White;
            BtnBulkUpdate.Location = new Point(701, 21);
            BtnBulkUpdate.Name = "BtnBulkUpdate";
            BtnBulkUpdate.Size = new Size(84, 32);
            BtnBulkUpdate.TabIndex = 5;
            BtnBulkUpdate.Text = "&Update";
            BtnBulkUpdate.UseVisualStyleBackColor = false;
            // 
            // LblBulkCatType
            // 
            LblBulkCatType.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblBulkCatType.AutoSize = true;
            LblBulkCatType.ForeColor = Color.FromArgb(163, 0, 34);
            LblBulkCatType.Location = new Point(33, 27);
            LblBulkCatType.Name = "LblBulkCatType";
            LblBulkCatType.Size = new Size(146, 19);
            LblBulkCatType.TabIndex = 1;
            LblBulkCatType.Text = "Category Type";
            // 
            // CmbBulkCatType
            // 
            CmbBulkCatType.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CmbBulkCatType.BackColor = Color.White;
            CmbBulkCatType.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbBulkCatType.FlatStyle = FlatStyle.Flat;
            CmbBulkCatType.ForeColor = Color.DarkGreen;
            CmbBulkCatType.FormattingEnabled = true;
            CmbBulkCatType.Location = new Point(185, 23);
            CmbBulkCatType.Name = "CmbBulkCatType";
            CmbBulkCatType.Size = new Size(146, 27);
            CmbBulkCatType.TabIndex = 2;
            CmbBulkCatType.Enter += ComboBox_Enter;
            CmbBulkCatType.Leave += ComboBox_Leave;
            // 
            // LblBulkUpload
            // 
            LblBulkUpload.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblBulkUpload.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(LblBulkUpload, 2);
            LblBulkUpload.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            LblBulkUpload.ForeColor = Color.DarkGreen;
            LblBulkUpload.Location = new Point(3, 0);
            LblBulkUpload.Name = "LblBulkUpload";
            LblBulkUpload.Size = new Size(176, 18);
            LblBulkUpload.TabIndex = 0;
            LblBulkUpload.Text = "Bulk Update";
            // 
            // LblBulkPercentage
            // 
            LblBulkPercentage.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblBulkPercentage.AutoSize = true;
            LblBulkPercentage.ForeColor = Color.FromArgb(163, 0, 34);
            LblBulkPercentage.Location = new Point(367, 27);
            LblBulkPercentage.Name = "LblBulkPercentage";
            LblBulkPercentage.Size = new Size(146, 19);
            LblBulkPercentage.TabIndex = 3;
            LblBulkPercentage.Text = "Sell Margin %";
            // 
            // TxtBulkPercentage
            // 
            TxtBulkPercentage.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtBulkPercentage.BackColor = Color.White;
            TxtBulkPercentage.ForeColor = Color.DarkGreen;
            TxtBulkPercentage.Location = new Point(519, 23);
            TxtBulkPercentage.MaxLength = 10;
            TxtBulkPercentage.Name = "TxtBulkPercentage";
            TxtBulkPercentage.Size = new Size(146, 27);
            TxtBulkPercentage.TabIndex = 4;
            TxtBulkPercentage.TextAlign = HorizontalAlignment.Right;
            TxtBulkPercentage.TextChanged += TxtFilterProduct_TextChanged;
            TxtBulkPercentage.Enter += TextBox_Enter;
            TxtBulkPercentage.KeyPress += Number_KeyPress;
            TxtBulkPercentage.Leave += TextBox_Leave;
            // 
            // DGView
            // 
            DGView.AllowUserToAddRows = false;
            DGView.AllowUserToDeleteRows = false;
            DGView.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DGView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DGView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.SelectionForeColor = Color.ForestGreen;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DGView.DefaultCellStyle = dataGridViewCellStyle2;
            DGView.Dock = DockStyle.Fill;
            DGView.Location = new Point(0, 119);
            DGView.Margin = new Padding(0, 3, 0, 3);
            DGView.MultiSelect = false;
            DGView.Name = "DGView";
            DGView.RowHeadersVisible = false;
            DGView.RowTemplate.Height = 25;
            DGView.Size = new Size(1261, 423);
            DGView.TabIndex = 2;
            DGView.CellEndEdit += DGView_CellEndEdit;
            DGView.CellEnter += DGView_CellEnter;
            DGView.CellValidating += DGView_CellValidating;
            DGView.DataBindingComplete += DGView_DataBindingComplete;
            DGView.KeyDown += DGView_KeyDown;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 5;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel4.Controls.Add(BtnExit, 4, 0);
            tableLayoutPanel4.Controls.Add(LblHelp, 0, 0);
            tableLayoutPanel4.Controls.Add(BtnCancel, 3, 0);
            tableLayoutPanel4.Controls.Add(BtnSave, 1, 0);
            tableLayoutPanel4.Controls.Add(BtnPrint, 2, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 548);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(1255, 37);
            tableLayoutPanel4.TabIndex = 3;
            // 
            // BtnExit
            // 
            BtnExit.BackColor = Color.SeaGreen;
            BtnExit.Dock = DockStyle.Fill;
            BtnExit.FlatStyle = FlatStyle.Popup;
            BtnExit.ForeColor = Color.White;
            BtnExit.Location = new Point(1131, 3);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(121, 31);
            BtnExit.TabIndex = 2;
            BtnExit.Text = "E&xit";
            BtnExit.UseVisualStyleBackColor = false;
            BtnExit.Click += BtnExit_Click;
            // 
            // LblHelp
            // 
            LblHelp.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblHelp.AutoSize = true;
            LblHelp.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LblHelp.Location = new Point(3, 11);
            LblHelp.Name = "LblHelp";
            LblHelp.Size = new Size(747, 15);
            LblHelp.TabIndex = 0;
            LblHelp.Text = "Focus : Ctrl + G => Grid View && F1 => Filter && Click \"P\" => Print Display Rate";
            // 
            // BtnCancel
            // 
            BtnCancel.BackColor = Color.SeaGreen;
            BtnCancel.Dock = DockStyle.Fill;
            BtnCancel.FlatStyle = FlatStyle.Popup;
            BtnCancel.ForeColor = Color.White;
            BtnCancel.Location = new Point(1006, 3);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(119, 31);
            BtnCancel.TabIndex = 2;
            BtnCancel.Text = "&Cancel";
            BtnCancel.UseVisualStyleBackColor = false;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // BtnSave
            // 
            BtnSave.BackColor = Color.SeaGreen;
            BtnSave.Dock = DockStyle.Fill;
            BtnSave.FlatStyle = FlatStyle.Popup;
            BtnSave.ForeColor = Color.White;
            BtnSave.Location = new Point(756, 3);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(119, 31);
            BtnSave.TabIndex = 3;
            BtnSave.Text = "&Save";
            BtnSave.UseVisualStyleBackColor = false;
            BtnSave.Click += BtnSave_Click;
            // 
            // BtnPrint
            // 
            BtnPrint.BackColor = Color.SeaGreen;
            BtnPrint.Dock = DockStyle.Fill;
            BtnPrint.FlatStyle = FlatStyle.Popup;
            BtnPrint.ForeColor = Color.White;
            BtnPrint.Location = new Point(881, 3);
            BtnPrint.Name = "BtnPrint";
            BtnPrint.Size = new Size(119, 31);
            BtnPrint.TabIndex = 2;
            BtnPrint.Text = "&Print";
            BtnPrint.UseVisualStyleBackColor = false;
            BtnPrint.Click += BtnPrint_Click;
            // 
            // PanelFilter
            // 
            PanelFilter.BorderStyle = BorderStyle.FixedSingle;
            PanelFilter.Controls.Add(tableLayoutPanel5);
            PanelFilter.Dock = DockStyle.Fill;
            PanelFilter.Location = new Point(0, 0);
            PanelFilter.Margin = new Padding(0);
            PanelFilter.Name = "PanelFilter";
            PanelFilter.Size = new Size(1261, 58);
            PanelFilter.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 10;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.415459F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.0772943F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.0772943F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.41545916F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.0772943F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.0772943F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.41545916F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.0772943F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.95169F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.41545916F));
            tableLayoutPanel5.Controls.Add(LblFilterCatType, 1, 1);
            tableLayoutPanel5.Controls.Add(LblFilterQtyType, 4, 1);
            tableLayoutPanel5.Controls.Add(CmbFilterCategoryType, 2, 1);
            tableLayoutPanel5.Controls.Add(CmbFilterQtyType, 5, 1);
            tableLayoutPanel5.Controls.Add(LblFilters, 0, 0);
            tableLayoutPanel5.Controls.Add(LblFilterProduct, 7, 1);
            tableLayoutPanel5.Controls.Add(TxtFilterProduct, 8, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 66.6666641F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(1259, 56);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // LblFilterCatType
            // 
            LblFilterCatType.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblFilterCatType.AutoSize = true;
            LblFilterCatType.ForeColor = Color.FromArgb(163, 0, 34);
            LblFilterCatType.Location = new Point(33, 27);
            LblFilterCatType.Name = "LblFilterCatType";
            LblFilterCatType.Size = new Size(146, 19);
            LblFilterCatType.TabIndex = 1;
            LblFilterCatType.Text = "Category Type";
            // 
            // LblFilterQtyType
            // 
            LblFilterQtyType.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblFilterQtyType.AutoSize = true;
            LblFilterQtyType.ForeColor = Color.FromArgb(163, 0, 34);
            LblFilterQtyType.Location = new Point(367, 27);
            LblFilterQtyType.Name = "LblFilterQtyType";
            LblFilterQtyType.Size = new Size(146, 19);
            LblFilterQtyType.TabIndex = 3;
            LblFilterQtyType.Text = "Qauntity Type";
            // 
            // CmbFilterCategoryType
            // 
            CmbFilterCategoryType.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CmbFilterCategoryType.BackColor = Color.White;
            CmbFilterCategoryType.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbFilterCategoryType.Enabled = false;
            CmbFilterCategoryType.FlatStyle = FlatStyle.Flat;
            CmbFilterCategoryType.ForeColor = Color.DarkGreen;
            CmbFilterCategoryType.FormattingEnabled = true;
            CmbFilterCategoryType.Location = new Point(185, 25);
            CmbFilterCategoryType.Name = "CmbFilterCategoryType";
            CmbFilterCategoryType.Size = new Size(146, 27);
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
            CmbFilterQtyType.Enabled = false;
            CmbFilterQtyType.FlatStyle = FlatStyle.Flat;
            CmbFilterQtyType.ForeColor = Color.DarkGreen;
            CmbFilterQtyType.FormattingEnabled = true;
            CmbFilterQtyType.Location = new Point(519, 25);
            CmbFilterQtyType.Name = "CmbFilterQtyType";
            CmbFilterQtyType.Size = new Size(146, 27);
            CmbFilterQtyType.TabIndex = 4;
            CmbFilterQtyType.SelectedIndexChanged += CmbFilterQtyType_SelectedIndexChanged;
            CmbFilterQtyType.Enter += ComboBox_Enter;
            CmbFilterQtyType.Leave += ComboBox_Leave;
            // 
            // LblFilters
            // 
            LblFilters.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblFilters.AutoSize = true;
            tableLayoutPanel5.SetColumnSpan(LblFilters, 2);
            LblFilters.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            LblFilters.ForeColor = Color.DarkGreen;
            LblFilters.Location = new Point(3, 0);
            LblFilters.Name = "LblFilters";
            LblFilters.Size = new Size(176, 18);
            LblFilters.TabIndex = 0;
            LblFilters.Text = "Filters";
            // 
            // LblFilterProduct
            // 
            LblFilterProduct.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblFilterProduct.AutoSize = true;
            LblFilterProduct.ForeColor = Color.FromArgb(163, 0, 34);
            LblFilterProduct.Location = new Point(701, 27);
            LblFilterProduct.Name = "LblFilterProduct";
            LblFilterProduct.Size = new Size(146, 19);
            LblFilterProduct.TabIndex = 5;
            LblFilterProduct.Text = "Product Search";
            // 
            // TxtFilterProduct
            // 
            TxtFilterProduct.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtFilterProduct.BackColor = Color.White;
            TxtFilterProduct.Enabled = false;
            TxtFilterProduct.ForeColor = Color.DarkGreen;
            TxtFilterProduct.Location = new Point(853, 23);
            TxtFilterProduct.MaxLength = 25;
            TxtFilterProduct.Name = "TxtFilterProduct";
            TxtFilterProduct.Size = new Size(371, 27);
            TxtFilterProduct.TabIndex = 6;
            TxtFilterProduct.TextChanged += TxtFilterProduct_TextChanged;
            TxtFilterProduct.Enter += TextBox_Enter;
            TxtFilterProduct.Leave += TextBox_Leave;
            // 
            // ErrorProvider
            // 
            ErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            ErrorProvider.ContainerControl = this;
            // 
            // FrmRateMaster
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
            Name = "FrmRateMaster";
            Text = "Rate - Master";
            Activated += FrmRateMaster_Activated;
            Load += FrmRateMaster_Load;
            KeyDown += FrmRateMaster_KeyDown;
            TlpMain.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
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
        private DataGridView DGView;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel3;
        private Button BtnExit;
        private TableLayoutPanel tableLayoutPanel5;
        private Label LblFilterCatType;
        private Label LblFilterProduct;
        private Label LblFilterQtyType;
        private ComboBox CmbFilterCategoryType;
        private ComboBox CmbFilterQtyType;
        private TextBox TxtFilterProduct;
        private Panel PanelFilter;
        private Label LblFilters;
        private ErrorProvider ErrorProvider;
        private Label LblHelp;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label LblBulkCatType;
        private ComboBox CmbBulkCatType;
        private Label LblBulkUpload;
        private Label LblBulkPercentage;
        private TextBox TxtBulkPercentage;
        private Button BtnBulkUpdate;
        private Button BtnCancel;
        private Button BtnSave;
        private Button BtnPrint;
    }
}