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
        int[] defectiveCategories = { 1, 2, 3 }; // Vegetables, Fruits, Banana
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
                this.ClearDiscountOptions();
                this.LoadCardGrid();
                this.ClearAmountDetails();
                this.GetMasterData();
                this.LoadTodayBillsWithPaymentsData();
                this.DispPosNetAmount();
                this.CallPos("POS1", "POS 1", false);
                SendKeys.Send("{TAB}");
                this.TxtProductSearch.Focus();

                this.LblTotalProfitAmt.Visible = false;
                this.LblProfitAmt.Visible = false;
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

                DGVCart.Columns[CartDataStruct.ColumnName.CalBORM].Visible = false;
                DGVCart.Columns[CartDataStruct.ColumnName.TotMRP].Visible = false;
                DGVCart.Columns[CartDataStruct.ColumnName.DiscPer].Visible = false;
                DGVCart.Columns[CartDataStruct.ColumnName.DiscAmount].Visible = false;

                DGVCart.Columns[CartDataStruct.ColumnName.PurAmount].Visible = false;
                DGVCart.Columns[CartDataStruct.ColumnName.ProfitAmount].Visible = false;
                DGVCart.Columns[CartDataStruct.ColumnName.DiscEmpCode].Visible = false;
                DGVCart.Columns[CartDataStruct.ColumnName.DiscCustCode].Visible = false;
                DGVCart.Columns[CartDataStruct.ColumnName.IsDefective].Visible = false;
                DGVCart.Columns[CartDataStruct.ColumnName.AllowRateChange].Visible = false;
                DGVCart.Columns[CartDataStruct.ColumnName.SellingRateZero].Visible = false;
                DGVCart.Columns[CartDataStruct.ColumnName.CatCode].Visible = false;

                DGVCart.Columns[CartDataStruct.ColumnName.ProCode].HeaderText = "Pro-Code";
                DGVCart.Columns[CartDataStruct.ColumnName.ProTamilName].HeaderText = "Product Name";
                DGVCart.Columns[CartDataStruct.ColumnName.TotDiscAmtFrmMrp].HeaderText = "Discount Amount";
                DGVCart.Columns[CartDataStruct.ColumnName.Qty].HeaderText = "Quantity";
                DGVCart.Columns[CartDataStruct.ColumnName.Amount].HeaderText = "Amount";
                DGVCart.Columns[CartDataStruct.ColumnName.Rate].HeaderText = "Selling Rate";
                DGVCart.Columns[CartDataStruct.ColumnName.TotalAmount].HeaderText = "Total Amount";
                DGVCart.Columns[CartDataStruct.ColumnName.MRP].HeaderText = "Maximum Retail Price";
                DGVCart.Columns[CartDataStruct.ColumnName.SNo].HeaderText = "S.No";

                foreach (DataGridViewColumn DGVColumn in DGVCart.Columns)
                {
                    DGVColumn.SortMode = DataGridViewColumnSortMode.NotSortable;

                    if (DGVColumn.Name == CartDataStruct.ColumnName.ProTamilName)
                        DGVColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    else
                        DGVColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

                    if (DGVColumn.Name == CartDataStruct.ColumnName.Qty)
                    {
                        DGVColumn.ValueType = typeof(decimal);
                        DGVColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        //DGVColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    }

                    if (DGVColumn.Name == CartDataStruct.ColumnName.Rate || DGVColumn.Name == CartDataStruct.ColumnName.Amount
                        || DGVColumn.Name == CartDataStruct.ColumnName.MRP || DGVColumn.Name == CartDataStruct.ColumnName.TotDiscAmtFrmMrp
                        || DGVColumn.Name == CartDataStruct.ColumnName.TotalAmount)
                    {
                        DGVColumn.DefaultCellStyle.Format = "0.00";
                        DGVColumn.ValueType = typeof(decimal);
                        DGVColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    }
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
                        _DtSearch.Columns.Add(ProductRateData.ColumnName.MRP, typeof(decimal));

#pragma warning disable CS8602 // Dereference of a possibly null reference.

                        if (clsFrmPos.ProductRateData.AsEnumerable()
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
                            _DtSearch = clsFrmPos.ProductRateData.AsEnumerable()
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
        private decimal? CurrentProfitAmount { get; set; }
        private bool? CurrentAllowRateChange { get; set; }
        private bool? CurrentSellingRateZero { get; set; }

        private void LoadCurrentProduct()
        {
            try
            {
                if (DgvProductSearch.Rows.Count > 0)
                {
                    this.CurrentPCode = (string)DgvProductSearch.CurrentRow.Cells[ProductRateData.ColumnName.ProductCode].Value;
                    this.CurrentMRP = (decimal)DgvProductSearch.CurrentRow.Cells[ProductRateData.ColumnName.MRP].Value;

                    if (clsFrmPos.ProductRateData != null && clsFrmPos.ProductRateData.Rows.Count > 0)
                    {
                        if (clsFrmPos.ProductRateData.AsEnumerable()
                            .Where(x => x.Field<string>(ProductRateData.ColumnName.ProductCode) == this.CurrentPCode
                            && x.Field<decimal>(ProductRateData.ColumnName.MRP) == this.CurrentMRP).Count() > 0)
                        {

                            DataRow dataRow = clsFrmPos.ProductRateData
                                .AsEnumerable().Where(x => x.Field<string>(ProductRateData.ColumnName.ProductCode) == this.CurrentPCode
                                && x.Field<decimal>(ProductRateData.ColumnName.MRP) == this.CurrentMRP).FirstOrDefault();

                            if (dataRow != null)
                            {
                                this.CurrentPName = (dataRow[ProductRateData.ColumnName.ProductName] != null ?
                                                    (string)dataRow[ProductRateData.ColumnName.ProductName] : string.Empty);

                                this.CurrentPTamilName = (dataRow[ProductRateData.ColumnName.ProductTName] != null ?
                                                    (string)dataRow[ProductRateData.ColumnName.ProductTName] : string.Empty);

                                if (rdoDefaultDisc.Checked)
                                {
                                    this.CurrentPSellRate = (dataRow[ProductRateData.ColumnName.SellRate] != null ?
                                                        (decimal)dataRow[ProductRateData.ColumnName.SellRate] : Convert.ToDecimal("0.00"));

                                    this.CurrentProfitAmount = (dataRow[ProductRateData.ColumnName.ProfitAmt] != null ?
                                                        (decimal)dataRow[ProductRateData.ColumnName.ProfitAmt] : Convert.ToDecimal("0.00"));
                                }
                                else if (rdoEmpPartnerDisc.Checked)
                                {
                                    this.CurrentPSellRate = (dataRow[ProductRateData.ColumnName.EmpSellRate] != null ?
                                                        (decimal)dataRow[ProductRateData.ColumnName.EmpSellRate] : Convert.ToDecimal("0.00"));
                                    this.CurrentProfitAmount = (dataRow[ProductRateData.ColumnName.EmpProfitAmt] != null ?
                                                        (decimal)dataRow[ProductRateData.ColumnName.EmpProfitAmt] : Convert.ToDecimal("0.00"));
                                }
                                else if (rdoPrivilageDisc.Checked)
                                {
                                    this.CurrentPSellRate = (dataRow[ProductRateData.ColumnName.CustSellRate] != null ?
                                                        (decimal)dataRow[ProductRateData.ColumnName.CustSellRate] : Convert.ToDecimal("0.00"));
                                    this.CurrentProfitAmount = (dataRow[ProductRateData.ColumnName.CustProfitAmt] != null ?
                                                        (decimal)dataRow[ProductRateData.ColumnName.CustProfitAmt] : Convert.ToDecimal("0.00"));
                                }

                                this.CurrentPurRate = (dataRow[ProductRateData.ColumnName.PurRate] != null ?
                                                    (decimal)dataRow[ProductRateData.ColumnName.PurRate] : Convert.ToDecimal("0.00"));


                                this.CurrentMRP = (dataRow[ProductRateData.ColumnName.MRP] != null ?
                                                    (decimal)dataRow[ProductRateData.ColumnName.MRP] : Convert.ToDecimal("0.00"));

                                this.CurrentPQtyShortName = (dataRow[ProductRateData.ColumnName.Qty] != null ?
                                                    (string)dataRow[ProductRateData.ColumnName.Qty] : string.Empty);

                                this.CurrentAllowRateChange = (dataRow[ProductRateData.ColumnName.AllowRateChange] != null
                                                               && dataRow[ProductRateData.ColumnName.AllowRateChange].ToString() == "Y" ? true : false);

                                string _Value = (dataRow[ProductRateData.ColumnName.CalcBasedRateMast] != null ?
                                                   (string)dataRow[ProductRateData.ColumnName.CalcBasedRateMast] : string.Empty);

                                if (_Value == "Y")
                                    this.CurrentPCalcBORM = true;
                                else
                                    this.CurrentPCalcBORM = false;

                                this.TxtProCode.Text = this.CurrentPCode;
                                this.TxtProTName.Text = this.CurrentPTamilName;
                                this.LblUnit.Text = this.CurrentPQtyShortName;
                                this.TxtRate.Text = this.CurrentPSellRate.ToString();

                                this.LblPurchaseAmt.Text = this.CurrentPurRate.ToString();
                                this.LblProfitAmt.Text = this.CurrentProfitAmount.ToString();

                                if (this.CurrentMRP > 0)
                                    this.TxtMrp.Text = this.CurrentMRP.ToString();
                                else
                                    this.TxtMrp.Text = this.CurrentPSellRate.ToString();

                                this.TxtDiscPercentage.Text = "0.00";
                                this.TxtDiscAmt.Text = "0.00";

                                if (this.TxtRate.Text == "0.00")
                                    this.CurrentSellingRateZero = true;
                                else
                                    this.CurrentSellingRateZero = false;

                                if (this.TxtRate.Text == "0.00" || this.CurrentAllowRateChange == true)
                                    this.TxtRate.ReadOnly = false;
                                else
                                    this.TxtRate.ReadOnly = true;

                                int _Val = (dataRow[ProductRateData.ColumnName.CatCode] != null ?
                                                   (int)dataRow[ProductRateData.ColumnName.CatCode] : 0);
                                this.chkIsDefective.Visible = defectiveCategories.Contains(_Val);
                                this.chkIsDefective.Tag = _Val;

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
                this.TxtDiscFromMRP.Text = string.Empty;

                this.LblPurchaseAmt.Text = string.Empty;
                this.LblPurchaseAmt.Visible = false;

                this.LblProfitAmt.Text = string.Empty;
                this.LblProfitAmt.Visible = true;

                this.TxtRate.ReadOnly = true;
                this.chkIsDefective.Checked = false;
                this.chkIsDefective.Visible = false;
                this.chkIsDefective.Tag = 0;
            }
            catch
            {
                throw;
            }
        }

        private void ClearDiscountOptions()
        {
            try
            {
                this.rdoDefaultDisc.Checked = true;
                this.cmbName.SelectedIndex = -1;
                this.lblName.Enabled = false;
                this.cmbName.Enabled = false;
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
                    if (!string.IsNullOrWhiteSpace(this.TxtQty.Text) &&
                        this.TxtQty.Text != "." &&
                        decimal.TryParse(this.TxtQty.Text.Trim(), out decimal qty) &&
                        qty > 0)
                    {
                        //if (this.CurrentPCalcBORM == true)
                        //    this.BtnAddCart.Focus();
                        //else
                        //    this.TxtRate.Focus();

                        if (string.IsNullOrWhiteSpace(this.TxtRate.Text) || (decimal.TryParse(this.TxtRate.Text.Trim(), out decimal rate)
                            && rate <= 0) || this.CurrentAllowRateChange == true || this.CurrentSellingRateZero == true)
                            this.TxtRate.Focus();
                        else
                            this.BtnAddCart.Focus();
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
                // Handle modifier key shortcuts first
                if (e.Control && e.KeyCode == Keys.G)
                {
                    DGVCart.Focus();
                    return;
                }
                else if (e.Control && e.KeyCode == Keys.E)
                {
                    if (DGVCart.Focused && DGVCart.SelectedRows.Count >= 1)
                    {
                        this.EditAndDeleteCartSelectedItem();
                        this.TxtQty.Focus();
                    }
                    return;
                }
                else if (e.Control && e.KeyCode == Keys.F1)
                {
                    this.LblProfitAmt.Visible = !this.LblProfitAmt.Visible;
                    this.LblTotalProfitAmt.Visible = !this.LblTotalProfitAmt.Visible;
                    return;
                }

                // Handle single key shortcuts
                switch (e.KeyCode)
                {
                    case Keys.Escape:
                        if (TxtCashTendered.Focused && LblFinalAmtReceived.Text == LblFinalNetAmt.Text)
                            BtnSave.Focus();
                        else
                            TxtCashTendered.Focus();
                        break;

                    case Keys.Delete:
                        if (DGVCart.Focused && DGVCart.SelectedRows.Count >= 1)
                        {
                            this.DeleteCartSelectedItem();
                            this.TxtProductSearch.Focus();
                        }
                        break;

                    case Keys.F1:
                        this.TxtProductSearch.Focus();
                        break;

                    case Keys.F4:
                        this.LblPurchaseAmt.Visible = !this.LblPurchaseAmt.Visible;
                        break;

                    case Keys.F5:
                        this.clsFrmPos.GetProductRateDetails();
                        this.GetMasterData();
                        break;

                    case Keys.F12:
                        this.TLP_RateBasedWt.Visible = !this.TLP_RateBasedWt.Visible;
                        this.TxtRBWRate.Clear();
                        this.TxtRBWWeight.Clear();
                        if (this.TLP_RateBasedWt.Visible)
                            this.TxtRBWRate.Focus();
                        break;
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
                    if (!string.IsNullOrWhiteSpace(this.TxtRate.Text) &&
                    decimal.TryParse(this.TxtRate.Text.Trim(), out decimal rate) &&
                    rate > 0)
                    {
                        this.BtnAddCart.Focus();
                    }
                    else
                    {
                        throw new Exception("Please enter a valid rate greater than zero.");
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
                decimal _PurRate = this.ToConvertTextToDecimal(this.LblPurchaseAmt.Text);

                if (this.CurrentPSellRate <= 0 || this.CurrentSellingRateZero == true)
                    this.TxtMrp.Text = this.ToConvertTextToDecimal(this.TxtRate.Text).ToString("0.00");

                if (this.CurrentAllowRateChange == true && _Rate > this.CurrentMRP)
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

                this.LblProfitAmt.Text = this.ToConvertAmtFormat(_PurRate == 0 ? "0.00" : Convert.ToString(_Rate - _PurRate));
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
                    decimal decTotalProfitAmount = Math.Round(Convert.ToDecimal(clsFrmPos.CartData.Compute("SUM(" + CartDataStruct.ColumnName.ProfitAmount + ")", string.Empty)), 2);
                    this.LblTotalProfitAmt.Text = this.ToConvertAmtFormat(decTotalProfitAmount.ToString());

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

                    //decimal decCashAmt = this.ToConvertTextToDecimal(this.TxtPaymentDetCash.Text);
                    decimal decCashAmt = this.ToConvertTextToDecimal(this.TxtCashTendered.Text);
                    decimal decCashUpi = this.ToConvertTextToDecimal(this.TxtPaymentDetUpi.Text);
                    decimal decCashCard = this.ToConvertTextToDecimal(this.TxtPaymentDetCard.Text);
                    decimal decCashGPay = this.ToConvertTextToDecimal(this.TxtPaymentDetGPay.Text);
                    decimal decCashCredit = this.ToConvertTextToDecimal(this.TxtPaymentDetCredit.Text);

                    decimal decAmtReceived = decCashAmt + decCashUpi + decCashCard + decCashGPay + decCashCredit;
                    decimal decBalanceAmt = decAmtReceived - decNetAmt;

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
                if (TxtQty.Focused && TxtProCode.Text != string.Empty && TxtQty.Text != ".")
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
                    int proCode = Convert.ToInt32(this.TxtProCode.Text);
                    decimal mrp = this.ToConvertTextToDecimal(this.TxtMrp.Text);

                    // 🔎 check if product already exists in Cart with same ProCode & MRP
                    DataRow existingRow = clsFrmPos.CartData.AsEnumerable()
                        .FirstOrDefault(r => r.Field<int>(CartDataStruct.ColumnName.ProCode) == proCode
                                          && r.Field<decimal>(CartDataStruct.ColumnName.MRP) == mrp);

                    if (existingRow != null)
                    {
                        string unit = this.LblUnit.Text.Trim();
                        decimal qtyE = this.ToConvertTextToDecimal(this.TxtQty.Text);
                        decimal rate = this.ToConvertTextToDecimal(this.TxtRate.Text);
                        decimal amount = this.ToConvertTextToDecimal(this.TxtAmt.Text);
                        decimal totalAmount = this.ToConvertTextToDecimal(this.TxtTotAmt.Text);
                        decimal totDiscAmtFrmMrp = this.ToConvertTextToDecimal(this.TxtDiscFromMRP.Text);

                        // Update existing row (Add Qty + Recalculate Amounts)
                        decimal existingQty = this.ToConvertTextToDecimal(existingRow[CartDataStruct.ColumnName.Qty].ToString());
                        decimal newQty = existingQty + qtyE;

                        existingRow[CartDataStruct.ColumnName.Qty] = newQty.ToString(unit == "Pcs" ? "0" : "0.00");
                        existingRow[CartDataStruct.ColumnName.Amount] = (newQty * rate).ToString("0.00");
                        existingRow[CartDataStruct.ColumnName.TotalAmount] = (newQty * rate).ToString("0.00");
                        existingRow[CartDataStruct.ColumnName.TotMRP] = (newQty * mrp).ToString("0.00");

                        decimal existingTotDiscAmtFrmMrp = this.ToConvertTextToDecimal(existingRow[CartDataStruct.ColumnName.TotDiscAmtFrmMrp].ToString());
                        existingRow[CartDataStruct.ColumnName.TotDiscAmtFrmMrp] = existingTotDiscAmtFrmMrp + totDiscAmtFrmMrp;

                        // Profit calc
                        decimal profitAmt = this.ToConvertTextToDecimal(this.LblProfitAmt.Text);
                        existingRow[CartDataStruct.ColumnName.ProfitAmount] = (newQty * profitAmt).ToString("0.00");

                        if (this.IsEdited == true && Convert.ToString(existingRow[CartDataStruct.ColumnName.BillStatus]) != "N")
                        {
                            existingRow[CartDataStruct.ColumnName.BillStatus] = "E"; // Edit
                            this.BillStatus = null;
                        }
                    }
                    else
                    {
                        DataRow dr = clsFrmPos.CartData.NewRow();
                        dr[CartDataStruct.ColumnName.SNo] = clsFrmPos.CartData.Rows.Count + 1;
                        dr[CartDataStruct.ColumnName.ProCode] = this.TxtProCode.Text.Trim();
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
                        dr[CartDataStruct.ColumnName.PurAmount] = this.LblPurchaseAmt.Text.Trim();

                        decimal qty = 0, profitAmt = 0;
                        decimal.TryParse(this.TxtQty.Text.Trim(), out qty);
                        decimal.TryParse(this.LblProfitAmt.Text.Trim(), out profitAmt);
                        dr[CartDataStruct.ColumnName.ProfitAmount] = this.ToConvertAmtFormat((qty * profitAmt).ToString());

                        dr[CartDataStruct.ColumnName.IsDefective] = this.chkIsDefective.Checked ? "Y" : null;
                        dr[CartDataStruct.ColumnName.AllowRateChange] = this.CurrentAllowRateChange;
                        dr[CartDataStruct.ColumnName.SellingRateZero] = this.CurrentSellingRateZero;
                        dr[CartDataStruct.ColumnName.CatCode] = (int)this.chkIsDefective.Tag;

                        if (rdoEmpPartnerDisc.Checked)
                            dr[CartDataStruct.ColumnName.DiscEmpCode] = this.cmbName.SelectedValue;

                        if (rdoPrivilageDisc.Checked)
                            dr[CartDataStruct.ColumnName.DiscCustCode] = this.cmbName.SelectedValue;

                        decimal _Qty = this.ToConvertTextToDecimal(this.TxtQty.Text);
                        decimal _Mrp = this.ToConvertTextToDecimal(this.TxtMrp.Text);
                        dr[CartDataStruct.ColumnName.TotMRP] = this.ToConvertAmtFormat(Convert.ToString(Math.Round(_Qty * _Mrp, 2)));

                        if (this.IsEdited == true && this.BillStatus == "F")
                        {
                            dr[CartDataStruct.ColumnName.BillStatus] = "E"; // Edit
                            this.BillStatus = null;
                        }
                        else if (this.IsEdited == true && this.BillStatus != "F")
                        {
                            dr[CartDataStruct.ColumnName.BillStatus] = "N"; // New Entry
                            this.BillStatus = null;
                        }

                        clsFrmPos.CartData.Rows.Add(dr);
                    }

                    DGVCart.DataSource = clsFrmPos.CartData.AsEnumerable().OrderByDescending(x => x.Field<int>(CartDataStruct.ColumnName.SNo)).CopyToDataTable();

                    if (this.IsEdited == false)
                    {
                        this.clsFrmPos.SavePos(this.clsFrmPos.CartData, this.LblCurrentPosName.Text.Replace(" ", ""));
                        this.DispPosNetAmount();
                    }

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

        private void TxtPaymentDetGPay_Validated(object sender, EventArgs e)
        {
            try
            {
                if (clsFrmPos.CartData != null && clsFrmPos.CartData.Rows.Count > 0)
                    TxtPaymentDetGPay.Text = ToConvertAmtFormat(TxtPaymentDetGPay.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void TxtPaymentDetCredit_Validated(object sender, EventArgs e)
        {
            try
            {
                if (clsFrmPos.CartData != null && clsFrmPos.CartData.Rows.Count > 0)
                    TxtPaymentDetCredit.Text = ToConvertAmtFormat(TxtPaymentDetCredit.Text);
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

        private void TxtPaymentDetGPay_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (TxtPaymentDetGPay.Focused && clsFrmPos.CartData != null && clsFrmPos.CartData.Rows.Count > 0)
                    this.ToCalcTotalAmount();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void TxtPaymentDetCredit_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (TxtPaymentDetCredit.Focused && clsFrmPos.CartData != null && clsFrmPos.CartData.Rows.Count > 0)
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
                string message = $"Are you sure you want to cancel? If you cancel, {this.LblCurrentPosName.Text} will be deleted.";

                if (this.IsEdited)
                    message = "Are you sure you want to cancel?";

                if (MessageBox.Show(message, "Vegetable Box", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    this.clsFrmPos = new ClsFrmPos();
                    this.ClearProductDetails();
                    this.ClearDiscountOptions();
                    this.LoadCardGrid();
                    this.ClearAmountDetails();

                    if (this.IsEdited == false)
                    {
                        this.clsFrmPos.SavePos(this.clsFrmPos.CartData.Clone(), this.LblCurrentPosName.Text.Replace(" ", ""));
                        this.DispPosNetAmount();
                    }
                    else
                    {
                        this.CallPos("POS1", "POS 1", false);
                    }

                    this.LoadTodayBillsWithPaymentsData();
                    
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
                this.TxtCashTendered.Text = "0.00";
                this.TxtPaymentDetCash.Text = "0.00";
                this.TxtPaymentDetUpi.Text = "0.00";
                this.TxtPaymentDetCard.Text = "0.00";
                this.TxtPaymentDetGPay.Text = "0.00";
                this.TxtPaymentDetCredit.Text = "0.00";
                this.LblFinalAmtReceived.Text = "0.00";
                this.LblFinalBalanceAmount.Text = "0.00";
                this.LblTotalProfitAmt.Text = "0.00";
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
                    this.TxtPaymentDetGPay.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void TxtPaymentDetGPay_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    this.TxtPaymentDetCredit.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void TxtPaymentDetCredit_KeyDown(object sender, KeyEventArgs e)
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
                this.Cursor = Cursors.WaitCursor;

                if (DGVCart.Rows.Count <= 0)
                    throw new Exception("Add atleast one product to cart.");

                CustomerUI:
                int customerCode = 0;
                if (this.TxtPaymentDetCredit.Text != string.Empty && Convert.ToDecimal(this.TxtPaymentDetCredit.Text) > 0)
                {
                    FrmPosCreditCustomer frmPosCreditCustomer = new FrmPosCreditCustomer();
                    frmPosCreditCustomer.WindowState = FormWindowState.Normal;
                    DialogResult result = frmPosCreditCustomer.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        customerCode = frmPosCreditCustomer.creditCustomerCode;
                    }
                }

                if (customerCode <= 0 && Convert.ToDecimal(this.TxtPaymentDetCredit.Text) > 0)
                {
                    DialogResult result = MessageBox.Show("Please select a customer for credit payment." +
                        "\nDo you want to select a customer? Click Yes, or No to change payment details.",
                        "Vegetable Box", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        goto CustomerUI; // Go to select customer
                    }
                    else
                    {
                        this.TxtPaymentDetCredit.Focus();
                        return;
                    }
                }

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
                    clsTransaction.TotProfitAmount = Convert.ToDecimal(this.LblTotalProfitAmt.Text);

                    List<ClsPaymentDetails> listClsPaymentDetails = new List<ClsPaymentDetails>();

                    ClsPaymentDetails clsPaymentDetails;

                    if (Convert.ToDecimal(this.TxtPaymentDetCash.Text) > 0)
                    {
                        clsPaymentDetails = new ClsPaymentDetails();
                        clsPaymentDetails.PaymentType = Account.PaymentTypeCash;
                        clsPaymentDetails.Amount = Convert.ToDecimal(this.TxtPaymentDetCash.Text);
                        listClsPaymentDetails.Add(clsPaymentDetails);
                    }

                    if (Convert.ToDecimal(this.TxtPaymentDetCard.Text) > 0)
                    {
                        clsPaymentDetails = new ClsPaymentDetails();
                        clsPaymentDetails.PaymentType = Account.PaymentTypeCard;
                        clsPaymentDetails.Amount = Convert.ToDecimal(this.TxtPaymentDetCard.Text);
                        listClsPaymentDetails.Add(clsPaymentDetails);
                    }

                    if (Convert.ToDecimal(this.TxtPaymentDetUpi.Text) > 0)
                    {
                        clsPaymentDetails = new ClsPaymentDetails();
                        clsPaymentDetails.PaymentType = Account.PaymentTypeUpi;
                        clsPaymentDetails.Amount = Convert.ToDecimal(this.TxtPaymentDetUpi.Text);
                        listClsPaymentDetails.Add(clsPaymentDetails);
                    }

                    if (Convert.ToDecimal(this.TxtPaymentDetGPay.Text) > 0)
                    {
                        clsPaymentDetails = new ClsPaymentDetails();
                        clsPaymentDetails.PaymentType = Account.PaymentTypeGPay;
                        clsPaymentDetails.Amount = Convert.ToDecimal(this.TxtPaymentDetGPay.Text);
                        listClsPaymentDetails.Add(clsPaymentDetails);
                    }

                    if (Convert.ToDecimal(this.TxtPaymentDetCredit.Text) > 0)
                    {
                        clsPaymentDetails = new ClsPaymentDetails();
                        clsPaymentDetails.PaymentType = Account.PaymentTypeOnCredit;
                        clsPaymentDetails.Amount = Convert.ToDecimal(this.TxtPaymentDetCredit.Text);
                        clsPaymentDetails.CustomerCode = customerCode;

                        listClsPaymentDetails.Add(clsPaymentDetails);
                    }

                    int BillNo = this.clsFrmPos.SaveData(this.clsFrmPos.CartData, clsTransaction, listClsPaymentDetails, this.IsEdited, this.EditedBillNo);

                    if (!IsEdited)
                    {
                        MessageBox.Show("Saved Sucessfully..." + Environment.NewLine + "Bill No : " + BillNo.ToString(), "Vegetable Box");
                    }
                    else
                    {
                        BillNo = this.EditedBillNo;
                        MessageBox.Show("Updated Sucessfully..." + Environment.NewLine + "Bill No : " + BillNo.ToString(), "Vegetable Box");
                    }

                    if (MessageBox.Show("Are you want to print ?", "Vegetable Box", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        ClsPrint clsPrint = new ClsPrint();
                        clsPrint.PrintSalesBill(BillNo, DateTime.Now.Date);
                    }

                    this.clsFrmPos = new ClsFrmPos();
                    this.ClearProductDetails();
                    this.ClearDiscountOptions();
                    this.LoadCardGrid();
                    this.ClearAmountDetails();

                    //Delete the saved POS
                    if (this.IsEdited == false)
                    {
                        this.clsFrmPos.SavePos(this.clsFrmPos.CartData.Clone(), this.LblCurrentPosName.Text.Replace(" ", ""));                        
                    }
                    
                    this.LoadTodayBillsWithPaymentsData();
                    this.DispPosNetAmount();
                    this.CallPos("POS1", "POS 1", false);
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
            finally
            {
                this.Cursor = Cursors.Default;
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

                        this.LblProfitAmt.Text = Convert.ToString(dr[CartDataStruct.ColumnName.ProfitAmount]);
                        this.LblPurchaseAmt.Text = Convert.ToString(dr[CartDataStruct.ColumnName.PurAmount]);

                        this.chkIsDefective.Checked = dr[CartDataStruct.ColumnName.IsDefective] != DBNull.Value &&
                            Convert.ToString(dr[CartDataStruct.ColumnName.IsDefective]) == "Y";

                        this.CurrentAllowRateChange = Convert.ToBoolean(dr[CartDataStruct.ColumnName.AllowRateChange]);
                        this.CurrentSellingRateZero = Convert.ToBoolean(dr[CartDataStruct.ColumnName.SellingRateZero]);

                        if (this.CurrentAllowRateChange == true || this.chkIsDefective.Checked || this.CurrentSellingRateZero == true)
                            this.TxtRate.ReadOnly = false;
                        else
                            this.TxtRate.ReadOnly = true;

                        this.chkIsDefective.Tag = Convert.ToInt32(dr[CartDataStruct.ColumnName.CatCode]);

                        int _Val = (dr[CartDataStruct.ColumnName.CatCode] != null ?
                            (int)dr[CartDataStruct.ColumnName.CatCode] : 0);
                        this.chkIsDefective.Visible = defectiveCategories.Contains(_Val);

                        this.BillStatus = Convert.ToString(dr[CartDataStruct.ColumnName.BillStatus]);

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

                if (string.IsNullOrEmpty(this.TxtProTName.Text.Trim()))
                {
                    this.ErrorProvider.SetError(this.TxtProTName, errValueSpecified);
                    IsValid = false;
                }

                if (string.IsNullOrWhiteSpace(this.TxtQty.Text))
                {
                    this.ErrorProvider.SetError(this.TxtQty, errValueSpecified);
                    IsValid = false;
                }
                else if (!decimal.TryParse(this.TxtQty.Text.Trim(), out decimal qty))
                {
                    this.ErrorProvider.SetError(this.TxtQty, "Please enter a valid number.");
                    IsValid = false;
                }
                else if (qty <= 0)
                {
                    this.ErrorProvider.SetError(this.TxtQty, errValueGreaterThenZero);
                    IsValid = false;
                }

                //Selling Rate
                decimal purchaseAmt;
                decimal sellingrate; // selling rate

                // Validate TxtRate
                if (string.IsNullOrWhiteSpace(this.TxtRate.Text))
                {
                    this.ErrorProvider.SetError(this.TxtRate, errValueSpecified);
                    IsValid = false;
                }
                else if (!decimal.TryParse(this.TxtRate.Text.Trim(), out sellingrate))
                {
                    this.ErrorProvider.SetError(this.TxtRate, "Please enter a valid number.");
                    IsValid = false;
                }
                else if (sellingrate <= 0)
                {
                    this.ErrorProvider.SetError(this.TxtRate, errValueGreaterThenZero);
                    IsValid = false;
                }
                // Compare with purchase amount if valid number
                else if (decimal.TryParse(this.LblPurchaseAmt.Text.Trim(), out purchaseAmt))
                {
                    if (!chkIsDefective.Checked && (purchaseAmt > 0 && sellingrate <= purchaseAmt))
                    {
                        this.ErrorProvider.SetError(this.TxtRate, "Selling rate should be greater than Purchase rate");
                        IsValid = false;
                    }
                }

                if (string.IsNullOrWhiteSpace(this.TxtAmt.Text))
                {
                    this.ErrorProvider.SetError(this.TxtAmt, errValueSpecified);
                    IsValid = false;
                }
                else if (!decimal.TryParse(this.TxtAmt.Text.Trim(), out decimal amount))
                {
                    this.ErrorProvider.SetError(this.TxtAmt, "Please enter a valid number.");
                    IsValid = false;
                }
                else if (amount <= 0)
                {
                    this.ErrorProvider.SetError(this.TxtAmt, errValueGreaterThenZero);
                    IsValid = false;
                }

                if (string.IsNullOrWhiteSpace(this.TxtTotAmt.Text))
                {
                    this.ErrorProvider.SetError(this.TxtTotAmt, errValueSpecified);
                    IsValid = false;
                }
                else if (!decimal.TryParse(this.TxtTotAmt.Text.Trim(), out decimal totalAmount))
                {
                    this.ErrorProvider.SetError(this.TxtTotAmt, "Please enter a valid number.");
                    IsValid = false;
                }
                else if (totalAmount <= 0)
                {
                    this.ErrorProvider.SetError(this.TxtTotAmt, errValueGreaterThenZero);
                    IsValid = false;
                }

                if (!rdoDefaultDisc.Checked && cmbName.SelectedIndex == -1)
                {
                    this.ErrorProvider.SetError(this.cmbName, "Please select a name.");
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

                decimal decBalanceAmt = this.ToConvertTextToDecimal(this.LblFinalBalanceAmount.Text);
                if (decBalanceAmt < 0)
                {
                    this.ErrorProvider.SetError(this.LblFinalBalanceAmountDisp, "Customer needs to pay this amount.");
                    IsValid = false;
                }

                decimal decNetAmt = this.ToConvertTextToDecimal(this.LblFinalNetAmt.Text);
                decimal decAmtReceived = this.ToConvertTextToDecimal(this.LblFinalAmtReceived.Text);

                if (decAmtReceived < decNetAmt)
                {
                    MessageBox.Show("Payment not complete. Please collect full amount.",
                    "Vegetable Box", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    this.ErrorProvider.SetError(this.LblFinalAmtReceivedDisp, "Payment not complete. Please collect full amount.");
                    IsValid = false;
                }

                decimal decCash = this.ToConvertTextToDecimal(this.TxtPaymentDetCash.Text);
                decimal decUpi = this.ToConvertTextToDecimal(this.TxtPaymentDetUpi.Text);
                decimal decCard = this.ToConvertTextToDecimal(this.TxtPaymentDetCard.Text);
                decimal decGPay = this.ToConvertTextToDecimal(this.TxtPaymentDetGPay.Text);
                decimal decCredit = this.ToConvertTextToDecimal(this.TxtPaymentDetCredit.Text);

                if ((decCash + decUpi + decCard + decGPay + decCredit) > decNetAmt)
                {
                    MessageBox.Show("Full payment is already received in cash. Other payment modes are not allowed.",
                        "Vegetable Box", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    this.ErrorProvider.SetError(this.LblFinalAmtReceivedDisp,
                        "Full payment is already received in cash. Please remove other payment entries.");

                    IsValid = false;
                }

                if (IsValid == true && decBalanceAmt > 0)
                {
                    string space = "                                     ";
                    MessageBox.Show("Don’t forget to return the balance amount to the customer:\n\n" +
                        space + " 👉 " + LblFinalBalanceAmount.Text + "          ", "Vegetable Box", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void rdoDefaultDisc_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdoDefaultDisc.Checked)
                {
                    this.cmbName.SelectedIndex = -1;
                    this.lblName.Enabled = false;
                    this.cmbName.Enabled = false;
                    this.cmbName.DataSource = null;
                    this.BtnCancel.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        DataTable _EmployeeMaster = new DataTable();
        DataTable _CustomerMaster = new DataTable();
        internal void GetMasterData()
        {
            try
            {
                Master _Master = new Master();
                this._EmployeeMaster = _Master.GetUserMaster();
                this._CustomerMaster = _Master.GetCustomerMaster();
            }
            catch
            {
                throw;
            }
        }

        internal void LoadTodayBillsWithPaymentsData()
        {
            try
            {
                this.clsFrmPos.GetTodayBillsWithPayments();
                this.DGVBillDetails.DataSource = this.clsFrmPos.TodayBillsWithPaymentsData;
                this.DGVBillDetails.ClearSelection();

                DGVBillDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
                DGVBillDetails.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                foreach (DataGridViewColumn DGVColumn in DGVBillDetails.Columns)
                {
                    DGVColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
                    DGVColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }

                this.IsEdited = false;
                this.EditedBillNo = 0;
                this.BillStatus = null;
                this.DGBillSelectedRowIndex = -1;
            }
            catch
            {
                throw;
            }
        }

        private void rdoEmpPartnerDisc_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rdoEmpPartnerDisc.Checked)
                {
                    this.lblName.Enabled = true;
                    this.cmbName.Enabled = true;
                    this.BtnCancel.PerformClick();
                    FillControls.ComboBoxFill(this.cmbName, this._EmployeeMaster, "Code", "Name", false, "");
                    this.cmbName.SelectedIndex = -1;
                    this.cmbName.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void rdoPrivilageDisc_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rdoPrivilageDisc.Checked)
                {
                    this.lblName.Enabled = true;
                    this.cmbName.Enabled = true;
                    this.BtnCancel.PerformClick();
                    FillControls.ComboBoxFill(this.cmbName, this._CustomerMaster, "Code", "Name", false, "");
                    this.cmbName.SelectedIndex = -1;
                    this.cmbName.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void chkIsDefective_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.chkIsDefective.Checked)
                {
                    this.TxtRate.ReadOnly = false;
                }
                else
                {
                    this.TxtRate.ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void TxtCashTendered_KeyDown(object sender, KeyEventArgs e)
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

        private void TxtCashTendered_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //this.TxtPaymentDetCash.Text = this.TxtCashTendered.Text;

                if (TxtCashTendered.Focused && clsFrmPos.CartData != null && clsFrmPos.CartData.Rows.Count > 0)
                    this.ToCalcTotalAmount();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void TxtCashTendered_Validated(object sender, EventArgs e)
        {
            try
            {
                if (clsFrmPos.CartData != null && clsFrmPos.CartData.Rows.Count > 0)
                {
                    decimal netAmt = Convert.ToDecimal(this.LblFinalNetAmt.Text);
                    decimal tenderedAmt = Convert.ToDecimal(this.TxtCashTendered.Text);

                    // Always format tendered text
                    this.TxtCashTendered.Text = ToConvertAmtFormat(tenderedAmt.ToString());

                    // If tendered is less than or equal to net, customer still owes money
                    if (tenderedAmt <= netAmt)
                    {
                        this.TxtPaymentDetCash.Text = ToConvertAmtFormat(tenderedAmt.ToString());
                        //this.LblFinalBalanceAmount.Text = ToConvertAmtFormat((tenderedAmt - netAmt).ToString()); ;  // No balance
                    }
                    else
                    {
                        this.TxtPaymentDetCash.Text = ToConvertAmtFormat(netAmt.ToString());
                        //this.LblFinalBalanceAmount.Text = ToConvertAmtFormat((tenderedAmt - netAmt).ToString()); // Return balance
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        int DGBillSelectedRowIndex = -1;
        private void DGVBillDetails_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DGVBillDetails.Focused && e.RowIndex >= 0)
                {
                    DGBillSelectedRowIndex = e.RowIndex;
                    DGVBillDetails.Rows[e.RowIndex].Selected = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void DGVBillDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DGVBillDetails.Focused && e.RowIndex >= 0)
                {
                    DGBillSelectedRowIndex = e.RowIndex;
                    DGVBillDetails.Rows[e.RowIndex].Selected = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void DGVBillDetails_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DGVBillDetails.Focused && e.RowIndex >= 0)
                {
                    DGBillSelectedRowIndex = e.RowIndex;
                    DGVBillDetails.Rows[e.RowIndex].Selected = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void DGVBillDetails_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (!DGVBillDetails.Focused && DGVBillDetails.Rows.Count > 0)
            {
                DGVBillDetails.ClearSelection();
            }
        }

        bool IsEdited = false;
        int EditedBillNo = 0;
        string? BillStatus = null;

        private void BtnBillEdit_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (DGBillSelectedRowIndex >= 0)
                {
                    int BillNo = Convert.ToInt32(this.DGVBillDetails.Rows[DGBillSelectedRowIndex].Cells[BillsWithPaymentsData.ColumnName.BillNo].Value);

                    if (MessageBox.Show("Are you sure want to edit the selected bill?", "Vegetable Box",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        return;
                    }

                    this.clsFrmPos.GetBillDetailsToEdit(BillNo);

                    if (this.clsFrmPos.BillDetails.IsDataTableValid())
                    {
                        this.clsFrmPos.CartData = this.clsFrmPos.BillDetails.Copy();
                        this.DGVCart.DataSource = clsFrmPos.CartData.AsEnumerable().OrderByDescending(x => x.Field<int>(CartDataStruct.ColumnName.SNo)).CopyToDataTable();
                        this.IsEdited = true;
                        this.EditedBillNo = BillNo;
                        this.ToCalcTotalAmount();
                        this.DGVBillDetails.ClearSelection();
                    }

                    this.LblCurrentPosName.Text = "Edit Mode";
                    this.TxtProductSearch.Focus();
                }
                else
                {
                    MessageBox.Show("Please select a bill to edit.", "Vegetable Box");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void TxtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                // allows 0-9, backspace, and decimal
                if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
                {
                    e.Handled = true;
                    return;
                }

                if (LblUnit.Text.ToUpper() == "PCS" && e.KeyChar == 46)
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

        private void BtnBillCancel_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (DGBillSelectedRowIndex >= 0)
                {
                    int BillNo = Convert.ToInt32(this.DGVBillDetails.Rows[DGBillSelectedRowIndex].Cells[BillsWithPaymentsData.ColumnName.BillNo].Value);

                    if (MessageBox.Show("Are you sure want to cancel the selected bill?", "Vegetable Box",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        return;
                    }

                    this.clsFrmPos.CancelSalesBill(BillNo, DateTime.Now.Date);

                    MessageBox.Show("Bill Cancelled Successfully.", "Vegetable Box");

                    this.LoadTodayBillsWithPaymentsData();
                    this.DGVBillDetails.ClearSelection();

                    this.TxtProductSearch.Focus();
                }
                else
                {
                    MessageBox.Show("Please select a bill to cancel.", "Vegetable Box");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void BtnBillPrint_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (DGBillSelectedRowIndex >= 0)
                {
                    int BillNo = Convert.ToInt32(this.DGVBillDetails.Rows[DGBillSelectedRowIndex].Cells[BillsWithPaymentsData.ColumnName.BillNo].Value);

                    if (MessageBox.Show("Are you sure want to print the selected bill?", "Vegetable Box",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        return;
                    }

                    ClsPrint clsPrint = new ClsPrint();
                    clsPrint.PrintSalesBill(BillNo, DateTime.Now.Date);

                    this.TxtProductSearch.Focus();
                }
                else
                {
                    MessageBox.Show("Please select a bill to cancel.", "Vegetable Box");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void BtnBillReload_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                this.LoadTodayBillsWithPaymentsData();
                this.TxtProductSearch.Focus();
                MessageBox.Show("Reloaded Successfully.", "Vegetable Box");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void DispPosNetAmount()
        {
            try
            {
                this.LblPos1.Text = "0.00";
                this.LblPos2.Text = "0.00";
                this.LblPos3.Text = "0.00";
                this.LblPos4.Text = "0.00";
                this.LblPos5.Text = "0.00";

                string colPosId = "PosId";
                string colNetAmount = "NetAmount";

                DataTable dt = this.clsFrmPos.GetPosNetAmount();

                if(dt.IsDataTableValid())
                {
                    foreach(DataRow dr in dt.Rows)
                    {
                        if(Convert.ToString(dr[colPosId]) == "POS1")
                        {
                            this.LblPos1.Text = Convert.ToDecimal(dr[colNetAmount]).ToString("0.00");                            
                        }
                        else if (Convert.ToString(dr[colPosId]) == "POS2")
                        {
                            this.LblPos2.Text = Convert.ToDecimal(dr[colNetAmount]).ToString("0.00");
                        }
                        else if (Convert.ToString(dr[colPosId]) == "POS3")
                        {
                            this.LblPos3.Text = Convert.ToDecimal(dr[colNetAmount]).ToString("0.00");
                        }
                        else if (Convert.ToString(dr[colPosId]) == "POS4")
                        {
                            this.LblPos4.Text = Convert.ToDecimal(dr[colNetAmount]).ToString("0.00");
                        }
                        else if (Convert.ToString(dr[colPosId]) == "POS5")
                        {
                            this.LblPos5.Text = Convert.ToDecimal(dr[colNetAmount]).ToString("0.00");
                        }
                    }
                }
            }
            catch
            {
                throw;
            }
        }

        private void CallPos(string PosId, string PosName, bool NeedValidate = true)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (NeedValidate)
                {
                    if (this.IsEdited)
                    {
                        MessageBox.Show(
                            "Please complete the bill editing before selecting a POS.", "Vegetable Box",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Stop
                        );
                        return;
                    }

                    if (this.LblCurrentPosName.Text == PosName)
                    {
                        MessageBox.Show($"{PosName} is already selected. Please choose another POS.", "Vegetable Box",
                            MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }

                    if (MessageBox.Show($"Are you sure want to load {PosName} ?", "Vegetable Box",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        return;
                    }
                }

                this.ClearAmountDetails();
                this.clsFrmPos.GetPos(PosId);

                if (this.clsFrmPos.BillDetails.IsDataTableValid())
                {
                    this.clsFrmPos.CartData = this.clsFrmPos.BillDetails.Copy();
                    this.DGVCart.DataSource = clsFrmPos.CartData.AsEnumerable().OrderByDescending(x => x.Field<int>(CartDataStruct.ColumnName.SNo)).CopyToDataTable();
                }
                else if (this.clsFrmPos.BillDetails != null)
                {
                    this.clsFrmPos.CartData = this.clsFrmPos.BillDetails.Copy();
                    this.DGVCart.DataSource = clsFrmPos.CartData;
                }

                this.IsEdited = false;
                this.EditedBillNo = 0;
                this.ToCalcTotalAmount();
                this.LblCurrentPosName.Text = PosName;
                this.TxtProductSearch.Focus();
            }
            catch
            {
                throw;
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void BtnPos1_Click(object sender, EventArgs e)
        {
            try
            {
                this.CallPos("POS1", "POS 1");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void BtnPos2_Click(object sender, EventArgs e)
        {
            try
            {
                this.CallPos("POS2", "POS 2");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void BtnPos3_Click(object sender, EventArgs e)
        {
            try
            {
                this.CallPos("POS3", "POS 3");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void BtnPos4_Click(object sender, EventArgs e)
        {
            try
            {
                this.CallPos("POS4", "POS 4");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void BtnPos5_Click(object sender, EventArgs e)
        {
            try
            {
                this.CallPos("POS5", "POS 5");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
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
            internal static string ProfitAmt = "ProfitAmt";
            internal static string EmpProfitAmt = "EmpProfitAmt";
            internal static string EmpSellRate = "EmpSellRate";
            internal static string CustProfitAmt = "CustProfitAmt";
            internal static string CustSellRate = "CustSellRate";

            internal static string AllowRateChange = "AllowRateChange";
            internal static string BarCode2 = "BarCode2";
            internal static string BarCode3 = "BarCode3";
            internal static string BarCode4 = "BarCode4";
        }
    }

    internal struct BillsWithPaymentsData
    {
        internal struct ColumnName
        {
            internal static string BillNo = "BillNo";
            internal static string ProductCode = "Payments";
        }
    }

    #endregion
}
