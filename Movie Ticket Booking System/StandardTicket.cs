
using Movie_Ticket_Booking_System;

public class StandardTicket : Ticket
{
    public string SeatNumber { get; set; }
    public StandardTicket(string m, decimal p, string s) : base(m, p) => SeatNumber = s;

    public override void Print() =>
        Console.WriteLine($"[Ticket #{TicketId}] {MovieName} | Standard | Seat: {SeatNumber} | Price: {Price} | After Tax: {Price * 1.14m} | Booked: {(IsBooked ? "Yes" : "No")}");
}

public class VIPTicket : Ticket
{
    public bool LoungeAccess { get; set; } = true;
    public decimal ServiceFee { get; set; } = 50;

    public VIPTicket(string m, decimal p) : base(m, p) { }

    public override void Print() =>
        Console.WriteLine($"[Ticket #{TicketId}] {MovieName} | VIP | Lounge: {(LoungeAccess ? "Yes" : "No")} | Fee: {ServiceFee} | Price: {Price} | After Tax: {(Price + ServiceFee) * 1.14m} | Booked: {(IsBooked ? "Yes" : "No")}");
}

public class IMAXTicket : Ticket
{
    public bool Is3D { get; set; }
    public IMAXTicket(string m, decimal p, bool is3D) : base(m, p) => Is3D = is3D;

    public override void Print() =>
        Console.WriteLine($"[Ticket #{TicketId}] {MovieName} | IMAX | 3D: {(Is3D ? "Yes" : "No")} | Price: {Price} | After Tax: {Price * 1.14m} | Booked: {(IsBooked ? "Yes" : "No")}");
}
