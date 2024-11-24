using System.Collections.Generic;

namespace RestMatch.API.Domain.Models
{
    public class PagedEntities<T>
    {
        public int TotalPages { get; set; }
        public ICollection<T> Entities { get; set; } = null!;
    }
}
