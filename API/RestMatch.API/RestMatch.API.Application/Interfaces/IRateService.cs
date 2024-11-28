using RestMatch.API.Application.Dtos;
using RestMatch.API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestMatch.API.Application.Interfaces
{
    public interface IRateService
    {
        Task<IEnumerable<ReviewDto>> GetAllReviews(int restaurantId);
        Task CreateReviewRerate(ReviewDto model);
        Task DeleteReview(int reviewId, int userId);
    }
}
