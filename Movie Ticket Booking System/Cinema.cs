namespace Movie_Ticket_Booking_System
{
    using System;
    using System.Collections.Generic;

    public class Cinema
    {
        private System.Collections.Generic.List<Ticket> _tickets = new System.Collections.Generic.List<Ticket>();

        public void Open() => Console.WriteLine("=== Cinema Opened ===\n");
        public void Close() => Console.WriteLine("\n=== Cinema Closed ===");
        public void AddTicket(Ticket t) => _tickets.Add(t);

        public void PrintAllTickets()
        {
            Console.WriteLine("--- All Tickets ---");
            foreach (var t in _tickets) t.Print();
        }
    }

    public static class BookingHelper
    {
       
        public static void PrintAll(IPrintable[] items)
        {
            Console.WriteLine("\n--- BookingHelper.PrintAll ---");
            foreach (var item in items) item?.Print();
        }
    }
}
