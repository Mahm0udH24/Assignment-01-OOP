using System;
using System.Collections.Generic;
using System.Text;

namespace Movie_Ticket_Booking_System
{
    public class Ticket
    {
    
        private static int ticketCounter = 0;

       
        private string _movieName = "";
        private double _price;

        public int TicketId { get; private set; }
        public TicketType Type { get; set; }
        public Seat Seat { get; set; }

        public string MovieName
        {
            get => _movieName;
            set { if (!string.IsNullOrEmpty(value)) _movieName = value; }
        }

        public double Price
        {
            get => _price;
            set { if (value > 0) _price = value; }
        }

        public double PriceAfterTax => Price * 1.14;

        public Ticket(string movie, TicketType type, Seat seat, double price)
        {
            TicketId = ++ticketCounter;
            MovieName = movie;
            Type = type;
            Seat = seat;
            Price = price;
        }

        public static int GetTotalTicketsSold() => ticketCounter;

        internal void PrintTicket()
        {
            throw new NotImplementedException();
        }

        internal void ApplyDiscount(ref double coupon)
        {
            throw new NotImplementedException();
        }

        internal object CalcTotal(int v)
        {
            throw new NotImplementedException();
        }
    }
}
