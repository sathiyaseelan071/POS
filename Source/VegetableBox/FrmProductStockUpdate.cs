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
    public partial class FrmProductStockUpdate : Form
    {
        Master clsMaster = new Master();

        public string? maintainStock { get; set; }
        public int minimumStock { get; set; }
        public int maximumStock { get; set; }
        public int stockInHand { get; set; }

        public FrmProductStockUpdate()
        {
            InitializeComponent();
        }

        private void RefreshUI()
        {
            try
            {
                this.CmbMaintainStock.DataSource = null;
                if (clsMaster.GetYesNoMaster().IsDataTableValid() == true)
                {
                    FillControls.ComboBoxFill(this.CmbMaintainStock, clsMaster.GetYesNoMaster(), "Code", "Name", false, "");
                }
                this.CmbMaintainStock.SelectedIndex = -1;
            }
            catch
            {
                throw;
            }
        }

        private void ToggleControls(bool IsEnabled)
        {
            try
            {
                this.LblMaximumStock.Enabled = IsEnabled;
                this.LblMinimumStock.Enabled = IsEnabled;
                this.LblStockInHand.Enabled = IsEnabled;

                this.TxtMaximumStock.Enabled = IsEnabled;
                this.TxtMinimumStock.Enabled = IsEnabled;
                this.TxtStockInHand.Enabled = IsEnabled;
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
                if (CmbMaintainStock.SelectedIndex < 0)
                {
                    CmbMaintainStock.Focus();
                    throw new Exception("Please select the maintain stock option.");
                }

                // Use ternary + null coalescing for safety
                maintainStock = CmbMaintainStock.SelectedValue?.ToString() ?? "N";

                // Parse numbers safely
                minimumStock = int.TryParse(TxtMinimumStock.Text, out var minVal) ? minVal : 0;
                maximumStock = int.TryParse(TxtMaximumStock.Text, out var maxVal) ? maxVal : 0;
                stockInHand = int.TryParse(TxtStockInHand.Text, out var stockVal) ? stockVal : -1;

                if (maintainStock == "Y")
                {
                    if (minimumStock <= 0)
                    {
                        TxtMinimumStock.Focus();
                        throw new Exception("Please enter a valid minimum stock.");
                    }

                    if (maximumStock <= 0)
                    {
                        TxtMaximumStock.Focus();
                        throw new Exception("Please enter a valid maximum stock.");
                    }

                    if (stockInHand < 0)
                    {
                        TxtStockInHand.Focus();
                        throw new Exception("Please enter the stock in hand.");
                    }

                    if (minimumStock > maximumStock)
                    {
                        TxtMaximumStock.Focus();
                        throw new Exception("Maximum stock must be greater than or equal to minimum stock.");
                    }
                }
                else
                {
                    maintainStock = "N";
                    minimumStock = 0;
                    maximumStock = 0;
                    stockInHand = 0;
                }

                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            try
            {
                this.DialogResult = DialogResult.Cancel;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void FrmProductStockUpdate_Load(object sender, EventArgs e)
        {
            try
            {
                this.KeyPreview = true;
                this.RefreshUI();
                this.ToggleControls(false);
                this.CmbMaintainStock.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void FrmProductStockUpdate_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SendKeys.Send("{TAB}");
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

        private void Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void CmbMaintainStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(this.CmbMaintainStock.SelectedIndex >= 0)
                {
                    if (Convert.ToString(this.CmbMaintainStock.SelectedValue) == "Y")
                    {
                        this.ToggleControls(true);
                    }
                    else
                    {
                        this.ToggleControls(false);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }
    }
}
