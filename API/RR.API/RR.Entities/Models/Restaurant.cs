namespace RR.API.Models
{
    public class Restaurant
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string ImageUrl { get; set; }
        public string MapAddress { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public Guid OwnerId { get; set; }
        public User Owner { get; set; }

        public ICollection<Table> Tables { get; set; } = new List<Table>();
        public ICollection<Review> Reviews { get; set; } = new List<Review>();
        public ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
        public ICollection<MenuItem> MenuItems { get; set; } = new List<MenuItem>();

    }
}
