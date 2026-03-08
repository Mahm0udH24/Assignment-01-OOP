namespace Movie_Ticket_Booking_System
{
    using System;
    using System.Collections.Generic;



    public partial class Cinema
    {
        private List<Ticket> _tickets = new();
        public void Open() => Console.WriteLine("=== Cinema Opened ===");
        public void Close() => Console.WriteLine("\n=== Cinema Closed ===");
        public void AddTicket(Ticket t) => _tickets.Add(t);
        public Ticket[] GetTickets() => _tickets.ToArray();
    }

 
    public partial class Cinema
    {
        public void PrintAll()
        {
            Console.WriteLine("\n--- All Tickets (from Cinema.Reporting) ---");
            foreach (var t in _tickets)
            {
                string details = t switch
                {
                    StandardTicket s => $"Standard | Seat: {s.Seat}",
                    VIPTicket v => $"VIP | Lounge: Yes | Fee: {v.Fee}",
                    IMAXTicket i => $"IMAX | 3D: Yes",
                    _ => ""
                };
                Console.WriteLine($"[Ticket #{t.TicketId}] {t.MovieName} | {details} | Price: {t.Price} | Final: {t.CalculateFinalPrice():F2} | Booked: {(t.IsBooked ? "Yes" : "No")}");
            }
        }
    }
}
