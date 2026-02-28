namespace Movie_Ticket_Booking_System;

public class Projector
{
    public void Start() => Console.WriteLine("Projector started.");
    public void Stop() => Console.WriteLine("Projector stopped.");
}

public class Cinema
{
    private Ticket[] _tickets = new Ticket[20];
    private Projector _projector = new Projector();

    public void AddTicket(Ticket t)
    {
        for (int i = 0; i < _tickets.Length; i++)
        {
            if (_tickets[i] == null) { _tickets[i] = t; return; }
        }
    }

    public void OpenCinema()
    {
        Console.WriteLine("========== Cinema Opened ==========");
        _projector.Start();
    }

    public void CloseCinema()
    {
        Console.WriteLine("\n========== Cinema Closed ==========");
        _projector.Stop();
    }

    // Polymorphism in action: calls the specific override for each ticket type
    public void PrintAllTickets()
    {
        Console.WriteLine("\n========== All Tickets ==========");
        foreach (var t in _tickets) { t?.PrintTicket(); }
    }
}