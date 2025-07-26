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

        public DataTable GetDataTable()
        {
            try
            {
                string Query = "Select BillNo, FORMAT(BilledDate, 'dd-MMM-yyy') as BilledDate, NetAmount from [SalesTransaction]";
                Query += Environment.NewLine + "Where IsNull(BillStatus, '') = '' and BilledDate = Cast(Getdate() as date)";
                Query += Environment.NewLine + "Order By BillNo Desc";

                SqlIntract _SqlIntract = new SqlIntract();
                SaleData = new DataTable();

                SaleData = _SqlIntract.ExecuteDataTable(Query, CommandType.Text, null);

                return SaleData;
            }
            catch
            {
                throw;
            }            
        }

    }
}
