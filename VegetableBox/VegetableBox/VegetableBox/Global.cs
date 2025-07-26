using System;
using System.Collections.Generic;
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
}
