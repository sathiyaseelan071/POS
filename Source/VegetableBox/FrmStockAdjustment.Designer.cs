namespace VegetableBox
{
    partial class FrmStockAdjustment
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
            TxtProductSearch = new TextBox();
            DgvProductSearch = new DataGridView();
            tableLayoutPanel3 = new TableLayoutPanel();
            BtnExit = new Button();
            btnUpdate = new Button();
            btnCancel = new Button();
            label6 = new Label();
            label7 = new Label();
            TxtProductName = new TextBox();
            TxtProductTamilName = new TextBox();
            TxtMrp = new TextBox();
            label2 = new Label();
            TxtSellingRate = new TextBox();
            label4 = new Label();
            label3 = new Label();
            TxtCurrentStockQty = new TextBox();
            label1 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            rdoAddStock = new RadioButton();
            rdoReduceStock = new RadioButton();
            label5 = new Label();
            label8 = new Label();
            cmbAdjustmentReason = new ComboBox();
            LblAdjustment = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            TxtAdjustmentStockQty = new TextBox();
            LblNewStockQty = new Label();
            ErrorProvider = new ErrorProvider(components);
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvProductSearch).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
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
            tableLayoutPanel6.Location = new Point(362, 3);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 3;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 6.521739F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 86.95652F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 6.521739F));
            tableLayoutPanel6.Size = new Size(473, 584);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 41);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(3);
            panel1.Size = new Size(467, 501);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(TxtProductSearch, 2, 3);
            tableLayoutPanel2.Controls.Add(DgvProductSearch, 2, 4);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 2, 11);
            tableLayoutPanel2.Controls.Add(label6, 1, 5);
            tableLayoutPanel2.Controls.Add(label7, 1, 6);
            tableLayoutPanel2.Controls.Add(TxtProductName, 2, 5);
            tableLayoutPanel2.Controls.Add(TxtProductTamilName, 2, 6);
            tableLayoutPanel2.Controls.Add(TxtMrp, 2, 7);
            tableLayoutPanel2.Controls.Add(label2, 1, 8);
            tableLayoutPanel2.Controls.Add(TxtSellingRate, 2, 8);
            tableLayoutPanel2.Controls.Add(label4, 1, 7);
            tableLayoutPanel2.Controls.Add(label3, 1, 9);
            tableLayoutPanel2.Controls.Add(TxtCurrentStockQty, 2, 9);
            tableLayoutPanel2.Controls.Add(label1, 1, 3);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 2, 1);
            tableLayoutPanel2.Controls.Add(label5, 1, 1);
            tableLayoutPanel2.Controls.Add(label8, 1, 2);
            tableLayoutPanel2.Controls.Add(cmbAdjustmentReason, 2, 2);
            tableLayoutPanel2.Controls.Add(LblAdjustment, 1, 10);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel5, 2, 10);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 13;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 1.25044572F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7.58372736F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7.58534431F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7.587444F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 21.63084F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7.587444F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7.587444F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7.587444F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7.587444F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7.587444F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7.5871F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7.587444F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 1.25044572F));
            tableLayoutPanel2.Size = new Size(459, 493);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // TxtProductSearch
            // 
            TxtProductSearch.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtProductSearch.BackColor = Color.WhiteSmoke;
            TxtProductSearch.ForeColor = Color.ForestGreen;
            TxtProductSearch.Location = new Point(187, 85);
            TxtProductSearch.Margin = new Padding(0);
            TxtProductSearch.Name = "TxtProductSearch";
            TxtProductSearch.PlaceholderText = "Search for Product";
            TxtProductSearch.Size = new Size(251, 27);
            TxtProductSearch.TabIndex = 5;
            TxtProductSearch.TextChanged += TxtProductSearch_TextChanged;
            TxtProductSearch.Enter += TextBox_Enter;
            TxtProductSearch.KeyDown += TxtProductSearch_KeyDown;
            TxtProductSearch.Leave += TextBox_Leave;
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
            dataGridViewCellStyle1.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(0, 64, 64);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(244, 244, 244);
            dataGridViewCellStyle1.SelectionForeColor = Color.ForestGreen;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            DgvProductSearch.DefaultCellStyle = dataGridViewCellStyle1;
            DgvProductSearch.Dock = DockStyle.Fill;
            DgvProductSearch.GridColor = Color.White;
            DgvProductSearch.Location = new Point(187, 117);
            DgvProductSearch.Margin = new Padding(0);
            DgvProductSearch.MultiSelect = false;
            DgvProductSearch.Name = "DgvProductSearch";
            DgvProductSearch.ReadOnly = true;
            DgvProductSearch.RowHeadersVisible = false;
            DgvProductSearch.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            DgvProductSearch.Size = new Size(251, 106);
            DgvProductSearch.TabIndex = 6;
            DgvProductSearch.KeyDown += DgvProductSearch_KeyDown;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Controls.Add(BtnExit, 2, 0);
            tableLayoutPanel3.Controls.Add(btnUpdate, 0, 0);
            tableLayoutPanel3.Controls.Add(btnCancel, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(187, 445);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(251, 37);
            tableLayoutPanel3.TabIndex = 19;
            // 
            // BtnExit
            // 
            BtnExit.Dock = DockStyle.Fill;
            BtnExit.ForeColor = Color.Crimson;
            BtnExit.Location = new Point(169, 3);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(79, 31);
            BtnExit.TabIndex = 2;
            BtnExit.Text = "E&xit";
            BtnExit.UseVisualStyleBackColor = true;
            BtnExit.Click += BtnExit_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Dock = DockStyle.Fill;
            btnUpdate.ForeColor = Color.DarkGreen;
            btnUpdate.Location = new Point(3, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(77, 31);
            btnUpdate.TabIndex = 0;
            btnUpdate.Text = "&Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCancel
            // 
            btnCancel.Dock = DockStyle.Fill;
            btnCancel.ForeColor = Color.Crimson;
            btnCancel.Location = new Point(86, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(77, 31);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cance&l";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(23, 232);
            label6.Name = "label6";
            label6.Size = new Size(161, 19);
            label6.TabIndex = 7;
            label6.Text = "Product Name";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(23, 269);
            label7.Name = "label7";
            label7.Size = new Size(161, 19);
            label7.TabIndex = 9;
            label7.Text = "Product Tamil Name";
            // 
            // TxtProductName
            // 
            TxtProductName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtProductName.BackColor = Color.WhiteSmoke;
            TxtProductName.ForeColor = Color.ForestGreen;
            TxtProductName.Location = new Point(187, 228);
            TxtProductName.Margin = new Padding(0);
            TxtProductName.Name = "TxtProductName";
            TxtProductName.Size = new Size(251, 27);
            TxtProductName.TabIndex = 8;
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
            TxtProductTamilName.Location = new Point(187, 265);
            TxtProductTamilName.Margin = new Padding(0);
            TxtProductTamilName.Name = "TxtProductTamilName";
            TxtProductTamilName.Size = new Size(251, 27);
            TxtProductTamilName.TabIndex = 10;
            TxtProductTamilName.TextChanged += TxtProductSearch_TextChanged;
            TxtProductTamilName.Enter += TextBox_Enter;
            TxtProductTamilName.KeyDown += TxtProductSearch_KeyDown;
            TxtProductTamilName.KeyPress += ReadOnlyTextBox_KeyPress;
            TxtProductTamilName.Leave += TextBox_Leave;
            // 
            // TxtMrp
            // 
            TxtMrp.Anchor = AnchorStyles.Left;
            TxtMrp.BackColor = Color.WhiteSmoke;
            TxtMrp.ForeColor = Color.ForestGreen;
            TxtMrp.Location = new Point(190, 302);
            TxtMrp.MaxLength = 10;
            TxtMrp.Name = "TxtMrp";
            TxtMrp.Size = new Size(100, 27);
            TxtMrp.TabIndex = 12;
            TxtMrp.TextAlign = HorizontalAlignment.Center;
            TxtMrp.Enter += TextBox_Enter;
            TxtMrp.KeyPress += ReadOnlyTextBox_KeyPress;
            TxtMrp.Leave += TextBox_Leave;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 64, 64);
            label2.Location = new Point(23, 343);
            label2.Name = "label2";
            label2.Size = new Size(89, 19);
            label2.TabIndex = 13;
            label2.Text = "Selling Rate";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TxtSellingRate
            // 
            TxtSellingRate.Anchor = AnchorStyles.Left;
            TxtSellingRate.BackColor = Color.WhiteSmoke;
            TxtSellingRate.ForeColor = Color.ForestGreen;
            TxtSellingRate.Location = new Point(190, 339);
            TxtSellingRate.MaxLength = 10;
            TxtSellingRate.Name = "TxtSellingRate";
            TxtSellingRate.Size = new Size(100, 27);
            TxtSellingRate.TabIndex = 14;
            TxtSellingRate.TextAlign = HorizontalAlignment.Center;
            TxtSellingRate.Enter += TextBox_Enter;
            TxtSellingRate.KeyPress += ReadOnlyTextBox_KeyPress;
            TxtSellingRate.Leave += TextBox_Leave;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(0, 64, 64);
            label4.Location = new Point(23, 306);
            label4.Name = "label4";
            label4.Size = new Size(41, 19);
            label4.TabIndex = 11;
            label4.Text = "MRP";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 64, 64);
            label3.Location = new Point(23, 380);
            label3.Name = "label3";
            label3.Size = new Size(132, 19);
            label3.TabIndex = 15;
            label3.Text = "Current Stock Qty";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TxtCurrentStockQty
            // 
            TxtCurrentStockQty.Anchor = AnchorStyles.Left;
            TxtCurrentStockQty.BackColor = Color.WhiteSmoke;
            TxtCurrentStockQty.ForeColor = Color.ForestGreen;
            TxtCurrentStockQty.Location = new Point(190, 376);
            TxtCurrentStockQty.MaxLength = 10;
            TxtCurrentStockQty.Name = "TxtCurrentStockQty";
            TxtCurrentStockQty.Size = new Size(100, 27);
            TxtCurrentStockQty.TabIndex = 16;
            TxtCurrentStockQty.TextAlign = HorizontalAlignment.Center;
            TxtCurrentStockQty.Enter += TextBox_Enter;
            TxtCurrentStockQty.KeyPress += ReadOnlyTextBox_KeyPress;
            TxtCurrentStockQty.Leave += TextBox_Leave;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(23, 89);
            label1.Name = "label1";
            label1.Size = new Size(161, 19);
            label1.TabIndex = 4;
            label1.Text = "Product  Search";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(rdoAddStock, 0, 0);
            tableLayoutPanel4.Controls.Add(rdoReduceStock, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(190, 9);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(245, 31);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // rdoAddStock
            // 
            rdoAddStock.Anchor = AnchorStyles.None;
            rdoAddStock.AutoSize = true;
            rdoAddStock.Checked = true;
            rdoAddStock.Location = new Point(13, 4);
            rdoAddStock.Name = "rdoAddStock";
            rdoAddStock.Size = new Size(97, 23);
            rdoAddStock.TabIndex = 0;
            rdoAddStock.TabStop = true;
            rdoAddStock.Text = "Add Stock";
            rdoAddStock.UseVisualStyleBackColor = true;
            rdoAddStock.CheckedChanged += rdoAddStock_CheckedChanged;
            // 
            // rdoReduceStock
            // 
            rdoReduceStock.Anchor = AnchorStyles.None;
            rdoReduceStock.AutoSize = true;
            rdoReduceStock.Location = new Point(126, 4);
            rdoReduceStock.Name = "rdoReduceStock";
            rdoReduceStock.Size = new Size(115, 23);
            rdoReduceStock.TabIndex = 1;
            rdoReduceStock.Text = "Reduce Stock";
            rdoReduceStock.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(23, 15);
            label5.Name = "label5";
            label5.Size = new Size(161, 19);
            label5.TabIndex = 0;
            label5.Text = "Stock Adjustment";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(23, 52);
            label8.Name = "label8";
            label8.Size = new Size(161, 19);
            label8.TabIndex = 2;
            label8.Text = "Adjustment Reason";
            // 
            // cmbAdjustmentReason
            // 
            cmbAdjustmentReason.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbAdjustmentReason.BackColor = SystemColors.Control;
            cmbAdjustmentReason.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAdjustmentReason.FormattingEnabled = true;
            cmbAdjustmentReason.Location = new Point(190, 50);
            cmbAdjustmentReason.Name = "cmbAdjustmentReason";
            cmbAdjustmentReason.Size = new Size(245, 27);
            cmbAdjustmentReason.TabIndex = 3;
            // 
            // LblAdjustment
            // 
            LblAdjustment.Anchor = AnchorStyles.Left;
            LblAdjustment.AutoSize = true;
            LblAdjustment.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblAdjustment.ForeColor = Color.FromArgb(0, 64, 64);
            LblAdjustment.Location = new Point(23, 417);
            LblAdjustment.Name = "LblAdjustment";
            LblAdjustment.Size = new Size(127, 19);
            LblAdjustment.TabIndex = 17;
            LblAdjustment.Text = "Stock to Add Qty";
            LblAdjustment.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel5.Controls.Add(TxtAdjustmentStockQty, 0, 0);
            tableLayoutPanel5.Controls.Add(LblNewStockQty, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(187, 408);
            tableLayoutPanel5.Margin = new Padding(0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(251, 37);
            tableLayoutPanel5.TabIndex = 18;
            // 
            // TxtAdjustmentStockQty
            // 
            TxtAdjustmentStockQty.Anchor = AnchorStyles.Left;
            TxtAdjustmentStockQty.BackColor = Color.WhiteSmoke;
            TxtAdjustmentStockQty.ForeColor = Color.ForestGreen;
            TxtAdjustmentStockQty.Location = new Point(3, 5);
            TxtAdjustmentStockQty.MaxLength = 3;
            TxtAdjustmentStockQty.Name = "TxtAdjustmentStockQty";
            TxtAdjustmentStockQty.Size = new Size(94, 27);
            TxtAdjustmentStockQty.TabIndex = 0;
            TxtAdjustmentStockQty.TextAlign = HorizontalAlignment.Center;
            TxtAdjustmentStockQty.TextChanged += TxtAdjustmentStockQty_TextChanged;
            TxtAdjustmentStockQty.Enter += TextBox_Enter;
            TxtAdjustmentStockQty.KeyPress += Decimal_KeyPress;
            TxtAdjustmentStockQty.Leave += TextBox_Leave;
            // 
            // LblNewStockQty
            // 
            LblNewStockQty.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblNewStockQty.AutoSize = true;
            LblNewStockQty.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblNewStockQty.ForeColor = Color.Purple;
            LblNewStockQty.Location = new Point(103, 9);
            LblNewStockQty.Name = "LblNewStockQty";
            LblNewStockQty.Size = new Size(145, 18);
            LblNewStockQty.TabIndex = 1;
            LblNewStockQty.Text = "New Stock Qty : ";
            // 
            // ErrorProvider
            // 
            ErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            ErrorProvider.ContainerControl = this;
            // 
            // FrmStockAdjustment
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1199, 590);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(0, 64, 64);
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmStockAdjustment";
            Text = "Stock Adjustment";
            Load += FrmStockAdjustment_Load;
            KeyDown += FrmStockAdjustment_KeyDown;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvProductSearch).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ErrorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Label label4;
        private TextBox TxtProductSearch;
        private DataGridView DgvProductSearch;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel6;
        private ErrorProvider ErrorProvider;
        private Label label6;
        private Label label7;
        private TextBox TxtProductName;
        private TextBox TxtProductTamilName;
        private TableLayoutPanel tableLayoutPanel3;
        private Button BtnExit;
        private Button btnUpdate;
        private TextBox TxtMrp;
        private Label label2;
        private TextBox TxtSellingRate;
        private Button btnCancel;
        private Label label3;
        private TextBox TxtCurrentStockQty;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel4;
        private RadioButton rdoAddStock;
        private RadioButton rdoReduceStock;
        private Label label8;
        private ComboBox cmbAdjustmentReason;
        private Label LblAdjustment;
        private TextBox TxtAdjustmentStockQty;
        private TableLayoutPanel tableLayoutPanel5;
        private Label LblNewStockQty;
    }
}