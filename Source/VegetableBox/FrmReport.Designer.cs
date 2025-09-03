namespace VegetableBox
{
    partial class FrmReport
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            tlpMain = new TableLayoutPanel();
            DGVReport = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            label4 = new Label();
            CmbReportType = new ComboBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            BtnExit = new Button();
            BtnView = new Button();
            CmbProductFilter = new ComboBox();
            label6 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            DtpToDate = new DateTimePicker();
            label2 = new Label();
            CmbQuantity = new ComboBox();
            label7 = new Label();
            CmbCategory = new ComboBox();
            label5 = new Label();
            label1 = new Label();
            DtpFromDate = new DateTimePicker();
            tableLayoutPanel4 = new TableLayoutPanel();
            LblTotalDispName1 = new Label();
            LblTotalDispValue1 = new Label();
            LblTotalDispName2 = new Label();
            LblTotalDispValue2 = new Label();
            tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVReport).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // tlpMain
            // 
            tlpMain.ColumnCount = 2;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.9323578F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 79.06764F));
            tlpMain.Controls.Add(DGVReport, 0, 1);
            tlpMain.Controls.Add(tableLayoutPanel1, 0, 0);
            tlpMain.Controls.Add(tableLayoutPanel4, 0, 2);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(0, 0);
            tlpMain.Margin = new Padding(3, 4, 3, 4);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 3;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 24.621212F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 66.47727F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 8.712121F));
            tlpMain.Size = new Size(1094, 528);
            tlpMain.TabIndex = 0;
            // 
            // DGVReport
            // 
            DGVReport.AllowUserToAddRows = false;
            DGVReport.AllowUserToDeleteRows = false;
            DGVReport.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.IndianRed;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.SelectionForeColor = Color.IndianRed;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DGVReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DGVReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tlpMain.SetColumnSpan(DGVReport, 2);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(0, 64, 64);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.SelectionForeColor = Color.ForestGreen;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DGVReport.DefaultCellStyle = dataGridViewCellStyle2;
            DGVReport.Dock = DockStyle.Fill;
            DGVReport.Location = new Point(3, 134);
            DGVReport.Margin = new Padding(3, 4, 3, 4);
            DGVReport.Name = "DGVReport";
            DGVReport.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Maroon;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            DGVReport.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            DGVReport.RowTemplate.Height = 25;
            DGVReport.Size = new Size(1088, 343);
            DGVReport.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tlpMain.SetColumnSpan(tableLayoutPanel1, 2);
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.639706F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.94853F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.4117641F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(label4, 0, 0);
            tableLayoutPanel1.Controls.Add(CmbReportType, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 4);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(1088, 122);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(0, 64, 64);
            label4.Location = new Point(3, 1);
            label4.Name = "label4";
            label4.Size = new Size(88, 38);
            label4.TabIndex = 0;
            label4.Text = "Report Type";
            // 
            // CmbReportType
            // 
            CmbReportType.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CmbReportType.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbReportType.FormattingEnabled = true;
            CmbReportType.Location = new Point(97, 8);
            CmbReportType.Name = "CmbReportType";
            CmbReportType.Size = new Size(396, 27);
            CmbReportType.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 6;
            tableLayoutPanel1.SetColumnSpan(tableLayoutPanel2, 4);
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.547794F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.7647057F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1.82215738F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.912537F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.912537F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.9810524F));
            tableLayoutPanel2.Controls.Add(BtnExit, 4, 0);
            tableLayoutPanel2.Controls.Add(BtnView, 3, 0);
            tableLayoutPanel2.Controls.Add(CmbProductFilter, 1, 0);
            tableLayoutPanel2.Controls.Add(label6, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 80);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1088, 42);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // BtnExit
            // 
            BtnExit.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            BtnExit.ForeColor = Color.Crimson;
            BtnExit.Location = new Point(622, 3);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(101, 36);
            BtnExit.TabIndex = 3;
            BtnExit.Text = "E&xit";
            BtnExit.UseVisualStyleBackColor = true;
            BtnExit.Click += BtnExit_Click;
            // 
            // BtnView
            // 
            BtnView.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            BtnView.ForeColor = Color.DarkGreen;
            BtnView.Location = new Point(515, 3);
            BtnView.Name = "BtnView";
            BtnView.Size = new Size(101, 36);
            BtnView.TabIndex = 2;
            BtnView.Text = "&View";
            BtnView.UseVisualStyleBackColor = true;
            BtnView.Click += BtnView_Click;
            // 
            // CmbProductFilter
            // 
            CmbProductFilter.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CmbProductFilter.FormattingEnabled = true;
            CmbProductFilter.Location = new Point(96, 7);
            CmbProductFilter.Name = "CmbProductFilter";
            CmbProductFilter.Size = new Size(394, 27);
            CmbProductFilter.TabIndex = 1;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(0, 64, 64);
            label6.Location = new Point(3, 2);
            label6.Name = "label6";
            label6.Size = new Size(87, 38);
            label6.TabIndex = 0;
            label6.Text = "Product Name";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 12;
            tableLayoutPanel1.SetColumnSpan(tableLayoutPanel3, 4);
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.677987F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.3971252F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1.23971248F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.677987F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.3971252F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1.23971248F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.677987F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.3971252F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1.23971248F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.677987F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.3971252F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.9804144F));
            tableLayoutPanel3.Controls.Add(DtpToDate, 4, 0);
            tableLayoutPanel3.Controls.Add(label2, 3, 0);
            tableLayoutPanel3.Controls.Add(CmbQuantity, 10, 0);
            tableLayoutPanel3.Controls.Add(label7, 9, 0);
            tableLayoutPanel3.Controls.Add(CmbCategory, 7, 0);
            tableLayoutPanel3.Controls.Add(label5, 6, 0);
            tableLayoutPanel3.Controls.Add(label1, 0, 0);
            tableLayoutPanel3.Controls.Add(DtpFromDate, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 40);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(1088, 40);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // DtpToDate
            // 
            DtpToDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            DtpToDate.CustomFormat = "dd-MMM-yyyy";
            DtpToDate.Format = DateTimePickerFormat.Custom;
            DtpToDate.Location = new Point(338, 6);
            DtpToDate.Name = "DtpToDate";
            DtpToDate.Size = new Size(128, 27);
            DtpToDate.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(0, 64, 64);
            label2.Location = new Point(244, 10);
            label2.Name = "label2";
            label2.Size = new Size(88, 19);
            label2.TabIndex = 2;
            label2.Text = "To Date";
            // 
            // CmbQuantity
            // 
            CmbQuantity.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CmbQuantity.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbQuantity.FormattingEnabled = true;
            CmbQuantity.Location = new Point(820, 6);
            CmbQuantity.Name = "CmbQuantity";
            CmbQuantity.Size = new Size(128, 27);
            CmbQuantity.TabIndex = 7;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.ForeColor = Color.FromArgb(0, 64, 64);
            label7.Location = new Point(726, 10);
            label7.Name = "label7";
            label7.Size = new Size(88, 19);
            label7.TabIndex = 6;
            label7.Text = "Quantity";
            // 
            // CmbCategory
            // 
            CmbCategory.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbCategory.FormattingEnabled = true;
            CmbCategory.Location = new Point(579, 6);
            CmbCategory.Name = "CmbCategory";
            CmbCategory.Size = new Size(128, 27);
            CmbCategory.TabIndex = 5;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(0, 64, 64);
            label5.Location = new Point(485, 10);
            label5.Name = "label5";
            label5.Size = new Size(88, 19);
            label5.TabIndex = 4;
            label5.Text = "Category";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(0, 64, 64);
            label1.Location = new Point(3, 10);
            label1.Name = "label1";
            label1.Size = new Size(88, 19);
            label1.TabIndex = 0;
            label1.Text = "From Date";
            // 
            // DtpFromDate
            // 
            DtpFromDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            DtpFromDate.CalendarForeColor = Color.FromArgb(0, 64, 0);
            DtpFromDate.CalendarTitleForeColor = Color.FromArgb(0, 64, 0);
            DtpFromDate.CustomFormat = "dd-MMM-yyyy";
            DtpFromDate.Format = DateTimePickerFormat.Custom;
            DtpFromDate.Location = new Point(97, 6);
            DtpFromDate.Name = "DtpFromDate";
            DtpFromDate.Size = new Size(128, 27);
            DtpFromDate.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 5;
            tlpMain.SetColumnSpan(tableLayoutPanel4, 2);
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.3138123F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.2092056F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.3138123F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.2092056F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.953975F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Controls.Add(LblTotalDispName1, 0, 0);
            tableLayoutPanel4.Controls.Add(LblTotalDispValue1, 1, 0);
            tableLayoutPanel4.Controls.Add(LblTotalDispName2, 2, 0);
            tableLayoutPanel4.Controls.Add(LblTotalDispValue2, 3, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 484);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(1088, 41);
            tableLayoutPanel4.TabIndex = 4;
            // 
            // LblTotalDispName1
            // 
            LblTotalDispName1.Anchor = AnchorStyles.Right;
            LblTotalDispName1.AutoSize = true;
            LblTotalDispName1.Font = new Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblTotalDispName1.ForeColor = Color.DarkRed;
            LblTotalDispName1.Location = new Point(258, 4);
            LblTotalDispName1.Name = "LblTotalDispName1";
            LblTotalDispName1.Size = new Size(36, 33);
            LblTotalDispName1.TabIndex = 2;
            LblTotalDispName1.Text = "...";
            // 
            // LblTotalDispValue1
            // 
            LblTotalDispValue1.Anchor = AnchorStyles.Left;
            LblTotalDispValue1.AutoSize = true;
            LblTotalDispValue1.Font = new Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblTotalDispValue1.ForeColor = Color.DarkGreen;
            LblTotalDispValue1.Location = new Point(300, 4);
            LblTotalDispValue1.Name = "LblTotalDispValue1";
            LblTotalDispValue1.Size = new Size(36, 33);
            LblTotalDispValue1.TabIndex = 3;
            LblTotalDispValue1.Text = "...";
            // 
            // LblTotalDispName2
            // 
            LblTotalDispName2.Anchor = AnchorStyles.Right;
            LblTotalDispName2.AutoSize = true;
            LblTotalDispName2.Font = new Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblTotalDispName2.ForeColor = Color.DarkRed;
            LblTotalDispName2.Location = new Point(753, 4);
            LblTotalDispName2.Name = "LblTotalDispName2";
            LblTotalDispName2.Size = new Size(36, 33);
            LblTotalDispName2.TabIndex = 2;
            LblTotalDispName2.Text = "...";
            // 
            // LblTotalDispValue2
            // 
            LblTotalDispValue2.Anchor = AnchorStyles.Left;
            LblTotalDispValue2.AutoSize = true;
            LblTotalDispValue2.Font = new Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblTotalDispValue2.ForeColor = Color.DarkGreen;
            LblTotalDispValue2.Location = new Point(795, 4);
            LblTotalDispValue2.Name = "LblTotalDispValue2";
            LblTotalDispValue2.Size = new Size(36, 33);
            LblTotalDispValue2.TabIndex = 3;
            LblTotalDispValue2.Text = "...";
            // 
            // FrmReport
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1094, 528);
            Controls.Add(tlpMain);
            Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmReport";
            Text = "Report";
            Load += FrmReportPurchase_Load;
            tlpMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGVReport).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpMain;
        private DataGridView DGVReport;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private DateTimePicker DtpFromDate;
        private DateTimePicker DtpToDate;
        private Button BtnView;
        private Button BtnExit;
        private Label LblTotalDispName1;
        private Label LblTotalDispValue1;
        private Label label4;
        private ComboBox CmbReportType;
        private Label label5;
        private ComboBox CmbCategory;
        private Label label6;
        private ComboBox CmbProductFilter;
        private Label label7;
        private ComboBox CmbQuantity;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Label LblTotalDispName2;
        private Label LblTotalDispValue2;
    }
}