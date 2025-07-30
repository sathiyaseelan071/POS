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
    public partial class FrmExpenseMaster : Form
    {
        ClsFrmExpenseMaster clsFrmExpenseMaster = new ClsFrmExpenseMaster();
        public Boolean IsChildForm = false;

        public FrmExpenseMaster()
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

        private void FrmExpenseMaster_Load(object sender, EventArgs e)
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
                this.TxtExpenseName.Focus();
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
                this.clsFrmExpenseMaster = new ClsFrmExpenseMaster();
                this.clsFrmExpenseMaster.GetMasterData();

                FillControls.ComboBoxFill(this.CmbActive, this.clsFrmExpenseMaster.YesNoMaster, "Code", "Name", false, "");
                FillControls.ComboBoxFill(this.CmbFilterActive, this.clsFrmExpenseMaster.YesNoMaster, "Code", "Name", true, "All");
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
                this.TxtExpenseName.Tag = null;
                this.TxtExpenseName.Text = string.Empty;
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
                this.TxtFilterExpense.Text = string.Empty;

                clsFrmExpenseMaster.View();
                DGView.DataSource = clsFrmExpenseMaster.VendorMaster.Copy();
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
                string FilterProduct = TxtFilterExpense.Text;
                string? FilterActiveStatus = Convert.ToString(CmbFilterActive.SelectedValue);

                DataTable DtView = new DataTable();
                DtView = clsFrmExpenseMaster.VendorMaster.Copy();

                if (!string.IsNullOrEmpty(FilterActiveStatus))
                {
                    if (DtView.AsEnumerable()
                    .Where(x => x.Field<string>(ExpenseMasterTable.ColumnName.ActiveStatusCode) == FilterActiveStatus).Count() > 0)
                    {
                        DtView = DtView.AsEnumerable()
                            .Where(x => x.Field<string>(ExpenseMasterTable.ColumnName.ActiveStatusCode) == FilterActiveStatus).CopyToDataTable();
                    }
                    else
                    {
                        DtView = clsFrmExpenseMaster.VendorMaster.Clone();
                    }
                }

                if (!string.IsNullOrEmpty(FilterProduct))
                {
                    if (DtView.AsEnumerable()
                    .Where(x => x.Field<string>(ExpenseMasterTable.ColumnName.Name).ToLower().Contains(FilterProduct.ToLower())
                    ).Count() > 0)
                    {

                        DtView = DtView.AsEnumerable()
                            .Where(x => x.Field<string>(ExpenseMasterTable.ColumnName.Name).ToLower().Contains(FilterProduct.ToLower())
                            ).CopyToDataTable();

                    }
                    else
                    {
                        DtView = clsFrmExpenseMaster.VendorMaster.Clone();
                    }
                }

                DGView.DataSource = DtView;
            }
            catch
            {
                throw;
            }
        }

        private void FrmExpenseMaster_Activated(object sender, EventArgs e)
        {
            try
            {
                this.TxtExpenseName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void FrmExpenseMaster_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                    SendKeys.Send("{TAB}");

                if (e.Control && e.KeyCode == Keys.G)
                    DGView.Focus();

                if (e.KeyCode == Keys.F1)
                    TxtFilterExpense.Focus();
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

                clsFrmExpenseMaster.Code = this.TxtExpenseName.Tag != null ? (int)this.TxtExpenseName.Tag : 0;
                clsFrmExpenseMaster.Name = this.TxtExpenseName.Text.Trim();
                clsFrmExpenseMaster.Active = (string)this.CmbActive.SelectedValue;

                if (clsFrmExpenseMaster.GetRecordCount() >= 1)
                {
                    this.ErrorProvider.SetError(this.TxtExpenseName, "Expense Name already exists. Please enter a different name.");
                    throw new Exception("Expense Name already exists. Please enter a different name.");
                }

                if (BtnSave.Text.ToUpper() == "&SAVE")
                {
                    clsFrmExpenseMaster.Save();
                    MessageBox.Show("Saved Successfully...");
                }
                else
                {
                    clsFrmExpenseMaster.Update();
                    MessageBox.Show("Update Successfully...");
                }

                this.ClearEntry();
                this.ClearView();
                this.TxtExpenseName.Focus();
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

                if (string.IsNullOrEmpty(this.TxtExpenseName.Text.Trim()))
                {
                    this.ErrorProvider.SetError(this.TxtExpenseName, "Please enter the expense name...");
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
                DGView.Columns[ExpenseMasterTable.ColumnName.ActiveStatusCode].Visible = false;
                DGView.Columns[ExpenseMasterTable.ColumnName.CreatedBy].Visible = false;
                DGView.Columns[ExpenseMasterTable.ColumnName.CreatedDate].Visible = false;
                DGView.Columns[ExpenseMasterTable.ColumnName.SNo].Visible = false;

                DGView.Columns[ExpenseMasterTable.ColumnName.SNo].HeaderText = "SNo";
                DGView.Columns[ExpenseMasterTable.ColumnName.Name].HeaderText = "Expense Name";
                DGView.Columns[ExpenseMasterTable.ColumnName.Active].HeaderText = "Active";
                DGView.Columns[ExpenseMasterTable.ColumnName.LastUpdatedBy].HeaderText = "Updated By";
                DGView.Columns[ExpenseMasterTable.ColumnName.LastUpdatedDate].HeaderText = "Updated Date";

                foreach (DataGridViewColumn DGVColumn in DGView.Columns)
                {
                    if (DGVColumn.Name == ExpenseMasterTable.ColumnName.Name)
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
                    int _Code = Convert.ToInt32(DGView[ExpenseMasterTable.ColumnName.Code, DGSelectedRowIndex].Value);

                    if (clsFrmExpenseMaster.VendorMaster.AsEnumerable().Where(x => x.Field<int>(ExpenseMasterTable.ColumnName.Code) == _Code).Count() > 0)
                    {
                        DataRow? _DataRow = clsFrmExpenseMaster.VendorMaster.AsEnumerable().Where(x => x.Field<int>(ExpenseMasterTable.ColumnName.Code) == _Code).FirstOrDefault();

                        this.TxtExpenseName.Tag = Convert.ToInt32(_DataRow[ExpenseMasterTable.ColumnName.Code]);
                        this.TxtExpenseName.Text = _DataRow[ExpenseMasterTable.ColumnName.Name].ToString();
                        this.CmbActive.SelectedValue = _DataRow[ExpenseMasterTable.ColumnName.ActiveStatusCode].ToString();

                        BtnSave.Text = "&Update";
                        TxtExpenseName.Focus();
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
                this.TxtExpenseName.Focus();
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
                if (clsFrmExpenseMaster.VendorMaster.Rows.Count > 0)
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
                if (clsFrmExpenseMaster.VendorMaster.Rows.Count > 0)
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

    internal struct ExpenseMasterTable
    {
        internal struct ColumnName
        {
            internal static string SNo = "SNo";
            internal static string Code = "Code";
            internal static string Name = "Name";
            
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
