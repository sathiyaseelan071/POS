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
    public partial class FrmUserMaster : Form
    {
        ClsFrmUserMaster clsFrmUserMaster = new ClsFrmUserMaster();
        public FrmUserMaster()
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

        private void FrmUserMaster_Load(object sender, EventArgs e)
        {
            try
            {
                this.LoadControls();
                this.ClearEntry();
                this.ClearView();
                this.TxtUserName.Focus();
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
                this.clsFrmUserMaster = new ClsFrmUserMaster();
                this.clsFrmUserMaster.GetMasterData();

                FillControls.ComboBoxFill(this.CmbActive, this.clsFrmUserMaster.YesNoMaster, "Code", "Name", false, "");
                FillControls.ComboBoxFill(this.CmbFilterActive, this.clsFrmUserMaster.YesNoMaster, "Code", "Name", true, "All");
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
                this.TxtUserName.Tag = null;
                this.TxtUserName.Text = string.Empty;
                this.TxtPassword.Text = string.Empty;
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
                this.TxtFilterUser.Text = string.Empty;

                clsFrmUserMaster.View();
                DGView.DataSource = clsFrmUserMaster.UserMaster.Copy();
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
                string FilterProduct = TxtFilterUser.Text;
                string? FilterActiveStatus = Convert.ToString(CmbFilterActive.SelectedValue);

                DataTable DtView = new DataTable();
                DtView = clsFrmUserMaster.UserMaster.Copy();

                if (!string.IsNullOrEmpty(FilterActiveStatus))
                {
                    if (DtView.AsEnumerable()
                    .Where(x => x.Field<string>(UserMasterTable.ColumnName.ActiveStatusCode) == FilterActiveStatus).Count() > 0)
                    {
                        DtView = DtView.AsEnumerable()
                            .Where(x => x.Field<string>(UserMasterTable.ColumnName.ActiveStatusCode) == FilterActiveStatus).CopyToDataTable();
                    }
                    else
                    {
                        DtView = clsFrmUserMaster.UserMaster.Clone();
                    }
                }

                if (!string.IsNullOrEmpty(FilterProduct))
                {
                    if (DtView.AsEnumerable()
                    .Where(x => x.Field<string>(UserMasterTable.ColumnName.Name).ToLower().Contains(FilterProduct.ToLower())
                    ).Count() > 0)
                    {

                        DtView = DtView.AsEnumerable()
                            .Where(x => x.Field<string>(UserMasterTable.ColumnName.Name).ToLower().Contains(FilterProduct.ToLower())
                            ).CopyToDataTable();

                    }
                    else
                    {
                        DtView = clsFrmUserMaster.UserMaster.Clone();
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
                this.TxtUserName.Focus();
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
                    TxtFilterUser.Focus();

                if (e.KeyCode == Keys.Escape)
                    BtnExit.PerformClick();
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

                clsFrmUserMaster.Code = this.TxtUserName.Tag != null ? (int)this.TxtUserName.Tag : 0;
                clsFrmUserMaster.Name = this.TxtUserName.Text.Trim();
                clsFrmUserMaster.Password = this.TxtPassword.Text.Trim();
                clsFrmUserMaster.Active = (string)this.CmbActive.SelectedValue;

                if (BtnSave.Text.ToUpper() == "&SAVE")
                {
                    clsFrmUserMaster.Save();
                    MessageBox.Show("Saved Successfully...");
                }
                else
                {
                    clsFrmUserMaster.Update();
                    MessageBox.Show("Update Successfully...");
                }

                this.ClearEntry();
                this.ClearView();
                this.TxtUserName.Focus();
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

                if (string.IsNullOrEmpty(this.TxtUserName.Text.Trim()))
                {
                    this.ErrorProvider.SetError(this.TxtUserName, "Please enter the vendor name...");
                    IsValid = false;
                }

                if (string.IsNullOrEmpty(this.TxtPassword.Text.Trim()))
                {
                    this.ErrorProvider.SetError(this.TxtPassword, "Please enter the vendor short name...");
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
                DGView.Columns[UserMasterTable.ColumnName.ActiveStatusCode].Visible = false;
                DGView.Columns[UserMasterTable.ColumnName.CreatedBy].Visible = false;
                DGView.Columns[UserMasterTable.ColumnName.CreatedDate].Visible = false;
                DGView.Columns[UserMasterTable.ColumnName.SNo].Visible = false;
                DGView.Columns[UserMasterTable.ColumnName.Password].Visible = false;

                DGView.Columns[UserMasterTable.ColumnName.SNo].HeaderText = "SNo";
                DGView.Columns[UserMasterTable.ColumnName.Name].HeaderText = "Vendor Name";                
                DGView.Columns[UserMasterTable.ColumnName.Active].HeaderText = "Active";
                DGView.Columns[UserMasterTable.ColumnName.LastUpdatedBy].HeaderText = "Updated By";
                DGView.Columns[UserMasterTable.ColumnName.LastUpdatedDate].HeaderText = "Updated Date";

                foreach (DataGridViewColumn DGVColumn in DGView.Columns)
                {
                    if (DGVColumn.Name == UserMasterTable.ColumnName.Name)
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
                    int _Code = Convert.ToInt32(DGView[UserMasterTable.ColumnName.Code, DGSelectedRowIndex].Value);

                    if (clsFrmUserMaster.UserMaster.AsEnumerable().Where(x => x.Field<int>(UserMasterTable.ColumnName.Code) == _Code).Count() > 0)
                    {
                        DataRow? _DataRow = clsFrmUserMaster.UserMaster.AsEnumerable().Where(x => x.Field<int>(UserMasterTable.ColumnName.Code) == _Code).FirstOrDefault();

                        this.TxtUserName.Tag = Convert.ToInt32(_DataRow[UserMasterTable.ColumnName.Code]);
                        this.TxtUserName.Text = _DataRow[UserMasterTable.ColumnName.Name].ToString();
                        this.TxtPassword.Text = _DataRow[UserMasterTable.ColumnName.Password].ToString();
                        this.CmbActive.SelectedValue = _DataRow[UserMasterTable.ColumnName.ActiveStatusCode].ToString();

                        BtnSave.Text = "&Update";
                        TxtUserName.Focus();
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
                this.TxtUserName.Focus();
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
                if (clsFrmUserMaster.UserMaster.Rows.Count > 0)
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
                if (clsFrmUserMaster.UserMaster.Rows.Count > 0)
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

    internal struct UserMasterTable
    {
        internal struct ColumnName
        {
            internal static string SNo = "SNo";
            internal static string Code = "Code";
            internal static string Name = "Name";
            internal static string Password = "Password";
            
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
