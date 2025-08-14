using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using System.Numerics;

namespace VegetableBox
{
    public partial class FrmCustomerMaster : Form
    {
        ClsFrmCustomerMaster clsFrmCustomerMaster = new ClsFrmCustomerMaster();
        public Boolean IsChildForm = false;

        public FrmCustomerMaster()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsChildForm)
                {
                    this.DialogResult = DialogResult.OK;
                    this.IsChildForm = false;
                }
                else
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

        private void FrmCustomerMaster_Load(object sender, EventArgs e)
        {
            try
            {
                if (IsChildForm)
                {
                    this.TlpForm.BackColor = Color.PaleVioletRed;
                }
                else
                {
                    this.TlpForm.BackColor = Color.WhiteSmoke;
                }

                this.LoadControls();
                this.ClearEntry();
                this.ClearView();
                this.TxtCustomerName.Focus();
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
                this.clsFrmCustomerMaster = new ClsFrmCustomerMaster();
                this.clsFrmCustomerMaster.GetMasterData();

                FillControls.ComboBoxFill(this.CmbActive, this.clsFrmCustomerMaster.YesNoMaster, "Code", "Name", false, "");
                FillControls.ComboBoxFill(this.CmbFilterActive, this.clsFrmCustomerMaster.YesNoMaster, "Code", "Name", true, "All");
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
                this.TxtCustomerName.Tag = null;
                this.TxtCustomerName.Text = string.Empty;
                this.TxtAddress.Text = string.Empty;
                this.TxtMobileNo.Text = string.Empty;
                this.CmbActive.SelectedIndex = 0;
                this.ErrorProvider.Clear();
                this.BtnSave.Text = "&Save";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void ClearView()
        {
            try
            {
                this.CmbFilterActive.SelectedIndex = 0;
                this.TxtFilterVendor.Text = string.Empty;

                clsFrmCustomerMaster.View();
                DGView.DataSource = clsFrmCustomerMaster.CustomerMaster.Copy();
                this.SetGridStyle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void FilterGridData()
        {
            try
            {
                string FilterProduct = TxtFilterVendor.Text;
                string? FilterActiveStatus = Convert.ToString(CmbFilterActive.SelectedValue);

                DataTable DtView = new DataTable();
                DtView = clsFrmCustomerMaster.CustomerMaster.Copy();

                if (!string.IsNullOrEmpty(FilterActiveStatus))
                {
                    if (DtView.AsEnumerable()
                    .Where(x => x.Field<string>(CustomerMasterTable.ColumnName.ActiveStatusCode) == FilterActiveStatus).Count() > 0)
                    {
                        DtView = DtView.AsEnumerable()
                            .Where(x => x.Field<string>(CustomerMasterTable.ColumnName.ActiveStatusCode) == FilterActiveStatus).CopyToDataTable();
                    }
                    else
                    {
                        DtView = clsFrmCustomerMaster.CustomerMaster.Clone();
                    }
                }

                if (!string.IsNullOrEmpty(FilterProduct))
                {
                    if (DtView.AsEnumerable()
                    .Where(x => x.Field<string>(CustomerMasterTable.ColumnName.Name).ToLower().Contains(FilterProduct.ToLower())
                    || x.Field<string>(CustomerMasterTable.ColumnName.MobileNo).Contains(FilterProduct)
                    ).Count() > 0)
                    {

                        DtView = DtView.AsEnumerable()
                            .Where(x => x.Field<string>(CustomerMasterTable.ColumnName.Name).ToLower().Contains(FilterProduct.ToLower())
                            || x.Field<string>(CustomerMasterTable.ColumnName.MobileNo).Contains(FilterProduct)
                            ).CopyToDataTable();

                    }
                    else
                    {
                        DtView = clsFrmCustomerMaster.CustomerMaster.Clone();
                    }
                }

                DGView.DataSource = DtView;
            }
            catch
            {
                throw;
            }
        }

        private void FrmCustomerMaster_Activated(object sender, EventArgs e)
        {
            try
            {
                this.TxtCustomerName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void FrmCustomerMaster_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                    SendKeys.Send("{TAB}");

                if (e.Control && e.KeyCode == Keys.G)
                    DGView.Focus();

                if (e.KeyCode == Keys.F1)
                    TxtFilterVendor.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }


        private void TextBox_Enter(object sender, EventArgs e)
        {
            try
            {
                TextBox TextBox = (TextBox)sender;
                TextBox.BackColor = Color.WhiteSmoke;
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
                TextBox.BackColor = Color.White;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void ComboBox_Enter(object sender, EventArgs e)
        {
            try
            {
                ComboBox ComboBox = (ComboBox)sender;
                ComboBox.BackColor = Color.WhiteSmoke;
                //ComboBox.DroppedDown = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void ComboBox_Leave(object sender, EventArgs e)
        {
            try
            {
                ComboBox ComboBox = (ComboBox)sender;
                ComboBox.BackColor = Color.White;
                //ComboBox.DroppedDown = false;
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

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validation();

                clsFrmCustomerMaster.Code = this.TxtCustomerName.Tag != null ? (int)this.TxtCustomerName.Tag : 0;
                clsFrmCustomerMaster.Name = this.TxtCustomerName.Text.Trim();
                clsFrmCustomerMaster.MobileNo = this.TxtMobileNo.Text.Trim();
                clsFrmCustomerMaster.Address = this.TxtAddress.Text.Trim();
                clsFrmCustomerMaster.Active = (string)this.CmbActive.SelectedValue;

                if (clsFrmCustomerMaster.GetRecordCount() >= 1)
                {
                    this.ErrorProvider.SetError(this.TxtCustomerName, "Customer Name already exists. Please enter a different name.");
                    throw new Exception("Customer Name already exists. Please enter a different name.");
                }

                if (BtnSave.Text.ToUpper() == "&SAVE")
                {
                    clsFrmCustomerMaster.Save();
                    MessageBox.Show("Saved Successfully...");
                }
                else
                {
                    clsFrmCustomerMaster.Update();
                    MessageBox.Show("Update Successfully...");
                }

                this.ClearEntry();
                this.ClearView();
                this.TxtCustomerName.Focus();
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

                if (string.IsNullOrEmpty(this.TxtCustomerName.Text.Trim()))
                {
                    this.ErrorProvider.SetError(this.TxtCustomerName, "Please enter the customer name...");
                    IsValid = false;
                }

                if (this.CmbActive.SelectedValue == null || this.CmbActive.SelectedValue.ToString() == string.Empty)
                {
                    this.ErrorProvider.SetError(this.CmbActive, "Please select active status...");
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
                DGView.Columns[CustomerMasterTable.ColumnName.ActiveStatusCode].Visible = false;
                DGView.Columns[CustomerMasterTable.ColumnName.CreatedBy].Visible = false;
                DGView.Columns[CustomerMasterTable.ColumnName.CreatedDate].Visible = false;
                DGView.Columns[CustomerMasterTable.ColumnName.SNo].Visible = false;

                DGView.Columns[CustomerMasterTable.ColumnName.SNo].HeaderText = "SNo";
                DGView.Columns[CustomerMasterTable.ColumnName.Name].HeaderText = "Customer Name";
                DGView.Columns[CustomerMasterTable.ColumnName.MobileNo].HeaderText = "MobileNo";
                DGView.Columns[CustomerMasterTable.ColumnName.Address].HeaderText = "Address";
                DGView.Columns[CustomerMasterTable.ColumnName.Active].HeaderText = "Active";
                DGView.Columns[CustomerMasterTable.ColumnName.LastUpdatedBy].HeaderText = "Updated By";
                DGView.Columns[CustomerMasterTable.ColumnName.LastUpdatedDate].HeaderText = "Updated Date";

                foreach (DataGridViewColumn DGVColumn in DGView.Columns)
                {
                    if (DGVColumn.Name == CustomerMasterTable.ColumnName.Name || DGVColumn.Name == CustomerMasterTable.ColumnName.Address)
                        DGVColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    else
                        DGVColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
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
                    int _Code = Convert.ToInt32(DGView[CustomerMasterTable.ColumnName.Code, DGSelectedRowIndex].Value);

                    if (clsFrmCustomerMaster.CustomerMaster.AsEnumerable().Where(x => x.Field<int>(CustomerMasterTable.ColumnName.Code) == _Code).Count() > 0)
                    {
                        DataRow? _DataRow = clsFrmCustomerMaster.CustomerMaster.AsEnumerable().Where(x => x.Field<int>(CustomerMasterTable.ColumnName.Code) == _Code).FirstOrDefault();

                        this.TxtCustomerName.Tag = Convert.ToInt32(_DataRow[CustomerMasterTable.ColumnName.Code]);
                        this.TxtCustomerName.Text = _DataRow[CustomerMasterTable.ColumnName.Name].ToString();
                        this.TxtMobileNo.Text = _DataRow[CustomerMasterTable.ColumnName.MobileNo].ToString();
                        this.TxtAddress.Text = _DataRow[CustomerMasterTable.ColumnName.Address].ToString();
                        this.CmbActive.SelectedValue = _DataRow[CustomerMasterTable.ColumnName.ActiveStatusCode].ToString();

                        BtnSave.Text = "&Update";
                        TxtCustomerName.Focus();
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
                this.TxtCustomerName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void TxtFilterProduct_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (clsFrmCustomerMaster.CustomerMaster.Rows.Count > 0)
                {
                    this.FilterGridData();
                    this.SetGridStyle();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void CmbFilterQtyType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (clsFrmCustomerMaster.CustomerMaster.Rows.Count > 0)
                {
                    this.FilterGridData();
                    this.SetGridStyle();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }
    }

    #region "Struct"

    internal struct CustomerMasterTable
    {
        internal struct ColumnName
        {
            internal static string SNo = "SNo";
            internal static string Code = "Code";
            internal static string Name = "Name";
            internal static string MobileNo = "MobileNo";
            internal static string Address = "Address";
            
            internal static string ActiveStatusCode = "ActiveStatusCode";
            internal static string Active = "Active";
            internal static string CreatedBy = "CreatedBy";
            internal static string CreatedDate = "CreatedDate";
            internal static string LastUpdatedBy = "LastUpdatedBy";
            internal static string LastUpdatedDate = "LastUpdatedDate";
        }
    }

    #endregion

}
