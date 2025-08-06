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
    public partial class FrmUndiyalCreditDebit : Form
    {

        ClsFrmUndiyalCreditDebit clsFrmUndiyalCreditDebit = new ClsFrmUndiyalCreditDebit();
        public FrmUndiyalCreditDebit()
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

        private void FrmUndiyalCreditDebit_Load(object sender, EventArgs e)
        {
            try
            {
                this.LoadControls();
                this.ClearEntry();
                this.ClearAndLoadView();
                this.CmbTransactionType.Focus();
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
                this.clsFrmUndiyalCreditDebit = new ClsFrmUndiyalCreditDebit();
                this.clsFrmUndiyalCreditDebit.GetMasterData();

                FillControls.ComboBoxFill(this.CmbTransactionType, this.clsFrmUndiyalCreditDebit.TransTypeMaster, "Code", "Name", false, "");
                FillControls.ComboBoxFill(this.CmbPaymentType, this.clsFrmUndiyalCreditDebit.PaymentTypeMaster, "Code", "Name", false, "");

                FillControls.ComboBoxFill(this.CmbFilterTransactionType, this.clsFrmUndiyalCreditDebit.TransTypeMaster, "Code", "Name", true, "All");
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
                this.CmbTransactionType.Tag = null;
                this.CmbTransactionType.SelectedIndex = -1;
                this.TxtAmount.Text = string.Empty;
                this.CmbPaymentType.SelectedIndex = -1;
                this.TxtRemarks.Text = string.Empty;
                this.CmbPaymentType.SelectedIndex = 0;

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
                this.ChkFltrApplyDate.Checked = false;
                this.CmbFilterTransactionType.SelectedIndex = 0;

                clsFrmUndiyalCreditDebit.View();
                DGView.DataSource = clsFrmUndiyalCreditDebit.UndiyalDebitNoteData.Copy();

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
                    object resultUndiyalDeposit = DtView.Compute("SUM([" + UndiyalCreditDebitNoteTable.ColumnName.Amount + "])",
                        UndiyalCreditDebitNoteTable.ColumnName.TransTypeCode + " = 'C'");
                    decimal decTotalUndiyalDeposit = resultUndiyalDeposit != DBNull.Value ? Math.Round(Convert.ToDecimal(resultUndiyalDeposit), 2) : 0.00m;

                    object resultUndiyalWithdraw = DtView.Compute("SUM([" + UndiyalCreditDebitNoteTable.ColumnName.Amount + "])",
                        UndiyalCreditDebitNoteTable.ColumnName.TransTypeCode + " = 'D'");
                    decimal decTotalUndiyalWithdraw = resultUndiyalWithdraw != DBNull.Value ? Math.Round(Convert.ToDecimal(resultUndiyalWithdraw), 2) : 0.00m;

                    decimal decTotalAvailableAmount = decTotalUndiyalDeposit - decTotalUndiyalWithdraw;

                    this.LblTotalDepositAmt.Text = this.ToConvertDecimalFormatString(decTotalUndiyalDeposit.ToString());
                    this.LblTotalWithdrawAmt.Text = this.ToConvertDecimalFormatString(decTotalUndiyalWithdraw.ToString());
                    this.LblTotalAvailableAmt.Text = this.ToConvertDecimalFormatString(decTotalAvailableAmount.ToString());
                }
                else
                {
                    this.LblTotalAvailableAmt.Text = "0.00";
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
                string FilterTransactionType = CmbFilterTransactionType.SelectedValue.ToString();

                DataTable DtView = new DataTable();
                DtView = clsFrmUndiyalCreditDebit.UndiyalDebitNoteData.Copy();

                if (!string.IsNullOrEmpty(FilterTransactionType))
                {
                    if (DtView.AsEnumerable()
                    .Where(x => x.Field<string>(UndiyalCreditDebitNoteTable.ColumnName.TransTypeCode) == FilterTransactionType).Count() > 0)
                    {
                        DtView = DtView.AsEnumerable()
                            .Where(x => x.Field<string>(UndiyalCreditDebitNoteTable.ColumnName.TransTypeCode) == FilterTransactionType).CopyToDataTable();
                    }
                    else
                    {
                        DtView = clsFrmUndiyalCreditDebit.UndiyalDebitNoteData.Clone();
                    }
                }

                if (ChkFltrApplyDate.Checked)
                {
                    if (DtView.AsEnumerable().Where(x => x.Field<DateTime>(UndiyalCreditDebitNoteTable.ColumnName.UpdatedDate) >= DtpFltrFromDate.Value.Date
                    && x.Field<DateTime>(UndiyalCreditDebitNoteTable.ColumnName.UpdatedDate) <= DtpFltrToDate.Value.Date.AddDays(1)).Count() > 0)
                    {
                        DtView = DtView.AsEnumerable().Where(x => x.Field<DateTime>(UndiyalCreditDebitNoteTable.ColumnName.UpdatedDate) >= DtpFltrFromDate.Value.Date
                        && x.Field<DateTime>(UndiyalCreditDebitNoteTable.ColumnName.UpdatedDate) <= DtpFltrToDate.Value.Date.AddDays(1)).CopyToDataTable();
                    }
                    else
                    {
                        DtView = clsFrmUndiyalCreditDebit.UndiyalDebitNoteData.Clone();
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

        private void FrmUndiyalCreditDebit_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                    SendKeys.Send("{TAB}");

                if (e.Control && e.KeyCode == Keys.G)
                    DGView.Focus();

                if (e.KeyCode == Keys.F1)
                    CmbTransactionType.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void FrmUndiyalCreditDebit_Activated(object sender, EventArgs e)
        {
            try
            {
                //this.CmbTransactionType.Focus();
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

                clsFrmUndiyalCreditDebit.TranNo = this.CmbTransactionType.Tag != null ? (int)this.CmbTransactionType.Tag : 0;
                clsFrmUndiyalCreditDebit.TransType = (string)this.CmbTransactionType.SelectedValue;
                clsFrmUndiyalCreditDebit.Amount = Convert.ToDecimal(TxtAmount.Text);
                clsFrmUndiyalCreditDebit.PaymentType = (string)this.CmbPaymentType.SelectedValue;
                clsFrmUndiyalCreditDebit.Remarks = (string)this.TxtRemarks.Text.Trim();

                if (BtnSave.Text.ToUpper() == "&SAVE")
                {
                    clsFrmUndiyalCreditDebit.Save();
                    MessageBox.Show("Saved Successfully...");
                }
                else
                {
                    clsFrmUndiyalCreditDebit.Update();
                    MessageBox.Show("Update Successfully...");
                }

                this.ClearEntry();
                this.ClearAndLoadView();
                this.CmbTransactionType.Focus();
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

                if (this.CmbTransactionType.SelectedValue == null || this.CmbTransactionType.SelectedValue.ToString() == string.Empty)
                {
                    this.ErrorProvider.SetError(this.CmbTransactionType, "Please select the transaction type.");
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
                DGView.Columns[UndiyalCreditDebitNoteTable.ColumnName.SNo].Visible = false;
                DGView.Columns[UndiyalCreditDebitNoteTable.ColumnName.PaymentTypeCode].Visible = false;
                DGView.Columns[UndiyalCreditDebitNoteTable.ColumnName.TransTypeCode].Visible = false;

                DGView.Columns[UndiyalCreditDebitNoteTable.ColumnName.TranNo].HeaderText = "Tran No";
                DGView.Columns[UndiyalCreditDebitNoteTable.ColumnName.TranDate].HeaderText = "Tran Date";
                DGView.Columns[UndiyalCreditDebitNoteTable.ColumnName.TransType].HeaderText = "Trans-Type";
                DGView.Columns[UndiyalCreditDebitNoteTable.ColumnName.Amount].HeaderText = "Amount";
                DGView.Columns[UndiyalCreditDebitNoteTable.ColumnName.PaymentType].HeaderText = "Payment-Type";
                DGView.Columns[UndiyalCreditDebitNoteTable.ColumnName.Remarks].HeaderText = "Remarks";
                DGView.Columns[UndiyalCreditDebitNoteTable.ColumnName.UpdatedBy].HeaderText = "UpdatedBy";
                DGView.Columns[UndiyalCreditDebitNoteTable.ColumnName.UpdatedDate].HeaderText = "UpdatedDate";

                foreach (DataGridViewColumn DGVColumn in DGView.Columns)
                {
                    if (DGVColumn.Name == UndiyalCreditDebitNoteTable.ColumnName.TransType || DGVColumn.Name == UndiyalCreditDebitNoteTable.ColumnName.Remarks)
                        DGVColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    else
                        DGVColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                    if (DGVColumn.Name == UndiyalCreditDebitNoteTable.ColumnName.Amount)
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
                    this.ErrorProvider.Clear();

                    int _TransNo = Convert.ToInt32(DGView[UndiyalCreditDebitNoteTable.ColumnName.TranNo, DGSelectedRowIndex].Value);

                    if (clsFrmUndiyalCreditDebit.UndiyalDebitNoteData.AsEnumerable().Where(x => x.Field<int>(UndiyalCreditDebitNoteTable.ColumnName.TranNo) == _TransNo).Count() > 0)
                    {
                        DataRow? _DataRow = clsFrmUndiyalCreditDebit.UndiyalDebitNoteData.AsEnumerable().Where(x => x.Field<int>(UndiyalCreditDebitNoteTable.ColumnName.TranNo) == _TransNo).FirstOrDefault();

                        this.CmbTransactionType.Tag = Convert.ToInt32(_DataRow[UndiyalCreditDebitNoteTable.ColumnName.TranNo]);
                        this.CmbTransactionType.SelectedValue = _DataRow[UndiyalCreditDebitNoteTable.ColumnName.TransTypeCode].ToString();
                        this.TxtAmount.Text = _DataRow[UndiyalCreditDebitNoteTable.ColumnName.Amount].ToString();
                        this.CmbPaymentType.SelectedValue = _DataRow[UndiyalCreditDebitNoteTable.ColumnName.PaymentTypeCode].ToString();
                        this.TxtRemarks.Text = _DataRow[UndiyalCreditDebitNoteTable.ColumnName.Remarks].ToString();

                        BtnSave.Text = "&Update";
                        CmbTransactionType.Focus();
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
                this.CmbTransactionType.Focus();
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
                if (clsFrmUndiyalCreditDebit.UndiyalDebitNoteData.Rows.Count > 0)
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
                if (this.TxtAmount.Text != string.Empty)
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

                if (clsFrmUndiyalCreditDebit.UndiyalDebitNoteData.Rows.Count > 0)
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
                if (clsFrmUndiyalCreditDebit.UndiyalDebitNoteData.Rows.Count > 0)
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
                if (clsFrmUndiyalCreditDebit.UndiyalDebitNoteData.Rows.Count > 0)
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

    internal struct UndiyalCreditDebitNoteTable
    {
        internal struct ColumnName
        {
            internal static string SNo = "SNo";
            internal static string TranNo = "TranNo";
            internal static string TranDate = "TranDate";
            internal static string TransType = "TransType";
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
