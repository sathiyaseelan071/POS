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
    public partial class FrmPurchaseEntry : Form
    {
        private ClsFrmPurchaseEntry clsFrmPurchaseEnty = new ClsFrmPurchaseEntry();
        public FrmPurchaseEntry()
        {
            InitializeComponent();
        }

        private void ClearVendorDetails()
        {
            try
            {
                this.CmbVendorName.SelectedIndex = -1;
                this.DgvVendorInvoiceDetails.DataSource = null;
                this.DgvVendorInvoiceDetails.ClearSelection();

                this.TxtBillNo.Text = string.Empty;
                this.DtpBillDate.Value = DateTime.Now;
                this.TxtBillAmount.Text = string.Empty;
                this.TxtBillItemsCount.Text = string.Empty;
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
                this.TxtTotPurchaseQty.Text = string.Empty;
                this.TxtTotPurchaseRate.Text = string.Empty;
                this.TxtPurchaseRatePerQty.Text = string.Empty;

                this.TxtCurrentSellingRate.Text = string.Empty;
                this.TxtLastPurchaseRate.Text = string.Empty;
                this.TxtSellingRate.Text = string.Empty;
                this.TxtSellingMarginPer.Text = string.Empty;
                this.TxtMrp.Text = string.Empty;
                this.TxtDiscPerFromMRP.Text = string.Empty;
                this.TxtDiscRateFromMRP.Text = string.Empty;

                this.LblQtyType.Text = string.Empty;

                if (this.CmbProductCategory.Items.Count > 0)
                    this.CmbProductCategory.SelectedIndex = 0;

                this.TxtLastMRP.Text = string.Empty;
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
                this.clsFrmPurchaseEnty.GetMasterData();

                if (this.clsFrmPurchaseEnty.CategoryMaster.IsDataTableValid())
                    FillControls.ComboBoxFill(this.CmbProductCategory, this.clsFrmPurchaseEnty.CategoryMaster, "Code", "Name", true, "");

                if (this.clsFrmPurchaseEnty.VendorMaster.IsDataTableValid())
                    FillControls.ComboBoxFill(this.CmbVendorName, this.clsFrmPurchaseEnty.VendorMaster, "Code", "Name", false, "");

                this.clsFrmPurchaseEnty.GetVendorBillDetails();
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

        private void FrmPurchaseEnty_Load(object sender, EventArgs e)
        {
            try
            {
                this.ReLoad();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void ReLoad()
        {
            try
            {
                this.ClearProductDetails();
                this.LoadControls();
                this.ClearVendorDetails();

                this.clsFrmPurchaseEnty.GetEnteredPurchaseItems(9999999); //Vendor bill reference number - Empty Record                                                                                             
                this.DGVPurchaseCart.DataSource = clsFrmPurchaseEnty.PurchaseCartData;

                this.LoadPurchaseCardGrid();
                this.ReleaseControlsForVendorBill();

                this.LblTotalAmt.Text = "0.00";
                this.CmbVendorName.Focus();
                this.ErrorProvider.Clear();
                this.BtnBillCompleted.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            try
            {
                this.ClearProductDetails();
                this.TxtProductSearch.Focus();
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
                    if (clsFrmPurchaseEnty.ProductData != null && clsFrmPurchaseEnty.ProductData.Rows.Count > 0)
                    {
                        _DtSearch.Columns.Add(ProductRateData.ColumnName.SearchName, typeof(string));
                        _DtSearch.Columns.Add(ProductRateData.ColumnName.ProductCode, typeof(string));

#pragma warning disable CS8602 // Dereference of a possibly null reference.

                        if (clsFrmPurchaseEnty.ProductData.AsEnumerable()
                            .Where(x => (FilterProduct.Length >= 3 && x.Field<string>(ProductRateData.ColumnName.ProductName).ToLower().Contains(FilterProduct.ToLower()))
                            || (FilterProduct.Length >= 3 && x.Field<string>(ProductRateData.ColumnName.ProductAltrName).ToLower().Contains(FilterProduct.ToLower()))
                            || x.Field<string>(ProductRateData.ColumnName.ProductCode) == FilterProduct
                            || (FilterProduct.Length >= 5 && !string.IsNullOrEmpty(x.Field<string>(ProductRateData.ColumnName.BarCode))
                            && x.Field<string>(ProductRateData.ColumnName.BarCode).Contains(FilterProduct))).Count() > 0)
                        {

                            _DtSearch = clsFrmPurchaseEnty.ProductData.AsEnumerable()
                                .Where(x => (FilterProduct.Length >= 3 && x.Field<string>(ProductRateData.ColumnName.ProductName).ToLower().Contains(FilterProduct.ToLower()))
                                || (FilterProduct.Length >= 3 && x.Field<string>(ProductRateData.ColumnName.ProductAltrName).ToLower().Contains(FilterProduct.ToLower()))
                                || x.Field<string>(ProductRateData.ColumnName.ProductCode) == FilterProduct
                                || (FilterProduct.Length >= 5 && !string.IsNullOrEmpty(x.Field<string>(ProductRateData.ColumnName.BarCode))
                                && x.Field<string>(ProductRateData.ColumnName.BarCode).Contains(FilterProduct)))
                                .OrderBy(x => x.Field<Int32>(ProductRateData.ColumnName.CatCode))
                                .Select(g =>
                                {
                                    var row = _DtSearch.NewRow();
                                    row[ProductRateData.ColumnName.SearchName] = g.Field<string>(ProductRateData.ColumnName.SearchName);
                                    row[ProductRateData.ColumnName.ProductCode] = g.Field<string>(ProductRateData.ColumnName.ProductCode);
                                    return row;
                                }).CopyToDataTable();
                        }

#pragma warning restore CS8602 // Dereference of a possibly null reference.

                        DgvProductSearch.DataSource = _DtSearch;

                        if (DgvProductSearch.Columns.Contains(ProductRateData.ColumnName.ProductCode))
                            DgvProductSearch.Columns[ProductRateData.ColumnName.ProductCode].Visible = false;

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

        private void FrmPurchaseEnty_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (this.CmbVendorName.Focused && this.DgvVendorInvoiceDetails.Rows.Count >= 1)
                        this.DgvVendorInvoiceDetails.Focus();
                    else if (this.DgvVendorInvoiceDetails.Focused)
                        this.TxtProductSearch.Focus();
                }

                if (e.KeyCode == Keys.Escape)
                {
                    BtnSave.Focus();
                }

                if (e.KeyCode == Keys.Delete)
                {
                    if (DGVPurchaseCart.Focused && DGVPurchaseCart.SelectedRows.Count >= 1)
                    {
                        if (DGVPurchaseCart.Rows[DGSelectedRowIndex].Cells[PurchaseCartDataStruct.ColumnName.IsSaved].Value != null &&
                            DGVPurchaseCart.Rows[DGSelectedRowIndex].Cells[PurchaseCartDataStruct.ColumnName.IsSaved].Value.ToString() != "Y")
                        {
                            this.DeleteCartSelectedItem();
                            this.TxtProductSearch.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Once saved, item cannot be deleted.", "Vegetable Box");
                        }
                    }
                }

                if (e.KeyCode == Keys.F5)
                {
                    this.clsFrmPurchaseEnty.GetProductDetails();
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
                    this.TxtTotPurchaseQty.Text = string.Empty;
                    this.TxtTotPurchaseRate.Text = string.Empty;
                    this.TxtPurchaseRatePerQty.Text = string.Empty;
                    this.LoadCurrentProduct();
                    this.TxtTotPurchaseQty.Focus();
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void TxtPurchaseWt_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    this.ErrorProvider.Clear();
                    this.TxtTotPurchaseRate.Focus();
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void TxtPurchaseRate_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    this.ErrorProvider.Clear();
                    this.TxtMrp.Focus();
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void TxtPurchaseRatePerKg_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    this.ErrorProvider.Clear();
                    this.TxtMrp.Focus();
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void TxtPurchaseWt_Validated(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(this.CurrentPCode))
                {
                    if (this.CurrentProductQtyType.ToUpper() == "KG" || this.CurrentProductQtyType.ToUpper() == "LTR")
                    {
                        this.TxtTotPurchaseQty.Text = this.ToConvertDecimalFormatString(this.TxtTotPurchaseQty.Text);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void TxtPurchaseRate_Validated(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(this.CurrentPCode))
                    this.TxtTotPurchaseRate.Text = this.ToConvertDecimalFormatString(this.TxtTotPurchaseRate.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void ToUpdateRatePerPcsQty()
        {
            try
            {
                decimal purchaseWt = Convert.ToDecimal(this.ToConvertDecimalFormatString(this.TxtTotPurchaseQty.Text));
                decimal purchaseRate = Convert.ToDecimal(this.ToConvertDecimalFormatString(this.TxtTotPurchaseRate.Text));

                if (purchaseRate > 0 && purchaseWt > 0)
                {
                    this.TxtPurchaseRatePerQty.Text = this.ToConvertDecimalFormatString((purchaseRate / purchaseWt).ToString());
                }
                else
                {
                    this.TxtPurchaseRatePerQty.Text = "0.00";
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
        private string? CurrentProductQtyType { get; set; }
        private void LoadCurrentProduct()
        {
            try
            {
                if (DgvProductSearch.Rows.Count > 0)
                {
                    this.CurrentPCode = (string)DgvProductSearch.CurrentRow.Cells[ProductRateData.ColumnName.ProductCode].Value;

                    if (clsFrmPurchaseEnty.ProductData != null && clsFrmPurchaseEnty.ProductData.Rows.Count > 0)
                    {
                        if (clsFrmPurchaseEnty.ProductData.AsEnumerable()
                            .Where(x => x.Field<string>(ProductRateData.ColumnName.ProductCode) == this.CurrentPCode).Count() > 0)
                        {

                            DataRow dataRow = clsFrmPurchaseEnty.ProductData
                                .AsEnumerable().Where(x => x.Field<string>(ProductRateData.ColumnName.ProductCode) == this.CurrentPCode).FirstOrDefault();

                            if (dataRow != null)
                            {
                                this.TxtProductName.Text = (dataRow[ProductRateData.ColumnName.ProductName] != null ?
                                                           (string)dataRow[ProductRateData.ColumnName.ProductName] : string.Empty);

                                this.TxtProductTamilName.Text = (dataRow[ProductRateData.ColumnName.ProductTName] != null ?
                                                                (string)dataRow[ProductRateData.ColumnName.ProductTName] : string.Empty);

                                this.LblQtyType.Text = (dataRow[ProductRateData.ColumnName.Qty] != null ?
                                                        (string)dataRow[ProductRateData.ColumnName.Qty] : string.Empty);

                                this.CurrentProductQtyType = (dataRow[ProductRateData.ColumnName.Qty] != null ?
                                                                    (string)dataRow[ProductRateData.ColumnName.Qty] : string.Empty);

                                this.CmbProductCategory.SelectedValue = (dataRow[ProductRateData.ColumnName.CatCode] != null ?
                                                                    (int)dataRow[ProductRateData.ColumnName.CatCode] : 0);

                                this.TxtCurrentSellingRate.Text = (dataRow[ProductRateData.ColumnName.SellRate] != null ?
                                                                    Convert.ToString(dataRow[ProductRateData.ColumnName.SellRate]) : string.Empty);

                                this.TxtLastPurchaseRate.Text = (dataRow[ProductRateData.ColumnName.PurRate] != null ?
                                                                    Convert.ToString(dataRow[ProductRateData.ColumnName.PurRate]) : string.Empty);

                                this.TxtLastMRP.Text = (dataRow[ProductRateData.ColumnName.MRP] != null ?
                                                                    Convert.ToString(dataRow[ProductRateData.ColumnName.MRP]) : string.Empty);

                                this.TxtProductSearch.Text = string.Empty;

                                //if (Convert.ToInt32(this.CmbProductCategory.SelectedValue) <= 2)
                                //{
                                //    this.LblMrp.ForeColor = System.Drawing.Color.FromArgb(0, 64, 64);
                                //    this.LblMrp.Text = "MRP";
                                //}

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

        private void LoadPurchaseCardGrid()
        {
            try
            {
                DGVPurchaseCart.DataSource = null;
                DGVPurchaseCart.DataSource = clsFrmPurchaseEnty.PurchaseCartData;
                DGVPurchaseCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
                DGVPurchaseCart.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                DGVPurchaseCart.Columns[PurchaseCartDataStruct.ColumnName.SellingMarginPer].Visible = false;
                DGVPurchaseCart.Columns[PurchaseCartDataStruct.ColumnName.DiscPer].Visible = false;
                DGVPurchaseCart.Columns[PurchaseCartDataStruct.ColumnName.DiscRate].Visible = false;
                DGVPurchaseCart.Columns[PurchaseCartDataStruct.ColumnName.BilledBy].Visible = false;
                DGVPurchaseCart.Columns[PurchaseCartDataStruct.ColumnName.IsSaved].Visible = false;
                DGVPurchaseCart.Columns[PurchaseCartDataStruct.ColumnName.TranNo].Visible = false;

                foreach (DataGridViewColumn DGVColumn in DGVPurchaseCart.Columns)
                {
                    DGVColumn.SortMode = DataGridViewColumnSortMode.NotSortable;

                    if (DGVColumn.Name == PurchaseCartDataStruct.ColumnName.TotalPurchaseQty)
                    {
                        DGVColumn.ValueType = typeof(decimal);
                        DGVColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    }

                    if (DGVColumn.Name == PurchaseCartDataStruct.ColumnName.TotalPurchaseAmount
                        || DGVColumn.Name == PurchaseCartDataStruct.ColumnName.PurchaseRatePerQty
                        || DGVColumn.Name == PurchaseCartDataStruct.ColumnName.MRP
                        || DGVColumn.Name == PurchaseCartDataStruct.ColumnName.SellRatePerQty
                        || DGVColumn.Name == PurchaseCartDataStruct.ColumnName.SellingMarginPer
                        || DGVColumn.Name == PurchaseCartDataStruct.ColumnName.DiscPer
                        || DGVColumn.Name == PurchaseCartDataStruct.ColumnName.DiscRate)
                    {
                        DGVColumn.DefaultCellStyle.Format = "0.00";
                        DGVColumn.ValueType = typeof(decimal);
                        DGVColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    }

                    if (DGVColumn.Name == PurchaseCartDataStruct.ColumnName.ProName || DGVColumn.Name == PurchaseCartDataStruct.ColumnName.ProTamilName
                        || DGVColumn.Name == PurchaseCartDataStruct.ColumnName.MRP)
                    {
                        DGVColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    }

                    //DGVColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void TxtPurchaseWt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.ToUpdateRatePerPcsQty();
                this.ToUpdateDiscPerAndRateFromMRP();
                this.ToUpdateSalesMarginPercentage();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void TxtPurchaseRate_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.ToUpdateRatePerPcsQty();
                this.ToUpdateDiscPerAndRateFromMRP();
                this.ToUpdateSalesMarginPercentage();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidateAddCart())
                {
                    if (clsFrmPurchaseEnty.PurchaseCartData != null
                        && clsFrmPurchaseEnty.PurchaseCartData.AsEnumerable()
                        .Any(x => x.Field<int>(PurchaseCartDataStruct.ColumnName.ProCode) == Convert.ToInt32(this.CurrentPCode.Trim())
                        && x.Field<string>(PurchaseCartDataStruct.ColumnName.IsSaved) == "N"))
                    {
                        foreach (DataRow dr in clsFrmPurchaseEnty.PurchaseCartData.Rows)
                        {
                            if (dr[PurchaseCartDataStruct.ColumnName.ProCode].ToString() == this.CurrentPCode.Trim())
                            {
                                dr[PurchaseCartDataStruct.ColumnName.TotalPurchaseAmount]
                                    = Convert.ToDecimal(dr[PurchaseCartDataStruct.ColumnName.TotalPurchaseAmount]) + Convert.ToDecimal(this.TxtTotPurchaseRate.Text.Trim());

                                dr[PurchaseCartDataStruct.ColumnName.TotalPurchaseQty]
                                    = Convert.ToDecimal(dr[PurchaseCartDataStruct.ColumnName.TotalPurchaseQty]) + Convert.ToDecimal(this.TxtTotPurchaseQty.Text.Trim());

                                clsFrmPurchaseEnty.PurchaseCartData.AcceptChanges();
                            }
                        }
                    }
                    else
                    {
                        DataRow dr = clsFrmPurchaseEnty.PurchaseCartData.NewRow();
                        dr[PurchaseCartDataStruct.ColumnName.SNo] = clsFrmPurchaseEnty.PurchaseCartData.Rows.Count + 1;
                        dr[PurchaseCartDataStruct.ColumnName.ProCode] = this.CurrentPCode.Trim();
                        dr[PurchaseCartDataStruct.ColumnName.ProName] = this.TxtProductName.Text.Trim();
                        dr[PurchaseCartDataStruct.ColumnName.ProTamilName] = this.TxtProductTamilName.Text.Trim();
                        dr[PurchaseCartDataStruct.ColumnName.TotalPurchaseQty] = this.TxtTotPurchaseQty.Text.Trim();
                        dr[PurchaseCartDataStruct.ColumnName.Unit] = this.LblQtyType.Text.Trim();
                        dr[PurchaseCartDataStruct.ColumnName.TotalPurchaseAmount] = this.TxtTotPurchaseRate.Text.Trim();
                        dr[PurchaseCartDataStruct.ColumnName.PurchaseRatePerQty] = this.TxtPurchaseRatePerQty.Text.Trim();

                        dr[PurchaseCartDataStruct.ColumnName.MRP] = this.TxtMrp.Text.Trim();
                        dr[PurchaseCartDataStruct.ColumnName.SellRatePerQty] = this.TxtSellingRate.Text.Trim();
                        dr[PurchaseCartDataStruct.ColumnName.SellingMarginPer] = this.TxtSellingMarginPer.Text.Trim();
                        dr[PurchaseCartDataStruct.ColumnName.DiscPer] = this.TxtDiscPerFromMRP.Text.Trim();
                        dr[PurchaseCartDataStruct.ColumnName.DiscRate] = this.TxtDiscRateFromMRP.Text.Trim();
                        dr[PurchaseCartDataStruct.ColumnName.IsSaved] = "N";

                        this.clsFrmPurchaseEnty.PurchaseCartData.Rows.Add(dr);
                    }

                    this.DGVPurchaseCart.DataSource = clsFrmPurchaseEnty.PurchaseCartData.AsEnumerable().OrderByDescending(x => x.Field<int>(CartDataStruct.ColumnName.SNo)).CopyToDataTable();

                    this.HighlightSavedRows();

                    this.ToCalcTotalAmount();

                    this.ClearProductDetails();
                    this.TxtProductSearch.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void FreezeControlsForVendorBill()
        {
            try
            {
                this.CmbVendorName.Enabled = false;
                this.DgvVendorInvoiceDetails.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void ReleaseControlsForVendorBill()
        {
            try
            {
                this.CmbVendorName.Enabled = true;
                this.DgvVendorInvoiceDetails.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void ToCalcTotalAmount()
        {
            try
            {
                if (clsFrmPurchaseEnty.PurchaseCartData != null && clsFrmPurchaseEnty.PurchaseCartData.Rows.Count > 0)
                {
                    decimal decTotalAmount = Math.Round(Convert.ToDecimal(clsFrmPurchaseEnty.PurchaseCartData.Compute("SUM([" + PurchaseCartDataStruct.ColumnName.TotalPurchaseAmount + "])", string.Empty)), 2);

                    this.LblTotalAmt.Text = this.ToConvertDecimalFormatString(decTotalAmount.ToString());
                }
                else
                {
                    this.LblTotalAmt.Text = "0.00";
                }
            }
            catch
            {
                throw;
            }
        }

        private bool ValidateAddCart()
        {
            try
            {
                bool IsValid = true;
                this.ErrorProvider.Clear();

                string errValueSpecified = "Value must be specified.";
                string errValueGreaterThenZero = "Value must be greater then zero.";

                if (string.IsNullOrEmpty(this.TxtProductName.Text.Trim()))
                {
                    this.ErrorProvider.SetError(this.TxtProductName, errValueSpecified);
                    IsValid = false;
                }

                if (string.IsNullOrEmpty(this.TxtProductTamilName.Text.Trim()))
                {
                    this.ErrorProvider.SetError(this.TxtProductTamilName, errValueSpecified);
                    IsValid = false;
                }

                if (string.IsNullOrEmpty(this.TxtTotPurchaseRate.Text.Trim()))
                {
                    this.ErrorProvider.SetError(this.TxtTotPurchaseRate, errValueSpecified);
                    IsValid = false;
                }
                else if (Convert.ToDecimal(this.TxtTotPurchaseRate.Text.Trim()) <= 0)
                {
                    this.ErrorProvider.SetError(this.TxtTotPurchaseRate, errValueGreaterThenZero);
                    IsValid = false;
                }

                if (string.IsNullOrEmpty(this.TxtTotPurchaseQty.Text.Trim()))
                {
                    this.ErrorProvider.SetError(this.TxtTotPurchaseQty, errValueSpecified);
                    IsValid = false;
                }
                else if (Convert.ToDecimal(this.TxtTotPurchaseQty.Text.Trim()) <= 0)
                {
                    this.ErrorProvider.SetError(this.TxtTotPurchaseQty, errValueGreaterThenZero);
                    IsValid = false;
                }

                if (string.IsNullOrEmpty(this.TxtPurchaseRatePerQty.Text.Trim()))
                {
                    this.ErrorProvider.SetError(this.TxtPurchaseRatePerQty, errValueSpecified);
                    IsValid = false;
                }
                else if (Convert.ToDecimal(this.TxtPurchaseRatePerQty.Text.Trim()) <= 0)
                {
                    this.ErrorProvider.SetError(this.TxtPurchaseRatePerQty, errValueGreaterThenZero);
                    IsValid = false;
                }

                if (string.IsNullOrEmpty(this.TxtMrp.Text.Trim()))
                {
                    this.ErrorProvider.SetError(this.TxtMrp, errValueSpecified);
                    IsValid = false;
                }
                else if (Convert.ToDecimal(this.TxtMrp.Text.Trim()) <= 0)
                {
                    this.ErrorProvider.SetError(this.TxtMrp, errValueGreaterThenZero);
                    IsValid = false;
                }

                if (string.IsNullOrEmpty(this.TxtSellingRate.Text.Trim()))
                {
                    this.ErrorProvider.SetError(this.TxtSellingRate, errValueSpecified);
                    IsValid = false;
                }
                else if (Convert.ToDecimal(this.TxtSellingRate.Text.Trim()) <= 0)
                {
                    this.ErrorProvider.SetError(this.TxtSellingRate, errValueGreaterThenZero);
                    IsValid = false;
                }

                if (!string.IsNullOrEmpty(this.TxtPurchaseRatePerQty.Text.Trim()) &&
                    !string.IsNullOrEmpty(this.TxtMrp.Text.Trim()) && !string.IsNullOrEmpty(this.TxtSellingRate.Text.Trim()))
                {

                    if (Convert.ToDecimal(this.TxtPurchaseRatePerQty.Text.Trim()) >= Convert.ToDecimal(this.TxtMrp.Text.Trim()))
                    {
                        this.ErrorProvider.SetError(this.TxtPurchaseRatePerQty, "Purchase rate should be less than MRP...");
                        IsValid = false;
                    }

                    if (Convert.ToDecimal(this.TxtPurchaseRatePerQty.Text.Trim()) >= Convert.ToDecimal(this.TxtSellingRate.Text.Trim()))
                    {
                        this.ErrorProvider.SetError(this.TxtPurchaseRatePerQty, "Purchase rate should be less than Selling rate...");
                        IsValid = false;
                    }

                    if (Convert.ToDecimal(this.TxtMrp.Text.Trim()) <= Convert.ToDecimal(this.TxtPurchaseRatePerQty.Text.Trim()))
                    {
                        this.ErrorProvider.SetError(this.TxtMrp, "MRP should be greater than Purchase rate...");
                        IsValid = false;
                    }

                    if (Convert.ToDecimal(this.TxtMrp.Text.Trim()) < Convert.ToDecimal(this.TxtSellingRate.Text.Trim()))
                    {
                        this.ErrorProvider.SetError(this.TxtMrp, "MRP should be greater than or equal to Selling rate...");
                        IsValid = false;
                    }

                    if (Convert.ToDecimal(this.TxtSellingRate.Text.Trim()) <= Convert.ToDecimal(this.TxtPurchaseRatePerQty.Text.Trim()))
                    {
                        this.ErrorProvider.SetError(this.TxtSellingRate, "Selling rate should be greater than Purchase rate...");
                        IsValid = false;
                    }

                    if (Convert.ToDecimal(this.TxtSellingRate.Text.Trim()) > Convert.ToDecimal(this.TxtMrp.Text.Trim()))
                    {
                        this.ErrorProvider.SetError(this.TxtSellingRate, "Selling rate should be less than or equal to MRP...");
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

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!DGVPurchaseCart.Rows.Cast<DataGridViewRow>().Any(r => r.Cells["IsSaved"].Value?.ToString() == "N"))
                {
                    throw new Exception("Add at least one product to cart.");
                }

                int vendorBillRefNo = this.TxtBillNo.Tag != null ? Convert.ToInt32(this.TxtBillNo.Tag) : 0;
                int vendorCode = this.CmbVendorName.SelectedValue != null ? Convert.ToInt32(this.CmbVendorName.SelectedValue) : 0;
                int oldTranNo = this.DGVPurchaseCart.Tag != null ? Convert.ToInt32(this.DGVPurchaseCart.Tag) : 0;

                if (vendorCode == 0)
                {
                    this.ErrorProvider.SetError(this.CmbVendorName, "Vendor Name is required");
                    return;
                }

                if (vendorBillRefNo == 0)
                {
                    this.ErrorProvider.SetError(this.TxtBillNo, "Vendor Bill Reference Number is required");
                    return;
                }

                int BillNo = this.clsFrmPurchaseEnty.SaveData(this.clsFrmPurchaseEnty.PurchaseCartData, Convert.ToDecimal(this.LblTotalAmt.Text),
                             vendorBillRefNo, vendorCode, oldTranNo);

                MessageBox.Show("Saved Sucessfully..." + Environment.NewLine + "Bill No : " + BillNo.ToString(), "Vegetable Box");

                this.ReLoad();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void BtnBillCompleted_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.DGVPurchaseCart.Rows.Count <= 0)
                    return;

                if (this.DGVPurchaseCart.Rows.Count != Convert.ToInt32(this.TxtBillItemsCount.Text))
                {
                    this.ErrorProvider.SetError(
                        this.TxtBillItemsCount,
                        "Entered item count does not match bill items. Please verify before updating."
                    );
                    return;
                }

                if (Convert.ToDecimal(this.LblTotalAmt.Text) != Convert.ToDecimal(this.TxtBillAmount.Text))
                {
                    this.ErrorProvider.SetError(
                        this.TxtBillItemsCount,
                        "Total amount mismatch. Please verify before updating bill status."
                    );
                    return;
                }

                this.clsFrmPurchaseEnty.UpdateBillStatus((int)this.TxtBillNo.Tag, ProgressStatusValues.Completed); //Vendor bill reference number    

                MessageBox.Show("Saved Sucessfully...", "Vegetable Box");

                this.ReLoad();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private int DGSelectedRowIndex = 0;
        private void DGVPurchaseCart_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DGSelectedRowIndex = e.RowIndex;
                if (DGVPurchaseCart.Focused && e.RowIndex >= 0)
                {
                    DGVPurchaseCart.Rows[e.RowIndex].Selected = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void DGVPurchaseCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DGSelectedRowIndex = e.RowIndex;
                if (DGVPurchaseCart.Focused && e.RowIndex >= 0)
                {
                    DGVPurchaseCart.Rows[e.RowIndex].Selected = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void DGVPurchaseCart_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DGSelectedRowIndex = e.RowIndex;
                if (DGVPurchaseCart.Focused && e.RowIndex >= 0)
                {
                    DGVPurchaseCart.Rows[e.RowIndex].Selected = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void DeleteCartSelectedItem()
        {
            try
            {
                if (DGVPurchaseCart.Focused && DGSelectedRowIndex >= 0)
                {
                    int sno = Convert.ToInt32(DGVPurchaseCart.Rows[DGSelectedRowIndex].Cells[CartDataStruct.ColumnName.SNo].Value);

                    if (clsFrmPurchaseEnty.PurchaseCartData
                        .AsEnumerable().Where(x => x.Field<int>(CartDataStruct.ColumnName.SNo) == sno).Count() > 0)
                    {
                        for (int i = clsFrmPurchaseEnty.PurchaseCartData.Rows.Count - 1; i >= 0; i--)
                        {
                            DataRow dr = clsFrmPurchaseEnty.PurchaseCartData.Rows[i];
                            if (Convert.ToInt32(dr[CartDataStruct.ColumnName.SNo]) == sno)
                            {
                                dr.Delete();
                                break;
                            }
                            dr[CartDataStruct.ColumnName.SNo] = Convert.ToInt32(dr[CartDataStruct.ColumnName.SNo]) - 1;
                        }
                        clsFrmPurchaseEnty.PurchaseCartData.AcceptChanges();

                        //if (clsFrmPurchaseEnty.PurchaseCartData.Rows.Count >= 1)
                        //{
                        //    DGVPurchaseCart.DataSource = clsFrmPurchaseEnty.PurchaseCartData.AsEnumerable().OrderByDescending(x => x.Field<int>(CartDataStruct.ColumnName.SNo)).CopyToDataTable();
                        //}
                        //else
                        //{
                        //    DGVPurchaseCart.DataSource = clsFrmPurchaseEnty.PurchaseCartData;
                        //}

                        DGVPurchaseCart.DataSource = clsFrmPurchaseEnty.PurchaseCartData.AsEnumerable()
                                                    .OrderByDescending(x => x.Field<int>(CartDataStruct.ColumnName.SNo)).CopyToDataTable();

                        this.HighlightSavedRows();
                        this.ToCalcTotalAmount();
                    }

                    DGVPurchaseCart.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void FrmPurchaseEntry_Activated(object sender, EventArgs e)
        {
            this.CmbVendorName.Focus();
        }

        private void TxtSellingRate_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    this.ErrorProvider.Clear();
                    this.BtnAdd.Focus();
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void TxtCurrentSellingRate_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    this.ErrorProvider.Clear();

                    if (Convert.ToInt32(this.CmbProductCategory.SelectedValue) <= 2)
                        this.TxtSellingRate.Focus();
                    else
                        this.TxtMrp.Focus();

                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void TxtSellingMarginPercentage_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    this.ErrorProvider.Clear();
                    this.BtnAdd.Focus();
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void TxtDiscFromMRP_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    this.ErrorProvider.Clear();
                    this.BtnAdd.Focus();
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void TxtMrp_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    this.ErrorProvider.Clear();
                    this.TxtSellingRate.Focus();
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void TxtSellingRate_Validated(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(this.CurrentPCode))
                    this.TxtSellingRate.Text = this.ToConvertDecimalFormatString(this.TxtSellingRate.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void TxtMrp_Validated(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(this.CurrentPCode))
                    this.TxtMrp.Text = this.ToConvertDecimalFormatString(this.TxtMrp.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void TxtSellingRate_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.ToUpdateSalesMarginPercentage();
                this.ToUpdateDiscPerAndRateFromMRP();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void ToUpdateSalesMarginPercentage()
        {
            try
            {
                decimal purchaseRate = Convert.ToDecimal(this.ToConvertDecimalFormatString(this.TxtPurchaseRatePerQty.Text));
                decimal SellingRate = Convert.ToDecimal(this.ToConvertDecimalFormatString(this.TxtSellingRate.Text));

                if (string.IsNullOrEmpty(this.TxtPurchaseRatePerQty.Text.Trim()) || string.IsNullOrEmpty(this.TxtSellingRate.Text.Trim())
                    || purchaseRate == 0)
                {
                    this.TxtSellingMarginPer.Text = "0.00";
                }
                else
                {
                    decimal result = ((SellingRate - purchaseRate) / purchaseRate) * 100;
                    this.TxtSellingMarginPer.Text = this.ToConvertDecimalFormatString(result.ToString()).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void ToUpdateDiscPerAndRateFromMRP()
        {
            try
            {
                decimal mrp = Convert.ToDecimal(this.ToConvertDecimalFormatString(this.TxtMrp.Text));
                decimal sellingRate = Convert.ToDecimal(this.ToConvertDecimalFormatString(this.TxtSellingRate.Text));

                if (string.IsNullOrEmpty(this.TxtMrp.Text.Trim()) || string.IsNullOrEmpty(this.TxtSellingRate.Text.Trim())
                    || mrp == 0)
                {
                    this.TxtDiscPerFromMRP.Text = "0.00";
                    this.TxtDiscRateFromMRP.Text = "0.00";
                }
                else
                {
                    decimal result = ((mrp - sellingRate) / mrp) * 100;
                    this.TxtDiscPerFromMRP.Text = this.ToConvertDecimalFormatString(result.ToString()).ToString();

                    this.TxtDiscRateFromMRP.Text = this.ToConvertDecimalFormatString((mrp - sellingRate).ToString()).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void TxtMrp_EnabledChanged(object sender, EventArgs e)
        {
            if (this.TxtMrp.Enabled == false) this.TxtSellingRate.Focus();
        }

        private void TxtLastPurchaseRate_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    this.ErrorProvider.Clear();

                    if (Convert.ToInt32(this.CmbProductCategory.SelectedValue) <= 2)
                        this.TxtSellingRate.Focus();
                    else
                        this.TxtMrp.Focus();

                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void CmbVendorName_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.CmbVendorName.Focused)
                    this.ErrorProvider.Clear();

                if (this.CmbVendorName.Focused && this.CmbVendorName.SelectedIndex >= 0)
                {
                    this.ClearLoadedBillDetails();
                    this.DoFillVendorBillSearchGridControl(Convert.ToInt32(this.CmbVendorName.SelectedValue));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void ClearLoadedBillDetails()
        {
            try
            {
                this.TxtBillNo.Tag = string.Empty;
                this.TxtBillNo.Text = string.Empty;
                this.DtpBillDate.Value = DateTime.Now;
                this.TxtBillAmount.Text = string.Empty;
                this.TxtBillItemsCount.Text = string.Empty;
            }
            catch
            {
                throw;
            }
        }

        private void DoFillVendorBillSearchGridControl(int? FilterProduct)
        {
            try
            {
                DataTable _DtSearch = new DataTable();
                if (FilterProduct != null && FilterProduct >= 0)
                {
                    if (clsFrmPurchaseEnty.VendorPurBillDetailsData != null && clsFrmPurchaseEnty.VendorPurBillDetailsData.Rows.Count > 0)
                    {
                        _DtSearch.Columns.Add(VendorPurBillDetailsData.ColumnName.TranNo, typeof(int));
                        _DtSearch.Columns.Add(VendorPurBillDetailsData.ColumnName.VendorCode, typeof(int));
                        _DtSearch.Columns.Add(VendorPurBillDetailsData.ColumnName.BillNo, typeof(string));
                        _DtSearch.Columns.Add(VendorPurBillDetailsData.ColumnName.BillDate, typeof(DateTime));
                        _DtSearch.Columns.Add(VendorPurBillDetailsData.ColumnName.BillAmount, typeof(decimal));
                        _DtSearch.Columns.Add(VendorPurBillDetailsData.ColumnName.ItemsCount, typeof(int));
                        _DtSearch.Columns.Add(VendorPurBillDetailsData.ColumnName.PurchaseEntryStatus, typeof(string));
                        _DtSearch.Columns.Add(VendorPurBillDetailsData.ColumnName.PurchaseEntryStatusCode, typeof(string));

                        if (clsFrmPurchaseEnty.VendorPurBillDetailsData.AsEnumerable().Where(x => x.Field<int>(VendorPurBillDetailsData.ColumnName.VendorCode) == FilterProduct).Count() > 0)
                        {
                            _DtSearch = clsFrmPurchaseEnty.VendorPurBillDetailsData.AsEnumerable()
                                .Where(x => x.Field<int>(VendorPurBillDetailsData.ColumnName.VendorCode) == FilterProduct)
                                .OrderBy(x => x.Field<DateTime>(VendorPurBillDetailsData.ColumnName.BillDate))
                                .Select(g =>
                                {
                                    var row = _DtSearch.NewRow();
                                    row[VendorPurBillDetailsData.ColumnName.TranNo] = g.Field<int>(VendorPurBillDetailsData.ColumnName.TranNo);
                                    row[VendorPurBillDetailsData.ColumnName.VendorCode] = g.Field<int>(VendorPurBillDetailsData.ColumnName.VendorCode);
                                    row[VendorPurBillDetailsData.ColumnName.BillNo] = g.Field<string>(VendorPurBillDetailsData.ColumnName.BillNo);
                                    row[VendorPurBillDetailsData.ColumnName.BillDate] = g.Field<DateTime>(VendorPurBillDetailsData.ColumnName.BillDate);
                                    row[VendorPurBillDetailsData.ColumnName.BillAmount] = g.Field<decimal>(VendorPurBillDetailsData.ColumnName.BillAmount);
                                    row[VendorPurBillDetailsData.ColumnName.ItemsCount] = g.Field<int>(VendorPurBillDetailsData.ColumnName.ItemsCount);
                                    row[VendorPurBillDetailsData.ColumnName.PurchaseEntryStatus] = g.Field<string>(VendorPurBillDetailsData.ColumnName.PurchaseEntryStatus);
                                    row[VendorPurBillDetailsData.ColumnName.PurchaseEntryStatusCode] = g.Field<string>(VendorPurBillDetailsData.ColumnName.PurchaseEntryStatusCode);
                                    return row;
                                }
                                ).CopyToDataTable();
                        }

                        DgvVendorInvoiceDetails.DataSource = _DtSearch;

                        DgvVendorInvoiceDetails.Columns[VendorPurBillDetailsData.ColumnName.TranNo].Visible = false;
                        DgvVendorInvoiceDetails.Columns[VendorPurBillDetailsData.ColumnName.VendorCode].Visible = false;
                        DgvVendorInvoiceDetails.Columns[VendorPurBillDetailsData.ColumnName.PurchaseEntryStatusCode].Visible = false;

                        DgvVendorInvoiceDetails.Columns[VendorPurBillDetailsData.ColumnName.BillNo].HeaderText = "Bill No";
                        DgvVendorInvoiceDetails.Columns[VendorPurBillDetailsData.ColumnName.BillDate].HeaderText = "Bill Date";
                        DgvVendorInvoiceDetails.Columns[VendorPurBillDetailsData.ColumnName.BillAmount].HeaderText = "Bill Amount";
                        DgvVendorInvoiceDetails.Columns[VendorPurBillDetailsData.ColumnName.ItemsCount].HeaderText = "Items Count";
                        DgvVendorInvoiceDetails.Columns[VendorPurBillDetailsData.ColumnName.PurchaseEntryStatus].HeaderText = "Entry Status";

                        foreach (DataGridViewColumn DGVColumn in DgvVendorInvoiceDetails.Columns)
                        {
                            //if (DGVColumn.Name == VendorPurBillDetailsData.ColumnName.BillAmount)
                            //    DGVColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                            //else

                            DGVColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                            if (DGVColumn.Name == VendorPurBillDetailsData.ColumnName.BillAmount)
                            {
                                DGVColumn.DefaultCellStyle.Format = "0.00";
                                DGVColumn.ValueType = typeof(decimal);
                                DGVColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            }
                        }


                    }
                }
                else
                {
                    DgvVendorInvoiceDetails.DataSource = _DtSearch;
                }
                this.DgvVendorInvoiceDetails.ClearSelection();
            }
            catch
            {
                throw;
            }
        }

        private void DgvVendorInvoiceDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DgvVendorInvoiceDetails.Rows.Count > 0)
                {
                    this.ErrorProvider.Clear();
                    this.LoadCurrentBillSelection();

                    this.TxtProductSearch.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void LoadCurrentBillSelection()
        {
            try
            {
                this.ClearLoadedBillDetails();

                if (DgvVendorInvoiceDetails.Rows.Count > 0)
                {
                    this.TxtBillNo.Tag = (int)DgvVendorInvoiceDetails.CurrentRow.Cells[VendorPurBillDetailsData.ColumnName.TranNo].Value;
                    this.TxtBillNo.Text = Convert.ToString(DgvVendorInvoiceDetails.CurrentRow.Cells[VendorPurBillDetailsData.ColumnName.BillNo].Value);
                    this.DtpBillDate.Value = (DateTime)DgvVendorInvoiceDetails.CurrentRow.Cells[VendorPurBillDetailsData.ColumnName.BillDate].Value;
                    this.TxtBillAmount.Text = Convert.ToString(DgvVendorInvoiceDetails.CurrentRow.Cells[VendorPurBillDetailsData.ColumnName.BillAmount].Value);
                    this.TxtBillItemsCount.Text = Convert.ToString(DgvVendorInvoiceDetails.CurrentRow.Cells[VendorPurBillDetailsData.ColumnName.ItemsCount].Value);
                }

                this.clsFrmPurchaseEnty.GetEnteredPurchaseItems((int)this.TxtBillNo.Tag); //Vendor bill reference number                                                                                              
                this.DGVPurchaseCart.DataSource = clsFrmPurchaseEnty.PurchaseCartData;

                if (clsFrmPurchaseEnty.PurchaseCartData.IsDataTableValid())
                {
                    this.DGVPurchaseCart.Tag = clsFrmPurchaseEnty.PurchaseCartData.AsEnumerable()
                        .Select(x => x.Field<int?>(PurchaseCartDataStruct.ColumnName.TranNo)).FirstOrDefault() ?? 0;
                }
                else
                {
                    this.DGVPurchaseCart.Tag = 0;
                }

                this.HighlightSavedRows();
                this.ToCalcTotalAmount();
                this.FreezeControlsForVendorBill();

                if (int.TryParse(TxtBillItemsCount.Text, out int billItemCount))
                {
                    this.BtnBillCompleted.Enabled = (DGVPurchaseCart.Rows.Count == billItemCount);
                }
                else
                {
                    this.BtnBillCompleted.Enabled = false; // or handle invalid input
                }                
            }
            catch
            {
                throw;
            }
        }

        private int DGVendorSelectedRowIndex = 0;
        private void DgvVendorInvoiceDetails_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DGVendorSelectedRowIndex = e.RowIndex;
                if (e.RowIndex >= 0)
                {
                    DgvVendorInvoiceDetails.Rows[e.RowIndex].Selected = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void DgvVendorInvoiceDetails_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter && DgvVendorInvoiceDetails.Rows.Count > 0)
                {
                    this.ErrorProvider.Clear();
                    this.LoadCurrentBillSelection();

                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void HighlightSavedRows()
        {
            try
            {
                foreach (DataGridViewRow row in this.DGVPurchaseCart.Rows)
                {
                    if (row.Cells[PurchaseCartDataStruct.ColumnName.IsSaved].Value != null && row.Cells[PurchaseCartDataStruct.ColumnName.IsSaved].Value.ToString() == "Y")
                    {
                        row.DefaultCellStyle.BackColor = Color.Beige; // background
                        row.DefaultCellStyle.ForeColor = Color.Black; // text color (optional)
                    }
                }

                this.DGVPurchaseCart.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void CmbVendorName_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                this.ClearLoadedBillDetails();
                this.DoFillVendorBillSearchGridControl(Convert.ToInt32(this.CmbVendorName.SelectedValue));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                this.ReLoad();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }
    }
}
