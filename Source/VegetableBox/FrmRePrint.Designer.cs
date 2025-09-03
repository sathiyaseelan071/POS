namespace VegetableBox
{
    partial class FrmRePrint
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
            Tlp_Main = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            BtnView = new Button();
            DtpBillDate = new DateTimePicker();
            DgvBillData = new DataGridView();
            tableLayoutPanel2 = new TableLayoutPanel();
            BtnExit = new Button();
            BtnPrint = new Button();
            TxtBillNo = new TextBox();
            label1 = new Label();
            Tlp_Main.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvBillData).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // Tlp_Main
            // 
            Tlp_Main.ColumnCount = 3;
            Tlp_Main.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.03448F));
            Tlp_Main.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 74.87685F));
            Tlp_Main.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.0886707F));
            Tlp_Main.Controls.Add(tableLayoutPanel1, 1, 1);
            Tlp_Main.Controls.Add(DgvBillData, 1, 2);
            Tlp_Main.Controls.Add(tableLayoutPanel2, 1, 3);
            Tlp_Main.Dock = DockStyle.Fill;
            Tlp_Main.Location = new Point(0, 0);
            Tlp_Main.Margin = new Padding(3, 4, 3, 4);
            Tlp_Main.Name = "Tlp_Main";
            Tlp_Main.RowCount = 4;
            Tlp_Main.RowStyles.Add(new RowStyle(SizeType.Percent, 5.016181F));
            Tlp_Main.RowStyles.Add(new RowStyle(SizeType.Percent, 13.9158573F));
            Tlp_Main.RowStyles.Add(new RowStyle(SizeType.Percent, 62.5780029F));
            Tlp_Main.RowStyles.Add(new RowStyle(SizeType.Percent, 18.3633442F));
            Tlp_Main.Size = new Size(1274, 618);
            Tlp_Main.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.870116F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2555437F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.982049F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65.89229F));
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(BtnView, 2, 1);
            tableLayoutPanel1.Controls.Add(DtpBillDate, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(143, 35);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(947, 78);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(3, 29);
            label2.Name = "label2";
            label2.Size = new Size(78, 19);
            label2.TabIndex = 0;
            label2.Text = "Bill Date";
            // 
            // BtnView
            // 
            BtnView.Dock = DockStyle.Fill;
            BtnView.ForeColor = Color.Green;
            BtnView.Location = new Point(222, 23);
            BtnView.Margin = new Padding(3, 4, 3, 4);
            BtnView.Name = "BtnView";
            BtnView.Size = new Size(98, 31);
            BtnView.TabIndex = 2;
            BtnView.Text = "&View";
            BtnView.UseVisualStyleBackColor = false;
            BtnView.Click += BtnView_Click;
            // 
            // DtpBillDate
            // 
            DtpBillDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            DtpBillDate.CustomFormat = "dd-MMM-yyyy";
            DtpBillDate.Format = DateTimePickerFormat.Custom;
            DtpBillDate.Location = new Point(86, 25);
            DtpBillDate.Margin = new Padding(2);
            DtpBillDate.Name = "DtpBillDate";
            DtpBillDate.Size = new Size(131, 27);
            DtpBillDate.TabIndex = 1;
            // 
            // DgvBillData
            // 
            DgvBillData.AllowUserToAddRows = false;
            DgvBillData.AllowUserToDeleteRows = false;
            DgvBillData.BackgroundColor = SystemColors.Control;
            DgvBillData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvBillData.Dock = DockStyle.Fill;
            DgvBillData.Location = new Point(143, 121);
            DgvBillData.Margin = new Padding(3, 4, 3, 4);
            DgvBillData.Name = "DgvBillData";
            DgvBillData.ReadOnly = true;
            DgvBillData.RowHeadersVisible = false;
            DgvBillData.RowTemplate.Height = 25;
            DgvBillData.Size = new Size(947, 379);
            DgvBillData.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54.97849F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.996089F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.996089F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5146666F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5146666F));
            tableLayoutPanel2.Controls.Add(BtnExit, 4, 1);
            tableLayoutPanel2.Controls.Add(BtnPrint, 3, 1);
            tableLayoutPanel2.Controls.Add(TxtBillNo, 2, 1);
            tableLayoutPanel2.Controls.Add(label1, 1, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(142, 506);
            tableLayoutPanel2.Margin = new Padding(2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.Size = new Size(949, 110);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // BtnExit
            // 
            BtnExit.Dock = DockStyle.Fill;
            BtnExit.ForeColor = Color.Crimson;
            BtnExit.Location = new Point(830, 37);
            BtnExit.Margin = new Padding(3, 4, 3, 4);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(116, 36);
            BtnExit.TabIndex = 3;
            BtnExit.Text = "E&xit";
            BtnExit.UseVisualStyleBackColor = false;
            BtnExit.Click += BtnExit_Click;
            // 
            // BtnPrint
            // 
            BtnPrint.Dock = DockStyle.Fill;
            BtnPrint.ForeColor = Color.Green;
            BtnPrint.Location = new Point(712, 37);
            BtnPrint.Margin = new Padding(3, 4, 3, 4);
            BtnPrint.Name = "BtnPrint";
            BtnPrint.Size = new Size(112, 36);
            BtnPrint.TabIndex = 2;
            BtnPrint.Text = "&Print";
            BtnPrint.UseVisualStyleBackColor = false;
            BtnPrint.Click += BtnPrint_Click;
            // 
            // TxtBillNo
            // 
            TxtBillNo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtBillNo.Location = new Point(618, 41);
            TxtBillNo.Margin = new Padding(3, 4, 3, 4);
            TxtBillNo.Name = "TxtBillNo";
            TxtBillNo.Size = new Size(88, 27);
            TxtBillNo.TabIndex = 1;
            TxtBillNo.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(524, 45);
            label1.Name = "label1";
            label1.Size = new Size(88, 19);
            label1.TabIndex = 0;
            label1.Text = "Bill No";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // FrmRePrint
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1274, 618);
            Controls.Add(Tlp_Main);
            Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(0, 64, 64);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmRePrint";
            Text = "Duplicate Bill";
            Load += FrmRePrint_Load;
            KeyDown += FrmRePrint_KeyDown;
            Tlp_Main.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvBillData).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel Tlp_Main;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox TxtBillNo;
        private Label label1;
        private Button BtnPrint;
        private Button BtnExit;
        private DataGridView DgvBillData;
        private Label label2;
        private DateTimePicker DtpBillDate;
        private TableLayoutPanel tableLayoutPanel2;
        private Button BtnView;
    }
}