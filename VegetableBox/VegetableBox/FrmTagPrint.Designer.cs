namespace VegetableBox
{
    partial class FrmTagPrint
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
            label1 = new Label();
            DgvProductSearch = new DataGridView();
            tableLayoutPanel3 = new TableLayoutPanel();
            BtnPrint = new Button();
            BtnClear = new Button();
            BtnExit = new Button();
            label6 = new Label();
            label7 = new Label();
            TxtProductName = new TextBox();
            TxtProductTamilName = new TextBox();
            TxtSellingRate = new TextBox();
            LblSellingRate = new Label();
            LblMrp = new Label();
            TxtMrp = new TextBox();
            label2 = new Label();
            TxtBarcode = new TextBox();
            label5 = new Label();
            CmbLabelType = new ComboBox();
            label3 = new Label();
            TxtPrintCount = new TextBox();
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
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 1.30293155F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 95.60261F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 2.931596F));
            tableLayoutPanel6.Size = new Size(473, 584);
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
            panel1.Size = new Size(467, 553);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.0155449F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70.98446F));
            tableLayoutPanel2.Controls.Add(TxtProductSearch, 1, 1);
            tableLayoutPanel2.Controls.Add(label1, 0, 1);
            tableLayoutPanel2.Controls.Add(DgvProductSearch, 1, 2);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 1, 10);
            tableLayoutPanel2.Controls.Add(label6, 0, 3);
            tableLayoutPanel2.Controls.Add(label7, 0, 4);
            tableLayoutPanel2.Controls.Add(TxtProductName, 1, 3);
            tableLayoutPanel2.Controls.Add(TxtProductTamilName, 1, 4);
            tableLayoutPanel2.Controls.Add(TxtSellingRate, 1, 6);
            tableLayoutPanel2.Controls.Add(LblSellingRate, 0, 6);
            tableLayoutPanel2.Controls.Add(LblMrp, 0, 5);
            tableLayoutPanel2.Controls.Add(TxtMrp, 1, 5);
            tableLayoutPanel2.Controls.Add(label2, 0, 7);
            tableLayoutPanel2.Controls.Add(TxtBarcode, 1, 7);
            tableLayoutPanel2.Controls.Add(label5, 0, 9);
            tableLayoutPanel2.Controls.Add(CmbLabelType, 1, 9);
            tableLayoutPanel2.Controls.Add(label3, 0, 8);
            tableLayoutPanel2.Controls.Add(TxtPrintCount, 1, 8);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Margin = new Padding(5);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 12;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 5.07936954F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7.83576F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 19.3125019F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7.83576F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7.83576F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7.83576F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7.83861637F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7.83861637F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7.83861637F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7.834102F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7.83576F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 5.079368F));
            tableLayoutPanel2.Size = new Size(459, 545);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // TxtProductSearch
            // 
            TxtProductSearch.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtProductSearch.BackColor = Color.WhiteSmoke;
            TxtProductSearch.ForeColor = Color.ForestGreen;
            TxtProductSearch.Location = new Point(133, 34);
            TxtProductSearch.Margin = new Padding(0);
            TxtProductSearch.Name = "TxtProductSearch";
            TxtProductSearch.PlaceholderText = "Search for Product";
            TxtProductSearch.Size = new Size(326, 27);
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
            label1.Location = new Point(3, 38);
            label1.Name = "label1";
            label1.Size = new Size(127, 19);
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
            DgvProductSearch.Location = new Point(133, 69);
            DgvProductSearch.Margin = new Padding(0);
            DgvProductSearch.MultiSelect = false;
            DgvProductSearch.Name = "DgvProductSearch";
            DgvProductSearch.ReadOnly = true;
            DgvProductSearch.RowHeadersVisible = false;
            DgvProductSearch.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            DgvProductSearch.Size = new Size(326, 105);
            DgvProductSearch.TabIndex = 2;
            DgvProductSearch.KeyDown += DgvProductSearch_KeyDown;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Controls.Add(BtnPrint, 0, 0);
            tableLayoutPanel3.Controls.Add(BtnClear, 1, 0);
            tableLayoutPanel3.Controls.Add(BtnExit, 2, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(133, 468);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(326, 42);
            tableLayoutPanel3.TabIndex = 17;
            // 
            // BtnPrint
            // 
            BtnPrint.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            BtnPrint.ForeColor = Color.Maroon;
            BtnPrint.Location = new Point(3, 4);
            BtnPrint.Name = "BtnPrint";
            BtnPrint.Size = new Size(102, 33);
            BtnPrint.TabIndex = 0;
            BtnPrint.Text = "&Print";
            BtnPrint.UseVisualStyleBackColor = true;
            BtnPrint.Click += BtnPrint_Click;
            // 
            // BtnClear
            // 
            BtnClear.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            BtnClear.ForeColor = Color.Purple;
            BtnClear.Location = new Point(111, 4);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(102, 33);
            BtnClear.TabIndex = 1;
            BtnClear.Text = "&Clear";
            BtnClear.UseVisualStyleBackColor = true;
            BtnClear.Click += BtnClear_Click;
            // 
            // BtnExit
            // 
            BtnExit.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            BtnExit.ForeColor = Color.Red;
            BtnExit.Location = new Point(219, 4);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(104, 33);
            BtnExit.TabIndex = 2;
            BtnExit.Text = "E&xit";
            BtnExit.UseVisualStyleBackColor = true;
            BtnExit.Click += BtnExit_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(3, 185);
            label6.Name = "label6";
            label6.Size = new Size(127, 19);
            label6.TabIndex = 3;
            label6.Text = "Product Name";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(3, 218);
            label7.Name = "label7";
            label7.Size = new Size(127, 38);
            label7.TabIndex = 5;
            label7.Text = "Product Tamil Name";
            // 
            // TxtProductName
            // 
            TxtProductName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtProductName.BackColor = Color.WhiteSmoke;
            TxtProductName.ForeColor = Color.ForestGreen;
            TxtProductName.Location = new Point(133, 181);
            TxtProductName.Margin = new Padding(0);
            TxtProductName.Name = "TxtProductName";
            TxtProductName.Size = new Size(326, 27);
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
            TxtProductTamilName.Location = new Point(133, 223);
            TxtProductTamilName.Margin = new Padding(0);
            TxtProductTamilName.Name = "TxtProductTamilName";
            TxtProductTamilName.Size = new Size(326, 27);
            TxtProductTamilName.TabIndex = 6;
            TxtProductTamilName.TextChanged += TxtProductSearch_TextChanged;
            TxtProductTamilName.Enter += TextBox_Enter;
            TxtProductTamilName.KeyDown += TxtProductSearch_KeyDown;
            TxtProductTamilName.KeyPress += ReadOnlyTextBox_KeyPress;
            TxtProductTamilName.Leave += TextBox_Leave;
            // 
            // TxtSellingRate
            // 
            TxtSellingRate.Anchor = AnchorStyles.Left;
            TxtSellingRate.BackColor = Color.WhiteSmoke;
            TxtSellingRate.ForeColor = Color.ForestGreen;
            TxtSellingRate.Location = new Point(133, 307);
            TxtSellingRate.Margin = new Padding(0);
            TxtSellingRate.MaxLength = 10;
            TxtSellingRate.Name = "TxtSellingRate";
            TxtSellingRate.Size = new Size(122, 27);
            TxtSellingRate.TabIndex = 10;
            TxtSellingRate.TextAlign = HorizontalAlignment.Right;
            TxtSellingRate.Enter += TextBox_Enter;
            TxtSellingRate.KeyPress += ReadOnlyTextBox_KeyPress;
            TxtSellingRate.Leave += TextBox_Leave;
            // 
            // LblSellingRate
            // 
            LblSellingRate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblSellingRate.AutoSize = true;
            LblSellingRate.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblSellingRate.ForeColor = Color.FromArgb(0, 64, 64);
            LblSellingRate.Location = new Point(3, 311);
            LblSellingRate.Name = "LblSellingRate";
            LblSellingRate.Size = new Size(127, 19);
            LblSellingRate.TabIndex = 9;
            LblSellingRate.Text = "Selling Rate";
            LblSellingRate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblMrp
            // 
            LblMrp.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblMrp.AutoSize = true;
            LblMrp.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblMrp.ForeColor = Color.FromArgb(0, 64, 64);
            LblMrp.Location = new Point(3, 269);
            LblMrp.Name = "LblMrp";
            LblMrp.Size = new Size(127, 19);
            LblMrp.TabIndex = 7;
            LblMrp.Text = "MRP";
            LblMrp.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtMrp
            // 
            TxtMrp.Anchor = AnchorStyles.Left;
            TxtMrp.BackColor = Color.WhiteSmoke;
            TxtMrp.ForeColor = Color.ForestGreen;
            TxtMrp.Location = new Point(133, 265);
            TxtMrp.Margin = new Padding(0);
            TxtMrp.MaxLength = 10;
            TxtMrp.Name = "TxtMrp";
            TxtMrp.Size = new Size(122, 27);
            TxtMrp.TabIndex = 8;
            TxtMrp.TextAlign = HorizontalAlignment.Right;
            TxtMrp.Enter += TextBox_Enter;
            TxtMrp.KeyPress += ReadOnlyTextBox_KeyPress;
            TxtMrp.Leave += TextBox_Leave;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(3, 353);
            label2.Name = "label2";
            label2.Size = new Size(127, 19);
            label2.TabIndex = 11;
            label2.Text = "Barcode";
            // 
            // TxtBarcode
            // 
            TxtBarcode.Anchor = AnchorStyles.Left;
            TxtBarcode.BackColor = Color.WhiteSmoke;
            TxtBarcode.ForeColor = Color.ForestGreen;
            TxtBarcode.Location = new Point(133, 349);
            TxtBarcode.Margin = new Padding(0);
            TxtBarcode.Name = "TxtBarcode";
            TxtBarcode.Size = new Size(122, 27);
            TxtBarcode.TabIndex = 12;
            TxtBarcode.TextChanged += TxtProductSearch_TextChanged;
            TxtBarcode.Enter += TextBox_Enter;
            TxtBarcode.KeyDown += TxtProductSearch_KeyDown;
            TxtBarcode.KeyPress += ReadOnlyTextBox_KeyPress;
            TxtBarcode.Leave += TextBox_Leave;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(3, 437);
            label5.Name = "label5";
            label5.Size = new Size(127, 19);
            label5.TabIndex = 15;
            label5.Text = "Label Type";
            // 
            // CmbLabelType
            // 
            CmbLabelType.Anchor = AnchorStyles.Left;
            CmbLabelType.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbLabelType.Enabled = false;
            CmbLabelType.FormattingEnabled = true;
            CmbLabelType.Items.AddRange(new object[] { "2 - Label" });
            CmbLabelType.Location = new Point(135, 435);
            CmbLabelType.Margin = new Padding(2);
            CmbLabelType.Name = "CmbLabelType";
            CmbLabelType.Size = new Size(120, 27);
            CmbLabelType.TabIndex = 16;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(3, 386);
            label3.Name = "label3";
            label3.Size = new Size(127, 38);
            label3.TabIndex = 13;
            label3.Text = "Label Print Count";
            // 
            // TxtPrintCount
            // 
            TxtPrintCount.Anchor = AnchorStyles.Left;
            TxtPrintCount.BackColor = Color.WhiteSmoke;
            TxtPrintCount.ForeColor = Color.ForestGreen;
            TxtPrintCount.Location = new Point(133, 391);
            TxtPrintCount.Margin = new Padding(0);
            TxtPrintCount.MaxLength = 2;
            TxtPrintCount.Name = "TxtPrintCount";
            TxtPrintCount.Size = new Size(48, 27);
            TxtPrintCount.TabIndex = 14;
            TxtPrintCount.TextAlign = HorizontalAlignment.Right;
            TxtPrintCount.Enter += TextBox_Enter;
            TxtPrintCount.KeyDown += TxtPrintCount_KeyDown;
            TxtPrintCount.KeyPress += Number_KeyPress;
            TxtPrintCount.Leave += TextBox_Leave;
            // 
            // ErrorProvider
            // 
            ErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            ErrorProvider.ContainerControl = this;
            // 
            // FrmTagPrint
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1199, 590);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(0, 64, 64);
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmTagPrint";
            Text = "Tag Print";
            Activated += FrmTagPrint_Activated;
            Load += FrmTagPrint_Load;
            KeyDown += FrmTagPrint_KeyDown;
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
        private TextBox TxtProductSearch;
        private DataGridView DgvProductSearch;
        private Button BtnPrint;
        private Button BtnExit;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel6;
        private ErrorProvider ErrorProvider;
        private Label label6;
        private Label label7;
        private TextBox TxtProductName;
        private TextBox TxtProductTamilName;
        private Label label5;
        private ComboBox CmbLabelType;
        private TableLayoutPanel tableLayoutPanel3;
        private Button BtnClear;
        private Label LblSellingRate;
        private Label LblMrp;
        private TextBox TxtSellingRate;
        private TextBox TxtMrp;
        private Label label2;
        private TextBox TxtBarcode;
        private Label label3;
        private TextBox TxtPrintCount;
    }
}