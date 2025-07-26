using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegetableBox
{
    internal class ClsFrmPurchaseEntry
    {
        private DataTable _ProductData = new DataTable();
        private DataTable _CategoryMaster = new DataTable();
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

        public ClsFrmPurchaseEntry()
        {
            try
            {
                this.GetProductDetails();
                this.ToMakePurchaseCart();  
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

        private void ToMakePurchaseCart()
        {
            try
            {
                this._PurchaseCartData = new DataTable();

                this._PurchaseCartData.Columns.Add(PurchaseCartDataStruct.ColumnName.SNo, typeof(int));
                this._PurchaseCartData.Columns.Add(PurchaseCartDataStruct.ColumnName.ProCode, typeof(int));
                this._PurchaseCartData.Columns.Add(PurchaseCartDataStruct.ColumnName.ProName, typeof(string));
                this._PurchaseCartData.Columns.Add(PurchaseCartDataStruct.ColumnName.ProTamilName, typeof(string));
                this._PurchaseCartData.Columns.Add(PurchaseCartDataStruct.ColumnName.TotalPurchaseQty, typeof(decimal));
                this._PurchaseCartData.Columns.Add(PurchaseCartDataStruct.ColumnName.Unit, typeof(string));
                this._PurchaseCartData.Columns.Add(PurchaseCartDataStruct.ColumnName.TotalPurchaseAmount, typeof(decimal));
                this._PurchaseCartData.Columns.Add(PurchaseCartDataStruct.ColumnName.PurchaseRatePerQty, typeof(decimal));

                this._PurchaseCartData.Columns.Add(PurchaseCartDataStruct.ColumnName.MRP, typeof(decimal));
                this._PurchaseCartData.Columns.Add(PurchaseCartDataStruct.ColumnName.SellRatePerQty, typeof(decimal));
                this._PurchaseCartData.Columns.Add(PurchaseCartDataStruct.ColumnName.SellingMarginPer, typeof(decimal));
                this._PurchaseCartData.Columns.Add(PurchaseCartDataStruct.ColumnName.DiscPer, typeof(decimal));
                this._PurchaseCartData.Columns.Add(PurchaseCartDataStruct.ColumnName.DiscRate, typeof(decimal));
            }
            catch
            {
                throw;
            }
        }

        public int SaveData(DataTable purchaseCartData, decimal totalPurchaseAmount)
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

                //SalesTableData = SalesTableData.AsEnumerable().OrderBy(x => x.Field<int>(CartDataStruct.ColumnName.SNo)).CopyToDataTable();
                PurchaseTableData.AcceptChanges();

                SqlIntract _SqlIntract = new SqlIntract();

                String SqlQuery = "SpSavePurchase";

                List<SqlParameter>? _ListSqlParameter = new List<SqlParameter>();
                _ListSqlParameter.Add(new SqlParameter("@UDT_Purchase", PurchaseTableData));
                _ListSqlParameter.Add(new SqlParameter("@TotPurAmount", totalPurchaseAmount));

                SqlParameter sqlParameter = new SqlParameter("@BILLNO", SqlDbType.Int, 8);
                sqlParameter.Direction = ParameterDirection.Output;
                _ListSqlParameter.Add(sqlParameter);

                int Result = Convert.ToInt32(_SqlIntract.ExecuteNonQueryWithOutputParam(SqlQuery, CommandType.StoredProcedure, "@BILLNO", _ListSqlParameter));

                return Result;
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
