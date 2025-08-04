using System.ComponentModel.DataAnnotations;

namespace RR.API.Models
{
    public class Review
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; }
        
        public Guid RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }
        
        public string Content { get; set; }
        [Required]
        [MaxLength(1)]
        [AllowedValues(1, 2, 3, 4, 5)]
        public int Rating { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    }
}
