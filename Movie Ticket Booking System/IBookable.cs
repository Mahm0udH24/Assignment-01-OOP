using System;
using System.Collections.Generic;
using System.Text;

namespace Movie_Ticket_Booking_System
{
    public interface IBookable
    {
        bool IsBooked { get; }
        void Book();
        void Cancel();


    }
}
