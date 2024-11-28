using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestMatch.API.Application.Dtos
{
    public class UserSelectedCriteiaDto
    {
        public int? Id { get; set; }
        public int CuisineId { get; set; }
        public int LowestPrice { get; set; }
        public int HighestPrice { get; set; }
        public string Location { get; set; }
    }
}
