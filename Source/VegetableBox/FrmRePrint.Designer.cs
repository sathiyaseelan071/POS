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
            BtnPrint = new Button();
            BtnExit = new Button();
            TxtBillNo = new TextBox();
            label1 = new Label();
            DgvBillData = new DataGridView();
            Tlp_Main.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvBillData).BeginInit();
            SuspendLayout();
            // 
            // Tlp_Main
            // 
            Tlp_Main.ColumnCount = 3;
            Tlp_Main.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.0236225F));
            Tlp_Main.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 74.80315F));
            Tlp_Main.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.0748034F));
            Tlp_Main.Controls.Add(tableLayoutPanel1, 1, 0);
            Tlp_Main.Controls.Add(DgvBillData, 1, 1);
            Tlp_Main.Dock = DockStyle.Fill;
            Tlp_Main.Location = new Point(0, 0);
            Tlp_Main.Margin = new Padding(4, 5, 4, 5);
            Tlp_Main.Name = "Tlp_Main";
            Tlp_Main.RowCount = 3;
            Tlp_Main.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            Tlp_Main.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            Tlp_Main.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            Tlp_Main.Size = new Size(1125, 509);
            Tlp_Main.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 7;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.3456764F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.3456793F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.3456793F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.3456793F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.3456793F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.3456793F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.9259281F));
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(TxtBillNo, 1, 1);
            tableLayoutPanel1.Controls.Add(BtnPrint, 2, 1);
            tableLayoutPanel1.Controls.Add(BtnExit, 3, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(128, 5);
            tableLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(834, 91);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // BtnPrint
            // 
            BtnPrint.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            BtnPrint.Location = new Point(208, 50);
            BtnPrint.Margin = new Padding(4, 5, 4, 5);
            BtnPrint.Name = "BtnPrint";
            BtnPrint.Size = new Size(94, 36);
            BtnPrint.TabIndex = 4;
            BtnPrint.Text = "&Print";
            BtnPrint.UseVisualStyleBackColor = true;
            BtnPrint.Click += BtnPrint_Click;
            // 
            // BtnExit
            // 
            BtnExit.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            BtnExit.Location = new Point(310, 50);
            BtnExit.Margin = new Padding(4, 5, 4, 5);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(94, 36);
            BtnExit.TabIndex = 5;
            BtnExit.Text = "E&xit";
            BtnExit.UseVisualStyleBackColor = true;
            BtnExit.Click += BtnExit_Click;
            // 
            // TxtBillNo
            // 
            TxtBillNo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtBillNo.Location = new Point(106, 52);
            TxtBillNo.Margin = new Padding(4, 5, 4, 5);
            TxtBillNo.Name = "TxtBillNo";
            TxtBillNo.Size = new Size(94, 31);
            TxtBillNo.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(4, 56);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(94, 23);
            label1.TabIndex = 2;
            label1.Text = "Bill No";
            // 
            // DgvBillData
            // 
            DgvBillData.AllowUserToAddRows = false;
            DgvBillData.AllowUserToDeleteRows = false;
            DgvBillData.BackgroundColor = SystemColors.Control;
            DgvBillData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvBillData.Dock = DockStyle.Fill;
            DgvBillData.Location = new Point(128, 106);
            DgvBillData.Margin = new Padding(4, 5, 4, 5);
            DgvBillData.Name = "DgvBillData";
            DgvBillData.ReadOnly = true;
            DgvBillData.RowTemplate.Height = 25;
            DgvBillData.Size = new Size(834, 295);
            DgvBillData.TabIndex = 1;
            // 
            // FrmRePrint
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1125, 509);
            Controls.Add(Tlp_Main);
            Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(0, 64, 64);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmRePrint";
            Text = "Re Print";
            Load += FrmRePrint_Load;
            Tlp_Main.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvBillData).EndInit();
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
    }
}