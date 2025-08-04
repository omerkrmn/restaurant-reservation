namespace RR.API.Models
{
    public class Table
    {
        public Guid Id { get; set; }

        public Guid RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }

        public string TableNumber { get; set; }
        public int Capacity { get; set; }
        public bool IsAvailable { get; set; } = true;

        public ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
    }
}
