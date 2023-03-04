using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentFormsAPI.Application.Models
{
    public class UserPatchDto
    {
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? EmailAddress { get; set; }
        public string? Password { get; set; }
    }
}
