using System.ComponentModel.DataAnnotations;
using RestMatch.API.Domain.Models.Base;

namespace RestMatch.API.Domain.Models
{
    public class RestaurantCuisine : BaseEntity
    {
        [Key]
        public int Id { get; set; }

        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; } = null!;
        public int TypeId { get; set; }
        public CuisineType Type { get; set; } = null!;
    }
}
