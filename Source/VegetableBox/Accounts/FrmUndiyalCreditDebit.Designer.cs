namespace VegetableBox
{
    partial class FrmUndiyalCreditDebit
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
            ChkFltrApplyDate = new CheckBox();
            LblFltrFromDate = new Label();
            DtpFltrFromDate = new DateTimePicker();
            LblFltrToDate = new Label();
            DtpFltrToDate = new DateTimePicker();
            tableLayoutPanel5 = new TableLayoutPanel();
            BtnEdit = new Button();
            BtnExit = new Button();
            LblTotalAvailableAmt = new Label();
            label3 = new Label();
            label11 = new Label();
            LblTotalWithdrawAmt = new Label();
            label10 = new Label();
            LblTotalDepositAmt = new Label();
            label9 = new Label();
            tableLayoutPanel6 = new TableLayoutPanel();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            BtnCancel = new Button();
            BtnSave = new Button();
            label6 = new Label();
            CmbTransactionType = new ComboBox();
            label4 = new Label();
            TxtAmount = new TextBox();
            label5 = new Label();
            TxtRemarks = new TextBox();
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
            tableLayoutPanel1.Size = new Size(1402, 690);
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
            tableLayoutPanel4.Size = new Size(976, 684);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // DGView
            // 
            DGView.AllowUserToAddRows = false;
            DGView.AllowUserToDeleteRows = false;
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
            tableLayoutPanel4.SetColumnSpan(DGView, 2);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(0, 64, 64);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.SelectionForeColor = Color.ForestGreen;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DGView.DefaultCellStyle = dataGridViewCellStyle2;
            DGView.Dock = DockStyle.Fill;
            DGView.Location = new Point(3, 138);
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
            tableLayoutPanel4.SetRowSpan(DGView, 2);
            DGView.RowTemplate.Height = 25;
            DGView.Size = new Size(970, 449);
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
            PanelFilter.Size = new Size(970, 129);
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
            tableLayoutPanel8.Controls.Add(ChkFltrApplyDate, 4, 1);
            tableLayoutPanel8.Controls.Add(LblFltrFromDate, 5, 1);
            tableLayoutPanel8.Controls.Add(DtpFltrFromDate, 6, 1);
            tableLayoutPanel8.Controls.Add(LblFltrToDate, 7, 1);
            tableLayoutPanel8.Controls.Add(DtpFltrToDate, 8, 1);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(0, 0);
            tableLayoutPanel8.Margin = new Padding(2);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 4;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel8.Size = new Size(968, 127);
            tableLayoutPanel8.TabIndex = 0;
            // 
            // LblFilterCatType
            // 
            LblFilterCatType.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblFilterCatType.AutoSize = true;
            LblFilterCatType.ForeColor = Color.FromArgb(163, 0, 34);
            LblFilterCatType.Location = new Point(25, 38);
            LblFilterCatType.Margin = new Padding(2, 0, 2, 0);
            LblFilterCatType.Name = "LblFilterCatType";
            LblFilterCatType.Size = new Size(113, 31);
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
            CmbFilterTransactionType.Location = new Point(142, 40);
            CmbFilterTransactionType.Margin = new Padding(2);
            CmbFilterTransactionType.Name = "CmbFilterTransactionType";
            CmbFilterTransactionType.Size = new Size(113, 27);
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
            LblFilters.Location = new Point(2, 19);
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
            ChkFltrApplyDate.Location = new Point(408, 42);
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
            LblFltrFromDate.Location = new Point(524, 44);
            LblFltrFromDate.Margin = new Padding(2, 0, 2, 0);
            LblFltrFromDate.Name = "LblFltrFromDate";
            LblFltrFromDate.Size = new Size(75, 19);
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
            DtpFltrFromDate.Location = new Point(604, 42);
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
            LblFltrToDate.Location = new Point(720, 44);
            LblFltrToDate.Margin = new Padding(2, 0, 2, 0);
            LblFltrToDate.Name = "LblFltrToDate";
            LblFltrToDate.Size = new Size(75, 19);
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
            DtpFltrToDate.Location = new Point(800, 42);
            DtpFltrToDate.Name = "DtpFltrToDate";
            DtpFltrToDate.Size = new Size(111, 23);
            DtpFltrToDate.TabIndex = 7;
            DtpFltrToDate.ValueChanged += DtpFltrToDate_ValueChanged;
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
            tableLayoutPanel5.Controls.Add(LblTotalAvailableAmt, 6, 0);
            tableLayoutPanel5.Controls.Add(label3, 0, 0);
            tableLayoutPanel5.Controls.Add(label11, 5, 0);
            tableLayoutPanel5.Controls.Add(LblTotalWithdrawAmt, 4, 0);
            tableLayoutPanel5.Controls.Add(label10, 3, 0);
            tableLayoutPanel5.Controls.Add(LblTotalDepositAmt, 2, 0);
            tableLayoutPanel5.Controls.Add(label9, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 593);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(970, 52);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // BtnEdit
            // 
            BtnEdit.Dock = DockStyle.Fill;
            BtnEdit.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            BtnEdit.ForeColor = Color.Maroon;
            BtnEdit.Location = new Point(741, 3);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(109, 46);
            BtnEdit.TabIndex = 7;
            BtnEdit.Text = "&Edit";
            BtnEdit.UseVisualStyleBackColor = true;
            BtnEdit.Click += BtnEdit_Click;
            // 
            // BtnExit
            // 
            BtnExit.Dock = DockStyle.Fill;
            BtnExit.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            BtnExit.ForeColor = Color.Crimson;
            BtnExit.Location = new Point(856, 3);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(111, 46);
            BtnExit.TabIndex = 8;
            BtnExit.Text = "E&xit";
            BtnExit.UseVisualStyleBackColor = true;
            BtnExit.Click += BtnExit_Click;
            // 
            // LblTotalAvailableAmt
            // 
            LblTotalAvailableAmt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblTotalAvailableAmt.AutoSize = true;
            LblTotalAvailableAmt.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblTotalAvailableAmt.ForeColor = Color.Crimson;
            LblTotalAvailableAmt.Location = new Point(625, 14);
            LblTotalAvailableAmt.Margin = new Padding(2, 0, 2, 0);
            LblTotalAvailableAmt.Name = "LblTotalAvailableAmt";
            LblTotalAvailableAmt.Size = new Size(111, 23);
            LblTotalAvailableAmt.TabIndex = 6;
            LblTotalAvailableAmt.Text = "...";
            LblTotalAvailableAmt.Visible = false;
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
            label3.Size = new Size(111, 23);
            label3.TabIndex = 0;
            label3.Text = "Total =>";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(538, 14);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(83, 23);
            label11.TabIndex = 5;
            label11.Text = "Pending :";
            label11.Visible = false;
            // 
            // LblTotalWithdrawAmt
            // 
            LblTotalWithdrawAmt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblTotalWithdrawAmt.AutoSize = true;
            LblTotalWithdrawAmt.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblTotalWithdrawAmt.ForeColor = Color.Crimson;
            LblTotalWithdrawAmt.Location = new Point(423, 14);
            LblTotalWithdrawAmt.Margin = new Padding(2, 0, 2, 0);
            LblTotalWithdrawAmt.Name = "LblTotalWithdrawAmt";
            LblTotalWithdrawAmt.Size = new Size(111, 23);
            LblTotalWithdrawAmt.TabIndex = 4;
            LblTotalWithdrawAmt.Text = "...";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(321, 14);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(98, 23);
            label10.TabIndex = 3;
            label10.Text = "Withdraw :";
            // 
            // LblTotalDepositAmt
            // 
            LblTotalDepositAmt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblTotalDepositAmt.AutoSize = true;
            LblTotalDepositAmt.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblTotalDepositAmt.ForeColor = Color.Crimson;
            LblTotalDepositAmt.Location = new Point(206, 14);
            LblTotalDepositAmt.Margin = new Padding(2, 0, 2, 0);
            LblTotalDepositAmt.Name = "LblTotalDepositAmt";
            LblTotalDepositAmt.Size = new Size(111, 23);
            LblTotalDepositAmt.TabIndex = 2;
            LblTotalDepositAmt.Text = "...";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(117, 14);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(85, 23);
            label9.TabIndex = 1;
            label9.Text = "Deposit  :";
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
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 66.3063049F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 13.6936941F));
            tableLayoutPanel6.Size = new Size(414, 684);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 139);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(3);
            panel1.Size = new Size(408, 447);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 1, 11);
            tableLayoutPanel2.Controls.Add(label6, 0, 2);
            tableLayoutPanel2.Controls.Add(CmbTransactionType, 1, 2);
            tableLayoutPanel2.Controls.Add(label4, 0, 3);
            tableLayoutPanel2.Controls.Add(TxtAmount, 1, 3);
            tableLayoutPanel2.Controls.Add(label5, 0, 4);
            tableLayoutPanel2.Controls.Add(TxtRemarks, 1, 4);
            tableLayoutPanel2.Controls.Add(label2, 0, 5);
            tableLayoutPanel2.Controls.Add(CmbPaymentType, 1, 5);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
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
            tableLayoutPanel2.Size = new Size(400, 439);
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
            tableLayoutPanel3.Location = new Point(138, 390);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(262, 39);
            tableLayoutPanel3.TabIndex = 8;
            // 
            // BtnCancel
            // 
            BtnCancel.Dock = DockStyle.Fill;
            BtnCancel.ForeColor = Color.Crimson;
            BtnCancel.Location = new Point(161, 3);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(98, 33);
            BtnCancel.TabIndex = 1;
            BtnCancel.Text = "&Cancel";
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // BtnSave
            // 
            BtnSave.Dock = DockStyle.Fill;
            BtnSave.ForeColor = Color.DarkGreen;
            BtnSave.Location = new Point(59, 3);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(96, 33);
            BtnSave.TabIndex = 0;
            BtnSave.Text = "&Save";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(163, 0, 34);
            label6.Location = new Point(3, 49);
            label6.Name = "label6";
            label6.Size = new Size(132, 19);
            label6.TabIndex = 0;
            label6.Text = "Transaction Type*";
            // 
            // CmbTransactionType
            // 
            CmbTransactionType.Anchor = AnchorStyles.Left;
            CmbTransactionType.BackColor = Color.White;
            CmbTransactionType.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbTransactionType.ForeColor = Color.DarkGreen;
            CmbTransactionType.FormattingEnabled = true;
            CmbTransactionType.Location = new Point(140, 45);
            CmbTransactionType.Margin = new Padding(2);
            CmbTransactionType.Name = "CmbTransactionType";
            CmbTransactionType.Size = new Size(151, 27);
            CmbTransactionType.TabIndex = 1;
            CmbTransactionType.Enter += ComboBox_Enter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(163, 0, 34);
            label4.Location = new Point(3, 88);
            label4.Name = "label4";
            label4.Size = new Size(132, 19);
            label4.TabIndex = 2;
            label4.Text = "Amount*";
            // 
            // TxtAmount
            // 
            TxtAmount.Anchor = AnchorStyles.Left;
            TxtAmount.BackColor = Color.WhiteSmoke;
            TxtAmount.ForeColor = Color.ForestGreen;
            TxtAmount.Location = new Point(141, 84);
            TxtAmount.MaxLength = 13;
            TxtAmount.Name = "TxtAmount";
            TxtAmount.Size = new Size(150, 27);
            TxtAmount.TabIndex = 3;
            TxtAmount.TextAlign = HorizontalAlignment.Right;
            TxtAmount.Enter += TextBox_Enter;
            TxtAmount.KeyPress += Decimal_KeyPress;
            TxtAmount.Leave += TextBox_Leave;
            TxtAmount.Validated += TxtAmount_Validated;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(163, 0, 34);
            label5.Location = new Point(3, 127);
            label5.Name = "label5";
            label5.Size = new Size(132, 19);
            label5.TabIndex = 4;
            label5.Text = "Remarks";
            // 
            // TxtRemarks
            // 
            TxtRemarks.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtRemarks.BackColor = Color.WhiteSmoke;
            TxtRemarks.ForeColor = Color.ForestGreen;
            TxtRemarks.Location = new Point(141, 123);
            TxtRemarks.MaxLength = 50;
            TxtRemarks.Name = "TxtRemarks";
            TxtRemarks.Size = new Size(256, 27);
            TxtRemarks.TabIndex = 5;
            TxtRemarks.Enter += TextBox_Enter;
            TxtRemarks.Leave += TextBox_Leave;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(163, 0, 34);
            label2.Location = new Point(3, 166);
            label2.Name = "label2";
            label2.Size = new Size(132, 19);
            label2.TabIndex = 6;
            label2.Text = "Payment Type*";
            label2.Visible = false;
            // 
            // CmbPaymentType
            // 
            CmbPaymentType.Anchor = AnchorStyles.Left;
            CmbPaymentType.BackColor = Color.White;
            CmbPaymentType.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbPaymentType.ForeColor = Color.DarkGreen;
            CmbPaymentType.FormattingEnabled = true;
            CmbPaymentType.Location = new Point(140, 162);
            CmbPaymentType.Margin = new Padding(2);
            CmbPaymentType.Name = "CmbPaymentType";
            CmbPaymentType.Size = new Size(151, 27);
            CmbPaymentType.TabIndex = 7;
            CmbPaymentType.Visible = false;
            CmbPaymentType.Enter += ComboBox_Enter;
            // 
            // ErrorProvider
            // 
            ErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            ErrorProvider.ContainerControl = this;
            // 
            // FrmUndiyalCreditDebit
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1402, 690);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(0, 64, 64);
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmUndiyalCreditDebit";
            Text = "Undiyal (Deposit/Withdraw)";
            Activated += FrmUndiyalCreditDebit_Activated;
            Load += FrmUndiyalCreditDebit_Load;
            KeyDown += FrmUndiyalCreditDebit_KeyDown;
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
            ((System.ComponentModel.ISupportInitialize)ErrorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
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
        private Label LblTotalAvailableAmt;
        private Label label5;
        private TextBox TxtRemarks;
        private Label label6;
        private ComboBox CmbTransactionType;
        private TableLayoutPanel tableLayoutPanel8;
        private Label LblFilterCatType;
        private ComboBox CmbFilterTransactionType;
        private Label LblFilters;
        private Panel PanelFilter;
        private Label label2;
        private ComboBox CmbPaymentType;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label LblTotalWithdrawAmt;
        private Label LblTotalDepositAmt;
        private CheckBox ChkFltrApplyDate;
        private Label LblFltrFromDate;
        private DateTimePicker DtpFltrFromDate;
        private Label LblFltrToDate;
        private DateTimePicker DtpFltrToDate;
    }
}