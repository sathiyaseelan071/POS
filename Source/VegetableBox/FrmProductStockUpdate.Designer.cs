namespace VegetableBox
{
    partial class FrmProductStockUpdate
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
            CmbMaintainStock = new ComboBox();
            LblMaintainStock = new Label();
            LblMinimumStock = new Label();
            TxtMinimumStock = new TextBox();
            LblMaximumStock = new Label();
            TxtMaximumStock = new TextBox();
            LblStockInHand = new Label();
            TxtStockInHand = new TextBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            BtnExit = new Button();
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
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.Size = new Size(657, 183);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(2, 17);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(184, 19);
            label1.TabIndex = 0;
            label1.Text = "Product && Stock - Update";
            // 
            // Tlp
            // 
            Tlp.ColumnCount = 10;
            Tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.38095236F));
            Tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.9047623F));
            Tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.9047623F));
            Tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.9047623F));
            Tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.9047623F));
            Tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.9047623F));
            Tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.9047623F));
            Tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.9047623F));
            Tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.9047623F));
            Tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.38095236F));
            Tlp.Controls.Add(CmbMaintainStock, 2, 0);
            Tlp.Controls.Add(LblMaintainStock, 1, 0);
            Tlp.Controls.Add(LblMinimumStock, 3, 0);
            Tlp.Controls.Add(TxtMinimumStock, 4, 0);
            Tlp.Controls.Add(LblMaximumStock, 5, 0);
            Tlp.Controls.Add(TxtMaximumStock, 6, 0);
            Tlp.Controls.Add(LblStockInHand, 7, 0);
            Tlp.Controls.Add(TxtStockInHand, 8, 0);
            Tlp.Dock = DockStyle.Fill;
            Tlp.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Tlp.Location = new Point(2, 56);
            Tlp.Margin = new Padding(2);
            Tlp.Name = "Tlp";
            Tlp.RowCount = 1;
            Tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Tlp.Size = new Size(653, 69);
            Tlp.TabIndex = 1;
            // 
            // CmbMaintainStock
            // 
            CmbMaintainStock.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CmbMaintainStock.BackColor = Color.White;
            CmbMaintainStock.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbMaintainStock.FlatStyle = FlatStyle.Flat;
            CmbMaintainStock.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            CmbMaintainStock.ForeColor = Color.DarkGreen;
            CmbMaintainStock.FormattingEnabled = true;
            CmbMaintainStock.Location = new Point(94, 23);
            CmbMaintainStock.Margin = new Padding(2);
            CmbMaintainStock.Name = "CmbMaintainStock";
            CmbMaintainStock.Size = new Size(73, 23);
            CmbMaintainStock.TabIndex = 1;
            CmbMaintainStock.SelectedIndexChanged += CmbMaintainStock_SelectedIndexChanged;
            // 
            // LblMaintainStock
            // 
            LblMaintainStock.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblMaintainStock.AutoSize = true;
            LblMaintainStock.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LblMaintainStock.ForeColor = Color.FromArgb(0, 64, 64);
            LblMaintainStock.Location = new Point(17, 19);
            LblMaintainStock.Margin = new Padding(2, 0, 2, 0);
            LblMaintainStock.Name = "LblMaintainStock";
            LblMaintainStock.Size = new Size(73, 30);
            LblMaintainStock.TabIndex = 0;
            LblMaintainStock.Text = "Maintain Stock";
            // 
            // LblMinimumStock
            // 
            LblMinimumStock.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblMinimumStock.AutoSize = true;
            LblMinimumStock.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LblMinimumStock.ForeColor = Color.FromArgb(0, 64, 64);
            LblMinimumStock.Location = new Point(171, 19);
            LblMinimumStock.Margin = new Padding(2, 0, 2, 0);
            LblMinimumStock.Name = "LblMinimumStock";
            LblMinimumStock.Size = new Size(73, 30);
            LblMinimumStock.TabIndex = 2;
            LblMinimumStock.Text = "Minimum Stock";
            // 
            // TxtMinimumStock
            // 
            TxtMinimumStock.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtMinimumStock.BackColor = Color.White;
            TxtMinimumStock.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            TxtMinimumStock.ForeColor = Color.DarkGreen;
            TxtMinimumStock.Location = new Point(248, 23);
            TxtMinimumStock.Margin = new Padding(2);
            TxtMinimumStock.MaxLength = 3;
            TxtMinimumStock.Name = "TxtMinimumStock";
            TxtMinimumStock.Size = new Size(73, 23);
            TxtMinimumStock.TabIndex = 3;
            TxtMinimumStock.TextAlign = HorizontalAlignment.Right;
            TxtMinimumStock.KeyPress += Number_KeyPress;
            // 
            // LblMaximumStock
            // 
            LblMaximumStock.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblMaximumStock.AutoSize = true;
            LblMaximumStock.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LblMaximumStock.ForeColor = Color.FromArgb(0, 64, 64);
            LblMaximumStock.Location = new Point(325, 19);
            LblMaximumStock.Margin = new Padding(2, 0, 2, 0);
            LblMaximumStock.Name = "LblMaximumStock";
            LblMaximumStock.Size = new Size(73, 30);
            LblMaximumStock.TabIndex = 4;
            LblMaximumStock.Text = "Maximum Stock";
            // 
            // TxtMaximumStock
            // 
            TxtMaximumStock.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtMaximumStock.BackColor = Color.White;
            TxtMaximumStock.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            TxtMaximumStock.ForeColor = Color.DarkGreen;
            TxtMaximumStock.Location = new Point(402, 23);
            TxtMaximumStock.Margin = new Padding(2);
            TxtMaximumStock.MaxLength = 3;
            TxtMaximumStock.Name = "TxtMaximumStock";
            TxtMaximumStock.Size = new Size(73, 23);
            TxtMaximumStock.TabIndex = 5;
            TxtMaximumStock.TextAlign = HorizontalAlignment.Right;
            TxtMaximumStock.KeyPress += Number_KeyPress;
            // 
            // LblStockInHand
            // 
            LblStockInHand.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblStockInHand.AutoSize = true;
            LblStockInHand.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LblStockInHand.ForeColor = Color.FromArgb(0, 64, 64);
            LblStockInHand.Location = new Point(479, 19);
            LblStockInHand.Margin = new Padding(2, 0, 2, 0);
            LblStockInHand.Name = "LblStockInHand";
            LblStockInHand.Size = new Size(73, 30);
            LblStockInHand.TabIndex = 6;
            LblStockInHand.Text = "Stock in Hand";
            // 
            // TxtStockInHand
            // 
            TxtStockInHand.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtStockInHand.BackColor = Color.White;
            TxtStockInHand.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            TxtStockInHand.ForeColor = Color.DarkGreen;
            TxtStockInHand.Location = new Point(556, 23);
            TxtStockInHand.Margin = new Padding(2);
            TxtStockInHand.MaxLength = 3;
            TxtStockInHand.Name = "TxtStockInHand";
            TxtStockInHand.Size = new Size(73, 23);
            TxtStockInHand.TabIndex = 7;
            TxtStockInHand.TextAlign = HorizontalAlignment.Right;
            TxtStockInHand.KeyPress += Number_KeyPress;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 3;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel5.Controls.Add(BtnExit, 2, 0);
            tableLayoutPanel5.Controls.Add(BtnOk, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(2, 129);
            tableLayoutPanel5.Margin = new Padding(2);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(653, 52);
            tableLayoutPanel5.TabIndex = 2;
            // 
            // BtnExit
            // 
            BtnExit.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            BtnExit.ForeColor = Color.Red;
            BtnExit.Location = new Point(557, 12);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(93, 28);
            BtnExit.TabIndex = 1;
            BtnExit.Text = "E&xit";
            BtnExit.UseVisualStyleBackColor = false;
            BtnExit.Click += BtnExit_Click;
            // 
            // BtnOk
            // 
            BtnOk.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            BtnOk.ForeColor = Color.Green;
            BtnOk.Location = new Point(460, 12);
            BtnOk.Name = "BtnOk";
            BtnOk.Size = new Size(91, 28);
            BtnOk.TabIndex = 0;
            BtnOk.Text = "&Ok";
            BtnOk.UseVisualStyleBackColor = false;
            BtnOk.Click += BtnOk_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.PaleVioletRed;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(663, 189);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // FrmProductStockUpdate
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(663, 189);
            Controls.Add(tableLayoutPanel2);
            Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmProductStockUpdate";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Credit Customer";
            Load += FrmProductStockUpdate_Load;
            KeyDown += FrmProductStockUpdate_KeyDown;
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
        private TableLayoutPanel tableLayoutPanel5;
        private Button BtnOk;
        private Button BtnExit;
        private ComboBox CmbMaintainStock;
        private Label LblMaintainStock;
        private Label LblMinimumStock;
        private TextBox TxtMinimumStock;
        private Label LblMaximumStock;
        private TextBox TxtMaximumStock;
        private Label LblStockInHand;
        private TextBox TxtStockInHand;
    }
}