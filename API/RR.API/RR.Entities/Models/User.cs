using Microsoft.AspNetCore.Identity;

namespace RR.API.Models
{
    public class User : IdentityUser<Guid>
    {
        public string FullName { get; set; }
        public  DateTime CreatedAt { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}
