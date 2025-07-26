namespace VegetableBox
{
    partial class FrmExpenseEntry
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
            DGVPurchaseCart = new DataGridView();
            tableLayoutPanel5 = new TableLayoutPanel();
            BtnSave = new Button();
            BtnExit = new Button();
            label3 = new Label();
            LblTotalAmt = new Label();
            tableLayoutPanel6 = new TableLayoutPanel();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            DtpPurchaseDate = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            BtnClear = new Button();
            BtnAdd = new Button();
            label4 = new Label();
            tableLayoutPanel7 = new TableLayoutPanel();
            comboBox1 = new ComboBox();
            BtnAddCreditDebitMaster = new Button();
            TxtTotPurchaseRate = new TextBox();
            label5 = new Label();
            textBox1 = new TextBox();
            ErrorProvider = new ErrorProvider(components);
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVPurchaseCart).BeginInit();
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
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel6, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1294, 622);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(DGVPurchaseCart, 0, 1);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 3);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(521, 4);
            tableLayoutPanel4.Margin = new Padding(4);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 5;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 62.5454559F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 7.15630865F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 8.6629F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 11.2994347F));
            tableLayoutPanel4.Size = new Size(769, 614);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // DGVPurchaseCart
            // 
            DGVPurchaseCart.AllowUserToAddRows = false;
            DGVPurchaseCart.AllowUserToDeleteRows = false;
            DGVPurchaseCart.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.IndianRed;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.SelectionForeColor = Color.IndianRed;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DGVPurchaseCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DGVPurchaseCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel4.SetColumnSpan(DGVPurchaseCart, 2);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(0, 64, 64);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.SelectionForeColor = Color.ForestGreen;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DGVPurchaseCart.DefaultCellStyle = dataGridViewCellStyle2;
            DGVPurchaseCart.Dock = DockStyle.Fill;
            DGVPurchaseCart.Location = new Point(4, 65);
            DGVPurchaseCart.Margin = new Padding(4);
            DGVPurchaseCart.MultiSelect = false;
            DGVPurchaseCart.Name = "DGVPurchaseCart";
            DGVPurchaseCart.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Maroon;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            DGVPurchaseCart.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            DGVPurchaseCart.RowHeadersVisible = false;
            tableLayoutPanel4.SetRowSpan(DGVPurchaseCart, 2);
            DGVPurchaseCart.RowTemplate.Height = 25;
            DGVPurchaseCart.Size = new Size(761, 421);
            DGVPurchaseCart.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 5;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.Controls.Add(BtnSave, 3, 0);
            tableLayoutPanel5.Controls.Add(BtnExit, 4, 0);
            tableLayoutPanel5.Controls.Add(label3, 0, 0);
            tableLayoutPanel5.Controls.Add(LblTotalAmt, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(4, 494);
            tableLayoutPanel5.Margin = new Padding(4);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(761, 45);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // BtnSave
            // 
            BtnSave.Dock = DockStyle.Fill;
            BtnSave.ForeColor = Color.Maroon;
            BtnSave.Location = new Point(460, 4);
            BtnSave.Margin = new Padding(4);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(144, 37);
            BtnSave.TabIndex = 2;
            BtnSave.Text = "&Save";
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // BtnExit
            // 
            BtnExit.Dock = DockStyle.Fill;
            BtnExit.ForeColor = Color.Crimson;
            BtnExit.Location = new Point(612, 4);
            BtnExit.Margin = new Padding(4);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(145, 37);
            BtnExit.TabIndex = 3;
            BtnExit.Text = "E&xit";
            BtnExit.UseVisualStyleBackColor = true;
            BtnExit.Click += BtnExit_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(146, 45);
            label3.TabIndex = 0;
            label3.Text = "Total Amount : ";
            // 
            // LblTotalAmt
            // 
            LblTotalAmt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblTotalAmt.AutoSize = true;
            LblTotalAmt.Font = new Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblTotalAmt.ForeColor = Color.Crimson;
            LblTotalAmt.Location = new Point(155, 6);
            LblTotalAmt.Name = "LblTotalAmt";
            LblTotalAmt.Size = new Size(146, 33);
            LblTotalAmt.TabIndex = 1;
            LblTotalAmt.Text = "...";
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Controls.Add(panel1, 0, 1);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(4, 4);
            tableLayoutPanel6.Margin = new Padding(4);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 3;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel6.Size = new Size(509, 614);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(4, 65);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(4);
            panel1.Size = new Size(501, 421);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tableLayoutPanel2.Controls.Add(DtpPurchaseDate, 1, 1);
            tableLayoutPanel2.Controls.Add(label2, 0, 1);
            tableLayoutPanel2.Controls.Add(label1, 0, 2);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 1, 9);
            tableLayoutPanel2.Controls.Add(label4, 0, 3);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel7, 1, 2);
            tableLayoutPanel2.Controls.Add(TxtTotPurchaseRate, 1, 3);
            tableLayoutPanel2.Controls.Add(label5, 0, 4);
            tableLayoutPanel2.Controls.Add(textBox1, 1, 4);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(4, 4);
            tableLayoutPanel2.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 11;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 0.221238941F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.0619469F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.0619469F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.0619469F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.0619469F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.0619469F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.0619469F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.0619469F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.0619469F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.0619469F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 0.221238941F));
            tableLayoutPanel2.Size = new Size(491, 411);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // DtpPurchaseDate
            // 
            DtpPurchaseDate.Anchor = AnchorStyles.Left;
            DtpPurchaseDate.CustomFormat = "dd-MMM-yyyy";
            DtpPurchaseDate.Format = DateTimePickerFormat.Custom;
            DtpPurchaseDate.Location = new Point(175, 7);
            DtpPurchaseDate.Margin = new Padding(4);
            DtpPurchaseDate.Name = "DtpPurchaseDate";
            DtpPurchaseDate.Size = new Size(164, 31);
            DtpPurchaseDate.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(4, 11);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(163, 23);
            label2.TabIndex = 0;
            label2.Text = "Date";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(4, 56);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(163, 23);
            label1.TabIndex = 2;
            label1.Text = "Description";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.5686283F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39.2156868F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39.2156868F));
            tableLayoutPanel3.Controls.Add(BtnClear, 2, 0);
            tableLayoutPanel3.Controls.Add(BtnAdd, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(171, 360);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(320, 45);
            tableLayoutPanel3.TabIndex = 8;
            // 
            // BtnClear
            // 
            BtnClear.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            BtnClear.ForeColor = Color.Crimson;
            BtnClear.Location = new Point(198, 4);
            BtnClear.Margin = new Padding(4);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(118, 37);
            BtnClear.TabIndex = 1;
            BtnClear.Text = "&Clear";
            BtnClear.UseVisualStyleBackColor = true;
            // 
            // BtnAdd
            // 
            BtnAdd.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            BtnAdd.ForeColor = Color.DarkGreen;
            BtnAdd.Location = new Point(73, 4);
            BtnAdd.Margin = new Padding(4);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(117, 37);
            BtnAdd.TabIndex = 0;
            BtnAdd.Text = "&Add";
            BtnAdd.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(4, 101);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(163, 23);
            label4.TabIndex = 4;
            label4.Text = "Amount";
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 83.3333359F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel7.Controls.Add(comboBox1, 0, 0);
            tableLayoutPanel7.Controls.Add(BtnAddCreditDebitMaster, 1, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(171, 45);
            tableLayoutPanel7.Margin = new Padding(0);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Size = new Size(320, 45);
            tableLayoutPanel7.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(3, 11);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(260, 31);
            comboBox1.TabIndex = 0;
            // 
            // BtnAddCreditDebitMaster
            // 
            BtnAddCreditDebitMaster.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            BtnAddCreditDebitMaster.ForeColor = Color.DarkGreen;
            BtnAddCreditDebitMaster.Location = new Point(270, 5);
            BtnAddCreditDebitMaster.Margin = new Padding(4);
            BtnAddCreditDebitMaster.Name = "BtnAddCreditDebitMaster";
            BtnAddCreditDebitMaster.Size = new Size(46, 35);
            BtnAddCreditDebitMaster.TabIndex = 1;
            BtnAddCreditDebitMaster.Text = "+";
            BtnAddCreditDebitMaster.UseVisualStyleBackColor = true;
            BtnAddCreditDebitMaster.Click += BtnAddCreditDebitMaster_Click;
            // 
            // TxtTotPurchaseRate
            // 
            TxtTotPurchaseRate.Anchor = AnchorStyles.Left;
            TxtTotPurchaseRate.BackColor = Color.WhiteSmoke;
            TxtTotPurchaseRate.ForeColor = Color.ForestGreen;
            TxtTotPurchaseRate.Location = new Point(175, 97);
            TxtTotPurchaseRate.Margin = new Padding(4);
            TxtTotPurchaseRate.MaxLength = 10;
            TxtTotPurchaseRate.Name = "TxtTotPurchaseRate";
            TxtTotPurchaseRate.Size = new Size(124, 31);
            TxtTotPurchaseRate.TabIndex = 5;
            TxtTotPurchaseRate.TextAlign = HorizontalAlignment.Right;
            TxtTotPurchaseRate.Enter += TextBox_Enter;
            TxtTotPurchaseRate.KeyPress += Decimal_KeyPress;
            TxtTotPurchaseRate.Leave += TextBox_Leave;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(4, 146);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(163, 23);
            label5.TabIndex = 6;
            label5.Text = "Remarks";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left;
            textBox1.BackColor = Color.WhiteSmoke;
            textBox1.ForeColor = Color.ForestGreen;
            textBox1.Location = new Point(175, 142);
            textBox1.Margin = new Padding(4);
            textBox1.MaxLength = 50;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(312, 31);
            textBox1.TabIndex = 7;
            textBox1.TextAlign = HorizontalAlignment.Right;
            textBox1.Enter += TextBox_Enter;
            textBox1.Leave += TextBox_Leave;
            // 
            // ErrorProvider
            // 
            ErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            ErrorProvider.ContainerControl = this;
            // 
            // FrmExpenseEntry
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1294, 622);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(0, 64, 64);
            KeyPreview = true;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmExpenseEntry";
            Text = "Credit Debit Enty";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGVPurchaseCart).EndInit();
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
        private Label label2;
        private Label label4;
        private DateTimePicker DtpPurchaseDate;
        private TextBox TxtTotPurchaseRate;
        private TableLayoutPanel tableLayoutPanel3;
        private Button BtnAdd;
        private Button BtnClear;
        private TableLayoutPanel tableLayoutPanel4;
        private DataGridView DGVPurchaseCart;
        private TableLayoutPanel tableLayoutPanel5;
        private Button BtnSave;
        private Button BtnExit;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel6;
        private ErrorProvider ErrorProvider;
        private Label label3;
        private Label LblTotalAmt;
        private ComboBox comboBox1;
        private TableLayoutPanel tableLayoutPanel7;
        private Button BtnAddCreditDebitMaster;
        private Label label5;
        private TextBox textBox1;
    }
}