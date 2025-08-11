using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RR.Entities.DTOs
{
    public class TokenDto
    {
        public String AccessToken { get; set; }
        public String RefreshToken { get; set; }
    }
}
