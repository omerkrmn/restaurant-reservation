using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace RR.API.Models
{
    public class Reservation
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; }

        public Guid RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }

        public Guid TableId { get; set; }
        public Table Table { get; set; }

        public DateTime ReservationDate { get; set; }
        public int NumberOfGuests { get; set; }
        public ReservationStatus Status { get; set; } = ReservationStatus.Pending;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public Payment Payment { get; set; }
    }

    public enum ReservationStatus
    {
        Pending = 0,
        Confirmed = 1,
        Cancelled = 2,
        Completed = 3
    }
}
