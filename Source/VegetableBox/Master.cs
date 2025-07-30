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

    }
}
