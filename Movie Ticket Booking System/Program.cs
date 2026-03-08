using Movie_Ticket_Booking_System;

class Program
{
    static void Main()
    {
        Cinema cinema = new Cinema();
        cinema.Open();

       
        Console.WriteLine("// Ticket t = new Ticket(\"Test\", 100);  // ERROR: Cannot create instance of abstract type 'Ticket'");

        var t1 = new StandardTicket("Inception", 80, "A5");
        var t2 = new VIPTicket("Avengers", 200);
        var t3 = new IMAXTicket("Dune", 130, true);

        t1.Book(); t2.Book(); t3.Book();
        cinema.AddTicket(t1); cinema.AddTicket(t2); cinema.AddTicket(t3);

        cinema.PrintAll();

        Console.WriteLine("\n--- Polymorphism: Final Price per Ticket ---");
        Ticket[] tickets = cinema.GetTickets();
        foreach (var t in tickets)
        {
            Console.WriteLine($"{t.GetType().Name} => Final Price: {t.CalculateFinalPrice():F2}");
        }

        Console.WriteLine("\n--- Extension Method: Receipt ---");
        t2.ShowReceipt();

        Console.WriteLine("\n--- Extension Method: Total Revenue ---");
        Console.WriteLine($"Total Revenue: {tickets.GetTotalRevenue():F2}");

        cinema.Close();
    }
}
}
