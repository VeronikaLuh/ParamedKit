using RestMatch.API.Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestMatch.API.Domain.Models.Recomendations
{
    public class RestaurantCriteria: BaseRecomendation
    {
        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }
    }
}
