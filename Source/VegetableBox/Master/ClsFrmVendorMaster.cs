using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace VegetableBox
{
    internal class ClsFrmVendorMaster
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
                Master _Master = new Master();
                this._YesNoMaster = _Master.GetYesNoMaster();
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
        private string _ShortName = string.Empty;
        private string _MobileNo = string.Empty;
        private string _Address = string.Empty;
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

        internal string ShortName
        {
            get { return _ShortName; }
            set { _ShortName = value; }
        }

        internal string MobileNo
        {
            get { return _MobileNo; }
            set { _MobileNo = value; }
        }

        internal string Address
        {
            get { return _Address; }
            set { _Address = value; }
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

                String SqlQuery = "SpSaveVendor";

                List<SqlParameter>? _ListSqlParameter = new List<SqlParameter>();
                _ListSqlParameter.Add(new SqlParameter("@Name", this.Name));
                _ListSqlParameter.Add(new SqlParameter("@ShortName", this.ShortName));
                _ListSqlParameter.Add(new SqlParameter("@MobileNo", this.MobileNo));
                _ListSqlParameter.Add(new SqlParameter("@Address", this.Address));
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

                String SqlQuery = "SpUpdateVendor";

                List<SqlParameter>? _ListSqlParameter = new List<SqlParameter>();
                _ListSqlParameter.Add(new SqlParameter("@Code", this.Code));
                _ListSqlParameter.Add(new SqlParameter("@Name", this.Name));
                _ListSqlParameter.Add(new SqlParameter("@ShortName", this.ShortName));
                _ListSqlParameter.Add(new SqlParameter("@MobileNo", this.MobileNo));
                _ListSqlParameter.Add(new SqlParameter("@Address", this.Address));
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

                String SqlQuery = "SpGetVendorMaster";

                _VendorMaster = new DataTable();
                _VendorMaster = _SqlIntract.ExecuteDataTable(SqlQuery, CommandType.Text, null);
            }
            catch
            {
                throw;
            }
        }

        #endregion

    }
}
