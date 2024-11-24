using RestMatch.API.Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestMatch.API.Domain.Models.UserModel
{
    public class Role: BaseEntity
    {
        public int Id { get; set; }
        public string RoleName { get; set; }
    }
}
