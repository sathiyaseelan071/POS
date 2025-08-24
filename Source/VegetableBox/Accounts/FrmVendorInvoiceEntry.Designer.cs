namespace VegetableBox
{
    partial class FrmVendorInvoiceEntry
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
            LblFilters = new Label();
            DtpFltrToDate = new DateTimePicker();
            LblFltrToDate = new Label();
            DtpFltrFromDate = new DateTimePicker();
            LblFltrFromDate = new Label();
            ChkFltrApplyDate = new CheckBox();
            LblFilterProduct = new Label();
            TxtFilterVendor = new TextBox();
            ChkSearchLike = new CheckBox();
            tableLayoutPanel9 = new TableLayoutPanel();
            CmbFilterBillChecked = new ComboBox();
            CmbFilterIsItemMissing = new ComboBox();
            LblFilterCatType = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            CmbFilterPurchaseEntryStatus = new ComboBox();
            CmbFilterIsMissingItemReceived = new ComboBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            BtnEdit = new Button();
            BtnExit = new Button();
            label3 = new Label();
            LblTotalExpenses = new Label();
            tableLayoutPanel6 = new TableLayoutPanel();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            BtnCancel = new Button();
            BtnSave = new Button();
            tableLayoutPanel7 = new TableLayoutPanel();
            label1 = new Label();
            CmbVendorName = new ComboBox();
            BtnAddVendorMaster = new Button();
            label5 = new Label();
            TxtRemarks = new TextBox();
            label7 = new Label();
            TxtBillNo = new TextBox();
            label8 = new Label();
            DtpBillDate = new DateTimePicker();
            label4 = new Label();
            TxtBillAmount = new TextBox();
            label6 = new Label();
            CmbBillChecked = new ComboBox();
            label10 = new Label();
            TxtMissingItemDetails = new TextBox();
            label2 = new Label();
            CmbIsItemMissing = new ComboBox();
            label11 = new Label();
            label9 = new Label();
            CmbBillCheckedBy = new ComboBox();
            TxtItemsCount = new TextBox();
            label12 = new Label();
            label14 = new Label();
            CmbPurchaseEntryStatus = new ComboBox();
            CmbIsMissingItemReceived = new ComboBox();
            label13 = new Label();
            label15 = new Label();
            CmbPurchaseEntryBy = new ComboBox();
            CmbMissingItemReceivedBy = new ComboBox();
            ErrorProvider = new ErrorProvider(components);
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGView).BeginInit();
            PanelFilter.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
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
            tableLayoutPanel1.Size = new Size(1135, 526);
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
            tableLayoutPanel4.Location = new Point(343, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 5;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 19.8374882F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 59.5124664F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 7.09815931F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 8.592508F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 4.959372F));
            tableLayoutPanel4.Size = new Size(789, 520);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // DGView
            // 
            DGView.AllowUserToAddRows = false;
            DGView.AllowUserToDeleteRows = false;
            DGView.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.IndianRed;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.SelectionForeColor = Color.IndianRed;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DGView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DGView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel4.SetColumnSpan(DGView, 2);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(0, 64, 64);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.SelectionForeColor = Color.ForestGreen;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DGView.DefaultCellStyle = dataGridViewCellStyle2;
            DGView.Dock = DockStyle.Fill;
            DGView.Location = new Point(3, 106);
            DGView.MultiSelect = false;
            DGView.Name = "DGView";
            DGView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Maroon;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            DGView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            DGView.RowHeadersVisible = false;
            tableLayoutPanel4.SetRowSpan(DGView, 2);
            DGView.RowTemplate.Height = 25;
            DGView.Size = new Size(783, 339);
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
            PanelFilter.Size = new Size(783, 97);
            PanelFilter.TabIndex = 1;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 10;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.431906F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.1595335F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.8429756F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.5330582F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.1595335F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.171206F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.1595316F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.171206F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.1595335F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.10700369F));
            tableLayoutPanel8.Controls.Add(LblFilters, 1, 0);
            tableLayoutPanel8.Controls.Add(DtpFltrToDate, 8, 1);
            tableLayoutPanel8.Controls.Add(LblFltrToDate, 7, 1);
            tableLayoutPanel8.Controls.Add(DtpFltrFromDate, 6, 1);
            tableLayoutPanel8.Controls.Add(LblFltrFromDate, 5, 1);
            tableLayoutPanel8.Controls.Add(ChkFltrApplyDate, 4, 1);
            tableLayoutPanel8.Controls.Add(LblFilterProduct, 1, 1);
            tableLayoutPanel8.Controls.Add(TxtFilterVendor, 2, 1);
            tableLayoutPanel8.Controls.Add(ChkSearchLike, 1, 2);
            tableLayoutPanel8.Controls.Add(tableLayoutPanel9, 2, 2);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(0, 0);
            tableLayoutPanel8.Margin = new Padding(2);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 4;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel8.Size = new Size(781, 95);
            tableLayoutPanel8.TabIndex = 0;
            // 
            // LblFilters
            // 
            LblFilters.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            LblFilters.AutoSize = true;
            tableLayoutPanel8.SetColumnSpan(LblFilters, 2);
            LblFilters.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            LblFilters.ForeColor = Color.DarkGreen;
            LblFilters.Location = new Point(21, 9);
            LblFilters.Margin = new Padding(2, 0, 2, 0);
            LblFilters.Name = "LblFilters";
            LblFilters.Size = new Size(50, 19);
            LblFilters.TabIndex = 0;
            LblFilters.Text = "Filters";
            // 
            // DtpFltrToDate
            // 
            DtpFltrToDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            DtpFltrToDate.CalendarFont = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            DtpFltrToDate.CustomFormat = "dd-MMM-yyyy";
            DtpFltrToDate.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            DtpFltrToDate.Format = DateTimePickerFormat.Custom;
            DtpFltrToDate.Location = new Point(646, 31);
            DtpFltrToDate.Name = "DtpFltrToDate";
            DtpFltrToDate.Size = new Size(89, 23);
            DtpFltrToDate.TabIndex = 9;
            DtpFltrToDate.ValueChanged += DtpFltrToDate_ValueChanged;
            // 
            // LblFltrToDate
            // 
            LblFltrToDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblFltrToDate.AutoSize = true;
            LblFltrToDate.ForeColor = Color.FromArgb(163, 0, 34);
            LblFltrToDate.Location = new Point(582, 30);
            LblFltrToDate.Margin = new Padding(2, 0, 2, 0);
            LblFltrToDate.Name = "LblFltrToDate";
            LblFltrToDate.Size = new Size(59, 18);
            LblFltrToDate.TabIndex = 8;
            LblFltrToDate.Text = "To";
            LblFltrToDate.TextAlign = ContentAlignment.MiddleRight;
            // 
            // DtpFltrFromDate
            // 
            DtpFltrFromDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            DtpFltrFromDate.CalendarFont = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            DtpFltrFromDate.CustomFormat = "dd-MMM-yyyy";
            DtpFltrFromDate.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            DtpFltrFromDate.Format = DateTimePickerFormat.Custom;
            DtpFltrFromDate.Location = new Point(488, 31);
            DtpFltrFromDate.Name = "DtpFltrFromDate";
            DtpFltrFromDate.Size = new Size(89, 23);
            DtpFltrFromDate.TabIndex = 7;
            DtpFltrFromDate.ValueChanged += DtpFltrFromDate_ValueChanged;
            // 
            // LblFltrFromDate
            // 
            LblFltrFromDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblFltrFromDate.AutoSize = true;
            LblFltrFromDate.ForeColor = Color.FromArgb(163, 0, 34);
            LblFltrFromDate.Location = new Point(424, 30);
            LblFltrFromDate.Margin = new Padding(2, 0, 2, 0);
            LblFltrFromDate.Name = "LblFltrFromDate";
            LblFltrFromDate.Size = new Size(59, 18);
            LblFltrFromDate.TabIndex = 6;
            LblFltrFromDate.Text = "From";
            LblFltrFromDate.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ChkFltrApplyDate
            // 
            ChkFltrApplyDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ChkFltrApplyDate.AutoSize = true;
            ChkFltrApplyDate.CheckAlign = ContentAlignment.MiddleRight;
            ChkFltrApplyDate.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ChkFltrApplyDate.ForeColor = Color.Maroon;
            ChkFltrApplyDate.Location = new Point(330, 31);
            ChkFltrApplyDate.Name = "ChkFltrApplyDate";
            ChkFltrApplyDate.Size = new Size(89, 17);
            ChkFltrApplyDate.TabIndex = 5;
            ChkFltrApplyDate.Text = "Apply Date Filter";
            ChkFltrApplyDate.TextAlign = ContentAlignment.MiddleRight;
            ChkFltrApplyDate.UseVisualStyleBackColor = false;
            ChkFltrApplyDate.CheckedChanged += ChkFltrApplyDate_CheckedChanged;
            // 
            // LblFilterProduct
            // 
            LblFilterProduct.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblFilterProduct.AutoSize = true;
            LblFilterProduct.ForeColor = Color.FromArgb(163, 0, 34);
            LblFilterProduct.Location = new Point(21, 28);
            LblFilterProduct.Margin = new Padding(2, 0, 2, 0);
            LblFilterProduct.Name = "LblFilterProduct";
            LblFilterProduct.Size = new Size(91, 23);
            LblFilterProduct.TabIndex = 1;
            LblFilterProduct.Text = "Vendor Search";
            // 
            // TxtFilterVendor
            // 
            TxtFilterVendor.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtFilterVendor.BackColor = Color.White;
            tableLayoutPanel8.SetColumnSpan(TxtFilterVendor, 2);
            TxtFilterVendor.ForeColor = Color.DarkGreen;
            TxtFilterVendor.Location = new Point(116, 30);
            TxtFilterVendor.Margin = new Padding(2);
            TxtFilterVendor.MaxLength = 50;
            TxtFilterVendor.Name = "TxtFilterVendor";
            TxtFilterVendor.Size = new Size(209, 26);
            TxtFilterVendor.TabIndex = 2;
            TxtFilterVendor.TextChanged += TxtFilterCustomer_TextChanged;
            TxtFilterVendor.Enter += TextBox_Enter;
            TxtFilterVendor.Leave += TextBox_Leave;
            // 
            // ChkSearchLike
            // 
            ChkSearchLike.AutoSize = true;
            ChkSearchLike.Checked = true;
            ChkSearchLike.CheckState = CheckState.Checked;
            ChkSearchLike.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ChkSearchLike.ForeColor = Color.Maroon;
            ChkSearchLike.Location = new Point(22, 54);
            ChkSearchLike.Name = "ChkSearchLike";
            ChkSearchLike.Size = new Size(87, 17);
            ChkSearchLike.TabIndex = 3;
            ChkSearchLike.Text = "Like Search";
            ChkSearchLike.UseVisualStyleBackColor = true;
            ChkSearchLike.CheckedChanged += ChkSearchLike_CheckedChanged;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 9;
            tableLayoutPanel8.SetColumnSpan(tableLayoutPanel9, 8);
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel9.Controls.Add(CmbFilterBillChecked, 1, 0);
            tableLayoutPanel9.Controls.Add(CmbFilterIsItemMissing, 3, 0);
            tableLayoutPanel9.Controls.Add(LblFilterCatType, 2, 0);
            tableLayoutPanel9.Controls.Add(label16, 0, 0);
            tableLayoutPanel9.Controls.Add(label17, 6, 0);
            tableLayoutPanel9.Controls.Add(label18, 4, 0);
            tableLayoutPanel9.Controls.Add(CmbFilterPurchaseEntryStatus, 7, 0);
            tableLayoutPanel9.Controls.Add(CmbFilterIsMissingItemReceived, 5, 0);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(114, 51);
            tableLayoutPanel9.Margin = new Padding(0);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 1;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.Size = new Size(667, 23);
            tableLayoutPanel9.TabIndex = 4;
            // 
            // CmbFilterBillChecked
            // 
            CmbFilterBillChecked.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CmbFilterBillChecked.BackColor = Color.White;
            CmbFilterBillChecked.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbFilterBillChecked.ForeColor = Color.DarkGreen;
            CmbFilterBillChecked.FormattingEnabled = true;
            CmbFilterBillChecked.Location = new Point(90, 2);
            CmbFilterBillChecked.Margin = new Padding(2);
            CmbFilterBillChecked.Name = "CmbFilterBillChecked";
            CmbFilterBillChecked.Size = new Size(29, 26);
            CmbFilterBillChecked.TabIndex = 1;
            CmbFilterBillChecked.SelectedIndexChanged += CmbFilterTransactionType_SelectedIndexChanged;
            CmbFilterBillChecked.Enter += ComboBox_Enter;
            // 
            // CmbFilterIsItemMissing
            // 
            CmbFilterIsItemMissing.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CmbFilterIsItemMissing.BackColor = Color.White;
            CmbFilterIsItemMissing.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbFilterIsItemMissing.ForeColor = Color.DarkGreen;
            CmbFilterIsItemMissing.FormattingEnabled = true;
            CmbFilterIsItemMissing.Location = new Point(228, 2);
            CmbFilterIsItemMissing.Margin = new Padding(2);
            CmbFilterIsItemMissing.Name = "CmbFilterIsItemMissing";
            CmbFilterIsItemMissing.Size = new Size(29, 26);
            CmbFilterIsItemMissing.TabIndex = 3;
            CmbFilterIsItemMissing.SelectedIndexChanged += CmbFilterTransactionType_SelectedIndexChanged;
            CmbFilterIsItemMissing.Enter += ComboBox_Enter;
            // 
            // LblFilterCatType
            // 
            LblFilterCatType.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblFilterCatType.AutoSize = true;
            LblFilterCatType.ForeColor = Color.FromArgb(163, 0, 34);
            LblFilterCatType.Location = new Point(123, 2);
            LblFilterCatType.Margin = new Padding(2, 0, 2, 0);
            LblFilterCatType.Name = "LblFilterCatType";
            LblFilterCatType.Size = new Size(101, 18);
            LblFilterCatType.TabIndex = 2;
            LblFilterCatType.Text = "Is Item Missing";
            LblFilterCatType.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label16.AutoSize = true;
            label16.ForeColor = Color.FromArgb(163, 0, 34);
            label16.Location = new Point(2, 2);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(84, 18);
            label16.TabIndex = 0;
            label16.Text = "Bill Checked";
            label16.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label17.AutoSize = true;
            label17.ForeColor = Color.FromArgb(163, 0, 34);
            label17.Location = new Point(459, 2);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(140, 18);
            label17.TabIndex = 6;
            label17.Text = "Purchase Entry Status";
            label17.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label18.AutoSize = true;
            label18.ForeColor = Color.FromArgb(163, 0, 34);
            label18.Location = new Point(261, 2);
            label18.Margin = new Padding(2, 0, 2, 0);
            label18.Name = "label18";
            label18.Size = new Size(161, 18);
            label18.TabIndex = 4;
            label18.Text = "Is Missing Item Received";
            label18.TextAlign = ContentAlignment.MiddleRight;
            // 
            // CmbFilterPurchaseEntryStatus
            // 
            CmbFilterPurchaseEntryStatus.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CmbFilterPurchaseEntryStatus.BackColor = Color.White;
            CmbFilterPurchaseEntryStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbFilterPurchaseEntryStatus.ForeColor = Color.DarkGreen;
            CmbFilterPurchaseEntryStatus.FormattingEnabled = true;
            CmbFilterPurchaseEntryStatus.Location = new Point(603, 2);
            CmbFilterPurchaseEntryStatus.Margin = new Padding(2);
            CmbFilterPurchaseEntryStatus.Name = "CmbFilterPurchaseEntryStatus";
            CmbFilterPurchaseEntryStatus.Size = new Size(29, 26);
            CmbFilterPurchaseEntryStatus.TabIndex = 7;
            CmbFilterPurchaseEntryStatus.SelectedIndexChanged += CmbFilterTransactionType_SelectedIndexChanged;
            CmbFilterPurchaseEntryStatus.Enter += ComboBox_Enter;
            // 
            // CmbFilterIsMissingItemReceived
            // 
            CmbFilterIsMissingItemReceived.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CmbFilterIsMissingItemReceived.BackColor = Color.White;
            CmbFilterIsMissingItemReceived.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbFilterIsMissingItemReceived.ForeColor = Color.DarkGreen;
            CmbFilterIsMissingItemReceived.FormattingEnabled = true;
            CmbFilterIsMissingItemReceived.Location = new Point(426, 2);
            CmbFilterIsMissingItemReceived.Margin = new Padding(2);
            CmbFilterIsMissingItemReceived.Name = "CmbFilterIsMissingItemReceived";
            CmbFilterIsMissingItemReceived.Size = new Size(29, 26);
            CmbFilterIsMissingItemReceived.TabIndex = 5;
            CmbFilterIsMissingItemReceived.SelectedIndexChanged += CmbFilterTransactionType_SelectedIndexChanged;
            CmbFilterIsMissingItemReceived.Enter += ComboBox_Enter;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 9;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.Controls.Add(BtnEdit, 7, 0);
            tableLayoutPanel5.Controls.Add(BtnExit, 8, 0);
            tableLayoutPanel5.Controls.Add(label3, 0, 0);
            tableLayoutPanel5.Controls.Add(LblTotalExpenses, 2, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 451);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(783, 38);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // BtnEdit
            // 
            BtnEdit.Dock = DockStyle.Fill;
            BtnEdit.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            BtnEdit.ForeColor = Color.Maroon;
            BtnEdit.Location = new Point(533, 3);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(120, 32);
            BtnEdit.TabIndex = 2;
            BtnEdit.Text = "&Edit";
            BtnEdit.UseVisualStyleBackColor = false;
            BtnEdit.Click += BtnEdit_Click;
            // 
            // BtnExit
            // 
            BtnExit.Dock = DockStyle.Fill;
            BtnExit.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            BtnExit.ForeColor = Color.Crimson;
            BtnExit.Location = new Point(659, 3);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(121, 32);
            BtnExit.TabIndex = 3;
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
            label3.Location = new Point(2, 7);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(148, 23);
            label3.TabIndex = 0;
            label3.Text = "Total Expenses =>";
            label3.Visible = false;
            // 
            // LblTotalExpenses
            // 
            LblTotalExpenses.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblTotalExpenses.AutoSize = true;
            LblTotalExpenses.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblTotalExpenses.ForeColor = Color.Crimson;
            LblTotalExpenses.Location = new Point(154, 7);
            LblTotalExpenses.Margin = new Padding(2, 0, 2, 0);
            LblTotalExpenses.Name = "LblTotalExpenses";
            LblTotalExpenses.Size = new Size(122, 23);
            LblTotalExpenses.TabIndex = 1;
            LblTotalExpenses.Text = "...";
            LblTotalExpenses.Visible = false;
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
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 5.70175457F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 91.37427F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 2.92397666F));
            tableLayoutPanel6.Size = new Size(334, 520);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 32);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(3);
            panel1.Size = new Size(328, 469);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 1, 16);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel7, 0, 2);
            tableLayoutPanel2.Controls.Add(label5, 0, 15);
            tableLayoutPanel2.Controls.Add(TxtRemarks, 1, 15);
            tableLayoutPanel2.Controls.Add(label7, 0, 3);
            tableLayoutPanel2.Controls.Add(TxtBillNo, 1, 3);
            tableLayoutPanel2.Controls.Add(label8, 0, 4);
            tableLayoutPanel2.Controls.Add(DtpBillDate, 1, 4);
            tableLayoutPanel2.Controls.Add(label4, 0, 5);
            tableLayoutPanel2.Controls.Add(TxtBillAmount, 1, 5);
            tableLayoutPanel2.Controls.Add(label6, 0, 6);
            tableLayoutPanel2.Controls.Add(CmbBillChecked, 1, 6);
            tableLayoutPanel2.Controls.Add(label10, 0, 10);
            tableLayoutPanel2.Controls.Add(TxtMissingItemDetails, 1, 10);
            tableLayoutPanel2.Controls.Add(label2, 0, 9);
            tableLayoutPanel2.Controls.Add(CmbIsItemMissing, 1, 9);
            tableLayoutPanel2.Controls.Add(label11, 0, 7);
            tableLayoutPanel2.Controls.Add(label9, 0, 8);
            tableLayoutPanel2.Controls.Add(CmbBillCheckedBy, 1, 7);
            tableLayoutPanel2.Controls.Add(TxtItemsCount, 1, 8);
            tableLayoutPanel2.Controls.Add(label12, 0, 13);
            tableLayoutPanel2.Controls.Add(label14, 0, 11);
            tableLayoutPanel2.Controls.Add(CmbPurchaseEntryStatus, 1, 13);
            tableLayoutPanel2.Controls.Add(CmbIsMissingItemReceived, 1, 11);
            tableLayoutPanel2.Controls.Add(label13, 0, 14);
            tableLayoutPanel2.Controls.Add(label15, 0, 12);
            tableLayoutPanel2.Controls.Add(CmbPurchaseEntryBy, 1, 14);
            tableLayoutPanel2.Controls.Add(CmbMissingItemReceivedBy, 1, 12);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 18;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 0.00502361F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 6.249372F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 6.249372F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 6.249372F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 6.249372F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 6.249372F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 6.249372F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 6.249372F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 6.249372F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 6.249372F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 6.249372F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 6.249372F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 6.249372F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 6.249372F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 6.249372F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 6.249372F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 6.249372F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 0.00502361F));
            tableLayoutPanel2.Size = new Size(320, 461);
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
            tableLayoutPanel3.Location = new Point(179, 420);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(141, 28);
            tableLayoutPanel3.TabIndex = 28;
            // 
            // BtnCancel
            // 
            BtnCancel.Dock = DockStyle.Fill;
            BtnCancel.ForeColor = Color.Crimson;
            BtnCancel.Location = new Point(88, 3);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(50, 22);
            BtnCancel.TabIndex = 1;
            BtnCancel.Text = "&Cancel";
            BtnCancel.UseVisualStyleBackColor = false;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // BtnSave
            // 
            BtnSave.Dock = DockStyle.Fill;
            BtnSave.ForeColor = Color.DarkGreen;
            BtnSave.Location = new Point(33, 3);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(49, 22);
            BtnSave.TabIndex = 0;
            BtnSave.Text = "&Save";
            BtnSave.UseVisualStyleBackColor = false;
            BtnSave.Click += BtnSave_Click;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 3;
            tableLayoutPanel2.SetColumnSpan(tableLayoutPanel7, 2);
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 83.33333F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel7.Controls.Add(label1, 0, 0);
            tableLayoutPanel7.Controls.Add(CmbVendorName, 1, 0);
            tableLayoutPanel7.Controls.Add(BtnAddVendorMaster, 2, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(0, 28);
            tableLayoutPanel7.Margin = new Padding(0);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Size = new Size(320, 28);
            tableLayoutPanel7.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(163, 0, 34);
            label1.Location = new Point(3, 5);
            label1.Name = "label1";
            label1.Size = new Size(100, 18);
            label1.TabIndex = 0;
            label1.Text = "Vendor Name*";
            // 
            // CmbVendorName
            // 
            CmbVendorName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CmbVendorName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CmbVendorName.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbVendorName.FormattingEnabled = true;
            CmbVendorName.Location = new Point(108, 2);
            CmbVendorName.Margin = new Padding(2);
            CmbVendorName.Name = "CmbVendorName";
            CmbVendorName.Size = new Size(174, 26);
            CmbVendorName.TabIndex = 0;
            // 
            // BtnAddVendorMaster
            // 
            BtnAddVendorMaster.Dock = DockStyle.Fill;
            BtnAddVendorMaster.Font = new Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnAddVendorMaster.ForeColor = Color.DarkGreen;
            BtnAddVendorMaster.Location = new Point(287, 3);
            BtnAddVendorMaster.Name = "BtnAddVendorMaster";
            BtnAddVendorMaster.Size = new Size(30, 22);
            BtnAddVendorMaster.TabIndex = 1;
            BtnAddVendorMaster.Text = "&Add Vendor";
            BtnAddVendorMaster.UseVisualStyleBackColor = true;
            BtnAddVendorMaster.Click += BtnAddVendorMaster_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(163, 0, 34);
            label5.Location = new Point(3, 397);
            label5.Name = "label5";
            label5.Size = new Size(173, 18);
            label5.TabIndex = 26;
            label5.Text = "Remarks";
            // 
            // TxtRemarks
            // 
            TxtRemarks.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtRemarks.BackColor = Color.WhiteSmoke;
            TxtRemarks.ForeColor = Color.ForestGreen;
            TxtRemarks.Location = new Point(182, 395);
            TxtRemarks.MaxLength = 100;
            TxtRemarks.Name = "TxtRemarks";
            TxtRemarks.Size = new Size(135, 26);
            TxtRemarks.TabIndex = 27;
            TxtRemarks.Enter += TextBox_Enter;
            TxtRemarks.Leave += TextBox_Leave;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.ForeColor = Color.FromArgb(163, 0, 34);
            label7.Location = new Point(3, 61);
            label7.Name = "label7";
            label7.Size = new Size(173, 18);
            label7.TabIndex = 2;
            label7.Text = "Bill No*";
            // 
            // TxtBillNo
            // 
            TxtBillNo.Anchor = AnchorStyles.Left;
            TxtBillNo.BackColor = Color.WhiteSmoke;
            TxtBillNo.ForeColor = Color.ForestGreen;
            TxtBillNo.Location = new Point(182, 59);
            TxtBillNo.MaxLength = 20;
            TxtBillNo.Name = "TxtBillNo";
            TxtBillNo.Size = new Size(132, 26);
            TxtBillNo.TabIndex = 3;
            TxtBillNo.Enter += TextBox_Enter;
            TxtBillNo.Leave += TextBox_Leave;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.ForeColor = Color.FromArgb(163, 0, 34);
            label8.Location = new Point(3, 89);
            label8.Name = "label8";
            label8.Size = new Size(173, 18);
            label8.TabIndex = 4;
            label8.Text = "Bill Date*";
            // 
            // DtpBillDate
            // 
            DtpBillDate.Anchor = AnchorStyles.Left;
            DtpBillDate.CustomFormat = "dd-MMM-yyyy";
            DtpBillDate.Format = DateTimePickerFormat.Custom;
            DtpBillDate.Location = new Point(182, 87);
            DtpBillDate.Name = "DtpBillDate";
            DtpBillDate.Size = new Size(132, 26);
            DtpBillDate.TabIndex = 5;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(163, 0, 34);
            label4.Location = new Point(3, 117);
            label4.Name = "label4";
            label4.Size = new Size(173, 18);
            label4.TabIndex = 6;
            label4.Text = "Bill Amount*";
            // 
            // TxtBillAmount
            // 
            TxtBillAmount.Anchor = AnchorStyles.Left;
            TxtBillAmount.BackColor = Color.WhiteSmoke;
            TxtBillAmount.ForeColor = Color.ForestGreen;
            TxtBillAmount.Location = new Point(182, 115);
            TxtBillAmount.MaxLength = 13;
            TxtBillAmount.Name = "TxtBillAmount";
            TxtBillAmount.Size = new Size(132, 26);
            TxtBillAmount.TabIndex = 7;
            TxtBillAmount.TextAlign = HorizontalAlignment.Right;
            TxtBillAmount.Enter += TextBox_Enter;
            TxtBillAmount.KeyPress += Decimal_KeyPress;
            TxtBillAmount.Leave += TextBox_Leave;
            TxtBillAmount.Validated += TxtAmount_Validated;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(163, 0, 34);
            label6.Location = new Point(3, 145);
            label6.Name = "label6";
            label6.Size = new Size(173, 18);
            label6.TabIndex = 8;
            label6.Text = "Bill Checked*";
            // 
            // CmbBillChecked
            // 
            CmbBillChecked.Anchor = AnchorStyles.Left;
            CmbBillChecked.BackColor = Color.White;
            CmbBillChecked.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbBillChecked.ForeColor = Color.DarkGreen;
            CmbBillChecked.FormattingEnabled = true;
            CmbBillChecked.Location = new Point(181, 142);
            CmbBillChecked.Margin = new Padding(2);
            CmbBillChecked.Name = "CmbBillChecked";
            CmbBillChecked.Size = new Size(133, 26);
            CmbBillChecked.TabIndex = 9;
            CmbBillChecked.SelectedIndexChanged += CmbCommon_SelectedIndexChanged;
            CmbBillChecked.Enter += ComboBox_Enter;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.ForeColor = Color.FromArgb(163, 0, 34);
            label10.Location = new Point(3, 257);
            label10.Name = "label10";
            label10.Size = new Size(173, 18);
            label10.TabIndex = 16;
            label10.Text = "Missing Item Details*";
            // 
            // TxtMissingItemDetails
            // 
            TxtMissingItemDetails.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtMissingItemDetails.BackColor = Color.WhiteSmoke;
            TxtMissingItemDetails.ForeColor = Color.ForestGreen;
            TxtMissingItemDetails.Location = new Point(182, 255);
            TxtMissingItemDetails.MaxLength = 100;
            TxtMissingItemDetails.Name = "TxtMissingItemDetails";
            TxtMissingItemDetails.Size = new Size(135, 26);
            TxtMissingItemDetails.TabIndex = 17;
            TxtMissingItemDetails.Enter += TextBox_Enter;
            TxtMissingItemDetails.Leave += TextBox_Leave;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(163, 0, 34);
            label2.Location = new Point(3, 229);
            label2.Name = "label2";
            label2.Size = new Size(173, 18);
            label2.TabIndex = 14;
            label2.Text = "Is Item Missing*";
            // 
            // CmbIsItemMissing
            // 
            CmbIsItemMissing.Anchor = AnchorStyles.Left;
            CmbIsItemMissing.BackColor = Color.White;
            CmbIsItemMissing.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbIsItemMissing.ForeColor = Color.DarkGreen;
            CmbIsItemMissing.FormattingEnabled = true;
            CmbIsItemMissing.Location = new Point(181, 226);
            CmbIsItemMissing.Margin = new Padding(2);
            CmbIsItemMissing.Name = "CmbIsItemMissing";
            CmbIsItemMissing.Size = new Size(133, 26);
            CmbIsItemMissing.TabIndex = 15;
            CmbIsItemMissing.SelectedIndexChanged += CmbCommon_SelectedIndexChanged;
            CmbIsItemMissing.Enter += ComboBox_Enter;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.ForeColor = Color.FromArgb(163, 0, 34);
            label11.Location = new Point(3, 173);
            label11.Name = "label11";
            label11.Size = new Size(173, 18);
            label11.TabIndex = 10;
            label11.Text = "Bill CheckedBy*";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.ForeColor = Color.FromArgb(163, 0, 34);
            label9.Location = new Point(3, 201);
            label9.Name = "label9";
            label9.Size = new Size(173, 18);
            label9.TabIndex = 12;
            label9.Text = "Items Count*";
            // 
            // CmbBillCheckedBy
            // 
            CmbBillCheckedBy.Anchor = AnchorStyles.Left;
            CmbBillCheckedBy.BackColor = Color.White;
            CmbBillCheckedBy.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbBillCheckedBy.Enabled = false;
            CmbBillCheckedBy.ForeColor = Color.DarkGreen;
            CmbBillCheckedBy.FormattingEnabled = true;
            CmbBillCheckedBy.Location = new Point(181, 170);
            CmbBillCheckedBy.Margin = new Padding(2);
            CmbBillCheckedBy.Name = "CmbBillCheckedBy";
            CmbBillCheckedBy.Size = new Size(133, 26);
            CmbBillCheckedBy.TabIndex = 11;
            CmbBillCheckedBy.Enter += ComboBox_Enter;
            // 
            // TxtItemsCount
            // 
            TxtItemsCount.Anchor = AnchorStyles.Left;
            TxtItemsCount.BackColor = Color.WhiteSmoke;
            TxtItemsCount.ForeColor = Color.ForestGreen;
            TxtItemsCount.Location = new Point(182, 199);
            TxtItemsCount.MaxLength = 3;
            TxtItemsCount.Name = "TxtItemsCount";
            TxtItemsCount.Size = new Size(132, 26);
            TxtItemsCount.TabIndex = 13;
            TxtItemsCount.TextAlign = HorizontalAlignment.Right;
            TxtItemsCount.Enter += TextBox_Enter;
            TxtItemsCount.KeyPress += Number_KeyPress;
            TxtItemsCount.Leave += TextBox_Leave;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.ForeColor = Color.FromArgb(163, 0, 34);
            label12.Location = new Point(3, 341);
            label12.Name = "label12";
            label12.Size = new Size(173, 18);
            label12.TabIndex = 22;
            label12.Text = "Purchase Entry Status*";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label14.AutoSize = true;
            label14.ForeColor = Color.FromArgb(163, 0, 34);
            label14.Location = new Point(3, 285);
            label14.Name = "label14";
            label14.Size = new Size(173, 18);
            label14.TabIndex = 18;
            label14.Text = "Is Missing Item Received*";
            // 
            // CmbPurchaseEntryStatus
            // 
            CmbPurchaseEntryStatus.Anchor = AnchorStyles.Left;
            CmbPurchaseEntryStatus.BackColor = Color.White;
            CmbPurchaseEntryStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbPurchaseEntryStatus.ForeColor = Color.DarkGreen;
            CmbPurchaseEntryStatus.FormattingEnabled = true;
            CmbPurchaseEntryStatus.Location = new Point(181, 338);
            CmbPurchaseEntryStatus.Margin = new Padding(2);
            CmbPurchaseEntryStatus.Name = "CmbPurchaseEntryStatus";
            CmbPurchaseEntryStatus.Size = new Size(133, 26);
            CmbPurchaseEntryStatus.TabIndex = 23;
            CmbPurchaseEntryStatus.SelectedIndexChanged += CmbCommon_SelectedIndexChanged;
            CmbPurchaseEntryStatus.Enter += ComboBox_Enter;
            // 
            // CmbIsMissingItemReceived
            // 
            CmbIsMissingItemReceived.Anchor = AnchorStyles.Left;
            CmbIsMissingItemReceived.BackColor = Color.White;
            CmbIsMissingItemReceived.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbIsMissingItemReceived.ForeColor = Color.DarkGreen;
            CmbIsMissingItemReceived.FormattingEnabled = true;
            CmbIsMissingItemReceived.Location = new Point(181, 282);
            CmbIsMissingItemReceived.Margin = new Padding(2);
            CmbIsMissingItemReceived.Name = "CmbIsMissingItemReceived";
            CmbIsMissingItemReceived.Size = new Size(133, 26);
            CmbIsMissingItemReceived.TabIndex = 19;
            CmbIsMissingItemReceived.SelectedIndexChanged += CmbCommon_SelectedIndexChanged;
            CmbIsMissingItemReceived.Enter += ComboBox_Enter;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.ForeColor = Color.FromArgb(163, 0, 34);
            label13.Location = new Point(3, 369);
            label13.Name = "label13";
            label13.Size = new Size(173, 18);
            label13.TabIndex = 24;
            label13.Text = "Purchase Entry By*";
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label15.AutoSize = true;
            label15.ForeColor = Color.FromArgb(163, 0, 34);
            label15.Location = new Point(3, 313);
            label15.Name = "label15";
            label15.Size = new Size(173, 18);
            label15.TabIndex = 20;
            label15.Text = "Missing Item Received By*";
            // 
            // CmbPurchaseEntryBy
            // 
            CmbPurchaseEntryBy.Anchor = AnchorStyles.Left;
            CmbPurchaseEntryBy.BackColor = Color.White;
            CmbPurchaseEntryBy.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbPurchaseEntryBy.Enabled = false;
            CmbPurchaseEntryBy.ForeColor = Color.DarkGreen;
            CmbPurchaseEntryBy.FormattingEnabled = true;
            CmbPurchaseEntryBy.Location = new Point(181, 366);
            CmbPurchaseEntryBy.Margin = new Padding(2);
            CmbPurchaseEntryBy.Name = "CmbPurchaseEntryBy";
            CmbPurchaseEntryBy.Size = new Size(133, 26);
            CmbPurchaseEntryBy.TabIndex = 25;
            CmbPurchaseEntryBy.Enter += ComboBox_Enter;
            // 
            // CmbMissingItemReceivedBy
            // 
            CmbMissingItemReceivedBy.Anchor = AnchorStyles.Left;
            CmbMissingItemReceivedBy.BackColor = Color.White;
            CmbMissingItemReceivedBy.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbMissingItemReceivedBy.Enabled = false;
            CmbMissingItemReceivedBy.ForeColor = Color.DarkGreen;
            CmbMissingItemReceivedBy.FormattingEnabled = true;
            CmbMissingItemReceivedBy.Location = new Point(181, 310);
            CmbMissingItemReceivedBy.Margin = new Padding(2);
            CmbMissingItemReceivedBy.Name = "CmbMissingItemReceivedBy";
            CmbMissingItemReceivedBy.Size = new Size(133, 26);
            CmbMissingItemReceivedBy.TabIndex = 21;
            CmbMissingItemReceivedBy.Enter += ComboBox_Enter;
            // 
            // ErrorProvider
            // 
            ErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            ErrorProvider.ContainerControl = this;
            // 
            // FrmVendorInvoiceEntry
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1135, 526);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(0, 64, 64);
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmVendorInvoiceEntry";
            Text = "Vendor - Invoice Entry";
            Activated += FrmVendorInvoiceEntry_Activated;
            Load += FrmVendorInvoiceEntry_Load;
            KeyDown += FrmVendorInvoiceEntry_KeyDown;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGView).EndInit();
            PanelFilter.ResumeLayout(false);
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel9.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ErrorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Label label4;
        private TextBox TxtBillAmount;
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
        private ComboBox CmbVendorName;
        private Label label5;
        private TextBox TxtRemarks;
        private TableLayoutPanel tableLayoutPanel7;
        private Button BtnAddVendorMaster;
        private Label label6;
        private ComboBox CmbBillChecked;
        private Label label7;
        private TextBox TxtBillNo;
        private Label label8;
        private DateTimePicker DtpBillDate;
        private TableLayoutPanel tableLayoutPanel8;
        private Label LblFilterCatType;
        private ComboBox CmbFilterIsItemMissing;
        private Label LblFilters;
        private Label LblFilterProduct;
        private TextBox TxtFilterVendor;
        private Panel PanelFilter;
        private Label label2;
        private ComboBox CmbIsItemMissing;
        private Label LblTotalExpenses;
        private Label LblFltrFromDate;
        private Label LblFltrToDate;
        private DateTimePicker DtpFltrToDate;
        private DateTimePicker DtpFltrFromDate;
        private CheckBox ChkFltrApplyDate;
        private CheckBox ChkSearchLike;
        private Label label9;
        private TextBox TxtItemsCount;
        private TextBox TxtMissingItemDetails;
        private Label label10;
        private ComboBox CmbBillCheckedBy;
        private Label label11;
        private Label label12;
        private Label label13;
        private ComboBox CmbPurchaseEntryStatus;
        private ComboBox CmbPurchaseEntryBy;
        private Label label14;
        private ComboBox CmbIsMissingItemReceived;
        private Label label15;
        private ComboBox CmbMissingItemReceivedBy;
        private Label label16;
        private ComboBox CmbFilterBillChecked;
        private Label label17;
        private ComboBox CmbFilterPurchaseEntryStatus;
        private Label label18;
        private ComboBox CmbFilterIsMissingItemReceived;
        private TableLayoutPanel tableLayoutPanel9;
    }
}