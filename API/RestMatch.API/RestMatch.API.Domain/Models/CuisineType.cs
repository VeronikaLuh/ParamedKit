using System.ComponentModel.DataAnnotations;

namespace RestMatch.API.Domain.Models
{
    public class CuisineType
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;
    }
}
