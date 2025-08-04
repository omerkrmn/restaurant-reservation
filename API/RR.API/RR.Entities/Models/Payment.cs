namespace RR.API.Models
{
    public class Payment
    {
        public Guid Id { get; set; }

        public Guid ReservationId { get; set; }
        public Reservation Reservation { get; set; }

        public decimal Amount { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public PaymentStatus Status { get; set; } = PaymentStatus.Pending;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
    public enum PaymentMethod
    {
        CreditCard = 0,
        PayPal = 1,
        Iyzico = 2,
        Cash = 3
    }

    public enum PaymentStatus
    {
        Pending = 0,
        Paid = 1,
        Failed = 2,
        Refunded = 3
    }
}
