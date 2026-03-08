using TicketBookingSystem.Structs;
namespace TicketBookingSystem
{

    public abstract class Ticket
    {
        private static int _counter = 0;
        public int TicketId { get; }
        public string MovieName { get; set; }
        public decimal Price { get; set; }
        public bool IsBooked { get; private set; }

        protected Ticket(string movie, decimal price)
        {
            TicketId = ++_counter;
            MovieName = movie;
            Price = price;
        }

        public void Book() => IsBooked = true;
        public abstract decimal CalculateFinalPrice(); 
    }
}