using RestMatch.API.Domain.Models.Base;
using RestMatch.API.Domain.Models.UserModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestMatch.API.Domain.Models.Recomendations
{
    public class UserCriteria: BaseRecomendation
    {
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
