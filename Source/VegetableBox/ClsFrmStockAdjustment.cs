using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace VegetableBox
{
    internal class ClsFrmStockAdjustment
    {
        private DataTable _ReasonMaster = new DataTable();
        private DataTable _ProductRateData = new DataTable();

        internal DataTable ReasonMaster
        {
            get { return _ReasonMaster; }
            set { _ReasonMaster = value; }
        }

        internal DataTable ProductRateData
        {
            get { return _ProductRateData; }
            set { _ProductRateData = value; }
        }

        public ClsFrmStockAdjustment()
        {
            try
            {
                this.GetProductDetails();
                this.GetReasonMaster();
            }
            catch
            {
                throw;
            }
        }

        private void GetReasonMaster()
        {
            try
            {
                SqlIntract _SqlIntract = new SqlIntract();

                String SqlQuery = " SELECT ReasonCode, ReasonName, AdjustmentType";
                SqlQuery += Environment.NewLine + "FROM StockAdjustmentReasonMaster";
                SqlQuery += Environment.NewLine + "WHERE Active = 1";
                SqlQuery += Environment.NewLine + "ORDER BY SNo";

                this._ReasonMaster = new DataTable();
                this._ReasonMaster = _SqlIntract.ExecuteDataTable(SqlQuery, CommandType.Text, null);
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

        public bool Update(int productCode, decimal mrp, decimal sellRate, decimal curStockQty, decimal adjustQty,
             decimal stockQty, string reason)
        {
            try
            {
                SqlIntract _SqlIntract = new SqlIntract();

                String SqlQuery = "SpUpdateStockAdjustment";

                List<SqlParameter>? _ListSqlParameter = new List<SqlParameter>();
                _ListSqlParameter.Add(new SqlParameter("@ProductCode", productCode));
                _ListSqlParameter.Add(new SqlParameter("@MRP", mrp));
                _ListSqlParameter.Add(new SqlParameter("@SellRate", sellRate));
                _ListSqlParameter.Add(new SqlParameter("@CurStockQty", curStockQty));
                _ListSqlParameter.Add(new SqlParameter("@AdjustQty", adjustQty));
                _ListSqlParameter.Add(new SqlParameter("@StockQty", stockQty));
                _ListSqlParameter.Add(new SqlParameter("@Reason", reason));
                _ListSqlParameter.Add(new SqlParameter("@UpdatedBy", Global.currentUserId));
                
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
