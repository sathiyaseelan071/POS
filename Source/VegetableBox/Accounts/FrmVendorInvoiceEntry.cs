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
    public partial class FrmVendorInvoiceEntry : Form
    {

        ClsFrmVendorInvoiceEntry clsFrmVendorInvoiceEntry = new ClsFrmVendorInvoiceEntry();
        public FrmVendorInvoiceEntry()
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

        private void BtnAddVendorMaster_Click(object sender, EventArgs e)
        {
            try
            {
                FrmVendorMaster frmVendorMaster = new FrmVendorMaster();
                frmVendorMaster.IsChildForm = true;
                frmVendorMaster.WindowState = FormWindowState.Normal;
                frmVendorMaster.ShowDialog();
                this.LoadControls();
                this.CmbVendorName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void FrmVendorInvoiceEntry_Load(object sender, EventArgs e)
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
                this.clsFrmVendorInvoiceEntry = new ClsFrmVendorInvoiceEntry();
                this.clsFrmVendorInvoiceEntry.GetMasterData();

                FillControls.ComboBoxFill(this.CmbVendorName, this.clsFrmVendorInvoiceEntry.VendorMaster, "Code", "Name", false, "");
                FillControls.ComboBoxFill(this.CmbIsItemMissing, this.clsFrmVendorInvoiceEntry.YesNoMaster, "Code", "Name", false, "");

                FillControls.ComboBoxFill(this.CmbBillChecked, this.clsFrmVendorInvoiceEntry.YesNoMaster, "Code", "Name", false, "");
                FillControls.ComboBoxFill(this.CmbBillCheckedBy, this.clsFrmVendorInvoiceEntry.UserMaster, "Code", "Name", false, "");

                FillControls.ComboBoxFill(this.CmbPurchaseEntryStatus, this.clsFrmVendorInvoiceEntry.ProgressStatusMaster, "Code", "Name", false, "");
                FillControls.ComboBoxFill(this.CmbPurchaseEntryBy, this.clsFrmVendorInvoiceEntry.UserMaster, "Code", "Name", false, "");

                FillControls.ComboBoxFill(this.CmbIsMissingItemReceived, this.clsFrmVendorInvoiceEntry.YesNoMaster, "Code", "Name", false, "");
                FillControls.ComboBoxFill(this.CmbMissingItemReceivedBy, this.clsFrmVendorInvoiceEntry.UserMaster, "Code", "Name", false, "");

                FillControls.ComboBoxFill(this.CmbFilterIsItemMissing, this.clsFrmVendorInvoiceEntry.YesNoMaster, "Code", "Name", true, "All");
                FillControls.ComboBoxFill(this.CmbFilterBillChecked, this.clsFrmVendorInvoiceEntry.YesNoMaster, "Code", "Name", true, "All");                
                FillControls.ComboBoxFill(this.CmbFilterPurchaseEntryStatus, this.clsFrmVendorInvoiceEntry.ProgressStatusMaster, "Code", "Name", true, "All");
                FillControls.ComboBoxFill(this.CmbFilterIsMissingItemReceived, this.clsFrmVendorInvoiceEntry.YesNoMaster, "Code", "Name", true, "All");                
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
                this.CmbVendorName.Tag = null;
                this.CmbVendorName.SelectedIndex = -1;
                this.TxtBillNo.Text = string.Empty;
                this.DtpBillDate.Value = DateTime.Now;
                this.TxtBillAmount.Text = string.Empty;
                this.CmbBillChecked.SelectedIndex = -1;
                this.CmbBillCheckedBy.SelectedIndex = -1;
                this.CmbPurchaseEntryStatus.SelectedIndex = -1;
                this.CmbPurchaseEntryBy.SelectedIndex = -1;
                this.CmbIsMissingItemReceived.SelectedIndex = -1;
                this.CmbMissingItemReceivedBy.SelectedIndex = -1;

                this.CmbIsItemMissing.SelectedIndex = -1;
                this.TxtMissingItemDetails.Text = string.Empty;

                this.TxtRemarks.Text = string.Empty;

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
                this.TxtFilterVendor.Text = string.Empty;

                this.CmbFilterIsItemMissing.SelectedIndex = 0;
                this.CmbFilterBillChecked.SelectedIndex = 0;
                this.CmbFilterPurchaseEntryStatus.SelectedIndex = 0;
                this.CmbFilterIsMissingItemReceived.SelectedIndex = 0;
                this.ChkSearchLike.Checked = true;
                this.ChkFltrApplyDate.Checked = false;
                this.DtpFltrFromDate.Value = DateTime.Now.Date;
                this.DtpFltrToDate.Value = DateTime.Now.Date.AddDays(1).AddSeconds(-1); // To include the whole day

                clsFrmVendorInvoiceEntry.View();
                DGView.DataSource = clsFrmVendorInvoiceEntry.VendorBillData.Copy();
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
                    object resultTotalExpenses = DtView.Compute("SUM([" + VendorBillDetailsTable.ColumnName.AmountPaid + "])",
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
                string FilterExpense = TxtFilterVendor.Text;
                string FilterTransactionType = CmbFilterIsItemMissing.SelectedValue.ToString();

                DataTable DtView = new DataTable();
                DtView = clsFrmVendorInvoiceEntry.VendorBillData.Copy();

                if (!string.IsNullOrEmpty(FilterTransactionType))
                {
                    //if (DtView.AsEnumerable()
                    //.Where(x => x.Field<string>(VendorBillDetailsTable.ColumnName.TransTypeCode) == FilterTransactionType).Count() > 0)
                    //{
                    //    DtView = DtView.AsEnumerable()
                    //        .Where(x => x.Field<string>(VendorBillDetailsTable.ColumnName.TransTypeCode) == FilterTransactionType).CopyToDataTable();
                    //}
                    //else
                    //{
                    //    DtView = clsFrmVendorInvoiceEntry.VendorBillData.Clone();
                    //}
                }

                if (!string.IsNullOrEmpty(FilterExpense))
                {
                    if (ChkSearchLike.Checked)
                    {
                        //if (DtView.AsEnumerable().Where(x => x.Field<string>(VendorBillDetailsTable.ColumnName.ExpenseName).ToLower().Contains(FilterExpense.ToLower())
                        //).Count() > 0)
                        //{
                        //    DtView = DtView.AsEnumerable()
                        //        .Where(x => x.Field<string>(VendorBillDetailsTable.ColumnName.ExpenseName).ToLower().Contains(FilterExpense.ToLower())
                        //        ).CopyToDataTable();
                        //}
                        //else
                        //{
                        //    DtView = clsFrmVendorInvoiceEntry.VendorBillData.Clone();
                        //}
                    }
                    else
                    {
                        //if (DtView.AsEnumerable().Where(x => x.Field<string>(VendorBillDetailsTable.ColumnName.ExpenseName).ToLower() == FilterExpense.ToLower()
                        //).Count() > 0)
                        //{
                        //    DtView = DtView.AsEnumerable()
                        //        .Where(x => x.Field<string>(VendorBillDetailsTable.ColumnName.ExpenseName).ToLower() == FilterExpense.ToLower()
                        //        ).CopyToDataTable();
                        //}
                        //else
                        //{
                        //    DtView = clsFrmVendorInvoiceEntry.VendorBillData.Clone();
                        //}
                    }
                }

                if (ChkFltrApplyDate.Checked)
                {
                    if (DtView.AsEnumerable().Where(x => x.Field<DateTime>(VendorBillDetailsTable.ColumnName.UpdatedDate) >= DtpFltrFromDate.Value.Date
                    && x.Field<DateTime>(VendorBillDetailsTable.ColumnName.UpdatedDate) <= DtpFltrToDate.Value.Date.AddDays(1)).Count() > 0)
                    {
                        DtView = DtView.AsEnumerable().Where(x => x.Field<DateTime>(VendorBillDetailsTable.ColumnName.UpdatedDate) >= DtpFltrFromDate.Value.Date
                        && x.Field<DateTime>(VendorBillDetailsTable.ColumnName.UpdatedDate) <= DtpFltrToDate.Value.Date.AddDays(1)).CopyToDataTable();
                    }
                    else
                    {
                        DtView = clsFrmVendorInvoiceEntry.VendorBillData.Clone();
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

        private void FrmVendorInvoiceEntry_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter && !CmbVendorName.Focused)
                    SendKeys.Send("{TAB}");

                if (e.KeyCode == Keys.Enter && CmbVendorName.Focused)
                    TxtBillNo.Focus();

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

        private void FrmVendorInvoiceEntry_Activated(object sender, EventArgs e)
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
                //this.Validation();

                clsFrmVendorInvoiceEntry.TranNo = this.CmbVendorName.Tag != null ? (int)this.CmbVendorName.Tag : 0;                
                clsFrmVendorInvoiceEntry.VendorCode = (int)this.CmbVendorName.SelectedValue;
                clsFrmVendorInvoiceEntry.BillNo = Convert.ToString(this.TxtBillNo.Text.Trim());
                clsFrmVendorInvoiceEntry.BillDate = DtpBillDate.Value;
                clsFrmVendorInvoiceEntry.BillAmount = Convert.ToDecimal(this.TxtBillAmount.Text);
                clsFrmVendorInvoiceEntry.ItemsCount = Convert.ToInt32(this.TxtItemsCount.Text);
                clsFrmVendorInvoiceEntry.IsItemMissing = (string)this.CmbIsItemMissing.SelectedValue;
                clsFrmVendorInvoiceEntry.MissingItemDetails = (string)this.TxtMissingItemDetails.Text.Trim();

                clsFrmVendorInvoiceEntry.BillChecked = (string)this.CmbBillChecked.SelectedValue;
                if(clsFrmVendorInvoiceEntry.BillChecked == YesNoValues.Yes)//Yes
                    clsFrmVendorInvoiceEntry.BillCheckedBy = (int)this.CmbBillCheckedBy.SelectedValue;
                else
                    clsFrmVendorInvoiceEntry.BillCheckedBy = null;

                clsFrmVendorInvoiceEntry.PurchaseEntryStatus = (string)this.CmbPurchaseEntryStatus.SelectedValue;
                if(clsFrmVendorInvoiceEntry.PurchaseEntryStatus == ProgressStatusValues.Completed 
                    || clsFrmVendorInvoiceEntry.PurchaseEntryStatus == ProgressStatusValues.InProgress)
                    clsFrmVendorInvoiceEntry.PurchaseEntryBy = (int)this.CmbPurchaseEntryBy.SelectedValue;
                else
                    clsFrmVendorInvoiceEntry.PurchaseEntryBy = null;

                clsFrmVendorInvoiceEntry.IsMissingItemReceived = (string)this.CmbIsMissingItemReceived.SelectedValue;
                if(clsFrmVendorInvoiceEntry.IsMissingItemReceived == YesNoValues.Yes) //Yes
                    clsFrmVendorInvoiceEntry.MissingItemReceivedBy = (int)this.CmbMissingItemReceivedBy.SelectedValue;
                else
                    clsFrmVendorInvoiceEntry.MissingItemReceivedBy = null;

                clsFrmVendorInvoiceEntry.Remarks = (string)this.TxtRemarks.Text.Trim();
                clsFrmVendorInvoiceEntry.AmountPaid = 0.00m;


                if (BtnSave.Text.ToUpper() == "&SAVE")
                {
                    clsFrmVendorInvoiceEntry.Save();
                    MessageBox.Show("Saved Successfully...");
                }
                else
                {
                    clsFrmVendorInvoiceEntry.Update();
                    MessageBox.Show("Update Successfully...");
                }

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
                    this.ErrorProvider.SetError(this.CmbVendorName, "Please select the expense.");
                    IsValid = false;
                }

                if (this.CmbBillChecked.SelectedValue == null || this.CmbBillChecked.SelectedValue.ToString() == string.Empty)
                {
                    this.ErrorProvider.SetError(this.CmbBillChecked, "Please select the transaction type.");
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

                if (string.IsNullOrEmpty(this.TxtBillAmount.Text.Trim()))
                {
                    this.ErrorProvider.SetError(this.TxtBillAmount, "Please enter the amount.");
                    IsValid = false;
                }
                else if (Convert.ToDecimal(this.TxtBillAmount.Text.Trim()) <= 0)
                {
                    this.ErrorProvider.SetError(this.TxtBillAmount, "Amount must be greater than 0.");
                    IsValid = false;
                }

                if (this.CmbIsItemMissing.SelectedValue == null || this.CmbIsItemMissing.SelectedValue.ToString() == string.Empty)
                {
                    this.ErrorProvider.SetError(this.CmbIsItemMissing, "Please select the payment type...");
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
                DGView.Columns[VendorBillDetailsTable.ColumnName.SNo].Visible = false;
                DGView.Columns[VendorBillDetailsTable.ColumnName.TranNo].Visible = true;
                DGView.Columns[VendorBillDetailsTable.ColumnName.VendorCode].Visible = false;

                DGView.Columns[VendorBillDetailsTable.ColumnName.IsItemMissingCode].Visible = false;
                DGView.Columns[VendorBillDetailsTable.ColumnName.BillCheckedCode].Visible = false;
                DGView.Columns[VendorBillDetailsTable.ColumnName.PurchaseEntryStatusCode].Visible = false;

                DGView.Columns[VendorBillDetailsTable.ColumnName.BillCheckedByCode].Visible = false;
                DGView.Columns[VendorBillDetailsTable.ColumnName.PurchaseEntryByCode].Visible = false;
                DGView.Columns[VendorBillDetailsTable.ColumnName.MissingItemReceivedByCode].Visible = false;
                DGView.Columns[VendorBillDetailsTable.ColumnName.UpdatedByCode].Visible = false;


                DGView.Columns[VendorBillDetailsTable.ColumnName.TranNo].HeaderText = "TranNo";
                DGView.Columns[VendorBillDetailsTable.ColumnName.VendorName].HeaderText = "Vendor Name";
                DGView.Columns[VendorBillDetailsTable.ColumnName.BillNo].HeaderText = "Bill No";
                DGView.Columns[VendorBillDetailsTable.ColumnName.BillDate].HeaderText = "Bill Date";
                DGView.Columns[VendorBillDetailsTable.ColumnName.BillAmount].HeaderText = "Bill Amount";
                DGView.Columns[VendorBillDetailsTable.ColumnName.ItemsCount].HeaderText = "Items Count";
                DGView.Columns[VendorBillDetailsTable.ColumnName.IsItemMissing].HeaderText = "Is Item Missing";
                DGView.Columns[VendorBillDetailsTable.ColumnName.MissingItemDetails].HeaderText = "Missing Item Details";
                DGView.Columns[VendorBillDetailsTable.ColumnName.BillChecked].HeaderText = "Bill Checked";
                DGView.Columns[VendorBillDetailsTable.ColumnName.BillCheckedBy].HeaderText = "Bill CheckedBy";

                DGView.Columns[VendorBillDetailsTable.ColumnName.PurchaseEntryStatus].HeaderText = "Purchase Entry Status";
                DGView.Columns[VendorBillDetailsTable.ColumnName.PurchaseEntryBy].HeaderText = "Purchase EntryBy";
                DGView.Columns[VendorBillDetailsTable.ColumnName.Remarks].HeaderText = "Remarks";
                DGView.Columns[VendorBillDetailsTable.ColumnName.IsMissingItemReceived].HeaderText = "Is Missing Item Received";
                DGView.Columns[VendorBillDetailsTable.ColumnName.MissingItemReceivedBy].HeaderText = "Missing Item ReceivedBy";
                DGView.Columns[VendorBillDetailsTable.ColumnName.UpdatedBy].HeaderText = "UpdatedBy";
                DGView.Columns[VendorBillDetailsTable.ColumnName.UpdatedDate].HeaderText = "UpdatedDate";
                DGView.Columns[VendorBillDetailsTable.ColumnName.AmountPaid].HeaderText = "Amount Paid";

                DGView.Columns[VendorBillDetailsTable.ColumnName.Remarks].HeaderText = "Remarks";
                DGView.Columns[VendorBillDetailsTable.ColumnName.UpdatedBy].HeaderText = "UpdatedBy";
                DGView.Columns[VendorBillDetailsTable.ColumnName.UpdatedDate].HeaderText = "UpdatedDate";

                foreach (DataGridViewColumn DGVColumn in DGView.Columns)
                {
                    if (DGVColumn.Name == VendorBillDetailsTable.ColumnName.VendorName)
                        DGVColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; //Fill
                    else
                        DGVColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                    if (DGVColumn.Name == VendorBillDetailsTable.ColumnName.AmountPaid)
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
                    int _TransNo = Convert.ToInt32(DGView[VendorBillDetailsTable.ColumnName.TranNo, DGSelectedRowIndex].Value);

                    if (clsFrmVendorInvoiceEntry.VendorBillData.AsEnumerable().Where(x => x.Field<int>(VendorBillDetailsTable.ColumnName.TranNo) == _TransNo).Count() > 0)
                    {
                        DataRow? _DataRow = clsFrmVendorInvoiceEntry.VendorBillData.AsEnumerable().Where(x => x.Field<int>(VendorBillDetailsTable.ColumnName.TranNo) == _TransNo).FirstOrDefault();

                        //this.CmbExpenseName.Tag = Convert.ToInt32(_DataRow[VendorBillDetailsTable.ColumnName.TranNo]);
                        //this.CmbExpenseName.SelectedValue = _DataRow[VendorBillDetailsTable.ColumnName.ExpenseCode].ToString();
                        //this.CmbTransactionType.SelectedValue = _DataRow[VendorBillDetailsTable.ColumnName.TransTypeCode].ToString();
                        //this.TxtBillNo.Text = _DataRow[VendorBillDetailsTable.ColumnName.BillNo].ToString();
                        //this.DtpBillDate.Value = Convert.ToDateTime(_DataRow[VendorBillDetailsTable.ColumnName.BillDate]);
                        //this.TxtAmount.Text = _DataRow[VendorBillDetailsTable.ColumnName.Amount].ToString();
                        //this.CmbPaymentType.SelectedValue = _DataRow[VendorBillDetailsTable.ColumnName.PaymentTypeCode].ToString();
                        //this.TxtRemarks.Text = _DataRow[VendorBillDetailsTable.ColumnName.Remarks].ToString();

                        BtnSave.Text = "&Update";
                        CmbVendorName.Focus();
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

        private void TxtFilterCustomer_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (clsFrmVendorInvoiceEntry.VendorBillData.Rows.Count > 0)
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
                if (clsFrmVendorInvoiceEntry.VendorBillData.Rows.Count > 0)
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
                if (this.CmbVendorName.SelectedIndex >= 0 || this.TxtBillAmount.Text != string.Empty)
                    this.TxtBillAmount.Text = this.ToConvertDecimalFormatString(this.TxtBillAmount.Text);
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

                if (clsFrmVendorInvoiceEntry.VendorBillData.Rows.Count > 0)
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
                if (clsFrmVendorInvoiceEntry.VendorBillData.Rows.Count > 0)
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
                if (clsFrmVendorInvoiceEntry.VendorBillData.Rows.Count > 0)
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
                if (clsFrmVendorInvoiceEntry.VendorBillData.Rows.Count > 0)
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

    internal struct YesNoValues
    {
        internal const string Yes = "Y";
        internal const string No = "N";
    }

    internal struct ProgressStatusValues
    {
        internal const string NotStarted = "N";
        internal const string InProgress = "P";
        internal const string Completed = "C";        
    }

    internal struct VendorBillDetailsTable
    {
        internal struct ColumnName
        {
            internal static string SNo = "SNo";
            internal static string TranNo = "TranNo";
            internal static string VendorCode = "VendorCode";
            internal static string VendorName = "VendorName";
            internal static string BillNo = "BillNo";
            internal static string BillDate = "BillDate";
            internal static string BillAmount = "BillAmount";
            internal static string ItemsCount = "ItemsCount";
            internal static string IsItemMissing = "IsItemMissing";
            internal static string MissingItemDetails = "MissingItemDetails";
            internal static string BillChecked = "BillChecked";
            internal static string BillCheckedBy = "BillCheckedBy";
            internal static string PurchaseEntryStatus = "PurchaseEntryStatus";
            internal static string PurchaseEntryBy = "PurchaseEntryBy";
            internal static string IsMissingItemReceived = "IsMissingItemReceived";
            internal static string MissingItemReceivedBy = "MissingItemReceivedBy";
            internal static string Remarks = "Remarks";
            internal static string AmountPaid = "AmountPaid";
            internal static string UpdatedBy = "UpdatedBy";
            internal static string UpdatedDate = "UpdatedDate";

            internal static string IsItemMissingCode = "IsItemMissingCode";
            internal static string BillCheckedCode = "BillCheckedCode";
            internal static string PurchaseEntryStatusCode = "PurchaseEntryStatusCode";
            internal static string BillCheckedByCode = "BillCheckedByCode";
            internal static string PurchaseEntryByCode = "PurchaseEntryByCode";
            internal static string MissingItemReceivedByCode = "MissingItemReceivedByCode";
            internal static string UpdatedByCode = "UpdatedByCode";

        }
    }

    #endregion
}
