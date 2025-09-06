using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace VegetableBox
{
    internal class ClsFrmReport
    {
        private DataTable _ReportData = new DataTable();
        internal DataTable ReportData
        {
            get { return _ReportData; }
            set { _ReportData = value; }
        }

        internal void GetData(DateTime fromDateTime, DateTime toDateTime, int ReportType, int ProductCode, int CategoryCode, int QtyTypeCode)
        {
            try
            {
                String SqlQuery = "";
                if (ReportType == 1)
                {
                    SqlQuery = "SELECT PU.[ProductCode], PR.[Name] as ProductName, PR.TamilName, [TotPurQty], [Unit], [TotPurAmount],";
                    SqlQuery += Environment.NewLine + "[PurRatePerQty], [SellRatePerQty], C.[Name] AS Category, PR.CatCode";
                    SqlQuery += Environment.NewLine + "FROM [Purchase] AS PU";
                    SqlQuery += Environment.NewLine + "Inner Join Product As PR On PU.ProductCode = PR.Code";
                    SqlQuery += Environment.NewLine + "Inner Join Quantity AS Q ON PR.QtyTypeCode = Q.Code";
                    SqlQuery += Environment.NewLine + "Inner Join Category AS C ON PR.CatCode = C.Code";
                    SqlQuery += Environment.NewLine + "Where 1=1 and IsNull(BillStatus,'') = ''";
                    SqlQuery += Environment.NewLine + "and PU.TranDate = '" + fromDateTime.ToString("dd/MMM/yyyy") + "'";

                    if (ProductCode > 0)
                        SqlQuery += Environment.NewLine + "and PU.[ProductCode] = " + ProductCode + "";

                    if (CategoryCode > 0)
                        SqlQuery += Environment.NewLine + "and PR.[CatCode] = " + CategoryCode + "";

                    if (QtyTypeCode > 0)
                        SqlQuery += Environment.NewLine + "and Q.Code = " + QtyTypeCode + "";

                    SqlQuery += Environment.NewLine + "Order By PU.SNo";
                }
                else if (ReportType == 2)
                {
                    SqlQuery = "SELECT ProductCode, ProductName, TamilName, TotPurQty, Unit, TotPurAmount, Category, CatCode FROM(";
                    SqlQuery += Environment.NewLine + "SELECT PU.[ProductCode], PR.[Name] AS ProductName, PR.TamilName,";
                    SqlQuery += Environment.NewLine + "SUM([TotPurQty]) AS TotPurQty, Q.[ShortName] AS[Unit], SUM([TotPurAmount]) AS TotPurAmount, C.[Name] AS Category, PR.CatCode";
                    SqlQuery += Environment.NewLine + "FROM [Purchase] AS PU";
                    SqlQuery += Environment.NewLine + "Inner Join Product AS PR ON PU.ProductCode = PR.Code";
                    SqlQuery += Environment.NewLine + "Inner Join Quantity AS Q ON PR.QtyTypeCode = Q.Code";
                    SqlQuery += Environment.NewLine + "Inner Join Category AS C ON PR.CatCode = C.Code";
                    SqlQuery += Environment.NewLine + "WHERE 1 = 1 and IsNull(BillStatus,'') = ''";
                    SqlQuery += Environment.NewLine + "and PU.TranDate >= '" + fromDateTime.ToString("dd/MMM/yyyy") + "' AND PU.TranDate <= '" + toDateTime.ToString("dd/MMM/yyyy") + "'";

                    if (ProductCode > 0)
                        SqlQuery += Environment.NewLine + "and PU.[ProductCode] = " + ProductCode + "";

                    if (CategoryCode > 0)
                        SqlQuery += Environment.NewLine + "and PR.[CatCode] = " + CategoryCode + "";

                    if (QtyTypeCode > 0)
                        SqlQuery += Environment.NewLine + "and Q.Code = " + QtyTypeCode + "";

                    SqlQuery += Environment.NewLine + "GROUP BY PU.[ProductCode], PR.[Name], PR.TamilName, Q.[ShortName], C.[Name], PR.CatCode";
                    SqlQuery += Environment.NewLine + ") AS X";
                    SqlQuery += Environment.NewLine + "ORDER BY CatCode, ProductCode";
                }
                else if (ReportType == 3)
                {
                    SqlQuery = "SELECT S.[ProductCode], PR.[Name] AS ProductName, PR.TamilName,";
                    SqlQuery += Environment.NewLine + "SUM([Qty]) AS TotSellQty, SUM([TotAmount]) AS TotSellAmount, Q.[ShortName] AS[Unit], C.[Name] AS Category, PR.CatCode";
                    SqlQuery += Environment.NewLine + "FROM [Sales] AS S";
                    SqlQuery += Environment.NewLine + "Inner Join Product AS PR ON S.ProductCode = PR.Code";
                    SqlQuery += Environment.NewLine + "Inner Join Quantity AS Q ON PR.QtyTypeCode = Q.Code";
                    SqlQuery += Environment.NewLine + "Inner Join Category AS C ON PR.CatCode = C.Code";
                    SqlQuery += Environment.NewLine + "WHERE 1 = 1";
                    SqlQuery += Environment.NewLine + "AND ISNULL(BillStatus, '') NOT IN ('C', 'D')";
                    SqlQuery += Environment.NewLine + "and S.BilledDate >= '" + fromDateTime.ToString("dd/MMM/yyyy") + "' AND S.BilledDate <= '" + toDateTime.ToString("dd/MMM/yyyy") + "'";

                    if (ProductCode > 0)
                        SqlQuery += Environment.NewLine + "and S.[ProductCode] = " + ProductCode + "";

                    if (CategoryCode > 0)
                        SqlQuery += Environment.NewLine + "and PR.[CatCode] = " + CategoryCode + "";

                    if (QtyTypeCode > 0)
                        SqlQuery += Environment.NewLine + "and PR.[QtyTypeCode] = " + QtyTypeCode + "";

                    SqlQuery += Environment.NewLine + "GROUP BY S.[ProductCode], PR.[Name], PR.TamilName, Q.[ShortName], C.[Name], PR.CatCode";
                    SqlQuery += Environment.NewLine + "ORDER BY PR.CatCode, C.[Name] DESC";
                }
                else if (ReportType == 4)
                {

                    SqlQuery = "SELECT ProductCode, ProductName, TamilName, SUM(TotPurQty) AS TotPurQty, SUM(TotPurAmount) AS TotPurAmount,";
                    SqlQuery += Environment.NewLine + "SUM(TotSellQty) AS TotSellQty, SUM(TotSellAmount) AS TotSellAmount, SUM(TotSellQty) -SUM(TotPurQty) AS ProfitOrLossQty,";
                    SqlQuery += Environment.NewLine + "SUM(TotSellAmount) -SUM(TotPurAmount)  AS ProfitOrLossAmount, Unit, Category, CatCode FROM (";

                    SqlQuery += Environment.NewLine + "SELECT PU.[ProductCode], PR.[Name] AS ProductName, PR.TamilName,";
                    SqlQuery += Environment.NewLine + "SUM([TotPurQty]) AS TotPurQty, 0.00 as TotSellQty, SUM([TotPurAmount]) AS TotPurAmount, 0.00 as TotSellAmount, Q.[ShortName] AS[Unit], C.[Name] AS Category, PR.CatCode";
                    SqlQuery += Environment.NewLine + "FROM [Purchase] AS PU";
                    SqlQuery += Environment.NewLine + "Inner Join Product AS PR ON PU.ProductCode = PR.Code";
                    SqlQuery += Environment.NewLine + "Inner Join Quantity AS Q ON PR.QtyTypeCode = Q.Code";
                    SqlQuery += Environment.NewLine + "Inner Join Category AS C ON PR.CatCode = C.Code";
                    SqlQuery += Environment.NewLine + "WHERE 1 = 1 and IsNull(BillStatus,'') = ''";
                    SqlQuery += Environment.NewLine + "and PU.TranDate >= '" + fromDateTime.ToString("dd/MMM/yyyy") + "' AND PU.TranDate <= '" + toDateTime.ToString("dd/MMM/yyyy") + "'";

                    if (ProductCode > 0)
                        SqlQuery += Environment.NewLine + "and PU.[ProductCode] = " + ProductCode + "";

                    if (CategoryCode > 0)
                        SqlQuery += Environment.NewLine + "and PR.[CatCode] = " + CategoryCode + "";

                    if (QtyTypeCode > 0)
                        SqlQuery += Environment.NewLine + "and Q.Code = " + QtyTypeCode + "";

                    SqlQuery += Environment.NewLine + "GROUP BY PU.[ProductCode], PR.[Name], PR.TamilName, Q.[ShortName], C.[Name], PR.CatCode";

                    SqlQuery += Environment.NewLine + "UNION ALL";

                    SqlQuery += Environment.NewLine + "SELECT S.[ProductCode], PR.[Name] AS ProductName, PR.TamilName,";
                    SqlQuery += Environment.NewLine + "0.00 as TotPurQty, SUM([Qty]) AS TotSellQty, 0.00 AS TotPurAmount, SUM([TotAmount]) AS TotSellAmount, Q.[ShortName] AS[Unit], C.[Name] AS Category, PR.CatCode";
                    SqlQuery += Environment.NewLine + "FROM [Sales] AS S";
                    SqlQuery += Environment.NewLine + "Inner Join Product AS PR ON S.ProductCode = PR.Code";
                    SqlQuery += Environment.NewLine + "Inner Join Quantity AS Q ON PR.QtyTypeCode = Q.Code";
                    SqlQuery += Environment.NewLine + "Inner Join Category AS C ON PR.CatCode = C.Code";
                    SqlQuery += Environment.NewLine + "WHERE 1 = 1 and IsNull(BillStatus,'') = ''";
                    SqlQuery += Environment.NewLine + "and S.BilledDate >= '" + fromDateTime.ToString("dd/MMM/yyyy") + "' AND S.BilledDate <= '" + toDateTime.ToString("dd/MMM/yyyy") + "'";
                    SqlQuery += Environment.NewLine + "AND ISNULL(BillStatus, '') NOT IN ('C', 'D')";

                    if (ProductCode > 0)
                        SqlQuery += Environment.NewLine + "and S.[ProductCode] = " + ProductCode + "";

                    if (CategoryCode > 0)
                        SqlQuery += Environment.NewLine + "and PR.[CatCode] = " + CategoryCode + "";

                    if (QtyTypeCode > 0)
                        SqlQuery += Environment.NewLine + "and PR.[QtyTypeCode] = " + QtyTypeCode + "";

                    SqlQuery += Environment.NewLine + "GROUP BY S.[ProductCode], PR.[Name], PR.TamilName, Q.[ShortName], C.[Name], PR.CatCode";

                    SqlQuery += Environment.NewLine + ") AS Y";
                    SqlQuery += Environment.NewLine + "GROUP BY[ProductCode], ProductName, TamilName, Unit, Category, CatCode";
                    SqlQuery += Environment.NewLine + "ORDER BY CatCode, ProductCode";
                }
                else if (ReportType == 5)
                {
                    SqlQuery = "SELECT ROW_NUMBER() OVER (ORDER BY [CDN].[CustomerCode]) AS SNo, [CDN].[CustomerCode], [C].[Name],";
                    SqlQuery += Environment.NewLine + "SUM(CASE WHEN [CDN].[TransType] = 'D' THEN [CDN].[Amount] ELSE 0 END) AS [Debit],";
                    SqlQuery += Environment.NewLine + "SUM(CASE WHEN [CDN].[TransType] = 'C' THEN [CDN].[Amount] ELSE 0 END) AS [Credit],";
                    SqlQuery += Environment.NewLine + "SUM(CASE WHEN [CDN].[TransType] = 'D' THEN [CDN].[Amount] ELSE 0 END) -";
                    SqlQuery += Environment.NewLine + "SUM(CASE WHEN [CDN].[TransType] = 'C' THEN [CDN].[Amount] ELSE 0 END) AS [BalanceDue]";
                    SqlQuery += Environment.NewLine + "FROM [CustomerCreditDebitNote] AS [CDN]";
                    SqlQuery += Environment.NewLine + "LEFT JOIN [Customer] AS [C] ON [C].[Code] = [CDN].[CustomerCode]";
                    SqlQuery += Environment.NewLine + "GROUP BY [CDN].[CustomerCode], [C].[Name]";
                    SqlQuery += Environment.NewLine + "ORDER BY [C].[Name]";
                }
                else if (ReportType == 6)
                {
                    SqlQuery = "SELECT SUM(TotProfitAmount) AS AproxAmount";
                    SqlQuery += Environment.NewLine + "FROM SalesTransaction";
                    SqlQuery += Environment.NewLine + "WHERE 1=1";
                    SqlQuery += Environment.NewLine + "AND BilledDate >= '" + fromDateTime.ToString("dd/MMM/yyyy") + "' AND BilledDate <= '" + toDateTime.ToString("dd/MMM/yyyy") + "'";
                    SqlQuery += Environment.NewLine + "AND ISNULL(BillStatus, '') NOT IN ('C', 'D')";
                    if (ProductCode > 0)
                        SqlQuery += Environment.NewLine + "and S.[ProductCode] = " + ProductCode + "";

                    if (CategoryCode > 0)
                        SqlQuery += Environment.NewLine + "and P.[CatCode] = " + CategoryCode + "";
                }
                else if (ReportType == 7)
                {
                    SqlQuery = "SELECT ROW_NUMBER() OVER (ORDER BY C.[Code]) AS SNo, C.[Code], C.[Name], CAST(ROUND(SUM(Qty * PurAmount), 2) AS NUMERIC(12,2)) AS PurchaseAmount, SUM(TotAmount) AS SellingAmount, SUM(ProfitAmount) AS AproxProfitAmount";
                    SqlQuery += Environment.NewLine + "FROM [Sales] AS S";
                    SqlQuery += Environment.NewLine + "LEFT JOIN [Product] AS P ON P.[Code] = S.[ProductCode]";
                    SqlQuery += Environment.NewLine + "LEFT JOIN [Category] AS C ON C.[Code] = P.[CatCode]";
                    SqlQuery += Environment.NewLine + "WHERE 1=1";
                    SqlQuery += Environment.NewLine + "AND BilledDate >= '" + fromDateTime.ToString("dd/MMM/yyyy") + "' AND BilledDate <= '" + toDateTime.ToString("dd/MMM/yyyy") + "'";
                    SqlQuery += Environment.NewLine + "AND ISNULL(BillStatus, '') NOT IN ('C', 'D')";
                    if (ProductCode > 0)
                        SqlQuery += Environment.NewLine + "and S.[ProductCode] = " + ProductCode + "";

                    if (CategoryCode > 0)
                        SqlQuery += Environment.NewLine + "and P.[CatCode] = " + CategoryCode + "";
                    SqlQuery += Environment.NewLine + "GROUP BY C.[Code], C.[Name]";
                    SqlQuery += Environment.NewLine + "ORDER BY C.[Code]";
                }
                else if (ReportType == 8)
                {
                    SqlQuery = "SELECT ROW_NUMBER() OVER (ORDER BY S.[ProductCode]) AS SNo, S.[ProductCode], P.[Name] AS ProductName,";
                    SqlQuery += Environment.NewLine + "CASE";
                    SqlQuery += Environment.NewLine + "    WHEN P.[QtyTypeCode] = 2 --Pcs";
                    SqlQuery += Environment.NewLine + "        THEN FORMAT(SUM(Qty), '0')        --no decimals";
                    SqlQuery += Environment.NewLine + "    ELSE";
                    SqlQuery += Environment.NewLine + "        FORMAT(SUM(Qty), '0.00')-- 2 decimals";
                    SqlQuery += Environment.NewLine + "END AS Qty,";
                    SqlQuery += Environment.NewLine + "CAST(ROUND(SUM([Qty] * [PurAmount]), 2) AS NUMERIC(12,2)) AS PurchaseAmount, SUM([TotAmount]) AS SellingAmount, SUM([ProfitAmount]) AS AproxProfitAmount";
                    SqlQuery += Environment.NewLine + "FROM [Sales] AS S";
                    SqlQuery += Environment.NewLine + "LEFT JOIN [Product] AS P ON P.[Code] = S.[ProductCode]";
                    SqlQuery += Environment.NewLine + "LEFT JOIN [Category] AS C ON C.[Code] = P.[CatCode]";
                    SqlQuery += Environment.NewLine + "WHERE 1=1";
                    SqlQuery += Environment.NewLine + "AND BilledDate >= '" + fromDateTime.ToString("dd/MMM/yyyy") + "' AND BilledDate <= '" + toDateTime.ToString("dd/MMM/yyyy") + "'";
                    SqlQuery += Environment.NewLine + "AND ISNULL(BillStatus, '') NOT IN ('C', 'D')";
                    if (ProductCode > 0)
                        SqlQuery += Environment.NewLine + "and S.[ProductCode] = " + ProductCode + "";

                    if (CategoryCode > 0)
                        SqlQuery += Environment.NewLine + "and P.[CatCode] = " + CategoryCode + "";
                    SqlQuery += Environment.NewLine + "GROUP BY S.ProductCode, P.[Name], P.[QtyTypeCode]";
                    SqlQuery += Environment.NewLine + "ORDER BY S.ProductCode, P.[Name]";
                }
                else if (ReportType == 9)
                {
                    SqlQuery = "SELECT ROW_NUMBER() OVER (ORDER BY B.[VendorCode]) AS SNo, B.[VendorCode], V.[Name] AS VendorName, SUM(B.[BillAmount]) AS BillAmount, SUM(B.[AmountPaid]) AS AmountPaid,";
                    SqlQuery += Environment.NewLine + "SUM(B.[BillAmount]) - SUM(B.[AmountPaid]) AS PendingAmount";
                    SqlQuery += Environment.NewLine + "FROM [VendorBillDetails] AS B";
                    SqlQuery += Environment.NewLine + "LEFT JOIN [Vendor] AS V ON V.[Code] = B.[VendorCode]";
                    SqlQuery += Environment.NewLine + "WHERE BillAmount > AmountPaid";
                    SqlQuery += Environment.NewLine + "GROUP BY B.[VendorCode], V.[Name]";
                }
                else if (ReportType == 10)
                {
                    SqlQuery = "SELECT ROW_NUMBER() OVER (ORDER BY EM.[Name]) AS SNo, EM.[Name] AS ExpenseDetails, SUM(E.[Amount]) AS TotalAmount";
                    SqlQuery += Environment.NewLine + "FROM [Expenses] AS E";
                    SqlQuery += Environment.NewLine + "LEFT JOIN [ExpenseMaster] AS EM ON E.[ExpenseCode] = EM.[Code]";
                    SqlQuery += Environment.NewLine + "WHERE 1=1";
                    SqlQuery += Environment.NewLine + "AND E.[TranDate] >= '" + fromDateTime.ToString("dd/MMM/yyyy") + "' AND E.[TranDate] <= '" + toDateTime.ToString("dd/MMM/yyyy") + "'";
                    SqlQuery += Environment.NewLine + "GROUP BY EM.[Name]";
                    SqlQuery += Environment.NewLine + "ORDER BY EM.[Name]";
                }
                
                SqlIntract _SqlIntract = new SqlIntract();

                this.ReportData = new DataTable();
                this.ReportData = _SqlIntract.ExecuteDataTable(SqlQuery, CommandType.Text, null);
            }
            catch
            {
                throw;
            }
        }

        private DataTable _CategoryMaster = new DataTable();
        private DataTable _QuantityMaster = new DataTable();
        private DataTable _ProductMaster = new DataTable();
        private DataTable _ReportType = new DataTable();

        internal DataTable CategoryMaster
        {
            get { return _CategoryMaster; }
            set { _CategoryMaster = value; }
        }
        internal DataTable QuantityMaster
        {
            get { return _QuantityMaster; }
            set { _QuantityMaster = value; }
        }
        internal DataTable ProductMaster
        {
            get { return _ProductMaster; }
            set { _ProductMaster = value; }
        }
        internal DataTable ReportType
        {
            get { return _ReportType; }
            set { _ReportType = value; }
        }

        internal void GetMasterData()
        {
            try
            {
                Master _Master = new Master();
                this._CategoryMaster = _Master.GetCategoryMaster();
                this._QuantityMaster = _Master.GetQuantityMaster();
                this._ProductMaster = _Master.GetProductMaster();


                DataTable _DataTable = new DataTable();
                _DataTable.Columns.Add(new DataColumn("Code", typeof(string)));
                _DataTable.Columns.Add(new DataColumn("Name", typeof(string)));

                DataRow _DataRow = _DataTable.NewRow();
                _DataRow["Code"] = "1"; _DataRow["Name"] = "Product Wise - Purchase Report";
                _DataTable.Rows.Add(_DataRow);

                _DataRow = _DataTable.NewRow();
                _DataRow["Code"] = "2"; _DataRow["Name"] = "Product Wise - Purchase Cummulaive Report";
                _DataTable.Rows.Add(_DataRow);

                _DataRow = _DataTable.NewRow();
                _DataRow["Code"] = "3"; _DataRow["Name"] = "Product Wise - Sales Report";
                _DataTable.Rows.Add(_DataRow);

                _DataRow = _DataTable.NewRow();
                _DataRow["Code"] = "4"; _DataRow["Name"] = "Product Wise - Profit Loss Report";
                _DataTable.Rows.Add(_DataRow);

                _DataRow = _DataTable.NewRow();
                _DataRow["Code"] = "5"; _DataRow["Name"] = "Customer Due - Report";
                _DataTable.Rows.Add(_DataRow);

                if (Global.currentUserId == 1 || Global.currentUserId == 2) // Only Admin User can see this Report
                {
                    _DataRow = _DataTable.NewRow();
                    _DataRow["Code"] = "6"; _DataRow["Name"] = "Aprox Profit - Report";
                    _DataTable.Rows.Add(_DataRow);

                    _DataRow = _DataTable.NewRow();
                    _DataRow["Code"] = "7"; _DataRow["Name"] = "Category Wise - Aprox Profit - Report";
                    _DataTable.Rows.Add(_DataRow);

                    _DataRow = _DataTable.NewRow();
                    _DataRow["Code"] = "8"; _DataRow["Name"] = "Product Wise - Aprox Profit - Report";
                    _DataTable.Rows.Add(_DataRow);
                }

                _DataRow = _DataTable.NewRow();
                _DataRow["Code"] = "9"; _DataRow["Name"] = "Vendor - Amount Pending - Report";
                _DataTable.Rows.Add(_DataRow);

                _DataRow = _DataTable.NewRow();
                _DataRow["Code"] = "10"; _DataRow["Name"] = "Expenses - Report";
                _DataTable.Rows.Add(_DataRow);

                this._ReportType = _DataTable;
            }
            catch
            {
                throw;
            }
        }

    }
}
