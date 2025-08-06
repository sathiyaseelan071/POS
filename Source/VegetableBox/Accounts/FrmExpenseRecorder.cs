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
    public partial class FrmExpenseRecorder : Form
    {

        ClsFrmExpenseRecorder clsFrmExpenseRecorder = new ClsFrmExpenseRecorder();
        public FrmExpenseRecorder()
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

        private void BtnAddCreditDebitMaster_Click(object sender, EventArgs e)
        {
            try
            {
                FrmExpenseMaster frmFrmExpenseMaster = new FrmExpenseMaster();
                frmFrmExpenseMaster.IsChildForm = true;
                frmFrmExpenseMaster.WindowState = FormWindowState.Normal;
                frmFrmExpenseMaster.ShowDialog();
                this.LoadControls();
                this.ClearEntry();
                this.ClearAndLoadView();
                this.CmbExpenseName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void FrmCustomerCreditDebit_Load(object sender, EventArgs e)
        {
            try
            {
                this.LoadControls();
                this.ClearEntry();
                this.ClearAndLoadView();
                this.CmbExpenseName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void LoadControls()
        {
            try
            {
                this.clsFrmExpenseRecorder = new ClsFrmExpenseRecorder();
                this.clsFrmExpenseRecorder.GetMasterData();

                FillControls.ComboBoxFill(this.CmbExpenseName, this.clsFrmExpenseRecorder.ExpenseMaster, "Code", "Name", false, "");
                FillControls.ComboBoxFill(this.CmbTransactionType, this.clsFrmExpenseRecorder.TransTypeMaster, "Code", "Name", false, "");
                FillControls.ComboBoxFill(this.CmbPaymentType, this.clsFrmExpenseRecorder.PaymentTypeMaster, "Code", "Name", false, "");

                FillControls.ComboBoxFill(this.CmbFilterTransactionType, this.clsFrmExpenseRecorder.TransTypeMaster, "Code", "Name", true, "All");
            }
            catch
            {
                throw;
            }
        }

        private void ClearEntry()
        {
            try
            {
                this.CmbExpenseName.Tag = null;
                this.CmbExpenseName.SelectedIndex = -1;
                this.TxtBillNo.Text = string.Empty;
                this.DtpBillDate.Value = DateTime.Now;
                this.TxtAmount.Text = string.Empty;
                this.CmbPaymentType.SelectedIndex = -1;
                this.TxtRemarks.Text = string.Empty;

                this.CmbTransactionType.SelectedIndex = 1;
                this.CmbTransactionType.Enabled = false;

                this.ErrorProvider.Clear();
                this.BtnSave.Text = "&Save";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void ClearAndLoadView()
        {
            try
            {
                this.ChkFltrApplyDate.Checked = false;
                this.CmbFilterTransactionType.SelectedIndex = 0;
                this.CmbFilterTransactionType.Enabled = false;

                this.TxtFilterExpense.Text = string.Empty;

                clsFrmExpenseRecorder.View();
                DGView.DataSource = clsFrmExpenseRecorder.ExpensesData.Copy();
                this.SetGridStyle();
                this.ToCalcTotalAmount();
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
                DataTable DtView = new DataTable();
                DtView = (DataTable)DGView.DataSource;

                if (DtView != null && DtView.Rows.Count > 0)
                {
                    object resultTotalExpenses = DtView.Compute("SUM([" + ExpensesTable.ColumnName.Amount + "])",
                        string.Empty);
                    decimal decTotalExpenses = resultTotalExpenses != DBNull.Value ? Math.Round(Convert.ToDecimal(resultTotalExpenses), 2) : 0.00m;

                    this.LblTotalExpenses.Text = this.ToConvertDecimalFormatString(decTotalExpenses.ToString());
                }
                else
                {
                    this.LblTotalExpenses.Text = "0.00";
                }
            }
            catch
            {
                throw;
            }
        }

        private void FilterGridData()
        {
            try
            {
                string FilterExpense = TxtFilterExpense.Text;
                string FilterTransactionType = CmbFilterTransactionType.SelectedValue.ToString();

                DataTable DtView = new DataTable();
                DtView = clsFrmExpenseRecorder.ExpensesData.Copy();

                if (!string.IsNullOrEmpty(FilterTransactionType))
                {
                    if (DtView.AsEnumerable()
                    .Where(x => x.Field<string>(ExpensesTable.ColumnName.TransTypeCode) == FilterTransactionType).Count() > 0)
                    {
                        DtView = DtView.AsEnumerable()
                            .Where(x => x.Field<string>(ExpensesTable.ColumnName.TransTypeCode) == FilterTransactionType).CopyToDataTable();
                    }
                    else
                    {
                        DtView = clsFrmExpenseRecorder.ExpensesData.Clone();
                    }
                }

                if (!string.IsNullOrEmpty(FilterExpense))
                {
                    if (ChkSearchLike.Checked)
                    {
                        if (DtView.AsEnumerable().Where(x => x.Field<string>(ExpensesTable.ColumnName.ExpenseName).ToLower().Contains(FilterExpense.ToLower())
                        ).Count() > 0)
                        {
                            DtView = DtView.AsEnumerable()
                                .Where(x => x.Field<string>(ExpensesTable.ColumnName.ExpenseName).ToLower().Contains(FilterExpense.ToLower())
                                ).CopyToDataTable();
                        }
                        else
                        {
                            DtView = clsFrmExpenseRecorder.ExpensesData.Clone();
                        }
                    }
                    else
                    {
                        if (DtView.AsEnumerable().Where(x => x.Field<string>(ExpensesTable.ColumnName.ExpenseName).ToLower() == FilterExpense.ToLower()
                        ).Count() > 0)
                        {
                            DtView = DtView.AsEnumerable()
                                .Where(x => x.Field<string>(ExpensesTable.ColumnName.ExpenseName).ToLower() == FilterExpense.ToLower()
                                ).CopyToDataTable();
                        }
                        else
                        {
                            DtView = clsFrmExpenseRecorder.ExpensesData.Clone();
                        }
                    }
                }

                if (ChkFltrApplyDate.Checked)
                {
                    if (DtView.AsEnumerable().Where(x => x.Field<DateTime>(ExpensesTable.ColumnName.UpdatedDate) >= DtpFltrFromDate.Value.Date
                    && x.Field<DateTime>(ExpensesTable.ColumnName.UpdatedDate) <= DtpFltrToDate.Value.Date.AddDays(1)).Count() > 0)
                    {
                        DtView = DtView.AsEnumerable().Where(x => x.Field<DateTime>(ExpensesTable.ColumnName.UpdatedDate) >= DtpFltrFromDate.Value.Date
                        && x.Field<DateTime>(ExpensesTable.ColumnName.UpdatedDate) <= DtpFltrToDate.Value.Date.AddDays(1)).CopyToDataTable();
                    }
                    else
                    {
                        DtView = clsFrmExpenseRecorder.ExpensesData.Clone();
                    }
                }

                DGView.DataSource = DtView;
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

        private void FrmCustomerCreditDebit_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter && !CmbExpenseName.Focused)
                    SendKeys.Send("{TAB}");

                if (e.KeyCode == Keys.Enter && CmbExpenseName.Focused)
                    TxtBillNo.Focus();

                if (e.Control && e.KeyCode == Keys.G)
                    DGView.Focus();

                if (e.KeyCode == Keys.F1)
                    CmbExpenseName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void FrmCustomerCreditDebit_Activated(object sender, EventArgs e)
        {
            try
            {
                this.CmbExpenseName.Focus();
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

                clsFrmExpenseRecorder.TranNo = this.CmbExpenseName.Tag != null ? (int)this.CmbExpenseName.Tag : 0;
                clsFrmExpenseRecorder.ExpenseCode = (int)this.CmbExpenseName.SelectedValue;
                clsFrmExpenseRecorder.TransType = (string)this.CmbTransactionType.SelectedValue;
                clsFrmExpenseRecorder.BillNo = Convert.ToInt32(this.TxtBillNo.Text.Trim());
                clsFrmExpenseRecorder.BillDate = DtpBillDate.Value;
                clsFrmExpenseRecorder.Amount = Convert.ToDecimal(TxtAmount.Text);
                clsFrmExpenseRecorder.PaymentType = (string)this.CmbPaymentType.SelectedValue;
                clsFrmExpenseRecorder.Remarks = (string)this.TxtRemarks.Text.Trim();

                if (BtnSave.Text.ToUpper() == "&SAVE")
                {
                    clsFrmExpenseRecorder.Save();
                    MessageBox.Show("Saved Successfully...");
                }
                else
                {
                    clsFrmExpenseRecorder.Update();
                    MessageBox.Show("Update Successfully...");
                }

                this.ClearEntry();
                this.ClearAndLoadView();
                this.CmbExpenseName.Focus();
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


                if (this.CmbExpenseName.SelectedValue == null || this.CmbExpenseName.SelectedValue.ToString() == string.Empty)
                {
                    this.ErrorProvider.SetError(this.CmbExpenseName, "Please select the expense.");
                    IsValid = false;
                }

                if (this.CmbTransactionType.SelectedValue == null || this.CmbTransactionType.SelectedValue.ToString() == string.Empty)
                {
                    this.ErrorProvider.SetError(this.CmbTransactionType, "Please select the transaction type.");
                    IsValid = false;
                }

                if (string.IsNullOrEmpty(this.TxtBillNo.Text.Trim()))
                {
                    this.ErrorProvider.SetError(this.TxtBillNo, "Please enter the bill no.");
                    IsValid = false;
                }
                else if (Convert.ToInt64(this.TxtBillNo.Text.Trim()) <= 0)
                {
                    this.ErrorProvider.SetError(this.TxtBillNo, "Bill-No must be greater than 0.");
                    IsValid = false;
                }

                if (string.IsNullOrEmpty(this.TxtAmount.Text.Trim()))
                {
                    this.ErrorProvider.SetError(this.TxtAmount, "Please enter the amount.");
                    IsValid = false;
                }
                else if (Convert.ToDecimal(this.TxtAmount.Text.Trim()) <= 0)
                {
                    this.ErrorProvider.SetError(this.TxtAmount, "Amount must be greater than 0.");
                    IsValid = false;
                }

                if (this.CmbPaymentType.SelectedValue == null || this.CmbPaymentType.SelectedValue.ToString() == string.Empty)
                {
                    this.ErrorProvider.SetError(this.CmbPaymentType, "Please select the payment type...");
                    IsValid = false;
                }
                else if (this.CmbPaymentType.SelectedValue.ToString() == Account.PaymentTypeOnCredit || this.CmbPaymentType.SelectedValue.ToString() == Account.PaymentTypeUpi)
                {
                    this.ErrorProvider.SetError(this.CmbPaymentType, "Payment type 'Credit' or 'UPI' is not allowed");
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
                DGView.Columns[ExpensesTable.ColumnName.SNo].Visible = false;
                DGView.Columns[ExpensesTable.ColumnName.TranNo].Visible = true;
                DGView.Columns[ExpensesTable.ColumnName.ExpenseCode].Visible = false;
                DGView.Columns[ExpensesTable.ColumnName.PaymentTypeCode].Visible = false;
                DGView.Columns[ExpensesTable.ColumnName.TransTypeCode].Visible = false;

                DGView.Columns[ExpensesTable.ColumnName.TranNo].HeaderText = "TranNo";
                DGView.Columns[ExpensesTable.ColumnName.ExpenseName].HeaderText = "Expense Name";
                DGView.Columns[ExpensesTable.ColumnName.TransType].HeaderText = "Trans-Type";
                DGView.Columns[ExpensesTable.ColumnName.BillNo].HeaderText = "Bill No";
                DGView.Columns[ExpensesTable.ColumnName.BillDate].HeaderText = "Bill Date";
                DGView.Columns[ExpensesTable.ColumnName.Amount].HeaderText = "Amount";
                DGView.Columns[ExpensesTable.ColumnName.PaymentType].HeaderText = "Payment-Type";
                DGView.Columns[ExpensesTable.ColumnName.Remarks].HeaderText = "Remarks";
                DGView.Columns[ExpensesTable.ColumnName.UpdatedBy].HeaderText = "UpdatedBy";
                DGView.Columns[ExpensesTable.ColumnName.UpdatedDate].HeaderText = "UpdatedDate";

                foreach (DataGridViewColumn DGVColumn in DGView.Columns)
                {
                    if (DGVColumn.Name == ExpensesTable.ColumnName.ExpenseName || DGVColumn.Name == ExpensesTable.ColumnName.Remarks)
                        DGVColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    else
                        DGVColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

                    if (DGVColumn.Name == ExpensesTable.ColumnName.Amount)
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

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGView.SelectedRows.Count > 0)
                {
                    int _TransNo = Convert.ToInt32(DGView[ExpensesTable.ColumnName.TranNo, DGSelectedRowIndex].Value);

                    if (clsFrmExpenseRecorder.ExpensesData.AsEnumerable().Where(x => x.Field<int>(ExpensesTable.ColumnName.TranNo) == _TransNo).Count() > 0)
                    {
                        DataRow? _DataRow = clsFrmExpenseRecorder.ExpensesData.AsEnumerable().Where(x => x.Field<int>(ExpensesTable.ColumnName.TranNo) == _TransNo).FirstOrDefault();

                        this.CmbExpenseName.Tag = Convert.ToInt32(_DataRow[ExpensesTable.ColumnName.TranNo]);
                        this.CmbExpenseName.SelectedValue = _DataRow[ExpensesTable.ColumnName.ExpenseCode].ToString();
                        this.CmbTransactionType.SelectedValue = _DataRow[ExpensesTable.ColumnName.TransTypeCode].ToString();
                        this.TxtBillNo.Text = _DataRow[ExpensesTable.ColumnName.BillNo].ToString();
                        this.DtpBillDate.Value = Convert.ToDateTime(_DataRow[ExpensesTable.ColumnName.BillDate]);
                        this.TxtAmount.Text = _DataRow[ExpensesTable.ColumnName.Amount].ToString();
                        this.CmbPaymentType.SelectedValue = _DataRow[ExpensesTable.ColumnName.PaymentTypeCode].ToString();
                        this.TxtRemarks.Text = _DataRow[ExpensesTable.ColumnName.Remarks].ToString();

                        BtnSave.Text = "&Update";
                        CmbExpenseName.Focus();
                    }
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
                this.ClearEntry();
                this.CmbExpenseName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void TxtFilterCustomer_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (clsFrmExpenseRecorder.ExpensesData.Rows.Count > 0)
                {
                    this.FilterGridData();
                    this.SetGridStyle();
                    this.ToCalcTotalAmount();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void CmbFilterTransactionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (clsFrmExpenseRecorder.ExpensesData.Rows.Count > 0)
                {
                    this.FilterGridData();
                    this.SetGridStyle();
                    this.ToCalcTotalAmount();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void TxtAmount_Validated(object sender, EventArgs e)
        {
            try
            {
                if (this.CmbExpenseName.SelectedIndex >= 0 || this.TxtAmount.Text != string.Empty)
                    this.TxtAmount.Text = this.ToConvertDecimalFormatString(this.TxtAmount.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void ChkFltrApplyDate_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.ChkFltrApplyDate.Checked)
                {
                    this.DtpFltrFromDate.Enabled = true;
                    this.DtpFltrToDate.Enabled = true;
                    this.LblFltrFromDate.Enabled = true;
                    this.LblFltrToDate.Enabled = true;
                }
                else
                {
                    this.DtpFltrFromDate.Enabled = false;
                    this.DtpFltrToDate.Enabled = false;
                    this.LblFltrFromDate.Enabled = false;
                    this.LblFltrToDate.Enabled = false;
                }

                if (clsFrmExpenseRecorder.ExpensesData.Rows.Count > 0)
                {
                    this.FilterGridData();
                    this.SetGridStyle();
                    this.ToCalcTotalAmount();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void DtpFltrFromDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (clsFrmExpenseRecorder.ExpensesData.Rows.Count > 0)
                {
                    this.FilterGridData();
                    this.SetGridStyle();
                    this.ToCalcTotalAmount();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void DtpFltrToDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (clsFrmExpenseRecorder.ExpensesData.Rows.Count > 0)
                {
                    this.FilterGridData();
                    this.SetGridStyle();
                    this.ToCalcTotalAmount();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void ChkSearchLike_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (clsFrmExpenseRecorder.ExpensesData.Rows.Count > 0)
                {
                    this.FilterGridData();
                    this.SetGridStyle();
                    this.ToCalcTotalAmount();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }
    }

    #region "Struct"

    internal struct ExpensesTable
    {
        internal struct ColumnName
        {
            internal static string SNo = "SNo";
            internal static string TranNo = "TranNo";
            internal static string ExpenseCode = "ExpenseCode";
            internal static string ExpenseName = "ExpenseName";
            internal static string TransType = "TransType";
            internal static string BillNo = "BillNo";
            internal static string BillDate = "BillDate";
            internal static string Amount = "Amount";
            internal static string PaymentType = "PaymentType";
            internal static string Remarks = "Remarks";
            internal static string UpdatedBy = "UpdatedBy";
            internal static string UpdatedDate = "UpdatedDate";

            internal static string TransTypeCode = "TransTypeCode";
            internal static string PaymentTypeCode = "PaymentTypeCode";
        }
    }

    #endregion
}
