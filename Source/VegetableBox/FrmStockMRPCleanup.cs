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
    public partial class FrmStockMRPCleanup : Form
    {
        ClsFrmStockMRPCleanup clsFrmStockMRPCleanup;
        public FrmStockMRPCleanup()
        {
            InitializeComponent();
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
                this.TxtStockQty.Text = string.Empty;
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
                this.clsFrmStockMRPCleanup = new ClsFrmStockMRPCleanup();                
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
                // allows 0-9, backspace, and decimal
                if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
                {
                    e.Handled = true;
                    return;
                }

                // checks to make sure only 1 decimal is allowed
                if (e.KeyChar == 46)
                {
                    if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                        e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void FrmStockMRPCleanup_Load(object sender, EventArgs e)
        {
            try
            {
                this.TxtProductSearch.Focus();
                this.clsFrmStockMRPCleanup = new ClsFrmStockMRPCleanup();
                this.ClearProductDetails();
                this.LoadControls();
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
                    if (clsFrmStockMRPCleanup.ProductRateData != null && clsFrmStockMRPCleanup.ProductRateData.Rows.Count > 0)
                    {
                        _DtSearch.Columns.Add(ProductRateData.ColumnName.SearchName, typeof(string));
                        _DtSearch.Columns.Add(ProductRateData.ColumnName.ProductCode, typeof(string));
                        _DtSearch.Columns.Add(ProductRateData.ColumnName.MRP, typeof(decimal));

#pragma warning disable CS8602 // Dereference of a possibly null reference.

                        if (clsFrmStockMRPCleanup.ProductRateData.AsEnumerable()
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
                            _DtSearch = clsFrmStockMRPCleanup.ProductRateData.AsEnumerable()
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

        private void FrmStockMRPCleanup_KeyDown(object sender, KeyEventArgs e)
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
                        this.TxtProductSearch.Focus();
                        this.clsFrmStockMRPCleanup = new ClsFrmStockMRPCleanup();
                        this.ClearProductDetails();
                        this.LoadControls();
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
                    this.TxtStockQty.Focus();
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

                    if (clsFrmStockMRPCleanup.ProductRateData != null && clsFrmStockMRPCleanup.ProductRateData.Rows.Count > 0)
                    {
                        if (clsFrmStockMRPCleanup.ProductRateData.AsEnumerable()
                            .Where(x => x.Field<string>(ProductRateData.ColumnName.ProductCode) == this.CurrentPCode
                            && x.Field<decimal>(ProductRateData.ColumnName.MRP) == this.CurrentMRP).Count() > 0)
                        {

                            DataRow dataRow = clsFrmStockMRPCleanup.ProductRateData
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

                                this.TxtStockQty.Text = (dataRow[ProductRateData.ColumnName.StockQty] != null ?
                                                                    Convert.ToString(dataRow[ProductRateData.ColumnName.StockQty]) : string.Empty);

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

                if (Convert.ToDecimal(this.TxtStockQty.Text.Trim()) > 0)
                {
                    this.ErrorProvider.SetError(this.TxtStockQty, "Stock is available for this MRP, so it cannot be deleted.");
                    IsValid = false;
                }
                
                return IsValid;
            }
            catch
            {
                throw;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.Validate())
                    return;

                if (MessageBox.Show("Are you sure want to delete this product MRP ?", "Vegetable Box", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                    return;

                this.clsFrmStockMRPCleanup.Delete(Convert.ToInt32(this.CurrentPCode), this.CurrentMRP.Value);

                MessageBox.Show("Deleted Sucessfully...", "Vegetable Box");

                this.clsFrmStockMRPCleanup = new ClsFrmStockMRPCleanup();
                this.ClearProductDetails();
                this.TxtProductSearch.Focus();
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
                this.ClearProductDetails();
                this.LoadControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }
    }
}
