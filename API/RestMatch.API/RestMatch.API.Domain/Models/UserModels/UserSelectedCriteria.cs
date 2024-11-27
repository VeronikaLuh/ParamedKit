using RestMatch.API.Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestMatch.API.Domain.Models.UserModels
{
    public class UserSelectedCriteria: BaseEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int CuisineId { get; set; }
        public int LowestPrice { get; set; }
        public int HighestPrice { get; set; }
        public string Location { get; set; }
        public CuisineType Cuisine { get; set; }
    }
}
