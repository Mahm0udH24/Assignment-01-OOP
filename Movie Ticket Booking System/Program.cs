namespace Movie_Ticket_Booking_System
{
    class Program
    {
        static void Main()
        {
            Cinema myCinema = new Cinema();

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"Enter data for Ticket {i}:");
                Console.Write("Movie Name: ");
                string name = Console.ReadLine() ?? "";
                Console.Write("Ticket Type (0=Standard, 1=VIP, 2=IMAX): ");
                TicketType type = (TicketType)int.Parse(Console.ReadLine() ?? "0");
                Console.Write("Seat Row (A-Z): ");
                char row = char.Parse((Console.ReadLine() ?? "A").ToUpper());
                Console.Write("Seat Number: ");
                int num = int.Parse(Console.ReadLine() ?? "1");
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine() ?? "0");

                myCinema.AddTicket(new Ticket(name, type, new Seat(row, num), price));
                Console.WriteLine();
            }

            Console.WriteLine("---------- All Tickets ----------");
            for (int i = 0; i < 3; i++)
            {
                Ticket? t = myCinema[i];
                if (t != null)
                    Console.WriteLine($"Ticket #{t.TicketId} | {t.MovieName} | {t.Type} | Seat: {t.Seat} | Price: {t.Price} EGP | After Tax: {t.PriceAfterTax:F1} EGP");
            }

            Console.WriteLine("\n========== Search by Movie ==========");
            Console.Write("Enter movie name to search: ");
            string? searchInput = Console.ReadLine();
            Ticket? found = !string.IsNullOrEmpty(searchInput) ? myCinema[searchInput] : null; 

            if (found != null)
                Console.WriteLine($"Found: Ticket #{found.TicketId} | {found.MovieName} | {found.Type} | Seat: {found.Seat} | Price: {found.Price} EGP");
            else
                Console.WriteLine("Movie not found.");

            Console.WriteLine($"\n========== Statistics ==========");
            Console.WriteLine($"Total Tickets Sold: {Ticket.GetTotalTicketsSold()}");
            Console.WriteLine($"Booking Reference 1: {BookingHelper.GenerateBookingReference()}");
            Console.WriteLine($"Booking Reference 2: {BookingHelper.GenerateBookingReference()}");

            double discountPrice = BookingHelper.CalcGroupDiscount(5, 80);
            Console.WriteLine($"\nGroup Discount (5 tickets x 80 EGP): {discountPrice} EGP (10% off applied)");
        }
    }
}
