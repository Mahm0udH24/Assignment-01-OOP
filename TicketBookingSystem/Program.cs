using System;
using TicketBookingSystem.Structs;

namespace TicketBookingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            Console.Write("Enter Movie Name: ");
            string movie = Console.ReadLine();

            Console.Write("Enter Ticket Type (0 = Standard , 1 = VIP , 2 = IMAX ): ");
            TicketType type = (TicketType)int.Parse(Console.ReadLine());

            Console.Write("Enter Seat Row (A, B, C...): ");
            char row = char.Parse(Console.ReadLine().ToUpper());

            Console.Write("Enter Seat Number: ");
            int seatNum = int.Parse(Console.ReadLine());

            Console.Write("Enter Price: ");
            double price = double.Parse(Console.ReadLine());

            Console.Write("Enter Discount Amount: ");
            double discount = double.Parse(Console.ReadLine());

         
            Ticket ticket = new Ticket(movie, type, new Seat(row, seatNum), price);

            Console.WriteLine("\n===== Ticket Info =====");
            ticket.PrintTicket(14); 

            double discountBefore = discount;
            ticket.ApplyDiscount(ref discount); 

            Console.WriteLine("\n===== After Discount =====");
            Console.WriteLine($"Discount Before : {discountBefore:F2}");
            Console.WriteLine($"Discount After  : {discount:F2}");
            ticket.PrintTicket(14);
        }
    }
}