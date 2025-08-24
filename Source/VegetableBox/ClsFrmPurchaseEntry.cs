using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace VegetableBox
{
    internal class ClsFrmPurchaseEntry
    {
        private DataTable _ProductData = new DataTable();
        private DataTable _CategoryMaster = new DataTable();
        private DataTable _VendorMaster = new DataTable();

        internal DataTable ProductData
        {
            get { return _ProductData; }
            set { _ProductData = value; }
        }

        internal DataTable CategoryMaster
        {
            get { return _CategoryMaster; }
            set { _CategoryMaster = value; }
        }

        internal DataTable VendorMaster
        {
            get { return _VendorMaster; }
            set { _VendorMaster = value; }
        }

        public ClsFrmPurchaseEntry()
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

        internal void GetMasterData()
        {
            try
            {
                Master _Master = new Master();
                this._CategoryMaster = _Master.GetCategoryMaster();
                this._VendorMaster = _Master.GetVendorMaster();
            }
            catch
            {
                throw;
            }
        }

        public int SaveData(DataTable purchaseCartData, decimal totalPurchaseAmount, int vendorBillRefNo, int vendorCode, int oldTranNo)
        {
            try
            {
                DataTable PurchaseTableData = new DataTable();
                PurchaseTableData.Columns.Add("ProductCode", typeof(int));
                PurchaseTableData.Columns.Add("TotPurQty", typeof(decimal));
                PurchaseTableData.Columns.Add("Unit", typeof(string));
                PurchaseTableData.Columns.Add("TotPurAmount", typeof(decimal));
                PurchaseTableData.Columns.Add("PurRatePerQty", typeof(decimal));
                PurchaseTableData.Columns.Add("SellRatePerQty", typeof(decimal));

                PurchaseTableData.Columns.Add("MRP", typeof(decimal));
                PurchaseTableData.Columns.Add("SellingMarginPer", typeof(decimal));
                PurchaseTableData.Columns.Add("DiscPer", typeof(decimal));
                PurchaseTableData.Columns.Add("DiscRate", typeof(decimal));

                PurchaseTableData.Columns.Add("BilledBy", typeof(int));

                foreach (DataRow rowCartData in purchaseCartData.Rows)
                {
                    var savedflag = rowCartData[PurchaseCartDataStruct.ColumnName.IsSaved]?.ToString();
                    if (savedflag == "N")
                    {
                        DataRow rowSales = PurchaseTableData.NewRow();

                        rowSales["ProductCode"] = rowCartData[PurchaseCartDataStruct.ColumnName.ProCode];
                        rowSales["TotPurQty"] = rowCartData[PurchaseCartDataStruct.ColumnName.TotalPurchaseQty];
                        rowSales["Unit"] = rowCartData[PurchaseCartDataStruct.ColumnName.Unit];
                        rowSales["TotPurAmount"] = rowCartData[PurchaseCartDataStruct.ColumnName.TotalPurchaseAmount];
                        rowSales["PurRatePerQty"] = rowCartData[PurchaseCartDataStruct.ColumnName.PurchaseRatePerQty];
                        rowSales["SellRatePerQty"] = rowCartData[PurchaseCartDataStruct.ColumnName.SellRatePerQty];

                        rowSales["MRP"] = (String.IsNullOrEmpty(rowCartData[PurchaseCartDataStruct.ColumnName.MRP].ToString())) ?
                            "0.00" : rowCartData[PurchaseCartDataStruct.ColumnName.MRP].ToString();

                        rowSales["SellingMarginPer"] = (String.IsNullOrEmpty(rowCartData[PurchaseCartDataStruct.ColumnName.SellingMarginPer].ToString())) ?
                            "0.00" : rowCartData[PurchaseCartDataStruct.ColumnName.SellingMarginPer].ToString();

                        rowSales["SellingMarginPer"] = (String.IsNullOrEmpty(rowCartData[PurchaseCartDataStruct.ColumnName.SellingMarginPer].ToString())) ?
                            "0.00" : rowCartData[PurchaseCartDataStruct.ColumnName.SellingMarginPer].ToString();

                        rowSales["DiscPer"] = (String.IsNullOrEmpty(rowCartData[PurchaseCartDataStruct.ColumnName.DiscPer].ToString())) ?
                            "0.00" : rowCartData[PurchaseCartDataStruct.ColumnName.DiscPer].ToString();

                        rowSales["DiscRate"] = (String.IsNullOrEmpty(rowCartData[PurchaseCartDataStruct.ColumnName.DiscRate].ToString())) ?
                            "0.00" : rowCartData[PurchaseCartDataStruct.ColumnName.DiscRate].ToString();

                        rowSales["BilledBy"] = Global.currentUserId;

                        PurchaseTableData.Rows.Add(rowSales);
                    }
                }

                //SalesTableData = SalesTableData.AsEnumerable().OrderBy(x => x.Field<int>(CartDataStruct.ColumnName.SNo)).CopyToDataTable();
                PurchaseTableData.AcceptChanges();

                SqlIntract _SqlIntract = new SqlIntract();

                String SqlQuery = "SpSavePurchase";

                List<SqlParameter>? _ListSqlParameter = new List<SqlParameter>();
                _ListSqlParameter.Add(new SqlParameter("@UDT_Purchase", PurchaseTableData));
                _ListSqlParameter.Add(new SqlParameter("@TotPurAmount", totalPurchaseAmount));
                _ListSqlParameter.Add(new SqlParameter("@VendorBillRefNo", vendorBillRefNo));
                _ListSqlParameter.Add(new SqlParameter("@VendorCode", vendorCode));
                _ListSqlParameter.Add(new SqlParameter("@OldTranNo", oldTranNo));

                SqlParameter sqlParameter = new SqlParameter("@TranNo", SqlDbType.Int, 8);
                sqlParameter.Direction = ParameterDirection.Output;
                _ListSqlParameter.Add(sqlParameter);

                int Result = Convert.ToInt32(_SqlIntract.ExecuteNonQueryWithOutputParam(SqlQuery, CommandType.StoredProcedure, "@TranNo", _ListSqlParameter));

                return Result;
            }
            catch
            {
                throw;
            }
        }

        private DataTable _VendorPurBillDetailsData = new DataTable();
        internal DataTable VendorPurBillDetailsData
        {
            get { return _VendorPurBillDetailsData; }
            set { _VendorPurBillDetailsData = value; }
        }

        internal void GetVendorBillDetails()
        {
            try
            {
                SqlIntract _SqlIntract = new SqlIntract();
                
                string SqlQuery = "SELECT TranNo, VendorCode, BillNo, BillDate, BillAmount, ItemsCount,";
                SqlQuery += Environment.NewLine + "P.[Name] AS PurchaseEntryStatus, PurchaseEntryStatus AS PurchaseEntryStatusCode";
                SqlQuery += Environment.NewLine + "FROM [VendorBillDetails] AS V";
                SqlQuery += Environment.NewLine + "LEFT JOIN [ProgressStatusMaster] AS P ON P.Code = V.PurchaseEntryStatus";
                SqlQuery += Environment.NewLine + "WHERE PurchaseEntryStatus != 'C'";

                _VendorPurBillDetailsData = _SqlIntract.ExecuteDataTable(SqlQuery, CommandType.Text, null);
            }
            catch
            {
                throw;
            }
        }

        private DataTable _PurchaseCartData = new DataTable();
        internal DataTable PurchaseCartData
        {
            get { return _PurchaseCartData; }
            set { _PurchaseCartData = value; }
        }

        internal void GetEnteredPurchaseItems(int vendorBillRefNo)
        {
            try
            {
                SqlIntract _SqlIntract = new SqlIntract();

                string SqlQuery = "SELECT CAST(ROW_NUMBER() OVER (ORDER BY P.[SNo] DESC) AS INT) AS SNo, P.[ProductCode] AS ProCode,";
                SqlQuery += Environment.NewLine + "PR.[Name] AS ProductName, PR.[TamilName] AS ProductTamilName, [TotPurQty], [Unit],";
                SqlQuery += Environment.NewLine + "[PurRatePerQty], [MRP], [SellRatePerQty], [SellingMarginPer],";
                SqlQuery += Environment.NewLine + "[DiscPer], [DiscRate], [TotPurAmount], [EnteredBy] AS BilledBy, 'Y' AS IsSaved, TranNo";
                SqlQuery += Environment.NewLine + "FROM [Purchase] AS P";
                SqlQuery += Environment.NewLine + "INNER JOIN [Product] AS PR ON PR.[Code] = P.[ProductCode]";
                SqlQuery += Environment.NewLine + "WHERE ISNULL(VendorBillRefNo, 0) = " + vendorBillRefNo;
                SqlQuery += Environment.NewLine + "ORDER BY SNo DESC";

                _PurchaseCartData = _SqlIntract.ExecuteDataTable(SqlQuery, CommandType.Text, null);
            }
            catch
            {
                throw;
            }
        }
        
        internal void UpdateBillStatus(int vendorBillRefNo, string progressStatusCode)
        {
            try
            {
                SqlIntract _SqlIntract = new SqlIntract();

                string SqlQuery = "UPDATE [VendorBillDetails] SET [PurchaseEntryStatus] = @PurchaseEntryStatus WHERE [TranNo] = @TranNo";

                List<SqlParameter>? _ListSqlParameter = new List<SqlParameter>();
                _ListSqlParameter.Add(new SqlParameter("@TranNo", vendorBillRefNo));
                _ListSqlParameter.Add(new SqlParameter("@PurchaseEntryStatus", progressStatusCode));

                _PurchaseCartData = _SqlIntract.ExecuteDataTable(SqlQuery, CommandType.Text, _ListSqlParameter);
            }
            catch
            {
                throw;
            }
        }
    }

    #region "Struct"

    internal struct PurchaseCartDataStruct
    {
        internal struct ColumnName
        {
            internal static string SNo = "SNo";
            internal static string ProCode = "ProCode";
            internal static string ProName = "ProductName";
            internal static string ProTamilName = "ProductTamilName";
            internal static string Unit = "Unit";
            internal static string TotalPurchaseQty = "TotPurQty";
            internal static string TotalPurchaseAmount = "TotPurAmount";
            internal static string PurchaseRatePerQty = "PurRatePerQty";
            internal static string SellRatePerQty = "SellRatePerQty";

            internal static string MRP = "MRP";
            internal static string SellingMarginPer = "SellingMarginPer";
            internal static string DiscPer = "DiscPer";
            internal static string DiscRate = "DiscRate";
            internal static string BilledBy = "BilledBy";
            internal static string IsSaved = "IsSaved";
            internal static string TranNo = "TranNo";
        }
    }

    internal struct VendorPurBillDetailsData
    {
        internal struct ColumnName
        {
            internal static string TranNo = "TranNo";
            internal static string VendorCode = "VendorCode";
            internal static string BillNo = "BillNo";
            internal static string BillDate = "BillDate";
            internal static string BillAmount = "BillAmount";
            internal static string ItemsCount = "ItemsCount";
            internal static string PurchaseEntryStatusCode = "PurchaseEntryStatusCode";
            internal static string PurchaseEntryStatus = "PurchaseEntryStatus";
        }
    }

    #endregion
}
