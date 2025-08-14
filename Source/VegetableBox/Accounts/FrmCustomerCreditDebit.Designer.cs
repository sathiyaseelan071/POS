namespace VegetableBox
{
    partial class FrmCustomerCreditDebit
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            DGView = new DataGridView();
            PanelFilter = new Panel();
            tableLayoutPanel8 = new TableLayoutPanel();
            LblFilterCatType = new Label();
            CmbFilterTransactionType = new ComboBox();
            LblFilters = new Label();
            LblFilterProduct = new Label();
            TxtFilterCustomer = new TextBox();
            ChkFltrApplyDate = new CheckBox();
            LblFltrFromDate = new Label();
            DtpFltrFromDate = new DateTimePicker();
            LblFltrToDate = new Label();
            DtpFltrToDate = new DateTimePicker();
            ChkSearchLike = new CheckBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            BtnEdit = new Button();
            BtnExit = new Button();
            LblTotalPendingAmt = new Label();
            label3 = new Label();
            label11 = new Label();
            LblTotalDebitAmt = new Label();
            label10 = new Label();
            LblTotalCreditAmt = new Label();
            label9 = new Label();
            tableLayoutPanel6 = new TableLayoutPanel();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            BtnCancel = new Button();
            BtnSave = new Button();
            tableLayoutPanel7 = new TableLayoutPanel();
            CmbCustomerName = new ComboBox();
            BtnAddCustomerMaster = new Button();
            CmbTransactionType = new ComboBox();
            label7 = new Label();
            TxtBillNo = new TextBox();
            label4 = new Label();
            TxtAmount = new TextBox();
            label8 = new Label();
            DtpBillDate = new DateTimePicker();
            label5 = new Label();
            TxtRemarks = new TextBox();
            label6 = new Label();
            label2 = new Label();
            CmbPaymentType = new ComboBox();
            ErrorProvider = new ErrorProvider(components);
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGView).BeginInit();
            PanelFilter.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.31241F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.68759F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel6, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1402, 654);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(DGView, 0, 1);
            tableLayoutPanel4.Controls.Add(PanelFilter, 0, 0);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 3);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(442, 2);
            tableLayoutPanel4.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 5;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 19.8374882F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 59.5124664F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 7.09815931F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 8.592508F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 4.959372F));
            tableLayoutPanel4.Size = new Size(957, 650);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // DGView
            // 
            DGView.AllowUserToAddRows = false;
            DGView.AllowUserToDeleteRows = false;
            DGView.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.IndianRed;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.SelectionForeColor = Color.IndianRed;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DGView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DGView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel4.SetColumnSpan(DGView, 2);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(0, 64, 64);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.SelectionForeColor = Color.ForestGreen;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DGView.DefaultCellStyle = dataGridViewCellStyle2;
            DGView.Dock = DockStyle.Fill;
            DGView.Location = new Point(3, 130);
            DGView.Margin = new Padding(3, 2, 3, 2);
            DGView.MultiSelect = false;
            DGView.Name = "DGView";
            DGView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Maroon;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            DGView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            DGView.RowHeadersVisible = false;
            tableLayoutPanel4.SetRowSpan(DGView, 2);
            DGView.RowTemplate.Height = 25;
            DGView.Size = new Size(951, 428);
            DGView.TabIndex = 0;
            DGView.CellEnter += DGView_CellEnter;
            // 
            // PanelFilter
            // 
            PanelFilter.BorderStyle = BorderStyle.FixedSingle;
            PanelFilter.Controls.Add(tableLayoutPanel8);
            PanelFilter.Dock = DockStyle.Fill;
            PanelFilter.Location = new Point(3, 2);
            PanelFilter.Margin = new Padding(3, 2, 3, 2);
            PanelFilter.Name = "PanelFilter";
            PanelFilter.Size = new Size(951, 124);
            PanelFilter.TabIndex = 1;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 10;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.43F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.16F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.16F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.32F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.16F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.17F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.16F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.17F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.16F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.11F));
            tableLayoutPanel8.Controls.Add(LblFilterCatType, 1, 1);
            tableLayoutPanel8.Controls.Add(CmbFilterTransactionType, 2, 1);
            tableLayoutPanel8.Controls.Add(LblFilters, 0, 0);
            tableLayoutPanel8.Controls.Add(LblFilterProduct, 1, 2);
            tableLayoutPanel8.Controls.Add(TxtFilterCustomer, 2, 2);
            tableLayoutPanel8.Controls.Add(ChkFltrApplyDate, 4, 1);
            tableLayoutPanel8.Controls.Add(LblFltrFromDate, 5, 1);
            tableLayoutPanel8.Controls.Add(DtpFltrFromDate, 6, 1);
            tableLayoutPanel8.Controls.Add(LblFltrToDate, 7, 1);
            tableLayoutPanel8.Controls.Add(DtpFltrToDate, 8, 1);
            tableLayoutPanel8.Controls.Add(ChkSearchLike, 1, 3);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(0, 0);
            tableLayoutPanel8.Margin = new Padding(2);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 4;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel8.Size = new Size(949, 122);
            tableLayoutPanel8.TabIndex = 0;
            // 
            // LblFilterCatType
            // 
            LblFilterCatType.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblFilterCatType.AutoSize = true;
            LblFilterCatType.ForeColor = Color.FromArgb(163, 0, 34);
            LblFilterCatType.Location = new Point(25, 42);
            LblFilterCatType.Margin = new Padding(2, 0, 2, 0);
            LblFilterCatType.Name = "LblFilterCatType";
            LblFilterCatType.Size = new Size(111, 18);
            LblFilterCatType.TabIndex = 1;
            LblFilterCatType.Text = "Transaction Type";
            // 
            // CmbFilterTransactionType
            // 
            CmbFilterTransactionType.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CmbFilterTransactionType.BackColor = Color.White;
            CmbFilterTransactionType.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbFilterTransactionType.ForeColor = Color.DarkGreen;
            CmbFilterTransactionType.FormattingEnabled = true;
            CmbFilterTransactionType.Location = new Point(140, 39);
            CmbFilterTransactionType.Margin = new Padding(2);
            CmbFilterTransactionType.Name = "CmbFilterTransactionType";
            CmbFilterTransactionType.Size = new Size(111, 26);
            CmbFilterTransactionType.TabIndex = 2;
            CmbFilterTransactionType.SelectedIndexChanged += CmbFilterTransactionType_SelectedIndexChanged;
            CmbFilterTransactionType.Enter += ComboBox_Enter;
            // 
            // LblFilters
            // 
            LblFilters.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            LblFilters.AutoSize = true;
            tableLayoutPanel8.SetColumnSpan(LblFilters, 2);
            LblFilters.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            LblFilters.ForeColor = Color.DarkGreen;
            LblFilters.Location = new Point(2, 17);
            LblFilters.Margin = new Padding(2, 0, 2, 0);
            LblFilters.Name = "LblFilters";
            LblFilters.Size = new Size(50, 19);
            LblFilters.TabIndex = 0;
            LblFilters.Text = "Filters";
            // 
            // LblFilterProduct
            // 
            LblFilterProduct.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblFilterProduct.AutoSize = true;
            LblFilterProduct.ForeColor = Color.FromArgb(163, 0, 34);
            LblFilterProduct.Location = new Point(25, 66);
            LblFilterProduct.Margin = new Padding(2, 0, 2, 0);
            LblFilterProduct.Name = "LblFilterProduct";
            LblFilterProduct.Size = new Size(111, 30);
            LblFilterProduct.TabIndex = 3;
            LblFilterProduct.Text = "Customer Search";
            // 
            // TxtFilterCustomer
            // 
            TxtFilterCustomer.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtFilterCustomer.BackColor = Color.White;
            tableLayoutPanel8.SetColumnSpan(TxtFilterCustomer, 3);
            TxtFilterCustomer.ForeColor = Color.DarkGreen;
            TxtFilterCustomer.Location = new Point(140, 68);
            TxtFilterCustomer.Margin = new Padding(2);
            TxtFilterCustomer.MaxLength = 25;
            TxtFilterCustomer.Name = "TxtFilterCustomer";
            TxtFilterCustomer.Size = new Size(371, 26);
            TxtFilterCustomer.TabIndex = 4;
            TxtFilterCustomer.TextChanged += TxtFilterCustomer_TextChanged;
            TxtFilterCustomer.Enter += TextBox_Enter;
            TxtFilterCustomer.Leave += TextBox_Leave;
            // 
            // ChkFltrApplyDate
            // 
            ChkFltrApplyDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ChkFltrApplyDate.AutoSize = true;
            ChkFltrApplyDate.CheckAlign = ContentAlignment.MiddleRight;
            ChkFltrApplyDate.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ChkFltrApplyDate.ForeColor = Color.Maroon;
            ChkFltrApplyDate.Location = new Point(401, 39);
            ChkFltrApplyDate.Margin = new Padding(3, 2, 3, 2);
            ChkFltrApplyDate.Name = "ChkFltrApplyDate";
            ChkFltrApplyDate.Size = new Size(109, 23);
            ChkFltrApplyDate.TabIndex = 5;
            ChkFltrApplyDate.Text = "Apply Date Filter";
            ChkFltrApplyDate.TextAlign = ContentAlignment.MiddleRight;
            ChkFltrApplyDate.UseVisualStyleBackColor = false;
            ChkFltrApplyDate.CheckedChanged += ChkFltrApplyDate_CheckedChanged;
            // 
            // LblFltrFromDate
            // 
            LblFltrFromDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblFltrFromDate.AutoSize = true;
            LblFltrFromDate.ForeColor = Color.FromArgb(163, 0, 34);
            LblFltrFromDate.Location = new Point(515, 42);
            LblFltrFromDate.Margin = new Padding(2, 0, 2, 0);
            LblFltrFromDate.Name = "LblFltrFromDate";
            LblFltrFromDate.Size = new Size(73, 18);
            LblFltrFromDate.TabIndex = 6;
            LblFltrFromDate.Text = "From";
            LblFltrFromDate.TextAlign = ContentAlignment.MiddleRight;
            // 
            // DtpFltrFromDate
            // 
            DtpFltrFromDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            DtpFltrFromDate.CalendarFont = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            DtpFltrFromDate.CustomFormat = "dd-MMM-yyyy";
            DtpFltrFromDate.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            DtpFltrFromDate.Format = DateTimePickerFormat.Custom;
            DtpFltrFromDate.Location = new Point(593, 39);
            DtpFltrFromDate.Margin = new Padding(3, 2, 3, 2);
            DtpFltrFromDate.Name = "DtpFltrFromDate";
            DtpFltrFromDate.Size = new Size(109, 23);
            DtpFltrFromDate.TabIndex = 7;
            DtpFltrFromDate.ValueChanged += DtpFltrFromDate_ValueChanged;
            // 
            // LblFltrToDate
            // 
            LblFltrToDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblFltrToDate.AutoSize = true;
            LblFltrToDate.ForeColor = Color.FromArgb(163, 0, 34);
            LblFltrToDate.Location = new Point(707, 42);
            LblFltrToDate.Margin = new Padding(2, 0, 2, 0);
            LblFltrToDate.Name = "LblFltrToDate";
            LblFltrToDate.Size = new Size(73, 18);
            LblFltrToDate.TabIndex = 8;
            LblFltrToDate.Text = "To";
            LblFltrToDate.TextAlign = ContentAlignment.MiddleRight;
            // 
            // DtpFltrToDate
            // 
            DtpFltrToDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            DtpFltrToDate.CalendarFont = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            DtpFltrToDate.CustomFormat = "dd-MMM-yyyy";
            DtpFltrToDate.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            DtpFltrToDate.Format = DateTimePickerFormat.Custom;
            DtpFltrToDate.Location = new Point(785, 39);
            DtpFltrToDate.Margin = new Padding(3, 2, 3, 2);
            DtpFltrToDate.Name = "DtpFltrToDate";
            DtpFltrToDate.Size = new Size(109, 23);
            DtpFltrToDate.TabIndex = 9;
            DtpFltrToDate.ValueChanged += DtpFltrToDate_ValueChanged;
            // 
            // ChkSearchLike
            // 
            ChkSearchLike.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ChkSearchLike.AutoSize = true;
            ChkSearchLike.Checked = true;
            ChkSearchLike.CheckState = CheckState.Checked;
            ChkSearchLike.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ChkSearchLike.ForeColor = Color.Maroon;
            ChkSearchLike.Location = new Point(26, 99);
            ChkSearchLike.Margin = new Padding(3, 2, 3, 2);
            ChkSearchLike.Name = "ChkSearchLike";
            ChkSearchLike.Size = new Size(109, 19);
            ChkSearchLike.TabIndex = 11;
            ChkSearchLike.Text = "Like Search";
            ChkSearchLike.UseVisualStyleBackColor = true;
            ChkSearchLike.CheckedChanged += ChkSearchLike_CheckedChanged;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 9;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666641F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel5.Controls.Add(BtnEdit, 7, 0);
            tableLayoutPanel5.Controls.Add(BtnExit, 8, 0);
            tableLayoutPanel5.Controls.Add(LblTotalPendingAmt, 6, 0);
            tableLayoutPanel5.Controls.Add(label3, 0, 0);
            tableLayoutPanel5.Controls.Add(label11, 5, 0);
            tableLayoutPanel5.Controls.Add(LblTotalDebitAmt, 4, 0);
            tableLayoutPanel5.Controls.Add(label10, 3, 0);
            tableLayoutPanel5.Controls.Add(LblTotalCreditAmt, 2, 0);
            tableLayoutPanel5.Controls.Add(label9, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 562);
            tableLayoutPanel5.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(951, 51);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // BtnEdit
            // 
            BtnEdit.Dock = DockStyle.Fill;
            BtnEdit.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            BtnEdit.ForeColor = Color.Maroon;
            BtnEdit.Location = new Point(779, 2);
            BtnEdit.Margin = new Padding(3, 2, 3, 2);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(80, 47);
            BtnEdit.TabIndex = 7;
            BtnEdit.Text = "&Edit";
            BtnEdit.UseVisualStyleBackColor = false;
            BtnEdit.Click += BtnEdit_Click;
            // 
            // BtnExit
            // 
            BtnExit.Dock = DockStyle.Fill;
            BtnExit.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            BtnExit.ForeColor = Color.Crimson;
            BtnExit.Location = new Point(865, 2);
            BtnExit.Margin = new Padding(3, 2, 3, 2);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(83, 47);
            BtnExit.TabIndex = 8;
            BtnExit.Text = "E&xit";
            BtnExit.UseVisualStyleBackColor = false;
            BtnExit.Click += BtnExit_Click;
            // 
            // LblTotalPendingAmt
            // 
            LblTotalPendingAmt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblTotalPendingAmt.AutoSize = true;
            LblTotalPendingAmt.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblTotalPendingAmt.ForeColor = Color.Crimson;
            LblTotalPendingAmt.Location = new Point(692, 14);
            LblTotalPendingAmt.Margin = new Padding(2, 0, 2, 0);
            LblTotalPendingAmt.Name = "LblTotalPendingAmt";
            LblTotalPendingAmt.Size = new Size(82, 23);
            LblTotalPendingAmt.TabIndex = 6;
            LblTotalPendingAmt.Text = "...";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Maroon;
            label3.Location = new Point(2, 14);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(82, 23);
            label3.TabIndex = 0;
            label3.Text = "Total =>";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(605, 14);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(83, 23);
            label11.TabIndex = 5;
            label11.Text = "Pending :";
            // 
            // LblTotalDebitAmt
            // 
            LblTotalDebitAmt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblTotalDebitAmt.AutoSize = true;
            LblTotalDebitAmt.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblTotalDebitAmt.ForeColor = Color.Crimson;
            LblTotalDebitAmt.Location = new Point(519, 14);
            LblTotalDebitAmt.Margin = new Padding(2, 0, 2, 0);
            LblTotalDebitAmt.Name = "LblTotalDebitAmt";
            LblTotalDebitAmt.Size = new Size(82, 23);
            LblTotalDebitAmt.TabIndex = 4;
            LblTotalDebitAmt.Text = "...";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(349, 14);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(166, 23);
            label10.TabIndex = 3;
            label10.Text = "Payment Recieved :";
            // 
            // LblTotalCreditAmt
            // 
            LblTotalCreditAmt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblTotalCreditAmt.AutoSize = true;
            LblTotalCreditAmt.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblTotalCreditAmt.ForeColor = Color.Crimson;
            LblTotalCreditAmt.Location = new Point(263, 14);
            LblTotalCreditAmt.Margin = new Padding(2, 0, 2, 0);
            LblTotalCreditAmt.Name = "LblTotalCreditAmt";
            LblTotalCreditAmt.Size = new Size(82, 23);
            LblTotalCreditAmt.TabIndex = 2;
            LblTotalCreditAmt.Text = "...";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(88, 14);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(171, 23);
            label9.TabIndex = 1;
            label9.Text = "Purchase On Credit :";
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
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 66.3063049F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 13.6936941F));
            tableLayoutPanel6.Size = new Size(433, 650);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 132);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(3, 2, 3, 2);
            panel1.Size = new Size(427, 426);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(label1, 0, 2);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 1, 11);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel7, 1, 2);
            tableLayoutPanel2.Controls.Add(CmbTransactionType, 1, 3);
            tableLayoutPanel2.Controls.Add(label7, 0, 4);
            tableLayoutPanel2.Controls.Add(TxtBillNo, 1, 4);
            tableLayoutPanel2.Controls.Add(label4, 0, 6);
            tableLayoutPanel2.Controls.Add(TxtAmount, 1, 6);
            tableLayoutPanel2.Controls.Add(label8, 0, 5);
            tableLayoutPanel2.Controls.Add(DtpBillDate, 1, 5);
            tableLayoutPanel2.Controls.Add(label5, 0, 8);
            tableLayoutPanel2.Controls.Add(TxtRemarks, 1, 8);
            tableLayoutPanel2.Controls.Add(label6, 0, 3);
            tableLayoutPanel2.Controls.Add(label2, 0, 7);
            tableLayoutPanel2.Controls.Add(CmbPaymentType, 1, 7);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 2);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 13;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 0.040192917F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 9.083601F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 9.083601F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 9.083601F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 9.083601F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 9.083601F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 9.083601F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 9.083601F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 9.083601F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 9.083601F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 9.083601F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 9.083601F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 0.040192917F));
            tableLayoutPanel2.Size = new Size(419, 420);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(163, 0, 34);
            label1.Location = new Point(3, 48);
            label1.Name = "label1";
            label1.Size = new Size(118, 18);
            label1.TabIndex = 0;
            label1.Text = "Customer Name*";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.5686283F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39.2156868F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39.2156868F));
            tableLayoutPanel3.Controls.Add(BtnCancel, 2, 0);
            tableLayoutPanel3.Controls.Add(BtnSave, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(124, 380);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(295, 38);
            tableLayoutPanel3.TabIndex = 14;
            // 
            // BtnCancel
            // 
            BtnCancel.Dock = DockStyle.Fill;
            BtnCancel.ForeColor = Color.Crimson;
            BtnCancel.Location = new Point(181, 2);
            BtnCancel.Margin = new Padding(3, 2, 3, 2);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(111, 34);
            BtnCancel.TabIndex = 1;
            BtnCancel.Text = "&Cancel";
            BtnCancel.UseVisualStyleBackColor = false;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // BtnSave
            // 
            BtnSave.Dock = DockStyle.Fill;
            BtnSave.ForeColor = Color.DarkGreen;
            BtnSave.Location = new Point(66, 2);
            BtnSave.Margin = new Padding(3, 2, 3, 2);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(109, 34);
            BtnSave.TabIndex = 0;
            BtnSave.Text = "&Save";
            BtnSave.UseVisualStyleBackColor = false;
            BtnSave.Click += BtnSave_Click;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 81.3559341F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.6440678F));
            tableLayoutPanel7.Controls.Add(CmbCustomerName, 0, 0);
            tableLayoutPanel7.Controls.Add(BtnAddCustomerMaster, 1, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(124, 38);
            tableLayoutPanel7.Margin = new Padding(0);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Size = new Size(295, 38);
            tableLayoutPanel7.TabIndex = 1;
            // 
            // CmbCustomerName
            // 
            CmbCustomerName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CmbCustomerName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CmbCustomerName.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbCustomerName.FormattingEnabled = true;
            CmbCustomerName.Location = new Point(2, 7);
            CmbCustomerName.Margin = new Padding(2);
            CmbCustomerName.Name = "CmbCustomerName";
            CmbCustomerName.Size = new Size(236, 26);
            CmbCustomerName.TabIndex = 0;
            // 
            // BtnAddCustomerMaster
            // 
            BtnAddCustomerMaster.Dock = DockStyle.Fill;
            BtnAddCustomerMaster.Font = new Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnAddCustomerMaster.ForeColor = Color.DarkGreen;
            BtnAddCustomerMaster.Location = new Point(240, 2);
            BtnAddCustomerMaster.Margin = new Padding(0, 2, 0, 2);
            BtnAddCustomerMaster.Name = "BtnAddCustomerMaster";
            BtnAddCustomerMaster.Size = new Size(55, 34);
            BtnAddCustomerMaster.TabIndex = 1;
            BtnAddCustomerMaster.Text = "&Add Customer";
            BtnAddCustomerMaster.UseVisualStyleBackColor = true;
            BtnAddCustomerMaster.Click += BtnAddCreditDebitMaster_Click;
            // 
            // CmbTransactionType
            // 
            CmbTransactionType.Anchor = AnchorStyles.Left;
            CmbTransactionType.BackColor = Color.White;
            CmbTransactionType.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbTransactionType.ForeColor = Color.DarkGreen;
            CmbTransactionType.FormattingEnabled = true;
            CmbTransactionType.Location = new Point(126, 83);
            CmbTransactionType.Margin = new Padding(2);
            CmbTransactionType.Name = "CmbTransactionType";
            CmbTransactionType.Size = new Size(151, 26);
            CmbTransactionType.TabIndex = 3;
            CmbTransactionType.SelectedValueChanged += CmbTransactionType_SelectedValueChanged;
            CmbTransactionType.Enter += ComboBox_Enter;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.ForeColor = Color.FromArgb(163, 0, 34);
            label7.Location = new Point(3, 124);
            label7.Name = "label7";
            label7.Size = new Size(118, 18);
            label7.TabIndex = 4;
            label7.Text = "Bill No*";
            // 
            // TxtBillNo
            // 
            TxtBillNo.Anchor = AnchorStyles.Left;
            TxtBillNo.BackColor = Color.WhiteSmoke;
            TxtBillNo.ForeColor = Color.ForestGreen;
            TxtBillNo.Location = new Point(127, 120);
            TxtBillNo.Margin = new Padding(3, 2, 3, 2);
            TxtBillNo.MaxLength = 10;
            TxtBillNo.Name = "TxtBillNo";
            TxtBillNo.Size = new Size(150, 26);
            TxtBillNo.TabIndex = 5;
            TxtBillNo.TextAlign = HorizontalAlignment.Right;
            TxtBillNo.Enter += TextBox_Enter;
            TxtBillNo.KeyPress += Decimal_KeyPress;
            TxtBillNo.Leave += TextBox_Leave;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(163, 0, 34);
            label4.Location = new Point(3, 200);
            label4.Name = "label4";
            label4.Size = new Size(118, 18);
            label4.TabIndex = 8;
            label4.Text = "Amount*";
            // 
            // TxtAmount
            // 
            TxtAmount.Anchor = AnchorStyles.Left;
            TxtAmount.BackColor = Color.WhiteSmoke;
            TxtAmount.ForeColor = Color.ForestGreen;
            TxtAmount.Location = new Point(127, 196);
            TxtAmount.Margin = new Padding(3, 2, 3, 2);
            TxtAmount.MaxLength = 13;
            TxtAmount.Name = "TxtAmount";
            TxtAmount.Size = new Size(150, 26);
            TxtAmount.TabIndex = 9;
            TxtAmount.TextAlign = HorizontalAlignment.Right;
            TxtAmount.Enter += TextBox_Enter;
            TxtAmount.KeyPress += Decimal_KeyPress;
            TxtAmount.Leave += TextBox_Leave;
            TxtAmount.Validated += TxtAmount_Validated;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.ForeColor = Color.FromArgb(163, 0, 34);
            label8.Location = new Point(3, 162);
            label8.Name = "label8";
            label8.Size = new Size(118, 18);
            label8.TabIndex = 6;
            label8.Text = "Bill Date*";
            // 
            // DtpBillDate
            // 
            DtpBillDate.Anchor = AnchorStyles.Left;
            DtpBillDate.CustomFormat = "dd-MMM-yyyy";
            DtpBillDate.Format = DateTimePickerFormat.Custom;
            DtpBillDate.Location = new Point(127, 158);
            DtpBillDate.Margin = new Padding(3, 2, 3, 2);
            DtpBillDate.Name = "DtpBillDate";
            DtpBillDate.Size = new Size(150, 26);
            DtpBillDate.TabIndex = 7;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(163, 0, 34);
            label5.Location = new Point(3, 276);
            label5.Name = "label5";
            label5.Size = new Size(118, 18);
            label5.TabIndex = 12;
            label5.Text = "Remarks";
            // 
            // TxtRemarks
            // 
            TxtRemarks.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtRemarks.BackColor = Color.WhiteSmoke;
            TxtRemarks.ForeColor = Color.ForestGreen;
            TxtRemarks.Location = new Point(127, 272);
            TxtRemarks.Margin = new Padding(3, 2, 3, 2);
            TxtRemarks.MaxLength = 50;
            TxtRemarks.Name = "TxtRemarks";
            TxtRemarks.Size = new Size(289, 26);
            TxtRemarks.TabIndex = 13;
            TxtRemarks.Enter += TextBox_Enter;
            TxtRemarks.Leave += TextBox_Leave;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(163, 0, 34);
            label6.Location = new Point(3, 86);
            label6.Name = "label6";
            label6.Size = new Size(118, 18);
            label6.TabIndex = 2;
            label6.Text = "Transaction Type*";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(163, 0, 34);
            label2.Location = new Point(3, 238);
            label2.Name = "label2";
            label2.Size = new Size(118, 18);
            label2.TabIndex = 10;
            label2.Text = "Payment Type*";
            // 
            // CmbPaymentType
            // 
            CmbPaymentType.Anchor = AnchorStyles.Left;
            CmbPaymentType.BackColor = Color.White;
            CmbPaymentType.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbPaymentType.ForeColor = Color.DarkGreen;
            CmbPaymentType.FormattingEnabled = true;
            CmbPaymentType.Location = new Point(126, 235);
            CmbPaymentType.Margin = new Padding(2);
            CmbPaymentType.Name = "CmbPaymentType";
            CmbPaymentType.Size = new Size(151, 26);
            CmbPaymentType.TabIndex = 11;
            CmbPaymentType.Enter += ComboBox_Enter;
            // 
            // ErrorProvider
            // 
            ErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            ErrorProvider.ContainerControl = this;
            // 
            // FrmCustomerCreditDebit
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1402, 654);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(0, 64, 64);
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmCustomerCreditDebit";
            Text = "Customer (Credit/Debit)";
            Activated += FrmCustomerCreditDebit_Activated;
            Load += FrmCustomerCreditDebit_Load;
            KeyDown += FrmCustomerCreditDebit_KeyDown;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGView).EndInit();
            PanelFilter.ResumeLayout(false);
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ErrorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Label label4;
        private TextBox TxtAmount;
        private TableLayoutPanel tableLayoutPanel3;
        private Button BtnSave;
        private Button BtnCancel;
        private TableLayoutPanel tableLayoutPanel4;
        private DataGridView DGView;
        private TableLayoutPanel tableLayoutPanel5;
        private Button BtnEdit;
        private Button BtnExit;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel6;
        private ErrorProvider ErrorProvider;
        private Label label3;
        private Label LblTotalPendingAmt;
        private ComboBox CmbCustomerName;
        private Label label5;
        private TextBox TxtRemarks;
        private TableLayoutPanel tableLayoutPanel7;
        private Button BtnAddCustomerMaster;
        private Label label6;
        private ComboBox CmbTransactionType;
        private Label label7;
        private TextBox TxtBillNo;
        private Label label8;
        private DateTimePicker DtpBillDate;
        private TableLayoutPanel tableLayoutPanel8;
        private Label LblFilterCatType;
        private ComboBox CmbFilterTransactionType;
        private Label LblFilters;
        private Label LblFilterProduct;
        private TextBox TxtFilterCustomer;
        private Panel PanelFilter;
        private Label label2;
        private ComboBox CmbPaymentType;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label LblTotalDebitAmt;
        private Label LblTotalCreditAmt;
        private CheckBox ChkFltrApplyDate;
        private Label LblFltrFromDate;
        private DateTimePicker DtpFltrFromDate;
        private Label LblFltrToDate;
        private DateTimePicker DtpFltrToDate;
        private CheckBox ChkSearchLike;
    }
}