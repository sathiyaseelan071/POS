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
    public partial class FrmReport : Form
    {
        ClsFrmReport clsFrmReport = new ClsFrmReport();
        public FrmReport()
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

        //"1" => "Product Wise - Purchase Report"
        //"2" => "Product Wise - Purchase Cummulaive Report"
        //"3" => "Product Wise - Sales Report"   
        //"4" => "Product Wise - Profit Loss Report"

        private void BtnView_Click(object sender, EventArgs e)
        {
            try
            {
                this.LabelClear();

                this.DGVReport.DataSource = null;

                int ReportType = Convert.ToInt32(CmbReportType.SelectedValue);
                int ProductCode = Convert.ToInt32(CmbProductFilter.SelectedValue);
                int CategoryCode = Convert.ToInt32(CmbCategory.SelectedValue);
                int QtyTypeCode = Convert.ToInt32(CmbQuantity.SelectedValue);

                clsFrmReport.GetData(DtpFromDate.Value.Date, DtpToDate.Value.Date, ReportType, ProductCode, CategoryCode, QtyTypeCode);

                if (clsFrmReport.ReportData != null)
                {
                    DGVReport.DataSource = clsFrmReport.ReportData;

                    decimal decTotalAmount;
                    if (clsFrmReport.ReportData.Rows.Count > 0)
                    {
                        if (ReportType == 1 || ReportType == 2)
                        {
                            decTotalAmount = Math.Round(Convert.ToDecimal(clsFrmReport.ReportData.Compute("SUM([TotPurAmount])", string.Empty)), 2);

                            this.LblTotalDispName1.Text = "Total Purchase Amount : ";
                            this.LblTotalDispValue1.Text = this.ToConvertDecimalFormatString(decTotalAmount.ToString());

                            this.LblTotalDispName1.Visible = true;
                            this.LblTotalDispValue1.Visible = true;
                        }
                        else if (ReportType == 3)
                        {
                            decTotalAmount = Math.Round(Convert.ToDecimal(clsFrmReport.ReportData.Compute("SUM([TotSellAmount])", string.Empty)), 2);

                            this.LblTotalDispName1.Text = "Total Sell Amount : ";
                            this.LblTotalDispValue1.Text = this.ToConvertDecimalFormatString(decTotalAmount.ToString());

                            this.LblTotalDispName1.Visible = true;
                            this.LblTotalDispValue1.Visible = true;
                        }
                        else if (ReportType == 4)
                        {
                            decTotalAmount = Math.Round(Convert.ToDecimal(clsFrmReport.ReportData.Compute("SUM([TotPurAmount])", string.Empty)), 2);

                            this.LblTotalDispName1.Text = "Total Purchase Amount : ";
                            this.LblTotalDispValue1.Text = this.ToConvertDecimalFormatString(decTotalAmount.ToString());

                            decTotalAmount = Math.Round(Convert.ToDecimal(clsFrmReport.ReportData.Compute("SUM([TotSellAmount])", string.Empty)), 2);

                            this.LblTotalDispName2.Text = "Total Sell Amount : ";
                            this.LblTotalDispValue2.Text = this.ToConvertDecimalFormatString(decTotalAmount.ToString());

                            this.LblTotalDispName1.Visible = true;
                            this.LblTotalDispValue1.Visible = true;

                            this.LblTotalDispName2.Visible = true;
                            this.LblTotalDispValue2.Visible = true;
                        }
                        else if (ReportType == 5)
                        {
                            decTotalAmount = Math.Round(Convert.ToDecimal(clsFrmReport.ReportData.Compute("SUM([BalanceDue])", string.Empty)), 2);

                            this.LblTotalDispName1.Text = "Total Due Amount : ";
                            this.LblTotalDispValue1.Text = this.ToConvertDecimalFormatString(decTotalAmount.ToString());

                            this.LblTotalDispName1.Visible = true;
                            this.LblTotalDispValue1.Visible = true;

                            this.LblTotalDispName2.Visible = false;
                            this.LblTotalDispValue2.Visible = false;
                        }
                        else if (ReportType == 6)
                        {
                            this.LblTotalDispName1.Visible = false;
                            this.LblTotalDispValue1.Visible = false;

                            this.LblTotalDispName2.Visible = false;
                            this.LblTotalDispValue2.Visible = false;
                        }
                        else if (ReportType == 7)
                        {
                            decTotalAmount = Math.Round(Convert.ToDecimal(clsFrmReport.ReportData.Compute("SUM([AproxProfitAmount])", string.Empty)), 2);

                            this.LblTotalDispName1.Text = "Total Aprox Profit Amount : ";
                            this.LblTotalDispValue1.Text = this.ToConvertDecimalFormatString(decTotalAmount.ToString());

                            this.LblTotalDispName1.Visible = true;
                            this.LblTotalDispValue1.Visible = true;

                            this.LblTotalDispName2.Visible = false;
                            this.LblTotalDispValue2.Visible = false;
                        }
                        else if (ReportType == 8)
                        {
                            decTotalAmount = Math.Round(Convert.ToDecimal(clsFrmReport.ReportData.Compute("SUM([AproxProfitAmount])", string.Empty)), 2);

                            this.LblTotalDispName1.Text = "Total Aprox Profit Amount : ";
                            this.LblTotalDispValue1.Text = this.ToConvertDecimalFormatString(decTotalAmount.ToString());

                            this.LblTotalDispName1.Visible = true;
                            this.LblTotalDispValue1.Visible = true;

                            this.LblTotalDispName2.Visible = false;
                            this.LblTotalDispValue2.Visible = false;
                        }
                        else if (ReportType == 9)
                        {
                            decTotalAmount = Math.Round(Convert.ToDecimal(clsFrmReport.ReportData.Compute("SUM([PendingAmount])", string.Empty)), 2);

                            this.LblTotalDispName1.Text = "Total Pending Amount : ";
                            this.LblTotalDispValue1.Text = this.ToConvertDecimalFormatString(decTotalAmount.ToString());

                            this.LblTotalDispName1.Visible = true;
                            this.LblTotalDispValue1.Visible = true;

                            this.LblTotalDispName2.Visible = false;
                            this.LblTotalDispValue2.Visible = false;
                        }
                        else if (ReportType == 10)
                        {
                            decTotalAmount = Math.Round(Convert.ToDecimal(clsFrmReport.ReportData.Compute("SUM([TotalAmount])", string.Empty)), 2);

                            this.LblTotalDispName1.Text = "Total Expenses Amount : ";
                            this.LblTotalDispValue1.Text = this.ToConvertDecimalFormatString(decTotalAmount.ToString());

                            this.LblTotalDispName1.Visible = true;
                            this.LblTotalDispValue1.Visible = true;

                            this.LblTotalDispName2.Visible = false;
                            this.LblTotalDispValue2.Visible = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
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

        private void FrmReportPurchase_Load(object sender, EventArgs e)
        {
            try
            {
                this.Clear();

                this.LoadControls();

                this.LabelClear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void Clear()
        {
            try
            {
                this.DtpFromDate.Value = DateTime.Now.Date;
                this.DtpToDate.Value = DateTime.Now.Date;

                this.CmbCategory.DataSource = null;
                this.CmbProductFilter.DataSource = null;
                this.CmbQuantity.DataSource = null;
                this.CmbReportType.DataSource = null;

                this.DGVReport.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void LabelClear()
        {
            try
            {
                this.LblTotalDispName1.Text = "";
                this.LblTotalDispValue1.Text = "";
                this.LblTotalDispName1.Visible = false;
                this.LblTotalDispValue1.Visible = false;

                this.LblTotalDispName2.Text = "";
                this.LblTotalDispValue2.Text = "";
                this.LblTotalDispName2.Visible = false;
                this.LblTotalDispValue2.Visible = false;
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
                this.clsFrmReport = new ClsFrmReport();
                this.clsFrmReport.GetMasterData();

                FillControls.ComboBoxFill(this.CmbProductFilter, this.clsFrmReport.ProductMaster, "Code", "Name", true, "All");
                FillControls.ComboBoxFill(this.CmbCategory, this.clsFrmReport.CategoryMaster, "Code", "Name", true, "All");
                FillControls.ComboBoxFill(this.CmbQuantity, this.clsFrmReport.QuantityMaster, "Code", "Name", true, "All");
                FillControls.ComboBoxFill(this.CmbReportType, this.clsFrmReport.ReportType, "Code", "Name", false, "");
            }
            catch
            {
                throw;
            }
        }
    }
}
