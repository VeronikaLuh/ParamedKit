using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestMatch.API.Domain.Models.Base
{
    public interface IBaseEntity
    {
        DateTime? CreatedAt { get; set; }
        DateTime? ModifiedAt { get; set; }
    }
}
