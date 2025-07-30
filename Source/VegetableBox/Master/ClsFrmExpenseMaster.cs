using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace VegetableBox
{
    internal class ClsFrmExpenseMaster
    {
        #region "Master"

        private DataTable _YesNoMaster = new DataTable();

        internal DataTable YesNoMaster
        {
            get { return _YesNoMaster; }
            set { _YesNoMaster = value; }
        }

        internal void GetMasterData()
        {
            try
            {
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

        #endregion

        #region "Save & View & Update"

        private int _Code = 0;
        private string _Name = string.Empty;
        private string _ActiveStatus = string.Empty;

        internal int Code
        {
            get { return _Code; }
            set { _Code = value; }
        }

        internal string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        internal string Active
        {
            get { return _ActiveStatus; }
            set { _ActiveStatus = value; }
        }

        internal void Save()
        {
            try
            {
                SqlIntract _SqlIntract = new SqlIntract();

                String SqlQuery = "SpSaveExpenseMaster";

                List<SqlParameter>? _ListSqlParameter = new List<SqlParameter>();
                _ListSqlParameter.Add(new SqlParameter("@Name", this.Name));
                _ListSqlParameter.Add(new SqlParameter("@Active", this.Active));
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

                String SqlQuery = "SpUpdateExpenseMaster";

                List<SqlParameter>? _ListSqlParameter = new List<SqlParameter>();
                _ListSqlParameter.Add(new SqlParameter("@Code", this.Code));
                _ListSqlParameter.Add(new SqlParameter("@Name", this.Name));
                _ListSqlParameter.Add(new SqlParameter("@Active", this.Active));
                _ListSqlParameter.Add(new SqlParameter("@LastUpdatedBy", Global.currentUserId));

                int Result = _SqlIntract.ExecuteNonQuery(SqlQuery, CommandType.StoredProcedure, _ListSqlParameter);
            }
            catch
            {
                throw;
            }
        }

        private DataTable _VendorMaster = new DataTable();
        internal DataTable VendorMaster
        {
            get { return _VendorMaster; }
            set { _VendorMaster = value; }
        }

        internal void View()
        {
            try
            {

                SqlIntract _SqlIntract = new SqlIntract();

                String SqlQuery = "SpGetExpenseMaster";

                _VendorMaster = new DataTable();
                _VendorMaster = _SqlIntract.ExecuteDataTable(SqlQuery, CommandType.Text, null);
            }
            catch
            {
                throw;
            }
        }

        internal int GetRecordCount()
        {
            try
            {
                SqlIntract _SqlIntract = new SqlIntract();

                String SqlQuery = "SELECT COUNT(*) AS RecordCount FROM [dbo].[ExpenseMaster] WHERE [Name] = @Name";

                List<SqlParameter>? _ListSqlParameter = new List<SqlParameter>();
                _ListSqlParameter.Add(new SqlParameter("@Name", this.Name));

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
