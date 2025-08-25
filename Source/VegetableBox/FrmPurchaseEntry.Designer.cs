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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            DGVPurchaseCart = new DataGridView();
            tableLayoutPanel5 = new TableLayoutPanel();
            BtnExit = new Button();
            label3 = new Label();
            LblTotalAmt = new Label();
            BtnCancel = new Button();
            BtnSave = new Button();
            BtnBillCompleted = new Button();
            label13 = new Label();
            tableLayoutPanel6 = new TableLayoutPanel();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            TxtPurchaseRatePerQty = new TextBox();
            LblPurchaseRatePerKgPcs = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            BtnClear = new Button();
            BtnAdd = new Button();
            DtpBillDate = new DateTimePicker();
            label2 = new Label();
            TxtBillNo = new TextBox();
            tableLayoutPanel9 = new TableLayoutPanel();
            LblLastPurchaseRate = new Label();
            TxtLastPurchaseRate = new TextBox();
            LblCurrentSellingRate = new Label();
            TxtCurrentSellingRate = new TextBox();
            LblSellingMarginPercentage = new Label();
            TxtSellingMarginPer = new TextBox();
            TxtDiscRateFromMRP = new TextBox();
            LblDiscRateFromMRP = new Label();
            TxtDiscPerFromMRP = new TextBox();
            LblDiscPerFromMRP = new Label();
            label12 = new Label();
            TxtLastMRP = new TextBox();
            TxtProductSearch = new TextBox();
            label1 = new Label();
            DgvProductSearch = new DataGridView();
            label6 = new Label();
            label7 = new Label();
            TxtProductName = new TextBox();
            TxtProductTamilName = new TextBox();
            label5 = new Label();
            CmbProductCategory = new ComboBox();
            label8 = new Label();
            CmbVendorName = new ComboBox();
            DgvVendorInvoiceDetails = new DataGridView();
            label9 = new Label();
            LblPurchaseWtPcs = new Label();
            tableLayoutPanel7 = new TableLayoutPanel();
            TxtTotPurchaseQty = new TextBox();
            LblQtyType = new Label();
            label4 = new Label();
            TxtTotPurchaseRate = new TextBox();
            LblMrp = new Label();
            TxtMrp = new TextBox();
            LblSellingRate = new Label();
            TxtSellingRate = new TextBox();
            tableLayoutPanel8 = new TableLayoutPanel();
            label10 = new Label();
            TxtBillAmount = new TextBox();
            tableLayoutPanel10 = new TableLayoutPanel();
            label11 = new Label();
            TxtBillItemsCount = new TextBox();
            ErrorProvider = new ErrorProvider(components);
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVPurchaseCart).BeginInit();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvProductSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DgvVendorInvoiceDetails).BeginInit();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
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
            tableLayoutPanel1.Size = new Size(1321, 626);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(DGVPurchaseCart, 0, 1);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 3);
            tableLayoutPanel4.Controls.Add(label13, 0, 4);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(462, 2);
            tableLayoutPanel4.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 5;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 6.913183F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 65.75563F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 15.4340839F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 7.39549828F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 4.180064F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(856, 622);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // DGVPurchaseCart
            // 
            DGVPurchaseCart.AllowUserToAddRows = false;
            DGVPurchaseCart.AllowUserToDeleteRows = false;
            DGVPurchaseCart.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.IndianRed;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.SelectionForeColor = Color.IndianRed;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DGVPurchaseCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DGVPurchaseCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel4.SetColumnSpan(DGVPurchaseCart, 2);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(0, 64, 64);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.SelectionForeColor = Color.ForestGreen;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DGVPurchaseCart.DefaultCellStyle = dataGridViewCellStyle2;
            DGVPurchaseCart.Dock = DockStyle.Fill;
            DGVPurchaseCart.Location = new Point(3, 45);
            DGVPurchaseCart.Margin = new Padding(3, 2, 3, 2);
            DGVPurchaseCart.MultiSelect = false;
            DGVPurchaseCart.Name = "DGVPurchaseCart";
            DGVPurchaseCart.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Maroon;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            DGVPurchaseCart.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            DGVPurchaseCart.RowHeadersVisible = false;
            tableLayoutPanel4.SetRowSpan(DGVPurchaseCart, 2);
            DGVPurchaseCart.RowTemplate.Height = 25;
            DGVPurchaseCart.Size = new Size(850, 502);
            DGVPurchaseCart.TabIndex = 0;
            DGVPurchaseCart.CellClick += DGVPurchaseCart_CellClick;
            DGVPurchaseCart.CellDoubleClick += DGVPurchaseCart_CellDoubleClick;
            DGVPurchaseCart.CellEnter += DGVPurchaseCart_CellEnter;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 6;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.Controls.Add(BtnExit, 5, 0);
            tableLayoutPanel5.Controls.Add(label3, 0, 0);
            tableLayoutPanel5.Controls.Add(LblTotalAmt, 1, 0);
            tableLayoutPanel5.Controls.Add(BtnCancel, 4, 0);
            tableLayoutPanel5.Controls.Add(BtnSave, 2, 0);
            tableLayoutPanel5.Controls.Add(BtnBillCompleted, 3, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 551);
            tableLayoutPanel5.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(850, 42);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // BtnExit
            // 
            BtnExit.Dock = DockStyle.Fill;
            BtnExit.ForeColor = Color.Crimson;
            BtnExit.Location = new Point(720, 2);
            BtnExit.Margin = new Padding(3, 2, 3, 2);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(127, 38);
            BtnExit.TabIndex = 5;
            BtnExit.Text = "E&xit";
            BtnExit.UseVisualStyleBackColor = true;
            BtnExit.Click += BtnExit_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(2, 4);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(185, 33);
            label3.TabIndex = 0;
            label3.Text = "Total Amount : ";
            // 
            // LblTotalAmt
            // 
            LblTotalAmt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblTotalAmt.AutoSize = true;
            LblTotalAmt.Font = new Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblTotalAmt.ForeColor = Color.Crimson;
            LblTotalAmt.Location = new Point(191, 4);
            LblTotalAmt.Margin = new Padding(2, 0, 2, 0);
            LblTotalAmt.Name = "LblTotalAmt";
            LblTotalAmt.Size = new Size(128, 33);
            LblTotalAmt.TabIndex = 1;
            LblTotalAmt.Text = "...";
            // 
            // BtnCancel
            // 
            BtnCancel.Dock = DockStyle.Fill;
            BtnCancel.ForeColor = Color.OrangeRed;
            BtnCancel.Location = new Point(588, 2);
            BtnCancel.Margin = new Padding(3, 2, 3, 2);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(126, 38);
            BtnCancel.TabIndex = 4;
            BtnCancel.Text = "Ca&ncel";
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // BtnSave
            // 
            BtnSave.Dock = DockStyle.Fill;
            BtnSave.ForeColor = Color.Green;
            BtnSave.Location = new Point(324, 2);
            BtnSave.Margin = new Padding(3, 2, 3, 2);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(126, 38);
            BtnSave.TabIndex = 2;
            BtnSave.Text = "&Save";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // BtnBillCompleted
            // 
            BtnBillCompleted.Dock = DockStyle.Fill;
            BtnBillCompleted.ForeColor = Color.Chocolate;
            BtnBillCompleted.Location = new Point(456, 2);
            BtnBillCompleted.Margin = new Padding(3, 2, 3, 2);
            BtnBillCompleted.Name = "BtnBillCompleted";
            BtnBillCompleted.Size = new Size(126, 38);
            BtnBillCompleted.TabIndex = 3;
            BtnBillCompleted.Text = "&Bill Completed";
            BtnBillCompleted.UseVisualStyleBackColor = true;
            BtnBillCompleted.Click += BtnBillCompleted_Click;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Left;
            label13.AutoSize = true;
            label13.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(3, 601);
            label13.Name = "label13";
            label13.Size = new Size(266, 14);
            label13.TabIndex = 2;
            label13.Text = "Help => Press 'Delete' to remove only unsaved data.";
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Controls.Add(panel1, 0, 1);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 2);
            tableLayoutPanel6.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 3;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 1.30293155F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 95.60261F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 2.931596F));
            tableLayoutPanel6.Size = new Size(453, 622);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 10);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(3, 2, 3, 2);
            panel1.Size = new Size(447, 591);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.30804F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.1274662F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.5644951F));
            tableLayoutPanel2.Controls.Add(TxtPurchaseRatePerQty, 1, 12);
            tableLayoutPanel2.Controls.Add(LblPurchaseRatePerKgPcs, 0, 12);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 1, 15);
            tableLayoutPanel2.Controls.Add(DtpBillDate, 1, 4);
            tableLayoutPanel2.Controls.Add(label2, 0, 4);
            tableLayoutPanel2.Controls.Add(TxtBillNo, 1, 3);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel9, 2, 9);
            tableLayoutPanel2.Controls.Add(TxtProductSearch, 1, 5);
            tableLayoutPanel2.Controls.Add(label1, 0, 5);
            tableLayoutPanel2.Controls.Add(DgvProductSearch, 1, 6);
            tableLayoutPanel2.Controls.Add(label6, 0, 7);
            tableLayoutPanel2.Controls.Add(label7, 0, 8);
            tableLayoutPanel2.Controls.Add(TxtProductName, 1, 7);
            tableLayoutPanel2.Controls.Add(TxtProductTamilName, 1, 8);
            tableLayoutPanel2.Controls.Add(label5, 0, 9);
            tableLayoutPanel2.Controls.Add(CmbProductCategory, 1, 9);
            tableLayoutPanel2.Controls.Add(label8, 0, 1);
            tableLayoutPanel2.Controls.Add(CmbVendorName, 1, 1);
            tableLayoutPanel2.Controls.Add(DgvVendorInvoiceDetails, 0, 2);
            tableLayoutPanel2.Controls.Add(label9, 0, 3);
            tableLayoutPanel2.Controls.Add(LblPurchaseWtPcs, 0, 10);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel7, 1, 10);
            tableLayoutPanel2.Controls.Add(label4, 0, 11);
            tableLayoutPanel2.Controls.Add(TxtTotPurchaseRate, 1, 11);
            tableLayoutPanel2.Controls.Add(LblMrp, 0, 13);
            tableLayoutPanel2.Controls.Add(TxtMrp, 1, 13);
            tableLayoutPanel2.Controls.Add(LblSellingRate, 0, 14);
            tableLayoutPanel2.Controls.Add(TxtSellingRate, 1, 14);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel8, 2, 3);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel10, 2, 4);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 17;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 0.7667622F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 5.05446339F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 15.4700947F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 5.05446339F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 5.05446339F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 5.05446339F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 15.4700947F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 5.05446339F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 5.05446339F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 5.05446339F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 5.05446339F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 5.05446339F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 5.05446339F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 5.05446339F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 5.05446339F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 6.87272024F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 0.7667622F));
            tableLayoutPanel2.Size = new Size(439, 585);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // TxtPurchaseRatePerQty
            // 
            TxtPurchaseRatePerQty.Anchor = AnchorStyles.Left;
            TxtPurchaseRatePerQty.BackColor = Color.WhiteSmoke;
            TxtPurchaseRatePerQty.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            TxtPurchaseRatePerQty.ForeColor = Color.ForestGreen;
            TxtPurchaseRatePerQty.Location = new Point(146, 446);
            TxtPurchaseRatePerQty.Margin = new Padding(0);
            TxtPurchaseRatePerQty.MaxLength = 10;
            TxtPurchaseRatePerQty.Name = "TxtPurchaseRatePerQty";
            TxtPurchaseRatePerQty.Size = new Size(97, 26);
            TxtPurchaseRatePerQty.TabIndex = 23;
            TxtPurchaseRatePerQty.TextAlign = HorizontalAlignment.Right;
            TxtPurchaseRatePerQty.Enter += TextBox_Enter;
            TxtPurchaseRatePerQty.KeyDown += TxtPurchaseRatePerKg_KeyDown;
            TxtPurchaseRatePerQty.KeyPress += ReadOnlyTextBox_KeyPress;
            TxtPurchaseRatePerQty.Leave += TextBox_Leave;
            // 
            // LblPurchaseRatePerKgPcs
            // 
            LblPurchaseRatePerKgPcs.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblPurchaseRatePerKgPcs.AutoSize = true;
            LblPurchaseRatePerKgPcs.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblPurchaseRatePerKgPcs.Location = new Point(3, 445);
            LblPurchaseRatePerKgPcs.Name = "LblPurchaseRatePerKgPcs";
            LblPurchaseRatePerKgPcs.Size = new Size(140, 29);
            LblPurchaseRatePerKgPcs.TabIndex = 22;
            LblPurchaseRatePerKgPcs.Text = "Purchase Rate Per Qty";
            LblPurchaseRatePerKgPcs.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel2.SetColumnSpan(tableLayoutPanel3, 2);
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.5686283F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39.2156868F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39.2156868F));
            tableLayoutPanel3.Controls.Add(BtnClear, 2, 0);
            tableLayoutPanel3.Controls.Add(BtnAdd, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(146, 532);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(293, 40);
            tableLayoutPanel3.TabIndex = 29;
            // 
            // BtnClear
            // 
            BtnClear.Dock = DockStyle.Fill;
            BtnClear.ForeColor = Color.Purple;
            BtnClear.Location = new Point(180, 5);
            BtnClear.Margin = new Padding(3, 5, 3, 2);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(110, 33);
            BtnClear.TabIndex = 1;
            BtnClear.Text = "&Clear";
            BtnClear.UseVisualStyleBackColor = true;
            BtnClear.Click += BtnClear_Click;
            // 
            // BtnAdd
            // 
            BtnAdd.Dock = DockStyle.Fill;
            BtnAdd.ForeColor = Color.DarkGreen;
            BtnAdd.Location = new Point(66, 5);
            BtnAdd.Margin = new Padding(3, 5, 3, 2);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(108, 33);
            BtnAdd.TabIndex = 0;
            BtnAdd.Text = "&Add";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // DtpBillDate
            // 
            DtpBillDate.Anchor = AnchorStyles.Left;
            DtpBillDate.CustomFormat = "dd-MMM-yyyy";
            DtpBillDate.Enabled = false;
            DtpBillDate.Format = DateTimePickerFormat.Custom;
            DtpBillDate.Location = new Point(149, 155);
            DtpBillDate.Name = "DtpBillDate";
            DtpBillDate.Size = new Size(99, 26);
            DtpBillDate.TabIndex = 7;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(163, 0, 34);
            label2.Location = new Point(3, 157);
            label2.Name = "label2";
            label2.Size = new Size(140, 18);
            label2.TabIndex = 6;
            label2.Text = "Bill Date";
            // 
            // TxtBillNo
            // 
            TxtBillNo.Anchor = AnchorStyles.Left;
            TxtBillNo.BackColor = Color.WhiteSmoke;
            TxtBillNo.ForeColor = Color.ForestGreen;
            TxtBillNo.Location = new Point(149, 126);
            TxtBillNo.MaxLength = 10;
            TxtBillNo.Name = "TxtBillNo";
            TxtBillNo.ReadOnly = true;
            TxtBillNo.Size = new Size(99, 26);
            TxtBillNo.TabIndex = 4;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel9.ColumnCount = 2;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.Controls.Add(LblLastPurchaseRate, 0, 0);
            tableLayoutPanel9.Controls.Add(TxtLastPurchaseRate, 1, 0);
            tableLayoutPanel9.Controls.Add(LblCurrentSellingRate, 0, 2);
            tableLayoutPanel9.Controls.Add(TxtCurrentSellingRate, 1, 2);
            tableLayoutPanel9.Controls.Add(LblSellingMarginPercentage, 0, 3);
            tableLayoutPanel9.Controls.Add(TxtSellingMarginPer, 1, 3);
            tableLayoutPanel9.Controls.Add(TxtDiscRateFromMRP, 1, 5);
            tableLayoutPanel9.Controls.Add(LblDiscRateFromMRP, 0, 5);
            tableLayoutPanel9.Controls.Add(TxtDiscPerFromMRP, 1, 4);
            tableLayoutPanel9.Controls.Add(LblDiscPerFromMRP, 0, 4);
            tableLayoutPanel9.Controls.Add(label12, 0, 1);
            tableLayoutPanel9.Controls.Add(TxtLastMRP, 1, 1);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tableLayoutPanel9.Location = new Point(251, 358);
            tableLayoutPanel9.Margin = new Padding(0);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 6;
            tableLayoutPanel2.SetRowSpan(tableLayoutPanel9, 6);
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel9.Size = new Size(188, 174);
            tableLayoutPanel9.TabIndex = 28;
            // 
            // LblLastPurchaseRate
            // 
            LblLastPurchaseRate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblLastPurchaseRate.AutoSize = true;
            LblLastPurchaseRate.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LblLastPurchaseRate.Location = new Point(4, 7);
            LblLastPurchaseRate.Name = "LblLastPurchaseRate";
            LblLastPurchaseRate.Size = new Size(116, 15);
            LblLastPurchaseRate.TabIndex = 0;
            LblLastPurchaseRate.Text = "Last Purchase Rate";
            LblLastPurchaseRate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TxtLastPurchaseRate
            // 
            TxtLastPurchaseRate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtLastPurchaseRate.BackColor = Color.WhiteSmoke;
            TxtLastPurchaseRate.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            TxtLastPurchaseRate.ForeColor = Color.ForestGreen;
            TxtLastPurchaseRate.Location = new Point(126, 3);
            TxtLastPurchaseRate.Margin = new Padding(2);
            TxtLastPurchaseRate.MaxLength = 10;
            TxtLastPurchaseRate.Name = "TxtLastPurchaseRate";
            TxtLastPurchaseRate.Size = new Size(59, 23);
            TxtLastPurchaseRate.TabIndex = 1;
            TxtLastPurchaseRate.TextAlign = HorizontalAlignment.Center;
            TxtLastPurchaseRate.Enter += TextBox_Enter;
            TxtLastPurchaseRate.KeyDown += TxtLastPurchaseRate_KeyDown;
            TxtLastPurchaseRate.KeyPress += ReadOnlyTextBox_KeyPress;
            TxtLastPurchaseRate.Leave += TextBox_Leave;
            // 
            // LblCurrentSellingRate
            // 
            LblCurrentSellingRate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblCurrentSellingRate.AutoSize = true;
            LblCurrentSellingRate.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LblCurrentSellingRate.Location = new Point(4, 63);
            LblCurrentSellingRate.Name = "LblCurrentSellingRate";
            LblCurrentSellingRate.Size = new Size(116, 15);
            LblCurrentSellingRate.TabIndex = 4;
            LblCurrentSellingRate.Text = "Current Selling Rate";
            LblCurrentSellingRate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TxtCurrentSellingRate
            // 
            TxtCurrentSellingRate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtCurrentSellingRate.BackColor = Color.WhiteSmoke;
            TxtCurrentSellingRate.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            TxtCurrentSellingRate.ForeColor = Color.ForestGreen;
            TxtCurrentSellingRate.Location = new Point(126, 59);
            TxtCurrentSellingRate.Margin = new Padding(2);
            TxtCurrentSellingRate.MaxLength = 10;
            TxtCurrentSellingRate.Name = "TxtCurrentSellingRate";
            TxtCurrentSellingRate.Size = new Size(59, 23);
            TxtCurrentSellingRate.TabIndex = 5;
            TxtCurrentSellingRate.TextAlign = HorizontalAlignment.Center;
            TxtCurrentSellingRate.Enter += TextBox_Enter;
            TxtCurrentSellingRate.KeyDown += TxtCurrentSellingRate_KeyDown;
            TxtCurrentSellingRate.KeyPress += ReadOnlyTextBox_KeyPress;
            TxtCurrentSellingRate.Leave += TextBox_Leave;
            // 
            // LblSellingMarginPercentage
            // 
            LblSellingMarginPercentage.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblSellingMarginPercentage.AutoSize = true;
            LblSellingMarginPercentage.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LblSellingMarginPercentage.Location = new Point(4, 91);
            LblSellingMarginPercentage.Name = "LblSellingMarginPercentage";
            LblSellingMarginPercentage.Size = new Size(116, 15);
            LblSellingMarginPercentage.TabIndex = 6;
            LblSellingMarginPercentage.Text = "Selling Margin %";
            LblSellingMarginPercentage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TxtSellingMarginPer
            // 
            TxtSellingMarginPer.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtSellingMarginPer.BackColor = Color.WhiteSmoke;
            TxtSellingMarginPer.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            TxtSellingMarginPer.ForeColor = Color.ForestGreen;
            TxtSellingMarginPer.Location = new Point(126, 87);
            TxtSellingMarginPer.Margin = new Padding(2);
            TxtSellingMarginPer.MaxLength = 10;
            TxtSellingMarginPer.Name = "TxtSellingMarginPer";
            TxtSellingMarginPer.Size = new Size(59, 23);
            TxtSellingMarginPer.TabIndex = 7;
            TxtSellingMarginPer.TextAlign = HorizontalAlignment.Center;
            TxtSellingMarginPer.Enter += TextBox_Enter;
            TxtSellingMarginPer.KeyDown += TxtSellingMarginPercentage_KeyDown;
            TxtSellingMarginPer.KeyPress += ReadOnlyTextBox_KeyPress;
            TxtSellingMarginPer.Leave += TextBox_Leave;
            // 
            // TxtDiscRateFromMRP
            // 
            TxtDiscRateFromMRP.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtDiscRateFromMRP.BackColor = Color.WhiteSmoke;
            TxtDiscRateFromMRP.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            TxtDiscRateFromMRP.ForeColor = Color.ForestGreen;
            TxtDiscRateFromMRP.Location = new Point(126, 145);
            TxtDiscRateFromMRP.Margin = new Padding(2);
            TxtDiscRateFromMRP.MaxLength = 10;
            TxtDiscRateFromMRP.Name = "TxtDiscRateFromMRP";
            TxtDiscRateFromMRP.Size = new Size(59, 23);
            TxtDiscRateFromMRP.TabIndex = 11;
            TxtDiscRateFromMRP.TextAlign = HorizontalAlignment.Center;
            TxtDiscRateFromMRP.Enter += TextBox_Enter;
            TxtDiscRateFromMRP.KeyDown += TxtDiscFromMRP_KeyDown;
            TxtDiscRateFromMRP.KeyPress += ReadOnlyTextBox_KeyPress;
            TxtDiscRateFromMRP.Leave += TextBox_Leave;
            // 
            // LblDiscRateFromMRP
            // 
            LblDiscRateFromMRP.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblDiscRateFromMRP.AutoSize = true;
            LblDiscRateFromMRP.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LblDiscRateFromMRP.Location = new Point(4, 149);
            LblDiscRateFromMRP.Name = "LblDiscRateFromMRP";
            LblDiscRateFromMRP.Size = new Size(116, 15);
            LblDiscRateFromMRP.TabIndex = 10;
            LblDiscRateFromMRP.Text = "Disc Rate From MRP";
            LblDiscRateFromMRP.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TxtDiscPerFromMRP
            // 
            TxtDiscPerFromMRP.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtDiscPerFromMRP.BackColor = Color.WhiteSmoke;
            TxtDiscPerFromMRP.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            TxtDiscPerFromMRP.ForeColor = Color.ForestGreen;
            TxtDiscPerFromMRP.Location = new Point(126, 115);
            TxtDiscPerFromMRP.Margin = new Padding(2);
            TxtDiscPerFromMRP.MaxLength = 10;
            TxtDiscPerFromMRP.Name = "TxtDiscPerFromMRP";
            TxtDiscPerFromMRP.Size = new Size(59, 23);
            TxtDiscPerFromMRP.TabIndex = 9;
            TxtDiscPerFromMRP.TextAlign = HorizontalAlignment.Center;
            TxtDiscPerFromMRP.Enter += TextBox_Enter;
            TxtDiscPerFromMRP.KeyDown += TxtDiscFromMRP_KeyDown;
            TxtDiscPerFromMRP.KeyPress += ReadOnlyTextBox_KeyPress;
            TxtDiscPerFromMRP.Leave += TextBox_Leave;
            // 
            // LblDiscPerFromMRP
            // 
            LblDiscPerFromMRP.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblDiscPerFromMRP.AutoSize = true;
            LblDiscPerFromMRP.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LblDiscPerFromMRP.Location = new Point(4, 119);
            LblDiscPerFromMRP.Name = "LblDiscPerFromMRP";
            LblDiscPerFromMRP.Size = new Size(116, 15);
            LblDiscPerFromMRP.TabIndex = 8;
            LblDiscPerFromMRP.Text = "Disc % From MRP";
            LblDiscPerFromMRP.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(4, 35);
            label12.Name = "label12";
            label12.Size = new Size(116, 15);
            label12.TabIndex = 2;
            label12.Text = "Last MRP";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TxtLastMRP
            // 
            TxtLastMRP.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtLastMRP.BackColor = Color.WhiteSmoke;
            TxtLastMRP.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            TxtLastMRP.ForeColor = Color.ForestGreen;
            TxtLastMRP.Location = new Point(126, 31);
            TxtLastMRP.Margin = new Padding(2);
            TxtLastMRP.MaxLength = 10;
            TxtLastMRP.Name = "TxtLastMRP";
            TxtLastMRP.Size = new Size(59, 23);
            TxtLastMRP.TabIndex = 3;
            TxtLastMRP.TextAlign = HorizontalAlignment.Center;
            TxtLastMRP.Enter += TextBox_Enter;
            TxtLastMRP.KeyDown += TxtLastPurchaseRate_KeyDown;
            TxtLastMRP.KeyPress += ReadOnlyTextBox_KeyPress;
            TxtLastMRP.Leave += TextBox_Leave;
            // 
            // TxtProductSearch
            // 
            TxtProductSearch.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtProductSearch.BackColor = Color.WhiteSmoke;
            tableLayoutPanel2.SetColumnSpan(TxtProductSearch, 2);
            TxtProductSearch.ForeColor = Color.ForestGreen;
            TxtProductSearch.Location = new Point(146, 182);
            TxtProductSearch.Margin = new Padding(0);
            TxtProductSearch.Name = "TxtProductSearch";
            TxtProductSearch.PlaceholderText = "Search for Product";
            TxtProductSearch.Size = new Size(293, 26);
            TxtProductSearch.TabIndex = 10;
            TxtProductSearch.TextChanged += TxtProductSearch_TextChanged;
            TxtProductSearch.Enter += TextBox_Enter;
            TxtProductSearch.KeyDown += TxtProductSearch_KeyDown;
            TxtProductSearch.Leave += TextBox_Leave;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(3, 186);
            label1.Name = "label1";
            label1.Size = new Size(140, 18);
            label1.TabIndex = 9;
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
            tableLayoutPanel2.SetColumnSpan(DgvProductSearch, 2);
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(0, 64, 64);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(244, 244, 244);
            dataGridViewCellStyle4.SelectionForeColor = Color.ForestGreen;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            DgvProductSearch.DefaultCellStyle = dataGridViewCellStyle4;
            DgvProductSearch.Dock = DockStyle.Fill;
            DgvProductSearch.GridColor = Color.White;
            DgvProductSearch.Location = new Point(146, 210);
            DgvProductSearch.Margin = new Padding(0, 0, 3, 0);
            DgvProductSearch.MultiSelect = false;
            DgvProductSearch.Name = "DgvProductSearch";
            DgvProductSearch.ReadOnly = true;
            DgvProductSearch.RowHeadersVisible = false;
            DgvProductSearch.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            DgvProductSearch.Size = new Size(290, 90);
            DgvProductSearch.TabIndex = 11;
            DgvProductSearch.KeyDown += DgvProductSearch_KeyDown;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(3, 305);
            label6.Name = "label6";
            label6.Size = new Size(140, 18);
            label6.TabIndex = 12;
            label6.Text = "Product Name";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(3, 334);
            label7.Name = "label7";
            label7.Size = new Size(140, 18);
            label7.TabIndex = 14;
            label7.Text = "Product Tamil Name";
            // 
            // TxtProductName
            // 
            TxtProductName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtProductName.BackColor = Color.WhiteSmoke;
            tableLayoutPanel2.SetColumnSpan(TxtProductName, 2);
            TxtProductName.ForeColor = Color.ForestGreen;
            TxtProductName.Location = new Point(146, 301);
            TxtProductName.Margin = new Padding(0, 0, 3, 0);
            TxtProductName.Name = "TxtProductName";
            TxtProductName.Size = new Size(290, 26);
            TxtProductName.TabIndex = 13;
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
            tableLayoutPanel2.SetColumnSpan(TxtProductTamilName, 2);
            TxtProductTamilName.ForeColor = Color.ForestGreen;
            TxtProductTamilName.Location = new Point(146, 330);
            TxtProductTamilName.Margin = new Padding(0, 0, 3, 0);
            TxtProductTamilName.Name = "TxtProductTamilName";
            TxtProductTamilName.Size = new Size(290, 26);
            TxtProductTamilName.TabIndex = 15;
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
            label5.Location = new Point(3, 363);
            label5.Name = "label5";
            label5.Size = new Size(140, 18);
            label5.TabIndex = 16;
            label5.Text = "Product Category";
            // 
            // CmbProductCategory
            // 
            CmbProductCategory.Anchor = AnchorStyles.Left;
            CmbProductCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbProductCategory.Enabled = false;
            CmbProductCategory.FormattingEnabled = true;
            CmbProductCategory.Location = new Point(146, 361);
            CmbProductCategory.Margin = new Padding(0, 0, 3, 0);
            CmbProductCategory.Name = "CmbProductCategory";
            CmbProductCategory.Size = new Size(97, 26);
            CmbProductCategory.TabIndex = 17;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.ForeColor = Color.FromArgb(163, 0, 34);
            label8.Location = new Point(3, 9);
            label8.Name = "label8";
            label8.Size = new Size(140, 18);
            label8.TabIndex = 0;
            label8.Text = "Vendor Name*";
            // 
            // CmbVendorName
            // 
            CmbVendorName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CmbVendorName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CmbVendorName.AutoCompleteSource = AutoCompleteSource.ListItems;
            tableLayoutPanel2.SetColumnSpan(CmbVendorName, 2);
            CmbVendorName.FormattingEnabled = true;
            CmbVendorName.Location = new Point(146, 7);
            CmbVendorName.Margin = new Padding(0, 0, 3, 0);
            CmbVendorName.Name = "CmbVendorName";
            CmbVendorName.Size = new Size(290, 26);
            CmbVendorName.TabIndex = 1;
            CmbVendorName.SelectedValueChanged += CmbVendorName_SelectedValueChanged;
            CmbVendorName.Validating += CmbVendorName_Validating;
            // 
            // DgvVendorInvoiceDetails
            // 
            DgvVendorInvoiceDetails.AllowUserToAddRows = false;
            DgvVendorInvoiceDetails.AllowUserToDeleteRows = false;
            DgvVendorInvoiceDetails.AllowUserToResizeColumns = false;
            DgvVendorInvoiceDetails.AllowUserToResizeRows = false;
            DgvVendorInvoiceDetails.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.IndianRed;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle5.SelectionForeColor = Color.IndianRed;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            DgvVendorInvoiceDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            DgvVendorInvoiceDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel2.SetColumnSpan(DgvVendorInvoiceDetails, 3);
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(0, 64, 64);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle6.SelectionForeColor = Color.ForestGreen;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            DgvVendorInvoiceDetails.DefaultCellStyle = dataGridViewCellStyle6;
            DgvVendorInvoiceDetails.Dock = DockStyle.Fill;
            DgvVendorInvoiceDetails.Location = new Point(0, 33);
            DgvVendorInvoiceDetails.Margin = new Padding(0, 0, 3, 0);
            DgvVendorInvoiceDetails.MultiSelect = false;
            DgvVendorInvoiceDetails.Name = "DgvVendorInvoiceDetails";
            DgvVendorInvoiceDetails.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.Maroon;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            DgvVendorInvoiceDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            DgvVendorInvoiceDetails.RowHeadersVisible = false;
            DgvVendorInvoiceDetails.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            DgvVendorInvoiceDetails.RowTemplate.Height = 25;
            DgvVendorInvoiceDetails.Size = new Size(436, 90);
            DgvVendorInvoiceDetails.TabIndex = 2;
            DgvVendorInvoiceDetails.CellClick += DgvVendorInvoiceDetails_CellClick;
            DgvVendorInvoiceDetails.CellEnter += DgvVendorInvoiceDetails_CellEnter;
            DgvVendorInvoiceDetails.KeyDown += DgvVendorInvoiceDetails_KeyDown;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.ForeColor = Color.FromArgb(163, 0, 34);
            label9.Location = new Point(3, 128);
            label9.Name = "label9";
            label9.Size = new Size(140, 18);
            label9.TabIndex = 3;
            label9.Text = "Bill No";
            // 
            // LblPurchaseWtPcs
            // 
            LblPurchaseWtPcs.Anchor = AnchorStyles.Left;
            LblPurchaseWtPcs.AutoSize = true;
            LblPurchaseWtPcs.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblPurchaseWtPcs.ForeColor = Color.Crimson;
            LblPurchaseWtPcs.Location = new Point(3, 392);
            LblPurchaseWtPcs.Name = "LblPurchaseWtPcs";
            LblPurchaseWtPcs.Size = new Size(129, 18);
            LblPurchaseWtPcs.TabIndex = 18;
            LblPurchaseWtPcs.Text = "Total Purchase Qty*";
            LblPurchaseWtPcs.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 77.14286F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.8571434F));
            tableLayoutPanel7.Controls.Add(TxtTotPurchaseQty, 0, 0);
            tableLayoutPanel7.Controls.Add(LblQtyType, 1, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(146, 387);
            tableLayoutPanel7.Margin = new Padding(0);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Size = new Size(105, 29);
            tableLayoutPanel7.TabIndex = 19;
            // 
            // TxtTotPurchaseQty
            // 
            TxtTotPurchaseQty.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtTotPurchaseQty.BackColor = Color.WhiteSmoke;
            TxtTotPurchaseQty.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            TxtTotPurchaseQty.ForeColor = Color.ForestGreen;
            TxtTotPurchaseQty.Location = new Point(0, 1);
            TxtTotPurchaseQty.Margin = new Padding(0);
            TxtTotPurchaseQty.MaxLength = 10;
            TxtTotPurchaseQty.Name = "TxtTotPurchaseQty";
            TxtTotPurchaseQty.Size = new Size(81, 26);
            TxtTotPurchaseQty.TabIndex = 0;
            TxtTotPurchaseQty.TextAlign = HorizontalAlignment.Right;
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
            LblQtyType.Location = new Point(81, 5);
            LblQtyType.Margin = new Padding(0);
            LblQtyType.Name = "LblQtyType";
            LblQtyType.Size = new Size(24, 18);
            LblQtyType.TabIndex = 1;
            LblQtyType.Text = "...";
            LblQtyType.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Crimson;
            label4.Location = new Point(3, 416);
            label4.Name = "label4";
            label4.Size = new Size(140, 29);
            label4.TabIndex = 20;
            label4.Text = "Total Purchase Amount*";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtTotPurchaseRate
            // 
            TxtTotPurchaseRate.Anchor = AnchorStyles.Left;
            TxtTotPurchaseRate.BackColor = Color.WhiteSmoke;
            TxtTotPurchaseRate.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            TxtTotPurchaseRate.ForeColor = Color.ForestGreen;
            TxtTotPurchaseRate.Location = new Point(146, 417);
            TxtTotPurchaseRate.Margin = new Padding(0);
            TxtTotPurchaseRate.MaxLength = 10;
            TxtTotPurchaseRate.Name = "TxtTotPurchaseRate";
            TxtTotPurchaseRate.Size = new Size(97, 26);
            TxtTotPurchaseRate.TabIndex = 21;
            TxtTotPurchaseRate.TextAlign = HorizontalAlignment.Right;
            TxtTotPurchaseRate.TextChanged += TxtPurchaseRate_TextChanged;
            TxtTotPurchaseRate.Enter += TextBox_Enter;
            TxtTotPurchaseRate.KeyDown += TxtPurchaseRate_KeyDown;
            TxtTotPurchaseRate.KeyPress += Decimal_KeyPress;
            TxtTotPurchaseRate.Leave += TextBox_Leave;
            TxtTotPurchaseRate.Validated += TxtPurchaseRate_Validated;
            // 
            // LblMrp
            // 
            LblMrp.Anchor = AnchorStyles.Left;
            LblMrp.AutoSize = true;
            LblMrp.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblMrp.ForeColor = Color.Crimson;
            LblMrp.Location = new Point(3, 479);
            LblMrp.Name = "LblMrp";
            LblMrp.Size = new Size(44, 18);
            LblMrp.TabIndex = 24;
            LblMrp.Text = "MRP*";
            LblMrp.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TxtMrp
            // 
            TxtMrp.Anchor = AnchorStyles.Left;
            TxtMrp.BackColor = Color.WhiteSmoke;
            TxtMrp.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            TxtMrp.ForeColor = Color.ForestGreen;
            TxtMrp.Location = new Point(146, 475);
            TxtMrp.Margin = new Padding(0);
            TxtMrp.MaxLength = 10;
            TxtMrp.Name = "TxtMrp";
            TxtMrp.Size = new Size(97, 26);
            TxtMrp.TabIndex = 25;
            TxtMrp.TextAlign = HorizontalAlignment.Right;
            TxtMrp.EnabledChanged += TxtMrp_EnabledChanged;
            TxtMrp.Enter += TextBox_Enter;
            TxtMrp.KeyDown += TxtMrp_KeyDown;
            TxtMrp.KeyPress += Decimal_KeyPress;
            TxtMrp.Leave += TextBox_Leave;
            TxtMrp.Validated += TxtMrp_Validated;
            // 
            // LblSellingRate
            // 
            LblSellingRate.Anchor = AnchorStyles.Left;
            LblSellingRate.AutoSize = true;
            LblSellingRate.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblSellingRate.ForeColor = Color.Crimson;
            LblSellingRate.Location = new Point(3, 508);
            LblSellingRate.Name = "LblSellingRate";
            LblSellingRate.Size = new Size(88, 18);
            LblSellingRate.TabIndex = 26;
            LblSellingRate.Text = "Selling Rate*";
            LblSellingRate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TxtSellingRate
            // 
            TxtSellingRate.Anchor = AnchorStyles.Left;
            TxtSellingRate.BackColor = Color.WhiteSmoke;
            TxtSellingRate.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            TxtSellingRate.ForeColor = Color.ForestGreen;
            TxtSellingRate.Location = new Point(146, 504);
            TxtSellingRate.Margin = new Padding(0);
            TxtSellingRate.MaxLength = 10;
            TxtSellingRate.Name = "TxtSellingRate";
            TxtSellingRate.Size = new Size(97, 26);
            TxtSellingRate.TabIndex = 27;
            TxtSellingRate.TextAlign = HorizontalAlignment.Right;
            TxtSellingRate.TextChanged += TxtSellingRate_TextChanged;
            TxtSellingRate.Enter += TextBox_Enter;
            TxtSellingRate.KeyDown += TxtSellingRate_KeyDown;
            TxtSellingRate.KeyPress += Decimal_KeyPress;
            TxtSellingRate.Leave += TextBox_Leave;
            TxtSellingRate.Validated += TxtSellingRate_Validated;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 2;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Controls.Add(label10, 0, 0);
            tableLayoutPanel8.Controls.Add(TxtBillAmount, 1, 0);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(251, 123);
            tableLayoutPanel8.Margin = new Padding(0);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Size = new Size(188, 29);
            tableLayoutPanel8.TabIndex = 5;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.ForeColor = Color.FromArgb(163, 0, 34);
            label10.Location = new Point(3, 5);
            label10.Name = "label10";
            label10.Size = new Size(88, 18);
            label10.TabIndex = 0;
            label10.Text = "Bill Amount";
            // 
            // TxtBillAmount
            // 
            TxtBillAmount.Anchor = AnchorStyles.Left;
            TxtBillAmount.BackColor = Color.WhiteSmoke;
            TxtBillAmount.ForeColor = Color.ForestGreen;
            TxtBillAmount.Location = new Point(97, 3);
            TxtBillAmount.MaxLength = 10;
            TxtBillAmount.Name = "TxtBillAmount";
            TxtBillAmount.ReadOnly = true;
            TxtBillAmount.Size = new Size(88, 26);
            TxtBillAmount.TabIndex = 1;
            TxtBillAmount.TextAlign = HorizontalAlignment.Right;
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.ColumnCount = 2;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.Controls.Add(label11, 0, 0);
            tableLayoutPanel10.Controls.Add(TxtBillItemsCount, 1, 0);
            tableLayoutPanel10.Dock = DockStyle.Fill;
            tableLayoutPanel10.Location = new Point(251, 152);
            tableLayoutPanel10.Margin = new Padding(0);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 1;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.Size = new Size(188, 29);
            tableLayoutPanel10.TabIndex = 8;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.ForeColor = Color.FromArgb(163, 0, 34);
            label11.Location = new Point(3, 5);
            label11.Name = "label11";
            label11.Size = new Size(88, 18);
            label11.TabIndex = 0;
            label11.Text = "Items Count";
            // 
            // TxtBillItemsCount
            // 
            TxtBillItemsCount.Anchor = AnchorStyles.Left;
            TxtBillItemsCount.BackColor = Color.WhiteSmoke;
            TxtBillItemsCount.ForeColor = Color.ForestGreen;
            TxtBillItemsCount.Location = new Point(97, 3);
            TxtBillItemsCount.MaxLength = 10;
            TxtBillItemsCount.Name = "TxtBillItemsCount";
            TxtBillItemsCount.ReadOnly = true;
            TxtBillItemsCount.Size = new Size(88, 26);
            TxtBillItemsCount.TabIndex = 1;
            TxtBillItemsCount.TextAlign = HorizontalAlignment.Right;
            // 
            // ErrorProvider
            // 
            ErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            ErrorProvider.ContainerControl = this;
            // 
            // FrmPurchaseEntry
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1321, 626);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
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
            tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVPurchaseCart).EndInit();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvProductSearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)DgvVendorInvoiceDetails).EndInit();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            tableLayoutPanel10.ResumeLayout(false);
            tableLayoutPanel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ErrorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Label LblPurchaseWtPcs;
        private Label label4;
        private Label LblPurchaseRatePerKgPcs;
        private TextBox TxtProductSearch;
        private DataGridView DgvProductSearch;
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
        private TableLayoutPanel tableLayoutPanel7;
        private Label LblSellingMarginPercentage;
        private Label LblMrp;
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
        private Label label8;
        private ComboBox CmbVendorName;
        private DataGridView DgvVendorInvoiceDetails;
        private Label label9;
        private TextBox TxtBillNo;
        private Label label2;
        private DateTimePicker DtpBillDate;
        private TableLayoutPanel tableLayoutPanel9;
        private Label LblSellingRate;
        private TextBox TxtSellingRate;
        private TableLayoutPanel tableLayoutPanel8;
        private TableLayoutPanel tableLayoutPanel10;
        private Label label10;
        private Label label11;
        private TextBox TxtBillAmount;
        private TextBox TxtBillItemsCount;
        private Label label12;
        private TextBox TxtLastMRP;
        private Label label13;
        private Button BtnCancel;
        private Button BtnBillCompleted;
    }
}