namespace VegetableBox
{
    partial class FrmUserMaster
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
            TlpMain = new TableLayoutPanel();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            LblUserName = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            BtnSave = new Button();
            BtnCancel = new Button();
            TxtUserName = new TextBox();
            LblVendorShortName = new Label();
            TxtPassword = new TextBox();
            LblActive = new Label();
            CmbActive = new ComboBox();
            panel2 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            DGView = new DataGridView();
            tableLayoutPanel4 = new TableLayoutPanel();
            BtnExit = new Button();
            BtnEdit = new Button();
            BtnDelete = new Button();
            LblHelp = new Label();
            PanelFilter = new Panel();
            tableLayoutPanel5 = new TableLayoutPanel();
            LblFilters = new Label();
            LblFilterUser = new Label();
            TxtFilterUser = new TextBox();
            CmbFilterActive = new ComboBox();
            LblFilterActive = new Label();
            ErrorProvider = new ErrorProvider(components);
            TlpMain.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGView).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            PanelFilter.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // TlpMain
            // 
            TlpMain.ColumnCount = 4;
            TlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 0.9933658F));
            TlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.36868F));
            TlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63.643528F));
            TlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 0.9944301F));
            TlpMain.Controls.Add(panel1, 1, 2);
            TlpMain.Controls.Add(panel2, 2, 1);
            TlpMain.Dock = DockStyle.Fill;
            TlpMain.Location = new Point(0, 0);
            TlpMain.Margin = new Padding(3, 4, 3, 4);
            TlpMain.Name = "TlpMain";
            TlpMain.RowCount = 5;
            TlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 2.93153F));
            TlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 24.3903351F));
            TlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 45.35627F));
            TlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 24.3903351F));
            TlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 2.93153071F));
            TlpMain.Size = new Size(972, 529);
            TlpMain.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(12, 148);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(328, 231);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3.0226233F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 93.95475F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3.02262378F));
            tableLayoutPanel1.Controls.Add(LblUserName, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 2, 6);
            tableLayoutPanel1.Controls.Add(TxtUserName, 2, 1);
            tableLayoutPanel1.Controls.Add(LblVendorShortName, 1, 2);
            tableLayoutPanel1.Controls.Add(TxtPassword, 2, 2);
            tableLayoutPanel1.Controls.Add(LblActive, 1, 3);
            tableLayoutPanel1.Controls.Add(CmbActive, 2, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 2.016268F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6941681F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6941681F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6941681F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6878433F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.69418F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5029478F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 2.01626754F));
            tableLayoutPanel1.Size = new Size(326, 229);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // LblUserName
            // 
            LblUserName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblUserName.AutoSize = true;
            LblUserName.ForeColor = Color.FromArgb(163, 0, 34);
            LblUserName.Location = new Point(10, 14);
            LblUserName.Name = "LblUserName";
            LblUserName.Size = new Size(84, 18);
            LblUserName.TabIndex = 0;
            LblUserName.Text = "User Name*";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.1437111F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.9281425F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.9281425F));
            tableLayoutPanel2.Controls.Add(BtnSave, 1, 0);
            tableLayoutPanel2.Controls.Add(BtnCancel, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(97, 194);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(221, 28);
            tableLayoutPanel2.TabIndex = 10;
            // 
            // BtnSave
            // 
            BtnSave.BackColor = SystemColors.Control;
            BtnSave.Dock = DockStyle.Fill;
            BtnSave.ForeColor = Color.Green;
            BtnSave.Location = new Point(65, 3);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(73, 22);
            BtnSave.TabIndex = 0;
            BtnSave.Text = "&Save";
            BtnSave.UseVisualStyleBackColor = false;
            BtnSave.Click += BtnSave_Click;
            // 
            // BtnCancel
            // 
            BtnCancel.BackColor = SystemColors.Control;
            BtnCancel.Dock = DockStyle.Fill;
            BtnCancel.ForeColor = Color.Red;
            BtnCancel.Location = new Point(144, 3);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(74, 22);
            BtnCancel.TabIndex = 1;
            BtnCancel.Text = "&Cancel";
            BtnCancel.UseVisualStyleBackColor = false;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // TxtUserName
            // 
            TxtUserName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtUserName.BackColor = Color.White;
            TxtUserName.ForeColor = Color.DarkGreen;
            TxtUserName.Location = new Point(100, 10);
            TxtUserName.MaxLength = 15;
            TxtUserName.Name = "TxtUserName";
            TxtUserName.Size = new Size(215, 26);
            TxtUserName.TabIndex = 1;
            TxtUserName.Enter += TextBox_Enter;
            TxtUserName.Leave += TextBox_Leave;
            // 
            // LblVendorShortName
            // 
            LblVendorShortName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblVendorShortName.AutoSize = true;
            LblVendorShortName.ForeColor = Color.FromArgb(163, 0, 34);
            LblVendorShortName.Location = new Point(10, 52);
            LblVendorShortName.Name = "LblVendorShortName";
            LblVendorShortName.Size = new Size(84, 18);
            LblVendorShortName.TabIndex = 2;
            LblVendorShortName.Text = "Password*";
            // 
            // TxtPassword
            // 
            TxtPassword.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtPassword.BackColor = Color.White;
            TxtPassword.ForeColor = Color.DarkGreen;
            TxtPassword.Location = new Point(100, 48);
            TxtPassword.MaxLength = 15;
            TxtPassword.Name = "TxtPassword";
            TxtPassword.PasswordChar = '*';
            TxtPassword.Size = new Size(215, 26);
            TxtPassword.TabIndex = 3;
            TxtPassword.Enter += TextBox_Enter;
            TxtPassword.Leave += TextBox_Leave;
            // 
            // LblActive
            // 
            LblActive.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblActive.AutoSize = true;
            LblActive.ForeColor = Color.FromArgb(163, 0, 34);
            LblActive.Location = new Point(10, 90);
            LblActive.Name = "LblActive";
            LblActive.Size = new Size(84, 18);
            LblActive.TabIndex = 8;
            LblActive.Text = "Active*";
            // 
            // CmbActive
            // 
            CmbActive.Anchor = AnchorStyles.Left;
            CmbActive.BackColor = Color.White;
            CmbActive.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbActive.FlatStyle = FlatStyle.Flat;
            CmbActive.ForeColor = Color.DarkGreen;
            CmbActive.FormattingEnabled = true;
            CmbActive.Location = new Point(100, 87);
            CmbActive.Name = "CmbActive";
            CmbActive.Size = new Size(121, 26);
            CmbActive.TabIndex = 9;
            CmbActive.Enter += ComboBox_Enter;
            CmbActive.Leave += ComboBox_Leave;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(tableLayoutPanel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(346, 18);
            panel2.Name = "panel2";
            TlpMain.SetRowSpan(panel2, 3);
            panel2.Size = new Size(612, 491);
            panel2.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(DGView, 0, 1);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 2);
            tableLayoutPanel3.Controls.Add(PanelFilter, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.3909779F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 76.54135F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            tableLayoutPanel3.Size = new Size(610, 489);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // DGView
            // 
            DGView.AllowUserToAddRows = false;
            DGView.AllowUserToDeleteRows = false;
            DGView.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DGView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DGView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.SelectionForeColor = Color.ForestGreen;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DGView.DefaultCellStyle = dataGridViewCellStyle2;
            DGView.Dock = DockStyle.Fill;
            DGView.Location = new Point(5, 83);
            DGView.Margin = new Padding(5, 3, 3, 3);
            DGView.MultiSelect = false;
            DGView.Name = "DGView";
            DGView.ReadOnly = true;
            DGView.RowHeadersVisible = false;
            DGView.RowTemplate.Height = 25;
            DGView.Size = new Size(602, 368);
            DGView.TabIndex = 0;
            DGView.CellEnter += DGView_CellEnter;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 4;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.0851059F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.638298F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.638298F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.638298F));
            tableLayoutPanel4.Controls.Add(BtnExit, 3, 0);
            tableLayoutPanel4.Controls.Add(BtnEdit, 2, 0);
            tableLayoutPanel4.Controls.Add(BtnDelete, 1, 0);
            tableLayoutPanel4.Controls.Add(LblHelp, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 457);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(604, 29);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // BtnExit
            // 
            BtnExit.BackColor = SystemColors.Control;
            BtnExit.Dock = DockStyle.Fill;
            BtnExit.ForeColor = Color.Crimson;
            BtnExit.Location = new Point(542, 3);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(59, 23);
            BtnExit.TabIndex = 3;
            BtnExit.Text = "E&xit";
            BtnExit.UseVisualStyleBackColor = false;
            BtnExit.Click += BtnExit_Click;
            // 
            // BtnEdit
            // 
            BtnEdit.BackColor = SystemColors.Control;
            BtnEdit.Dock = DockStyle.Fill;
            BtnEdit.ForeColor = Color.SaddleBrown;
            BtnEdit.Location = new Point(478, 3);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(58, 23);
            BtnEdit.TabIndex = 2;
            BtnEdit.Text = "&Edit";
            BtnEdit.UseVisualStyleBackColor = false;
            BtnEdit.Click += BtnEdit_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.BackColor = SystemColors.Control;
            BtnDelete.Dock = DockStyle.Fill;
            BtnDelete.ForeColor = Color.OrangeRed;
            BtnDelete.Location = new Point(414, 3);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(58, 23);
            BtnDelete.TabIndex = 1;
            BtnDelete.Text = "Delete";
            BtnDelete.UseVisualStyleBackColor = false;
            BtnDelete.Visible = false;
            // 
            // LblHelp
            // 
            LblHelp.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblHelp.AutoSize = true;
            LblHelp.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LblHelp.Location = new Point(3, 7);
            LblHelp.Name = "LblHelp";
            LblHelp.Size = new Size(405, 15);
            LblHelp.TabIndex = 0;
            LblHelp.Text = "Focus : Ctrl + G => Grid View && F1 => Filter";
            // 
            // PanelFilter
            // 
            PanelFilter.BorderStyle = BorderStyle.FixedSingle;
            PanelFilter.Controls.Add(tableLayoutPanel5);
            PanelFilter.Dock = DockStyle.Fill;
            PanelFilter.Location = new Point(3, 3);
            PanelFilter.Name = "PanelFilter";
            PanelFilter.Size = new Size(604, 74);
            PanelFilter.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 8;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3.5638814F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.9053421F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.60825F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4.435489F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.5973148F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.8897228F));
            tableLayoutPanel5.Controls.Add(LblFilters, 0, 1);
            tableLayoutPanel5.Controls.Add(LblFilterUser, 1, 2);
            tableLayoutPanel5.Controls.Add(TxtFilterUser, 2, 2);
            tableLayoutPanel5.Controls.Add(CmbFilterActive, 6, 2);
            tableLayoutPanel5.Controls.Add(LblFilterActive, 5, 2);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 4;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 10.7382545F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 26.1744957F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 52.34899F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 10.7382565F));
            tableLayoutPanel5.Size = new Size(602, 72);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // LblFilters
            // 
            LblFilters.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblFilters.AutoSize = true;
            tableLayoutPanel5.SetColumnSpan(LblFilters, 2);
            LblFilters.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            LblFilters.ForeColor = Color.DarkGreen;
            LblFilters.Location = new Point(3, 7);
            LblFilters.Name = "LblFilters";
            LblFilters.Size = new Size(97, 18);
            LblFilters.TabIndex = 0;
            LblFilters.Text = "Filters";
            // 
            // LblFilterUser
            // 
            LblFilterUser.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblFilterUser.AutoSize = true;
            LblFilterUser.ForeColor = Color.FromArgb(163, 0, 34);
            LblFilterUser.Location = new Point(19, 34);
            LblFilterUser.Name = "LblFilterUser";
            LblFilterUser.Size = new Size(81, 18);
            LblFilterUser.TabIndex = 1;
            LblFilterUser.Text = "User Search";
            // 
            // TxtFilterUser
            // 
            TxtFilterUser.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtFilterUser.BackColor = Color.White;
            tableLayoutPanel5.SetColumnSpan(TxtFilterUser, 2);
            TxtFilterUser.ForeColor = Color.DarkGreen;
            TxtFilterUser.Location = new Point(106, 30);
            TxtFilterUser.MaxLength = 25;
            TxtFilterUser.Name = "TxtFilterUser";
            TxtFilterUser.Size = new Size(245, 26);
            TxtFilterUser.TabIndex = 2;
            TxtFilterUser.TextChanged += TxtFilterProduct_TextChanged;
            TxtFilterUser.Enter += TextBox_Enter;
            TxtFilterUser.Leave += TextBox_Leave;
            // 
            // CmbFilterActive
            // 
            CmbFilterActive.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CmbFilterActive.BackColor = Color.White;
            CmbFilterActive.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbFilterActive.FlatStyle = FlatStyle.Flat;
            CmbFilterActive.ForeColor = Color.DarkGreen;
            CmbFilterActive.FormattingEnabled = true;
            CmbFilterActive.Location = new Point(430, 32);
            CmbFilterActive.Name = "CmbFilterActive";
            CmbFilterActive.Size = new Size(70, 26);
            CmbFilterActive.TabIndex = 4;
            CmbFilterActive.SelectedIndexChanged += CmbFilterQtyType_SelectedIndexChanged;
            CmbFilterActive.Enter += ComboBox_Enter;
            CmbFilterActive.Leave += ComboBox_Leave;
            // 
            // LblFilterActive
            // 
            LblFilterActive.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblFilterActive.AutoSize = true;
            LblFilterActive.ForeColor = Color.FromArgb(163, 0, 34);
            LblFilterActive.Location = new Point(377, 34);
            LblFilterActive.Name = "LblFilterActive";
            LblFilterActive.Size = new Size(47, 18);
            LblFilterActive.TabIndex = 3;
            LblFilterActive.Text = "Active";
            // 
            // ErrorProvider
            // 
            ErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            ErrorProvider.ContainerControl = this;
            // 
            // FrmUserMaster
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(972, 529);
            Controls.Add(TlpMain);
            Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmUserMaster";
            Text = "User - Master";
            Activated += FrmVendorMaster_Activated;
            Load += FrmUserMaster_Load;
            KeyDown += FrmVendorMaster_KeyDown;
            TlpMain.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGView).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            PanelFilter.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ErrorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TlpMain;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label LblUserName;
        private Label LblVendorShortName;
        private Label LblActive;
        private TableLayoutPanel tableLayoutPanel2;
        private Button BtnSave;
        private Button BtnCancel;
        private TextBox TxtUserName;
        private TextBox TxtPassword;
        private ComboBox CmbActive;
        private DataGridView DGView;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel4;
        private Button BtnEdit;
        private Button BtnDelete;
        private TableLayoutPanel tableLayoutPanel3;
        private Button BtnExit;
        private TableLayoutPanel tableLayoutPanel5;
        private Label LblFilterActive;
        private Label LblFilterUser;
        private ComboBox CmbFilterActive;
        private TextBox TxtFilterUser;
        private Panel PanelFilter;
        private Label LblFilters;
        private ErrorProvider ErrorProvider;
        private Label LblHelp;
    }
}