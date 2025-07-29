namespace VegetableBox
{
    partial class FrmCreditDebitMaster
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            DGVPurchaseCart = new DataGridView();
            label2 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            rdbCredit = new RadioButton();
            rdbDebit = new RadioButton();
            textBox2 = new TextBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            BtnAdd = new Button();
            BtnEdit = new Button();
            BtnExit = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVPurchaseCart).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.Control;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 82.64463F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.43801641F));
            tableLayoutPanel1.Size = new Size(840, 363);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(0, 64, 64);
            label1.Location = new Point(3, 6);
            label1.Name = "label1";
            label1.Size = new Size(169, 23);
            label1.TabIndex = 0;
            label1.Text = "Credit Debit Master";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 6;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3.63252926F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.2934074F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.720768F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.720768F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3.63252926F));
            tableLayoutPanel3.Controls.Add(DGVPurchaseCart, 1, 1);
            tableLayoutPanel3.Controls.Add(label2, 1, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 3, 0);
            tableLayoutPanel3.Controls.Add(textBox2, 2, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel5, 4, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            tableLayoutPanel3.Location = new Point(3, 39);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 19.4539242F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 80.5460739F));
            tableLayoutPanel3.Size = new Size(834, 293);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // DGVPurchaseCart
            // 
            DGVPurchaseCart.AllowUserToAddRows = false;
            DGVPurchaseCart.AllowUserToDeleteRows = false;
            DGVPurchaseCart.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.IndianRed;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle4.SelectionForeColor = Color.IndianRed;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            DGVPurchaseCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            DGVPurchaseCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel3.SetColumnSpan(DGVPurchaseCart, 4);
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle5.SelectionForeColor = Color.ForestGreen;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            DGVPurchaseCart.DefaultCellStyle = dataGridViewCellStyle5;
            DGVPurchaseCart.Dock = DockStyle.Fill;
            DGVPurchaseCart.Location = new Point(31, 61);
            DGVPurchaseCart.Margin = new Padding(4);
            DGVPurchaseCart.MultiSelect = false;
            DGVPurchaseCart.Name = "DGVPurchaseCart";
            DGVPurchaseCart.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.Maroon;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            DGVPurchaseCart.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            DGVPurchaseCart.RowHeadersVisible = false;
            DGVPurchaseCart.RowTemplate.Height = 25;
            DGVPurchaseCart.Size = new Size(770, 228);
            DGVPurchaseCart.TabIndex = 4;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(0, 64, 64);
            label2.Location = new Point(30, 19);
            label2.Name = "label2";
            label2.Size = new Size(79, 18);
            label2.TabIndex = 0;
            label2.Text = "Description";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(rdbCredit, 0, 0);
            tableLayoutPanel4.Controls.Add(rdbDebit, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(394, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(201, 51);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // rdbCredit
            // 
            rdbCredit.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            rdbCredit.AutoSize = true;
            rdbCredit.Checked = true;
            rdbCredit.ForeColor = Color.FromArgb(0, 64, 64);
            rdbCredit.Location = new Point(3, 14);
            rdbCredit.Name = "rdbCredit";
            rdbCredit.Size = new Size(94, 22);
            rdbCredit.TabIndex = 0;
            rdbCredit.TabStop = true;
            rdbCredit.Text = "Credit";
            rdbCredit.UseVisualStyleBackColor = true;
            // 
            // rdbDebit
            // 
            rdbDebit.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            rdbDebit.AutoSize = true;
            rdbDebit.ForeColor = Color.FromArgb(0, 64, 64);
            rdbDebit.Location = new Point(103, 14);
            rdbDebit.Name = "rdbDebit";
            rdbDebit.Size = new Size(95, 22);
            rdbDebit.TabIndex = 1;
            rdbDebit.Text = "Debit";
            rdbDebit.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox2.BackColor = Color.WhiteSmoke;
            textBox2.ForeColor = Color.ForestGreen;
            textBox2.Location = new Point(116, 15);
            textBox2.Margin = new Padding(4);
            textBox2.MaxLength = 50;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(271, 26);
            textBox2.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 3;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel5.Controls.Add(BtnAdd, 0, 0);
            tableLayoutPanel5.Controls.Add(BtnEdit, 1, 0);
            tableLayoutPanel5.Controls.Add(BtnExit, 2, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(601, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(201, 51);
            tableLayoutPanel5.TabIndex = 3;
            // 
            // BtnAdd
            // 
            BtnAdd.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            BtnAdd.ForeColor = Color.DarkGreen;
            BtnAdd.Location = new Point(4, 8);
            BtnAdd.Margin = new Padding(4);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(58, 34);
            BtnAdd.TabIndex = 0;
            BtnAdd.Text = "&Add";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            BtnEdit.ForeColor = Color.FromArgb(64, 0, 0);
            BtnEdit.Location = new Point(70, 8);
            BtnEdit.Margin = new Padding(4);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(58, 34);
            BtnEdit.TabIndex = 1;
            BtnEdit.Text = "&Edit";
            BtnEdit.UseVisualStyleBackColor = true;
            BtnEdit.Click += BtnEdit_Click;
            // 
            // BtnExit
            // 
            BtnExit.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            BtnExit.ForeColor = Color.Maroon;
            BtnExit.Location = new Point(136, 8);
            BtnExit.Margin = new Padding(4);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(61, 34);
            BtnExit.TabIndex = 2;
            BtnExit.Text = "&Exit";
            BtnExit.UseVisualStyleBackColor = true;
            BtnExit.Click += BtnExit_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.FromArgb(0, 64, 64);
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(846, 369);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // FrmCreditDebitMaster
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 369);
            Controls.Add(tableLayoutPanel2);
            Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmCreditDebitMaster";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Credit Debit Master";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVPurchaseCart).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel4;
        private RadioButton rdbCredit;
        private RadioButton rdbDebit;
        private TextBox textBox2;
        private TableLayoutPanel tableLayoutPanel5;
        private Button BtnAdd;
        private Button BtnEdit;
        private Button BtnExit;
        private DataGridView DGVPurchaseCart;
    }
}