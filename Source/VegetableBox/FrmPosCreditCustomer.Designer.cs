namespace VegetableBox
{
    partial class FrmPosCreditCustomer
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            Tlp = new TableLayoutPanel();
            CmbCustomerName = new ComboBox();
            label2 = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            BtnExit = new Button();
            BtnAdd = new Button();
            BtnOk = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            Tlp.SuspendLayout();
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
            tableLayoutPanel1.Controls.Add(Tlp, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(620, 146);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(0, 64, 64);
            label1.Location = new Point(3, 10);
            label1.Name = "label1";
            label1.Size = new Size(200, 23);
            label1.TabIndex = 0;
            label1.Text = "Credit Customer Details";
            // 
            // Tlp
            // 
            Tlp.ColumnCount = 5;
            Tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.02568865F));
            Tlp.ColumnStyles.Add(new ColumnStyle());
            Tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.5963F));
            Tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.3523254F));
            Tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.025689F));
            Tlp.Controls.Add(CmbCustomerName, 2, 0);
            Tlp.Controls.Add(label2, 1, 0);
            Tlp.Controls.Add(tableLayoutPanel5, 3, 0);
            Tlp.Dock = DockStyle.Fill;
            Tlp.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Tlp.Location = new Point(3, 46);
            Tlp.Name = "Tlp";
            Tlp.RowCount = 1;
            Tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Tlp.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp.Size = new Size(614, 67);
            Tlp.TabIndex = 1;
            // 
            // CmbCustomerName
            // 
            CmbCustomerName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CmbCustomerName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CmbCustomerName.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbCustomerName.FormattingEnabled = true;
            CmbCustomerName.Location = new Point(141, 22);
            CmbCustomerName.Margin = new Padding(2);
            CmbCustomerName.Name = "CmbCustomerName";
            CmbCustomerName.Size = new Size(253, 26);
            CmbCustomerName.TabIndex = 2;
            CmbCustomerName.KeyDown += CmbCustomerName_KeyDown;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(0, 64, 64);
            label2.Location = new Point(28, 24);
            label2.Name = "label2";
            label2.Size = new Size(108, 18);
            label2.TabIndex = 0;
            label2.Text = "Customer Name";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 3;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel5.Controls.Add(BtnExit, 2, 0);
            tableLayoutPanel5.Controls.Add(BtnAdd, 1, 0);
            tableLayoutPanel5.Controls.Add(BtnOk, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(399, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(185, 61);
            tableLayoutPanel5.TabIndex = 2;
            // 
            // BtnExit
            // 
            BtnExit.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            BtnExit.ForeColor = Color.Red;
            BtnExit.Location = new Point(126, 13);
            BtnExit.Margin = new Padding(4);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(55, 34);
            BtnExit.TabIndex = 2;
            BtnExit.Text = "E&xit";
            BtnExit.UseVisualStyleBackColor = true;
            BtnExit.Click += BtnExit_Click;
            // 
            // BtnAdd
            // 
            BtnAdd.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            BtnAdd.ForeColor = Color.DarkGreen;
            BtnAdd.Location = new Point(65, 13);
            BtnAdd.Margin = new Padding(4);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(53, 34);
            BtnAdd.TabIndex = 1;
            BtnAdd.Text = "&Add";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // BtnOk
            // 
            BtnOk.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            BtnOk.ForeColor = Color.Green;
            BtnOk.Location = new Point(4, 13);
            BtnOk.Margin = new Padding(4);
            BtnOk.Name = "BtnOk";
            BtnOk.Size = new Size(53, 34);
            BtnOk.TabIndex = 0;
            BtnOk.Text = "&Ok";
            BtnOk.UseVisualStyleBackColor = true;
            BtnOk.Click += BtnOk_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.Purple;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(626, 152);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // FrmPosCreditCustomer
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(626, 152);
            Controls.Add(tableLayoutPanel2);
            Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmPosCreditCustomer";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Credit Customer";
            Load += FrmPosCreditCustomer_Load;
            KeyDown += FrmPosCreditCustomer_KeyDown;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            Tlp.ResumeLayout(false);
            Tlp.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel Tlp;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel5;
        private Button BtnAdd;
        private Button BtnOk;
        private Button BtnExit;
        private ComboBox CmbCustomerName;
    }
}