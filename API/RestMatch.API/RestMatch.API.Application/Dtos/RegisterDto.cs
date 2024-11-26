using Azure.Core.Pipeline;
using RestMatch.API.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestMatch.API.Application.Dtos
{
    public class RegisterDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nickname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public IEnumerable<Roles> Roles { get; set; } = new List<Roles>() { Domain.Enums.Roles.User }; 
    }
}
