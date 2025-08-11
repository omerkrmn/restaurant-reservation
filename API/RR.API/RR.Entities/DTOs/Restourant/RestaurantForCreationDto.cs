using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RR.Entities.DTOs.Restourant
{
    
    public class RestaurantForCreationDto
    {
        [Required(ErrorMessage = "Restoran adı zorunludur.")]
        public string Name { get; set; }
        
        [Required(ErrorMessage ="Restoran adresi zorunludur.")]
        public string Address { get; set; }

        [Phone]
        [Required(ErrorMessage = "Telefon numarası zorunludur.")]
        public string PhoneNumber { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "E-mail adresi zorunludur.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Owner ID zorunludur.")]
        public Guid OwnerId { get; set; }
    }
}
