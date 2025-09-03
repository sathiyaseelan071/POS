using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace VegetableBox
{
    public partial class FrmRePrint : Form
    {
        public FrmRePrint()
        {
            InitializeComponent();
        }

        private void FrmRePrint_Load(object sender, EventArgs e)
        {
            try
            {
                this.TxtBillNo.Text = string.Empty;
                this.DtpBillDate.Value = DateTime.Now.Date;
                this.DgvBillData.DataSource = null;
                this.DtpBillDate.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(this.TxtBillNo.Text))
                {
                    MessageBox.Show("Please Enter Bill No", "Vegetable Box");
                    this.TxtBillNo.Focus();
                    return;
                }

                ClsPrint clsPrint = new ClsPrint();
                clsPrint.PrintSalesBill(Convert.ToInt32(this.TxtBillNo.Text), this.DtpBillDate.Value.Date);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            try
            {
                if (Global.mdiVegetableBox != null)
                    Global.mdiVegetableBox.CloseForm(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            try
            {
                ClsFrmRePrint clsFrmRePrint = new ClsFrmRePrint();
                DataTable dataTable = clsFrmRePrint.GetDataTable(this.DtpBillDate.Value.Date);

                this.DgvBillData.DataSource = dataTable;
                this.DgvBillData.AllowUserToResizeColumns = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmRePrint_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true; // prevents ding sound
            }
        }
    }
}
