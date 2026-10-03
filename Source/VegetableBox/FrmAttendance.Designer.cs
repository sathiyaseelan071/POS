namespace VegetableBox
{
    partial class FrmAttendance
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            label1 = new Label();
            LblCurrentUserName = new Label();
            label3 = new Label();
            TxtRemarks = new TextBox();
            BtnLogInOut = new Button();
            BtnExit = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            dgvTodayData = new DataGridView();
            dgvMonthlyData = new DataGridView();
            label4 = new Label();
            label5 = new Label();
            ErrorProvider = new ErrorProvider(components);
            folderBrowserDialog1 = new FolderBrowserDialog();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTodayData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMonthlyData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4.24794054F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 27.6437855F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 68.27458F));
            tableLayoutPanel1.Size = new Size(1063, 539);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(tableLayoutPanel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(24, 25);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(3);
            panel1.Size = new Size(504, 142);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 6;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.142858F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.8571434F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.4285717F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.4285717F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.14285755F));
            tableLayoutPanel3.Controls.Add(label1, 1, 1);
            tableLayoutPanel3.Controls.Add(LblCurrentUserName, 2, 1);
            tableLayoutPanel3.Controls.Add(label3, 1, 2);
            tableLayoutPanel3.Controls.Add(TxtRemarks, 2, 2);
            tableLayoutPanel3.Controls.Add(BtnLogInOut, 3, 3);
            tableLayoutPanel3.Controls.Add(BtnExit, 4, 3);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 5;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 7.142857F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 28.5714283F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 28.5714283F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 28.5714283F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 7.142857F));
            tableLayoutPanel3.Size = new Size(496, 134);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(26, 15);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(120, 26);
            label1.TabIndex = 0;
            label1.Text = "User Name :";
            // 
            // LblCurrentUserName
            // 
            LblCurrentUserName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblCurrentUserName.AutoSize = true;
            LblCurrentUserName.BorderStyle = BorderStyle.FixedSingle;
            LblCurrentUserName.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            LblCurrentUserName.ForeColor = Color.Crimson;
            LblCurrentUserName.Location = new Point(146, 14);
            LblCurrentUserName.Margin = new Padding(0);
            LblCurrentUserName.Name = "LblCurrentUserName";
            LblCurrentUserName.Size = new Size(161, 28);
            LblCurrentUserName.TabIndex = 1;
            LblCurrentUserName.Text = "Siva";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(26, 53);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(120, 26);
            label3.TabIndex = 2;
            label3.Text = "Remarks :";
            // 
            // TxtRemarks
            // 
            TxtRemarks.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtRemarks.Location = new Point(146, 52);
            TxtRemarks.Margin = new Padding(0, 3, 0, 3);
            TxtRemarks.MaxLength = 50;
            TxtRemarks.Name = "TxtRemarks";
            TxtRemarks.Size = new Size(161, 27);
            TxtRemarks.TabIndex = 3;
            // 
            // BtnLogInOut
            // 
            BtnLogInOut.Dock = DockStyle.Fill;
            BtnLogInOut.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnLogInOut.ForeColor = Color.Maroon;
            BtnLogInOut.Location = new Point(310, 88);
            BtnLogInOut.Name = "BtnLogInOut";
            BtnLogInOut.Size = new Size(74, 32);
            BtnLogInOut.TabIndex = 4;
            BtnLogInOut.Text = "&Login";
            BtnLogInOut.UseVisualStyleBackColor = false;
            BtnLogInOut.Click += BtnUpdate_Click;
            // 
            // BtnExit
            // 
            BtnExit.Dock = DockStyle.Fill;
            BtnExit.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnExit.ForeColor = Color.Red;
            BtnExit.Location = new Point(390, 88);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(74, 32);
            BtnExit.TabIndex = 5;
            BtnExit.Text = "E&xit";
            BtnExit.UseVisualStyleBackColor = false;
            BtnExit.Click += BtnExit_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(dgvTodayData, 0, 1);
            tableLayoutPanel2.Controls.Add(dgvMonthlyData, 0, 3);
            tableLayoutPanel2.Controls.Add(label4, 0, 0);
            tableLayoutPanel2.Controls.Add(label5, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(24, 173);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(504, 363);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // dgvTodayData
            // 
            dgvTodayData.AllowUserToAddRows = false;
            dgvTodayData.AllowUserToDeleteRows = false;
            dgvTodayData.BackgroundColor = SystemColors.ControlLight;
            dgvTodayData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTodayData.Dock = DockStyle.Fill;
            dgvTodayData.Location = new Point(3, 39);
            dgvTodayData.Name = "dgvTodayData";
            dgvTodayData.ReadOnly = true;
            dgvTodayData.RowHeadersVisible = false;
            dgvTodayData.RowTemplate.Height = 25;
            dgvTodayData.Size = new Size(498, 102);
            dgvTodayData.TabIndex = 1;
            // 
            // dgvMonthlyData
            // 
            dgvMonthlyData.AllowUserToAddRows = false;
            dgvMonthlyData.AllowUserToDeleteRows = false;
            dgvMonthlyData.BackgroundColor = Color.FromArgb(224, 224, 224);
            dgvMonthlyData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMonthlyData.Dock = DockStyle.Fill;
            dgvMonthlyData.Location = new Point(3, 183);
            dgvMonthlyData.Name = "dgvMonthlyData";
            dgvMonthlyData.ReadOnly = true;
            dgvMonthlyData.RowHeadersVisible = false;
            dgvMonthlyData.RowTemplate.Height = 25;
            dgvMonthlyData.Size = new Size(498, 177);
            dgvMonthlyData.TabIndex = 3;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(0, 6);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(504, 23);
            label4.TabIndex = 0;
            label4.Text = "Daily Status";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(0, 150);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Size = new Size(504, 23);
            label5.TabIndex = 2;
            label5.Text = "Monthly Status";
            // 
            // ErrorProvider
            // 
            ErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            ErrorProvider.ContainerControl = this;
            // 
            // FrmAttendance
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1063, 539);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(0, 64, 64);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmAttendance";
            Text = "Attendance";
            Load += FrmAttendance_Load;
            KeyDown += FrmAttendance_KeyDown;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTodayData).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMonthlyData).EndInit();
            ((System.ComponentModel.ISupportInitialize)ErrorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button BtnLogInOut;
        private Button BtnExit;
        private Panel panel1;
        private ErrorProvider ErrorProvider;
        private TableLayoutPanel tableLayoutPanel3;
        private FolderBrowserDialog folderBrowserDialog1;
        private Label label1;
        private Label LblCurrentUserName;
        private Label label3;
        private TextBox TxtRemarks;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridView dgvTodayData;
        private DataGridView dgvMonthlyData;
        private Label label4;
        private Label label5;
    }
}