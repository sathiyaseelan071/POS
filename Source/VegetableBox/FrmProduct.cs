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

namespace VegetableBox
{
    public partial class FrmProduct : Form
    {
        ClsFrmProduct clsFrmProduct = new ClsFrmProduct();
        public FrmProduct()
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

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            try
            {
                this.LoadControls();
                this.ClearEntry();
                this.ClearView();
                this.TxtProductName.Focus();
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
                this.clsFrmProduct = new ClsFrmProduct();
                this.clsFrmProduct.GetMasterData();

                FillControls.ComboBoxFill(this.CmbCategoryType, this.clsFrmProduct.CategoryMaster, "Code", "Name", false, "");
                FillControls.ComboBoxFill(this.CmbQtyType, this.clsFrmProduct.QuantityMaster, "Code", "Name", false, "");
                FillControls.ComboBoxFill(this.CmbCBORateMaster, this.clsFrmProduct.YesNoMaster, "Code", "Name", false, "");
                FillControls.ComboBoxFill(this.CmbAllowRateChange, this.clsFrmProduct.YesNoMaster, "Code", "Name", false, "");
                FillControls.ComboBoxFill(this.CmbMaintainStock, this.clsFrmProduct.YesNoMaster, "Code", "Name", true, "");
                FillControls.ComboBoxFill(this.CmbActive, this.clsFrmProduct.YesNoMaster, "Code", "Name", false, "");

                FillControls.ComboBoxFill(this.CmbFilterCategoryType, this.clsFrmProduct.CategoryMaster, "Code", "Name", true, "All");
                FillControls.ComboBoxFill(this.CmbFilterQtyType, this.clsFrmProduct.QuantityMaster, "Code", "Name", true, "All");
                FillControls.ComboBoxFill(this.CmbFilterMaintainStock, this.clsFrmProduct.YesNoMaster, "Code", "Name", true, "All");
                FillControls.ComboBoxFill(this.CmbFilterActive, this.clsFrmProduct.YesNoMaster, "Code", "Name", true, "All");
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
                this.TxtProductName.Tag = null;
                this.TxtProductName.Text = string.Empty;
                this.TxtProductTamilName.Text = string.Empty;
                this.TxtProductAlternateName.Text = string.Empty;
                this.CmbCategoryType.SelectedIndex = 0;
                this.CmbQtyType.SelectedIndex = 0;
                this.CmbCBORateMaster.SelectedIndex = 0;
                this.CmbAllowRateChange.SelectedIndex = 1;
                this.TxtBarcode.Text = string.Empty;
                this.TxtBarcode2.Text = string.Empty;
                this.TxtBarcode3.Text = string.Empty;
                this.TxtBarcode4.Text = string.Empty;
                this.CmbActive.SelectedIndex = 0;
                this.CmbMaintainStock.SelectedIndex = 0;
                this.TxtMaximumStock.Text = string.Empty;
                this.TxtMinimumStock.Text = string.Empty;
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
                this.CmbFilterCategoryType.SelectedIndex = 0;
                this.CmbFilterQtyType.SelectedIndex = 0;
                this.CmbFilterActive.SelectedIndex = 0;
                this.CmbFilterMaintainStock.SelectedIndex = 0;
                this.TxtFilterProduct.Text = string.Empty;

                clsFrmProduct.View();
                DGView.DataSource = clsFrmProduct.ProductMaster.Copy();
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
                string FilterProduct = TxtFilterProduct.Text;
                int FilterCategoryType = Convert.ToInt32(CmbFilterCategoryType.SelectedValue);
                int FilterQtyType = Convert.ToInt32(CmbFilterQtyType.SelectedValue);
                string? FilterActiveStatus = Convert.ToString(CmbFilterActive.SelectedValue);
                string? FilterMaintainStock = Convert.ToString(CmbFilterMaintainStock.SelectedValue);

                DataTable DtView = new DataTable();
                DtView = clsFrmProduct.ProductMaster.Copy();

                if (FilterCategoryType > 0)
                {
                    if (DtView.AsEnumerable()
                    .Where(x => x.Field<int>(ProductTable.ColumnName.CatCode) == FilterCategoryType).Count() > 0)
                    {
                        DtView = DtView.AsEnumerable()
                            .Where(x => x.Field<int>(ProductTable.ColumnName.CatCode) == FilterCategoryType).CopyToDataTable();
                    }
                    else
                    {
                        DtView = clsFrmProduct.ProductMaster.Clone();
                    }
                }

                if (FilterQtyType > 0)
                {
                    if (DtView.AsEnumerable()
                    .Where(x => x.Field<int>(ProductTable.ColumnName.QtyTypeCode) == FilterQtyType).Count() > 0)
                    {
                        DtView = DtView.AsEnumerable()
                            .Where(x => x.Field<int>(ProductTable.ColumnName.QtyTypeCode) == FilterQtyType).CopyToDataTable();
                    }
                    else
                    {
                        DtView = clsFrmProduct.ProductMaster.Clone();
                    }
                }

                if (!string.IsNullOrEmpty(FilterActiveStatus))
                {
                    if (DtView.AsEnumerable()
                    .Where(x => x.Field<string>(ProductTable.ColumnName.ActiveStatusCode) == FilterActiveStatus).Count() > 0)
                    {
                        DtView = DtView.AsEnumerable()
                            .Where(x => x.Field<string>(ProductTable.ColumnName.ActiveStatusCode) == FilterActiveStatus).CopyToDataTable();
                    }
                    else
                    {
                        DtView = clsFrmProduct.ProductMaster.Clone();
                    }
                }

                if (!string.IsNullOrEmpty(FilterMaintainStock))
                {
                    if (DtView.AsEnumerable()
                    .Where(x => x.Field<string>(ProductTable.ColumnName.MaintainStockCode) == FilterMaintainStock).Count() > 0)
                    {
                        DtView = DtView.AsEnumerable()
                            .Where(x => x.Field<string>(ProductTable.ColumnName.MaintainStockCode) == FilterMaintainStock).CopyToDataTable();
                    }
                    else
                    {
                        DtView = clsFrmProduct.ProductMaster.Clone();
                    }
                }

                if (!string.IsNullOrEmpty(FilterProduct))
                {
                    if (DtView.AsEnumerable()
                    .Where(x => x.Field<string>(ProductTable.ColumnName.Name).ToLower().Contains(FilterProduct.ToLower())
                    || x.Field<string>(ProductTable.ColumnName.AlternativeName).ToLower().Contains(FilterProduct.ToLower())
                    || x.Field<string>(ProductTable.ColumnName.PCodeString) == FilterProduct
                    || x.Field<string>(ProductTable.ColumnName.BarCode) == FilterProduct
                    ).Count() > 0)
                    {

                        DtView = DtView.AsEnumerable()
                            .Where(x => x.Field<string>(ProductTable.ColumnName.Name).ToLower().Contains(FilterProduct.ToLower())
                            || x.Field<string>(ProductTable.ColumnName.AlternativeName).ToLower().Contains(FilterProduct.ToLower())
                            || x.Field<string>(ProductTable.ColumnName.PCodeString) == FilterProduct
                            || x.Field<string>(ProductTable.ColumnName.BarCode) == FilterProduct
                            ).CopyToDataTable();

                    }
                    else
                    {
                        DtView = clsFrmProduct.ProductMaster.Clone();
                    }
                }

                DGView.DataSource = DtView;
            }
            catch
            {
                throw;
            }
        }

        private void FrmProduct_Activated(object sender, EventArgs e)
        {
            try
            {
                this.TxtProductName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void FrmProduct_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                    SendKeys.Send("{TAB}");

                if (e.Control && e.KeyCode == Keys.G)
                    DGView.Focus();

                if (e.KeyCode == Keys.F1)
                    CmbFilterCategoryType.Focus();
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

                if (TextBox.Name == TxtProductTamilName.Name)
                {
                    //SendKeys.Send("%(3)");
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

                if (TextBox.Name == TxtProductTamilName.Name)
                {
                    //SendKeys.Send("%(3)");
                }
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

                clsFrmProduct.ProductCode = this.TxtProductName.Tag != null ? (int)this.TxtProductName.Tag : 0;
                clsFrmProduct.ProductName = this.TxtProductName.Text.Trim();
                clsFrmProduct.ProductTamilName = this.TxtProductTamilName.Text.Trim();
                clsFrmProduct.ProductAlternateName = this.TxtProductAlternateName.Text.Trim();
                clsFrmProduct.CategoryTypeCode = Convert.ToInt32(this.CmbCategoryType.SelectedValue);
                clsFrmProduct.QuantityTypeCode = Convert.ToInt32(this.CmbQtyType.SelectedValue);
                clsFrmProduct.CalcBasedOnRateMaster = (string)this.CmbCBORateMaster.SelectedValue;
                clsFrmProduct.AllowRateChange = (string)this.CmbAllowRateChange.SelectedValue;
                clsFrmProduct.BarCode = this.TxtBarcode.Text.Trim();
                clsFrmProduct.BarCode2 = this.TxtBarcode2.Text.Trim();
                clsFrmProduct.BarCode3 = this.TxtBarcode3.Text.Trim();
                clsFrmProduct.BarCode4 = this.TxtBarcode4.Text.Trim();
                clsFrmProduct.ActiveStatus = (string)this.CmbActive.SelectedValue;

                if (this.CmbMaintainStock.SelectedIndex == -1)
                    clsFrmProduct.MaintainStock = "N";
                else
                    clsFrmProduct.MaintainStock = (string)this.CmbMaintainStock.SelectedValue;

                clsFrmProduct.MinStock = Convert.ToInt32(this.TxtMinimumStock.Text.Trim());
                clsFrmProduct.MaxStock = Convert.ToInt32(this.TxtMaximumStock.Text.Trim());

                if (clsFrmProduct.GetProductRecordCount() >= 1)
                {
                    this.ErrorProvider.SetError(this.TxtProductName, "Product Name already exists. Please enter a different name.");
                    this.ErrorProvider.SetError(this.TxtProductTamilName, "Product Name already exists. Please enter a different name.");

                    throw new Exception("Product Name already exists. Please enter a different name.");
                }

                if (BtnSave.Text.ToUpper() == "&SAVE")
                {
                    clsFrmProduct.Save();
                    MessageBox.Show("Saved Successfully...");
                }
                else
                {
                    clsFrmProduct.Update();
                    MessageBox.Show("Update Successfully...");
                }

                this.ClearEntry();
                this.ClearView();
                this.TxtProductName.Focus();
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

                if (string.IsNullOrEmpty(this.TxtProductName.Text.Trim()))
                {
                    this.ErrorProvider.SetError(this.TxtProductName, "Please enter the product name...");
                    IsValid = false;
                }

                if (string.IsNullOrEmpty(this.TxtProductTamilName.Text.Trim()))
                {
                    this.ErrorProvider.SetError(this.TxtProductTamilName, "Please enter the product tamil name...");
                    IsValid = false;
                }

                if (string.IsNullOrEmpty(this.TxtProductAlternateName.Text.Trim()))
                {
                    this.ErrorProvider.SetError(this.TxtProductAlternateName, "Please enter the product alternaive name...");
                    IsValid = false;
                }

                if (this.CmbCategoryType.SelectedValue == null || this.CmbCategoryType.SelectedValue.ToString() == string.Empty)
                {
                    this.ErrorProvider.SetError(this.CmbCategoryType, "Please select the product category type...");
                    IsValid = false;
                }

                if (this.CmbQtyType.SelectedValue == null || this.CmbQtyType.SelectedValue.ToString() == string.Empty)
                {
                    this.ErrorProvider.SetError(this.CmbQtyType, "Please select the product quantity type...");
                    IsValid = false;
                }

                if (this.CmbCBORateMaster.SelectedValue == null || this.CmbCBORateMaster.SelectedValue.ToString() == string.Empty)
                {
                    this.ErrorProvider.SetError(this.CmbCBORateMaster, "Please select the calculation based rate master...");
                    IsValid = false;
                }

                if (this.CmbMaintainStock.Enabled &&  (this.CmbMaintainStock.SelectedValue == null || this.CmbMaintainStock.SelectedValue.ToString() == string.Empty))
                {
                    this.ErrorProvider.SetError(this.CmbMaintainStock, "Please select maintain stock...");
                    IsValid = false;
                }

                if (this.CmbMaintainStock.Enabled &&
                    this.CmbMaintainStock.SelectedValue?.ToString() == "Y")
                {
                    if (!int.TryParse(this.TxtMinimumStock.Text, out int minStock) || minStock <= 0)
                    {
                        this.ErrorProvider.SetError(this.TxtMinimumStock, "Minimum stock must be greater than 0.");
                        IsValid = false;
                    }

                    if (!int.TryParse(this.TxtMaximumStock.Text, out int maxStock) || maxStock <= 0)
                    {
                        this.ErrorProvider.SetError(this.TxtMaximumStock, "Maximum stock must be greater than 0.");
                        IsValid = false;
                    }       

                    // Extra logical check: Min should not be greater than Max
                    if (minStock > 0 && maxStock > 0 && minStock > maxStock)
                    {
                        this.ErrorProvider.SetError(this.TxtMaximumStock, "Maximum stock must be greater than or equal to minimum stock.");
                        IsValid = false;
                    }
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
                DGView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

                DGView.Columns[ProductTable.ColumnName.CatCode].Visible = false;
                DGView.Columns[ProductTable.ColumnName.QtyTypeCode].Visible = false;
                DGView.Columns[ProductTable.ColumnName.ActiveStatusCode].Visible = false;
                DGView.Columns[ProductTable.ColumnName.CalcBORMCode].Visible = false;
                DGView.Columns[ProductTable.ColumnName.CreatedBy].Visible = false;
                DGView.Columns[ProductTable.ColumnName.LastUpdatedBy].Visible = false;
                DGView.Columns[ProductTable.ColumnName.CreatedDateTime].Visible = false;
                DGView.Columns[ProductTable.ColumnName.LastUpdatedDateTime].Visible = false;
                DGView.Columns[ProductTable.ColumnName.PCodeString].Visible = false;
                DGView.Columns[ProductTable.ColumnName.SNo].Visible = false;
                DGView.Columns[ProductTable.ColumnName.AllowRateChangeCode].Visible = false;
                DGView.Columns[ProductTable.ColumnName.MaintainStockCode].Visible = false;

                DGView.Columns[ProductTable.ColumnName.SNo].HeaderText = "SNo";
                DGView.Columns[ProductTable.ColumnName.Name].HeaderText = "Name";
                DGView.Columns[ProductTable.ColumnName.TamilName].HeaderText = "Tamil Name";
                DGView.Columns[ProductTable.ColumnName.AlternativeName].HeaderText = "Alternative Name";
                DGView.Columns[ProductTable.ColumnName.CatName].HeaderText = "Category";
                DGView.Columns[ProductTable.ColumnName.QtyTypeName].HeaderText = "Quantity Type";
                DGView.Columns[ProductTable.ColumnName.CalcBORM].HeaderText = "Calc BORM";
                DGView.Columns[ProductTable.ColumnName.ActiveStatus].HeaderText = "Active";
                DGView.Columns[ProductTable.ColumnName.AllowRateChange].HeaderText = "Allow Rate Change";
                DGView.Columns[ProductTable.ColumnName.MaintainStock].HeaderText = "Maintain Stock";
                DGView.Columns[ProductTable.ColumnName.MinStock].HeaderText = "Min Stock";
                DGView.Columns[ProductTable.ColumnName.MaxStock].HeaderText = "Max Stock";

                foreach (DataGridViewColumn DGVColumn in DGView.Columns)
                {
                    if (DGVColumn.Name == ProductTable.ColumnName.Name || DGVColumn.Name == ProductTable.ColumnName.TamilName)
                        DGVColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    else
                        DGVColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
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
                    int _ProCode = Convert.ToInt32(DGView[ProductTable.ColumnName.Code, DGSelectedRowIndex].Value);

                    if (clsFrmProduct.ProductMaster.AsEnumerable().Where(x => x.Field<int>(ProductTable.ColumnName.Code) == _ProCode).Count() > 0)
                    {
                        DataRow? _DataRow = clsFrmProduct.ProductMaster.AsEnumerable().Where(x => x.Field<int>(ProductTable.ColumnName.Code) == _ProCode).FirstOrDefault();

                        this.TxtProductName.Tag = Convert.ToInt32(_DataRow[ProductTable.ColumnName.Code]);
                        this.TxtProductName.Text = _DataRow[ProductTable.ColumnName.Name].ToString();
                        this.TxtProductTamilName.Text = _DataRow[ProductTable.ColumnName.TamilName].ToString();
                        this.TxtProductAlternateName.Text = _DataRow[ProductTable.ColumnName.AlternativeName].ToString();
                        this.CmbCategoryType.SelectedValue = _DataRow[ProductTable.ColumnName.CatCode].ToString();
                        this.CmbQtyType.SelectedValue = _DataRow[ProductTable.ColumnName.QtyTypeCode].ToString();
                        this.CmbCBORateMaster.SelectedValue = _DataRow[ProductTable.ColumnName.CalcBORMCode].ToString();
                        this.CmbAllowRateChange.SelectedValue = _DataRow[ProductTable.ColumnName.AllowRateChangeCode].ToString();
                        this.TxtBarcode.Text = _DataRow[ProductTable.ColumnName.BarCode].ToString();
                        this.TxtBarcode2.Text = _DataRow[ProductTable.ColumnName.BarCode2].ToString();
                        this.TxtBarcode3.Text = _DataRow[ProductTable.ColumnName.BarCode3].ToString();
                        this.TxtBarcode4.Text = _DataRow[ProductTable.ColumnName.BarCode4].ToString();
                        this.CmbActive.SelectedValue = _DataRow[ProductTable.ColumnName.ActiveStatusCode].ToString();
                        this.CmbMaintainStock.SelectedValue = _DataRow[ProductTable.ColumnName.MaintainStockCode].ToString();
                        this.TxtMinimumStock.Text = _DataRow[ProductTable.ColumnName.MinStock].ToString();
                        this.TxtMaximumStock.Text = _DataRow[ProductTable.ColumnName.MaxStock].ToString();

                        BtnSave.Text = "&Update";
                        TxtProductName.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void TxtProductTamilName_Validating(object sender, CancelEventArgs e)
        {
            //SendKeys.Send("%(3)");
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                this.ClearEntry();
                this.TxtProductName.Focus();
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
                if (clsFrmProduct.ProductMaster.Rows.Count > 0)
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
                if (clsFrmProduct.ProductMaster.Rows.Count > 0)
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

        private void TxtProductName_TextChanged(object sender, EventArgs e)
        {
            //this.TxtProductAlternateName.Text = this.TxtProductName.Text;
            //this.TxtProductTamilName.Text = this.TxtProductName.Text;
        }

        private void EnableDisable_MaintainStock()
        {
            try
            {
                bool IsEnable = false;

                if ((this.CmbCategoryType.SelectedValue != null && this.CmbCategoryType.SelectedIndex > 2) && //Vegetable, Fruit and Banana
                    this.CmbQtyType.SelectedValue != null && this.CmbQtyType.SelectedIndex == 1)  //Pieces
                {
                    IsEnable = true;
                }
                else
                {
                    this.CmbMaintainStock.SelectedIndex = -1;
                }

                this.LblMaintainStock.Enabled = IsEnable;
                this.CmbMaintainStock.Enabled = IsEnable;

                this.LblMinimumStock.Enabled = IsEnable;
                this.TxtMinimumStock.Enabled = IsEnable;

                this.LblMaximumStock.Enabled = IsEnable;
                this.TxtMaximumStock.Enabled = IsEnable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void CmbCategoryType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.EnableDisable_MaintainStock();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void CmbQtyType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.EnableDisable_MaintainStock();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void CmbFilterMaintainStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (clsFrmProduct.ProductMaster.Rows.Count > 0)
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

    internal struct ProductTable
    {
        internal struct ColumnName
        {
            internal static string SNo = "SNo";
            internal static string Code = "Code";
            internal static string Name = "Name";
            internal static string TamilName = "TamilName";
            internal static string AlternativeName = "AlternativeName";
            internal static string CatCode = "CatCode";
            internal static string CatName = "CatName";
            internal static string QtyTypeCode = "QtyTypeCode";
            internal static string QtyTypeName = "QtyTypeName";
            internal static string CalcBORMCode = "CalcBORMCode";
            internal static string CalcBORM = "CalcBORM";
            internal static string ActiveStatusCode = "ActiveStatusCode";
            internal static string ActiveStatus = "ActiveStatus";
            internal static string CreatedBy = "CreatedBy";
            internal static string CreatedDateTime = "CreatedDateTime";
            internal static string LastUpdatedBy = "LastUpdatedBy";
            internal static string LastUpdatedDateTime = "LastUpdatedDateTime";
            internal static string PCodeString = "PCodeString";
            internal static string BarCode = "BarCode";
            internal static string AllowRateChangeCode = "AllowRateChangeCode";
            internal static string AllowRateChange = "AllowRateChange";
            internal static string BarCode2 = "BarCode2";
            internal static string BarCode3 = "BarCode3";
            internal static string BarCode4 = "BarCode4";
            internal static string MaintainStockCode = "MaintainStockCode";
            internal static string MaintainStock = "MaintainStock";
            internal static string MinStock = "MinStock";
            internal static string MaxStock = "MaxStock";
        }
    }

    #endregion

}
