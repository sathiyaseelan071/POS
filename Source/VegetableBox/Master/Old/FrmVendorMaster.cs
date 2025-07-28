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
    public partial class FrmVendorMaster : Form
    {
        ClsFrmVendorMaster clsVendorMaster = new ClsFrmVendorMaster();
        public FrmVendorMaster()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            try
            {
                if (Global.mdiVegetableBox != null)
                    Global.mdiVegetableBox.CloseForm(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void FrmVendorMaster_Load(object sender, EventArgs e)
        {
            try
            {
                this.LoadControls();
                this.ClearEntry();
                this.ClearView();
                this.TxtVendorName.Focus();
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
                this.clsVendorMaster = new ClsFrmVendorMaster();
                this.clsVendorMaster.GetMasterData();

                FillControls.ComboBoxFill(this.CmbActive, this.clsVendorMaster.YesNoMaster, "Code", "Name", false, "");
                FillControls.ComboBoxFill(this.CmbFilterActive, this.clsVendorMaster.YesNoMaster, "Code", "Name", true, "All");
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
                this.TxtVendorName.Tag = null;
                this.TxtVendorName.Text = string.Empty;
                this.TxtVendorShortName.Text = string.Empty;
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

                clsVendorMaster.View();
                DGView.DataSource = clsVendorMaster.VendorMaster.Copy();
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
                DtView = clsVendorMaster.VendorMaster.Copy();

                if (!string.IsNullOrEmpty(FilterActiveStatus))
                {
                    if (DtView.AsEnumerable()
                    .Where(x => x.Field<string>(VendorMasterTable.ColumnName.ActiveStatusCode) == FilterActiveStatus).Count() > 0)
                    {
                        DtView = DtView.AsEnumerable()
                            .Where(x => x.Field<string>(VendorMasterTable.ColumnName.ActiveStatusCode) == FilterActiveStatus).CopyToDataTable();
                    }
                    else
                    {
                        DtView = clsVendorMaster.VendorMaster.Clone();
                    }
                }

                if (!string.IsNullOrEmpty(FilterProduct))
                {
                    if (DtView.AsEnumerable()
                    .Where(x => x.Field<string>(VendorMasterTable.ColumnName.Name).ToLower().Contains(FilterProduct.ToLower())
                    || x.Field<string>(VendorMasterTable.ColumnName.ShortName).ToLower().Contains(FilterProduct.ToLower())
                    || x.Field<string>(VendorMasterTable.ColumnName.MobileNo).Contains(FilterProduct)
                    ).Count() > 0)
                    {

                        DtView = DtView.AsEnumerable()
                            .Where(x => x.Field<string>(VendorMasterTable.ColumnName.Name).ToLower().Contains(FilterProduct.ToLower())
                            || x.Field<string>(VendorMasterTable.ColumnName.ShortName).ToLower().Contains(FilterProduct.ToLower())
                            || x.Field<string>(VendorMasterTable.ColumnName.MobileNo).Contains(FilterProduct)
                            ).CopyToDataTable();

                    }
                    else
                    {
                        DtView = clsVendorMaster.VendorMaster.Clone();
                    }
                }

                DGView.DataSource = DtView;
            }
            catch
            {
                throw;
            }
        }

        private void FrmVendorMaster_Activated(object sender, EventArgs e)
        {
            try
            {
                this.TxtVendorName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void FrmVendorMaster_KeyDown(object sender, KeyEventArgs e)
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

                clsVendorMaster.Code = this.TxtVendorName.Tag != null ? (int)this.TxtVendorName.Tag : 0;
                clsVendorMaster.Name = this.TxtVendorName.Text.Trim();
                clsVendorMaster.ShortName = this.TxtVendorShortName.Text.Trim();
                clsVendorMaster.MobileNo = this.TxtMobileNo.Text.Trim();
                clsVendorMaster.Address = this.TxtAddress.Text.Trim();
                clsVendorMaster.Active = (string)this.CmbActive.SelectedValue;

                if (BtnSave.Text.ToUpper() == "&SAVE")
                {
                    clsVendorMaster.Save();
                    MessageBox.Show("Saved Successfully...");
                }
                else
                {
                    clsVendorMaster.Update();
                    MessageBox.Show("Update Successfully...");
                }

                this.ClearEntry();
                this.ClearView();
                this.TxtVendorName.Focus();
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

                if (string.IsNullOrEmpty(this.TxtVendorName.Text.Trim()))
                {
                    this.ErrorProvider.SetError(this.TxtVendorName, "Please enter the vendor name...");
                    IsValid = false;
                }

                if (string.IsNullOrEmpty(this.TxtVendorShortName.Text.Trim()))
                {
                    this.ErrorProvider.SetError(this.TxtVendorShortName, "Please enter the vendor short name...");
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
                DGView.Columns[VendorMasterTable.ColumnName.ActiveStatusCode].Visible = false;
                DGView.Columns[VendorMasterTable.ColumnName.CreatedBy].Visible = false;
                DGView.Columns[VendorMasterTable.ColumnName.CreatedDate].Visible = false;
                DGView.Columns[VendorMasterTable.ColumnName.SNo].Visible = false;

                DGView.Columns[VendorMasterTable.ColumnName.SNo].HeaderText = "SNo";
                DGView.Columns[VendorMasterTable.ColumnName.Name].HeaderText = "Vendor Name";
                DGView.Columns[VendorMasterTable.ColumnName.ShortName].HeaderText = "Vendor Short Name";
                DGView.Columns[VendorMasterTable.ColumnName.MobileNo].HeaderText = "MobileNo";
                DGView.Columns[VendorMasterTable.ColumnName.Address].HeaderText = "Address";
                DGView.Columns[VendorMasterTable.ColumnName.Active].HeaderText = "Active";
                DGView.Columns[VendorMasterTable.ColumnName.LastUpdatedBy].HeaderText = "Updated By";
                DGView.Columns[VendorMasterTable.ColumnName.LastUpdatedDate].HeaderText = "Updated Date";

                foreach (DataGridViewColumn DGVColumn in DGView.Columns)
                {
                    if (DGVColumn.Name == VendorMasterTable.ColumnName.Name || DGVColumn.Name == VendorMasterTable.ColumnName.ShortName
                        || DGVColumn.Name == VendorMasterTable.ColumnName.Address)
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
                    int _Code = Convert.ToInt32(DGView[VendorMasterTable.ColumnName.Code, DGSelectedRowIndex].Value);

                    if (clsVendorMaster.VendorMaster.AsEnumerable().Where(x => x.Field<int>(VendorMasterTable.ColumnName.Code) == _Code).Count() > 0)
                    {
                        DataRow? _DataRow = clsVendorMaster.VendorMaster.AsEnumerable().Where(x => x.Field<int>(VendorMasterTable.ColumnName.Code) == _Code).FirstOrDefault();

                        this.TxtVendorName.Tag = Convert.ToInt32(_DataRow[VendorMasterTable.ColumnName.Code]);
                        this.TxtVendorName.Text = _DataRow[VendorMasterTable.ColumnName.Name].ToString();
                        this.TxtVendorShortName.Text = _DataRow[VendorMasterTable.ColumnName.ShortName].ToString();
                        this.TxtMobileNo.Text = _DataRow[VendorMasterTable.ColumnName.MobileNo].ToString();
                        this.TxtAddress.Text = _DataRow[VendorMasterTable.ColumnName.Address].ToString();
                        this.CmbActive.SelectedValue = _DataRow[VendorMasterTable.ColumnName.ActiveStatusCode].ToString();

                        BtnSave.Text = "&Update";
                        TxtVendorName.Focus();
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
                this.TxtVendorName.Focus();
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
                if (clsVendorMaster.VendorMaster.Rows.Count > 0)
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
                if (clsVendorMaster.VendorMaster.Rows.Count > 0)
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

    internal struct VendorMasterTable
    {
        internal struct ColumnName
        {
            internal static string SNo = "SNo";
            internal static string Code = "Code";
            internal static string Name = "Name";
            internal static string ShortName = "ShortName";
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
