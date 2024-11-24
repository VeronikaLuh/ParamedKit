using RestMatch.API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestMatch.API.Domain.Interfaces
{
    public interface IReviewRepository
    {
        Task CreateNewReview(Review review);
    }
}
