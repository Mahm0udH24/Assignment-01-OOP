using Movie_Ticket_Booking_System;

class Program
{
    static void Main()
    {
        Cinema myCinema = new Cinema();
        myCinema.Open();

    
        StandardTicket t1 = new StandardTicket("Inception", 80, "A5");
        VIPTicket t2 = new VIPTicket("Avengers", 200);
        IMAXTicket t3 = new IMAXTicket("Dune", 130, true);

        t1.Book(); t2.Book(); t3.Book();
        myCinema.AddTicket(t1); myCinema.AddTicket(t2); myCinema.AddTicket(t3);

   
        myCinema.PrintAllTickets();

     
        Console.WriteLine("\n--- Clone Test ---");
        VIPTicket t2Clone = (VIPTicket)t2.Clone();
        t2Clone.MovieName = "Interstellar"; 

        Console.Write("Original : "); t2.Print();
        Console.Write("Clone    : "); t2Clone.Print();

        Console.WriteLine("\n--- After Cancellation ---");
        t1.Cancel();
        t1.Print();

        IPrintable[] printableTickets = { t1, t2, t3 };
        BookingHelper.PrintAll(printableTickets);
        myCinema.Close();
    }
}
}