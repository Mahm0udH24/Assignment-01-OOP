using System;
using System.Collections.Generic;
using System.Text;

namespace TicketBookingSystem
{
    public static class BookingHelper
    {
        private static int referenceCounter = 0;

        public static string GenerateBookingReference() => $"BK-{++referenceCounter}";

        public static double CalcGroupDiscount(int count, double price)
        {
            double total = count * price;
            return count >= 5 ? total * 0.9 : total; 
        }
    }
}
