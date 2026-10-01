using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegetableBox
{
    internal class ClsFrmPriceUpdate
    {
        private DataTable _ProductRateData = new DataTable();
        private DataTable _CategoryMaster = new DataTable();

        internal DataTable ProductRateData
        {
            get { return _ProductRateData; }
            set { _ProductRateData = value; }
        }

        internal DataTable CategoryMaster
        {
            get { return _CategoryMaster; }
            set { _CategoryMaster = value; }
        }

        public ClsFrmPriceUpdate()
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

                String SqlQuery = "SpGetProductRate";

                this._ProductRateData = new DataTable();
                this._ProductRateData = _SqlIntract.ExecuteDataTable(SqlQuery, CommandType.Text, null);
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

        public bool UpdateRateMaster(decimal buyRate, decimal mrp, decimal sellMarginPercentage, decimal sellRate, int productCode)
        {
            try
            {
                SqlIntract _SqlIntract = new SqlIntract();

                String SqlQuery = "UPDATE [dbo].[RateMaster] SET BuyRate = @BuyRate, MRP = @MRP, SellMarginPercentage = @SellMarginPercentage,";
                SqlQuery += Environment.NewLine + "SellRate = @SellRate, CreatedBy = @CreatedBy, CreatedDateTime = GETDATE()";
                SqlQuery += Environment.NewLine + "WHERE ProductCode = @ProductCode";

                List<SqlParameter>? _ListSqlParameter = new List<SqlParameter>();
                _ListSqlParameter.Add(new SqlParameter("@BuyRate", buyRate));
                _ListSqlParameter.Add(new SqlParameter("@MRP", mrp));
                _ListSqlParameter.Add(new SqlParameter("@SellMarginPercentage", sellMarginPercentage));
                _ListSqlParameter.Add(new SqlParameter("@SellRate", sellRate));
                _ListSqlParameter.Add(new SqlParameter("@CreatedBy", Global.currentUserId));
                _ListSqlParameter.Add(new SqlParameter("@ProductCode", productCode));

                _SqlIntract.ExecuteNonQuery(SqlQuery, CommandType.Text, _ListSqlParameter);

                return true;
            }
            catch
            {
                throw;
            }
        }

        public bool UpdateStockRate(decimal purRate, decimal mrp, decimal sellRate, decimal sellingMarginPer,  
                                    decimal discPer, decimal discRate, int productCode, decimal curMrp, decimal curSellRate)
        {
            try
            {
                SqlIntract _SqlIntract = new SqlIntract();

                String SqlQuery = "UPDATE [dbo].[Stock] SET PurRate = @PurRate, MRP = @MRP, SellRate = @SellRate, SellingMarginPer = @SellingMarginPer,";
                SqlQuery += Environment.NewLine + "DiscPer = @DiscPer, DiscRate = @DiscRate, LastUpdatedBy = @LastUpdatedBy, LastUpdatedDate = GETDATE(),";
                SqlQuery += Environment.NewLine + "LastUpdatedDateTime = GETDATE()";
                SqlQuery += Environment.NewLine + "WHERE ProductCode = @ProductCode AND MRP = @CurMRP AND SellRate = @CurSellRate";

                List<SqlParameter>? _ListSqlParameter = new List<SqlParameter>();
                _ListSqlParameter.Add(new SqlParameter("@PurRate", purRate));
                _ListSqlParameter.Add(new SqlParameter("@MRP", mrp));
                _ListSqlParameter.Add(new SqlParameter("@SellRate", sellRate));
                _ListSqlParameter.Add(new SqlParameter("@SellingMarginPer", sellingMarginPer));
                _ListSqlParameter.Add(new SqlParameter("@DiscPer", discPer));
                _ListSqlParameter.Add(new SqlParameter("@DiscRate", discRate));
                _ListSqlParameter.Add(new SqlParameter("@LastUpdatedBy", Global.currentUserId));
                _ListSqlParameter.Add(new SqlParameter("@ProductCode", productCode));
                _ListSqlParameter.Add(new SqlParameter("@CurMRP", curMrp));
                _ListSqlParameter.Add(new SqlParameter("@CurSellRate", curSellRate));

                _SqlIntract.ExecuteNonQuery(SqlQuery, CommandType.Text, _ListSqlParameter);

                return true;
            }
            catch
            {
                throw;
            }
        }

    }

}
