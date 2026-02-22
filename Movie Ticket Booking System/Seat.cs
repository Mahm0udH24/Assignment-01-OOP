using System;
using System.Collections.Generic;
using System.Text;

namespace Movie_Ticket_Booking_System
{
    public struct Seat
    {
        public char Row;
        public int Number;
        public Seat(char row, int number) { Row = row; Number = number; }
        public override string ToString() => $"{Row}{Number}";
    }
}
