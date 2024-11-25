using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestMatch.API.Application.Dtos
{
    public class LoginDto
    {
        public string Nickname { get; set; }
        public string Password { get; set; }
    }
}
