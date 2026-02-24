using Movie_Ticket_Booking_System;

class Program
{
    static void Main()
    {
        Cinema myCinema = new Cinema { CinemaName = "Cinema Opened" };
        myCinema.OpenCinema();

        
        myCinema.AddTicket(new StandardTicket("The Irishman", 120, "A-5"));
        myCinema.AddTicket(new VIPTicket("12 Years a Slave", 200));
        myCinema.AddTicket(new IMAXTicket("Spiderhead", 180, false));

        myCinema.PrintAllTickets();

        Console.WriteLine("\n========== Statistics ==========");
        Console.WriteLine($"Total Tickets Created: {Ticket.GetTotalTickets()}");

        myCinema.CloseCinema();
    }
}