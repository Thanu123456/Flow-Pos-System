using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscopeWindowsApp
{
    public static class SessionManager
    {
        public static decimal CashInHand { get; set; }
        public static decimal Cash { get; set; }
        public static decimal Card { get; set; }
        public static decimal TotalSales { get; set; }
        public static decimal TotalRefund { get; set; }
        public static DateTime SessionStartTime { get; set; } // To track when the session started

        // Reset the session data when the cashier logs out
        public static void ResetSession()
        {
            CashInHand = 0m;
            Cash = 0m;
            Card = 0m;
            TotalSales = 0m;
            TotalRefund = 0m;
            SessionStartTime = DateTime.MinValue;
        }
    }
}