using RestMatch.API.Domain.Models.Base;
using RestMatch.API.Domain.Models.UserModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestMatch.API.Domain.Models
{
    public class Review: BaseEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public int Rating { get; set; }
    }
}
