using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegetableBox
{
    internal static class Global
    {
        internal static MdiVegetableBox? mdiVegetableBox;
        internal static string applicationName = "Vegetable Box";
        internal static int currentUserId = 1;
        internal static string currentUserName = "Admin";

        internal static string sqlConnectionString = ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;
        internal static string sqlMasterConnectionString = ConfigurationManager.ConnectionStrings["SqlMasterConnection"].ConnectionString;

        internal static string sqlServerName = ConfigurationManager.AppSettings["SqlServerName"];
        internal static string sqlDatabaseName = ConfigurationManager.AppSettings["SqlDatabaseName"];
        internal static string sqlServerUserId = ConfigurationManager.AppSettings["SqlServerUserId"];
        internal static string sqlServerPassword = ConfigurationManager.AppSettings["SqlServerPassword"];
    }

    public static class CommonUtils
    {
        public static bool IsDataTableValid(this DataTable dataTable)
        {
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static decimal GetTotalAmountFromStrings(params string[] amounts)
        {
            decimal total = 0;
            foreach (string amount in amounts)
            {
                total += string.IsNullOrEmpty(amount.Trim()) ? 0 : Convert.ToDecimal(amount.Trim());
            }
            return total;
        }

    }
}
