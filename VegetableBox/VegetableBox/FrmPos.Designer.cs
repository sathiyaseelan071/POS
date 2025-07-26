namespace VegetableBox
{
    partial class FrmPos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPos));
            tableLayoutPanel1 = new TableLayoutPanel();
            DGVCart = new DataGridView();
            TlpProductDetails = new TableLayoutPanel();
            label1 = new Label();
            TxtProductSearch = new TextBox();
            DgvProductSearch = new DataGridView();
            pnlCartEntry = new Panel();
            tlpProDetails = new TableLayoutPanel();
            tableLayoutPanel7 = new TableLayoutPanel();
            BtnAddCart = new Button();
            BtnCancel = new Button();
            LblMrp = new Label();
            TxtMrp = new TextBox();
            TxtTotAmt = new TextBox();
            LblTotAmt = new Label();
            LblDiscFromMRP = new Label();
            LblPurchaseAmt = new Label();
            TxtDiscFromMRP = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            LblQty = new Label();
            LblUnit = new Label();
            TxtQty = new TextBox();
            TxtDiscAmt = new TextBox();
            LblDiscAmt = new Label();
            TxtDiscPercentage = new TextBox();
            LblDiscPercentage = new Label();
            LblRate = new Label();
            TxtRate = new TextBox();
            LblAmt = new Label();
            TxtAmt = new TextBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            TxtProTName = new TextBox();
            LblProTName = new Label();
            TxtProName = new TextBox();
            LblProCode = new Label();
            TxtProCode = new TextBox();
            LblProName = new Label();
            TLP_RateBasedWt = new TableLayoutPanel();
            TxtRBWRate = new TextBox();
            TxtRBWWeight = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label7 = new Label();
            panel1 = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            LblFinalTotAmtDisp = new Label();
            label5 = new Label();
            label6 = new Label();
            LblFinalAmtReceived = new Label();
            LblFinalAmtReceivedDisp = new Label();
            LblFinalGrossAmtDisp = new Label();
            label4 = new Label();
            LblFinalNetAmtDisp = new Label();
            LblFinalBalanceAmountDisp = new Label();
            BtnSave = new Button();
            LblFinalBalanceAmount = new Label();
            LblFinalNetAmt = new Label();
            LblFinalTotAmt = new Label();
            LblFinalGrossAmt = new Label();
            LblFinalRoundOffAmt = new Label();
            TxtFinalDiscPer = new TextBox();
            TxtFinalDiscAmt = new TextBox();
            groupBox1 = new GroupBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            TxtPaymentDetCash = new TextBox();
            TxtPaymentDetUpi = new TextBox();
            TxtPaymentDetCard = new TextBox();
            tableLayoutPanel6 = new TableLayoutPanel();
            BtnCancelAll = new Button();
            BtnExit = new Button();
            label19 = new Label();
            ErrorProvider = new ErrorProvider(components);
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVCart).BeginInit();
            TlpProductDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvProductSearch).BeginInit();
            pnlCartEntry.SuspendLayout();
            tlpProDetails.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            TLP_RateBasedWt.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 56.72269F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.3193283F));
            tableLayoutPanel1.Controls.Add(DGVCart, 0, 1);
            tableLayoutPanel1.Controls.Add(TlpProductDetails, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 2, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel6, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 72.3122253F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.80559635F));
            tableLayoutPanel1.Size = new Size(1370, 679);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // DGVCart
            // 
            DGVCart.AllowUserToAddRows = false;
            DGVCart.AllowUserToDeleteRows = false;
            DGVCart.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.IndianRed;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.SelectionForeColor = Color.IndianRed;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DGVCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DGVCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel1.SetColumnSpan(DGVCart, 2);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.DarkSlateGray;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.SelectionForeColor = Color.ForestGreen;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DGVCart.DefaultCellStyle = dataGridViewCellStyle2;
            DGVCart.Dock = DockStyle.Fill;
            DGVCart.Location = new Point(4, 140);
            DGVCart.Margin = new Padding(4, 5, 4, 5);
            DGVCart.MultiSelect = false;
            DGVCart.Name = "DGVCart";
            DGVCart.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Maroon;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            DGVCart.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            DGVCart.RowHeadersVisible = false;
            DGVCart.RowTemplate.Height = 25;
            DGVCart.Size = new Size(1041, 480);
            DGVCart.TabIndex = 1;
            DGVCart.CellClick += DGVCart_CellClick;
            DGVCart.CellDoubleClick += DGVCart_CellDoubleClick;
            DGVCart.CellEnter += DGVCart_CellEnter;
            DGVCart.DataBindingComplete += DGVCart_DataBindingComplete;
            // 
            // TlpProductDetails
            // 
            TlpProductDetails.ColumnCount = 4;
            tableLayoutPanel1.SetColumnSpan(TlpProductDetails, 3);
            TlpProductDetails.ColumnStyles.Add(new ColumnStyle());
            TlpProductDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.3070869F));
            TlpProductDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.4251976F));
            TlpProductDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.154604F));
            TlpProductDetails.Controls.Add(label1, 0, 0);
            TlpProductDetails.Controls.Add(TxtProductSearch, 1, 0);
            TlpProductDetails.Controls.Add(DgvProductSearch, 1, 1);
            TlpProductDetails.Controls.Add(pnlCartEntry, 2, 0);
            TlpProductDetails.Controls.Add(TLP_RateBasedWt, 0, 1);
            TlpProductDetails.Dock = DockStyle.Fill;
            TlpProductDetails.Location = new Point(4, 4);
            TlpProductDetails.Margin = new Padding(4);
            TlpProductDetails.Name = "TlpProductDetails";
            TlpProductDetails.RowCount = 2;
            TlpProductDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 24.8322144F));
            TlpProductDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 75.1677856F));
            TlpProductDetails.Size = new Size(1362, 127);
            TlpProductDetails.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 64, 64);
            label1.Location = new Point(4, 6);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(103, 18);
            label1.TabIndex = 0;
            label1.Text = "Product  Search";
            // 
            // TxtProductSearch
            // 
            TxtProductSearch.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtProductSearch.BackColor = Color.WhiteSmoke;
            TxtProductSearch.ForeColor = Color.ForestGreen;
            TxtProductSearch.Location = new Point(111, 0);
            TxtProductSearch.Margin = new Padding(0);
            TxtProductSearch.Name = "TxtProductSearch";
            TxtProductSearch.PlaceholderText = "Search for Product";
            TxtProductSearch.Size = new Size(291, 31);
            TxtProductSearch.TabIndex = 2;
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
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(244, 244, 244);
            dataGridViewCellStyle4.SelectionForeColor = Color.ForestGreen;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            DgvProductSearch.DefaultCellStyle = dataGridViewCellStyle4;
            DgvProductSearch.Dock = DockStyle.Fill;
            DgvProductSearch.GridColor = Color.White;
            DgvProductSearch.Location = new Point(111, 31);
            DgvProductSearch.Margin = new Padding(0);
            DgvProductSearch.MultiSelect = false;
            DgvProductSearch.Name = "DgvProductSearch";
            DgvProductSearch.ReadOnly = true;
            DgvProductSearch.RowHeadersVisible = false;
            DgvProductSearch.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            DgvProductSearch.Size = new Size(291, 96);
            DgvProductSearch.TabIndex = 3;
            DgvProductSearch.KeyDown += DgvProductSearch_KeyDown;
            // 
            // pnlCartEntry
            // 
            pnlCartEntry.BorderStyle = BorderStyle.FixedSingle;
            TlpProductDetails.SetColumnSpan(pnlCartEntry, 2);
            pnlCartEntry.Controls.Add(tlpProDetails);
            pnlCartEntry.Dock = DockStyle.Fill;
            pnlCartEntry.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            pnlCartEntry.Location = new Point(405, 0);
            pnlCartEntry.Margin = new Padding(3, 0, 3, 0);
            pnlCartEntry.Name = "pnlCartEntry";
            TlpProductDetails.SetRowSpan(pnlCartEntry, 2);
            pnlCartEntry.Size = new Size(954, 127);
            pnlCartEntry.TabIndex = 3;
            // 
            // tlpProDetails
            // 
            tlpProDetails.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tlpProDetails.ColumnCount = 1;
            tlpProDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpProDetails.Controls.Add(tableLayoutPanel7, 0, 2);
            tlpProDetails.Controls.Add(tableLayoutPanel2, 0, 1);
            tlpProDetails.Controls.Add(tableLayoutPanel3, 0, 0);
            tlpProDetails.Dock = DockStyle.Fill;
            tlpProDetails.Location = new Point(0, 0);
            tlpProDetails.Margin = new Padding(0);
            tlpProDetails.Name = "tlpProDetails";
            tlpProDetails.RowCount = 3;
            tlpProDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tlpProDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tlpProDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tlpProDetails.Size = new Size(952, 125);
            tlpProDetails.TabIndex = 0;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 11;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.505702F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.505702F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4.942965F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.505702F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.505702F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.505702F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.505702F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.505702F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.505702F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.505702F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.505702F));
            tableLayoutPanel7.Controls.Add(BtnAddCart, 9, 0);
            tableLayoutPanel7.Controls.Add(BtnCancel, 10, 0);
            tableLayoutPanel7.Controls.Add(LblMrp, 0, 0);
            tableLayoutPanel7.Controls.Add(TxtMrp, 1, 0);
            tableLayoutPanel7.Controls.Add(TxtTotAmt, 4, 0);
            tableLayoutPanel7.Controls.Add(LblTotAmt, 3, 0);
            tableLayoutPanel7.Controls.Add(LblDiscFromMRP, 5, 0);
            tableLayoutPanel7.Controls.Add(LblPurchaseAmt, 8, 0);
            tableLayoutPanel7.Controls.Add(TxtDiscFromMRP, 7, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(1, 83);
            tableLayoutPanel7.Margin = new Padding(0);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel7.Size = new Size(950, 41);
            tableLayoutPanel7.TabIndex = 2;
            // 
            // BtnAddCart
            // 
            BtnAddCart.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            BtnAddCart.ForeColor = Color.DarkGreen;
            BtnAddCart.Location = new Point(769, 4);
            BtnAddCart.Name = "BtnAddCart";
            BtnAddCart.Size = new Size(84, 32);
            BtnAddCart.TabIndex = 7;
            BtnAddCart.Text = "&Add Cart";
            BtnAddCart.UseVisualStyleBackColor = true;
            BtnAddCart.Click += BtnAddCart_Click;
            // 
            // BtnCancel
            // 
            BtnCancel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            BtnCancel.ForeColor = Color.Crimson;
            BtnCancel.Location = new Point(859, 4);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(88, 32);
            BtnCancel.TabIndex = 8;
            BtnCancel.Text = "&Cancel";
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // LblMrp
            // 
            LblMrp.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblMrp.AutoSize = true;
            LblMrp.ForeColor = Color.FromArgb(0, 64, 64);
            LblMrp.Location = new Point(3, 11);
            LblMrp.Name = "LblMrp";
            LblMrp.Size = new Size(84, 19);
            LblMrp.TabIndex = 0;
            LblMrp.Text = "MRP";
            LblMrp.TextAlign = ContentAlignment.TopRight;
            // 
            // TxtMrp
            // 
            TxtMrp.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtMrp.BackColor = Color.WhiteSmoke;
            TxtMrp.ForeColor = Color.ForestGreen;
            TxtMrp.Location = new Point(93, 7);
            TxtMrp.MaxLength = 12;
            TxtMrp.Name = "TxtMrp";
            TxtMrp.Size = new Size(84, 27);
            TxtMrp.TabIndex = 1;
            TxtMrp.TextAlign = HorizontalAlignment.Right;
            TxtMrp.TextChanged += TxtAmt_TextChanged;
            TxtMrp.Enter += TextBox_Enter;
            TxtMrp.KeyPress += ReadOnlyTextBox_KeyPress;
            TxtMrp.Leave += TextBox_Leave;
            // 
            // TxtTotAmt
            // 
            TxtTotAmt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtTotAmt.BackColor = Color.WhiteSmoke;
            TxtTotAmt.ForeColor = Color.ForestGreen;
            TxtTotAmt.Location = new Point(319, 7);
            TxtTotAmt.MaxLength = 12;
            TxtTotAmt.Name = "TxtTotAmt";
            TxtTotAmt.Size = new Size(84, 27);
            TxtTotAmt.TabIndex = 3;
            TxtTotAmt.TextAlign = HorizontalAlignment.Right;
            TxtTotAmt.Enter += TextBox_Enter;
            TxtTotAmt.KeyPress += ReadOnlyTextBox_KeyPress;
            TxtTotAmt.Leave += TextBox_Leave;
            // 
            // LblTotAmt
            // 
            LblTotAmt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblTotAmt.AutoSize = true;
            LblTotAmt.ForeColor = Color.FromArgb(0, 64, 64);
            LblTotAmt.Location = new Point(229, 11);
            LblTotAmt.Name = "LblTotAmt";
            LblTotAmt.Size = new Size(84, 19);
            LblTotAmt.TabIndex = 2;
            LblTotAmt.Text = "Total Amt";
            LblTotAmt.TextAlign = ContentAlignment.TopRight;
            // 
            // LblDiscFromMRP
            // 
            LblDiscFromMRP.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblDiscFromMRP.AutoSize = true;
            tableLayoutPanel7.SetColumnSpan(LblDiscFromMRP, 2);
            LblDiscFromMRP.ForeColor = Color.FromArgb(0, 64, 64);
            LblDiscFromMRP.Location = new Point(409, 11);
            LblDiscFromMRP.Margin = new Padding(3, 0, 1, 0);
            LblDiscFromMRP.Name = "LblDiscFromMRP";
            LblDiscFromMRP.Size = new Size(176, 19);
            LblDiscFromMRP.TabIndex = 4;
            LblDiscFromMRP.Text = "Tot Disc Amt From MRP";
            LblDiscFromMRP.TextAlign = ContentAlignment.TopRight;
            // 
            // LblPurchaseAmt
            // 
            LblPurchaseAmt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblPurchaseAmt.AutoSize = true;
            LblPurchaseAmt.ForeColor = Color.Green;
            LblPurchaseAmt.Location = new Point(679, 11);
            LblPurchaseAmt.Name = "LblPurchaseAmt";
            LblPurchaseAmt.Size = new Size(84, 19);
            LblPurchaseAmt.TabIndex = 6;
            LblPurchaseAmt.Text = "...";
            LblPurchaseAmt.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtDiscFromMRP
            // 
            TxtDiscFromMRP.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtDiscFromMRP.BackColor = Color.WhiteSmoke;
            TxtDiscFromMRP.ForeColor = Color.ForestGreen;
            TxtDiscFromMRP.Location = new Point(589, 7);
            TxtDiscFromMRP.MaxLength = 12;
            TxtDiscFromMRP.Name = "TxtDiscFromMRP";
            TxtDiscFromMRP.Size = new Size(84, 27);
            TxtDiscFromMRP.TabIndex = 5;
            TxtDiscFromMRP.TextAlign = HorizontalAlignment.Right;
            TxtDiscFromMRP.Enter += TextBox_Enter;
            TxtDiscFromMRP.KeyPress += ReadOnlyTextBox_KeyPress;
            TxtDiscFromMRP.Leave += TextBox_Leave;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 11;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.505702F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.505702F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4.942965F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.505702F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.505702F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.505702F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.505702F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.505702F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.505702F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.505702F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.505702F));
            tableLayoutPanel2.Controls.Add(LblQty, 0, 0);
            tableLayoutPanel2.Controls.Add(LblUnit, 2, 0);
            tableLayoutPanel2.Controls.Add(TxtQty, 1, 0);
            tableLayoutPanel2.Controls.Add(TxtDiscAmt, 10, 0);
            tableLayoutPanel2.Controls.Add(LblDiscAmt, 9, 0);
            tableLayoutPanel2.Controls.Add(TxtDiscPercentage, 8, 0);
            tableLayoutPanel2.Controls.Add(LblDiscPercentage, 7, 0);
            tableLayoutPanel2.Controls.Add(LblRate, 3, 0);
            tableLayoutPanel2.Controls.Add(TxtRate, 4, 0);
            tableLayoutPanel2.Controls.Add(LblAmt, 5, 0);
            tableLayoutPanel2.Controls.Add(TxtAmt, 6, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(1, 42);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(950, 40);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // LblQty
            // 
            LblQty.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblQty.AutoSize = true;
            LblQty.ForeColor = Color.FromArgb(0, 64, 64);
            LblQty.Location = new Point(3, 10);
            LblQty.Name = "LblQty";
            LblQty.Size = new Size(84, 19);
            LblQty.TabIndex = 0;
            LblQty.Text = "Qty*";
            LblQty.TextAlign = ContentAlignment.TopRight;
            // 
            // LblUnit
            // 
            LblUnit.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblUnit.AutoSize = true;
            LblUnit.ForeColor = Color.ForestGreen;
            LblUnit.Location = new Point(180, 10);
            LblUnit.Margin = new Padding(0, 0, 5, 0);
            LblUnit.Name = "LblUnit";
            LblUnit.Size = new Size(41, 19);
            LblUnit.TabIndex = 2;
            LblUnit.Text = "...";
            // 
            // TxtQty
            // 
            TxtQty.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtQty.BackColor = Color.WhiteSmoke;
            TxtQty.ForeColor = Color.ForestGreen;
            TxtQty.Location = new Point(93, 6);
            TxtQty.Margin = new Padding(3, 3, 0, 3);
            TxtQty.MaxLength = 10;
            TxtQty.Name = "TxtQty";
            TxtQty.Size = new Size(87, 27);
            TxtQty.TabIndex = 1;
            TxtQty.TextAlign = HorizontalAlignment.Right;
            TxtQty.TextChanged += TxtQty_TextChanged;
            TxtQty.Enter += TextBox_Enter;
            TxtQty.KeyDown += TxtQty_KeyDown;
            TxtQty.KeyPress += Decimal_KeyPress;
            TxtQty.Leave += TextBox_Leave;
            // 
            // TxtDiscAmt
            // 
            TxtDiscAmt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtDiscAmt.BackColor = Color.WhiteSmoke;
            TxtDiscAmt.ForeColor = Color.ForestGreen;
            TxtDiscAmt.Location = new Point(859, 6);
            TxtDiscAmt.MaxLength = 10;
            TxtDiscAmt.Name = "TxtDiscAmt";
            TxtDiscAmt.Size = new Size(88, 27);
            TxtDiscAmt.TabIndex = 10;
            TxtDiscAmt.TextAlign = HorizontalAlignment.Right;
            TxtDiscAmt.Enter += TextBox_Enter;
            TxtDiscAmt.KeyPress += ReadOnlyTextBox_KeyPress;
            TxtDiscAmt.Leave += TextBox_Leave;
            // 
            // LblDiscAmt
            // 
            LblDiscAmt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblDiscAmt.AutoSize = true;
            LblDiscAmt.ForeColor = Color.FromArgb(0, 64, 64);
            LblDiscAmt.Location = new Point(769, 10);
            LblDiscAmt.Name = "LblDiscAmt";
            LblDiscAmt.Size = new Size(84, 19);
            LblDiscAmt.TabIndex = 9;
            LblDiscAmt.Text = "Disc Amt";
            LblDiscAmt.TextAlign = ContentAlignment.TopRight;
            // 
            // TxtDiscPercentage
            // 
            TxtDiscPercentage.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtDiscPercentage.BackColor = Color.WhiteSmoke;
            TxtDiscPercentage.ForeColor = Color.ForestGreen;
            TxtDiscPercentage.Location = new Point(679, 6);
            TxtDiscPercentage.MaxLength = 3;
            TxtDiscPercentage.Name = "TxtDiscPercentage";
            TxtDiscPercentage.Size = new Size(84, 27);
            TxtDiscPercentage.TabIndex = 8;
            TxtDiscPercentage.TextAlign = HorizontalAlignment.Right;
            TxtDiscPercentage.TextChanged += TxtDiscPercentage_TextChanged;
            TxtDiscPercentage.Enter += TextBox_Enter;
            TxtDiscPercentage.KeyPress += ReadOnlyTextBox_KeyPress;
            TxtDiscPercentage.Leave += TextBox_Leave;
            TxtDiscPercentage.Validated += TxtDiscPercentage_Validated;
            // 
            // LblDiscPercentage
            // 
            LblDiscPercentage.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblDiscPercentage.AutoSize = true;
            LblDiscPercentage.ForeColor = Color.FromArgb(0, 64, 64);
            LblDiscPercentage.Location = new Point(589, 10);
            LblDiscPercentage.Name = "LblDiscPercentage";
            LblDiscPercentage.Size = new Size(84, 19);
            LblDiscPercentage.TabIndex = 7;
            LblDiscPercentage.Text = "Disc %*";
            LblDiscPercentage.TextAlign = ContentAlignment.TopRight;
            // 
            // LblRate
            // 
            LblRate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblRate.AutoSize = true;
            LblRate.ForeColor = Color.FromArgb(0, 64, 64);
            LblRate.Location = new Point(229, 10);
            LblRate.Name = "LblRate";
            LblRate.Size = new Size(84, 19);
            LblRate.TabIndex = 3;
            LblRate.Text = "Sell Rate*";
            LblRate.TextAlign = ContentAlignment.TopRight;
            // 
            // TxtRate
            // 
            TxtRate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtRate.BackColor = Color.WhiteSmoke;
            TxtRate.ForeColor = Color.ForestGreen;
            TxtRate.Location = new Point(319, 6);
            TxtRate.MaxLength = 10;
            TxtRate.Name = "TxtRate";
            TxtRate.Size = new Size(84, 27);
            TxtRate.TabIndex = 4;
            TxtRate.TextAlign = HorizontalAlignment.Right;
            TxtRate.TextChanged += TxtRate_TextChanged;
            TxtRate.Enter += TextBox_Enter;
            TxtRate.KeyDown += TxtRate_KeyDown;
            TxtRate.KeyPress += Decimal_KeyPress;
            TxtRate.Leave += TextBox_Leave;
            TxtRate.Validated += TxtRate_Validated;
            // 
            // LblAmt
            // 
            LblAmt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblAmt.AutoSize = true;
            LblAmt.ForeColor = Color.FromArgb(0, 64, 64);
            LblAmt.Location = new Point(409, 10);
            LblAmt.Name = "LblAmt";
            LblAmt.Size = new Size(84, 19);
            LblAmt.TabIndex = 5;
            LblAmt.Text = "Amount";
            LblAmt.TextAlign = ContentAlignment.TopRight;
            // 
            // TxtAmt
            // 
            TxtAmt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtAmt.BackColor = Color.WhiteSmoke;
            TxtAmt.ForeColor = Color.ForestGreen;
            TxtAmt.Location = new Point(499, 6);
            TxtAmt.MaxLength = 12;
            TxtAmt.Name = "TxtAmt";
            TxtAmt.Size = new Size(84, 27);
            TxtAmt.TabIndex = 6;
            TxtAmt.TextAlign = HorizontalAlignment.Right;
            TxtAmt.TextChanged += TxtAmt_TextChanged;
            TxtAmt.Enter += TextBox_Enter;
            TxtAmt.KeyPress += ReadOnlyTextBox_KeyPress;
            TxtAmt.Leave += TextBox_Leave;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 6;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(TxtProTName, 5, 0);
            tableLayoutPanel3.Controls.Add(LblProTName, 4, 0);
            tableLayoutPanel3.Controls.Add(TxtProName, 3, 0);
            tableLayoutPanel3.Controls.Add(LblProCode, 0, 0);
            tableLayoutPanel3.Controls.Add(TxtProCode, 1, 0);
            tableLayoutPanel3.Controls.Add(LblProName, 2, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(1, 1);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(950, 40);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // TxtProTName
            // 
            TxtProTName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtProTName.BackColor = Color.WhiteSmoke;
            TxtProTName.ForeColor = Color.ForestGreen;
            TxtProTName.Location = new Point(662, 6);
            TxtProTName.Margin = new Padding(3, 3, 8, 3);
            TxtProTName.Name = "TxtProTName";
            TxtProTName.Size = new Size(280, 27);
            TxtProTName.TabIndex = 5;
            TxtProTName.TextAlign = HorizontalAlignment.Center;
            TxtProTName.Enter += TextBox_Enter;
            TxtProTName.KeyPress += ReadOnlyTextBox_KeyPress;
            TxtProTName.Leave += TextBox_Leave;
            // 
            // LblProTName
            // 
            LblProTName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblProTName.AutoSize = true;
            LblProTName.ForeColor = Color.FromArgb(0, 64, 64);
            LblProTName.Location = new Point(539, 10);
            LblProTName.Name = "LblProTName";
            LblProTName.Size = new Size(117, 19);
            LblProTName.TabIndex = 4;
            LblProTName.Text = "Pro Tamil Name";
            // 
            // TxtProName
            // 
            TxtProName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtProName.BackColor = Color.WhiteSmoke;
            TxtProName.ForeColor = Color.ForestGreen;
            TxtProName.Location = new Point(249, 6);
            TxtProName.Name = "TxtProName";
            TxtProName.Size = new Size(284, 27);
            TxtProName.TabIndex = 3;
            TxtProName.TextAlign = HorizontalAlignment.Center;
            TxtProName.Enter += TextBox_Enter;
            TxtProName.KeyPress += ReadOnlyTextBox_KeyPress;
            TxtProName.Leave += TextBox_Leave;
            // 
            // LblProCode
            // 
            LblProCode.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblProCode.AutoSize = true;
            LblProCode.ForeColor = Color.FromArgb(0, 64, 64);
            LblProCode.Location = new Point(3, 10);
            LblProCode.Name = "LblProCode";
            LblProCode.Size = new Size(71, 19);
            LblProCode.TabIndex = 0;
            LblProCode.Text = "Pro Code";
            // 
            // TxtProCode
            // 
            TxtProCode.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtProCode.BackColor = Color.WhiteSmoke;
            TxtProCode.ForeColor = Color.ForestGreen;
            TxtProCode.Location = new Point(80, 6);
            TxtProCode.Name = "TxtProCode";
            TxtProCode.Size = new Size(80, 27);
            TxtProCode.TabIndex = 1;
            TxtProCode.TextAlign = HorizontalAlignment.Center;
            TxtProCode.Enter += TextBox_Enter;
            TxtProCode.KeyPress += ReadOnlyTextBox_KeyPress;
            TxtProCode.Leave += TextBox_Leave;
            // 
            // LblProName
            // 
            LblProName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblProName.AutoSize = true;
            LblProName.ForeColor = Color.FromArgb(0, 64, 64);
            LblProName.Location = new Point(166, 10);
            LblProName.Name = "LblProName";
            LblProName.Size = new Size(77, 19);
            LblProName.TabIndex = 2;
            LblProName.Text = "Pro Name";
            // 
            // TLP_RateBasedWt
            // 
            TLP_RateBasedWt.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            TLP_RateBasedWt.ColumnCount = 2;
            TLP_RateBasedWt.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TLP_RateBasedWt.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TLP_RateBasedWt.Controls.Add(TxtRBWRate, 1, 1);
            TLP_RateBasedWt.Controls.Add(TxtRBWWeight, 1, 2);
            TLP_RateBasedWt.Controls.Add(label2, 0, 0);
            TLP_RateBasedWt.Controls.Add(label3, 0, 1);
            TLP_RateBasedWt.Controls.Add(label7, 0, 2);
            TLP_RateBasedWt.Dock = DockStyle.Fill;
            TLP_RateBasedWt.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            TLP_RateBasedWt.Location = new Point(0, 31);
            TLP_RateBasedWt.Margin = new Padding(0);
            TLP_RateBasedWt.Name = "TLP_RateBasedWt";
            TLP_RateBasedWt.RowCount = 3;
            TLP_RateBasedWt.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            TLP_RateBasedWt.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            TLP_RateBasedWt.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            TLP_RateBasedWt.Size = new Size(111, 96);
            TLP_RateBasedWt.TabIndex = 1;
            // 
            // TxtRBWRate
            // 
            TxtRBWRate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtRBWRate.Location = new Point(59, 35);
            TxtRBWRate.Name = "TxtRBWRate";
            TxtRBWRate.Size = new Size(48, 23);
            TxtRBWRate.TabIndex = 2;
            TxtRBWRate.TextAlign = HorizontalAlignment.Right;
            TxtRBWRate.TextChanged += TxtRBWRate_TextChanged;
            TxtRBWRate.KeyPress += Decimal_KeyPress;
            // 
            // TxtRBWWeight
            // 
            TxtRBWWeight.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtRBWWeight.Location = new Point(59, 67);
            TxtRBWWeight.Name = "TxtRBWWeight";
            TxtRBWWeight.Size = new Size(48, 23);
            TxtRBWWeight.TabIndex = 4;
            TxtRBWWeight.TextAlign = HorizontalAlignment.Right;
            TxtRBWWeight.KeyPress += Decimal_KeyPress;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            TLP_RateBasedWt.SetColumnSpan(label2, 2);
            label2.ForeColor = Color.ForestGreen;
            label2.Location = new Point(4, 8);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 0;
            label2.Text = "Rate Based Wt";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.ForeColor = Color.Green;
            label3.Location = new Point(4, 39);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 1;
            label3.Text = "Rate";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.ForeColor = Color.Green;
            label7.Location = new Point(4, 71);
            label7.Name = "label7";
            label7.Size = new Size(48, 15);
            label7.TabIndex = 3;
            label7.Text = "Wt";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(tableLayoutPanel4);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(1052, 140);
            panel1.Margin = new Padding(3, 5, 3, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(315, 480);
            panel1.TabIndex = 3;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 5;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.978056F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.2246604F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 88.81923F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.97805667F));
            tableLayoutPanel4.Controls.Add(LblFinalTotAmtDisp, 1, 0);
            tableLayoutPanel4.Controls.Add(label5, 1, 1);
            tableLayoutPanel4.Controls.Add(label6, 1, 2);
            tableLayoutPanel4.Controls.Add(LblFinalAmtReceived, 3, 7);
            tableLayoutPanel4.Controls.Add(LblFinalAmtReceivedDisp, 1, 7);
            tableLayoutPanel4.Controls.Add(LblFinalGrossAmtDisp, 1, 3);
            tableLayoutPanel4.Controls.Add(label4, 1, 4);
            tableLayoutPanel4.Controls.Add(LblFinalNetAmtDisp, 1, 5);
            tableLayoutPanel4.Controls.Add(LblFinalBalanceAmountDisp, 1, 8);
            tableLayoutPanel4.Controls.Add(BtnSave, 1, 9);
            tableLayoutPanel4.Controls.Add(LblFinalBalanceAmount, 3, 8);
            tableLayoutPanel4.Controls.Add(LblFinalNetAmt, 3, 5);
            tableLayoutPanel4.Controls.Add(LblFinalTotAmt, 3, 0);
            tableLayoutPanel4.Controls.Add(LblFinalGrossAmt, 3, 3);
            tableLayoutPanel4.Controls.Add(LblFinalRoundOffAmt, 3, 4);
            tableLayoutPanel4.Controls.Add(TxtFinalDiscPer, 3, 1);
            tableLayoutPanel4.Controls.Add(TxtFinalDiscAmt, 3, 2);
            tableLayoutPanel4.Controls.Add(groupBox1, 1, 6);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 10;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 7.18580627F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 7.18580627F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 7.18580627F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 7.18580627F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 7.18580627F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 9.752166F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 28.9923439F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 8.368201F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 5.02092028F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 11.7400675F));
            tableLayoutPanel4.Size = new Size(313, 478);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // LblFinalTotAmtDisp
            // 
            LblFinalTotAmtDisp.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblFinalTotAmtDisp.AutoSize = true;
            LblFinalTotAmtDisp.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblFinalTotAmtDisp.ForeColor = Color.FromArgb(0, 64, 64);
            LblFinalTotAmtDisp.Location = new Point(8, 7);
            LblFinalTotAmtDisp.Name = "LblFinalTotAmtDisp";
            LblFinalTotAmtDisp.Size = new Size(130, 19);
            LblFinalTotAmtDisp.TabIndex = 0;
            LblFinalTotAmtDisp.Text = "Total Amount";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(0, 64, 64);
            label5.Location = new Point(8, 41);
            label5.Name = "label5";
            label5.Size = new Size(130, 19);
            label5.TabIndex = 2;
            label5.Text = "Discount %";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(0, 64, 64);
            label6.Location = new Point(8, 75);
            label6.Name = "label6";
            label6.Size = new Size(130, 19);
            label6.TabIndex = 4;
            label6.Text = "Discount";
            // 
            // LblFinalAmtReceived
            // 
            LblFinalAmtReceived.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblFinalAmtReceived.AutoSize = true;
            LblFinalAmtReceived.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblFinalAmtReceived.ForeColor = Color.Crimson;
            LblFinalAmtReceived.Location = new Point(153, 362);
            LblFinalAmtReceived.Name = "LblFinalAmtReceived";
            LblFinalAmtReceived.Size = new Size(151, 23);
            LblFinalAmtReceived.TabIndex = 14;
            LblFinalAmtReceived.Text = "0.00";
            LblFinalAmtReceived.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LblFinalAmtReceivedDisp
            // 
            LblFinalAmtReceivedDisp.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblFinalAmtReceivedDisp.AutoSize = true;
            LblFinalAmtReceivedDisp.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblFinalAmtReceivedDisp.ForeColor = Color.FromArgb(0, 64, 64);
            LblFinalAmtReceivedDisp.Location = new Point(8, 364);
            LblFinalAmtReceivedDisp.Name = "LblFinalAmtReceivedDisp";
            LblFinalAmtReceivedDisp.Size = new Size(130, 19);
            LblFinalAmtReceivedDisp.TabIndex = 13;
            LblFinalAmtReceivedDisp.Text = "Amount Received";
            // 
            // LblFinalGrossAmtDisp
            // 
            LblFinalGrossAmtDisp.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblFinalGrossAmtDisp.AutoSize = true;
            LblFinalGrossAmtDisp.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblFinalGrossAmtDisp.ForeColor = Color.FromArgb(0, 64, 64);
            LblFinalGrossAmtDisp.Location = new Point(8, 109);
            LblFinalGrossAmtDisp.Name = "LblFinalGrossAmtDisp";
            LblFinalGrossAmtDisp.Size = new Size(130, 19);
            LblFinalGrossAmtDisp.TabIndex = 6;
            LblFinalGrossAmtDisp.Text = "Gross Amount";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(0, 64, 64);
            label4.Location = new Point(8, 143);
            label4.Name = "label4";
            label4.Size = new Size(130, 19);
            label4.TabIndex = 8;
            label4.Text = "Round Off";
            // 
            // LblFinalNetAmtDisp
            // 
            LblFinalNetAmtDisp.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblFinalNetAmtDisp.AutoSize = true;
            LblFinalNetAmtDisp.ForeColor = Color.FromArgb(0, 64, 64);
            LblFinalNetAmtDisp.Location = new Point(8, 181);
            LblFinalNetAmtDisp.Name = "LblFinalNetAmtDisp";
            LblFinalNetAmtDisp.Size = new Size(130, 23);
            LblFinalNetAmtDisp.TabIndex = 10;
            LblFinalNetAmtDisp.Text = "Net Amount";
            // 
            // LblFinalBalanceAmountDisp
            // 
            LblFinalBalanceAmountDisp.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblFinalBalanceAmountDisp.AutoSize = true;
            LblFinalBalanceAmountDisp.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblFinalBalanceAmountDisp.ForeColor = Color.FromArgb(0, 64, 64);
            LblFinalBalanceAmountDisp.Location = new Point(8, 397);
            LblFinalBalanceAmountDisp.Name = "LblFinalBalanceAmountDisp";
            LblFinalBalanceAmountDisp.Size = new Size(130, 18);
            LblFinalBalanceAmountDisp.TabIndex = 15;
            LblFinalBalanceAmountDisp.Text = "Balance Amount";
            // 
            // BtnSave
            // 
            tableLayoutPanel4.SetColumnSpan(BtnSave, 3);
            BtnSave.Dock = DockStyle.Fill;
            BtnSave.ForeColor = Color.Maroon;
            BtnSave.Location = new Point(5, 421);
            BtnSave.Margin = new Padding(0, 3, 0, 3);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(302, 54);
            BtnSave.TabIndex = 17;
            BtnSave.Text = "&Save && Print";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // LblFinalBalanceAmount
            // 
            LblFinalBalanceAmount.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblFinalBalanceAmount.AutoSize = true;
            LblFinalBalanceAmount.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblFinalBalanceAmount.ForeColor = Color.Maroon;
            LblFinalBalanceAmount.Location = new Point(153, 394);
            LblFinalBalanceAmount.Name = "LblFinalBalanceAmount";
            LblFinalBalanceAmount.Size = new Size(151, 23);
            LblFinalBalanceAmount.TabIndex = 16;
            LblFinalBalanceAmount.Text = "0.00";
            LblFinalBalanceAmount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LblFinalNetAmt
            // 
            LblFinalNetAmt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblFinalNetAmt.AutoSize = true;
            LblFinalNetAmt.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point);
            LblFinalNetAmt.ForeColor = Color.Crimson;
            LblFinalNetAmt.Location = new Point(153, 173);
            LblFinalNetAmt.Name = "LblFinalNetAmt";
            LblFinalNetAmt.Size = new Size(151, 39);
            LblFinalNetAmt.TabIndex = 11;
            LblFinalNetAmt.Text = "0.00";
            LblFinalNetAmt.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LblFinalTotAmt
            // 
            LblFinalTotAmt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblFinalTotAmt.AutoSize = true;
            LblFinalTotAmt.ForeColor = Color.ForestGreen;
            LblFinalTotAmt.Location = new Point(153, 5);
            LblFinalTotAmt.Name = "LblFinalTotAmt";
            LblFinalTotAmt.Size = new Size(151, 23);
            LblFinalTotAmt.TabIndex = 1;
            LblFinalTotAmt.Text = "0.00";
            LblFinalTotAmt.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LblFinalGrossAmt
            // 
            LblFinalGrossAmt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblFinalGrossAmt.AutoSize = true;
            LblFinalGrossAmt.ForeColor = Color.ForestGreen;
            LblFinalGrossAmt.Location = new Point(153, 107);
            LblFinalGrossAmt.Name = "LblFinalGrossAmt";
            LblFinalGrossAmt.Size = new Size(151, 23);
            LblFinalGrossAmt.TabIndex = 7;
            LblFinalGrossAmt.Text = "0.00";
            LblFinalGrossAmt.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LblFinalRoundOffAmt
            // 
            LblFinalRoundOffAmt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblFinalRoundOffAmt.AutoSize = true;
            LblFinalRoundOffAmt.ForeColor = Color.ForestGreen;
            LblFinalRoundOffAmt.Location = new Point(153, 141);
            LblFinalRoundOffAmt.Name = "LblFinalRoundOffAmt";
            LblFinalRoundOffAmt.Size = new Size(151, 23);
            LblFinalRoundOffAmt.TabIndex = 9;
            LblFinalRoundOffAmt.Text = "0.00";
            LblFinalRoundOffAmt.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TxtFinalDiscPer
            // 
            TxtFinalDiscPer.Anchor = AnchorStyles.Right;
            TxtFinalDiscPer.BackColor = Color.WhiteSmoke;
            TxtFinalDiscPer.ForeColor = Color.ForestGreen;
            TxtFinalDiscPer.Location = new Point(216, 37);
            TxtFinalDiscPer.Name = "TxtFinalDiscPer";
            TxtFinalDiscPer.Size = new Size(88, 31);
            TxtFinalDiscPer.TabIndex = 3;
            TxtFinalDiscPer.Text = "0.00";
            TxtFinalDiscPer.TextAlign = HorizontalAlignment.Right;
            TxtFinalDiscPer.TextChanged += TxtFinalDiscPer_TextChanged;
            TxtFinalDiscPer.Enter += TextBox_Enter;
            TxtFinalDiscPer.KeyDown += TxtFinalDiscPer_KeyDown;
            TxtFinalDiscPer.KeyPress += ReadOnlyTextBox_KeyPress;
            TxtFinalDiscPer.Leave += TextBox_Leave;
            TxtFinalDiscPer.Validated += TxtFinalDiscPer_Validated;
            // 
            // TxtFinalDiscAmt
            // 
            TxtFinalDiscAmt.Anchor = AnchorStyles.Right;
            TxtFinalDiscAmt.BackColor = Color.WhiteSmoke;
            TxtFinalDiscAmt.ForeColor = Color.ForestGreen;
            TxtFinalDiscAmt.Location = new Point(216, 71);
            TxtFinalDiscAmt.Name = "TxtFinalDiscAmt";
            TxtFinalDiscAmt.Size = new Size(88, 31);
            TxtFinalDiscAmt.TabIndex = 5;
            TxtFinalDiscAmt.Text = "0.00";
            TxtFinalDiscAmt.TextAlign = HorizontalAlignment.Right;
            TxtFinalDiscAmt.TextChanged += TxtFinalDiscAmt_TextChanged;
            TxtFinalDiscAmt.Enter += TextBox_Enter;
            TxtFinalDiscAmt.KeyDown += TxtFinalDiscAmt_KeyDown;
            TxtFinalDiscAmt.KeyPress += ReadOnlyTextBox_KeyPress;
            TxtFinalDiscAmt.Leave += TextBox_Leave;
            TxtFinalDiscAmt.Validated += TxtFinalDiscAmt_Validated;
            // 
            // groupBox1
            // 
            tableLayoutPanel4.SetColumnSpan(groupBox1, 3);
            groupBox1.Controls.Add(tableLayoutPanel5);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.FromArgb(0, 64, 64);
            groupBox1.Location = new Point(6, 217);
            groupBox1.Margin = new Padding(1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 136);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Payment Details";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(label12, 0, 0);
            tableLayoutPanel5.Controls.Add(label13, 0, 1);
            tableLayoutPanel5.Controls.Add(label14, 0, 2);
            tableLayoutPanel5.Controls.Add(TxtPaymentDetCash, 1, 0);
            tableLayoutPanel5.Controls.Add(TxtPaymentDetUpi, 1, 1);
            tableLayoutPanel5.Controls.Add(TxtPaymentDetCard, 1, 2);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tableLayoutPanel5.Location = new Point(3, 19);
            tableLayoutPanel5.Margin = new Padding(0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 3;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(294, 114);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Location = new Point(3, 9);
            label12.Name = "label12";
            label12.Size = new Size(141, 19);
            label12.TabIndex = 0;
            label12.Text = "Cash";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.Location = new Point(3, 47);
            label13.Name = "label13";
            label13.Size = new Size(141, 19);
            label13.TabIndex = 2;
            label13.Text = "UPI";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label14.AutoSize = true;
            label14.Location = new Point(3, 85);
            label14.Name = "label14";
            label14.Size = new Size(141, 19);
            label14.TabIndex = 4;
            label14.Text = "Card";
            // 
            // TxtPaymentDetCash
            // 
            TxtPaymentDetCash.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtPaymentDetCash.BackColor = Color.WhiteSmoke;
            TxtPaymentDetCash.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            TxtPaymentDetCash.ForeColor = Color.ForestGreen;
            TxtPaymentDetCash.Location = new Point(150, 3);
            TxtPaymentDetCash.Name = "TxtPaymentDetCash";
            TxtPaymentDetCash.Size = new Size(141, 31);
            TxtPaymentDetCash.TabIndex = 1;
            TxtPaymentDetCash.Text = "0.00";
            TxtPaymentDetCash.TextAlign = HorizontalAlignment.Right;
            TxtPaymentDetCash.TextChanged += TxtPaymentDetCash_TextChanged;
            TxtPaymentDetCash.Enter += TextBox_Enter;
            TxtPaymentDetCash.KeyDown += TxtPaymentDetCash_KeyDown;
            TxtPaymentDetCash.KeyPress += Decimal_KeyPress;
            TxtPaymentDetCash.Leave += TextBox_Leave;
            TxtPaymentDetCash.Validated += TxtPaymentDetCash_Validated;
            // 
            // TxtPaymentDetUpi
            // 
            TxtPaymentDetUpi.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtPaymentDetUpi.BackColor = Color.WhiteSmoke;
            TxtPaymentDetUpi.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            TxtPaymentDetUpi.ForeColor = Color.ForestGreen;
            TxtPaymentDetUpi.Location = new Point(150, 41);
            TxtPaymentDetUpi.Name = "TxtPaymentDetUpi";
            TxtPaymentDetUpi.Size = new Size(141, 31);
            TxtPaymentDetUpi.TabIndex = 3;
            TxtPaymentDetUpi.Text = "0.00";
            TxtPaymentDetUpi.TextAlign = HorizontalAlignment.Right;
            TxtPaymentDetUpi.TextChanged += TxtPaymentDetUpi_TextChanged;
            TxtPaymentDetUpi.Enter += TextBox_Enter;
            TxtPaymentDetUpi.KeyDown += TxtPaymentDetUpi_KeyDown;
            TxtPaymentDetUpi.KeyPress += Decimal_KeyPress;
            TxtPaymentDetUpi.Leave += TextBox_Leave;
            TxtPaymentDetUpi.Validated += TxtPaymentDetUpi_Validated;
            // 
            // TxtPaymentDetCard
            // 
            TxtPaymentDetCard.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtPaymentDetCard.BackColor = Color.WhiteSmoke;
            TxtPaymentDetCard.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            TxtPaymentDetCard.ForeColor = Color.ForestGreen;
            TxtPaymentDetCard.Location = new Point(150, 79);
            TxtPaymentDetCard.Name = "TxtPaymentDetCard";
            TxtPaymentDetCard.Size = new Size(141, 31);
            TxtPaymentDetCard.TabIndex = 5;
            TxtPaymentDetCard.Text = "0.00";
            TxtPaymentDetCard.TextAlign = HorizontalAlignment.Right;
            TxtPaymentDetCard.TextChanged += TxtPaymentDetCard_TextChanged;
            TxtPaymentDetCard.Enter += TextBox_Enter;
            TxtPaymentDetCard.KeyDown += TxtPaymentDetCard_KeyDown;
            TxtPaymentDetCard.KeyPress += Decimal_KeyPress;
            TxtPaymentDetCard.Leave += TextBox_Leave;
            TxtPaymentDetCard.Validated += TxtPaymentDetCard_Validated;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel6.ColumnCount = 3;
            tableLayoutPanel1.SetColumnSpan(tableLayoutPanel6, 3);
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 77.1361F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.4319439F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.4319439F));
            tableLayoutPanel6.Controls.Add(BtnCancelAll, 1, 0);
            tableLayoutPanel6.Controls.Add(BtnExit, 2, 0);
            tableLayoutPanel6.Controls.Add(label19, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 628);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(1364, 48);
            tableLayoutPanel6.TabIndex = 2;
            // 
            // BtnCancelAll
            // 
            BtnCancelAll.Dock = DockStyle.Fill;
            BtnCancelAll.ForeColor = Color.SaddleBrown;
            BtnCancelAll.Location = new Point(1054, 4);
            BtnCancelAll.Name = "BtnCancelAll";
            BtnCancelAll.Size = new Size(149, 40);
            BtnCancelAll.TabIndex = 1;
            BtnCancelAll.Text = "Cance&l All";
            BtnCancelAll.UseVisualStyleBackColor = true;
            BtnCancelAll.Click += BtnCancelAll_Click;
            // 
            // BtnExit
            // 
            BtnExit.Dock = DockStyle.Fill;
            BtnExit.ForeColor = Color.Crimson;
            BtnExit.Location = new Point(1210, 4);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(150, 40);
            BtnExit.TabIndex = 2;
            BtnExit.Text = "E&xit";
            BtnExit.UseVisualStyleBackColor = true;
            BtnExit.Click += BtnExit_Click;
            // 
            // label19
            // 
            label19.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label19.AutoSize = true;
            label19.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label19.ForeColor = Color.FromArgb(0, 64, 64);
            label19.Location = new Point(4, 1);
            label19.Name = "label19";
            label19.Size = new Size(1043, 45);
            label19.TabIndex = 0;
            label19.Text = resources.GetString("label19.Text");
            // 
            // ErrorProvider
            // 
            ErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            ErrorProvider.ContainerControl = this;
            // 
            // FrmPos
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 679);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmPos";
            Text = "POS";
            Load += FrmPos_Load;
            KeyDown += FrmPos_KeyDown;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGVCart).EndInit();
            TlpProductDetails.ResumeLayout(false);
            TlpProductDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvProductSearch).EndInit();
            pnlCartEntry.ResumeLayout(false);
            tlpProDetails.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            TLP_RateBasedWt.ResumeLayout(false);
            TLP_RateBasedWt.PerformLayout();
            panel1.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            groupBox1.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ErrorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView DGVCart;
        private TableLayoutPanel TlpProductDetails;
        private Label label1;
        private TextBox TxtProductSearch;
        private Label LblProCode;
        private DataGridView DgvProductSearch;
        private Panel pnlCartEntry;
        private TableLayoutPanel tlpProDetails;
        private Label LblProName;
        private TextBox TxtProCode;
        private TextBox TxtProName;
        private Label LblProTName;
        private TextBox TxtProTName;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel2;
        private Label LblQty;
        private Label LblUnit;
        private Label LblRate;
        private TextBox TxtQty;
        private TextBox TxtRate;
        private Label LblTotAmt;
        private TextBox TxtTotAmt;
        private Button BtnAddCart;
        private Label LblDiscPercentage;
        private TextBox TxtDiscPercentage;
        private Label LblDiscAmt;
        private TextBox TxtDiscAmt;
        private Button BtnCancel;
        private Label LblAmt;
        private TextBox TxtAmt;
        private TableLayoutPanel tableLayoutPanel4;
        private Label LblFinalGrossAmtDisp;
        private Label LblFinalTotAmtDisp;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label LblFinalNetAmtDisp;
        private Label LblFinalNetAmt;
        private Label LblFinalTotAmt;
        private Label LblFinalGrossAmt;
        private Label LblFinalRoundOffAmt;
        private TextBox TxtFinalDiscPer;
        private TextBox TxtFinalDiscAmt;
        private Panel panel1;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label12;
        private Label label13;
        private Label label14;
        private TextBox TxtPaymentDetCash;
        private TextBox TxtPaymentDetUpi;
        private TextBox TxtPaymentDetCard;
        private Label LblFinalBalanceAmountDisp;
        private Button BtnSave;
        private Label LblFinalAmtReceivedDisp;
        private Label LblFinalAmtReceived;
        private Label LblFinalBalanceAmount;
        private TableLayoutPanel tableLayoutPanel6;
        private Button BtnCancelAll;
        private Button BtnExit;
        private Label label19;
        private ErrorProvider ErrorProvider;
        private TableLayoutPanel TLP_RateBasedWt;
        private TextBox TxtRBWRate;
        private TextBox TxtRBWWeight;
        private Label label2;
        private Label label3;
        private Label label7;
        private TableLayoutPanel tableLayoutPanel7;
        private Label LblMrp;
        private TextBox TxtMrp;
        private Label LblDiscFromMRP;
        private Label LblPurchaseAmt;
        private TextBox TxtDiscFromMRP;
    }
}