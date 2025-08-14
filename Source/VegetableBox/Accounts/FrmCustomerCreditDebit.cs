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
    public partial class FrmCustomerCreditDebit : Form
    {

        ClsFrmCustomerCreditDebitNote clsFrmCustomerCreditDebitNote = new ClsFrmCustomerCreditDebitNote();
        public FrmCustomerCreditDebit()
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
                FrmCustomerMaster frmCustomerMaster = new FrmCustomerMaster();
                frmCustomerMaster.IsChildForm = true;
                frmCustomerMaster.WindowState = FormWindowState.Normal;
                frmCustomerMaster.ShowDialog();

                this.LoadControls();
                this.ClearEntry();
                this.ClearAndLoadView();

                this.ChkFltrApplyDate.Checked = false;
                this.ChkFltrApplyDate.Checked = true;

                this.CmbCustomerName.Focus();
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
                this.CmbCustomerName.Focus();
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
                this.clsFrmCustomerCreditDebitNote = new ClsFrmCustomerCreditDebitNote();
                this.clsFrmCustomerCreditDebitNote.GetMasterData();

                if(this.clsFrmCustomerCreditDebitNote.CustomerMaster.IsDataTableValid())
                {
                    FillControls.ComboBoxFill(this.CmbCustomerName, this.clsFrmCustomerCreditDebitNote.CustomerMaster, "Code", "Name", false, "");
                }
                
                FillControls.ComboBoxFill(this.CmbTransactionType, this.clsFrmCustomerCreditDebitNote.TransTypeMaster, "Code", "Name", false, "");
                FillControls.ComboBoxFill(this.CmbPaymentType, this.clsFrmCustomerCreditDebitNote.PaymentTypeMaster, "Code", "Name", false, "");

                FillControls.ComboBoxFill(this.CmbFilterTransactionType, this.clsFrmCustomerCreditDebitNote.TransTypeMaster, "Code", "Name", true, "All");
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
                this.CmbCustomerName.Tag = null;
                this.CmbCustomerName.SelectedIndex = -1;
                this.CmbTransactionType.SelectedIndex = -1;
                this.TxtBillNo.Text = string.Empty;
                this.DtpBillDate.Value = DateTime.Now;
                this.TxtAmount.Text = string.Empty;
                this.CmbPaymentType.SelectedIndex = -1;
                this.TxtRemarks.Text = string.Empty;

                this.ErrorProvider.Clear();
                this.BtnSave.Text = "&Save";

                if (Global.currentUserId == 1) //ADMIN
                {
                    this.BtnEdit.Enabled = true;
                }
                else
                {
                    this.BtnEdit.Enabled = false;
                }

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
                this.CmbFilterTransactionType.SelectedIndex = 0;
                this.TxtFilterCustomer.Text = string.Empty;

                this.clsFrmCustomerCreditDebitNote.View();
                this.DGView.DataSource = clsFrmCustomerCreditDebitNote.CreditDebitNoteData.Copy();
                this.ChkFltrApplyDate.Checked = true;
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
                    object resultPurchaseOnCredit = DtView.Compute("SUM([" + CustomerCreditDebitNoteTable.ColumnName.Amount + "])",
                        CustomerCreditDebitNoteTable.ColumnName.TransTypeCode + " = 'D'");
                    decimal decTotalPurchaseOnCredit = resultPurchaseOnCredit != DBNull.Value ? Math.Round(Convert.ToDecimal(resultPurchaseOnCredit), 2) : 0.00m;

                    object resultPaymentReceived = DtView.Compute("SUM([" + CustomerCreditDebitNoteTable.ColumnName.Amount + "])",
                        CustomerCreditDebitNoteTable.ColumnName.TransTypeCode + " = 'C'");
                    decimal decTotalPaymentReceived = resultPaymentReceived != DBNull.Value ? Math.Round(Convert.ToDecimal(resultPaymentReceived), 2) : 0.00m;

                    decimal decTotalPendingAmount = decTotalPurchaseOnCredit - decTotalPaymentReceived;

                    this.LblTotalCreditAmt.Text = this.ToConvertDecimalFormatString(decTotalPurchaseOnCredit.ToString());
                    this.LblTotalDebitAmt.Text = this.ToConvertDecimalFormatString(decTotalPaymentReceived.ToString());
                    this.LblTotalPendingAmt.Text = this.ToConvertDecimalFormatString(decTotalPendingAmount.ToString());
                }
                else
                {
                    this.LblTotalPendingAmt.Text = "0.00";
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
                string FilterCustomer = TxtFilterCustomer.Text;
                string FilterTransactionType = CmbFilterTransactionType.SelectedValue.ToString();

                DataTable DtView = new DataTable();
                DtView = clsFrmCustomerCreditDebitNote.CreditDebitNoteData.Copy();

                if (!string.IsNullOrEmpty(FilterTransactionType))
                {
                    if (DtView.AsEnumerable()
                    .Where(x => x.Field<string>(CustomerCreditDebitNoteTable.ColumnName.TransTypeCode) == FilterTransactionType).Count() > 0)
                    {
                        DtView = DtView.AsEnumerable()
                            .Where(x => x.Field<string>(CustomerCreditDebitNoteTable.ColumnName.TransTypeCode) == FilterTransactionType).CopyToDataTable();
                    }
                    else
                    {
                        DtView = clsFrmCustomerCreditDebitNote.CreditDebitNoteData.Clone();
                    }
                }

                if (!string.IsNullOrEmpty(FilterCustomer))
                {
                    if (ChkSearchLike.Checked)
                    {
                        if (DtView.AsEnumerable()
                            .Where(x => x.Field<string>(CustomerCreditDebitNoteTable.ColumnName.CustomerName).ToLower().Contains(FilterCustomer.ToLower())
                            ).Count() > 0)
                        {
                            DtView = DtView.AsEnumerable()
                                .Where(x => x.Field<string>(CustomerCreditDebitNoteTable.ColumnName.CustomerName).ToLower().Contains(FilterCustomer.ToLower())
                                ).CopyToDataTable();
                        }
                        else
                        {
                            DtView = clsFrmCustomerCreditDebitNote.CreditDebitNoteData.Clone();
                        }
                    }
                    else
                    {
                        if (DtView.AsEnumerable()
                            .Where(x => x.Field<string>(CustomerCreditDebitNoteTable.ColumnName.CustomerName).ToLower() == FilterCustomer.ToLower()
                            ).Count() > 0)
                        {
                            DtView = DtView.AsEnumerable()
                                .Where(x => x.Field<string>(CustomerCreditDebitNoteTable.ColumnName.CustomerName).ToLower() == FilterCustomer.ToLower()
                                ).CopyToDataTable();
                        }
                        else
                        {
                            DtView = clsFrmCustomerCreditDebitNote.CreditDebitNoteData.Clone();
                        }
                    }
                }

                if (ChkFltrApplyDate.Checked)
                {
                    if (DtView.AsEnumerable().Where(x => x.Field<DateTime>(CustomerCreditDebitNoteTable.ColumnName.UpdatedDate) >= DtpFltrFromDate.Value.Date
                    && x.Field<DateTime>(CustomerCreditDebitNoteTable.ColumnName.UpdatedDate) <= DtpFltrToDate.Value.Date.AddDays(1)).Count() > 0)
                    {
                        DtView = DtView.AsEnumerable().Where(x => x.Field<DateTime>(CustomerCreditDebitNoteTable.ColumnName.UpdatedDate) >= DtpFltrFromDate.Value.Date
                        && x.Field<DateTime>(CustomerCreditDebitNoteTable.ColumnName.UpdatedDate) <= DtpFltrToDate.Value.Date.AddDays(1)).CopyToDataTable();
                    }
                    else
                    {
                        DtView = clsFrmCustomerCreditDebitNote.CreditDebitNoteData.Clone();
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
                if (e.KeyCode == Keys.Enter && !CmbCustomerName.Focused)
                    SendKeys.Send("{TAB}");

                if (e.KeyCode == Keys.Enter && CmbCustomerName.Focused)
                    CmbTransactionType.Focus();

                if (e.Control && e.KeyCode == Keys.G)
                    DGView.Focus();

                if (e.KeyCode == Keys.F1)
                    CmbCustomerName.Focus();

                if (e.KeyCode == Keys.Escape)
                    BtnExit.PerformClick();
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
                this.CmbCustomerName.Focus();
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

                clsFrmCustomerCreditDebitNote.TranNo = this.CmbCustomerName.Tag != null ? (int)this.CmbCustomerName.Tag : 0;
                clsFrmCustomerCreditDebitNote.CustomerCode = (int)this.CmbCustomerName.SelectedValue;
                clsFrmCustomerCreditDebitNote.TransType = (string)this.CmbTransactionType.SelectedValue;
                clsFrmCustomerCreditDebitNote.BillNo = Convert.ToInt32(this.TxtBillNo.Text.Trim());
                clsFrmCustomerCreditDebitNote.BillDate = DtpBillDate.Value;
                clsFrmCustomerCreditDebitNote.Amount = Convert.ToDecimal(TxtAmount.Text);
                clsFrmCustomerCreditDebitNote.PaymentType = (string)this.CmbPaymentType.SelectedValue;
                clsFrmCustomerCreditDebitNote.Remarks = (string)this.TxtRemarks.Text.Trim();

                if (BtnSave.Text.ToUpper() == "&SAVE")
                {
                    clsFrmCustomerCreditDebitNote.Save();
                    MessageBox.Show("Saved Successfully...");
                }
                else
                {
                    clsFrmCustomerCreditDebitNote.Update();
                    MessageBox.Show("Update Successfully...");
                }

                this.ClearEntry();
                this.ClearAndLoadView();

                this.ChkFltrApplyDate.Checked = false;
                this.ChkFltrApplyDate.Checked = true;

                this.CmbCustomerName.Focus();
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


                if (this.CmbCustomerName.SelectedValue == null || this.CmbCustomerName.SelectedValue.ToString() == string.Empty)
                {
                    this.ErrorProvider.SetError(this.CmbCustomerName, "Please select the customer.");
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
                DGView.Columns[CustomerCreditDebitNoteTable.ColumnName.SNo].Visible = false;
                DGView.Columns[CustomerCreditDebitNoteTable.ColumnName.TranNo].Visible = true;
                DGView.Columns[CustomerCreditDebitNoteTable.ColumnName.CustomerCode].Visible = false;
                DGView.Columns[CustomerCreditDebitNoteTable.ColumnName.PaymentTypeCode].Visible = false;
                DGView.Columns[CustomerCreditDebitNoteTable.ColumnName.TransTypeCode].Visible = false;

                DGView.Columns[CustomerCreditDebitNoteTable.ColumnName.TranNo].HeaderText = "TranNo";
                DGView.Columns[CustomerCreditDebitNoteTable.ColumnName.CustomerName].HeaderText = "Customer Name";
                DGView.Columns[CustomerCreditDebitNoteTable.ColumnName.TransType].HeaderText = "Trans-Type";
                DGView.Columns[CustomerCreditDebitNoteTable.ColumnName.BillNo].HeaderText = "Bill No";
                DGView.Columns[CustomerCreditDebitNoteTable.ColumnName.BillDate].HeaderText = "Bill Date";
                DGView.Columns[CustomerCreditDebitNoteTable.ColumnName.Amount].HeaderText = "Amount";
                DGView.Columns[CustomerCreditDebitNoteTable.ColumnName.PaymentType].HeaderText = "Payment-Type";
                DGView.Columns[CustomerCreditDebitNoteTable.ColumnName.Remarks].HeaderText = "Remarks";
                DGView.Columns[CustomerCreditDebitNoteTable.ColumnName.UpdatedBy].HeaderText = "UpdatedBy";
                DGView.Columns[CustomerCreditDebitNoteTable.ColumnName.UpdatedDate].HeaderText = "UpdatedDate";

                foreach (DataGridViewColumn DGVColumn in DGView.Columns)
                {
                    if (DGVColumn.Name == CustomerCreditDebitNoteTable.ColumnName.CustomerName || DGVColumn.Name == CustomerCreditDebitNoteTable.ColumnName.TransType
                        || DGVColumn.Name == CustomerCreditDebitNoteTable.ColumnName.Remarks)
                        DGVColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    else
                        DGVColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

                    if (DGVColumn.Name == CustomerCreditDebitNoteTable.ColumnName.Amount)
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
                    int _TransNo = Convert.ToInt32(DGView[CustomerCreditDebitNoteTable.ColumnName.TranNo, DGSelectedRowIndex].Value);

                    if (clsFrmCustomerCreditDebitNote.CreditDebitNoteData.AsEnumerable().Where(x => x.Field<int>(CustomerCreditDebitNoteTable.ColumnName.TranNo) == _TransNo).Count() > 0)
                    {
                        DataRow? _DataRow = clsFrmCustomerCreditDebitNote.CreditDebitNoteData.AsEnumerable().Where(x => x.Field<int>(CustomerCreditDebitNoteTable.ColumnName.TranNo) == _TransNo).FirstOrDefault();

                        this.CmbCustomerName.Tag = Convert.ToInt32(_DataRow[CustomerCreditDebitNoteTable.ColumnName.TranNo]);
                        this.CmbCustomerName.SelectedValue = _DataRow[CustomerCreditDebitNoteTable.ColumnName.CustomerCode].ToString();
                        this.CmbTransactionType.SelectedValue = _DataRow[CustomerCreditDebitNoteTable.ColumnName.TransTypeCode].ToString();
                        this.TxtBillNo.Text = _DataRow[CustomerCreditDebitNoteTable.ColumnName.BillNo].ToString();
                        this.DtpBillDate.Value = Convert.ToDateTime(_DataRow[CustomerCreditDebitNoteTable.ColumnName.BillDate]);
                        this.TxtAmount.Text = _DataRow[CustomerCreditDebitNoteTable.ColumnName.Amount].ToString();
                        this.CmbPaymentType.SelectedValue = _DataRow[CustomerCreditDebitNoteTable.ColumnName.PaymentTypeCode].ToString();
                        this.TxtRemarks.Text = _DataRow[CustomerCreditDebitNoteTable.ColumnName.Remarks].ToString();

                        BtnSave.Text = "&Update";
                        CmbCustomerName.Focus();
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
                this.CmbCustomerName.Focus();
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
                if (clsFrmCustomerCreditDebitNote.CreditDebitNoteData.Rows.Count > 0)
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
                if (clsFrmCustomerCreditDebitNote.CreditDebitNoteData.Rows.Count > 0)
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
                if (this.CmbCustomerName.SelectedIndex >= 0 || this.TxtAmount.Text != string.Empty)
                    this.TxtAmount.Text = this.ToConvertDecimalFormatString(this.TxtAmount.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void CmbTransactionType_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.CmbTransactionType.SelectedIndex >= 0)
                {
                    if (this.CmbTransactionType.SelectedValue.ToString() == Account.TransTypeDebitedFromAccount)
                    {
                        this.CmbPaymentType.SelectedValue = Account.PaymentTypeOnCredit;
                        this.CmbPaymentType.Enabled = false;
                    }
                    else
                    {
                        this.CmbPaymentType.Enabled = true;
                        this.CmbPaymentType.SelectedIndex = -1;
                    }
                }
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

                if (clsFrmCustomerCreditDebitNote.CreditDebitNoteData.Rows.Count > 0)
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
                if (clsFrmCustomerCreditDebitNote.CreditDebitNoteData.Rows.Count > 0)
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
                if (clsFrmCustomerCreditDebitNote.CreditDebitNoteData.Rows.Count > 0)
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
                if (clsFrmCustomerCreditDebitNote.CreditDebitNoteData.Rows.Count > 0)
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

    internal struct CustomerCreditDebitNoteTable
    {
        internal struct ColumnName
        {
            internal static string SNo = "SNo";
            internal static string TranNo = "TranNo";
            internal static string CustomerCode = "CustomerCode";
            internal static string CustomerName = "CustomerName";
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
