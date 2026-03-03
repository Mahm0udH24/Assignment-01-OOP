using System;
using System.Collections.Generic;
using System.Text;

namespace Movie_Ticket_Booking_System
{
    public abstract class Ticket : IPrintable, IBookable, ICloneable
    {
        private static int _counter = 0;
        public int TicketId { get; protected set; }
        public string MovieName { get; set; }
        public decimal Price { get; set; }
        public bool IsBooked { get; private set; }

        public Ticket(string movie, decimal price)
        {
            TicketId = ++_counter;
            MovieName = movie;
            Price = price;
            IsBooked = false;
        }

        public void Book()
        {
            if (IsBooked) Console.WriteLine($"Ticket #{TicketId} is already booked.");
            else IsBooked = true;
        }

        public void Cancel()
        {
            if (!IsBooked) Console.WriteLine($"Ticket #{TicketId} is not booked yet.");
            else IsBooked = false;
        }

        public abstract void Print();

   
        public object Clone()
        {
            Ticket clone = (Ticket)this.MemberwiseClone();
            
            clone.TicketId = ++_counter;
            clone.IsBooked = false;
            return clone;
        }
    }
}
