using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace VegetableBox
{
    internal class ClsFrmProduct
    {
        #region "Master"

        private DataTable _CategoryMaster = new DataTable();
        private DataTable _QuantityMaster = new DataTable();
        private DataTable _YesNoMaster = new DataTable();

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
        internal DataTable YesNoMaster
        {
            get { return _YesNoMaster; }
            set { _YesNoMaster = value; }
        }

        internal void GetMasterData()
        {
            try
            {
                Master _Master = new Master();
                this._CategoryMaster = _Master.GetCategoryMaster();
                this._QuantityMaster = _Master.GetQuantityMaster();
                this._YesNoMaster = _Master.GetYesNoMaster();
            }
            catch
            {
                throw;
            }
        }

        #endregion

        #region "Save & View & Update"

        private int _ProductCode = 0;
        private string _ProductName = string.Empty;
        private string _ProductTamilName = string.Empty;
        private string _ProductAlternateName = string.Empty;
        private int _CategoryTypeCode = 0;
        private int _QuantityTypeCode = 0;
        private string _CalcBasedOnRateMaster = string.Empty;
        private string _AllowRateChange = string.Empty;
        private string _BarCode = string.Empty;
        private string _BarCode2 = string.Empty;
        private string _BarCode3 = string.Empty;
        private string _BarCode4 = string.Empty;
        private string _ActiveStatus = string.Empty;

        internal int ProductCode
        {
            get { return _ProductCode; }
            set { _ProductCode = value; }
        }

        internal string ProductName
        {
            get { return _ProductName; }
            set { _ProductName = value; }
        }

        internal string ProductTamilName
        {
            get { return _ProductTamilName; }
            set { _ProductTamilName = value; }
        }

        internal string ProductAlternateName
        {
            get { return _ProductAlternateName; }
            set { _ProductAlternateName = value; }
        }

        internal int CategoryTypeCode
        {
            get { return _CategoryTypeCode; }
            set { _CategoryTypeCode = value; }
        }

        internal int QuantityTypeCode
        {
            get { return _QuantityTypeCode; }
            set { _QuantityTypeCode = value; }
        }

        internal string CalcBasedOnRateMaster
        {
            get { return _CalcBasedOnRateMaster; }
            set { _CalcBasedOnRateMaster = value; }
        }
        internal string AllowRateChange
        {
            get { return _AllowRateChange; }
            set { _AllowRateChange = value; }
        }

        internal string BarCode
        {
            get { return _BarCode; }
            set { _BarCode = value; }
        }

        internal string BarCode2
        {
            get { return _BarCode2; }
            set { _BarCode2 = value; }
        }

        internal string BarCode3
        {
            get { return _BarCode3; }
            set { _BarCode3 = value; }
        }

        internal string BarCode4
        {
            get { return _BarCode4; }
            set { _BarCode4 = value; }
        }

        internal string ActiveStatus
        {
            get { return _ActiveStatus; }
            set { _ActiveStatus = value; }
        }

        internal void Save()
        {
            try
            {
                SqlIntract _SqlIntract = new SqlIntract();

                String SqlQuery = "SpSaveProduct";

                List<SqlParameter>? _ListSqlParameter = new List<SqlParameter>();
                _ListSqlParameter.Add(new SqlParameter("@Name", this.ProductName));
                _ListSqlParameter.Add(new SqlParameter("@TamilName", this.ProductTamilName));
                _ListSqlParameter.Add(new SqlParameter("@AlternativeName", this.ProductAlternateName));
                _ListSqlParameter.Add(new SqlParameter("@CatCode", this.CategoryTypeCode));
                _ListSqlParameter.Add(new SqlParameter("@QtyTypeCode", this.QuantityTypeCode));
                _ListSqlParameter.Add(new SqlParameter("@CalcBasedRateMast", this.CalcBasedOnRateMaster));
                _ListSqlParameter.Add(new SqlParameter("@AllowRateChange", this.AllowRateChange));                
                _ListSqlParameter.Add(new SqlParameter("@BarCode", this.BarCode));
                _ListSqlParameter.Add(new SqlParameter("@BarCode2", this.BarCode2));
                _ListSqlParameter.Add(new SqlParameter("@BarCode3", this.BarCode3));
                _ListSqlParameter.Add(new SqlParameter("@BarCode4", this.BarCode4));
                _ListSqlParameter.Add(new SqlParameter("@Active", this.ActiveStatus));
                _ListSqlParameter.Add(new SqlParameter("@CreatedBy", Global.currentUserId));
                _ListSqlParameter.Add(new SqlParameter("@LastUpdatedBy", Global.currentUserId));

                int Result = _SqlIntract.ExecuteNonQuery(SqlQuery, CommandType.StoredProcedure, _ListSqlParameter);
            }
            catch
            {
                throw;
            }
        }

        internal void Update()
        {
            try
            {
                SqlIntract _SqlIntract = new SqlIntract();

                String SqlQuery = "SpUpdateProduct";

                List<SqlParameter>? _ListSqlParameter = new List<SqlParameter>();
                _ListSqlParameter.Add(new SqlParameter("@Code", this.ProductCode));
                _ListSqlParameter.Add(new SqlParameter("@Name", this.ProductName));
                _ListSqlParameter.Add(new SqlParameter("@TamilName", this.ProductTamilName));
                _ListSqlParameter.Add(new SqlParameter("@AlternativeName", this.ProductAlternateName));
                _ListSqlParameter.Add(new SqlParameter("@CatCode", this.CategoryTypeCode));
                _ListSqlParameter.Add(new SqlParameter("@QtyTypeCode", this.QuantityTypeCode));
                _ListSqlParameter.Add(new SqlParameter("@CalcBasedRateMast", this.CalcBasedOnRateMaster));
                _ListSqlParameter.Add(new SqlParameter("@AllowRateChange", this.AllowRateChange));
                _ListSqlParameter.Add(new SqlParameter("@BarCode", this.BarCode));
                _ListSqlParameter.Add(new SqlParameter("@BarCode2", this.BarCode2));
                _ListSqlParameter.Add(new SqlParameter("@BarCode3", this.BarCode3));
                _ListSqlParameter.Add(new SqlParameter("@BarCode4", this.BarCode4));
                _ListSqlParameter.Add(new SqlParameter("@Active", this.ActiveStatus));
                _ListSqlParameter.Add(new SqlParameter("@LastUpdatedBy", Global.currentUserId));

                int Result = _SqlIntract.ExecuteNonQuery(SqlQuery, CommandType.StoredProcedure, _ListSqlParameter);
            }
            catch
            {
                throw;
            }
        }

        private DataTable _ProductMaster = new DataTable();
        internal DataTable ProductMaster
        {
            get { return _ProductMaster; }
            set { _ProductMaster = value; }
        }

        internal void View()
        {
            try
            {

                SqlIntract _SqlIntract = new SqlIntract();

                String SqlQuery = "SpGetProduct";

                _ProductMaster = new DataTable();
                _ProductMaster = _SqlIntract.ExecuteDataTable(SqlQuery, CommandType.Text, null);
            }
            catch
            {
                throw;
            }
        }

        internal int GetProductRecordCount()
        {
            try
            {
                SqlIntract _SqlIntract = new SqlIntract();

                String SqlQuery = "SELECT COUNT(*) AS RecordCount FROM [dbo].[Product] WHERE ([Name] = @Name OR [TamilName] = @TamilName) AND [Code] != @Code";

                List<SqlParameter>? _ListSqlParameter = new List<SqlParameter>();
                _ListSqlParameter.Add(new SqlParameter("@Name", this.ProductName));
                _ListSqlParameter.Add(new SqlParameter("@TamilName", this.ProductTamilName));
                _ListSqlParameter.Add(new SqlParameter("@Code", this.ProductCode));

                int Result = (int)_SqlIntract.ExecuteScalar(SqlQuery, CommandType.Text, _ListSqlParameter);

                return Result;
            }
            catch
            {
                throw;
            }
        }

        #endregion

    }
}
