using System;

public static class TicketExtensions
{
    public static void ShowReceipt(this Ticket t)
    {
        string type = t.GetType().Name.Replace("Ticket", "");
        Console.WriteLine("========== RECEIPT ==========");
        Console.WriteLine($"  Movie    : {t.MovieName}");
        Console.WriteLine($"  Type     : {type}");
        Console.WriteLine($"  Price    : {t.Price}");
        Console.WriteLine($"  Final    : {t.CalculateFinalPrice():F2}");
        Console.WriteLine($"  Status   : {(t.IsBooked ? "Booked" : "Available")}");
        Console.WriteLine("=============================");
    }

    public static decimal GetTotalRevenue(this Ticket[] tickets)
    {
        decimal total = 0;
        foreach (var t in tickets) total += t.CalculateFinalPrice();
        return total;
    }
}