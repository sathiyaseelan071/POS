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

                ClsFrmRePrint clsFrmRePrint = new ClsFrmRePrint();
                DataTable dataTable = clsFrmRePrint.GetDataTable();

                DgvBillData.DataSource = dataTable;

                DgvBillData.AllowUserToResizeColumns = true;

                TxtBillNo.Focus();
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
                ClsPrint clsPrint = new ClsPrint();
                clsPrint.PrintSalesBill(Convert.ToInt32(this.TxtBillNo.Text), DateTime.Now.Date);
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
    }
}
