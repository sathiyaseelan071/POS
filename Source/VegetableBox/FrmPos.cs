using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace VegetableBox
{
    public partial class FrmPos : Form
    {
        ClsFrmPos clsFrmPos = new ClsFrmPos();
        public FrmPos()
        {
            InitializeComponent();
        }

        private void FrmPos_Load(object sender, EventArgs e)
        {
            try
            {
                this.ClearProductDetails();
                this.LoadCardGrid();
                this.ClearAmountDetails();
                SendKeys.Send("{TAB}");
                this.TxtProductSearch.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void LoadCardGrid()
        {
            try
            {
                DGVCart.DataSource = null;
                DGVCart.DataSource = clsFrmPos.CartData;
                DGVCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                DGVCart.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

                foreach (DataGridViewColumn DGVColumn in DGVCart.Columns)
                {
                    DGVColumn.SortMode = DataGridViewColumnSortMode.NotSortable;

                    if (DGVColumn.Name == CartDataStruct.ColumnName.CalBORM || DGVColumn.Name == CartDataStruct.ColumnName.TotMRP)
                        DGVColumn.Visible = false;

                    if (DGVColumn.Name == CartDataStruct.ColumnName.Qty)
                    {
                        DGVColumn.ValueType = typeof(decimal);
                        DGVColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        //DGVColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    }

                    if (DGVColumn.Name == CartDataStruct.ColumnName.Rate || DGVColumn.Name == CartDataStruct.ColumnName.Amount
                        || DGVColumn.Name == CartDataStruct.ColumnName.DiscPer || DGVColumn.Name == CartDataStruct.ColumnName.DiscAmount
                        || DGVColumn.Name == CartDataStruct.ColumnName.TotalAmount)
                    {
                        DGVColumn.DefaultCellStyle.Format = "0.00";
                        DGVColumn.ValueType = typeof(decimal);
                        DGVColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    }

                    if (DGVColumn.Name == CartDataStruct.ColumnName.ProName)
                        DGVColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

                    if (DGVColumn.Name == CartDataStruct.ColumnName.ProTamilName)
                        DGVColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

                }
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
                    if (clsFrmPos.ProductRateData != null && clsFrmPos.ProductRateData.Rows.Count > 0)
                    {
                        _DtSearch.Columns.Add(ProductRateData.ColumnName.SearchName, typeof(string));
                        _DtSearch.Columns.Add(ProductRateData.ColumnName.ProductCode, typeof(string));

#pragma warning disable CS8602 // Dereference of a possibly null reference.

                        if (clsFrmPos.ProductRateData.AsEnumerable()
                            .Where(x => (FilterProduct.Length >= 3 && x.Field<string>(ProductRateData.ColumnName.ProductName).ToLower().Contains(FilterProduct.ToLower()))
                            || (FilterProduct.Length >= 3 && x.Field<string>(ProductRateData.ColumnName.ProductAltrName).ToLower().Contains(FilterProduct.ToLower()))
                            || x.Field<string>(ProductRateData.ColumnName.ProductCode) == FilterProduct
                            || (FilterProduct.Length >= 3 && !string.IsNullOrEmpty(x.Field<string>(ProductRateData.ColumnName.BarCode))
                            && x.Field<string>(ProductRateData.ColumnName.BarCode).Contains(FilterProduct))).Count() > 0)
                        {
                            _DtSearch = clsFrmPos.ProductRateData.AsEnumerable()
                                .Where(x => (FilterProduct.Length >= 3 && x.Field<string>(ProductRateData.ColumnName.ProductName).ToLower().Contains(FilterProduct.ToLower()))
                                || (FilterProduct.Length >= 3 && x.Field<string>(ProductRateData.ColumnName.ProductAltrName).ToLower().Contains(FilterProduct.ToLower()))
                                || x.Field<string>(ProductRateData.ColumnName.ProductCode) == FilterProduct
                                || (FilterProduct.Length >= 3 && !string.IsNullOrEmpty(x.Field<string>(ProductRateData.ColumnName.BarCode))
                                && x.Field<string>(ProductRateData.ColumnName.BarCode).Contains(FilterProduct)))
                                .OrderBy(x => x.Field<Int32>(ProductRateData.ColumnName.CatCode))
                                .Select(g =>
                                {
                                    var row = _DtSearch.NewRow();
                                    row[ProductRateData.ColumnName.SearchName] = g.Field<string>(ProductRateData.ColumnName.SearchName);
                                    row[ProductRateData.ColumnName.ProductCode] = g.Field<string>(ProductRateData.ColumnName.ProductCode);
                                    return row;
                                }
                                ).CopyToDataTable();
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
                if ((e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down) && DgvProductSearch.Rows.Count > 0)
                {
                    DgvProductSearch.Focus();
                    DgvProductSearch.CurrentRow.Cells[0].Selected = true;
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
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private string? CurrentPCode { get; set; }
        private string? CurrentPName { get; set; }
        private string? CurrentPTamilName { get; set; }
        private decimal? CurrentPSellRate { get; set; }
        private string? CurrentPQtyShortName { get; set; }
        private bool? CurrentPCalcBORM { get; set; }
        private decimal? CurrentMRP { get; set; }
        private decimal? CurrentDiscFromMrp { get; set; }
        private decimal? CurrentPurRate { get; set; }

        private void LoadCurrentProduct()
        {
            try
            {
                if (DgvProductSearch.Rows.Count > 0)
                {
                    this.CurrentPCode = (string)DgvProductSearch.CurrentRow.Cells[ProductRateData.ColumnName.ProductCode].Value;

                    if (clsFrmPos.ProductRateData != null && clsFrmPos.ProductRateData.Rows.Count > 0)
                    {
                        if (clsFrmPos.ProductRateData.AsEnumerable()
                            .Where(x => x.Field<string>(ProductRateData.ColumnName.ProductCode) == this.CurrentPCode).Count() > 0)
                        {

                            DataRow dataRow = clsFrmPos.ProductRateData
                                .AsEnumerable().Where(x => x.Field<string>(ProductRateData.ColumnName.ProductCode) == this.CurrentPCode).FirstOrDefault();

                            if (dataRow != null)
                            {
                                this.CurrentPName = (dataRow[ProductRateData.ColumnName.ProductName] != null ?
                                                    (string)dataRow[ProductRateData.ColumnName.ProductName] : string.Empty);

                                this.CurrentPTamilName = (dataRow[ProductRateData.ColumnName.ProductTName] != null ?
                                                    (string)dataRow[ProductRateData.ColumnName.ProductTName] : string.Empty);

                                this.CurrentPSellRate = (dataRow[ProductRateData.ColumnName.SellRate] != null ?
                                                    (decimal)dataRow[ProductRateData.ColumnName.SellRate] : Convert.ToDecimal("0.00"));

                                this.CurrentPurRate = (dataRow[ProductRateData.ColumnName.PurRate] != null ?
                                                    (decimal)dataRow[ProductRateData.ColumnName.PurRate] : Convert.ToDecimal("0.00"));

                                this.CurrentMRP = (dataRow[ProductRateData.ColumnName.MRP] != null ?
                                                    (decimal)dataRow[ProductRateData.ColumnName.MRP] : Convert.ToDecimal("0.00"));

                                this.CurrentPQtyShortName = (dataRow[ProductRateData.ColumnName.Qty] != null ?
                                                    (string)dataRow[ProductRateData.ColumnName.Qty] : string.Empty);

                                string _Value = (dataRow[ProductRateData.ColumnName.CalcBasedRateMast] != null ?
                                                   (string)dataRow[ProductRateData.ColumnName.CalcBasedRateMast] : string.Empty);

                                if (_Value == "Y")
                                    this.CurrentPCalcBORM = true;
                                else
                                    this.CurrentPCalcBORM = false;

                                this.TxtProCode.Text = this.CurrentPCode;
                                this.TxtProName.Text = this.CurrentPName;
                                this.TxtProTName.Text = this.CurrentPTamilName;
                                this.LblUnit.Text = this.CurrentPQtyShortName;
                                this.TxtRate.Text = this.CurrentPSellRate.ToString();

                                this.LblPurchaseAmt.Text = this.CurrentPurRate.ToString();

                                if (this.CurrentMRP > 0)
                                    this.TxtMrp.Text = this.CurrentMRP.ToString();
                                else
                                    this.TxtMrp.Text = this.CurrentPSellRate.ToString();

                                this.TxtDiscPercentage.Text = "0.00";
                                this.TxtDiscAmt.Text = "0.00";

                                this.TxtProductSearch.Text = string.Empty;
                                this.TxtQty.Focus();
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

        private void BtnCancel_Click(object sender, EventArgs e)
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

        private void ClearProductDetails()
        {
            try
            {
                this.TxtProCode.Text = string.Empty;
                this.TxtProName.Text = string.Empty;
                this.TxtProTName.Text = string.Empty;
                this.TxtQty.Text = string.Empty;
                this.LblUnit.Text = string.Empty;
                this.TxtRate.Text = string.Empty;
                this.TxtAmt.Text = string.Empty;
                this.TxtDiscPercentage.Text = string.Empty;
                this.TxtDiscAmt.Text = string.Empty;
                this.TxtTotAmt.Text = string.Empty;
                this.TxtProductSearch.Text = string.Empty;
                this.DgvProductSearch.DataSource = null;
                this.DgvProductSearch.ClearSelection();
                this.ErrorProvider.Clear();
                this.TxtRBWRate.Text = string.Empty;
                this.TxtRBWWeight.Text = string.Empty;
                this.TLP_RateBasedWt.Visible = false;
                this.TxtMrp.Text = string.Empty;
                this.LblPurchaseAmt.Text = string.Empty;
                this.LblPurchaseAmt.Visible = false;
                this.TxtDiscFromMRP.Text = string.Empty;
            }
            catch
            {
                throw;
            }
        }

        private void TxtQty_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (this.TxtQty.Text != string.Empty && Convert.ToDecimal(this.TxtQty.Text) > 0)
                    {
                        if (this.CurrentPCalcBORM == true)
                        {
                            this.BtnAddCart.Focus();
                        }
                        else
                        {
                            this.TxtRate.Focus();
                        }
                    }
                    else
                    {
                        this.TxtQty.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void FrmPos_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape && TxtPaymentDetCash.Focused && LblFinalAmtReceived.Text == LblFinalNetAmt.Text)
                {
                    BtnSave.Focus();
                }

                if (e.KeyCode == Keys.Escape)
                {
                    TxtPaymentDetCash.Focus();
                }

                if (e.Control & e.KeyCode == Keys.G)
                {
                    DGVCart.Focus();
                }

                if (e.KeyCode == Keys.Delete)
                {
                    if (DGVCart.Focused && DGVCart.SelectedRows.Count >= 1)
                    {
                        this.DeleteCartSelectedItem();
                        this.TxtProductSearch.Focus();
                    }
                }

                if ((e.Control & e.KeyCode == Keys.E))
                {
                    if (DGVCart.Focused && DGVCart.SelectedRows.Count >= 1)
                    {
                        this.EditAndDeleteCartSelectedItem();
                        this.TxtQty.Focus();
                    }
                }

                if (e.KeyCode == Keys.F12)
                {
                    if (this.TLP_RateBasedWt.Visible == false)
                    {
                        this.TLP_RateBasedWt.Visible = true;
                        this.TxtRBWRate.Focus();
                        this.TxtRBWRate.Clear();
                        this.TxtRBWWeight.Clear();
                    }
                    else
                    {
                        this.TLP_RateBasedWt.Visible = false;
                        this.TxtRBWRate.Clear();
                        this.TxtRBWWeight.Clear();
                    }
                }

                if (e.KeyCode == Keys.F1)
                {
                    this.TxtProductSearch.Focus();
                }

                if (e.KeyCode == Keys.F5)
                {
                    this.clsFrmPos.GetProductRateDetails();
                }

                if (e.KeyCode == Keys.F4)
                {
                    this.LblPurchaseAmt.Visible = this.LblPurchaseAmt.Visible ? false : true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void TxtRate_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (this.TxtRate.Text != string.Empty && Convert.ToDecimal(this.TxtRate.Text) > 0)
                    {
                        this.BtnAddCart.Focus();
                    }
                    else
                    {
                        throw new Exception("Please enter the rate.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void ToCalcProductAmount()
        {
            try
            {
                decimal _Qty = this.ToConvertTextToDecimal(this.TxtQty.Text);
                decimal _Rate = this.ToConvertTextToDecimal(this.TxtRate.Text);
                decimal _DiscPer = this.ToConvertTextToDecimal(this.TxtDiscPercentage.Text);

                if (this.CurrentPSellRate <= 0)
                    this.TxtMrp.Text = this.ToConvertTextToDecimal(this.TxtRate.Text).ToString("0.00");

                this.TxtAmt.Text = this.ToConvertAmtFormat(Convert.ToString(Math.Round(_Qty * _Rate, 2)));

                decimal _Amt = this.ToConvertTextToDecimal(this.TxtAmt.Text);

                this.TxtDiscAmt.Text = this.ToConvertAmtFormat(Convert.ToString(Math.Round(((_Amt * _DiscPer) / 100), 2)));

                decimal _DiscAmt = this.ToConvertTextToDecimal(this.TxtDiscAmt.Text);

                this.TxtTotAmt.Text = this.ToConvertAmtFormat(Convert.ToString(Math.Round(_Amt - _DiscAmt, 2)));

                decimal _TotAmt = this.ToConvertTextToDecimal(this.TxtTotAmt.Text);
                decimal _MRP = this.ToConvertTextToDecimal(this.TxtMrp.Text);
                decimal _TotMRP = _Qty * _MRP;

                this.TxtDiscFromMRP.Text = this.ToConvertAmtFormat(Convert.ToString(Math.Round(_TotMRP - _TotAmt, 2)));
            }
            catch
            {
                throw;
            }
        }

        Decimal PrintTotDiscMRP;
        Decimal PrintTotMRP;

        private void ToCalcTotalAmount()
        {
            try
            {
                if (clsFrmPos.CartData != null && clsFrmPos.CartData.Rows.Count > 0)
                {
                    decimal decTotalAmount = Math.Round(Convert.ToDecimal(clsFrmPos.CartData.Compute("SUM(" + CartDataStruct.ColumnName.TotalAmount + ")", string.Empty)), 2);
                    decimal decDiscPer = this.ToConvertTextToDecimal(this.TxtFinalDiscPer.Text);
                    decimal decDiscAmt = Math.Round(((decTotalAmount * decDiscPer) / 100), 2);
                    decimal decGrossAmt = decTotalAmount - decDiscAmt;
                    decimal decNetAmt;

                    PrintTotMRP = Math.Round(Convert.ToDecimal(clsFrmPos.CartData.Compute("SUM( " + CartDataStruct.ColumnName.TotMRP + ")", string.Empty)), 2);
                    PrintTotDiscMRP = Math.Round(Convert.ToDecimal(clsFrmPos.CartData.Compute("SUM(" + CartDataStruct.ColumnName.TotDiscAmtFrmMrp + ")", string.Empty)), 2);

                    if (decGrossAmt.ToString().Split('.').Length > 1 && decGrossAmt.ToString().Split('.')[1] == "50")
                        decNetAmt = Math.Round(decGrossAmt + Convert.ToDecimal("0.01"), 0);
                    else
                        decNetAmt = Math.Round(decGrossAmt, 0);

                    decimal decRoundOffAmt = decNetAmt - decGrossAmt;

                    this.LblFinalTotAmt.Text = this.ToConvertAmtFormat(decTotalAmount.ToString());
                    this.TxtFinalDiscAmt.Text = this.ToConvertAmtFormat(decDiscAmt.ToString());
                    this.LblFinalGrossAmt.Text = this.ToConvertAmtFormat(decGrossAmt.ToString());
                    this.LblFinalRoundOffAmt.Text = this.ToConvertAmtFormat(decRoundOffAmt.ToString());
                    this.LblFinalNetAmt.Text = this.ToConvertAmtFormat(decNetAmt.ToString());

                    decimal decCashAmt = this.ToConvertTextToDecimal(this.TxtPaymentDetCash.Text);
                    decimal decCashUpi = this.ToConvertTextToDecimal(this.TxtPaymentDetUpi.Text);
                    decimal decCashCard = this.ToConvertTextToDecimal(this.TxtPaymentDetCard.Text);

                    decimal decAmtReceived = decCashAmt + decCashUpi + decCashCard;
                    decimal decBalanceAmt = decNetAmt - decAmtReceived;

                    this.LblFinalAmtReceived.Text = this.ToConvertAmtFormat(decAmtReceived.ToString());
                    this.LblFinalBalanceAmount.Text = this.ToConvertAmtFormat(decBalanceAmt.ToString());
                }
            }
            catch
            {
                throw;
            }
        }

        private decimal ToConvertTextToDecimal(string value)
        {
            try
            {
                return (value == string.Empty ? Convert.ToDecimal("0.00") : Convert.ToDecimal(value));
            }
            catch
            {
                throw;
            }
        }

        private void TxtQty_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (TxtQty.Focused && TxtProCode.Text != string.Empty)
                    this.ToCalcProductAmount();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void TxtAmt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (TxtAmt.Focused && TxtProCode.Text != string.Empty)
                    this.ToCalcProductAmount();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void TxtDiscPercentage_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (TxtDiscPercentage.Focused && TxtProCode.Text != string.Empty)
                    this.ToCalcProductAmount();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void TxtRate_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (TxtRate.Focused && TxtProCode.Text != string.Empty)
                    this.ToCalcProductAmount();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void TxtRate_Validated(object sender, EventArgs e)
        {
            try
            {
                if (TxtProCode.Text != string.Empty)
                    TxtRate.Text = ToConvertAmtFormat(TxtRate.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void TxtDiscPercentage_Validated(object sender, EventArgs e)
        {
            try
            {
                if (TxtProCode.Text != string.Empty)
                    TxtDiscPercentage.Text = ToConvertAmtFormat(TxtDiscPercentage.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private string ToConvertAmtFormat(string value)
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

        private void BtnAddCart_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidateAddCart())
                {
                    DataRow dr = clsFrmPos.CartData.NewRow();
                    dr[CartDataStruct.ColumnName.SNo] = clsFrmPos.CartData.Rows.Count + 1;
                    dr[CartDataStruct.ColumnName.ProCode] = this.TxtProCode.Text.Trim();
                    dr[CartDataStruct.ColumnName.ProName] = this.TxtProName.Text.Trim();
                    dr[CartDataStruct.ColumnName.ProTamilName] = this.TxtProTName.Text.Trim();
                    dr[CartDataStruct.ColumnName.Qty] = this.TxtQty.Text.Trim();
                    dr[CartDataStruct.ColumnName.Unit] = this.LblUnit.Text.Trim();
                    dr[CartDataStruct.ColumnName.Rate] = this.TxtRate.Text.Trim();
                    dr[CartDataStruct.ColumnName.Amount] = this.TxtAmt.Text.Trim();
                    dr[CartDataStruct.ColumnName.DiscPer] = this.TxtDiscPercentage.Text.Trim();
                    dr[CartDataStruct.ColumnName.DiscAmount] = this.TxtDiscAmt.Text.Trim();
                    dr[CartDataStruct.ColumnName.TotalAmount] = this.TxtTotAmt.Text.Trim();
                    dr[CartDataStruct.ColumnName.CalBORM] = this.CurrentPCalcBORM;
                    dr[CartDataStruct.ColumnName.TotDiscAmtFrmMrp] = this.TxtDiscFromMRP.Text.Trim();
                    dr[CartDataStruct.ColumnName.MRP] = this.TxtMrp.Text.Trim();

                    decimal _Qty = this.ToConvertTextToDecimal(this.TxtQty.Text);
                    decimal _Mrp = this.ToConvertTextToDecimal(this.TxtMrp.Text);
                    dr[CartDataStruct.ColumnName.TotMRP] = this.ToConvertAmtFormat(Convert.ToString(Math.Round(_Qty * _Mrp, 2)));



                    clsFrmPos.CartData.Rows.Add(dr);
                    DGVCart.DataSource = clsFrmPos.CartData.AsEnumerable().OrderByDescending(x => x.Field<int>(CartDataStruct.ColumnName.SNo)).CopyToDataTable();

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

        private int DGSelectedRowIndex = 0;
        private void DGVCart_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DGSelectedRowIndex = e.RowIndex;
                if (DGVCart.Focused && e.RowIndex >= 0)
                {
                    DGVCart.Rows[e.RowIndex].Selected = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void DGVCart_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (!DGVCart.Focused && DGVCart.Rows.Count > 0)
            {
                DGVCart.ClearSelection();
            }
        }

        private void TxtFinalDiscPer_Validated(object sender, EventArgs e)
        {
            try
            {
                if (clsFrmPos.CartData != null && clsFrmPos.CartData.Rows.Count > 0)
                    TxtFinalDiscPer.Text = ToConvertAmtFormat(TxtFinalDiscPer.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void TxtFinalDiscAmt_Validated(object sender, EventArgs e)
        {
            try
            {
                if (clsFrmPos.CartData != null && clsFrmPos.CartData.Rows.Count > 0)
                    TxtFinalDiscPer.Text = ToConvertAmtFormat(TxtFinalDiscPer.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void TxtPaymentDetCash_Validated(object sender, EventArgs e)
        {
            try
            {
                if (clsFrmPos.CartData != null && clsFrmPos.CartData.Rows.Count > 0)
                    TxtPaymentDetCash.Text = ToConvertAmtFormat(TxtPaymentDetCash.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void TxtPaymentDetUpi_Validated(object sender, EventArgs e)
        {
            try
            {
                if (clsFrmPos.CartData != null && clsFrmPos.CartData.Rows.Count > 0)
                    TxtPaymentDetUpi.Text = ToConvertAmtFormat(TxtPaymentDetUpi.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void TxtPaymentDetCard_Validated(object sender, EventArgs e)
        {
            try
            {
                if (clsFrmPos.CartData != null && clsFrmPos.CartData.Rows.Count > 0)
                    TxtPaymentDetCard.Text = ToConvertAmtFormat(TxtPaymentDetCard.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void TxtFinalDiscPer_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (TxtFinalDiscPer.Focused && clsFrmPos.CartData != null && clsFrmPos.CartData.Rows.Count > 0)
                    this.ToCalcTotalAmount();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void TxtFinalDiscAmt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (TxtFinalDiscAmt.Focused && clsFrmPos.CartData != null && clsFrmPos.CartData.Rows.Count > 0)
                    this.ToCalcTotalAmount();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void TxtPaymentDetCash_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (TxtPaymentDetCash.Focused && clsFrmPos.CartData != null && clsFrmPos.CartData.Rows.Count > 0)
                    this.ToCalcTotalAmount();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void TxtPaymentDetUpi_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (TxtPaymentDetUpi.Focused && clsFrmPos.CartData != null && clsFrmPos.CartData.Rows.Count > 0)
                    this.ToCalcTotalAmount();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void TxtPaymentDetCard_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (TxtPaymentDetCard.Focused && clsFrmPos.CartData != null && clsFrmPos.CartData.Rows.Count > 0)
                    this.ToCalcTotalAmount();
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

        private void BtnCancelAll_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you want to cancel ?", "Vegetable Box", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    this.clsFrmPos = new ClsFrmPos();
                    this.ClearProductDetails();
                    this.LoadCardGrid();
                    this.ClearAmountDetails();
                    this.TxtProductSearch.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void ClearAmountDetails()
        {
            try
            {
                this.LblFinalTotAmt.Text = "0.00";
                this.TxtFinalDiscPer.Text = "0.00";
                this.TxtFinalDiscAmt.Text = "0.00";
                this.LblFinalGrossAmt.Text = "0.00";
                this.LblFinalRoundOffAmt.Text = "0.00";
                this.LblFinalNetAmt.Text = "0.00";
                this.TxtPaymentDetCash.Text = "0.00";
                this.TxtPaymentDetUpi.Text = "0.00";
                this.TxtPaymentDetCard.Text = "0.00";
                this.LblFinalAmtReceived.Text = "0.00";
                this.LblFinalBalanceAmount.Text = "0.00";
            }
            catch
            {
                throw;
            }
        }

        private void TxtFinalDiscPer_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    this.TxtPaymentDetCash.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void TxtFinalDiscAmt_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    this.TxtPaymentDetCash.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void TxtPaymentDetCash_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    this.TxtPaymentDetUpi.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void TxtPaymentDetUpi_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    this.TxtPaymentDetCard.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void TxtPaymentDetCard_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    this.BtnSave.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGVCart.Rows.Count <= 0)
                    throw new Exception("Add atleast one product to cart.");

                if (this.ValidateSaveData())
                {
                    ClsTransaction clsTransaction = new ClsTransaction();
                    clsTransaction.TotAmount = Convert.ToDecimal(this.LblFinalTotAmt.Text);
                    clsTransaction.DiscPercent = Convert.ToDecimal(this.TxtFinalDiscPer.Text);
                    clsTransaction.DiscAmount = Convert.ToDecimal(this.TxtFinalDiscAmt.Text);
                    clsTransaction.GrossAmount = Convert.ToDecimal(this.LblFinalGrossAmt.Text);
                    clsTransaction.RoundOffAmount = Convert.ToDecimal(this.LblFinalRoundOffAmt.Text);
                    clsTransaction.NetAmount = Convert.ToDecimal(this.LblFinalNetAmt.Text);
                    clsTransaction.PrintTotDiscMRP = this.PrintTotDiscMRP;
                    clsTransaction.PrintTotMRP = this.PrintTotMRP;

                    List<ClsPaymentDetails> listClsPaymentDetails = new List<ClsPaymentDetails>();

                    ClsPaymentDetails clsPaymentDetails;

                    if (Convert.ToDecimal(this.TxtPaymentDetCash.Text) > 0)
                    {
                        clsPaymentDetails = new ClsPaymentDetails();
                        clsPaymentDetails.PaymentType = "CASH";
                        clsPaymentDetails.Amount = Convert.ToDecimal(this.TxtPaymentDetCash.Text);
                        listClsPaymentDetails.Add(clsPaymentDetails);
                    }

                    if (Convert.ToDecimal(this.TxtPaymentDetCard.Text) > 0)
                    {
                        clsPaymentDetails = new ClsPaymentDetails();
                        clsPaymentDetails.PaymentType = "CARD";
                        clsPaymentDetails.Amount = Convert.ToDecimal(this.TxtPaymentDetCard.Text);
                        listClsPaymentDetails.Add(clsPaymentDetails);
                    }

                    if (Convert.ToDecimal(this.TxtPaymentDetUpi.Text) > 0)
                    {
                        clsPaymentDetails = new ClsPaymentDetails();
                        clsPaymentDetails.PaymentType = "UPI";
                        clsPaymentDetails.Amount = Convert.ToDecimal(this.TxtPaymentDetUpi.Text);
                        listClsPaymentDetails.Add(clsPaymentDetails);
                    }

                    int BillNo = this.clsFrmPos.SaveData(this.clsFrmPos.CartData, clsTransaction, listClsPaymentDetails);

                    MessageBox.Show("Saved Sucessfully..." + Environment.NewLine + "Bill No : " + BillNo.ToString(), "Vegetable Box");

                    if (MessageBox.Show("Are you want to print ?", "Vegetable Box", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        ClsPrint clsPrint = new ClsPrint();
                        clsPrint.PrintSalesBill(BillNo, DateTime.Now.Date);
                    }

                    this.clsFrmPos = new ClsFrmPos();
                    this.ClearProductDetails();
                    this.LoadCardGrid();
                    this.ClearAmountDetails();
                    this.TxtProductSearch.Focus();
                }
                else
                {
                    throw new Exception("Please enter valid inputs.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void DGVCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DGSelectedRowIndex = e.RowIndex;
                if (DGVCart.Focused && e.RowIndex >= 0)
                {
                    DGVCart.Rows[e.RowIndex].Selected = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void DGVCart_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DGSelectedRowIndex = e.RowIndex;
                if (DGVCart.Focused && e.RowIndex >= 0)
                {
                    DGVCart.Rows[e.RowIndex].Selected = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void EditAndDeleteCartSelectedItem()
        {
            try
            {
                if (DGVCart.Focused && DGSelectedRowIndex >= 0)
                {
                    int sno = Convert.ToInt32(DGVCart.Rows[DGSelectedRowIndex].Cells[CartDataStruct.ColumnName.SNo].Value);

                    DataRow dr = clsFrmPos.CartData
                        .AsEnumerable().Where(x => x.Field<int>(CartDataStruct.ColumnName.SNo) == sno).FirstOrDefault();

                    if (dr != null)
                    {
                        this.ClearProductDetails();

                        this.TxtProCode.Text = Convert.ToString(dr[CartDataStruct.ColumnName.ProCode]);
                        this.TxtProName.Text = Convert.ToString(dr[CartDataStruct.ColumnName.ProName]);
                        this.TxtProTName.Text = Convert.ToString(dr[CartDataStruct.ColumnName.ProTamilName]);
                        this.TxtQty.Text = Convert.ToString(dr[CartDataStruct.ColumnName.Qty]);
                        this.LblUnit.Text = Convert.ToString(dr[CartDataStruct.ColumnName.Unit]);
                        this.TxtRate.Text = Convert.ToString(dr[CartDataStruct.ColumnName.Rate]);
                        this.TxtAmt.Text = Convert.ToString(dr[CartDataStruct.ColumnName.Amount]);
                        this.TxtDiscPercentage.Text = Convert.ToString(dr[CartDataStruct.ColumnName.DiscPer]);
                        this.TxtDiscAmt.Text = Convert.ToString(dr[CartDataStruct.ColumnName.DiscAmount]);
                        this.TxtTotAmt.Text = Convert.ToString(dr[CartDataStruct.ColumnName.TotalAmount]);
                        this.CurrentPCalcBORM = Convert.ToBoolean(dr[CartDataStruct.ColumnName.CalBORM]);
                        this.TxtDiscFromMRP.Text = Convert.ToString(dr[CartDataStruct.ColumnName.TotDiscAmtFrmMrp]);
                        this.TxtMrp.Text = Convert.ToString(dr[CartDataStruct.ColumnName.MRP]);

                        this.DeleteCartSelectedItem();
                    }
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
                if (DGVCart.Focused && DGSelectedRowIndex >= 0)
                {
                    int sno = Convert.ToInt32(DGVCart.Rows[DGSelectedRowIndex].Cells[CartDataStruct.ColumnName.SNo].Value);

                    if (clsFrmPos.CartData
                        .AsEnumerable().Where(x => x.Field<int>(CartDataStruct.ColumnName.SNo) == sno).Count() > 0)
                    {
                        for (int i = clsFrmPos.CartData.Rows.Count - 1; i >= 0; i--)
                        {
                            DataRow dr = clsFrmPos.CartData.Rows[i];
                            if (Convert.ToInt32(dr[CartDataStruct.ColumnName.SNo]) == sno)
                            {
                                dr.Delete();
                                break;
                            }
                            dr[CartDataStruct.ColumnName.SNo] = Convert.ToInt32(dr[CartDataStruct.ColumnName.SNo]) - 1;
                        }
                        clsFrmPos.CartData.AcceptChanges();

                        if (clsFrmPos.CartData.Rows.Count >= 1)
                        {
                            DGVCart.DataSource = clsFrmPos.CartData.AsEnumerable().OrderByDescending(x => x.Field<int>(CartDataStruct.ColumnName.SNo)).CopyToDataTable();
                            this.ToCalcTotalAmount();
                        }
                        else
                        {
                            DGVCart.DataSource = clsFrmPos.CartData;
                            this.ClearAmountDetails();
                        }
                    }

                    DGVCart.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
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

                if (string.IsNullOrEmpty(this.TxtProCode.Text.Trim()))
                {
                    this.ErrorProvider.SetError(this.TxtProCode, errValueSpecified);
                    IsValid = false;
                }

                if (string.IsNullOrEmpty(this.TxtProName.Text.Trim()))
                {
                    this.ErrorProvider.SetError(this.TxtProName, errValueSpecified);
                    IsValid = false;
                }

                if (string.IsNullOrEmpty(this.TxtProTName.Text.Trim()))
                {
                    this.ErrorProvider.SetError(this.TxtProTName, errValueSpecified);
                    IsValid = false;
                }

                if (string.IsNullOrEmpty(this.TxtQty.Text.Trim()))
                {
                    this.ErrorProvider.SetError(this.TxtQty, errValueSpecified);
                    IsValid = false;
                }
                else if (Convert.ToDecimal(this.TxtQty.Text.Trim()) <= 0)
                {
                    this.ErrorProvider.SetError(this.TxtQty, errValueGreaterThenZero);
                    IsValid = false;
                }

                if (string.IsNullOrEmpty(this.TxtRate.Text.Trim()))
                {
                    this.ErrorProvider.SetError(this.TxtRate, errValueSpecified);
                    IsValid = false;
                }
                else if (Convert.ToDecimal(this.TxtRate.Text.Trim()) <= 0)
                {
                    this.ErrorProvider.SetError(this.TxtRate, errValueGreaterThenZero);
                    IsValid = false;
                }

                if (string.IsNullOrEmpty(this.TxtAmt.Text.Trim()))
                {
                    this.ErrorProvider.SetError(this.TxtAmt, errValueSpecified);
                    IsValid = false;
                }
                else if (Convert.ToDecimal(this.TxtAmt.Text.Trim()) <= 0)
                {
                    this.ErrorProvider.SetError(this.TxtAmt, errValueGreaterThenZero);
                    IsValid = false;
                }

                if (string.IsNullOrEmpty(this.TxtTotAmt.Text.Trim()))
                {
                    this.ErrorProvider.SetError(this.TxtTotAmt, errValueSpecified);
                    IsValid = false;
                }
                else if (Convert.ToDecimal(this.TxtTotAmt.Text.Trim()) <= 0)
                {
                    this.ErrorProvider.SetError(this.TxtTotAmt, errValueGreaterThenZero);
                    IsValid = false;
                }

                return IsValid;
            }
            catch
            {
                throw;
            }
        }

        private bool ValidateSaveData()
        {
            try
            {
                bool IsValid = true;
                this.ErrorProvider.Clear();

                string errValueSpecified = "Value must be specified.";
                string errValueGreaterThenZero = "Value must be greater then zero.";

                if (string.IsNullOrEmpty(this.LblFinalTotAmt.Text.Trim()))
                {
                    this.ErrorProvider.SetError(this.LblFinalTotAmtDisp, errValueSpecified);
                    IsValid = false;
                }
                else if (Convert.ToDecimal(this.LblFinalTotAmt.Text.Trim()) <= 0)
                {
                    this.ErrorProvider.SetError(this.LblFinalTotAmtDisp, errValueGreaterThenZero);
                    IsValid = false;
                }

                if (string.IsNullOrEmpty(this.LblFinalGrossAmt.Text.Trim()))
                {
                    this.ErrorProvider.SetError(this.LblFinalGrossAmtDisp, errValueSpecified);
                    IsValid = false;
                }
                else if (Convert.ToDecimal(this.LblFinalGrossAmt.Text.Trim()) <= 0)
                {
                    this.ErrorProvider.SetError(this.LblFinalGrossAmtDisp, errValueGreaterThenZero);
                    IsValid = false;
                }

                if (string.IsNullOrEmpty(this.LblFinalNetAmt.Text.Trim()))
                {
                    this.ErrorProvider.SetError(this.LblFinalNetAmtDisp, errValueSpecified);
                    IsValid = false;
                }
                else if (Convert.ToDecimal(this.LblFinalNetAmt.Text.Trim()) <= 0)
                {
                    this.ErrorProvider.SetError(this.LblFinalNetAmtDisp, errValueGreaterThenZero);
                    IsValid = false;
                }

                if (string.IsNullOrEmpty(this.LblFinalAmtReceived.Text.Trim()))
                {
                    this.ErrorProvider.SetError(this.LblFinalAmtReceivedDisp, errValueSpecified);
                    IsValid = false;
                }
                else if (Convert.ToDecimal(this.LblFinalAmtReceived.Text.Trim()) <= 0)
                {
                    this.ErrorProvider.SetError(this.LblFinalAmtReceivedDisp, errValueGreaterThenZero);
                    IsValid = false;
                }

                if (string.IsNullOrEmpty(this.LblFinalBalanceAmount.Text.Trim()))
                {
                    this.ErrorProvider.SetError(this.LblFinalBalanceAmountDisp, errValueSpecified);
                    IsValid = false;
                }
                else if (Convert.ToDecimal(this.LblFinalBalanceAmount.Text.Trim()) != 0)
                {
                    this.ErrorProvider.SetError(this.LblFinalBalanceAmountDisp, "Balance amount must be zero.");
                    IsValid = false;
                }

                if (this.LblFinalAmtReceived.Text != this.LblFinalNetAmt.Text)
                {
                    this.ErrorProvider.SetError(this.LblFinalAmtReceived, "The received amount should be equal to the net amount.");
                    IsValid = false;
                }

                return IsValid;
            }
            catch
            {
                throw;
            }
        }

        private void TxtRBWRate_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(TxtRate.Text.Trim()))
                {
                    if (!string.IsNullOrEmpty(TxtRBWRate.Text.Trim()) && Convert.ToDecimal(TxtRBWRate.Text) > 0)
                    {
                        decimal res = ((1000 / Convert.ToDecimal(TxtRate.Text)) * Convert.ToDecimal(TxtRBWRate.Text)) / 1000;
                        TxtRBWWeight.Text = res.ToString("0.00");
                    }
                    else
                    {
                        TxtRBWWeight.Text = string.Empty;
                    }
                }
            }
            catch
            {

            }

        }
    }

    #region "Struct"

    internal struct ProductRateData
    {
        internal struct ColumnName
        {
            internal static string ProductCode = "ProductCode";
            internal static string ProductName = "ProductName";
            internal static string ProductTName = "ProductTName";
            internal static string ProductAltrName = "ProductAltrName";
            internal static string CatCode = "CatCode";
            internal static string QtyTypeCode = "QtyTypeCode";
            internal static string CalcBasedRateMast = "CalcBasedRateMast";
            internal static string Qty = "Qty";
            internal static string SellRate = "SellRate";
            internal static string SearchName = "SearchName";
            internal static string BarCode = "BarCode";
            internal static string PurRate = "PurRate";
            internal static string MRP = "MRP";
            internal static string SellingMarginPer = "SellingMarginPer";
            internal static string DiscPer = "DiscPer";
            internal static string DiscRate = "DiscRate";
        }
    }

    #endregion
}
