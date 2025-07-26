using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegetableBox
{
    internal class ClsFrmRateMaster
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

                DataTable _DataTable = new DataTable();
                _DataTable.Columns.Add(new DataColumn("Code", typeof(string)));
                _DataTable.Columns.Add(new DataColumn("Name", typeof(string)));

                DataRow _DataRow = _DataTable.NewRow();
                _DataRow["Code"] = "Y"; _DataRow["Name"] = "Yes";
                _DataTable.Rows.Add(_DataRow);

                _DataRow = _DataTable.NewRow();
                _DataRow["Code"] = "N"; _DataRow["Name"] = "No";
                _DataTable.Rows.Add(_DataRow);

                this._YesNoMaster = _DataTable;
            }
            catch
            {
                throw;
            }
        }

        private DataTable _RateMaster = new DataTable();
        internal DataTable RateMaster
        {
            get { return _RateMaster; }
            set { _RateMaster = value; }
        }

        internal void View()
        {
            try
            {

                SqlIntract _SqlIntract = new SqlIntract();

                String SqlQuery = "SpGetRateMaster";

                _RateMaster = new DataTable();
                _RateMaster = _SqlIntract.ExecuteDataTable(SqlQuery, CommandType.Text, null);
            }
            catch
            {
                throw;
            }
        }

        internal void Save(DataTable dtSave)
        {
            try
            {
                SqlIntract _SqlIntract = new SqlIntract();

                String SqlQuery = "SpSaveRateMaster";

                List<SqlParameter>? _ListSqlParameter = new List<SqlParameter>();
                _ListSqlParameter.Add(new SqlParameter("@UDT_RateMaster", dtSave));

                int Result = _SqlIntract.ExecuteNonQuery(SqlQuery, CommandType.StoredProcedure, _ListSqlParameter);
            }
            catch
            {
                throw;
            }
        }

        #endregion

    }
}
