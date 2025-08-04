using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace VegetableBox
{
    public partial class MdiVegetableBox : Form
    {
        public MdiVegetableBox()
        {
            InitializeComponent();
            this.BackToNormalMode();
        }

        private Form childForm = new Form();
        private void ShowForm(Form form)
        {
            try
            {
                form.MdiParent = this;
                childForm = form;
                form.Show();
                form.WindowState = FormWindowState.Maximized;
                form.Dock = DockStyle.Fill;
                form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                form.Tag = true;
                TlpForm.Controls.Add(form, 0, 0);
                TlpHeader.ColumnStyles[0].SizeType = SizeType.Percent;
                TlpHeader.ColumnStyles[0].Width = 0;
                TlpHeader.ColumnStyles[1].SizeType = SizeType.Percent;
                TlpHeader.ColumnStyles[1].Width = 87;
                TlpHeader.ColumnStyles[2].SizeType = SizeType.Percent;
                TlpHeader.ColumnStyles[2].Width = 13;

                LblFormHeader.Text = form.Text;
                this.PicBoxMdi.Visible = false;
            }
            catch
            {
                throw;
            }
        }

        public void CloseForm(Form form)
        {
            try
            {
                this.BackToNormalMode();
                form.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void SetToolTip()
        {
            try
            {
                ToolTip toolTip = new ToolTip();

                toolTip.AutoPopDelay = 5000;
                toolTip.InitialDelay = 50;
                toolTip.ReshowDelay = 500;
                toolTip.ShowAlways = true;
                toolTip.SetToolTip(this.PicBoxMinimize, "Minimise");
                toolTip.SetToolTip(this.PicBoxClose, "Close");
            }
            catch
            {
                throw;
            }
        }

        private void BackToNormalMode()
        {
            try
            {
                this.PicBoxMdi.Visible = true;
                LblFormHeader.Text = String.Empty;
                TlpHeader.ColumnStyles[0].SizeType = SizeType.Percent;
                TlpHeader.ColumnStyles[0].Width = 87;
                TlpHeader.ColumnStyles[1].SizeType = SizeType.Percent;
                TlpHeader.ColumnStyles[1].Width = 0;
                TlpHeader.ColumnStyles[2].SizeType = SizeType.Percent;
                TlpHeader.ColumnStyles[2].Width = 13;
            }
            catch
            {
                throw;
            }
        }

        private void MdiVegetableBox_Load(object sender, EventArgs e)
        {
            try
            {
                this.SetToolTip();

                Global.mdiVegetableBox = this;
                Global.applicationName = Application.ProductName;

                this.Timer.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            try
            {
                LblDate.Text = "Date : " + DateTime.Today.ToString("dd-MMM-yyyy");
                LblTime.Text = "Time : " + DateTime.Now.ToString("hh:mm:ss  tt");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void PicBoxClose_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you want to close the application ?", "Vegetable Box", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    Application.Exit();
                    Application.ExitThread();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void PicBoxMinimize_Click(object sender, EventArgs e)
        {
            try
            {
                this.WindowState = FormWindowState.Minimized;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void ToolStripMenuItem_ProductMaster_Click(object sender, EventArgs e)
        {
            try
            {
                FrmProduct frmProduct = new FrmProduct();
                this.ShowForm(frmProduct);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void ToolStripMenuItem_RateMaster_Click(object sender, EventArgs e)
        {
            try
            {
                FrmRateMaster frmRateMaster = new FrmRateMaster();
                this.ShowForm(frmRateMaster);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void pOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmPos frmPos = new FrmPos();
                this.ShowForm(frmPos);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void rePrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmRePrint frmRePrint = new FrmRePrint();
                this.ShowForm(frmRePrint);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void purchaseEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmPurchaseEntry frmPurchaseEnty = new FrmPurchaseEntry();
                this.ShowForm(frmPurchaseEnty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void purchaseReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmReport frmReportPurchase = new FrmReport();
                this.ShowForm(frmReportPurchase);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void expensesEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmExpenseRecorder frmExpenseRecorder = new FrmExpenseRecorder();
                this.ShowForm(frmExpenseRecorder);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void tagPrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmTagPrint frmTagPrint = new FrmTagPrint();
                this.ShowForm(frmTagPrint);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void ToolStripMenuItem_UserMaster_Click(object sender, EventArgs e)
        {
            try
            {
                FrmUserMaster frmUserMaster = new FrmUserMaster();
                this.ShowForm(frmUserMaster);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void ToolStripMenuItem_VendorMaster_Click(object sender, EventArgs e)
        {
            try
            {
                FrmVendorMaster frmVendorMaster = new FrmVendorMaster();
                this.ShowForm(frmVendorMaster);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void ToolStripMenuItem_CustomerMaster_Click(object sender, EventArgs e)
        {
            try
            {
                FrmCustomerMaster frmCustomerMaster = new FrmCustomerMaster();
                this.ShowForm(frmCustomerMaster);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void ToolStripMenuItem_ExpenseMaster_Click(object sender, EventArgs e)
        {
            try
            {
                FrmExpenseMaster frmExpenseMaster = new FrmExpenseMaster();
                this.ShowForm(frmExpenseMaster);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void ToolStripMenuItem_CustomerCreditDebit_Click(object sender, EventArgs e)
        {
            try
            {
                FrmCustomerCreditDebit frmCustomerCreditDebit = new FrmCustomerCreditDebit();
                this.ShowForm(frmCustomerCreditDebit);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void ToolStripMenuItem_VendorInvoiceEntry_Click(object sender, EventArgs e)
        {
            try
            {
                FrmVendorInvoiceEntry frmVendorInvoiceEntry = new FrmVendorInvoiceEntry();
                this.ShowForm(frmVendorInvoiceEntry);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void ToolStripMenuItem_VendorPayment_Click(object sender, EventArgs e)
        {
            try
            {
                FrmVendorPayment frmVendorInvoiceEntry = new FrmVendorPayment();
                this.ShowForm(frmVendorInvoiceEntry);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void ToolStripMenuItem_UndiyalCreditDebit_Click(object sender, EventArgs e)
        {
            try
            {
                FrmUndiyalCreditDebit frmUndiyalCreditDebit = new FrmUndiyalCreditDebit();
                this.ShowForm(frmUndiyalCreditDebit);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }
    }
}
