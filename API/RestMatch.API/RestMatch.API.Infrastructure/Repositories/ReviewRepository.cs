using Microsoft.EntityFrameworkCore;
using RestMatch.API.Domain.Interfaces;
using RestMatch.API.Domain.Models;
using RestMatch.API.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RestMatch.API.Infrastructure.Repositories
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly ApplicationDbContext _context;
        public ReviewRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task CreateNewReview(Review review)
        {
            await _context.Reviews.AddAsync(review);
        }

        public async Task<Review?> GetReviewById(int id)
        {
            return await _context.Reviews
                .FirstOrDefaultAsync(i => i.Id == id);
        }

        public async Task<IEnumerable<Review>> GetReviews(Expression<Func<Review, bool>> expression)
        {
            return await _context.Reviews
                .Include(i => i.User)
                .Where(expression)
                .ToListAsync();
        }

        public void DeleteReview(Review review)
        {
            _context.Reviews.Remove(review);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
