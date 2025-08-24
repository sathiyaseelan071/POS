namespace VegetableBox
{
    partial class FrmVendorPayment
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            DGView = new DataGridView();
            PanelFilter = new Panel();
            tableLayoutPanel8 = new TableLayoutPanel();
            LblFilters = new Label();
            ChkFltrApplyDate = new CheckBox();
            LblFltrFromDate = new Label();
            DtpFltrFromDate = new DateTimePicker();
            LblFltrToDate = new Label();
            DtpFltrToDate = new DateTimePicker();
            TxtFilterVendorSearch = new TextBox();
            LblFilterVendor = new Label();
            ChkSearchLike = new CheckBox();
            LblFilterTranType = new Label();
            CmbFilterTransactionType = new ComboBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            BtnEdit = new Button();
            BtnExit = new Button();
            label3 = new Label();
            label11 = new Label();
            LblTotalPayment = new Label();
            tableLayoutPanel6 = new TableLayoutPanel();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            BtnCancel = new Button();
            BtnSave = new Button();
            label1 = new Label();
            CmbVendorName = new ComboBox();
            label7 = new Label();
            TxtBillNo = new TextBox();
            label8 = new Label();
            DtpBillDate = new DateTimePicker();
            label12 = new Label();
            label4 = new Label();
            label13 = new Label();
            label14 = new Label();
            label2 = new Label();
            CmbPaymentType = new ComboBox();
            label6 = new Label();
            CmbTransactionType = new ComboBox();
            label5 = new Label();
            TxtRemarks = new TextBox();
            TxtTotalBillAmount = new TextBox();
            TxtPaidTillNow = new TextBox();
            TxtPendingAmount = new TextBox();
            TxtCurrentPayment = new TextBox();
            DgvVendorInvoiceDetails = new DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)DgvVendorInvoiceDetails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
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
            tableLayoutPanel4.Location = new Point(423, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 5;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 19.8374882F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 59.5124664F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 7.09815931F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 8.592508F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 4.959372F));
            tableLayoutPanel4.Size = new Size(976, 648);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // DGView
            // 
            DGView.AllowUserToAddRows = false;
            DGView.AllowUserToDeleteRows = false;
            DGView.AllowUserToResizeRows = false;
            DGView.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.IndianRed;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.SelectionForeColor = Color.IndianRed;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DGView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DGView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(0, 64, 64);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.SelectionForeColor = Color.ForestGreen;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DGView.DefaultCellStyle = dataGridViewCellStyle2;
            DGView.Dock = DockStyle.Fill;
            DGView.Location = new Point(3, 131);
            DGView.MultiSelect = false;
            DGView.Name = "DGView";
            DGView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Maroon;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            DGView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            DGView.RowHeadersVisible = false;
            DGView.RowTemplate.Height = 25;
            DGView.Size = new Size(970, 379);
            DGView.TabIndex = 0;
            DGView.CellEnter += DGView_CellEnter;
            // 
            // PanelFilter
            // 
            PanelFilter.BorderStyle = BorderStyle.FixedSingle;
            PanelFilter.Controls.Add(tableLayoutPanel8);
            PanelFilter.Dock = DockStyle.Fill;
            PanelFilter.Location = new Point(3, 3);
            PanelFilter.Name = "PanelFilter";
            PanelFilter.Size = new Size(970, 122);
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
            tableLayoutPanel8.Controls.Add(LblFilters, 0, 0);
            tableLayoutPanel8.Controls.Add(ChkFltrApplyDate, 4, 1);
            tableLayoutPanel8.Controls.Add(LblFltrFromDate, 5, 1);
            tableLayoutPanel8.Controls.Add(DtpFltrFromDate, 6, 1);
            tableLayoutPanel8.Controls.Add(LblFltrToDate, 7, 1);
            tableLayoutPanel8.Controls.Add(DtpFltrToDate, 8, 1);
            tableLayoutPanel8.Controls.Add(TxtFilterVendorSearch, 2, 1);
            tableLayoutPanel8.Controls.Add(LblFilterVendor, 1, 1);
            tableLayoutPanel8.Controls.Add(ChkSearchLike, 1, 2);
            tableLayoutPanel8.Controls.Add(LblFilterTranType, 3, 2);
            tableLayoutPanel8.Controls.Add(CmbFilterTransactionType, 4, 2);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(0, 0);
            tableLayoutPanel8.Margin = new Padding(2);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 4;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel8.Size = new Size(968, 120);
            tableLayoutPanel8.TabIndex = 0;
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
            // ChkFltrApplyDate
            // 
            ChkFltrApplyDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ChkFltrApplyDate.AutoSize = true;
            ChkFltrApplyDate.CheckAlign = ContentAlignment.MiddleRight;
            ChkFltrApplyDate.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ChkFltrApplyDate.ForeColor = Color.Maroon;
            ChkFltrApplyDate.Location = new Point(408, 39);
            ChkFltrApplyDate.Name = "ChkFltrApplyDate";
            ChkFltrApplyDate.Size = new Size(111, 23);
            ChkFltrApplyDate.TabIndex = 3;
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
            LblFltrFromDate.Location = new Point(524, 42);
            LblFltrFromDate.Margin = new Padding(2, 0, 2, 0);
            LblFltrFromDate.Name = "LblFltrFromDate";
            LblFltrFromDate.Size = new Size(75, 18);
            LblFltrFromDate.TabIndex = 4;
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
            DtpFltrFromDate.Location = new Point(604, 39);
            DtpFltrFromDate.Name = "DtpFltrFromDate";
            DtpFltrFromDate.Size = new Size(111, 23);
            DtpFltrFromDate.TabIndex = 5;
            DtpFltrFromDate.ValueChanged += DtpFltrFromDate_ValueChanged;
            // 
            // LblFltrToDate
            // 
            LblFltrToDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblFltrToDate.AutoSize = true;
            LblFltrToDate.ForeColor = Color.FromArgb(163, 0, 34);
            LblFltrToDate.Location = new Point(720, 42);
            LblFltrToDate.Margin = new Padding(2, 0, 2, 0);
            LblFltrToDate.Name = "LblFltrToDate";
            LblFltrToDate.Size = new Size(75, 18);
            LblFltrToDate.TabIndex = 6;
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
            DtpFltrToDate.Location = new Point(800, 39);
            DtpFltrToDate.Name = "DtpFltrToDate";
            DtpFltrToDate.Size = new Size(111, 23);
            DtpFltrToDate.TabIndex = 7;
            DtpFltrToDate.ValueChanged += DtpFltrToDate_ValueChanged;
            // 
            // TxtFilterVendorSearch
            // 
            TxtFilterVendorSearch.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtFilterVendorSearch.BackColor = Color.White;
            tableLayoutPanel8.SetColumnSpan(TxtFilterVendorSearch, 2);
            TxtFilterVendorSearch.ForeColor = Color.DarkGreen;
            TxtFilterVendorSearch.Location = new Point(142, 38);
            TxtFilterVendorSearch.Margin = new Padding(2);
            TxtFilterVendorSearch.MaxLength = 50;
            TxtFilterVendorSearch.Name = "TxtFilterVendorSearch";
            TxtFilterVendorSearch.Size = new Size(261, 26);
            TxtFilterVendorSearch.TabIndex = 2;
            TxtFilterVendorSearch.TextChanged += TxtFilterVendor_TextChanged;
            TxtFilterVendorSearch.Enter += TextBox_Enter;
            TxtFilterVendorSearch.Leave += TextBox_Leave;
            // 
            // LblFilterVendor
            // 
            LblFilterVendor.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblFilterVendor.AutoSize = true;
            LblFilterVendor.ForeColor = Color.FromArgb(163, 0, 34);
            LblFilterVendor.Location = new Point(25, 42);
            LblFilterVendor.Margin = new Padding(2, 0, 2, 0);
            LblFilterVendor.Name = "LblFilterVendor";
            LblFilterVendor.Size = new Size(113, 18);
            LblFilterVendor.TabIndex = 1;
            LblFilterVendor.Text = "Vendor Search";
            // 
            // ChkSearchLike
            // 
            ChkSearchLike.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ChkSearchLike.AutoSize = true;
            ChkSearchLike.Checked = true;
            ChkSearchLike.CheckState = CheckState.Checked;
            ChkSearchLike.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ChkSearchLike.ForeColor = Color.Maroon;
            ChkSearchLike.Location = new Point(26, 71);
            ChkSearchLike.Name = "ChkSearchLike";
            ChkSearchLike.Size = new Size(111, 19);
            ChkSearchLike.TabIndex = 8;
            ChkSearchLike.Text = "Like Search";
            ChkSearchLike.UseVisualStyleBackColor = true;
            ChkSearchLike.CheckedChanged += ChkSearchLike_CheckedChanged;
            // 
            // LblFilterTranType
            // 
            LblFilterTranType.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblFilterTranType.AutoSize = true;
            LblFilterTranType.Enabled = false;
            LblFilterTranType.ForeColor = Color.FromArgb(163, 0, 34);
            LblFilterTranType.Location = new Point(259, 72);
            LblFilterTranType.Margin = new Padding(2, 0, 2, 0);
            LblFilterTranType.Name = "LblFilterTranType";
            LblFilterTranType.Size = new Size(144, 18);
            LblFilterTranType.TabIndex = 9;
            LblFilterTranType.Text = "Transaction Type";
            // 
            // CmbFilterTransactionType
            // 
            CmbFilterTransactionType.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CmbFilterTransactionType.BackColor = Color.White;
            CmbFilterTransactionType.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbFilterTransactionType.Enabled = false;
            CmbFilterTransactionType.ForeColor = Color.DarkGreen;
            CmbFilterTransactionType.FormattingEnabled = true;
            CmbFilterTransactionType.Location = new Point(407, 69);
            CmbFilterTransactionType.Margin = new Padding(2);
            CmbFilterTransactionType.Name = "CmbFilterTransactionType";
            CmbFilterTransactionType.Size = new Size(113, 26);
            CmbFilterTransactionType.TabIndex = 10;
            CmbFilterTransactionType.SelectedIndexChanged += CmbFilterTransactionType_SelectedIndexChanged;
            CmbFilterTransactionType.Enter += ComboBox_Enter;
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
            tableLayoutPanel5.Controls.Add(label3, 0, 0);
            tableLayoutPanel5.Controls.Add(label11, 2, 0);
            tableLayoutPanel5.Controls.Add(LblTotalPayment, 4, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 561);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(970, 49);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // BtnEdit
            // 
            BtnEdit.Dock = DockStyle.Fill;
            BtnEdit.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            BtnEdit.ForeColor = Color.Maroon;
            BtnEdit.Location = new Point(647, 3);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(155, 43);
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
            BtnExit.Location = new Point(808, 3);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(159, 43);
            BtnExit.TabIndex = 8;
            BtnExit.Text = "E&xit";
            BtnExit.UseVisualStyleBackColor = false;
            BtnExit.Click += BtnExit_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Maroon;
            label3.Location = new Point(2, 13);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(157, 23);
            label3.TabIndex = 0;
            label3.Text = "Total =>";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(163, 13);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(157, 23);
            label11.TabIndex = 5;
            label11.Text = "Payment Done :";
            // 
            // LblTotalPayment
            // 
            LblTotalPayment.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblTotalPayment.AutoSize = true;
            LblTotalPayment.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblTotalPayment.ForeColor = Color.Crimson;
            LblTotalPayment.Location = new Point(324, 13);
            LblTotalPayment.Margin = new Padding(2, 0, 2, 0);
            LblTotalPayment.Name = "LblTotalPayment";
            LblTotalPayment.Size = new Size(157, 23);
            LblTotalPayment.TabIndex = 6;
            LblTotalPayment.Text = "...";
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
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 6.43274832F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 85.81871F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 7.748538F));
            tableLayoutPanel6.Size = new Size(414, 648);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 44);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(3);
            panel1.Size = new Size(408, 550);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.49519014F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 95.00962F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.49519014F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 2, 12);
            tableLayoutPanel2.Controls.Add(label1, 1, 1);
            tableLayoutPanel2.Controls.Add(CmbVendorName, 2, 1);
            tableLayoutPanel2.Controls.Add(label7, 1, 3);
            tableLayoutPanel2.Controls.Add(TxtBillNo, 2, 3);
            tableLayoutPanel2.Controls.Add(label8, 1, 4);
            tableLayoutPanel2.Controls.Add(DtpBillDate, 2, 4);
            tableLayoutPanel2.Controls.Add(label12, 1, 7);
            tableLayoutPanel2.Controls.Add(label4, 1, 5);
            tableLayoutPanel2.Controls.Add(label13, 1, 6);
            tableLayoutPanel2.Controls.Add(label14, 1, 8);
            tableLayoutPanel2.Controls.Add(label2, 1, 9);
            tableLayoutPanel2.Controls.Add(CmbPaymentType, 2, 9);
            tableLayoutPanel2.Controls.Add(label6, 1, 10);
            tableLayoutPanel2.Controls.Add(CmbTransactionType, 2, 10);
            tableLayoutPanel2.Controls.Add(label5, 1, 11);
            tableLayoutPanel2.Controls.Add(TxtRemarks, 2, 11);
            tableLayoutPanel2.Controls.Add(TxtTotalBillAmount, 2, 5);
            tableLayoutPanel2.Controls.Add(TxtPaidTillNow, 2, 6);
            tableLayoutPanel2.Controls.Add(TxtPendingAmount, 2, 7);
            tableLayoutPanel2.Controls.Add(TxtCurrentPayment, 2, 8);
            tableLayoutPanel2.Controls.Add(DgvVendorInvoiceDetails, 1, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 14;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 0.4720047F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7.288708F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 18.8801861F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7.288708F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7.288708F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7.288708F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7.288708F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7.288708F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7.288708F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7.288708F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7.288708F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7.288708F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7.288709F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 0.4720047F));
            tableLayoutPanel2.Size = new Size(400, 542);
            tableLayoutPanel2.TabIndex = 0;
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
            tableLayoutPanel3.Location = new Point(132, 494);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(260, 39);
            tableLayoutPanel3.TabIndex = 21;
            // 
            // BtnCancel
            // 
            BtnCancel.Dock = DockStyle.Fill;
            BtnCancel.ForeColor = Color.Crimson;
            BtnCancel.Location = new Point(160, 3);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(97, 33);
            BtnCancel.TabIndex = 1;
            BtnCancel.Text = "&Cancel";
            BtnCancel.UseVisualStyleBackColor = false;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // BtnSave
            // 
            BtnSave.Dock = DockStyle.Fill;
            BtnSave.ForeColor = Color.DarkGreen;
            BtnSave.Location = new Point(59, 3);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(95, 33);
            BtnSave.TabIndex = 0;
            BtnSave.Text = "&Save";
            BtnSave.UseVisualStyleBackColor = false;
            BtnSave.Click += BtnSave_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(163, 0, 34);
            label1.Location = new Point(9, 12);
            label1.Name = "label1";
            label1.Size = new Size(120, 18);
            label1.TabIndex = 0;
            label1.Text = "Vendor Name*";
            // 
            // CmbVendorName
            // 
            CmbVendorName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CmbVendorName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CmbVendorName.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbVendorName.FormattingEnabled = true;
            CmbVendorName.Location = new Point(134, 10);
            CmbVendorName.Margin = new Padding(2);
            CmbVendorName.Name = "CmbVendorName";
            CmbVendorName.Size = new Size(256, 26);
            CmbVendorName.TabIndex = 1;
            CmbVendorName.SelectedValueChanged += CmbVendorName_SelectedValueChanged;
            CmbVendorName.Validating += CmbVendorName_Validating;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.ForeColor = Color.FromArgb(163, 0, 34);
            label7.Location = new Point(9, 153);
            label7.Name = "label7";
            label7.Size = new Size(120, 18);
            label7.TabIndex = 3;
            label7.Text = "Bill No*";
            // 
            // TxtBillNo
            // 
            TxtBillNo.Anchor = AnchorStyles.Left;
            TxtBillNo.BackColor = Color.WhiteSmoke;
            TxtBillNo.ForeColor = Color.ForestGreen;
            TxtBillNo.Location = new Point(135, 149);
            TxtBillNo.MaxLength = 10;
            TxtBillNo.Name = "TxtBillNo";
            TxtBillNo.ReadOnly = true;
            TxtBillNo.Size = new Size(168, 26);
            TxtBillNo.TabIndex = 4;
            TxtBillNo.Enter += TextBox_Enter;
            TxtBillNo.KeyPress += Decimal_KeyPress;
            TxtBillNo.Leave += TextBox_Leave;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.ForeColor = Color.FromArgb(163, 0, 34);
            label8.Location = new Point(9, 192);
            label8.Name = "label8";
            label8.Size = new Size(120, 18);
            label8.TabIndex = 5;
            label8.Text = "Bill Date*";
            // 
            // DtpBillDate
            // 
            DtpBillDate.Anchor = AnchorStyles.Left;
            DtpBillDate.CustomFormat = "dd-MMM-yyyy";
            DtpBillDate.Enabled = false;
            DtpBillDate.Format = DateTimePickerFormat.Custom;
            DtpBillDate.Location = new Point(135, 188);
            DtpBillDate.Name = "DtpBillDate";
            DtpBillDate.Size = new Size(168, 26);
            DtpBillDate.TabIndex = 6;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.ForeColor = Color.FromArgb(163, 0, 34);
            label12.Location = new Point(9, 309);
            label12.Name = "label12";
            label12.Size = new Size(120, 18);
            label12.TabIndex = 11;
            label12.Text = "Pending Amount";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(163, 0, 34);
            label4.Location = new Point(9, 231);
            label4.Name = "label4";
            label4.Size = new Size(120, 18);
            label4.TabIndex = 7;
            label4.Text = "Total Bill Amount";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.ForeColor = Color.FromArgb(163, 0, 34);
            label13.Location = new Point(9, 270);
            label13.Name = "label13";
            label13.Size = new Size(120, 18);
            label13.TabIndex = 9;
            label13.Text = "Paid Till Now";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label14.AutoSize = true;
            label14.ForeColor = Color.FromArgb(163, 0, 34);
            label14.Location = new Point(9, 348);
            label14.Name = "label14";
            label14.Size = new Size(120, 18);
            label14.TabIndex = 13;
            label14.Text = "Current Payment*";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(163, 0, 34);
            label2.Location = new Point(9, 387);
            label2.Name = "label2";
            label2.Size = new Size(120, 18);
            label2.TabIndex = 15;
            label2.Text = "Payment Type*";
            // 
            // CmbPaymentType
            // 
            CmbPaymentType.Anchor = AnchorStyles.Left;
            CmbPaymentType.BackColor = Color.White;
            CmbPaymentType.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbPaymentType.ForeColor = Color.DarkGreen;
            CmbPaymentType.FormattingEnabled = true;
            CmbPaymentType.Location = new Point(134, 385);
            CmbPaymentType.Margin = new Padding(2);
            CmbPaymentType.Name = "CmbPaymentType";
            CmbPaymentType.Size = new Size(169, 26);
            CmbPaymentType.TabIndex = 16;
            CmbPaymentType.Enter += ComboBox_Enter;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(163, 0, 34);
            label6.Location = new Point(9, 426);
            label6.Name = "label6";
            label6.Size = new Size(120, 18);
            label6.TabIndex = 17;
            label6.Text = "Transaction Type*";
            // 
            // CmbTransactionType
            // 
            CmbTransactionType.Anchor = AnchorStyles.Left;
            CmbTransactionType.BackColor = Color.White;
            CmbTransactionType.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbTransactionType.ForeColor = Color.DarkGreen;
            CmbTransactionType.FormattingEnabled = true;
            CmbTransactionType.Location = new Point(134, 424);
            CmbTransactionType.Margin = new Padding(2);
            CmbTransactionType.Name = "CmbTransactionType";
            CmbTransactionType.Size = new Size(169, 26);
            CmbTransactionType.TabIndex = 18;
            CmbTransactionType.Enter += ComboBox_Enter;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(163, 0, 34);
            label5.Location = new Point(9, 465);
            label5.Name = "label5";
            label5.Size = new Size(120, 18);
            label5.TabIndex = 19;
            label5.Text = "Remarks";
            // 
            // TxtRemarks
            // 
            TxtRemarks.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtRemarks.BackColor = Color.WhiteSmoke;
            TxtRemarks.ForeColor = Color.ForestGreen;
            TxtRemarks.Location = new Point(135, 461);
            TxtRemarks.MaxLength = 50;
            TxtRemarks.Name = "TxtRemarks";
            TxtRemarks.Size = new Size(254, 26);
            TxtRemarks.TabIndex = 20;
            TxtRemarks.Enter += TextBox_Enter;
            TxtRemarks.Leave += TextBox_Leave;
            // 
            // TxtTotalBillAmount
            // 
            TxtTotalBillAmount.Anchor = AnchorStyles.Left;
            TxtTotalBillAmount.BackColor = Color.WhiteSmoke;
            TxtTotalBillAmount.ForeColor = Color.ForestGreen;
            TxtTotalBillAmount.Location = new Point(135, 227);
            TxtTotalBillAmount.MaxLength = 13;
            TxtTotalBillAmount.Name = "TxtTotalBillAmount";
            TxtTotalBillAmount.ReadOnly = true;
            TxtTotalBillAmount.Size = new Size(168, 26);
            TxtTotalBillAmount.TabIndex = 8;
            TxtTotalBillAmount.TextAlign = HorizontalAlignment.Right;
            TxtTotalBillAmount.Enter += TextBox_Enter;
            TxtTotalBillAmount.KeyPress += Decimal_KeyPress;
            TxtTotalBillAmount.Leave += TextBox_Leave;
            // 
            // TxtPaidTillNow
            // 
            TxtPaidTillNow.Anchor = AnchorStyles.Left;
            TxtPaidTillNow.BackColor = Color.WhiteSmoke;
            TxtPaidTillNow.ForeColor = Color.ForestGreen;
            TxtPaidTillNow.Location = new Point(135, 266);
            TxtPaidTillNow.MaxLength = 13;
            TxtPaidTillNow.Name = "TxtPaidTillNow";
            TxtPaidTillNow.ReadOnly = true;
            TxtPaidTillNow.Size = new Size(168, 26);
            TxtPaidTillNow.TabIndex = 10;
            TxtPaidTillNow.TextAlign = HorizontalAlignment.Right;
            TxtPaidTillNow.Enter += TextBox_Enter;
            TxtPaidTillNow.KeyPress += Decimal_KeyPress;
            TxtPaidTillNow.Leave += TextBox_Leave;
            // 
            // TxtPendingAmount
            // 
            TxtPendingAmount.Anchor = AnchorStyles.Left;
            TxtPendingAmount.BackColor = Color.WhiteSmoke;
            TxtPendingAmount.ForeColor = Color.ForestGreen;
            TxtPendingAmount.Location = new Point(135, 305);
            TxtPendingAmount.MaxLength = 13;
            TxtPendingAmount.Name = "TxtPendingAmount";
            TxtPendingAmount.ReadOnly = true;
            TxtPendingAmount.Size = new Size(168, 26);
            TxtPendingAmount.TabIndex = 12;
            TxtPendingAmount.TextAlign = HorizontalAlignment.Right;
            TxtPendingAmount.Enter += TextBox_Enter;
            TxtPendingAmount.KeyPress += Decimal_KeyPress;
            TxtPendingAmount.Leave += TextBox_Leave;
            // 
            // TxtCurrentPayment
            // 
            TxtCurrentPayment.Anchor = AnchorStyles.Left;
            TxtCurrentPayment.BackColor = Color.WhiteSmoke;
            TxtCurrentPayment.ForeColor = Color.ForestGreen;
            TxtCurrentPayment.Location = new Point(135, 344);
            TxtCurrentPayment.MaxLength = 13;
            TxtCurrentPayment.Name = "TxtCurrentPayment";
            TxtCurrentPayment.Size = new Size(168, 26);
            TxtCurrentPayment.TabIndex = 14;
            TxtCurrentPayment.TextAlign = HorizontalAlignment.Right;
            TxtCurrentPayment.Enter += TextBox_Enter;
            TxtCurrentPayment.KeyPress += Decimal_KeyPress;
            TxtCurrentPayment.Leave += TextBox_Leave;
            TxtCurrentPayment.Validated += TxtAmount_Validated;
            // 
            // DgvVendorInvoiceDetails
            // 
            DgvVendorInvoiceDetails.AllowUserToAddRows = false;
            DgvVendorInvoiceDetails.AllowUserToDeleteRows = false;
            DgvVendorInvoiceDetails.AllowUserToResizeColumns = false;
            DgvVendorInvoiceDetails.AllowUserToResizeRows = false;
            DgvVendorInvoiceDetails.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.IndianRed;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle4.SelectionForeColor = Color.IndianRed;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            DgvVendorInvoiceDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            DgvVendorInvoiceDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel2.SetColumnSpan(DgvVendorInvoiceDetails, 2);
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(0, 64, 64);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle5.SelectionForeColor = Color.ForestGreen;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            DgvVendorInvoiceDetails.DefaultCellStyle = dataGridViewCellStyle5;
            DgvVendorInvoiceDetails.Dock = DockStyle.Fill;
            DgvVendorInvoiceDetails.Location = new Point(9, 44);
            DgvVendorInvoiceDetails.MultiSelect = false;
            DgvVendorInvoiceDetails.Name = "DgvVendorInvoiceDetails";
            DgvVendorInvoiceDetails.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.Maroon;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            DgvVendorInvoiceDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            DgvVendorInvoiceDetails.RowHeadersVisible = false;
            DgvVendorInvoiceDetails.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            DgvVendorInvoiceDetails.RowTemplate.Height = 25;
            DgvVendorInvoiceDetails.Size = new Size(380, 96);
            DgvVendorInvoiceDetails.TabIndex = 2;
            DgvVendorInvoiceDetails.CellClick += DgvVendorInvoiceDetails_CellClick;
            DgvVendorInvoiceDetails.CellEnter += DgvVendorInvoiceDetails_CellEnter;
            DgvVendorInvoiceDetails.KeyDown += DgvVendorInvoiceDetails_KeyDown;
            // 
            // ErrorProvider
            // 
            ErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            ErrorProvider.ContainerControl = this;
            // 
            // FrmVendorPayment
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1402, 654);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(0, 64, 64);
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmVendorPayment";
            Text = "Vendor - Bill Payment";
            Activated += FrmVendorPayment_Activated;
            Load += FrmVendorPayment_Load;
            KeyDown += FrmVendorPayment_KeyDown;
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
            ((System.ComponentModel.ISupportInitialize)DgvVendorInvoiceDetails).EndInit();
            ((System.ComponentModel.ISupportInitialize)ErrorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Label label4;
        private TextBox TxtTotalBillAmount;
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
        private Label LblTotalPayment;
        private ComboBox CmbVendorName;
        private Label label5;
        private TextBox TxtRemarks;
        private Label label6;
        private ComboBox CmbTransactionType;
        private Label label7;
        private TextBox TxtBillNo;
        private Label label8;
        private DateTimePicker DtpBillDate;
        private TableLayoutPanel tableLayoutPanel8;
        private Label LblFilterTranType;
        private ComboBox CmbFilterTransactionType;
        private Label LblFilters;
        private Label LblFilterVendor;
        private TextBox TxtFilterVendorSearch;
        private Panel PanelFilter;
        private Label label2;
        private ComboBox CmbPaymentType;
        private Label label11;
        private CheckBox ChkFltrApplyDate;
        private Label LblFltrFromDate;
        private DateTimePicker DtpFltrFromDate;
        private Label LblFltrToDate;
        private DateTimePicker DtpFltrToDate;
        private CheckBox ChkSearchLike;
        private Label label12;
        private Label label13;
        private Label label14;
        private TextBox TxtPaidTillNow;
        private TextBox TxtPendingAmount;
        private TextBox TxtCurrentPayment;
        private DataGridView DgvVendorInvoiceDetails;
    }
}