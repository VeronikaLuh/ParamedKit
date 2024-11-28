using System.ComponentModel.DataAnnotations;
using RestMatch.API.Domain.Models.Base;

namespace RestMatch.API.Domain.Models
{
    public class RestaurantImageUrl : BaseEntity
    {
        public RestaurantImageUrl(string imageUrl)
        {
            Url = imageUrl;
        }

        public RestaurantImageUrl()
        {
        }

        [Key]
        public int Id { get; set; }

        public string Url { get; set; } = string.Empty;

        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; } = null!;
    }
}
