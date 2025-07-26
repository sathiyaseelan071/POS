using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VegetableBox
{
    public partial class FrmTagPrint : Form
    {
        ClsFrmTagPrint clsFrmTagPrint;
        public FrmTagPrint()
        {
            InitializeComponent();
        }

        private void ClearProductDetails()
        {
            try
            {
                this.TxtProductSearch.Text = string.Empty;
                this.DgvProductSearch.DataSource = null;
                this.TxtProductName.Text = string.Empty;
                this.TxtProductTamilName.Text = string.Empty;
                this.TxtSellingRate.Text = string.Empty;
                this.TxtMrp.Text = string.Empty;
                this.TxtBarcode.Text = string.Empty;
                this.TxtPrintCount.Text = string.Empty;
                if (this.CmbLabelType.Items.Count > 0)
                    this.CmbLabelType.SelectedIndex = 0;
            }
            catch
            {
                throw;
            }
        }

        private void LoadControls()
        {
            try
            {

            }
            catch
            {
                throw;
            }
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

        private void ReadOnlyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

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

        private void Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                // allows 0-9, backspace, and decimal
                if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                {
                    e.Handled = true;
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void FrmTagPrint_Load(object sender, EventArgs e)
        {
            try
            {
                this.TxtProductSearch.Focus();
                this.clsFrmTagPrint = new ClsFrmTagPrint();
                this.ClearProductDetails();
                this.LoadControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            try
            {
                this.ClearProductDetails();
                this.TxtProductSearch.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void TxtProductSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.TxtProductSearch.Focused)
                    this.ErrorProvider.Clear();

                this.DoFillProductSearchGridControl(this.TxtProductSearch.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void DoFillProductSearchGridControl(string FilterProduct)
        {
            try
            {
                DataTable _DtSearch = new DataTable();
                if (FilterProduct != string.Empty)
                {
                    if (clsFrmTagPrint.ProductData != null && clsFrmTagPrint.ProductData.Rows.Count > 0)
                    {
                        _DtSearch.Columns.Add(ProductRateData.ColumnName.SearchName, typeof(string));
                        _DtSearch.Columns.Add(ProductRateData.ColumnName.ProductCode, typeof(string));

#pragma warning disable CS8602 // Dereference of a possibly null reference.

                        if (clsFrmTagPrint.ProductData.AsEnumerable()
                            .Where(x => (FilterProduct.Length >= 3 && x.Field<string>(ProductRateData.ColumnName.ProductName).ToLower().Contains(FilterProduct.ToLower()))
                            || (FilterProduct.Length >= 3 && x.Field<string>(ProductRateData.ColumnName.ProductAltrName).ToLower().Contains(FilterProduct.ToLower()))
                            || x.Field<string>(ProductRateData.ColumnName.ProductCode) == FilterProduct
                            || (FilterProduct.Length >= 3 && !string.IsNullOrEmpty(x.Field<string>(ProductRateData.ColumnName.BarCode))
                            && x.Field<string>(ProductRateData.ColumnName.BarCode).Contains(FilterProduct))).Count() > 0)
                        {

                            _DtSearch = clsFrmTagPrint.ProductData.AsEnumerable()
                                .Where(x => (FilterProduct.Length >= 3 && x.Field<string>(ProductRateData.ColumnName.ProductName).ToLower().Contains(FilterProduct.ToLower()))
                                || (FilterProduct.Length >= 3 && x.Field<string>(ProductRateData.ColumnName.ProductAltrName).ToLower().Contains(FilterProduct.ToLower()))
                                || x.Field<string>(ProductRateData.ColumnName.ProductCode) == FilterProduct
                                || (FilterProduct.Length >= 3 && !string.IsNullOrEmpty(x.Field<string>(ProductRateData.ColumnName.BarCode))
                                && x.Field<string>(ProductRateData.ColumnName.BarCode).Contains(FilterProduct)))
                                .OrderBy(x => x.Field<Int32>(ProductRateData.ColumnName.CatCode))
                                .Select(g =>
                                {
                                    var row = _DtSearch.NewRow();
                                    row[ProductRateData.ColumnName.SearchName] = g.Field<string>(ProductRateData.ColumnName.SearchName);
                                    row[ProductRateData.ColumnName.ProductCode] = g.Field<string>(ProductRateData.ColumnName.ProductCode);
                                    return row;
                                }).CopyToDataTable();
                        }

#pragma warning restore CS8602 // Dereference of a possibly null reference.

                        DgvProductSearch.DataSource = _DtSearch;

                        if (DgvProductSearch.Columns.Contains(ProductRateData.ColumnName.ProductCode))
                            DgvProductSearch.Columns[ProductRateData.ColumnName.ProductCode].Visible = false;

                    }
                }
                else
                {
                    DgvProductSearch.DataSource = _DtSearch;
                }
                this.DgvProductSearch.ClearSelection();
            }
            catch
            {
                throw;
            }
        }

        private void FrmTagPrint_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.F5)
                {
                    this.clsFrmTagPrint.GetProductDetails();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void TxtProductSearch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if ((e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down) && DgvProductSearch.Rows.Count == 1)
                {
                    this.DgvProductSearch.Focus();
                    this.DgvProductSearch.CurrentRow.Cells[0].Selected = true;
                    this.DgvProductSearch_KeyDown(sender, e);
                }
                else if ((e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down) && DgvProductSearch.Rows.Count > 0)
                {
                    this.DgvProductSearch.Focus();
                    this.DgvProductSearch.CurrentRow.Cells[0].Selected = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void DgvProductSearch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter && DgvProductSearch.Rows.Count > 0)
                {
                    this.ErrorProvider.Clear();
                    this.LoadCurrentProduct();
                    this.TxtPrintCount.Focus();
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private string? CurrentPCode { get; set; }
        private void LoadCurrentProduct()
        {
            try
            {
                if (DgvProductSearch.Rows.Count > 0)
                {
                    this.CurrentPCode = (string)DgvProductSearch.CurrentRow.Cells[ProductRateData.ColumnName.ProductCode].Value;

                    if (clsFrmTagPrint.ProductData != null && clsFrmTagPrint.ProductData.Rows.Count > 0)
                    {
                        if (clsFrmTagPrint.ProductData.AsEnumerable()
                            .Where(x => x.Field<string>(ProductRateData.ColumnName.ProductCode) == this.CurrentPCode).Count() > 0)
                        {

                            DataRow dataRow = clsFrmTagPrint.ProductData
                                .AsEnumerable().Where(x => x.Field<string>(ProductRateData.ColumnName.ProductCode) == this.CurrentPCode).FirstOrDefault();

                            if (dataRow != null)
                            {
                                this.TxtProductName.Text = (dataRow[ProductRateData.ColumnName.ProductName] != null ?
                                                           (string)dataRow[ProductRateData.ColumnName.ProductName] : string.Empty);

                                this.TxtProductTamilName.Text = (dataRow[ProductRateData.ColumnName.ProductTName] != null ?
                                                                (string)dataRow[ProductRateData.ColumnName.ProductTName] : string.Empty);

                                this.TxtMrp.Text = Convert.ToString((dataRow[ProductRateData.ColumnName.MRP] != null ?
                                                                (decimal)dataRow[ProductRateData.ColumnName.MRP] : 0.00));

                                this.TxtSellingRate.Text = Convert.ToString((dataRow[ProductRateData.ColumnName.SellRate] != null ?
                                                                (decimal)dataRow[ProductRateData.ColumnName.SellRate] : 0.00));

                                this.TxtBarcode.Text = (dataRow[ProductRateData.ColumnName.BarCode] != null ?
                                                                (string)dataRow[ProductRateData.ColumnName.BarCode] : string.Empty);

                                this.CmbLabelType.SelectedIndex = 0;

                                this.TxtProductSearch.Text = string.Empty;
                            }
                        }
                    }
                }
            }
            catch
            {
                throw;
            }
        }

        private void FrmTagPrint_Activated(object sender, EventArgs e)
        {
            this.TxtProductSearch.Focus();
        }

        private void TxtPrintCount_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    this.ErrorProvider.Clear();
                    this.BtnPrint.Focus();
                    e.Handled = true;
                }
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
                this.Validation();

                string productName = this.TxtProductName.Text;
                string mrp = this.TxtMrp.Text;
                string barcode = this.TxtBarcode.Text;
                string sellingRate = this.TxtSellingRate.Text;
                int printCount = Convert.ToInt32(this.TxtPrintCount.Text);

                this.clsFrmTagPrint.print(productName, mrp, sellingRate, barcode, printCount);
                
                MessageBox.Show("Pint Successfully...");

                this.ClearProductDetails();
                this.TxtProductSearch.Focus();
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

                if (string.IsNullOrEmpty(this.TxtMrp.Text.Trim()))
                {
                    this.ErrorProvider.SetError(this.TxtProductName, "Please enter the mrp...");
                    IsValid = false;
                }

                if (string.IsNullOrEmpty(this.TxtSellingRate.Text.Trim()))
                {
                    this.ErrorProvider.SetError(this.TxtSellingRate, "Please enter the selling rate...");
                    IsValid = false;
                }

                if (string.IsNullOrEmpty(this.TxtProductName.Text.Trim()))
                {
                    this.ErrorProvider.SetError(this.TxtProductName, "Please enter the product name...");
                    IsValid = false;
                }

                if (string.IsNullOrEmpty(this.TxtBarcode.Text.Trim()))
                {
                    this.ErrorProvider.SetError(this.TxtBarcode, "Please enter the barcode...");
                    IsValid = false;
                }

                if (string.IsNullOrEmpty(this.TxtPrintCount.Text.Trim()))
                {
                    this.ErrorProvider.SetError(this.TxtPrintCount, "Please enter the print count...");
                    IsValid = false;
                }

                //if (this.CmbLabelType.SelectedValue == null || this.CmbLabelType.SelectedValue.ToString() == string.Empty)
                //{
                //    this.ErrorProvider.SetError(this.CmbLabelType, "Please select the label type...");
                //    IsValid = false;
                //}

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


        [DllImport("winspool.Drv", EntryPoint = "OpenPrinter", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool OpenPrinter(string szPrinter, out IntPtr hPrinter, PRINTER_DEFAULTS pd);

        [DllImport("winspool.Drv", EntryPoint = "ClosePrinter", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool ClosePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "StartDocPrinter", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool StartDocPrinter(IntPtr hPrinter, int level, [In, MarshalAs(UnmanagedType.LPStruct)] DOCINFO di);

        [DllImport("winspool.Drv", EntryPoint = "EndDocPrinter", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool EndDocPrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "StartPagePrinter", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool StartPagePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "EndPagePrinter", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool EndPagePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "WritePrinter", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool WritePrinter(IntPtr hPrinter, IntPtr pBytes, int dwCount, out int dwWritten);

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public class DOCINFO
        {
            [MarshalAs(UnmanagedType.LPStr)]
            public string pDocName;
            [MarshalAs(UnmanagedType.LPStr)]
            public string pOutputFile;
            [MarshalAs(UnmanagedType.LPStr)]
            public string pDataType;
        }

        public class PRINTER_DEFAULTS
        {
            public int pDatatype;
            public int pDevMode;
            public int DesiredAccess;
        }

        private const int PRINTER_ACCESS_USE = 0x00000008;

        public bool SendFileToPrinter(string printerName, string filePath)
        {
            IntPtr printerHandle;
            PRINTER_DEFAULTS printerDefaults = new PRINTER_DEFAULTS();
            printerDefaults.DesiredAccess = PRINTER_ACCESS_USE;

            if (OpenPrinter(printerName, out printerHandle, printerDefaults))
            {
                IntPtr fileHandle = new IntPtr(0);
                DOCINFO docInfo = new DOCINFO();
                docInfo.pDocName = "Print Document";
                docInfo.pDataType = "RAW";

                if (StartDocPrinter(printerHandle, 1, docInfo))
                {
                    if (StartPagePrinter(printerHandle))
                    {
                        int bytesWritten;
                        IntPtr p = Marshal.StringToCoTaskMemAnsi(filePath);
                        WritePrinter(printerHandle, p, (int)filePath.Length, out bytesWritten);
                        Marshal.FreeCoTaskMem(p);
                        EndPagePrinter(printerHandle);
                    }
                    EndDocPrinter(printerHandle);
                }
                ClosePrinter(printerHandle);
            }

            return true;
        }

    }
}
