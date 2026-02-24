
using Movie_Ticket_Booking_System;

public class StandardTicket : Ticket
{
    public string SeatNumber { get; set; }
    public StandardTicket(string movie, decimal price, string seat) : base(movie, price) => SeatNumber = seat;

    public override string ToString() => base.ToString() + $" | Seat: {SeatNumber}";
}
public class VIPTicket : Ticket
{
    public bool LoungeAccess { get; set; } = true;
    public decimal ServiceFee { get; set; } = 50.0m;
    public VIPTicket(string movie, decimal price) : base(movie, price) { }

    public override string ToString() => base.ToString() + $" | Lounge: {(LoungeAccess ? "Yes" : "No")} | Service Fee: {ServiceFee} EGP";
}

public class IMAXTicket : Ticket
{
    public bool Is3D { get; set; }
    public IMAXTicket(string movie, decimal price, bool is3D) : base(movie, is3D ? price + 30 : price) => Is3D = is3D;

    public override string ToString() => base.ToString() + $" | IMAX 3D: {(Is3D ? "Yes" : "No")}";
}