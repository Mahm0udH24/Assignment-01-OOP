using Movie_Ticket_Booking_System;

class Program
{
    
    static void ProcessTicket(Ticket t)
    {
        t.PrintTicket();
    }

    static void Main()
    {
        Cinema myCinema = new Cinema();
        myCinema.OpenCinema();


        StandardTicket t1 = new StandardTicket("Inception", 120, "A-5");
        VIPTicket t2 = new VIPTicket("Avengers", 200);
        IMAXTicket t3 = new IMAXTicket("Dune", 180, false);

        Console.WriteLine("\n========== SetPrice Test ==========");
        t1.SetPrice(150);
        Console.WriteLine($"Setting price directly: {t1.Price}");
        t1.SetPrice(100, 1.5m);
        Console.WriteLine($"Setting price with multiplier: 100 x 1.5 = {t1.Price}");


        myCinema.AddTicket(t1);
        myCinema.AddTicket(t2);
        myCinema.AddTicket(t3);
        myCinema.PrintAllTickets();

        Console.WriteLine("\n========== Process Single Ticket ==========");
        ProcessTicket(t2);

        myCinema.CloseCinema();
    }
}