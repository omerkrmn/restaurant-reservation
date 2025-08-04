namespace RR.API.Models
{
    public class Notification
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; }

        public string Message { get; set; }
        public bool IsRead { get; set; } = false;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public NotificationType Type { get; set; } = NotificationType.General;
    }
    public enum NotificationType
    {
        General = 0,
        ReservationConfirmed = 1,
        ReservationCancelled = 2,
        PaymentReceived = 3
    }
}
