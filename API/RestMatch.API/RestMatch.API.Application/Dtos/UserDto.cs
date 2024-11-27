using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestMatch.API.Application.Dtos
{
    public class UserDto
    {
        public int Id { get; set; }

        public string NickName { get; set; }
         
        public string ImageUrl { get; set; }
    }
}
