using System.Data;
using System.Runtime.CompilerServices;

namespace VegetableBox
{
    public partial class FrmDailyAccountClosing : Form
    {

        ClsFrmDailyAccountClosing clsFrmDailyAccountClosing = new ClsFrmDailyAccountClosing();
        public FrmDailyAccountClosing()
        {
            InitializeComponent();
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

        private void FrmDailyAccountClosing_Load(object sender, EventArgs e)
        {
            try
            {
                this.clsFrmDailyAccountClosing.InsertZeroCashDailySummary();

                this.ClearControls();
                this.ClearDenominationControls();
                this.ClearCashRelated();

                this.LoadAllTranControls();
                this.LoadOpeningBalanceControls();
                this.LoadGridControls();

                this.TxtCash500Count.Focus();
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
                this.ClearDenominationControls();
                this.ClearCashRelated();

                this.PnlCash.Enabled = true;
                this.PnlCoin.Enabled = true;

                this.TxtCash500Count.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void ClearControls()
        {
            try
            {
                //Sales
                this.TxtSalesCash.Text = string.Empty;
                this.TxtSalesCard.Text = string.Empty;
                this.TxtSalesUpi.Text = string.Empty;
                this.TxtSalesGPay.Text = string.Empty;
                this.TxtSalesCredit.Text = string.Empty;
                this.TxtSalesTotal.Text = string.Empty;

                //Vendor
                this.TxtVendorCash.Text = string.Empty;
                this.TxtVendorCard.Text = string.Empty;
                this.TxtVendorGPay.Text = string.Empty;
                this.TxtVendorTotal.Text = string.Empty;

                //Expense
                this.TxtExpenseCash.Text = string.Empty;
                this.TxtExpenseCard.Text = string.Empty;
                this.TxtExpenseGPay.Text = string.Empty;
                this.TxtExpenseTotal.Text = string.Empty;

                //CustomerDebit
                this.TxtCustomerDebitCard.Text = string.Empty;
                this.TxtCustomerDebitCash.Text = string.Empty;
                this.TxtCustomerDebitGPay.Text = string.Empty;
                this.TxtCustomerDebitTotal.Text = string.Empty;

                //UndiyalDebit
                this.TxtUndiyalOpeningBalance.Text = string.Empty;
                this.TxtUndiyalDeposit.Text = string.Empty;
                this.TxtUndiyalWithdraw.Text = string.Empty;
                this.TxtUndiyalClosingBalance.Text = string.Empty;

                this.PnlCash.Enabled = true;
                this.PnlCoin.Enabled = true;

                this.ErrorProvider.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void ClearDenominationControls()
        {
            try
            {
                //Cash
                this.TxtCash500Count.Text = string.Empty;
                this.TxtCash200Count.Text = string.Empty;
                this.TxtCash100Count.Text = string.Empty;
                this.TxtCash50Count.Text = string.Empty;
                this.TxtCash20Count.Text = string.Empty;
                this.TxtCash10Count.Text = string.Empty;
                this.TxtCash5Count.Text = string.Empty;

                this.TxtCash500Amt.Text = string.Empty;
                this.TxtCash200Amt.Text = string.Empty;
                this.TxtCash100Amt.Text = string.Empty;
                this.TxtCash50Amt.Text = string.Empty;
                this.TxtCash20Amt.Text = string.Empty;
                this.TxtCash10Amt.Text = string.Empty;
                this.TxtCash5Amt.Text = string.Empty;

                this.TxtCashTotalAmt.Text = string.Empty;

                //Coin
                this.TxtCoin20Count.Text = string.Empty;
                this.TxtCoin10Count.Text = string.Empty;
                this.TxtCoin5Count.Text = string.Empty;
                this.TxtCoin2Count.Text = string.Empty;
                this.TxtCoin1Count.Text = string.Empty;

                this.TxtCoin20Amt.Text = string.Empty;
                this.TxtCoin10Amt.Text = string.Empty;
                this.TxtCoin5Amt.Text = string.Empty;
                this.TxtCoin2Amt.Text = string.Empty;
                this.TxtCoin1Amt.Text = string.Empty;
                this.TxtCoinPktAmt.Text = string.Empty;

                this.TxtCoinTotalAmt.Text = string.Empty;

                this.TxtTotalCashCoinOnHand.Text = string.Empty;

                this.ErrorProvider.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void ClearCashRelated()
        {
            try
            {
                //CashOnly
                //this.TxtCashOnlyOpeningBalance.Text = string.Empty;
                this.TxtCashOnlySales.Text = string.Empty;
                this.TxtCashOnlyCustomerCreditRepayment.Text = string.Empty;
                this.TxtCashOnlyUndiyalWithdraw.Text = string.Empty;
                this.TxtCashOnlyVendorPayment.Text = string.Empty;
                this.TxtCashOnlyExpense.Text = string.Empty;
                this.TxtCashOnlyUndiyalDeposit.Text = string.Empty;
                this.TxtCashOnHand.Text = string.Empty;
                this.TxtCoinOnHand.Text = string.Empty;
                this.TxtCashOnlyTally.Text = string.Empty;
                this.TxtCashOnlyClosingBalance.Text = string.Empty;

                this.TxtMismatchAmount.Text = string.Empty;
                this.TxtMismatchExplanation.Text = string.Empty;

                this.ErrorProvider.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void LoadAllTranControls()
        {
            try
            {
                this.clsFrmDailyAccountClosing.GetUIData();

                if (this.clsFrmDailyAccountClosing.SalesPaymentData.IsDataTableValid())
                {
                    foreach (DataRow row in this.clsFrmDailyAccountClosing.SalesPaymentData.Rows)
                    {
                        if (row[SalesPaymentDataTable.ColumnName.PaymentType].ToString() == Account.PaymentTypeCash)
                            this.TxtSalesCash.Text = row[SalesPaymentDataTable.ColumnName.Amount].ToString();
                        else if (row[SalesPaymentDataTable.ColumnName.PaymentType].ToString() == Account.PaymentTypeCard)
                            this.TxtSalesCard.Text = row[SalesPaymentDataTable.ColumnName.Amount].ToString();
                        else if (row[SalesPaymentDataTable.ColumnName.PaymentType].ToString() == Account.PaymentTypeUpi)
                            this.TxtSalesUpi.Text = row[SalesPaymentDataTable.ColumnName.Amount].ToString();
                        else if (row[SalesPaymentDataTable.ColumnName.PaymentType].ToString() == Account.PaymentTypeGPay)
                            this.TxtSalesGPay.Text = row[SalesPaymentDataTable.ColumnName.Amount].ToString();
                        else if (row[SalesPaymentDataTable.ColumnName.PaymentType].ToString() == Account.PaymentTypeOnCredit)
                            this.TxtSalesCredit.Text = row[SalesPaymentDataTable.ColumnName.Amount].ToString();
                    }

                    this.TxtSalesTotal.Text = this.clsFrmDailyAccountClosing.SalesPaymentData
                                              .Compute("SUM([" + SalesPaymentDataTable.ColumnName.Amount + "])", string.Empty).ToString();
                }

                if (this.clsFrmDailyAccountClosing.VendorPaymentData.IsDataTableValid())
                {
                    foreach (DataRow row in this.clsFrmDailyAccountClosing.VendorPaymentData.Rows)
                    {
                        if (row[VendorPaymentDetailsDataTable.ColumnName.PaymentType].ToString() == Account.PaymentTypeCash)
                            this.TxtVendorCash.Text = row[VendorPaymentDetailsDataTable.ColumnName.Amount].ToString();
                        else if (row[VendorPaymentDetailsDataTable.ColumnName.PaymentType].ToString() == Account.PaymentTypeCard)
                            this.TxtVendorCard.Text = row[VendorPaymentDetailsDataTable.ColumnName.Amount].ToString();
                        else if (row[VendorPaymentDetailsDataTable.ColumnName.PaymentType].ToString() == Account.PaymentTypeGPay)
                            this.TxtVendorGPay.Text = row[VendorPaymentDetailsDataTable.ColumnName.Amount].ToString();
                    }

                    this.TxtVendorTotal.Text = this.clsFrmDailyAccountClosing.VendorPaymentData
                                               .Compute("SUM([" + VendorPaymentDetailsDataTable.ColumnName.Amount + "])", string.Empty).ToString();

                }

                if (this.clsFrmDailyAccountClosing.ExpensesData.IsDataTableValid())
                {
                    foreach (DataRow row in this.clsFrmDailyAccountClosing.ExpensesData.Rows)
                    {
                        if (row[ExpensesDataTable.ColumnName.PaymentType].ToString() == Account.PaymentTypeCash)
                            this.TxtExpenseCash.Text = row[ExpensesDataTable.ColumnName.Amount].ToString();
                        else if (row[ExpensesDataTable.ColumnName.PaymentType].ToString() == Account.PaymentTypeCard)
                            this.TxtExpenseCard.Text = row[ExpensesDataTable.ColumnName.Amount].ToString();
                        else if (row[ExpensesDataTable.ColumnName.PaymentType].ToString() == Account.PaymentTypeGPay)
                            this.TxtExpenseGPay.Text = row[ExpensesDataTable.ColumnName.Amount].ToString();
                    }

                    this.TxtExpenseTotal.Text = this.clsFrmDailyAccountClosing.ExpensesData
                                               .Compute("SUM([" + ExpensesDataTable.ColumnName.Amount + "])", string.Empty).ToString();
                }

                if (this.clsFrmDailyAccountClosing.CustomerDebitsData.IsDataTableValid())
                {
                    foreach (DataRow row in this.clsFrmDailyAccountClosing.CustomerDebitsData.Rows)
                    {
                        if (row[CustomerDebitDataTable.ColumnName.PaymentType].ToString() == Account.PaymentTypeCash)
                            this.TxtCustomerDebitCash.Text = row[CustomerDebitDataTable.ColumnName.Amount].ToString();
                        else if (row[CustomerDebitDataTable.ColumnName.PaymentType].ToString() == Account.PaymentTypeCard)
                            this.TxtCustomerDebitCard.Text = row[CustomerDebitDataTable.ColumnName.Amount].ToString();
                        else if (row[CustomerDebitDataTable.ColumnName.PaymentType].ToString() == Account.PaymentTypeUpi)
                            this.TxtCustomerDebitUpi.Text = row[CustomerDebitDataTable.ColumnName.Amount].ToString();
                        else if (row[CustomerDebitDataTable.ColumnName.PaymentType].ToString() == Account.PaymentTypeGPay)
                            this.TxtCustomerDebitGPay.Text = row[CustomerDebitDataTable.ColumnName.Amount].ToString();
                    }

                    this.TxtCustomerDebitTotal.Text = this.clsFrmDailyAccountClosing.CustomerDebitsData
                                               .Compute("SUM([" + CustomerDebitDataTable.ColumnName.Amount + "])", string.Empty).ToString();
                }

                if (this.clsFrmDailyAccountClosing.UndiyalData.IsDataTableValid())
                {
                    DataRow? undiyalRow = this.clsFrmDailyAccountClosing.UndiyalData.Rows[0];
                    if (undiyalRow != null)
                    {
                        this.TxtUndiyalOpeningBalance.Text = undiyalRow[CustomerUndiyalDataTable.ColumnName.OpeningBalance].ToString();
                        this.TxtUndiyalDeposit.Text = undiyalRow[CustomerUndiyalDataTable.ColumnName.Deposit].ToString();
                        this.TxtUndiyalWithdraw.Text = undiyalRow[CustomerUndiyalDataTable.ColumnName.Withdraw].ToString();
                        this.TxtUndiyalClosingBalance.Text = undiyalRow[CustomerUndiyalDataTable.ColumnName.ClosingBalance].ToString();
                    }
                }

            }
            catch
            {
                throw;
            }
        }

        private void LoadOpeningBalanceControls()
        {
            try
            {
                this.clsFrmDailyAccountClosing = new ClsFrmDailyAccountClosing();
                this.clsFrmDailyAccountClosing.GetCashDailySummaryByToday();

                if (this.clsFrmDailyAccountClosing.CashDailySummaryByTodayData.IsDataTableValid())
                {
                    DataRow? dataRow = this.clsFrmDailyAccountClosing.CashDailySummaryByTodayData.Rows[0];
                    if (dataRow != null)
                    {
                        this.TxtCashOnlyOpeningBalance.Text = dataRow[CashDailySummaryTable.ColumnName.OpeningBalance].ToString();
                        this.TxtCashOnlyClosingBalance.Text = dataRow[CashDailySummaryTable.ColumnName.ClosingBalance].ToString();
                    }
                }
            }
            catch
            {
                throw;
            }
        }

        private void LoadGridControls()
        {
            try
            {
                this.clsFrmDailyAccountClosing = new ClsFrmDailyAccountClosing();
                this.clsFrmDailyAccountClosing.GetCashDailyAllClosingDetailsByToday();

                this.DGView.DataSource = this.clsFrmDailyAccountClosing.CashDailyAllClosingDetailsByTodayData;

                this.SetGridStyle();

                this.DGView.ClearSelection();
            }
            catch
            {
                throw;
            }
        }

        #region "Common TextBox KeyPress Events"

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

        private void AlphaNumeric_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
                {
                    e.Handled = true;
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

        private void ComboBox_Enter(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            if (comboBox != null)
            {
                this.BeginInvoke(new Action(() => comboBox.DroppedDown = true));
            }
        }

        #endregion

        private void FrmDailyAccountClosing_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (this.TxtCash500Count.Focused)
                        this.TxtCash200Count.Focus();
                    else if (this.TxtCash200Count.Focused)
                        this.TxtCash100Count.Focus();
                    else if (this.TxtCash100Count.Focused)
                        this.TxtCash50Count.Focus();
                    else if (this.TxtCash50Count.Focused)
                        this.TxtCash20Count.Focus();
                    else if (this.TxtCash20Count.Focused)
                        this.TxtCash10Count.Focus();
                    else if (this.TxtCash10Count.Focused)
                        this.TxtCash5Count.Focus();
                    else if (this.TxtCash5Count.Focused)
                        this.TxtCoin20Count.Focus();
                    else if (this.TxtCoin20Count.Focused)
                        this.TxtCoin10Count.Focus();
                    else if (this.TxtCoin10Count.Focused)
                        this.TxtCoin5Count.Focus();
                    else if (this.TxtCoin5Count.Focused)
                        this.TxtCoin2Count.Focus();
                    else if (this.TxtCoin2Count.Focused)
                        this.TxtCoin1Count.Focus();
                    else if (this.TxtCoin1Count.Focused)
                        this.TxtCoinPktAmt.Focus();
                    else if (this.TxtCoinPktAmt.Focused)
                        this.BtnProceed.Focus();
                    else if (this.TxtMismatchExplanation.Focused)
                        this.BtnSave.Focus();

                    //SendKeys.Send("{TAB}");
                }

                if (e.KeyCode == Keys.Escape)
                    BtnExit.PerformClick();
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
                this.Validation();

                clsFrmDailyAccountClosing.OpeningBalance = Convert.ToDecimal(TxtCashOnlyOpeningBalance.Text);
                clsFrmDailyAccountClosing.CashSales = Convert.ToDecimal(TxtCashOnlySales.Text);
                clsFrmDailyAccountClosing.CustomerDueReceivedCash = Convert.ToDecimal(TxtCashOnlyCustomerCreditRepayment.Text);
                clsFrmDailyAccountClosing.UndiyalCashWithdraw = Convert.ToDecimal(TxtCashOnlyUndiyalWithdraw.Text);

                clsFrmDailyAccountClosing.VendorPaymentCash = Convert.ToDecimal(TxtCashOnlyVendorPayment.Text);
                clsFrmDailyAccountClosing.ExpenseCash = Convert.ToDecimal(TxtCashOnlyExpense.Text);
                clsFrmDailyAccountClosing.UndiyalCashDeposit = Convert.ToDecimal(TxtCashOnlyUndiyalDeposit.Text);

                clsFrmDailyAccountClosing.CashOnHand = Convert.ToDecimal(TxtCashOnHand.Text);
                clsFrmDailyAccountClosing.CoinOnHand = Convert.ToDecimal(TxtCoinOnHand.Text);

                clsFrmDailyAccountClosing.TallyAmount = Convert.ToDecimal(TxtCashOnlyTally.Text);
                clsFrmDailyAccountClosing.ClosingBalance = Convert.ToDecimal(TxtCashOnlyClosingBalance.Text);

                clsFrmDailyAccountClosing.Remarks = TxtMismatchExplanation.Text.Trim();

                clsFrmDailyAccountClosing.Save();

                MessageBox.Show("Cash account closed successfully. Don't forget to take a backup.", "Vegetable Box");

                this.LoadGridControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void Validation()
        {
            try
            {
                bool IsValid = true;
                this.ErrorProvider.Clear();

                if (this.TxtSalesTotal.Text == string.Empty || this.TxtSalesTotal.Text == "0.00")
                {
                    this.ErrorProvider.SetError(this.TxtSalesTotal, "At least one sale must be done before closing the account.");
                    IsValid = false;
                }

                if (this.TxtCashOnHand.Text == string.Empty || this.TxtCashOnHand.Text == "0.00")
                {
                    this.ErrorProvider.SetError(this.TxtCashOnHand, "Please enter cash denominations.");
                    IsValid = false;
                }

                if (this.TxtMismatchAmount.Text != string.Empty && Convert.ToDecimal(this.TxtMismatchAmount.Text) != 0 && this.TxtMismatchExplanation.Text.Trim() == string.Empty)
                {
                    this.ErrorProvider.SetError(this.TxtMismatchExplanation, "Please enter cash mismatch explanation.");
                    IsValid = false;
                }

                if (IsValid == false)
                {
                    throw new Exception("Please enter the valid input...");
                }
            }
            catch
            {
                throw;
            }
        }

        private void SetGridStyle()
        {
            try
            {
                DGView.Columns[CashDailySummaryTable.ColumnName.TranNo].Visible = false;
                DGView.Columns[CashDailySummaryTable.ColumnName.TranDate].Visible = false;
                DGView.Columns[CashDailySummaryTable.ColumnName.UpdatedDate].Visible = false;

                DGView.Columns[CashDailySummaryTable.ColumnName.OpeningBalance].HeaderText = "Opening Balance";
                DGView.Columns[CashDailySummaryTable.ColumnName.CashSales].HeaderText = "Sales";
                DGView.Columns[CashDailySummaryTable.ColumnName.CustomerDueReceivedCash].HeaderText = "Customer Due Received";
                DGView.Columns[CashDailySummaryTable.ColumnName.UndiyalCashWithdraw].HeaderText = "Undiyal Withdraw";
                DGView.Columns[CashDailySummaryTable.ColumnName.VendorPaymentCash].HeaderText = "Vendor Payment";
                DGView.Columns[CashDailySummaryTable.ColumnName.ExpenseCash].HeaderText = "Expense";
                DGView.Columns[CashDailySummaryTable.ColumnName.UndiyalCashDeposit].HeaderText = "Undiyal Deposit";
                DGView.Columns[CashDailySummaryTable.ColumnName.CashOnHand].HeaderText = "Cash On Hand";
                DGView.Columns[CashDailySummaryTable.ColumnName.CoinOnHand].HeaderText = "Coin On Hand";
                DGView.Columns[CashDailySummaryTable.ColumnName.TallyAmount].HeaderText = "Tally Amount";
                DGView.Columns[CashDailySummaryTable.ColumnName.ClosingBalance].HeaderText = "Closing Balance";
                DGView.Columns[CashDailySummaryTable.ColumnName.Remarks].HeaderText = "Remarks";
                DGView.Columns[CashDailySummaryTable.ColumnName.UpdatedBy].HeaderText = "Closed By";

                foreach (DataGridViewColumn DGVColumn in DGView.Columns)
                {
                    if (DGVColumn.Name == CashDailySummaryTable.ColumnName.OpeningBalance)
                        DGVColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    else
                        DGVColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                    if (DGVColumn.Name != CashDailySummaryTable.ColumnName.Remarks && DGVColumn.Name != CashDailySummaryTable.ColumnName.UpdatedBy)
                    {
                        DGVColumn.DefaultCellStyle.Format = "0.00";
                        DGVColumn.ValueType = typeof(decimal);
                        DGVColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    }
                }
            }
            catch
            {
                throw;
            }
        }

        private int DGSelectedRowIndex = 0;
        private void DGView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DGSelectedRowIndex = e.RowIndex;
                if (e.RowIndex >= 0)
                {
                    DGView.Rows[e.RowIndex].Selected = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        #region "Denomination"
        private void TxtCash500Count_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(TxtCash500Count.Text.Trim()))
                {
                    this.TxtCash500Amt.Text = this.ToConvertDecimalFormatString((Convert.ToInt32(TxtCash500Count.Text.Trim()) * 500).ToString());

                    this.CalculatedDenominationAmount();
                }
                else
                    this.TxtCash500Amt.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void TxtCash200Count_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(TxtCash200Count.Text.Trim()))
                    TxtCash200Amt.Text = this.ToConvertDecimalFormatString((Convert.ToInt32(TxtCash200Count.Text.Trim()) * 200).ToString());
                else
                    TxtCash200Amt.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void TxtCash100Count_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(TxtCash100Count.Text.Trim()))
                    TxtCash100Amt.Text = this.ToConvertDecimalFormatString((Convert.ToInt32(TxtCash100Count.Text.Trim()) * 100).ToString());
                else
                    TxtCash100Amt.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void TxtCash50Count_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(TxtCash50Count.Text.Trim()))
                    TxtCash50Amt.Text = this.ToConvertDecimalFormatString((Convert.ToInt32(TxtCash50Count.Text.Trim()) * 50).ToString());
                else
                    TxtCash50Amt.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void TxtCash20Count_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(TxtCash20Count.Text.Trim()))
                    TxtCash20Amt.Text = this.ToConvertDecimalFormatString((Convert.ToInt32(TxtCash20Count.Text.Trim()) * 20).ToString());
                else
                    TxtCash20Amt.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void TxtCash10Count_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(TxtCash10Count.Text.Trim()))
                    TxtCash10Amt.Text = this.ToConvertDecimalFormatString((Convert.ToInt32(TxtCash10Count.Text.Trim()) * 10).ToString());
                else
                    TxtCash10Amt.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void TxtCash5Count_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(TxtCash5Count.Text.Trim()))
                    TxtCash5Amt.Text = this.ToConvertDecimalFormatString((Convert.ToInt32(TxtCash5Count.Text.Trim()) * 5).ToString());
                else
                    TxtCash5Amt.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void TxtCoin20Count_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(TxtCoin20Count.Text.Trim()))
                    TxtCoin20Amt.Text = this.ToConvertDecimalFormatString((Convert.ToInt32(TxtCoin20Count.Text.Trim()) * 20).ToString());
                else
                    TxtCoin20Amt.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void TxtCoin10Count_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(TxtCoin10Count.Text.Trim()))
                    TxtCoin10Amt.Text = this.ToConvertDecimalFormatString((Convert.ToInt32(TxtCoin10Count.Text.Trim()) * 10).ToString());
                else
                    TxtCoin10Amt.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void TxtCoin5Count_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(TxtCoin5Count.Text.Trim()))
                    TxtCoin5Amt.Text = this.ToConvertDecimalFormatString((Convert.ToInt32(TxtCoin5Count.Text.Trim()) * 5).ToString());
                else
                    TxtCoin5Amt.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void TxtCoin2Count_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(TxtCoin2Count.Text.Trim()))
                    TxtCoin2Amt.Text = this.ToConvertDecimalFormatString((Convert.ToInt32(TxtCoin2Count.Text.Trim()) * 2).ToString());
                else
                    TxtCoin2Amt.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void TxtCoin1Count_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(TxtCoin1Count.Text.Trim()))
                    TxtCoin1Amt.Text = this.ToConvertDecimalFormatString((Convert.ToInt32(TxtCoin1Count.Text.Trim()) * 1).ToString());
                else
                    TxtCoin1Amt.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void CalculatedDenominationAmount()
        {
            try
            {

                this.TxtCashTotalAmt.Text = CommonUtils.GetTotalAmountFromStrings(TxtCash500Amt.Text, TxtCash200Amt.Text,
                                            TxtCash100Amt.Text, TxtCash50Amt.Text, TxtCash20Amt.Text,
                                            TxtCash10Amt.Text, TxtCash5Amt.Text).ToString("0.00");

                this.TxtCoinTotalAmt.Text = CommonUtils.GetTotalAmountFromStrings(TxtCoin20Amt.Text, TxtCoin10Amt.Text,
                                            TxtCoin5Amt.Text, TxtCoin2Amt.Text, TxtCoin1Amt.Text, TxtCoinPktAmt.Text).ToString("0.00");

                this.TxtTotalCashCoinOnHand.Text = (Convert.ToDecimal(this.TxtCashTotalAmt.Text) + Convert.ToDecimal(this.TxtCoinTotalAmt.Text)).ToString("0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void TxtCountCommon_Validated(object sender, EventArgs e)
        {
            try
            {
                this.CalculatedDenominationAmount();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void TxtCoinPktAmt_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                this.TxtCoinPktAmt.Text = this.ToConvertDecimalFormatString((this.TxtCoinPktAmt.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        #endregion

        private void BtnProceed_Click(object sender, EventArgs e)
        {
            try
            {
                //Cash Only Calculations

                //this.TxtCashOnlyOpeningBalance.Text = "0.00";
                this.TxtCashOnlySales.Text = this.ToConvertDecimalFormatString(this.TxtSalesCash.Text);
                this.TxtCashOnlyCustomerCreditRepayment.Text = this.ToConvertDecimalFormatString(this.TxtCustomerDebitCash.Text);
                this.TxtCashOnlyUndiyalWithdraw.Text = this.ToConvertDecimalFormatString(this.TxtUndiyalWithdraw.Text);

                this.TxtCashOnlyVendorPayment.Text = this.ToConvertDecimalFormatString(this.TxtVendorCash.Text);
                this.TxtCashOnlyExpense.Text = this.ToConvertDecimalFormatString(this.TxtExpenseCash.Text);
                this.TxtCashOnlyUndiyalDeposit.Text = this.ToConvertDecimalFormatString(this.TxtUndiyalDeposit.Text);

                this.TxtCashOnHand.Text = this.ToConvertDecimalFormatString(this.TxtCashTotalAmt.Text);
                this.TxtCoinOnHand.Text = this.ToConvertDecimalFormatString(this.TxtCoinTotalAmt.Text);

                decimal totalReceipts = CommonUtils.GetTotalAmountFromStrings(this.TxtCashOnlyOpeningBalance.Text, this.TxtCashOnlySales.Text,
                                        this.TxtCashOnlyCustomerCreditRepayment.Text, this.TxtCashOnlyUndiyalWithdraw.Text);

                decimal totalPayments = CommonUtils.GetTotalAmountFromStrings(this.TxtCashOnlyVendorPayment.Text, this.TxtCashOnlyExpense.Text,
                                        this.TxtCashOnlyUndiyalDeposit.Text);

                decimal availableCash = CommonUtils.GetTotalAmountFromStrings(this.TxtCashOnHand.Text, this.TxtCoinOnHand.Text);

                this.TxtCashOnlyTally.Text = ((totalPayments + availableCash) - totalReceipts).ToString("0.00");
                this.TxtCashOnlyClosingBalance.Text = (availableCash).ToString("0.00");

                this.TxtMismatchAmount.Text = this.TxtCashOnlyTally.Text;

                this.PnlCash.Enabled = false;
                this.PnlCoin.Enabled = false;

                this.TxtMismatchExplanation.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void BtnEditDenomEntry_Click(object sender, EventArgs e)
        {
            try
            {
                this.ClearCashRelated();

                this.PnlCash.Enabled = true;
                this.PnlCoin.Enabled = true;

                this.TxtCash500Count.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void FrmDailyAccountClosing_Activated(object sender, EventArgs e)
        {
            this.TxtCash500Count.Focus();
        }
    }

    #region "Struct"

    internal struct SalesPaymentDataTable
    {
        internal struct ColumnName
        {
            internal static string PaymentType = "PaymentType";
            internal static string Amount = "Amount";
        }
    }

    internal struct VendorPaymentDetailsDataTable
    {
        internal struct ColumnName
        {
            internal static string PaymentType = "PaymentType";
            internal static string Amount = "Amount";
        }
    }

    internal struct ExpensesDataTable
    {
        internal struct ColumnName
        {
            internal static string PaymentType = "PaymentType";
            internal static string Amount = "Amount";
        }
    }

    internal struct CustomerDebitDataTable
    {
        internal struct ColumnName
        {
            internal static string PaymentType = "PaymentType";
            internal static string Amount = "Amount";
        }
    }

    internal struct CustomerCreditDataTable
    {
        internal struct ColumnName
        {
            internal static string PaymentType = "PaymentType";
            internal static string Amount = "Amount";
        }
    }

    internal struct CustomerUndiyalDataTable
    {
        internal struct ColumnName
        {
            internal static string OpeningBalance = "OpeningBalance";
            internal static string Deposit = "Deposit";
            internal static string Withdraw = "Withdraw";
            internal static string ClosingBalance = "ClosingBalance";
        }
    }

    internal struct CashDailySummaryTable
    {
        internal struct ColumnName
        {
            internal static string TranNo = "TranNo";
            internal static string TranDate = "TranDate";
            internal static string OpeningBalance = "OpeningBalance";
            internal static string CashSales = "CashSales";
            internal static string CustomerDueReceivedCash = "CustomerDueReceivedCash";
            internal static string UndiyalCashWithdraw = "UndiyalCashWithdraw";
            internal static string VendorPaymentCash = "VendorPaymentCash";
            internal static string ExpenseCash = "ExpenseCash";
            internal static string UndiyalCashDeposit = "UndiyalCashDeposit";
            internal static string CashOnHand = "CashOnHand";
            internal static string CoinOnHand = "CoinOnHand";
            internal static string TallyAmount = "TallyAmount";
            internal static string ClosingBalance = "ClosingBalance";
            internal static string Remarks = "Remarks";
            internal static string UpdatedBy = "UpdatedBy";
            internal static string UpdatedDate = "UpdatedDate";
        }
    }

    #endregion
}
