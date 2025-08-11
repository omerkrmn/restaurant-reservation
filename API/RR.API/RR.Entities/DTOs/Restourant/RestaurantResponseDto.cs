using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RR.Entities.DTOs.Restourant
{
    public class RestaurantResponseDto
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
        public DateTime CreatedAt { get; set; }
        public Guid OwnerId { get; set; }
    }
}
