using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegetableBox
{
    internal class ClsFrmRePrint
    {
        private DataTable SaleData = new DataTable();

        public DataTable GetDataTable(DateTime billDate)
        {
            try
            {
                string Query = "SELECT BillNo, FORMAT(BilledDate, 'dd-MMM-yyy') AS BilledDate, NetAmount FROM [SalesTransaction]";
                Query += Environment.NewLine + "WHERE 1=1";
                Query += Environment.NewLine + "AND ISNULL(BillStatus, '') NOT IN ('C', 'D')";
                Query += Environment.NewLine + "AND CAST(BilledDate AS DATE) = @BillDate";
                Query += Environment.NewLine + "ORDER BY BillNo DESC";

                SqlIntract _SqlIntract = new SqlIntract();
                SaleData = new DataTable();

                List<SqlParameter>? _ListSqlParameter = new List<SqlParameter>();
                _ListSqlParameter.Add(new SqlParameter("@BillDate", billDate.Date));

                SaleData = _SqlIntract.ExecuteDataTable(Query, CommandType.Text, _ListSqlParameter);

                return SaleData;
            }
            catch
            {
                throw;
            }            
        }

    }
}
