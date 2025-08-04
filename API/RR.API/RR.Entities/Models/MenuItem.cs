using System.ComponentModel.DataAnnotations;

namespace RR.API.Models
{
    public class MenuItem
    {
        public Guid Id { get; set; }

        public Guid RestaurantId { get; set; }
        public Guid CategoryId { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }

        public Restaurant Restaurant { get; set; }
        public MenuCategory Category { get; set; }

    }
}
