using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentFormsAPI.Application.Models
{
    public record UserSignInDto
    {
        public string EmailAddress { get; set; }
        public string Password { get; set; }
    }
}
