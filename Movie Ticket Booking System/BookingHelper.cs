namespace Movie_Ticket_Booking_System
{
    public static class BookingHelper
    {
        private static int _referenceCounter;

        public static string GenerateBookingReference() => $"BK-{++_referenceCounter}";

        public static double CalcGroupDiscount(int count, double price)
        {
            double total = count * price;
            return count >= 5 ? total * 0.9 : total;
        }
    }
}
