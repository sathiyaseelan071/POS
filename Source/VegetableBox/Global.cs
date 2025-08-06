using System;
using System.Collections.Generic;
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
        internal static string sqlConnectionString = "Data Source=ATHIRATHAN;" +
            "Initial Catalog=VBOX2324_LIVE;" +
            "User id=sa;" +
            "Password=athi@123;";
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
