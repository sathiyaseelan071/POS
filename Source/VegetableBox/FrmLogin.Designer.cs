namespace VegetableBox
{
    partial class FrmLogin
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
            panel1 = new Panel();
            PicBoxLogin = new PictureBox();
            panel2 = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            BtnExit = new Button();
            BtnLogin = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            CmbUserName = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            TxtPassword = new TextBox();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicBoxLogin).BeginInit();
            panel2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.Control;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44.4444427F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55.5555573F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(613, 300);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(PicBoxLogin);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(266, 294);
            panel1.TabIndex = 0;
            // 
            // PicBoxLogin
            // 
            PicBoxLogin.Dock = DockStyle.Fill;
            PicBoxLogin.Image = Properties.Resources.TransparentLogo;
            PicBoxLogin.Location = new Point(0, 0);
            PicBoxLogin.Name = "PicBoxLogin";
            PicBoxLogin.Size = new Size(264, 292);
            PicBoxLogin.SizeMode = PictureBoxSizeMode.Zoom;
            PicBoxLogin.TabIndex = 3;
            PicBoxLogin.TabStop = false;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(tableLayoutPanel4);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(275, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(335, 294);
            panel2.TabIndex = 5;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 2);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel4.Controls.Add(label1, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 30.1369858F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 33.90411F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 35.61644F));
            tableLayoutPanel4.Size = new Size(333, 292);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 3;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.9681759F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.51591F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.51591F));
            tableLayoutPanel5.Controls.Add(BtnExit, 2, 0);
            tableLayoutPanel5.Controls.Add(BtnLogin, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 190);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 47.826088F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 52.173912F));
            tableLayoutPanel5.Size = new Size(327, 99);
            tableLayoutPanel5.TabIndex = 2;
            // 
            // BtnExit
            // 
            BtnExit.Dock = DockStyle.Fill;
            BtnExit.ForeColor = Color.Red;
            BtnExit.Location = new Point(211, 4);
            BtnExit.Margin = new Padding(4);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(112, 39);
            BtnExit.TabIndex = 1;
            BtnExit.Text = "E&xit";
            BtnExit.UseVisualStyleBackColor = false;
            BtnExit.Click += BtnExit_Click;
            // 
            // BtnLogin
            // 
            BtnLogin.Dock = DockStyle.Fill;
            BtnLogin.ForeColor = Color.Green;
            BtnLogin.Location = new Point(92, 4);
            BtnLogin.Margin = new Padding(4);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(111, 39);
            BtnLogin.TabIndex = 0;
            BtnLogin.Text = "&Login";
            BtnLogin.UseVisualStyleBackColor = false;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(CmbUserName, 1, 0);
            tableLayoutPanel3.Controls.Add(label2, 0, 0);
            tableLayoutPanel3.Controls.Add(label3, 0, 1);
            tableLayoutPanel3.Controls.Add(TxtPassword, 1, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 91);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(327, 93);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // CmbUserName
            // 
            CmbUserName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CmbUserName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CmbUserName.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbUserName.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbUserName.FormattingEnabled = true;
            CmbUserName.Location = new Point(91, 9);
            CmbUserName.Margin = new Padding(2);
            CmbUserName.Name = "CmbUserName";
            CmbUserName.Size = new Size(234, 27);
            CmbUserName.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(0, 64, 64);
            label2.Location = new Point(3, 13);
            label2.Name = "label2";
            label2.Size = new Size(83, 19);
            label2.TabIndex = 0;
            label2.Text = "User Name";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(0, 64, 64);
            label3.Location = new Point(3, 60);
            label3.Name = "label3";
            label3.Size = new Size(83, 19);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // TxtPassword
            // 
            TxtPassword.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtPassword.Location = new Point(92, 56);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.PasswordChar = '*';
            TxtPassword.Size = new Size(232, 27);
            TxtPassword.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 64, 64);
            label1.Location = new Point(3, 32);
            label1.Name = "label1";
            label1.Size = new Size(327, 23);
            label1.TabIndex = 0;
            label1.Text = "Login";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.DarkSlateGray;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(619, 306);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 306);
            Controls.Add(tableLayoutPanel2);
            Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Credit Customer";
            Load += FrmPosCreditCustomer_Load;
            KeyDown += FrmPosCreditCustomer_KeyDown;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PicBoxLogin).EndInit();
            panel2.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel5;
        private Button BtnLogin;
        private Button BtnExit;
        private ComboBox CmbUserName;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label3;
        private TextBox TxtPassword;
        private PictureBox PicBoxLogin;
        private Panel panel1;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel4;
    }
}