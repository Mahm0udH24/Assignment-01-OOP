using System;
using System.Collections.Generic;
using System.Text;

namespace Movie_Ticket_Booking_System
{
    public class Ticket
    {
        private static int _ticketCounter = 0; 
        private decimal _price;

        public int TicketId { get; } 
        public string MovieName { get; set; }

        public decimal Price
        {
            get => _price;
            set { if (value > 0) _price = value; } 
        }

        public decimal PriceAfterTax => Price * 1.14m; 

        public Ticket(string movieName, decimal price)
        {
            TicketId = ++_ticketCounter; 
            MovieName = movieName;
            Price = price;
        }

        public static int GetTotalTickets() => _ticketCounter;

        public virtual void PrintTicket() => Console.Write(ToString());

        public void SetPrice(decimal price) => Price = price;
        public void SetPrice(decimal price, decimal multiplier) => Price = price * multiplier;

        public override string ToString() =>
            $"Ticket #{TicketId} | {MovieName} | Price: {Price} EGP | After Tax: {PriceAfterTax:F2} EGP";
    }
}
