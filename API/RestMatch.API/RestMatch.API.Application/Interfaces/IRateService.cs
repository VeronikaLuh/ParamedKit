using RestMatch.API.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestMatch.API.Application.Interfaces
{
    public interface IRateService
    {
        Task CreateReviewRerate(CreateReviewDto model);
    }
}
