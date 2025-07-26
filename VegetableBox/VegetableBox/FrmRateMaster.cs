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
using System.Data.Common;
using System.Security.Cryptography.X509Certificates;

namespace VegetableBox
{
    public partial class FrmRateMaster : Form
    {
        ClsFrmRateMaster clsFrmRateMaster = new ClsFrmRateMaster();
        public FrmRateMaster()
        {
            InitializeComponent();

            // deleted out all the binding code of the grid to focus on the interesting stuff
            DGView.CellEndEdit += new DataGridViewCellEventHandler(DGView_CellEndEdit);

            // Use the DataBindingComplete event to attack the SelectionChanged, 
            // avoiding infinite loops and other nastiness.
            DGView.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(DGView_DataBindingComplete);
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

        private void FrmRateMaster_Load(object sender, EventArgs e)
        {
            try
            {
                this.LoadControls();
                this.Clear();
                this.CmbFilterCategoryType.Focus();
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
                this.clsFrmRateMaster = new ClsFrmRateMaster();
                this.clsFrmRateMaster.GetMasterData();

                FillControls.ComboBoxFill(this.CmbFilterCategoryType, this.clsFrmRateMaster.CategoryMaster, "Code", "Name", true, "All");
                FillControls.ComboBoxFill(this.CmbFilterQtyType, this.clsFrmRateMaster.QuantityMaster, "Code", "Name", true, "All");
            }
            catch
            {
                throw;
            }
        }

        private void Clear()
        {
            try
            {
                this.CmbFilterCategoryType.SelectedIndex = 0;
                this.CmbFilterQtyType.SelectedIndex = 0;
                this.TxtFilterProduct.Text = string.Empty;
                clsFrmRateMaster.View();
                DGView.DataSource = clsFrmRateMaster.RateMaster.Copy();
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

                DataTable DtView = new DataTable();
                DtView = clsFrmRateMaster.RateMaster.Copy();

                if (FilterCategoryType > 0)
                {
                    if (DtView.AsEnumerable()
                    .Where(x => x.Field<int>(RateMasterTable.ColumnName.CatCode) == FilterCategoryType).Count() > 0)
                    {
                        DtView = DtView.AsEnumerable()
                            .Where(x => x.Field<int>(RateMasterTable.ColumnName.CatCode) == FilterCategoryType).CopyToDataTable();
                    }
                    else
                    {
                        DtView = clsFrmRateMaster.RateMaster.Clone();
                    }
                }

                if (FilterQtyType > 0)
                {
                    if (DtView.AsEnumerable()
                    .Where(x => x.Field<int>(RateMasterTable.ColumnName.QtyTypeCode) == FilterQtyType).Count() > 0)
                    {
                        DtView = DtView.AsEnumerable()
                            .Where(x => x.Field<int>(RateMasterTable.ColumnName.QtyTypeCode) == FilterQtyType).CopyToDataTable();
                    }
                    else
                    {
                        DtView = clsFrmRateMaster.RateMaster.Clone();
                    }
                }

                if (!string.IsNullOrEmpty(FilterProduct))
                {
                    if (DtView.AsEnumerable()
                    .Where(x => x.Field<string>(RateMasterTable.ColumnName.ProductName).ToLower().Contains(FilterProduct.ToLower())
                    || x.Field<string>(RateMasterTable.ColumnName.PCodeString).Contains(FilterProduct)
                    ).Count() > 0)
                    {

                        DtView = DtView.AsEnumerable()
                            .Where(x => x.Field<string>(RateMasterTable.ColumnName.ProductName).ToLower().Contains(FilterProduct.ToLower())
                            || x.Field<string>(RateMasterTable.ColumnName.PCodeString).Contains(FilterProduct)
                            ).CopyToDataTable();

                    }
                    else
                    {
                        DtView = clsFrmRateMaster.RateMaster.Clone();
                    }
                }

                DGView.DataSource = DtView;
            }
            catch
            {
                throw;
            }
        }

        private void FrmRateMaster_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter && !DGView.Focused)
                    SendKeys.Send("{TAB}");

                if (e.Control | e.KeyCode == Keys.G)
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
                List<string> list = new List<string>() { "ProductCode", "BuyRate", "SellMarginPercentage", "SellRate" };

                DataTable dtSave = new DataTable();
                dtSave = (DataTable)DGView.DataSource;

                if (dtSave != null && dtSave.Columns.Count > 0)
                {
                    if (dtSave.AsEnumerable().Where(x => x.Field<decimal>(RateMasterTable.ColumnName.SellRate) > 0).Count() > 0)
                    {
                        dtSave = dtSave.AsEnumerable().Where(x => x.Field<decimal>(RateMasterTable.ColumnName.SellRate) > 0).CopyToDataTable();

                        for (int i = dtSave.Columns.Count - 1; i >= 0; i--)
                        {
                            if (dtSave.Columns[i].ColumnName.ToUpper() != RateMasterTable.ColumnName.ProductCode.ToUpper()
                                && dtSave.Columns[i].ColumnName.ToUpper() != RateMasterTable.ColumnName.BuyRate.ToUpper()
                                && dtSave.Columns[i].ColumnName.ToUpper() != RateMasterTable.ColumnName.SellMarginPercentage.ToUpper()
                                && dtSave.Columns[i].ColumnName.ToUpper() != RateMasterTable.ColumnName.SellRate.ToUpper())
                            {
                                dtSave.Columns.Remove(dtSave.Columns[i].ColumnName);
                            }
                        }

                        dtSave.Columns.Add(RateMasterTable.ColumnName.CreatedBy, typeof(string));

                        foreach (DataRow dr in dtSave.Rows)
                        {
                            dr[RateMasterTable.ColumnName.CreatedBy] = Global.currentUserId;
                        }

                        clsFrmRateMaster.Save(dtSave);

                        MessageBox.Show("Saved Successfully...");

                        this.LoadControls();
                        this.Clear();
                        this.CmbFilterCategoryType.Focus();
                    }
                    else
                    {
                        throw new Exception("Enter atleast one product selling rate...");
                    }
                }
                else
                {
                    throw new Exception("Enter atleast one product selling rate...");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void SetGridStyle()
        {
            try
            {
                DGView.Columns[RateMasterTable.ColumnName.CatCode].Visible = false;
                DGView.Columns[RateMasterTable.ColumnName.QtyTypeCode].Visible = false;
                DGView.Columns[RateMasterTable.ColumnName.QtyTypeName].Visible = false;
                DGView.Columns[RateMasterTable.ColumnName.RateCode].Visible = false;
                DGView.Columns[RateMasterTable.ColumnName.PCodeString].Visible = false;

                DGView.Columns[RateMasterTable.ColumnName.ProductCode].HeaderText = "Product Code";
                DGView.Columns[RateMasterTable.ColumnName.ProductName].HeaderText = "Product Name";
                DGView.Columns[RateMasterTable.ColumnName.ProductTamilName].HeaderText = "Product Tamil Name";
                DGView.Columns[RateMasterTable.ColumnName.Qty].HeaderText = "Quantity";
                DGView.Columns[RateMasterTable.ColumnName.CatName].HeaderText = "Category";
                DGView.Columns[RateMasterTable.ColumnName.BuyRate].HeaderText = "Buy Rate";
                DGView.Columns[RateMasterTable.ColumnName.SellMarginPercentage].HeaderText = "Sell Margin %";
                DGView.Columns[RateMasterTable.ColumnName.SellRate].HeaderText = "Sell Rate";

                DGView.Columns[RateMasterTable.ColumnName.Qty].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                foreach (DataGridViewColumn DGVColumn in DGView.Columns)
                {
                    if (DGVColumn.Name == RateMasterTable.ColumnName.ProductCode || DGVColumn.Name == RateMasterTable.ColumnName.Qty
                        || DGVColumn.Name == RateMasterTable.ColumnName.SellRate)
                        DGVColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                    else
                        DGView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                    if (DGVColumn.Name == RateMasterTable.ColumnName.BuyRate || DGVColumn.Name == RateMasterTable.ColumnName.SellMarginPercentage
                        || DGVColumn.Name == RateMasterTable.ColumnName.SellRate)
                    {
                        DGVColumn.ReadOnly = false;
                        DGVColumn.ValueType = typeof(decimal);
                        DGVColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
                        DGVColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        DGVColumn.DefaultCellStyle.Format = "0.00";
                    }
                    else
                    {
                        DGVColumn.ReadOnly = true;
                    }
                }

                DGView.Columns[RateMasterTable.ColumnName.BuyRate].Visible = false;
                DGView.Columns[RateMasterTable.ColumnName.SellMarginPercentage].Visible = false;

                DGView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

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
                if (clsFrmRateMaster.RateMaster.Rows.Count > 0)
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
                if (clsFrmRateMaster.RateMaster.Rows.Count > 0)
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

        private void FrmRateMaster_Activated(object sender, EventArgs e)
        {
            try
            {
                this.CmbFilterCategoryType.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void DGView_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {

                if (e.KeyCode == Keys.P)
                {
                    e.SuppressKeyPress = true;

                    int productCode = Convert.ToInt32(DGView.Rows[DGSelectedRowIndex].Cells[RateMasterTable.ColumnName.ProductCode].Value);

                    ClsPrint clsPrint = new ClsPrint();
                    clsPrint.ProductRateDispPrint(productCode);
                }

                //if (e.KeyCode == Keys.Enter)
                //{
                //    e.SuppressKeyPress = true;

                //    if (DGView.CurrentCell.OwningColumn.Name == RateMasterTable.ColumnName.BuyRate)
                //    {
                //        DGView.CurrentCell = DGView.Rows[DGSelectedRowIndex].Cells[RateMasterTable.ColumnName.SellMarginPercentage];
                //    }
                //    else if (DGView.CurrentCell.OwningColumn.Name == RateMasterTable.ColumnName.SellMarginPercentage)
                //    {
                //        DGView.CurrentCell = DGView.Rows[DGSelectedRowIndex].Cells[RateMasterTable.ColumnName.SellRate];
                //    }
                //    else if (DGView.CurrentCell.OwningColumn.Name == RateMasterTable.ColumnName.SellRate)
                //    {
                //        if (DGView.Rows.Count > DGSelectedRowIndex + 1)
                //        {
                //            DGView.CurrentCell = DGView.Rows[DGSelectedRowIndex + 1].Cells[RateMasterTable.ColumnName.BuyRate];
                //        }
                //    }
                //}

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private int currentRow;
        private int currentCell;
        private bool resetRow = false;
        private void DGView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                resetRow = true;
                currentRow = e.RowIndex;
                currentCell = e.ColumnIndex;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void DGView_SelectionChanged_DontRemove(object sender, EventArgs e)
        {
            try
            {
                if (resetRow)
                {
                    resetRow = false;
                    //DGView.CurrentCell = DGView.Rows[currentRow].Cells[currentCell];

                    if (DGView.CurrentCell.OwningColumn.Name == RateMasterTable.ColumnName.BuyRate)
                    {
                        DGView.CurrentCell = DGView.Rows[currentRow].Cells[RateMasterTable.ColumnName.SellMarginPercentage];
                    }
                    else if (DGView.CurrentCell.OwningColumn.Name == RateMasterTable.ColumnName.SellMarginPercentage)
                    {
                        DGView.CurrentCell = DGView.Rows[currentRow].Cells[RateMasterTable.ColumnName.SellRate];
                    }
                    else if (DGView.CurrentCell.OwningColumn.Name == RateMasterTable.ColumnName.SellRate)
                    {
                        if (DGView.Rows.Count > currentRow + 1)
                        {
                            DGView.CurrentCell = DGView.Rows[currentRow + 1].Cells[RateMasterTable.ColumnName.BuyRate];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void DGView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                //DGView.SelectionChanged += new EventHandler(DGView_SelectionChanged_DontRemove); //SA001 DontRemove
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void DGView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            try
            {
                //bool IsResult = false;
                //if (DGView.CurrentCell.OwningColumn.Name == RateMasterTable.ColumnName.BuyRate)
                //    IsResult = IsValidBuyRate(e.FormattedValue);

                //if (DGView.CurrentCell.OwningColumn.Name == RateMasterTable.ColumnName.SellMarginPercentage)
                //    IsResult = IsValidSellRate(e.FormattedValue);

                //if (DGView.CurrentCell.OwningColumn.Name == RateMasterTable.ColumnName.SellRate)
                //    IsResult = IsValidSellRate(e.FormattedValue);
            }
            catch (Exception ex)
            {
                //e.Cancel = true;
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private bool IsValidBuyRate(object Value)
        {
            try
            {
                if (Value == null || Convert.ToString(Value).Trim() == string.Empty)
                    throw new Exception("Buy rate should not be empty...");

                decimal result = 0;
                if (!Decimal.TryParse(Convert.ToString(Value).Trim(), out result))
                    throw new Exception("Buy rate should be in decimal format...");

                if (result <= 0)
                    throw new Exception("Buy rate should be greater then zero...");

                return true;
            }
            catch
            {
                throw;
            }
        }

        private bool IsValidSellMarginPer(object Value)
        {
            try
            {
                if (Value == null || Convert.ToString(Value).Trim() == string.Empty)
                    throw new Exception("Sell margin percentage should not be empty...");

                decimal result = 0;
                if (!Decimal.TryParse(Convert.ToString(Value).Trim(), out result))
                    throw new Exception("Sell margin percentage should be in decimal format...");

                if (result <= 0)
                    throw new Exception("Sell margin percentage should be greater then zero...");

                return true;
            }
            catch
            {
                throw;
            }
        }

        private bool IsValidSellRate(object Value)
        {
            try
            {
                if (Value == null || Convert.ToString(Value).Trim() == string.Empty)
                    throw new Exception("Sell rate should not be empty...");

                decimal result = 0;
                if (!Decimal.TryParse(Convert.ToString(Value).Trim(), out result))
                    throw new Exception("Sell rate should be in decimal format...");

                if (result <= 0)
                    throw new Exception("Sell rate should be greater then zero...");

                return true;
            }
            catch
            {
                throw;
            }
        }

        private void UpdateRateInGrid()
        {
            try
            {
                if (DGView.Rows[this.currentRow].Cells[this.currentCell].OwningColumn.Name == RateMasterTable.ColumnName.BuyRate
                    || DGView.Rows[this.currentRow].Cells[this.currentCell].OwningColumn.Name == RateMasterTable.ColumnName.SellMarginPercentage)
                {
                    decimal BuyRate = (decimal)DGView.Rows[this.currentRow].Cells[RateMasterTable.ColumnName.BuyRate].Value;
                    decimal SellPer = (decimal)DGView.Rows[this.currentRow].Cells[RateMasterTable.ColumnName.SellMarginPercentage].Value;

                    decimal SellRate = Math.Round(BuyRate + ((BuyRate * SellPer) / 100));

                    DGView.Rows[this.currentRow].Cells[RateMasterTable.ColumnName.SellRate].Value = SellRate;
                }
                else if (DGView.Rows[this.currentRow].Cells[this.currentCell].OwningColumn.Name == RateMasterTable.ColumnName.SellRate)
                {
                    decimal BuyRate = (decimal)DGView.Rows[this.currentRow].Cells[RateMasterTable.ColumnName.BuyRate].Value;
                    decimal SellRate = (decimal)DGView.Rows[this.currentRow].Cells[RateMasterTable.ColumnName.SellRate].Value;

                    decimal SellPer = Math.Round(((SellRate - BuyRate) * 100) / SellRate);

                    DGView.Rows[this.currentRow].Cells[RateMasterTable.ColumnName.SellMarginPercentage].Value = SellPer;
                }
            }
            catch
            {
                throw;
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                this.LoadControls();
                this.Clear();
                this.CmbFilterCategoryType.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you want to print ?", "Vegetable Box", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    ClsPrint clsPrint = new ClsPrint();
                    clsPrint.RateMasterBill();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }
    }

    #region "Struct"

    internal struct RateMasterTable
    {
        internal struct ColumnName
        {
            internal static string ProductCode = "ProductCode";
            internal static string ProductName = "ProductName";
            internal static string ProductTamilName = "ProductTamilName";
            internal static string CatCode = "CatCode";
            internal static string CatName = "CatName";
            internal static string QtyTypeCode = "QtyTypeCode";
            internal static string QtyTypeName = "QtyTypeName";
            internal static string Qty = "Qty";

            internal static string BuyRate = "BuyRate";
            internal static string SellRate = "SellRate";
            internal static string SellMarginPercentage = "SellMarginPercentage";
            internal static string RateCode = "RateCode";
            internal static string PCodeString = "PCodeString";

            internal static string CreatedBy = "CreatedBy";
        }
    }

    #endregion

}
