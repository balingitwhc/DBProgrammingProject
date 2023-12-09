using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystemProject
{
    public static class GlobalData
    {
        public static string userAccess { get; set; }
        public static string userId { get; set; }
        public static string userFullName { get; set; }
        public static string lblRecordStatus { get; set; }
        public static string lblStockStatus { get; set; }

        //snippet to update the MDI Labels from the child forms
        //updateStatusMDI(GlobalData.lblRecordStatus.ToString(), GlobalData.lblStockStatus.ToString());
        public static int AccessLevel()
        {
            switch (userAccess)
            {
                case "Administrator":
                    return 5;
                case "Manager":
                    return 4;
                case "Stock Clerk":
                    return 3;
                case "Cashier":
                    return 2;
                case "Deli":
                    return 1;
                default:
                    return 0;
            }
        }
    }
}