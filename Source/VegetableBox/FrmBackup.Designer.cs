namespace VegetableBox
{
    partial class FrmBackup
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
            TxtBackupPath = new TextBox();
            BtnBrowse = new Button();
            BtnBackup = new Button();
            BtnExit = new Button();
            label1 = new Label();
            ErrorProvider = new ErrorProvider(components);
            folderBrowserDialog1 = new FolderBrowserDialog();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.Size = new Size(1199, 590);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(tableLayoutPanel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(122, 209);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(3);
            panel1.Size = new Size(953, 171);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 6;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel3.Controls.Add(TxtBackupPath, 1, 1);
            tableLayoutPanel3.Controls.Add(BtnBrowse, 2, 1);
            tableLayoutPanel3.Controls.Add(BtnBackup, 3, 1);
            tableLayoutPanel3.Controls.Add(BtnExit, 4, 1);
            tableLayoutPanel3.Controls.Add(label1, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel3.Size = new Size(945, 163);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // TxtBackupPath
            // 
            TxtBackupPath.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtBackupPath.Location = new Point(50, 68);
            TxtBackupPath.Name = "TxtBackupPath";
            TxtBackupPath.Size = new Size(561, 27);
            TxtBackupPath.TabIndex = 1;
            // 
            // BtnBrowse
            // 
            BtnBrowse.Dock = DockStyle.Fill;
            BtnBrowse.ForeColor = Color.Maroon;
            BtnBrowse.Location = new Point(617, 68);
            BtnBrowse.Name = "BtnBrowse";
            BtnBrowse.Size = new Size(88, 26);
            BtnBrowse.TabIndex = 2;
            BtnBrowse.Text = "B&rowse";
            BtnBrowse.UseVisualStyleBackColor = true;
            BtnBrowse.Click += BtnBrowse_Click;
            // 
            // BtnBackup
            // 
            BtnBackup.Dock = DockStyle.Fill;
            BtnBackup.ForeColor = Color.Purple;
            BtnBackup.Location = new Point(711, 68);
            BtnBackup.Name = "BtnBackup";
            BtnBackup.Size = new Size(88, 26);
            BtnBackup.TabIndex = 3;
            BtnBackup.Text = "&Backup";
            BtnBackup.UseVisualStyleBackColor = true;
            BtnBackup.Click += BtnBackup_Click;
            // 
            // BtnExit
            // 
            BtnExit.Dock = DockStyle.Fill;
            BtnExit.ForeColor = Color.Red;
            BtnExit.Location = new Point(805, 68);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(88, 26);
            BtnExit.TabIndex = 4;
            BtnExit.Text = "E&xit";
            BtnExit.UseVisualStyleBackColor = true;
            BtnExit.Click += BtnExit_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(47, 46);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(88, 19);
            label1.TabIndex = 0;
            label1.Text = "Folder Path";
            // 
            // ErrorProvider
            // 
            ErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            ErrorProvider.ContainerControl = this;
            // 
            // FrmBackup
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1199, 590);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(0, 64, 64);
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmBackup";
            Text = "Backup";
            Load += FrmBackup_Load;
            KeyDown += FrmBackup_KeyDown;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ErrorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button BtnBrowse;
        private Button BtnExit;
        private Panel panel1;
        private ErrorProvider ErrorProvider;
        private TableLayoutPanel tableLayoutPanel3;
        private Button BtnBackup;
        private FolderBrowserDialog folderBrowserDialog1;
        private TextBox TxtBackupPath;
        private Label label1;
    }
}