using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestMatch.API.Domain.Models.Base
{
    public abstract class BaseEntity : IBaseEntity
    {
        [ScaffoldColumn(false)]
        public DateTime? CreatedAt { get; set; }
        
        [ScaffoldColumn(false)]
        public DateTime? ModifiedAt { get; set; }
    }
}
