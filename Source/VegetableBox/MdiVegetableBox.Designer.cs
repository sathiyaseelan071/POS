namespace VegetableBox
{
    partial class MdiVegetableBox
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
            Timer = new System.Windows.Forms.Timer(components);
            TlpMdiVegitableBox = new TableLayoutPanel();
            TlpMain = new TableLayoutPanel();
            TlpHeader = new TableLayoutPanel();
            menuStrip = new MenuStrip();
            ToolStripMenuItem_Master = new ToolStripMenuItem();
            ToolStripMenuItem_ProductMaster = new ToolStripMenuItem();
            ToolStripMenuItem_RateMaster = new ToolStripMenuItem();
            ToolStripMenuItem_UserMaster = new ToolStripMenuItem();
            ToolStripMenuItem_VendorMaster = new ToolStripMenuItem();
            ToolStripMenuItem_CustomerMaster = new ToolStripMenuItem();
            ToolStripMenuItem_ExpenseMaster = new ToolStripMenuItem();
            ToolStripMenuItem_Billing = new ToolStripMenuItem();
            pOSToolStripMenuItem = new ToolStripMenuItem();
            rePrintToolStripMenuItem = new ToolStripMenuItem();
            ToolStripMenuItem_Order = new ToolStripMenuItem();
            ToolStripMenuItem_VendorInvoiceEntry = new ToolStripMenuItem();
            purchaseEntryToolStripMenuItem = new ToolStripMenuItem();
            tagPrintToolStripMenuItem = new ToolStripMenuItem();
            ToolStripMenuItem_Accounts = new ToolStripMenuItem();
            ToolStripMenuItem_ExpenseEntry_Click = new ToolStripMenuItem();
            ToolStripMenuItem_CustomerCreditDebit = new ToolStripMenuItem();
            ToolStripMenuItem_VendorPayment = new ToolStripMenuItem();
            ToolStripMenuItem_UndiyalCreditDebit = new ToolStripMenuItem();
            ToolStripMenuItem_DailyAccountClosing = new ToolStripMenuItem();
            ToolStripMenuItem_Reports = new ToolStripMenuItem();
            purchaseReportToolStripMenuItem = new ToolStripMenuItem();
            ToolStripMenuItem_Settings = new ToolStripMenuItem();
            ToolStripMenuItem_Backup = new ToolStripMenuItem();
            LblFormHeader = new Label();
            TlpClose = new TableLayoutPanel();
            PicBoxMinimize = new PictureBox();
            PicBoxClose = new PictureBox();
            LblUserName = new Label();
            TlpForm = new TableLayoutPanel();
            PicBoxMdi = new PictureBox();
            TlpFooder = new TableLayoutPanel();
            LblDate = new Label();
            LblTime = new Label();
            PicBoxCompanyLogo = new PictureBox();
            TlpMdiVegitableBox.SuspendLayout();
            TlpMain.SuspendLayout();
            TlpHeader.SuspendLayout();
            menuStrip.SuspendLayout();
            TlpClose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicBoxMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicBoxClose).BeginInit();
            TlpForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicBoxMdi).BeginInit();
            TlpFooder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicBoxCompanyLogo).BeginInit();
            SuspendLayout();
            // 
            // Timer
            // 
            Timer.Interval = 1;
            Timer.Tick += Timer_Tick;
            // 
            // TlpMdiVegitableBox
            // 
            TlpMdiVegitableBox.BackColor = Color.ForestGreen;
            TlpMdiVegitableBox.ColumnCount = 1;
            TlpMdiVegitableBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TlpMdiVegitableBox.Controls.Add(TlpMain, 0, 0);
            TlpMdiVegitableBox.Dock = DockStyle.Fill;
            TlpMdiVegitableBox.Location = new Point(0, 0);
            TlpMdiVegitableBox.Margin = new Padding(0);
            TlpMdiVegitableBox.Name = "TlpMdiVegitableBox";
            TlpMdiVegitableBox.RowCount = 1;
            TlpMdiVegitableBox.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TlpMdiVegitableBox.Size = new Size(1370, 608);
            TlpMdiVegitableBox.TabIndex = 1;
            // 
            // TlpMain
            // 
            TlpMain.BackColor = Color.Transparent;
            TlpMain.ColumnCount = 1;
            TlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TlpMain.Controls.Add(TlpHeader, 0, 0);
            TlpMain.Controls.Add(TlpForm, 0, 1);
            TlpMain.Controls.Add(TlpFooder, 0, 2);
            TlpMain.Dock = DockStyle.Fill;
            TlpMain.Location = new Point(5, 5);
            TlpMain.Margin = new Padding(5);
            TlpMain.Name = "TlpMain";
            TlpMain.RowCount = 3;
            TlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 7.84313726F));
            TlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 84.31373F));
            TlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 7.84313726F));
            TlpMain.Size = new Size(1360, 598);
            TlpMain.TabIndex = 0;
            // 
            // TlpHeader
            // 
            TlpHeader.BackColor = Color.FromArgb(245, 244, 242);
            TlpHeader.ColumnCount = 3;
            TlpHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67F));
            TlpHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            TlpHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13F));
            TlpHeader.Controls.Add(menuStrip, 0, 0);
            TlpHeader.Controls.Add(LblFormHeader, 1, 0);
            TlpHeader.Controls.Add(TlpClose, 2, 0);
            TlpHeader.Dock = DockStyle.Fill;
            TlpHeader.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            TlpHeader.Location = new Point(1, 1);
            TlpHeader.Margin = new Padding(1);
            TlpHeader.Name = "TlpHeader";
            TlpHeader.RowCount = 1;
            TlpHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TlpHeader.Size = new Size(1358, 44);
            TlpHeader.TabIndex = 0;
            // 
            // menuStrip
            // 
            menuStrip.Dock = DockStyle.Fill;
            menuStrip.Items.AddRange(new ToolStripItem[] { ToolStripMenuItem_Master, ToolStripMenuItem_Billing, ToolStripMenuItem_Order, ToolStripMenuItem_Accounts, ToolStripMenuItem_Reports, ToolStripMenuItem_Settings });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(909, 44);
            menuStrip.TabIndex = 0;
            // 
            // ToolStripMenuItem_Master
            // 
            ToolStripMenuItem_Master.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuItem_ProductMaster, ToolStripMenuItem_RateMaster, ToolStripMenuItem_UserMaster, ToolStripMenuItem_VendorMaster, ToolStripMenuItem_CustomerMaster, ToolStripMenuItem_ExpenseMaster });
            ToolStripMenuItem_Master.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ToolStripMenuItem_Master.ForeColor = Color.FromArgb(163, 0, 34);
            ToolStripMenuItem_Master.Name = "ToolStripMenuItem_Master";
            ToolStripMenuItem_Master.Size = new Size(80, 40);
            ToolStripMenuItem_Master.Text = "&Master";
            // 
            // ToolStripMenuItem_ProductMaster
            // 
            ToolStripMenuItem_ProductMaster.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ToolStripMenuItem_ProductMaster.ForeColor = Color.DarkGreen;
            ToolStripMenuItem_ProductMaster.Name = "ToolStripMenuItem_ProductMaster";
            ToolStripMenuItem_ProductMaster.Size = new Size(196, 24);
            ToolStripMenuItem_ProductMaster.Text = "Product Master";
            ToolStripMenuItem_ProductMaster.Click += ToolStripMenuItem_ProductMaster_Click;
            // 
            // ToolStripMenuItem_RateMaster
            // 
            ToolStripMenuItem_RateMaster.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ToolStripMenuItem_RateMaster.ForeColor = Color.DarkGreen;
            ToolStripMenuItem_RateMaster.Name = "ToolStripMenuItem_RateMaster";
            ToolStripMenuItem_RateMaster.Size = new Size(196, 24);
            ToolStripMenuItem_RateMaster.Text = "Rate Master";
            ToolStripMenuItem_RateMaster.Click += ToolStripMenuItem_RateMaster_Click;
            // 
            // ToolStripMenuItem_UserMaster
            // 
            ToolStripMenuItem_UserMaster.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ToolStripMenuItem_UserMaster.ForeColor = Color.DarkGreen;
            ToolStripMenuItem_UserMaster.Name = "ToolStripMenuItem_UserMaster";
            ToolStripMenuItem_UserMaster.Size = new Size(196, 24);
            ToolStripMenuItem_UserMaster.Text = "User Master";
            ToolStripMenuItem_UserMaster.Click += ToolStripMenuItem_UserMaster_Click;
            // 
            // ToolStripMenuItem_VendorMaster
            // 
            ToolStripMenuItem_VendorMaster.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ToolStripMenuItem_VendorMaster.ForeColor = Color.DarkGreen;
            ToolStripMenuItem_VendorMaster.Name = "ToolStripMenuItem_VendorMaster";
            ToolStripMenuItem_VendorMaster.Size = new Size(196, 24);
            ToolStripMenuItem_VendorMaster.Text = "Vendor Master";
            ToolStripMenuItem_VendorMaster.Click += ToolStripMenuItem_VendorMaster_Click;
            // 
            // ToolStripMenuItem_CustomerMaster
            // 
            ToolStripMenuItem_CustomerMaster.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ToolStripMenuItem_CustomerMaster.ForeColor = Color.DarkGreen;
            ToolStripMenuItem_CustomerMaster.Name = "ToolStripMenuItem_CustomerMaster";
            ToolStripMenuItem_CustomerMaster.Size = new Size(196, 24);
            ToolStripMenuItem_CustomerMaster.Text = "Customer Master";
            ToolStripMenuItem_CustomerMaster.Click += ToolStripMenuItem_CustomerMaster_Click;
            // 
            // ToolStripMenuItem_ExpenseMaster
            // 
            ToolStripMenuItem_ExpenseMaster.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ToolStripMenuItem_ExpenseMaster.ForeColor = Color.DarkGreen;
            ToolStripMenuItem_ExpenseMaster.Name = "ToolStripMenuItem_ExpenseMaster";
            ToolStripMenuItem_ExpenseMaster.Size = new Size(196, 24);
            ToolStripMenuItem_ExpenseMaster.Text = "Expense Master";
            ToolStripMenuItem_ExpenseMaster.Click += ToolStripMenuItem_ExpenseMaster_Click;
            // 
            // ToolStripMenuItem_Billing
            // 
            ToolStripMenuItem_Billing.DropDownItems.AddRange(new ToolStripItem[] { pOSToolStripMenuItem, rePrintToolStripMenuItem });
            ToolStripMenuItem_Billing.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ToolStripMenuItem_Billing.ForeColor = Color.FromArgb(163, 0, 34);
            ToolStripMenuItem_Billing.Name = "ToolStripMenuItem_Billing";
            ToolStripMenuItem_Billing.Size = new Size(72, 40);
            ToolStripMenuItem_Billing.Text = "&Billing";
            // 
            // pOSToolStripMenuItem
            // 
            pOSToolStripMenuItem.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            pOSToolStripMenuItem.ForeColor = Color.DarkGreen;
            pOSToolStripMenuItem.Name = "pOSToolStripMenuItem";
            pOSToolStripMenuItem.Size = new Size(135, 24);
            pOSToolStripMenuItem.Text = "POS";
            pOSToolStripMenuItem.Click += pOSToolStripMenuItem_Click;
            // 
            // rePrintToolStripMenuItem
            // 
            rePrintToolStripMenuItem.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rePrintToolStripMenuItem.ForeColor = Color.DarkGreen;
            rePrintToolStripMenuItem.Name = "rePrintToolStripMenuItem";
            rePrintToolStripMenuItem.Size = new Size(135, 24);
            rePrintToolStripMenuItem.Text = "Re-Print";
            rePrintToolStripMenuItem.Click += rePrintToolStripMenuItem_Click;
            // 
            // ToolStripMenuItem_Order
            // 
            ToolStripMenuItem_Order.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuItem_VendorInvoiceEntry, purchaseEntryToolStripMenuItem, tagPrintToolStripMenuItem });
            ToolStripMenuItem_Order.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ToolStripMenuItem_Order.ForeColor = Color.FromArgb(163, 0, 34);
            ToolStripMenuItem_Order.Name = "ToolStripMenuItem_Order";
            ToolStripMenuItem_Order.Size = new Size(94, 40);
            ToolStripMenuItem_Order.Text = "&Purchase";
            // 
            // ToolStripMenuItem_VendorInvoiceEntry
            // 
            ToolStripMenuItem_VendorInvoiceEntry.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ToolStripMenuItem_VendorInvoiceEntry.ForeColor = Color.DarkGreen;
            ToolStripMenuItem_VendorInvoiceEntry.Name = "ToolStripMenuItem_VendorInvoiceEntry";
            ToolStripMenuItem_VendorInvoiceEntry.Size = new Size(222, 24);
            ToolStripMenuItem_VendorInvoiceEntry.Text = "&Vendor Invoice Entry";
            ToolStripMenuItem_VendorInvoiceEntry.Click += ToolStripMenuItem_VendorInvoiceEntry_Click;
            // 
            // purchaseEntryToolStripMenuItem
            // 
            purchaseEntryToolStripMenuItem.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            purchaseEntryToolStripMenuItem.ForeColor = Color.DarkGreen;
            purchaseEntryToolStripMenuItem.Name = "purchaseEntryToolStripMenuItem";
            purchaseEntryToolStripMenuItem.Size = new Size(222, 24);
            purchaseEntryToolStripMenuItem.Text = "P&urchase Entry";
            purchaseEntryToolStripMenuItem.Click += purchaseEntryToolStripMenuItem_Click;
            // 
            // tagPrintToolStripMenuItem
            // 
            tagPrintToolStripMenuItem.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tagPrintToolStripMenuItem.ForeColor = Color.DarkGreen;
            tagPrintToolStripMenuItem.Name = "tagPrintToolStripMenuItem";
            tagPrintToolStripMenuItem.Size = new Size(222, 24);
            tagPrintToolStripMenuItem.Text = "&Tag Print";
            tagPrintToolStripMenuItem.Click += tagPrintToolStripMenuItem_Click;
            // 
            // ToolStripMenuItem_Accounts
            // 
            ToolStripMenuItem_Accounts.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuItem_ExpenseEntry_Click, ToolStripMenuItem_CustomerCreditDebit, ToolStripMenuItem_VendorPayment, ToolStripMenuItem_UndiyalCreditDebit, ToolStripMenuItem_DailyAccountClosing });
            ToolStripMenuItem_Accounts.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ToolStripMenuItem_Accounts.ForeColor = Color.FromArgb(163, 0, 34);
            ToolStripMenuItem_Accounts.Name = "ToolStripMenuItem_Accounts";
            ToolStripMenuItem_Accounts.Size = new Size(95, 40);
            ToolStripMenuItem_Accounts.Text = "&Accounts";
            // 
            // ToolStripMenuItem_ExpenseEntry_Click
            // 
            ToolStripMenuItem_ExpenseEntry_Click.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ToolStripMenuItem_ExpenseEntry_Click.ForeColor = Color.DarkGreen;
            ToolStripMenuItem_ExpenseEntry_Click.Name = "ToolStripMenuItem_ExpenseEntry_Click";
            ToolStripMenuItem_ExpenseEntry_Click.Size = new Size(273, 24);
            ToolStripMenuItem_ExpenseEntry_Click.Text = "Expense Recorder";
            ToolStripMenuItem_ExpenseEntry_Click.Click += expensesEntryToolStripMenuItem_Click;
            // 
            // ToolStripMenuItem_CustomerCreditDebit
            // 
            ToolStripMenuItem_CustomerCreditDebit.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ToolStripMenuItem_CustomerCreditDebit.ForeColor = Color.DarkGreen;
            ToolStripMenuItem_CustomerCreditDebit.Name = "ToolStripMenuItem_CustomerCreditDebit";
            ToolStripMenuItem_CustomerCreditDebit.Size = new Size(273, 24);
            ToolStripMenuItem_CustomerCreditDebit.Text = "Customer (Credit/Debit)";
            ToolStripMenuItem_CustomerCreditDebit.Click += ToolStripMenuItem_CustomerCreditDebit_Click;
            // 
            // ToolStripMenuItem_VendorPayment
            // 
            ToolStripMenuItem_VendorPayment.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ToolStripMenuItem_VendorPayment.ForeColor = Color.DarkGreen;
            ToolStripMenuItem_VendorPayment.Name = "ToolStripMenuItem_VendorPayment";
            ToolStripMenuItem_VendorPayment.Size = new Size(273, 24);
            ToolStripMenuItem_VendorPayment.Text = "Vendor Bill Payment";
            ToolStripMenuItem_VendorPayment.Click += ToolStripMenuItem_VendorPayment_Click;
            // 
            // ToolStripMenuItem_UndiyalCreditDebit
            // 
            ToolStripMenuItem_UndiyalCreditDebit.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ToolStripMenuItem_UndiyalCreditDebit.ForeColor = Color.DarkGreen;
            ToolStripMenuItem_UndiyalCreditDebit.Name = "ToolStripMenuItem_UndiyalCreditDebit";
            ToolStripMenuItem_UndiyalCreditDebit.Size = new Size(273, 24);
            ToolStripMenuItem_UndiyalCreditDebit.Text = "Undiyal (Deposit/Withdraw)";
            ToolStripMenuItem_UndiyalCreditDebit.Click += ToolStripMenuItem_UndiyalCreditDebit_Click;
            // 
            // ToolStripMenuItem_DailyAccountClosing
            // 
            ToolStripMenuItem_DailyAccountClosing.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ToolStripMenuItem_DailyAccountClosing.ForeColor = Color.DarkGreen;
            ToolStripMenuItem_DailyAccountClosing.Name = "ToolStripMenuItem_DailyAccountClosing";
            ToolStripMenuItem_DailyAccountClosing.Size = new Size(273, 24);
            ToolStripMenuItem_DailyAccountClosing.Text = "Daily Cash Closing";
            ToolStripMenuItem_DailyAccountClosing.Click += ToolStripMenuItem_DailyAccountClosing_Click_Click;
            // 
            // ToolStripMenuItem_Reports
            // 
            ToolStripMenuItem_Reports.DropDownItems.AddRange(new ToolStripItem[] { purchaseReportToolStripMenuItem });
            ToolStripMenuItem_Reports.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ToolStripMenuItem_Reports.ForeColor = Color.FromArgb(163, 0, 34);
            ToolStripMenuItem_Reports.Name = "ToolStripMenuItem_Reports";
            ToolStripMenuItem_Reports.Size = new Size(85, 40);
            ToolStripMenuItem_Reports.Text = "&Reports";
            // 
            // purchaseReportToolStripMenuItem
            // 
            purchaseReportToolStripMenuItem.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            purchaseReportToolStripMenuItem.ForeColor = Color.DarkGreen;
            purchaseReportToolStripMenuItem.Name = "purchaseReportToolStripMenuItem";
            purchaseReportToolStripMenuItem.Size = new Size(180, 24);
            purchaseReportToolStripMenuItem.Text = "&All Report";
            purchaseReportToolStripMenuItem.Click += purchaseReportToolStripMenuItem_Click;
            // 
            // ToolStripMenuItem_Settings
            // 
            ToolStripMenuItem_Settings.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuItem_Backup });
            ToolStripMenuItem_Settings.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ToolStripMenuItem_Settings.ForeColor = Color.FromArgb(163, 0, 34);
            ToolStripMenuItem_Settings.Name = "ToolStripMenuItem_Settings";
            ToolStripMenuItem_Settings.Size = new Size(85, 40);
            ToolStripMenuItem_Settings.Text = "&Settings";
            // 
            // ToolStripMenuItem_Backup
            // 
            ToolStripMenuItem_Backup.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ToolStripMenuItem_Backup.ForeColor = Color.DarkGreen;
            ToolStripMenuItem_Backup.Name = "ToolStripMenuItem_Backup";
            ToolStripMenuItem_Backup.Size = new Size(180, 24);
            ToolStripMenuItem_Backup.Text = "&Backup";
            ToolStripMenuItem_Backup.Click += ToolStripMenuItem_Backup_Click;
            // 
            // LblFormHeader
            // 
            LblFormHeader.Anchor = AnchorStyles.Left;
            LblFormHeader.AutoSize = true;
            LblFormHeader.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point);
            LblFormHeader.ForeColor = Color.FromArgb(163, 0, 34);
            LblFormHeader.Location = new Point(912, 2);
            LblFormHeader.Name = "LblFormHeader";
            LblFormHeader.Size = new Size(80, 39);
            LblFormHeader.TabIndex = 1;
            LblFormHeader.Text = ".......";
            // 
            // TlpClose
            // 
            TlpClose.ColumnCount = 3;
            TlpClose.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.42857F));
            TlpClose.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            TlpClose.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            TlpClose.Controls.Add(PicBoxMinimize, 1, 0);
            TlpClose.Controls.Add(PicBoxClose, 2, 0);
            TlpClose.Controls.Add(LblUserName, 0, 1);
            TlpClose.Dock = DockStyle.Fill;
            TlpClose.Location = new Point(1183, 3);
            TlpClose.Name = "TlpClose";
            TlpClose.RowCount = 2;
            TlpClose.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TlpClose.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TlpClose.Size = new Size(172, 38);
            TlpClose.TabIndex = 2;
            // 
            // PicBoxMinimize
            // 
            PicBoxMinimize.Dock = DockStyle.Fill;
            PicBoxMinimize.Image = Properties.Resources.Minimize;
            PicBoxMinimize.Location = new Point(124, 2);
            PicBoxMinimize.Margin = new Padding(2);
            PicBoxMinimize.Name = "PicBoxMinimize";
            PicBoxMinimize.Size = new Size(20, 15);
            PicBoxMinimize.SizeMode = PictureBoxSizeMode.StretchImage;
            PicBoxMinimize.TabIndex = 0;
            PicBoxMinimize.TabStop = false;
            PicBoxMinimize.Click += PicBoxMinimize_Click;
            // 
            // PicBoxClose
            // 
            PicBoxClose.Dock = DockStyle.Fill;
            PicBoxClose.Image = Properties.Resources.Close;
            PicBoxClose.Location = new Point(148, 2);
            PicBoxClose.Margin = new Padding(2);
            PicBoxClose.Name = "PicBoxClose";
            PicBoxClose.Size = new Size(22, 15);
            PicBoxClose.SizeMode = PictureBoxSizeMode.StretchImage;
            PicBoxClose.TabIndex = 1;
            PicBoxClose.TabStop = false;
            PicBoxClose.Click += PicBoxClose_Click;
            // 
            // LblUserName
            // 
            LblUserName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblUserName.AutoSize = true;
            TlpClose.SetColumnSpan(LblUserName, 3);
            LblUserName.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblUserName.Location = new Point(3, 19);
            LblUserName.Name = "LblUserName";
            LblUserName.Size = new Size(166, 19);
            LblUserName.TabIndex = 2;
            LblUserName.Text = "User : Admin";
            LblUserName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TlpForm
            // 
            TlpForm.BackColor = Color.FromArgb(245, 244, 242);
            TlpForm.ColumnCount = 1;
            TlpForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TlpForm.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            TlpForm.Controls.Add(PicBoxMdi, 0, 0);
            TlpForm.Dock = DockStyle.Fill;
            TlpForm.Location = new Point(1, 47);
            TlpForm.Margin = new Padding(1);
            TlpForm.Name = "TlpForm";
            TlpForm.RowCount = 1;
            TlpForm.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TlpForm.Size = new Size(1358, 502);
            TlpForm.TabIndex = 1;
            // 
            // PicBoxMdi
            // 
            PicBoxMdi.Dock = DockStyle.Fill;
            PicBoxMdi.Image = Properties.Resources.TransparentLogo;
            PicBoxMdi.Location = new Point(3, 3);
            PicBoxMdi.Name = "PicBoxMdi";
            PicBoxMdi.Size = new Size(1352, 496);
            PicBoxMdi.SizeMode = PictureBoxSizeMode.CenterImage;
            PicBoxMdi.TabIndex = 0;
            PicBoxMdi.TabStop = false;
            // 
            // TlpFooder
            // 
            TlpFooder.BackColor = Color.FromArgb(245, 244, 242);
            TlpFooder.ColumnCount = 4;
            TlpFooder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.2800436F));
            TlpFooder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.2800436F));
            TlpFooder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54.15987F));
            TlpFooder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.2800436F));
            TlpFooder.Controls.Add(LblDate, 0, 0);
            TlpFooder.Controls.Add(LblTime, 1, 0);
            TlpFooder.Controls.Add(PicBoxCompanyLogo, 3, 0);
            TlpFooder.Dock = DockStyle.Fill;
            TlpFooder.ForeColor = Color.DarkGreen;
            TlpFooder.Location = new Point(1, 551);
            TlpFooder.Margin = new Padding(1);
            TlpFooder.Name = "TlpFooder";
            TlpFooder.RowCount = 1;
            TlpFooder.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TlpFooder.Size = new Size(1358, 46);
            TlpFooder.TabIndex = 2;
            // 
            // LblDate
            // 
            LblDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblDate.AutoSize = true;
            LblDate.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblDate.ForeColor = Color.FromArgb(163, 0, 34);
            LblDate.Location = new Point(3, 11);
            LblDate.Name = "LblDate";
            LblDate.Size = new Size(201, 23);
            LblDate.TabIndex = 0;
            LblDate.Text = "Date : ";
            // 
            // LblTime
            // 
            LblTime.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblTime.AutoSize = true;
            LblTime.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblTime.ForeColor = Color.FromArgb(163, 0, 34);
            LblTime.Location = new Point(210, 11);
            LblTime.Name = "LblTime";
            LblTime.Size = new Size(201, 23);
            LblTime.TabIndex = 1;
            LblTime.Text = "Time :";
            // 
            // PicBoxCompanyLogo
            // 
            PicBoxCompanyLogo.BorderStyle = BorderStyle.FixedSingle;
            PicBoxCompanyLogo.Dock = DockStyle.Fill;
            PicBoxCompanyLogo.Image = Properties.Resources.TransparentLogo;
            PicBoxCompanyLogo.InitialImage = Properties.Resources.TransparentLogo;
            PicBoxCompanyLogo.Location = new Point(1151, 2);
            PicBoxCompanyLogo.Margin = new Padding(2);
            PicBoxCompanyLogo.Name = "PicBoxCompanyLogo";
            PicBoxCompanyLogo.Size = new Size(205, 42);
            PicBoxCompanyLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            PicBoxCompanyLogo.TabIndex = 2;
            PicBoxCompanyLogo.TabStop = false;
            // 
            // MdiVegetableBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1370, 608);
            Controls.Add(TlpMdiVegitableBox);
            Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            KeyPreview = true;
            MainMenuStrip = menuStrip;
            Name = "MdiVegetableBox";
            Text = "Vegitable Box";
            WindowState = FormWindowState.Maximized;
            Load += MdiVegetableBox_Load;
            TlpMdiVegitableBox.ResumeLayout(false);
            TlpMain.ResumeLayout(false);
            TlpHeader.ResumeLayout(false);
            TlpHeader.PerformLayout();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            TlpClose.ResumeLayout(false);
            TlpClose.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PicBoxMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicBoxClose).EndInit();
            TlpForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PicBoxMdi).EndInit();
            TlpFooder.ResumeLayout(false);
            TlpFooder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PicBoxCompanyLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer Timer;
        private TableLayoutPanel TlpMdiVegitableBox;
        private TableLayoutPanel TlpMain;
        private TableLayoutPanel TlpHeader;
        private TableLayoutPanel TlpForm;
        private TableLayoutPanel TlpFooder;
        private MenuStrip menuStrip;
        private Label LblFormHeader;
        private ToolStripMenuItem ToolStripMenuItem_Master;
        private ToolStripMenuItem ToolStripMenuItem_Billing;
        private ToolStripMenuItem ToolStripMenuItem_Order;
        private ToolStripMenuItem ToolStripMenuItem_Reports;
        private Label LblDate;
        private Label LblTime;
        private TableLayoutPanel TlpClose;
        private PictureBox PicBoxMinimize;
        private PictureBox PicBoxClose;
        private ToolStripMenuItem ToolStripMenuItem_Accounts;
        private ToolStripMenuItem ToolStripMenuItem_ProductMaster;
        private Label LblUserName;
        private ToolStripMenuItem ToolStripMenuItem_RateMaster;
        private PictureBox PicBoxCompanyLogo;
        private PictureBox PicBoxMdi;
        private ToolStripMenuItem pOSToolStripMenuItem;
        private ToolStripMenuItem rePrintToolStripMenuItem;
        private ToolStripMenuItem purchaseEntryToolStripMenuItem;
        private ToolStripMenuItem purchaseReportToolStripMenuItem;
        private ToolStripMenuItem ToolStripMenuItem_ExpenseEntry_Click;
        private ToolStripMenuItem tagPrintToolStripMenuItem;
        private ToolStripMenuItem ToolStripMenuItem_UserMaster;
        private ToolStripMenuItem ToolStripMenuItem_VendorMaster;
        private ToolStripMenuItem ToolStripMenuItem_CustomerMaster;
        private ToolStripMenuItem ToolStripMenuItem_ExpenseMaster;
        private ToolStripMenuItem ToolStripMenuItem_CustomerCreditDebit;
        private ToolStripMenuItem ToolStripMenuItem_VendorInvoiceEntry;
        private ToolStripMenuItem ToolStripMenuItem_VendorPayment;
        private ToolStripMenuItem ToolStripMenuItem_UndiyalCreditDebit;
        private ToolStripMenuItem ToolStripMenuItem_DailyAccountClosing;
        private ToolStripMenuItem ToolStripMenuItem_Settings;
        private ToolStripMenuItem ToolStripMenuItem_Backup;
    }
}