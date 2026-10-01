using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegetableBox
{
    internal class ClsFrmStockMRPCleanup
    {
        private DataTable _ProductRateData = new DataTable();

        internal DataTable ProductRateData
        {
            get { return _ProductRateData; }
            set { _ProductRateData = value; }
        }

        public ClsFrmStockMRPCleanup()
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

        private void GetProductDetails()
        {
            try
            {
                SqlIntract _SqlIntract = new SqlIntract();

                String SqlQuery = " SELECT CAST(P.[Code] AS VARCHAR) AS ProductCode, P.[Name] AS ProductName, P.[TamilName] AS ProductTName,";
                SqlQuery += Environment.NewLine + "P.[AlternativeName] AS ProductAltrName, P.[CatCode], P.[QtyTypeCode], P.[CalcBasedRateMast], Q.ShortName AS Qty,";
                SqlQuery += Environment.NewLine + "CAST(P.[Code] AS VARCHAR) + ' - ' + P.[Name] + ' - MRP: ' + CAST(S.[MRP] AS VARCHAR) AS SearchName,";
                SqlQuery += Environment.NewLine + "(CASE WHEN ISNULL(P.BarCode, '') = '' THEN 'B' + REPLICATE('0', 5 - LEN(RTRIM(CAST(P.[Code] AS VARCHAR)))) +  RTRIM(CAST(P.[Code] AS VARCHAR)) ELSE P.BarCode END ) AS BarCode,";
                SqlQuery += Environment.NewLine + "S.PurRate, S.MRP, S.SellRate, P.[AllowRateChange], ISNULL(P.[BarCode2], '') AS BarCode2, ISNULL(P.[BarCode3], '') AS BarCode3, ISNULL(P.[BarCode4], '') AS BarCode4,";
                SqlQuery += Environment.NewLine + "P.[MaintainStock], S.[StockQty]";
                SqlQuery += Environment.NewLine + "FROM [Product] AS P"; 
                SqlQuery += Environment.NewLine + "INNER JOIN [Stock] AS S On P.[Code] = S.ProductCode";
                SqlQuery += Environment.NewLine + "INNER JOIN [Quantity] AS Q ON P.QtyTypeCode = Q.Code";
                SqlQuery += Environment.NewLine + "WHERE 1=1";
                SqlQuery += Environment.NewLine + "AND ISNULL(P.CalcBasedRateMast,'') != 'Y'";
                SqlQuery += Environment.NewLine + "AND ISNULL(P.Active,'') = 'Y'";

                this._ProductRateData = new DataTable();
                this._ProductRateData = _SqlIntract.ExecuteDataTable(SqlQuery, CommandType.Text, null);
            }
            catch
            {
                throw;
            }
        }

        public bool Delete(int productCode, decimal mrp)
        {
            try
            {
                SqlIntract _SqlIntract = new SqlIntract();

                String SqlQuery = "SpStockLogAndDelete";

                List<SqlParameter>? _ListSqlParameter = new List<SqlParameter>();
                _ListSqlParameter.Add(new SqlParameter("@ProductCode", productCode));
                _ListSqlParameter.Add(new SqlParameter("@MRP", mrp));
                _ListSqlParameter.Add(new SqlParameter("@DeletedBy", Global.currentUserId));
                
                _SqlIntract.ExecuteNonQuery(SqlQuery, CommandType.StoredProcedure, _ListSqlParameter);

                return true;
            }
            catch
            {
                throw;
            }
        }

    }

}
