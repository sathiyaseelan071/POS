using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VegetableBox
{
    public partial class FrmPosCreditCustomer : Form
    {
        Master clsMaster = new Master();
        public int creditCustomerCode { get; set; }

        public FrmPosCreditCustomer()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                FrmCustomerMaster frmCustomerMaster = new FrmCustomerMaster();
                frmCustomerMaster.IsChildForm = true;
                frmCustomerMaster.WindowState = FormWindowState.Normal;
                frmCustomerMaster.ShowDialog();

                this.RefreshUI();
                this.CmbCustomerName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void RefreshUI()
        {
            try
            {
                this.CmbCustomerName.DataSource = null;
                if(clsMaster.GetCustomerMaster().IsDataTableValid() == true)
                {
                    FillControls.ComboBoxFill(this.CmbCustomerName, clsMaster.GetCustomerMaster(), "Code", "Name", false, "");
                }
                this.CmbCustomerName.SelectedIndex = -1;
            }
            catch
            {
                throw;
            }
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.CmbCustomerName.SelectedIndex < 0)
                {
                    throw new Exception("Please select a customer name.");
                }
                else
                {
                    this.creditCustomerCode = Convert.ToInt32(this.CmbCustomerName.SelectedValue);
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            try
            {
                this.creditCustomerCode = 0;
                this.DialogResult = DialogResult.Cancel;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void FrmPosCreditCustomer_Load(object sender, EventArgs e)
        {
            try
            {
                this.KeyPreview = true;
                this.RefreshUI();
                this.CmbCustomerName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void FrmPosCreditCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (this.CmbCustomerName.Focused)
                    {
                        this.BtnOk.Focus();
                    }
                }
                else if (e.KeyCode == Keys.Escape)
                {
                    this.BtnExit.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void CmbCustomerName_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    this.BtnOk.Focus();
                }
                else if (e.KeyCode == Keys.Escape)
                {
                    this.BtnExit.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }
    }
}
