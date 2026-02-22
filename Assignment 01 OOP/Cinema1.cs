using System;
using System.Collections.Generic;
using System.Linq;

namespace Movie_Ticket_Booking_System
{
    internal class Cinema
    {
        private readonly List<Ticket> _tickets = new List<Ticket>();

        internal void AddTicket(Ticket ticket)
        {
            if (ticket == null) throw new ArgumentNullException(nameof(ticket));
            _tickets.Add(ticket);
        }

       
        internal Ticket this[int index]
        {
            get
            {
                if (index < 0 || index >= _tickets.Count)
                    throw new IndexOutOfRangeException($"Index {index} is out of range. Valid range: 0..{Math.Max(0, _tickets.Count - 1)}");
                return _tickets[index];
            }
        }
        internal Ticket this[string movieName]
        {
            get
            {
                if (movieName == null) return null;
                return _tickets.FirstOrDefault(t => string.Equals(t.MovieName, movieName, StringComparison.OrdinalIgnoreCase));
            }
        }
    }
}