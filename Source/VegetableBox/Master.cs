using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace VegetableBox
{
    internal class Master
    {
        internal DataTable GetCategoryMaster()
        {
            try
            {
                DataTable _Result = new DataTable();
                String _SqlQuery = "Select Code, [Name] From [Category] Where Isnull(Active,'') = 'Y'";

                SqlIntract _SqlIntract = new SqlIntract();
                _Result = _SqlIntract.ExecuteDataTable(_SqlQuery, CommandType.Text, null);

                return _Result;
            }
            catch
            {
                throw;
            }
        }

        internal DataTable GetQuantityMaster()
        {
            try
            {
                DataTable _Result = new DataTable();
                String _SqlQuery = "Select Code, [Name] From [Quantity] Where Isnull(Active,'') = 'Y'";

                SqlIntract _SqlIntract = new SqlIntract();
                _Result = _SqlIntract.ExecuteDataTable(_SqlQuery, CommandType.Text, null);

                return _Result;
            }
            catch
            {
                throw;
            }
        }

        internal DataTable GetProductMaster()
        {
            try
            {
                DataTable _Result = new DataTable();
                String _SqlQuery = "Select Code, [Name] From [Product] Where Isnull(Active,'') = 'Y' Order By [Name]";

                SqlIntract _SqlIntract = new SqlIntract();
                _Result = _SqlIntract.ExecuteDataTable(_SqlQuery, CommandType.Text, null);

                return _Result;
            }
            catch
            {
                throw;
            }
        }

        internal DataTable GetCustomerMaster()
        {
            try
            {
                DataTable _Result = new DataTable();
                String _SqlQuery = "Select [Code], [Name] From [Customer] Where Isnull([Active],'') = 'Y' Order By [Name]";

                SqlIntract _SqlIntract = new SqlIntract();
                _Result = _SqlIntract.ExecuteDataTable(_SqlQuery, CommandType.Text, null);

                return _Result;
            }
            catch
            {
                throw;
            }
        }

        internal DataTable GetExpenseMaster()
        {
            try
            {
                DataTable _Result = new DataTable();
                String _SqlQuery = "Select [Code], [Name] From [ExpenseMaster] Where Isnull([Active],'') = 'Y' Order By [Name]";

                SqlIntract _SqlIntract = new SqlIntract();
                _Result = _SqlIntract.ExecuteDataTable(_SqlQuery, CommandType.Text, null);

                return _Result;
            }
            catch
            {
                throw;
            }
        }

        internal DataTable GetPaymentTypeMaster()
        {
            try
            {
                DataTable _Result = new DataTable();
                String _SqlQuery = "Select [Code], [Name] From [PaymentType] Where Isnull([Active],'') = 'Y' Order By [SNo]";

                SqlIntract _SqlIntract = new SqlIntract();
                _Result = _SqlIntract.ExecuteDataTable(_SqlQuery, CommandType.Text, null);

                return _Result;
            }
            catch
            {
                throw;
            }
        }

        internal DataTable GetVendorMaster()
        {
            try
            {
                DataTable _Result = new DataTable();
                String _SqlQuery = "Select [Code], [Name] From [Vendor] Where Isnull([Active],'') = 'Y' Order By [Name]";

                SqlIntract _SqlIntract = new SqlIntract();
                _Result = _SqlIntract.ExecuteDataTable(_SqlQuery, CommandType.Text, null);

                return _Result;
            }
            catch
            {
                throw;
            }
        }

        internal DataTable GetUserMaster()
        {
            try
            {
                DataTable _Result = new DataTable();
                String _SqlQuery = "Select [Code], [Name], [Password] From [User] Where Isnull([Active],'') = 'Y' Order By [Name]";

                SqlIntract _SqlIntract = new SqlIntract();
                _Result = _SqlIntract.ExecuteDataTable(_SqlQuery, CommandType.Text, null);

                return _Result;
            }
            catch
            {
                throw;
            }
        }

        internal DataTable GetProgressStatusMaster()
        {
            try
            {
                DataTable _Result = new DataTable();
                String _SqlQuery = "Select [Code], [Name] From [ProgressStatusMaster] Where Isnull([Active],'') = 'Y' Order By [SNo]";

                SqlIntract _SqlIntract = new SqlIntract();
                _Result = _SqlIntract.ExecuteDataTable(_SqlQuery, CommandType.Text, null);

                return _Result;
            }
            catch
            {
                throw;
            }
        }

        internal DataTable GetYesNoMaster()
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

                return _DataTable;
            }
            catch
            {
                throw;
            }
        }

    }
}
