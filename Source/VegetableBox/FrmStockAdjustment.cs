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
    public partial class FrmStockAdjustment : Form
    {
        ClsFrmStockAdjustment clsFrmStockAdjustment;
        public FrmStockAdjustment()
        {
            InitializeComponent();
        }

        private void ClearAll()
        {
            try
            {
                this.rdoAddStock.Checked = true;
                this.cmbAdjustmentReason.SelectedIndex = -1;
                
                this.ClearProductDetails();
            }
            catch
            {
                throw;
            }
        }

        private void ClearProductDetails()
        {
            try
            {
                this.TxtProductSearch.Text = string.Empty;
                this.DgvProductSearch.DataSource = null;
                this.TxtProductName.Text = string.Empty;
                this.TxtProductTamilName.Text = string.Empty;
                this.TxtMrp.Text = string.Empty;
                this.TxtSellingRate.Text = string.Empty;
                this.TxtCurrentStockQty.Text = string.Empty;
                this.TxtAdjustmentStockQty.Text = string.Empty;
                this.LblNewStockQty.Text = "New Stock Qty : ";
                this.LblAdjustment.Text = "Add Qty to Stock";
            }
            catch
            {
                throw;
            }
        }

        private void LoadControls()
        {
            try
            {
                this.clsFrmStockAdjustment = new ClsFrmStockAdjustment();

                this.LblAdjustment.Text = "Add to Stock Qty";

                DataTable dataTable = new DataTable();
                dataTable = this.clsFrmStockAdjustment.ReasonMaster.AsEnumerable()
                    .Where(x => x.Field<string>("AdjustmentType") == "ADD")
                    .CopyToDataTable();

                FillControls.ComboBoxFill(this.cmbAdjustmentReason, dataTable,
                    "ReasonCode", "ReasonName", false, "");
            }
            catch
            {
                throw;
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you want to exit ?", "Vegetable Box", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (Global.mdiVegetableBox != null)
                        Global.mdiVegetableBox.CloseForm(this);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void ReadOnlyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            try
            {
                TextBox TextBox = (TextBox)sender;
                TextBox.BackColor = Color.White;
                if (TextBox.Text.Length > 0)
                {
                    TextBox.SelectionStart = 0;
                    TextBox.SelectionLength = TextBox.Text.Length;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                TextBox TextBox = (TextBox)sender;
                TextBox.BackColor = Color.WhiteSmoke;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void Decimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                // allows 0-9, backspace
                if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8))
                {
                    e.Handled = true;
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void FrmStockAdjustment_Load(object sender, EventArgs e)
        {
            try
            {
                this.clsFrmStockAdjustment = new ClsFrmStockAdjustment();
                this.ClearAll();
                this.LoadControls();
                SendKeys.Send("{Tab}");
                this.rdoAddStock.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void TxtProductSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.TxtProductSearch.Focused)
                    this.ErrorProvider.Clear();

                this.DoFillProductSearchGridControl(this.TxtProductSearch.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void DoFillProductSearchGridControl(string FilterProduct)
        {
            try
            {
                DataTable _DtSearch = new DataTable();
                if (FilterProduct != string.Empty)
                {
                    if (clsFrmStockAdjustment.ProductRateData != null && clsFrmStockAdjustment.ProductRateData.Rows.Count > 0)
                    {
                        _DtSearch.Columns.Add(ProductRateData.ColumnName.SearchName, typeof(string));
                        _DtSearch.Columns.Add(ProductRateData.ColumnName.ProductCode, typeof(string));
                        _DtSearch.Columns.Add(ProductRateData.ColumnName.MRP, typeof(decimal));

#pragma warning disable CS8602 // Dereference of a possibly null reference.

                        if (clsFrmStockAdjustment.ProductRateData.AsEnumerable()
                            .Where(x => (FilterProduct.Length >= 3 && x.Field<string>(ProductRateData.ColumnName.ProductName).ToLower().Contains(FilterProduct.ToLower()))
                            || (FilterProduct.Length >= 3 && x.Field<string>(ProductRateData.ColumnName.ProductAltrName).ToLower().Contains(FilterProduct.ToLower()))
                            || x.Field<string>(ProductRateData.ColumnName.ProductCode) == FilterProduct

                            || (FilterProduct.Length >= 5 && !string.IsNullOrEmpty(x.Field<string>(ProductRateData.ColumnName.BarCode))
                            && x.Field<string>(ProductRateData.ColumnName.BarCode).Contains(FilterProduct))

                            || (FilterProduct.Length >= 5 && !string.IsNullOrEmpty(x.Field<string>(ProductRateData.ColumnName.BarCode2))
                            && x.Field<string>(ProductRateData.ColumnName.BarCode2).Contains(FilterProduct))

                            || (FilterProduct.Length >= 5 && !string.IsNullOrEmpty(x.Field<string>(ProductRateData.ColumnName.BarCode3))
                            && x.Field<string>(ProductRateData.ColumnName.BarCode3).Contains(FilterProduct))

                            || (FilterProduct.Length >= 5 && !string.IsNullOrEmpty(x.Field<string>(ProductRateData.ColumnName.BarCode4))
                            && x.Field<string>(ProductRateData.ColumnName.BarCode4).Contains(FilterProduct))

                            ).Count() > 0)
                        {
                            _DtSearch = clsFrmStockAdjustment.ProductRateData.AsEnumerable()
                                .Where(x => (FilterProduct.Length >= 3 && x.Field<string>(ProductRateData.ColumnName.ProductName).ToLower().Contains(FilterProduct.ToLower()))
                                || (FilterProduct.Length >= 3 && x.Field<string>(ProductRateData.ColumnName.ProductAltrName).ToLower().Contains(FilterProduct.ToLower()))
                                || x.Field<string>(ProductRateData.ColumnName.ProductCode) == FilterProduct

                                || (FilterProduct.Length >= 5 && !string.IsNullOrEmpty(x.Field<string>(ProductRateData.ColumnName.BarCode))
                                && x.Field<string>(ProductRateData.ColumnName.BarCode).Contains(FilterProduct))

                                || (FilterProduct.Length >= 5 && !string.IsNullOrEmpty(x.Field<string>(ProductRateData.ColumnName.BarCode2))
                                && x.Field<string>(ProductRateData.ColumnName.BarCode2).Contains(FilterProduct))

                                || (FilterProduct.Length >= 5 && !string.IsNullOrEmpty(x.Field<string>(ProductRateData.ColumnName.BarCode3))
                                && x.Field<string>(ProductRateData.ColumnName.BarCode3).Contains(FilterProduct))

                                || (FilterProduct.Length >= 5 && !string.IsNullOrEmpty(x.Field<string>(ProductRateData.ColumnName.BarCode4))
                                && x.Field<string>(ProductRateData.ColumnName.BarCode4).Contains(FilterProduct)))
                                .OrderBy(x => x.Field<Int32>(ProductRateData.ColumnName.CatCode))
                                .ThenBy(x => x.Field<string>(ProductRateData.ColumnName.ProductName))
                                .Select(g =>
                                {
                                    var row = _DtSearch.NewRow();
                                    row[ProductRateData.ColumnName.SearchName] = g.Field<string>(ProductRateData.ColumnName.SearchName);
                                    row[ProductRateData.ColumnName.ProductCode] = g.Field<string>(ProductRateData.ColumnName.ProductCode);
                                    row[ProductRateData.ColumnName.MRP] = g.Field<decimal>(ProductRateData.ColumnName.MRP);
                                    return row;
                                }
                                ).CopyToDataTable();
                        }

#pragma warning restore CS8602 // Dereference of a possibly null reference.

                        DgvProductSearch.DataSource = _DtSearch;

                        if (DgvProductSearch.Columns.Contains(ProductRateData.ColumnName.ProductCode))
                            DgvProductSearch.Columns[ProductRateData.ColumnName.ProductCode].Visible = false;

                        if (DgvProductSearch.Columns.Contains(ProductRateData.ColumnName.MRP))
                            DgvProductSearch.Columns[ProductRateData.ColumnName.MRP].Visible = false;

                    }
                }
                else
                {
                    DgvProductSearch.DataSource = _DtSearch;
                }
                this.DgvProductSearch.ClearSelection();
            }
            catch
            {
                throw;
            }
        }

        private void FrmStockAdjustment_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    BtnExit.Focus();
                }

                if (e.KeyCode == Keys.Enter)
                {
                    SendKeys.Send("{Tab}");
                }

                // Handle single key shortcuts
                switch (e.KeyCode)
                {
                    case Keys.F1:
                        this.TxtProductSearch.Focus();
                        break;

                    case Keys.F5:                        
                        this.clsFrmStockAdjustment = new ClsFrmStockAdjustment();
                        this.ClearAll();
                        this.LoadControls();
                        this.rdoAddStock.Focus();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void TxtProductSearch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if ((e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down) && DgvProductSearch.Rows.Count == 1)
                {
                    this.DgvProductSearch.Focus();
                    this.DgvProductSearch.CurrentRow.Cells[0].Selected = true;
                    this.DgvProductSearch_KeyDown(sender, e);
                }
                else if ((e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down) && DgvProductSearch.Rows.Count > 0)
                {
                    this.DgvProductSearch.Focus();
                    this.DgvProductSearch.CurrentRow.Cells[0].Selected = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void DgvProductSearch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter && DgvProductSearch.Rows.Count > 0)
                {
                    this.ErrorProvider.Clear();
                    this.LoadCurrentProduct();
                    this.TxtCurrentStockQty.Focus();
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private string ToConvertDecimalFormatString(string value)
        {
            try
            {
                return (value.Trim() == string.Empty ? "0.00" : Math.Round(Convert.ToDecimal(value.Trim()), 2).ToString("0.00"));
            }
            catch
            {
                throw;
            }
        }

        private string? CurrentPCode { get; set; }
        private decimal? CurrentMRP { get; set; }
        private bool IsRateMasterProduct { get; set; }
        private void LoadCurrentProduct()
        {
            try
            {
                if (DgvProductSearch.Rows.Count > 0)
                {
                    this.CurrentPCode = (string)DgvProductSearch.CurrentRow.Cells[ProductRateData.ColumnName.ProductCode].Value;
                    this.CurrentMRP = (decimal)DgvProductSearch.CurrentRow.Cells[ProductRateData.ColumnName.MRP].Value;

                    if (clsFrmStockAdjustment.ProductRateData != null && clsFrmStockAdjustment.ProductRateData.Rows.Count > 0)
                    {
                        if (clsFrmStockAdjustment.ProductRateData.AsEnumerable()
                            .Where(x => x.Field<string>(ProductRateData.ColumnName.ProductCode) == this.CurrentPCode
                            && x.Field<decimal>(ProductRateData.ColumnName.MRP) == this.CurrentMRP).Count() > 0)
                        {

                            DataRow dataRow = clsFrmStockAdjustment.ProductRateData
                                .AsEnumerable().Where(x => x.Field<string>(ProductRateData.ColumnName.ProductCode) == this.CurrentPCode
                                && x.Field<decimal>(ProductRateData.ColumnName.MRP) == this.CurrentMRP).FirstOrDefault();

                            if (dataRow != null)
                            {
                                this.TxtProductName.Text = (dataRow[ProductRateData.ColumnName.ProductName] != null ?
                                                           (string)dataRow[ProductRateData.ColumnName.ProductName] : string.Empty);

                                this.TxtProductTamilName.Text = (dataRow[ProductRateData.ColumnName.ProductTName] != null ?
                                                                (string)dataRow[ProductRateData.ColumnName.ProductTName] : string.Empty);

                                this.IsRateMasterProduct = (dataRow[ProductRateData.ColumnName.CalcBasedRateMast] != null
                                                            && (string)dataRow[ProductRateData.ColumnName.CalcBasedRateMast] == "Y");

                                this.TxtMrp.Text = (dataRow[ProductRateData.ColumnName.MRP] != null ?
                                                                    Convert.ToString(dataRow[ProductRateData.ColumnName.MRP]) : string.Empty);

                                this.TxtSellingRate.Text = (dataRow[ProductRateData.ColumnName.SellRate] != null ?
                                                                    Convert.ToString(dataRow[ProductRateData.ColumnName.SellRate]) : string.Empty);

                                this.TxtCurrentStockQty.Text = (dataRow[ProductRateData.ColumnName.StockQty] != null ?
                                                                    Convert.ToString(Convert.ToInt32(dataRow[ProductRateData.ColumnName.StockQty])) : string.Empty);

                                this.TxtProductSearch.Text = string.Empty;
                            }
                        }
                    }
                }
            }
            catch
            {
                throw;
            }
        }

        private bool Validate()
        {
            try
            {
                bool IsValid = true;
                this.ErrorProvider.Clear();

                string errValueSpecified = "Value must be specified.";
                string errValueGreaterThanZero = "Value must be greater than zero.";

                // Validate that a product is selected
                if (string.IsNullOrEmpty(this.CurrentPCode))
                {
                    this.ErrorProvider.SetError(this.TxtProductSearch, "Please select a product.");
                    IsValid = false;
                }

                // Validate that adjustment reason is selected
                if (this.cmbAdjustmentReason.SelectedIndex < 0)
                {
                    this.ErrorProvider.SetError(this.cmbAdjustmentReason, errValueSpecified);
                    IsValid = false;
                }

                // Validate adjustment quantity is provided and greater than zero
                if (string.IsNullOrWhiteSpace(this.TxtAdjustmentStockQty.Text))
                {
                    this.ErrorProvider.SetError(this.TxtAdjustmentStockQty, errValueSpecified);
                    IsValid = false;
                }
                else if (!int.TryParse(this.TxtAdjustmentStockQty.Text.Trim(), out int adjustmentQty) || adjustmentQty <= 0)
                {
                    this.ErrorProvider.SetError(this.TxtAdjustmentStockQty, errValueGreaterThanZero);
                    IsValid = false;
                }

                // Validate sufficient stock when reducing
                if (this.ErrorProvider.GetError(this.TxtAdjustmentStockQty) == string.Empty
                    && !this.rdoAddStock.Checked
                    && int.TryParse(this.TxtCurrentStockQty.Text.Trim(), out int currentStock)
                    && int.TryParse(this.TxtAdjustmentStockQty.Text.Trim(), out int reduceQty))
                {
                    if (reduceQty > currentStock)
                    {
                        this.ErrorProvider.SetError(this.TxtAdjustmentStockQty,
                            $"Insufficient stock. Available: {currentStock}, Trying to reduce: {reduceQty}");
                        IsValid = false;
                    }
                }

                return IsValid;
            }
            catch
            {
                throw;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.Validate())
                    return;

                if (MessageBox.Show("Are you sure you want to update this product stock?", "Vegetable Box", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                    return;

                // Parse validated values
                int adjustmentQty = int.Parse(this.TxtAdjustmentStockQty.Text.Trim());
                string reason = this.cmbAdjustmentReason.SelectedValue?.ToString() ?? string.Empty;
                
                // Calculate new stock
                int currentStock = int.Parse(this.TxtCurrentStockQty.Text.Trim());
                int newStock = this.rdoAddStock.Checked 
                    ? currentStock + adjustmentQty 
                    : currentStock - adjustmentQty;

                // Call the Update method with correct parameters
                bool success = this.clsFrmStockAdjustment.Update(
                    Convert.ToInt32(this.CurrentPCode),
                    this.CurrentMRP ?? 0,
                    Convert.ToDecimal(this.TxtSellingRate.Text.Trim()),
                    currentStock,
                    adjustmentQty,
                    newStock,
                    reason);

                if (success)
                {
                    MessageBox.Show("Stock updated successfully...", "Vegetable Box");
                    this.clsFrmStockAdjustment = new ClsFrmStockAdjustment();
                    this.ClearProductDetails();
                    this.TxtProductSearch.Focus();
                }
                else
                {
                    MessageBox.Show("Failed to update stock. Please try again.", "Vegetable Box");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                this.TxtProductSearch.Focus();
                this.ClearAll();
                this.LoadControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void rdoAddStock_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.rdoAddStock.Checked)
                {
                    this.LblAdjustment.Text = "Add to Stock Qty";

                    DataTable dataTable = new DataTable();
                    dataTable = this.clsFrmStockAdjustment.ReasonMaster.AsEnumerable()
                        .Where(x => x.Field<string>("AdjustmentType") == "ADD")
                        .CopyToDataTable();

                    FillControls.ComboBoxFill(this.cmbAdjustmentReason, dataTable,
                        "ReasonCode", "ReasonName", false, "");
                }
                else
                {
                    this.LblAdjustment.Text = "Reduce from Stock Qty";

                    DataTable dataTable = new DataTable();
                    dataTable = this.clsFrmStockAdjustment.ReasonMaster.AsEnumerable()
                        .Where(x => x.Field<string>("AdjustmentType") == "REDUCE")
                        .CopyToDataTable();

                    FillControls.ComboBoxFill(this.cmbAdjustmentReason, dataTable,
                        "ReasonCode", "ReasonName", false, "");
                }

                this.RefreshNewStockQty();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void RefreshNewStockQty()
        {
            try
            {
                // Parse current stock quantity safely
                if (!int.TryParse(this.TxtCurrentStockQty.Text.Trim(), out int currentStock))
                    currentStock = 0;
                // Parse adjustment quantity safely
                if (!int.TryParse(this.TxtAdjustmentStockQty.Text.Trim(), out int adjustmentQty))
                    adjustmentQty = 0;
                // Calculate new stock based on adjustment type
                int newStock = this.rdoAddStock.Checked
                    ? currentStock + adjustmentQty
                    : currentStock - adjustmentQty;
                // Update label with the result
                this.LblNewStockQty.Text = $"New Stock Qty : {newStock}";
            }
            catch
            {
                throw;
            }
        }

        private void TxtAdjustmentStockQty_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.RefreshNewStockQty();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }
    }
}
