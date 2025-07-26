using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Printing;
using System.IO.Ports;
using System.Diagnostics;

namespace VegetableBox
{
    internal class ClsFrmTagPrint
    {
        private DataTable _ProductData = new DataTable();
        internal DataTable ProductData
        {
            get { return _ProductData; }
            set { _ProductData = value; }
        }

        public ClsFrmTagPrint()
        {
            try
            {
                this.GetProductDetails();
            }
            catch
            {
                throw;
            }
        }

        public void GetProductDetails()
        {
            try
            {
                SqlIntract _SqlIntract = new SqlIntract();

                String SqlQuery = "SpGetProductRate";

                this._ProductData = new DataTable();
                this._ProductData = _SqlIntract.ExecuteDataTable(SqlQuery, CommandType.Text, null);
            }
            catch
            {
                throw;
            }
        }

        public void print(string productName, string MRP, string sellingRate, string barCode, int printCount)
        {
            try
            {
                string companyName = "Vegetable Box";
                MRP = "MRP: " + MRP;
                string sRate = "S.Rate:";

                string printString = string.Empty;

                printString = "I8,A";
                printString += Environment.NewLine + "q779";
                printString += Environment.NewLine + "O";
                printString += Environment.NewLine + "JF";
                printString += Environment.NewLine + "ZT";
                printString += Environment.NewLine + "Q200,25";
                printString += Environment.NewLine + "N";
                printString += Environment.NewLine + "A687,180,2,4,1,1,N,\"" + companyName + "\"";
                printString += Environment.NewLine + "A715,54,2,2,1,1,N,\"" + productName + "\"";
                printString += Environment.NewLine + "A756,24,2,2,1,1,N,\"" + MRP + "\"";
                printString += Environment.NewLine + "A506,27,2,3,1,1,N,\"" + sellingRate + "\"";
                printString += Environment.NewLine + "B718,145,2,1,3,6,56,N,\"" + barCode + "\"";
                printString += Environment.NewLine + "A619,80,2,2,1,1,N,\"" + barCode + "\"";
                printString += Environment.NewLine + "A602,24,2,2,1,1,N,\"" + sRate + "\"";

                printString += Environment.NewLine + "A297,180,2,4,1,1,N,\"" + companyName + "\"";
                printString += Environment.NewLine + "A325,54,2,2,1,1,N,\"" + productName + "\"";
                printString += Environment.NewLine + "A366,24,2,2,1,1,N,\"" + MRP + "\"";
                printString += Environment.NewLine + "A116,27,2,3,1,1,N,\"" + sellingRate + "\"";
                printString += Environment.NewLine + "B328,145,2,1,3,6,56,N,\"" + barCode + "\"";
                printString += Environment.NewLine + "A229,80,2,2,1,1,N,\"" + barCode + "\"";
                printString += Environment.NewLine + "A212,24,2,2,1,1,N,\"" + sRate + "\"";
                int pcount = 0;
                if (printCount % 2 == 0)
                {
                    pcount = printCount / 2;
                }
                else
                {
                    printCount = printCount + 1;
                    pcount = printCount / 2;
                }

                printString += Environment.NewLine + "P" + pcount.ToString();

                string printFilepath = Application.StartupPath + "TagPrint.prn";

                if (File.Exists(printFilepath))
                    File.Delete(printFilepath);

                if (!File.Exists(printFilepath))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(printFilepath))
                    {
                        sw.WriteLine(printString);
                        sw.Flush();
                    }
                }

                string batFilePath = Application.StartupPath + "BatPrint.bat";

                if (File.Exists(batFilePath))
                    File.Delete(batFilePath);

                if (!File.Exists(batFilePath))
                {
                    string printerName = "\\\\VEGETABLEBOX1\\SNBCTVSELP46NEOBPLE";
                    printString = "copy /b " + printFilepath + " " + printerName;
                    using (StreamWriter sw = File.CreateText(batFilePath))
                    {
                        sw.WriteLine(printString);
                        sw.Flush();
                    }
                }

                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = batFilePath,
                    RedirectStandardInput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                process.StartInfo = startInfo;
                process.Start();

                process.StandardInput.Flush();
                process.StandardInput.Close();

                process.WaitForExit();
                process.Close();

            }
            catch
            {
                throw;
            }
        }
    }

    #region "Struct"

    internal struct TagPrintDataStruct
    {
        internal struct ColumnName
        {
            internal static string SNo = "SNo";
            internal static string ProCode = "Pro-Code";
            internal static string ProName = "Product Name";
            internal static string ProTamilName = "Product Tamil Name";
            internal static string Unit = "Unit";
            internal static string TotalPurchaseQty = "Tot Pur Qty";
            internal static string TotalPurchaseAmount = "Tot Pur Amount";
            internal static string PurchaseRatePerQty = "Pur Rate Per Qty";
            internal static string SellRatePerQty = "Sell Rate Per Qty";

            internal static string MRP = "MRP";
            internal static string SellingMarginPer = "Selling Margin %";
            internal static string DiscPer = "Disc %";
            internal static string DiscRate = "Disc Rate";
        }
    }

    #endregion
}
