using RestMatch.API.Domain.Models;
using RestMatch.API.Domain.Models.UserModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RestMatch.API.Domain.Interfaces
{
    public interface IReviewRepository
    {
        Task CreateNewReview(Review review);

        Task<Review?> GetReviewById(int id);

        Task<IEnumerable<Review>> GetReviews(Expression<Func<Review, bool>> expression);

        void DeleteReview(Review review);

        Task SaveChangesAsync();
    }
}
