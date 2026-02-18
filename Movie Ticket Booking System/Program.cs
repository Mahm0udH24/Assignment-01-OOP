namespace Movie_Ticket_Booking_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Movie Booking System");

            Ticket t1 = new Ticket("Inception");
            t1.PrintTicket();

            Console.Write("\nEnter Movie Name: ");
            string? movie = Console.ReadLine();

            Ticket t2 = new Ticket(movie, TicketType.VIP, new Seat('B', 5), 150.0);

            double coupon = 20.0;
            Console.WriteLine($"Applying a coupon of {coupon:C}...");
            t2.ApplyDiscount(ref coupon); 

            t2.PrintTicket();
            Console.WriteLine($"Total after 14% tax: {t2.CalcTotal(14):C}");
        }
    }
}
