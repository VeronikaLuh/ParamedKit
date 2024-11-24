using RestMatch.API.Domain.Models.UserModels;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RestMatch.API.Domain.Models
{
    public class CuisineType
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;
        public IEnumerable<UserSelectedCriteria> SelectedCriterias { get; set; }
    }
}
