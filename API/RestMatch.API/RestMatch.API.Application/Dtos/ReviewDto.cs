using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestMatch.API.Application.Dtos
{
    public class ReviewDto
    {
        public int? Id { get; set; } 
        public int RestaurantId { get; set; }
        public UserDto? User { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public int Rating { get; set; }
    }
}
