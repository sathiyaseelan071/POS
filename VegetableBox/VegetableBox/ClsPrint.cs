using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Printing;
using VegetableBox.Properties;
using System.Data;
using System.Data.SqlClient;

namespace VegetableBox
{

    internal class ClsPrint
    {
        private System.Drawing.Printing.PrintDocument printDocument;
        private DataTable PrintData = new DataTable();

        #region "Sales"
        public void PrintSalesBill(int BillNo, DateTime BillDate)
        {
            try
            {
                this.GetSalesPrintData(BillNo, BillDate);

                if(this.PrintData != null && this.PrintData.Rows.Count > 0)
                {
                    printDocument = new PrintDocument();
                    printDocument.PrintPage += new PrintPageEventHandler(printDocumentSalesPrintData_PrintPage);
                    printDocument.Print();
                }
                else
                {
                    throw new Exception("Print data is empty...");
                }
            }
            catch
            {
                throw;
            }
        }

        private void GetSalesPrintData(int BillNo, DateTime BillDate)
        {
            try
            {
                SqlIntract _SqlIntract = new SqlIntract();

                String SqlQuery = "SpGetPrintData";
                List<SqlParameter>? _ListSqlParameter = new List<SqlParameter>();
                _ListSqlParameter.Add(new SqlParameter("@BillNo", BillNo));
                _ListSqlParameter.Add(new SqlParameter("@BilledDate", BillDate));

                PrintData = new DataTable();
                PrintData = _SqlIntract.ExecuteDataTable(SqlQuery, CommandType.StoredProcedure, _ListSqlParameter);
            }
            catch
            {
                throw;
            }
        }

        private void printDocumentSalesPrintData_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                if (PrintData.Rows.Count > 0)
                {
                    string BillNo = Convert.ToString(PrintData.Rows[0]["BillNo"]);
                    string BillDate = Convert.ToString(PrintData.Rows[0]["BilledDateTime"]);
                    string TotAmount = Convert.ToString(PrintData.Rows[0]["TotAmount"]);
                    string DiscPercent = Convert.ToString(PrintData.Rows[0]["DiscPercent"]);
                    string DiscAmount = Convert.ToString(PrintData.Rows[0]["DiscAmount"]);
                    string GrossAmount = Convert.ToString(PrintData.Rows[0]["GrossAmount"]);
                    string RoundOffAmount = Convert.ToString(PrintData.Rows[0]["RoundOffAmount"]);
                    string NetAmount = Convert.ToString(PrintData.Rows[0]["NetAmount"]);

                    string PrintTotMRP = Convert.ToString(PrintData.Rows[0]["PrintTotMRP"]);
                    string PrintTotDiscMRP = Convert.ToString(PrintData.Rows[0]["PrintTotDiscMRP"]);

                    Graphics graphics = e.Graphics;

                    Font boldExtraSmall = new Font("Calibri", 8, FontStyle.Bold);
                    Font regularExtraSmall = new Font("Calibri", 8, FontStyle.Regular);

                    Font boldSmall = new Font("Calibri", 10, FontStyle.Bold);
                    Font regularSmall = new Font("Calibri", 10, FontStyle.Regular);

                    Font boldLarge = new Font("Calibri", 11, FontStyle.Bold);
                    Font regularLarge = new Font("Calibri", 11, FontStyle.Regular);

                    Font boldExtraLarge = new Font("Calibri", 14, FontStyle.Bold);
                    Font regularExtraLarge = new Font("Calibri", 14, FontStyle.Regular);

                    Font boldHeader = new Font("Calibri", 16, FontStyle.Bold);

                    SolidBrush solidBrush = new SolidBrush(Color.Black);
                    StringFormat stringFormatRighToLeft = new StringFormat(StringFormatFlags.DirectionRightToLeft);

                    string line = "________________________________________";

                    int vertical_y = 0;
                    int newLine = 20;

                    graphics.DrawString("VEGETABLE BOX", boldHeader, solidBrush, 70, vertical_y + newLine);
                    newLine = newLine + 30;
                    graphics.DrawString("87, 5 வது தெரு, நடாராஜபுரம் தெற்கு காலனி,", regularExtraSmall, solidBrush, 5, vertical_y + newLine);
                    newLine = newLine + 15;
                    graphics.DrawString("M.C. ரோடு, தஞ்சாவூர்.", regularExtraSmall, solidBrush, 80, vertical_y + newLine);
                    newLine = newLine + 15;
                    graphics.DrawString("Ph - 8248226167", regularSmall, solidBrush, 100, vertical_y + newLine);
                    newLine = newLine + 15;
                    graphics.DrawString("Cash Bill", boldSmall, solidBrush, 120, vertical_y + newLine);
                    newLine = newLine + 20;
                    graphics.DrawString("Bill No : " + BillNo, regularSmall, solidBrush, 5, vertical_y + newLine);
                    graphics.DrawString(BillDate, regularSmall, solidBrush, 145, vertical_y + newLine);
                    newLine = newLine + 10;
                    graphics.DrawString(line, regularSmall, solidBrush, 5, vertical_y + newLine);
                    newLine = newLine + 20;
                    graphics.DrawString("S.No", regularSmall, solidBrush, 5, vertical_y + newLine);
                    graphics.DrawString("Product-Name", regularSmall, solidBrush, 50, vertical_y + newLine);
                    newLine = newLine + 15;
                    graphics.DrawString("Qty", regularSmall, solidBrush, 5, vertical_y + newLine);
                    graphics.DrawString("MRP", regularSmall, solidBrush, 80, vertical_y + newLine);
                    graphics.DrawString("S.Rate", regularSmall, solidBrush, 150, vertical_y + newLine);
                    graphics.DrawString("Amount", regularSmall, solidBrush, 230, vertical_y + newLine);
                    newLine = newLine + 5;
                    graphics.DrawString(line, regularSmall, solidBrush, 5, vertical_y + newLine);

                    foreach (DataRow dataRow in PrintData.Rows)
                    {
                        newLine = newLine + 20;
                        graphics.DrawString(Convert.ToString(dataRow["SNo"]) , regularSmall, solidBrush, 5, vertical_y + newLine);
                        graphics.DrawString(Convert.ToString(dataRow["Item"]), regularSmall, solidBrush, 50, vertical_y + newLine);
                        newLine = newLine + 15;
                        graphics.DrawString(Convert.ToString(dataRow["Qty"]), regularSmall, solidBrush, 5, vertical_y + newLine);
                        graphics.DrawString(Convert.ToString(dataRow["MRP"]), regularSmall, solidBrush, 110, vertical_y + newLine, stringFormatRighToLeft);
                        graphics.DrawString(Convert.ToString(dataRow["SellRate"]), regularSmall, solidBrush, 190, vertical_y + newLine, stringFormatRighToLeft);
                        graphics.DrawString(Convert.ToString(dataRow["Amount"]), regularSmall, solidBrush, 285, vertical_y + newLine, stringFormatRighToLeft);
                        newLine = newLine + 3;
                    }

                    newLine = newLine + 5;
                    graphics.DrawString(line, regularSmall, solidBrush, 5, vertical_y + newLine);
                    newLine = newLine + 20;
                    graphics.DrawString("Sub Total", boldSmall, solidBrush, 100, vertical_y + newLine);
                    graphics.DrawString(TotAmount, boldSmall, solidBrush, 285, vertical_y + newLine, stringFormatRighToLeft);
                    newLine = newLine + 7;
                    graphics.DrawString(line, regularSmall, solidBrush, 5, vertical_y + newLine);

                    newLine = newLine + 20;
                    graphics.DrawString("Total Amount", boldLarge, solidBrush, 85, vertical_y + newLine);
                    graphics.DrawString(TotAmount, boldLarge, solidBrush, 285, vertical_y + newLine, stringFormatRighToLeft);
                    newLine = newLine + 20;

                    if (Convert.ToDecimal(DiscPercent) > 0)
                    {
                        graphics.DrawString("Disc %", boldLarge, solidBrush, 85, vertical_y + newLine);
                        graphics.DrawString("% " + DiscPercent, boldLarge, solidBrush, 285, vertical_y + newLine, stringFormatRighToLeft);
                        newLine = newLine + 20;

                        graphics.DrawString("Disc Amount", boldLarge, solidBrush, 85, vertical_y + newLine);
                        graphics.DrawString(DiscAmount, boldLarge, solidBrush, 285, vertical_y + newLine, stringFormatRighToLeft);
                        newLine = newLine + 20;

                        graphics.DrawString("Gross Amount", boldLarge, solidBrush, 85, vertical_y + newLine);
                        graphics.DrawString(GrossAmount, boldLarge, solidBrush, 285, vertical_y + newLine, stringFormatRighToLeft);
                        newLine = newLine + 20;
                    }

                    if (RoundOffAmount.Contains("-"))
                    {
                        RoundOffAmount.Replace("-", "");
                        RoundOffAmount = RoundOffAmount + "-";
                    }

                    graphics.DrawString("Round Off", regularSmall, solidBrush, 85, vertical_y + newLine);
                    graphics.DrawString(RoundOffAmount, regularSmall, solidBrush, 285, vertical_y + newLine, stringFormatRighToLeft);
                    newLine = newLine + 40;

                    graphics.DrawString("Net Amount", boldExtraLarge, solidBrush, 50, vertical_y + newLine);
                    graphics.DrawString(NetAmount, boldExtraLarge, solidBrush, 285, vertical_y + newLine, stringFormatRighToLeft);

                    newLine = newLine + 30;

                    graphics.DrawString("Total MRP", boldSmall, solidBrush, 85, vertical_y + newLine);
                    graphics.DrawString(PrintTotMRP, boldSmall, solidBrush, 285, vertical_y + newLine, stringFormatRighToLeft);
                    newLine = newLine + 20;

                    decimal roundOff = Convert.ToDecimal(PrintData.Rows[0]["RoundOffAmount"]);
                    decimal totDiscMRP = Convert.ToDecimal(PrintData.Rows[0]["PrintTotDiscMRP"]);

                    PrintTotDiscMRP = (totDiscMRP - roundOff).ToString("0.00");
                    if ((totDiscMRP - roundOff) < 0)
                        PrintTotDiscMRP = "0.00";

                    graphics.DrawString("Total Savings", boldSmall, solidBrush, 85, vertical_y + newLine);
                    graphics.DrawString(PrintTotDiscMRP, boldSmall, solidBrush, 285, vertical_y + newLine, stringFormatRighToLeft);
                    newLine = newLine + 50;

                    graphics.DrawString("நன்றி மீண்டும் வருக.", regularSmall, solidBrush, 70, vertical_y + newLine);

                    e.HasMorePages = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void printDocumentSalesPrintDataOld_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                if (PrintData.Rows.Count > 0)
                {
                    string BillNo = Convert.ToString(PrintData.Rows[0]["BillNo"]);
                    string BillDate = Convert.ToString(PrintData.Rows[0]["BilledDateTime"]);
                    string TotAmount = Convert.ToString(PrintData.Rows[0]["TotAmount"]);
                    string DiscPercent = Convert.ToString(PrintData.Rows[0]["DiscPercent"]);
                    string DiscAmount = Convert.ToString(PrintData.Rows[0]["DiscAmount"]);
                    string GrossAmount = Convert.ToString(PrintData.Rows[0]["GrossAmount"]);
                    string RoundOffAmount = Convert.ToString(PrintData.Rows[0]["RoundOffAmount"]);
                    string NetAmount = Convert.ToString(PrintData.Rows[0]["NetAmount"]);


                    Graphics graphics = e.Graphics;

                    Font boldExtraSmall = new Font("Calibri", 8, FontStyle.Bold);
                    Font regularExtraSmall = new Font("Calibri", 8, FontStyle.Regular);

                    Font boldSmall = new Font("Calibri", 10, FontStyle.Bold);
                    Font regularSmall = new Font("Calibri", 10, FontStyle.Regular);

                    Font boldLarge = new Font("Calibri", 11, FontStyle.Bold);
                    Font regularLarge = new Font("Calibri", 11, FontStyle.Regular);

                    Font boldExtraLarge = new Font("Calibri", 14, FontStyle.Bold);
                    Font regularExtraLarge = new Font("Calibri", 14, FontStyle.Regular);

                    Font boldHeader = new Font("Calibri", 16, FontStyle.Bold);

                    SolidBrush solidBrush = new SolidBrush(Color.Black);
                    StringFormat stringFormatRighToLeft = new StringFormat(StringFormatFlags.DirectionRightToLeft);

                    string line = "________________________________________";

                    int vertical_y = 0;
                    int newLine = 20;

                    graphics.DrawString("VEGETABLE BOX", boldHeader, solidBrush, 70, vertical_y + newLine);
                    newLine = newLine + 30;
                    graphics.DrawString("87, 5 வது தெரு, நடாராஜபுரம் தெற்கு காலனி,", regularExtraSmall, solidBrush, 5, vertical_y + newLine);
                    newLine = newLine + 15;
                    graphics.DrawString("M.C. ரோடு, தஞ்சாவூர்.", regularExtraSmall, solidBrush, 80, vertical_y + newLine);
                    newLine = newLine + 15;
                    graphics.DrawString("Ph - 8248226167", regularSmall, solidBrush, 100, vertical_y + newLine);
                    newLine = newLine + 15;
                    graphics.DrawString("Cash Bill", boldSmall, solidBrush, 120, vertical_y + newLine);
                    newLine = newLine + 20;
                    graphics.DrawString("Bill No : " + BillNo, regularSmall, solidBrush, 5, vertical_y + newLine);
                    graphics.DrawString(BillDate, regularSmall, solidBrush, 145, vertical_y + newLine);
                    newLine = newLine + 10;
                    graphics.DrawString(line, regularSmall, solidBrush, 5, vertical_y + newLine);
                    newLine = newLine + 20;
                    graphics.DrawString("S.No", regularSmall, solidBrush, 5, vertical_y + newLine);
                    graphics.DrawString("Item", regularSmall, solidBrush, 40, vertical_y + newLine);
                    graphics.DrawString("Qty", regularSmall, solidBrush, 120, vertical_y + newLine);
                    graphics.DrawString("Rate", regularSmall, solidBrush, 180, vertical_y + newLine);
                    graphics.DrawString("Amount", regularSmall, solidBrush, 230, vertical_y + newLine);
                    newLine = newLine + 5;
                    graphics.DrawString(line, regularSmall, solidBrush, 5, vertical_y + newLine);

                    foreach (DataRow dataRow in PrintData.Rows)
                    {
                        newLine = newLine + 20;

                        graphics.DrawString(Convert.ToString(dataRow["SNo"]), regularSmall, solidBrush, 5, vertical_y + newLine);
                        graphics.DrawString(Convert.ToString(dataRow["Item"]), regularSmall, solidBrush, 40, vertical_y + newLine);
                        newLine = newLine + 15;
                        graphics.DrawString(Convert.ToString(dataRow["Qty"]), regularSmall, solidBrush, 150, vertical_y + newLine, stringFormatRighToLeft);
                        graphics.DrawString(Convert.ToString(dataRow["SellRate"]), regularSmall, solidBrush, 210, vertical_y + newLine, stringFormatRighToLeft);
                        graphics.DrawString(Convert.ToString(dataRow["Amount"]), regularSmall, solidBrush, 285, vertical_y + newLine, stringFormatRighToLeft);
                    }

                    newLine = newLine + 5;
                    graphics.DrawString(line, regularSmall, solidBrush, 5, vertical_y + newLine);
                    newLine = newLine + 20;
                    graphics.DrawString("Sub Total", boldSmall, solidBrush, 100, vertical_y + newLine);
                    graphics.DrawString(TotAmount, boldSmall, solidBrush, 285, vertical_y + newLine, stringFormatRighToLeft);
                    newLine = newLine + 7;
                    graphics.DrawString(line, regularSmall, solidBrush, 5, vertical_y + newLine);

                    newLine = newLine + 20;
                    graphics.DrawString("Total Amount", boldLarge, solidBrush, 85, vertical_y + newLine);
                    graphics.DrawString(TotAmount, boldLarge, solidBrush, 285, vertical_y + newLine, stringFormatRighToLeft);
                    newLine = newLine + 20;

                    if (Convert.ToDecimal(DiscPercent) > 0)
                    {
                        graphics.DrawString("Disc %", boldLarge, solidBrush, 85, vertical_y + newLine);
                        graphics.DrawString("% " + DiscPercent, boldLarge, solidBrush, 285, vertical_y + newLine, stringFormatRighToLeft);
                        newLine = newLine + 20;

                        graphics.DrawString("Disc Amount", boldLarge, solidBrush, 85, vertical_y + newLine);
                        graphics.DrawString(DiscAmount, boldLarge, solidBrush, 285, vertical_y + newLine, stringFormatRighToLeft);
                        newLine = newLine + 20;

                        graphics.DrawString("Gross Amount", boldLarge, solidBrush, 85, vertical_y + newLine);
                        graphics.DrawString(GrossAmount, boldLarge, solidBrush, 285, vertical_y + newLine, stringFormatRighToLeft);
                        newLine = newLine + 20;
                    }

                    if (RoundOffAmount.Contains("-"))
                    {
                        RoundOffAmount.Replace("-", "");
                        RoundOffAmount = RoundOffAmount + "-";
                    }

                    graphics.DrawString("Round Off", regularSmall, solidBrush, 85, vertical_y + newLine);
                    graphics.DrawString(RoundOffAmount, regularSmall, solidBrush, 285, vertical_y + newLine, stringFormatRighToLeft);
                    newLine = newLine + 35;

                    graphics.DrawString("Net Amount", boldExtraLarge, solidBrush, 50, vertical_y + newLine);
                    graphics.DrawString(NetAmount, boldExtraLarge, solidBrush, 285, vertical_y + newLine, stringFormatRighToLeft);
                    newLine = newLine + 50;

                    graphics.DrawString("நன்றி மீண்டும் வருக.", regularSmall, solidBrush, 70, vertical_y + newLine);

                    e.HasMorePages = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region "Rate Master"

        public void RateMasterBill()
        {
            try
            {
                this.GetRateMasterPrintData();

                if (this.PrintData != null && this.PrintData.Rows.Count > 0)
                {
                    printDocument = new PrintDocument();
                    printDocument.PrintPage += new PrintPageEventHandler(printDocumentRateMaster_PrintPage);
                    printDocument.Print();
                }
                else
                {
                    throw new Exception("Print data is empty...");
                }
            }
            catch
            {
                throw;
            }
        }

        public void ProductRateDispPrint(int productCode)
        {
            try
            {
                this.GetRateMasterPrintData(productCode);

                if (this.PrintData != null && this.PrintData.Rows.Count > 0)
                {
                    printDocument = new PrintDocument();
                    printDocument.PrintPage += new PrintPageEventHandler(printDocumentRate_PrintPage);
                    printDocument.Print();
                }
                else
                {
                    throw new Exception("Print data is empty...");
                }
            }
            catch
            {
                throw;
            }
        }

        private void GetRateMasterPrintData(int productCode = 0)
        {
            try
            {
                SqlIntract _SqlIntract = new SqlIntract();

                String SqlQuery = "Select R.ProductCode, P.TamilName, R.SellRate, Q.ShortName As Unit From [RateMaster] As R";
                SqlQuery += Environment.NewLine + "Left Join [Product] As P On R.ProductCode = P.Code";
                SqlQuery += Environment.NewLine + "Left Join [Quantity] As Q On Q.Code = P.QtyTypeCode";
                SqlQuery += Environment.NewLine + "Where P.CatCode <= 2";

                if (productCode > 0)
                {
                    SqlQuery += Environment.NewLine + "and R.ProductCode = " + productCode;
                }

                SqlQuery += Environment.NewLine + "Order By P.CatCode, P.Code";

                PrintData = new DataTable();
                PrintData = _SqlIntract.ExecuteDataTable(SqlQuery, CommandType.Text, null);
            }
            catch
            {
                throw;
            }
        }

        private void printDocumentRateMaster_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                if (PrintData.Rows.Count > 0)
                {
                    string BillDate = DateTime.Now.Date.ToString("dd-MMM-yyyy");

                    Graphics graphics = e.Graphics;

                    Font boldExtraSmall = new Font("Calibri", 8, FontStyle.Bold);
                    Font regularExtraSmall = new Font("Calibri", 8, FontStyle.Regular);

                    Font boldSmall = new Font("Calibri", 10, FontStyle.Bold);
                    Font regularSmall = new Font("Calibri", 10, FontStyle.Regular);

                    Font boldLarge = new Font("Calibri", 11, FontStyle.Bold);
                    Font regularLarge = new Font("Calibri", 11, FontStyle.Regular);

                    Font boldExtraLarge = new Font("Calibri", 14, FontStyle.Bold);
                    Font regularExtraLarge = new Font("Calibri", 14, FontStyle.Regular);

                    Font boldHeader = new Font("Calibri", 16, FontStyle.Bold);

                    SolidBrush solidBrush = new SolidBrush(Color.Black);
                    StringFormat stringFormatRighToLeft = new StringFormat(StringFormatFlags.DirectionRightToLeft);

                    string line = "________________________________________";

                    int vertical_y = 0;
                    int newLine = 20;

                    graphics.DrawString(BillDate, regularSmall, solidBrush, 5, vertical_y + newLine);
                    newLine = newLine + 10;
                    graphics.DrawString(line, regularSmall, solidBrush, 5, vertical_y + newLine);
                    newLine = newLine + 20;
                    graphics.DrawString("Code", regularSmall, solidBrush, 5, vertical_y + newLine);
                    graphics.DrawString("Product Name", regularSmall, solidBrush, 40, vertical_y + newLine);
                    graphics.DrawString("Sell Rate", regularSmall, solidBrush, 230, vertical_y + newLine);
                    newLine = newLine + 5;
                    graphics.DrawString(line, regularSmall, solidBrush, 5, vertical_y + newLine);

                    foreach (DataRow dataRow in PrintData.Rows)
                    {
                        newLine = newLine + 20;

                        graphics.DrawString(Convert.ToString(dataRow["ProductCode"]), regularSmall, solidBrush, 5, vertical_y + newLine);
                        graphics.DrawString(Convert.ToString(dataRow["TamilName"]), regularSmall, solidBrush, 40, vertical_y + newLine);
                        graphics.DrawString(Convert.ToString(dataRow["SellRate"]), regularSmall, solidBrush, 285, vertical_y + newLine, stringFormatRighToLeft);
                    }

                    newLine = newLine + 5;
                    graphics.DrawString(line, regularSmall, solidBrush, 5, vertical_y + newLine);
                    newLine = newLine + 20;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void printDocumentRate_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                if (PrintData.Rows.Count > 0)
                {
                    string productName = PrintData.Rows[0]["TamilName"].ToString();
                    string productRate = PrintData.Rows[0]["SellRate"].ToString().Split('.')[0];
                    string productPaisa = PrintData.Rows[0]["SellRate"].ToString().Split('.')[1];
                    string productUnit = PrintData.Rows[0]["Unit"].ToString();

                    Graphics graphics = e.Graphics;

                    Font boldTwoNumber = new Font("Calibri", 100, FontStyle.Bold);
                    Font boldThreeNumber = new Font("Calibri", 80, FontStyle.Bold);

                    SolidBrush solidBrush = new SolidBrush(Color.Black);
                    StringFormat stringFormatRighToLeft = new StringFormat(StringFormatFlags.DirectionRightToLeft);

                    Font regularSmall = new Font("Calibri", 10, FontStyle.Regular);
                    string line = "________________________________________";

                    int vertical_y = 0;
                    int newLine = 5;

                    Font regularTamilFont = new Font("Calibri", 13, FontStyle.Regular);
                    graphics.DrawString(line, regularSmall, solidBrush, 5, vertical_y + newLine);
                    newLine = newLine + 25;
                    graphics.DrawString(productName, regularTamilFont, solidBrush, 5, vertical_y + newLine);
                    newLine = newLine + 20;
                    graphics.DrawString(line, regularSmall, solidBrush, 5, vertical_y + newLine);
                    newLine = newLine + 10;

                    if (productRate.Length <= 2)
                    {
                        graphics.DrawString(productRate, boldTwoNumber, solidBrush, 1, vertical_y + newLine);
                        newLine = newLine + 95;
                        Font regularExtraLarge = new Font("Calibri", 28, FontStyle.Bold);
                        graphics.DrawString("." + productPaisa + " /" + productUnit, regularExtraLarge, solidBrush, 155, vertical_y + newLine);
                    }
                    else
                    {
                        graphics.DrawString(productRate, boldThreeNumber, solidBrush, 1, vertical_y + newLine);
                        newLine = newLine + 75;
                        Font regularExtraLarge = new Font("Calibri", 23, FontStyle.Bold);
                        graphics.DrawString("." + productPaisa + " /" + productUnit, regularExtraLarge, solidBrush, 185, vertical_y + newLine);
                        newLine = newLine - 5;
                    }

                    newLine = newLine + 50;
                    graphics.DrawString(line, regularSmall, solidBrush, 5, vertical_y + newLine);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

    }
}
