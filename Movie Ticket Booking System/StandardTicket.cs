
using Movie_Ticket_Booking_System;

public class StandardTicket : Ticket
{
    public string Seat { get; set; }
    public StandardTicket(string m, decimal p, string s) : base(m, p) => Seat = s;

    public override decimal CalculateFinalPrice() => BasePrice * 1.14m; 
    public override void Print() { Console.Write("[Standard] "); base.Print(); Console.WriteLine($" | Seat: {Seat}"); }
}

public class VIPTicket : Ticket
{
    public decimal ServiceFee { get; set; } = 50;
    public VIPTicket(string m, decimal p) : base(m, p) { }

    public override decimal CalculateFinalPrice() => (BasePrice + ServiceFee) * 1.14m;
    public override void Print() { Console.Write("[VIP] "); base.Print(); Console.WriteLine($" | Fee: {ServiceFee}"); }
}

public class IMAXTicket : Ticket
{
    public bool Is3D { get; set; }
    public IMAXTicket(string m, decimal p, bool is3D) : base(m, p) => Is3D = is3D;

    public override decimal CalculateFinalPrice() => (BasePrice + 20) * 1.14m; 
    public override void Print() { Console.Write("[IMAX] "); base.Print(); Console.WriteLine($" | 3D: {Is3D}"); }
}