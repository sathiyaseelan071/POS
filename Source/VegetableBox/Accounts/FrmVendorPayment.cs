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
    public partial class FrmVendorPayment : Form
    {

        ClsFrmVendorPayment clsFrmVendorPayment = new ClsFrmVendorPayment();
        public FrmVendorPayment()
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

        private void FrmVendorPayment_Load(object sender, EventArgs e)
        {
            try
            {
                this.LoadControls();
                this.ClearEntry();
                this.ClearAndLoadView();
                this.CmbVendorName.Focus();
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
                this.clsFrmVendorPayment = new ClsFrmVendorPayment();

                this.clsFrmVendorPayment.GetVendorBillDetails();

                this.clsFrmVendorPayment.GetMasterData();
                FillControls.ComboBoxFill(this.CmbVendorName, this.clsFrmVendorPayment.VendorMaster, "Code", "Name", false, "");
                FillControls.ComboBoxFill(this.CmbTransactionType, this.clsFrmVendorPayment.TransTypeMaster, "Code", "Name", false, "");
                FillControls.ComboBoxFill(this.CmbPaymentType, this.clsFrmVendorPayment.PaymentTypeMaster, "Code", "Name", false, "");

                FillControls.ComboBoxFill(this.CmbFilterTransactionType, this.clsFrmVendorPayment.TransTypeMaster, "Code", "Name", true, "All");
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
                this.DgvVendorInvoiceDetails.DataSource = null;

                this.CmbVendorName.Tag = null; //TranNo
                this.CmbVendorName.SelectedIndex = -1;
                this.TxtBillNo.Tag = null; //RefTranNo
                this.TxtBillNo.Text = string.Empty;

                this.DgvVendorInvoiceDetails.DataSource = null;
                this.DgvVendorInvoiceDetails.ClearSelection();
                this.DtpBillDate.Value = DateTime.Now;
                this.TxtTotalBillAmount.Text = string.Empty;
                this.TxtPaidTillNow.Text = string.Empty;
                this.TxtPendingAmount.Text = string.Empty;
                this.TxtCurrentPayment.Text = string.Empty;
                this.CmbPaymentType.SelectedIndex = -1;
                this.TxtRemarks.Text = string.Empty;

                this.CmbTransactionType.Enabled = false;
                this.CmbTransactionType.SelectedIndex = 0;

                this.CmbVendorName.Enabled = true;
                this.DgvVendorInvoiceDetails.Enabled = true;

                this.ErrorProvider.Clear();
                this.BtnSave.Text = "&Save";

                if(Global.currentUserId == 1) //ADMIN
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
                this.TxtFilterVendorSearch.Text = string.Empty;

                this.DGView.DataSource = null;
                this.DGView.ClearSelection();

                clsFrmVendorPayment.View();
                DGView.DataSource = clsFrmVendorPayment.VendorPaymentData.Copy();

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
                    object resultTotalPaymentDone = DtView.Compute("SUM([" + VendorPaymentTable.ColumnName.AmountPaid + "])", string.Empty);
                    decimal decTotalPaymentDone = resultTotalPaymentDone != DBNull.Value ? Math.Round(Convert.ToDecimal(resultTotalPaymentDone), 2) : 0.00m;

                    this.LblTotalPayment.Text = this.ToConvertDecimalFormatString(decTotalPaymentDone.ToString());
                }
                else
                {
                    this.LblTotalPayment.Text = "0.00";
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
                string FilterVendor = TxtFilterVendorSearch.Text;
                string FilterTransactionType = CmbFilterTransactionType.SelectedValue.ToString();

                DataTable DtView = new DataTable();
                DtView = clsFrmVendorPayment.VendorPaymentData.Copy();

                if (!string.IsNullOrEmpty(FilterTransactionType))
                {
                    if (DtView.AsEnumerable()
                    .Where(x => x.Field<string>(VendorPaymentTable.ColumnName.TransTypeCode) == FilterTransactionType).Count() > 0)
                    {
                        DtView = DtView.AsEnumerable()
                            .Where(x => x.Field<string>(VendorPaymentTable.ColumnName.TransTypeCode) == FilterTransactionType).CopyToDataTable();
                    }
                    else
                    {
                        DtView = clsFrmVendorPayment.VendorPaymentData.Clone();
                    }
                }

                if (!string.IsNullOrEmpty(FilterVendor))
                {
                    if (ChkSearchLike.Checked)
                    {
                        if (DtView.AsEnumerable()
                            .Where(x => x.Field<string>(VendorPaymentTable.ColumnName.VendorName).ToLower().Contains(FilterVendor.ToLower())
                            ).Count() > 0)
                        {
                            DtView = DtView.AsEnumerable()
                                .Where(x => x.Field<string>(VendorPaymentTable.ColumnName.VendorName).ToLower().Contains(FilterVendor.ToLower())
                                ).CopyToDataTable();
                        }
                        else
                        {
                            DtView = clsFrmVendorPayment.VendorPaymentData.Clone();
                        }
                    }
                    else
                    {
                        if (DtView.AsEnumerable()
                            .Where(x => x.Field<string>(VendorPaymentTable.ColumnName.VendorName).ToLower() == FilterVendor.ToLower()
                            ).Count() > 0)
                        {
                            DtView = DtView.AsEnumerable()
                                .Where(x => x.Field<string>(VendorPaymentTable.ColumnName.VendorName).ToLower() == FilterVendor.ToLower()
                                ).CopyToDataTable();
                        }
                        else
                        {
                            DtView = clsFrmVendorPayment.VendorPaymentData.Clone();
                        }
                    }
                }

                if (ChkFltrApplyDate.Checked)
                {
                    if (DtView.AsEnumerable().Where(x => x.Field<DateTime>(VendorPaymentTable.ColumnName.UpdatedDate) >= DtpFltrFromDate.Value.Date
                    && x.Field<DateTime>(VendorPaymentTable.ColumnName.UpdatedDate) <= DtpFltrToDate.Value.Date.AddDays(1)).Count() > 0)
                    {
                        DtView = DtView.AsEnumerable().Where(x => x.Field<DateTime>(VendorPaymentTable.ColumnName.UpdatedDate) >= DtpFltrFromDate.Value.Date
                        && x.Field<DateTime>(VendorPaymentTable.ColumnName.UpdatedDate) <= DtpFltrToDate.Value.Date.AddDays(1)).CopyToDataTable();
                    }
                    else
                    {
                        DtView = clsFrmVendorPayment.VendorPaymentData.Clone();
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

        private void FrmVendorPayment_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter && !DgvVendorInvoiceDetails.Focused)
                    SendKeys.Send("{TAB}");

                if (e.KeyCode == Keys.Enter && DgvVendorInvoiceDetails.Focused)
                    TxtCurrentPayment.Focus();

                if (e.Control && e.KeyCode == Keys.G)
                    DGView.Focus();

                if (e.KeyCode == Keys.F1)
                    CmbVendorName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void FrmVendorPayment_Activated(object sender, EventArgs e)
        {
            try
            {
                this.CmbVendorName.Focus();
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

                clsFrmVendorPayment.VendorCode = (int)this.CmbVendorName.SelectedValue;
                clsFrmVendorPayment.BillNo = this.TxtBillNo.Text.Trim();
                clsFrmVendorPayment.BillDate = DtpBillDate.Value;
                clsFrmVendorPayment.Amount = Convert.ToDecimal(TxtCurrentPayment.Text);
                clsFrmVendorPayment.PaymentType = (string)this.CmbPaymentType.SelectedValue;
                clsFrmVendorPayment.TransType = (string)this.CmbTransactionType.SelectedValue;
                clsFrmVendorPayment.Remarks = (string)this.TxtRemarks.Text.Trim();
                clsFrmVendorPayment.RefTranNo = this.TxtBillNo.Tag != null ? Convert.ToInt32(this.TxtBillNo.Tag) : 0;
                clsFrmVendorPayment.TranNo = this.CmbVendorName.Tag != null ? Convert.ToInt32(this.CmbVendorName.Tag) : 0;

                if (BtnSave.Text.ToUpper() == "&SAVE")
                {
                    clsFrmVendorPayment.Save();
                    MessageBox.Show("Saved Successfully...");
                }
                else
                {
                    clsFrmVendorPayment.Update();
                    MessageBox.Show("Update Successfully...");
                }

                this.LoadControls();
                this.ClearEntry();
                this.ClearAndLoadView();
                this.CmbVendorName.Focus();
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

                if (this.CmbVendorName.SelectedValue == null || this.CmbVendorName.SelectedValue.ToString() == string.Empty)
                {
                    this.ErrorProvider.SetError(this.CmbVendorName, "Please select the vendor.");
                    IsValid = false;
                }

                if (string.IsNullOrEmpty(this.TxtBillNo.Text.Trim()))
                {
                    this.ErrorProvider.SetError(this.TxtBillNo, "Please enter the bill no.");
                    IsValid = false;
                }

                if (string.IsNullOrEmpty(this.TxtCurrentPayment.Text.Trim()))
                {
                    this.ErrorProvider.SetError(this.TxtCurrentPayment, "Please enter the amount.");
                    IsValid = false;
                }
                else if (Convert.ToDecimal(this.TxtCurrentPayment.Text.Trim()) <= 0)
                {
                    this.ErrorProvider.SetError(this.TxtCurrentPayment, "Amount must be greater than 0.");
                    IsValid = false;
                }
                else if (BtnSave.Text.ToUpper() != "&UPDATE" && Convert.ToDecimal(this.TxtCurrentPayment.Text.Trim()) > Convert.ToDecimal(this.TxtPendingAmount.Text.Trim()))
                {
                    this.ErrorProvider.SetError(this.TxtCurrentPayment, "Current payment amount must be less than or equal to pending payment.");
                    IsValid = false;
                }

                if (this.CmbPaymentType.SelectedValue == null || this.CmbPaymentType.SelectedValue.ToString() == string.Empty)
                {
                    this.ErrorProvider.SetError(this.CmbPaymentType, "Please select the payment type.");
                    IsValid = false;
                }
                else if (this.CmbPaymentType.SelectedValue != null && (this.CmbPaymentType.SelectedValue.ToString() == Account.PaymentTypeOnCredit || this.CmbPaymentType.SelectedValue.ToString() == Account.PaymentTypeUpi))
                {
                    this.ErrorProvider.SetError(this.CmbPaymentType, "On Credit and UPI payments are not allowed for vendor bill payments.");
                    IsValid = false;
                }

                if (this.CmbTransactionType.SelectedValue == null || this.CmbTransactionType.SelectedValue.ToString() == string.Empty)
                {
                    this.ErrorProvider.SetError(this.CmbTransactionType, "Please select the transaction type.");
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
                DGView.Columns[VendorPaymentTable.ColumnName.SNo].Visible = false;
                DGView.Columns[VendorPaymentTable.ColumnName.TranNo].Visible = true;
                DGView.Columns[VendorPaymentTable.ColumnName.VendorCode].Visible = false;
                DGView.Columns[VendorPaymentTable.ColumnName.PaymentTypeCode].Visible = false;
                DGView.Columns[VendorPaymentTable.ColumnName.TransTypeCode].Visible = false;
                DGView.Columns[VendorPaymentTable.ColumnName.RefTranNo].Visible = false;

                DGView.Columns[VendorPaymentTable.ColumnName.TranNo].HeaderText = "TranNo";
                DGView.Columns[VendorPaymentTable.ColumnName.VendorName].HeaderText = "Vendor Name";
                DGView.Columns[VendorPaymentTable.ColumnName.TransType].HeaderText = "Trans-Type";
                DGView.Columns[VendorPaymentTable.ColumnName.BillNo].HeaderText = "Bill No";
                DGView.Columns[VendorPaymentTable.ColumnName.BillDate].HeaderText = "Bill Date";
                DGView.Columns[VendorPaymentTable.ColumnName.AmountPaid].HeaderText = "Amount Paid";
                DGView.Columns[VendorPaymentTable.ColumnName.PaymentType].HeaderText = "Payment-Type";
                DGView.Columns[VendorPaymentTable.ColumnName.Remarks].HeaderText = "Remarks";
                DGView.Columns[VendorPaymentTable.ColumnName.UpdatedBy].HeaderText = "UpdatedBy";
                DGView.Columns[VendorPaymentTable.ColumnName.UpdatedDate].HeaderText = "UpdatedDate";

                foreach (DataGridViewColumn DGVColumn in DGView.Columns)
                {
                    if (DGVColumn.Name == VendorPaymentTable.ColumnName.VendorName || DGVColumn.Name == VendorPaymentTable.ColumnName.TransType)
                        DGVColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    else if (DGVColumn.Name == VendorPaymentTable.ColumnName.AmountPaid)
                        DGVColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    else
                        DGVColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

                    if (DGVColumn.Name == VendorPaymentTable.ColumnName.AmountPaid)
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
                    this.ClearEntry();
                    this.ErrorProvider.Clear();

                    int _TransNo = Convert.ToInt32(DGView[VendorPaymentTable.ColumnName.TranNo, DGSelectedRowIndex].Value);

                    if (clsFrmVendorPayment.VendorPaymentData.AsEnumerable().Where(x => x.Field<int>(VendorPaymentTable.ColumnName.TranNo) == _TransNo).Count() > 0)
                    {
                        DataRow? _DataRow = clsFrmVendorPayment.VendorPaymentData.AsEnumerable().Where(x => x.Field<int>(VendorPaymentTable.ColumnName.TranNo) == _TransNo).FirstOrDefault();

                        this.CmbVendorName.Tag = Convert.ToInt32(_DataRow[VendorPaymentTable.ColumnName.TranNo]);
                        this.CmbVendorName.SelectedValue = _DataRow[VendorPaymentTable.ColumnName.VendorCode].ToString();
                        
                        this.TxtBillNo.Text = _DataRow[VendorPaymentTable.ColumnName.BillNo].ToString();
                        this.TxtBillNo.Tag = _DataRow[VendorPaymentTable.ColumnName.RefTranNo].ToString();
                        this.DtpBillDate.Value = Convert.ToDateTime(_DataRow[VendorPaymentTable.ColumnName.BillDate]);
                        this.TxtCurrentPayment.Text = _DataRow[VendorPaymentTable.ColumnName.AmountPaid].ToString();
                        this.CmbPaymentType.SelectedValue = _DataRow[VendorPaymentTable.ColumnName.PaymentTypeCode].ToString();
                        this.CmbTransactionType.SelectedValue = _DataRow[VendorPaymentTable.ColumnName.TransTypeCode].ToString();
                        this.TxtRemarks.Text = _DataRow[VendorPaymentTable.ColumnName.Remarks].ToString();

                        this.CmbVendorName.Enabled = false;
                        this.DgvVendorInvoiceDetails.Enabled = false;

                        this.BtnSave.Text = "&Update";
                        this.TxtCurrentPayment.Focus();
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
                this.CmbVendorName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void TxtFilterVendor_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (clsFrmVendorPayment.VendorPaymentData.Rows.Count > 0)
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
                if (clsFrmVendorPayment.VendorPaymentData.Rows.Count > 0)
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
                if (this.CmbVendorName.SelectedIndex >= 0 || this.TxtCurrentPayment.Text != string.Empty)
                    this.TxtCurrentPayment.Text = this.ToConvertDecimalFormatString(this.TxtCurrentPayment.Text);
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

                if (clsFrmVendorPayment.VendorPaymentData.Rows.Count > 0)
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
                if (clsFrmVendorPayment.VendorPaymentData.Rows.Count > 0)
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
                if (clsFrmVendorPayment.VendorPaymentData.Rows.Count > 0)
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
                if (clsFrmVendorPayment.VendorPaymentData.Rows.Count > 0)
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

        private void DoFillVendorBillSearchGridControl(int? FilterProduct)
        {
            try
            {
                DataTable _DtSearch = new DataTable();
                if (FilterProduct != null && FilterProduct >= 0)
                {
                    if (clsFrmVendorPayment.VendorBillDetailsData != null && clsFrmVendorPayment.VendorBillDetailsData.Rows.Count > 0)
                    {
                        _DtSearch.Columns.Add(VendorBillDetailsData.ColumnName.TranNo, typeof(int));
                        _DtSearch.Columns.Add(VendorBillDetailsData.ColumnName.VendorCode, typeof(int));
                        _DtSearch.Columns.Add(VendorBillDetailsData.ColumnName.BillNo, typeof(string));
                        _DtSearch.Columns.Add(VendorBillDetailsData.ColumnName.BillDate, typeof(DateTime));
                        _DtSearch.Columns.Add(VendorBillDetailsData.ColumnName.BillAmount, typeof(decimal));
                        _DtSearch.Columns.Add(VendorBillDetailsData.ColumnName.PaidTillNow, typeof(decimal));
                        _DtSearch.Columns.Add(VendorBillDetailsData.ColumnName.PendingAmount, typeof(decimal));

                        if (clsFrmVendorPayment.VendorBillDetailsData.AsEnumerable().Where(x => x.Field<int>(VendorBillDetailsData.ColumnName.VendorCode) == FilterProduct).Count() > 0)
                        {
                            _DtSearch = clsFrmVendorPayment.VendorBillDetailsData.AsEnumerable()
                                .Where(x => x.Field<int>(VendorBillDetailsData.ColumnName.VendorCode) == FilterProduct)
                                .OrderBy(x => x.Field<DateTime>(VendorBillDetailsData.ColumnName.BillDate))
                                .Select(g =>
                                {
                                    var row = _DtSearch.NewRow();
                                    row[VendorBillDetailsData.ColumnName.TranNo] = g.Field<int>(VendorBillDetailsData.ColumnName.TranNo);
                                    row[VendorBillDetailsData.ColumnName.VendorCode] = g.Field<int>(VendorBillDetailsData.ColumnName.VendorCode);
                                    row[VendorBillDetailsData.ColumnName.BillNo] = g.Field<string>(VendorBillDetailsData.ColumnName.BillNo);
                                    row[VendorBillDetailsData.ColumnName.BillDate] = g.Field<DateTime>(VendorBillDetailsData.ColumnName.BillDate);
                                    row[VendorBillDetailsData.ColumnName.BillAmount] = g.Field<decimal>(VendorBillDetailsData.ColumnName.BillAmount);
                                    row[VendorBillDetailsData.ColumnName.PaidTillNow] = g.Field<decimal>(VendorBillDetailsData.ColumnName.PaidTillNow);
                                    row[VendorBillDetailsData.ColumnName.PendingAmount] = g.Field<decimal>(VendorBillDetailsData.ColumnName.PendingAmount);
                                    return row;
                                }
                                ).CopyToDataTable();
                        }

                        DgvVendorInvoiceDetails.DataSource = _DtSearch;

                        DgvVendorInvoiceDetails.Columns[VendorBillDetailsData.ColumnName.TranNo].Visible = false;
                        DgvVendorInvoiceDetails.Columns[VendorBillDetailsData.ColumnName.VendorCode].Visible = false;

                        DgvVendorInvoiceDetails.Columns[VendorBillDetailsData.ColumnName.BillNo].HeaderText = "Bill No";
                        DgvVendorInvoiceDetails.Columns[VendorBillDetailsData.ColumnName.BillDate].HeaderText = "Bill Date";
                        DgvVendorInvoiceDetails.Columns[VendorBillDetailsData.ColumnName.BillAmount].HeaderText = "Bill Amount";
                        DgvVendorInvoiceDetails.Columns[VendorBillDetailsData.ColumnName.PaidTillNow].HeaderText = "Paid Till Now";
                        DgvVendorInvoiceDetails.Columns[VendorBillDetailsData.ColumnName.PendingAmount].HeaderText = "Pending Amount";

                        foreach (DataGridViewColumn DGVColumn in DgvVendorInvoiceDetails.Columns)
                        {
                            //if (DGVColumn.Name == VendorBillDetailsData.ColumnName.BillAmount)
                            //    DGVColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                            //else

                            DGVColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                            if (DGVColumn.Name == VendorBillDetailsData.ColumnName.BillAmount || DGVColumn.Name == VendorBillDetailsData.ColumnName.PaidTillNow
                                || DGVColumn.Name == VendorBillDetailsData.ColumnName.PendingAmount)
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

        private void ClearLoadedBillDetails()
        {
            try
            {
                this.TxtBillNo.Tag = string.Empty;
                this.TxtBillNo.Text = string.Empty;
                this.DtpBillDate.Value = DateTime.Now;
                this.TxtTotalBillAmount.Text = string.Empty;
                this.TxtPaidTillNow.Text = string.Empty;
                this.TxtPendingAmount.Text = string.Empty;
            }
            catch
            {
                throw;
            }
        }

        private void LoadCurrentBillSelection()
        {
            try
            {
                this.ClearLoadedBillDetails();

                if (DgvVendorInvoiceDetails.Rows.Count > 0)
                {
                    this.TxtBillNo.Tag = (int)DgvVendorInvoiceDetails.CurrentRow.Cells[VendorBillDetailsData.ColumnName.TranNo].Value;
                    this.TxtBillNo.Text = Convert.ToString(DgvVendorInvoiceDetails.CurrentRow.Cells[VendorBillDetailsData.ColumnName.BillNo].Value);
                    this.DtpBillDate.Value = (DateTime)DgvVendorInvoiceDetails.CurrentRow.Cells[VendorBillDetailsData.ColumnName.BillDate].Value;
                    this.TxtTotalBillAmount.Text = Convert.ToString(DgvVendorInvoiceDetails.CurrentRow.Cells[VendorBillDetailsData.ColumnName.BillAmount].Value);
                    this.TxtPaidTillNow.Text = Convert.ToString(DgvVendorInvoiceDetails.CurrentRow.Cells[VendorBillDetailsData.ColumnName.PaidTillNow].Value);
                    this.TxtPendingAmount.Text = Convert.ToString(DgvVendorInvoiceDetails.CurrentRow.Cells[VendorBillDetailsData.ColumnName.PendingAmount].Value);
                }
            }
            catch
            {
                throw;
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

        private void DgvVendorInvoiceDetails_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void DgvVendorInvoiceDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DgvVendorInvoiceDetails.Rows.Count > 0)
                {
                    this.ErrorProvider.Clear();
                    this.LoadCurrentBillSelection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }
    }

    #region "Struct"

    internal struct VendorPaymentTable
    {
        internal struct ColumnName
        {
            internal static string SNo = "SNo";
            internal static string TranNo = "TranNo";
            internal static string VendorCode = "VendorCode";
            internal static string VendorName = "VendorName";
            internal static string TransType = "TransType";
            internal static string BillNo = "BillNo";
            internal static string BillDate = "BillDate";
            internal static string AmountPaid = "AmountPaid";
            internal static string PaymentType = "PaymentType";
            internal static string Remarks = "Remarks";
            internal static string RefTranNo = "RefTranNo";
            internal static string UpdatedBy = "UpdatedBy";
            internal static string UpdatedDate = "UpdatedDate";
            internal static string TransTypeCode = "TransTypeCode";
            internal static string PaymentTypeCode = "PaymentTypeCode";
        }
    }

    internal struct VendorBillDetailsData
    {
        internal struct ColumnName
        {
            internal static string TranNo = "TranNo";
            internal static string VendorCode = "VendorCode";
            internal static string BillNo = "BillNo";
            internal static string BillDate = "BillDate";
            internal static string BillAmount = "BillAmount";
            internal static string PaidTillNow = "PaidTillNow";
            internal static string PendingAmount = "PendingAmount";
        }
    }

    #endregion
}
