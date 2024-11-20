using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RestMatch.API.Domain.Interfaces;
using RestMatch.API.Domain.Models;
using RestMatch.API.Infrastructure.Data;

namespace RestMatch.API.Infrastructure.Repositories
{
    public class RestaurantRepository : IRestaurantRepository
    {
        private readonly ApplicationDbContext _context;

        public RestaurantRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ICollection<Restaurant>> GetRestaurants() =>
            await _context.Restaurants.ToListAsync();

        public async Task<Restaurant?> GetRestaurant(int id) =>
            await _context.Restaurants.Where(r => r.Id == id)
                .Include(r => r.Cuisines).Include(r => r.ImageUrls)
                .FirstOrDefaultAsync();

        public async Task<bool> UpdateRestaurant(int id, Restaurant restaurant)
        {
            restaurant.Id = id;
            _context.Entry(restaurant).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RestaurantExists(restaurant.Id))
                    return false;
                throw;
            }

            return true;
        }

        public async Task<Restaurant> AddRestaurant(Restaurant restaurant)
        {
            _context.Restaurants.Add(restaurant);
            await _context.SaveChangesAsync();
            return restaurant;
        }

        public async Task<bool> DeleteRestaurant(int id)
        {
            var restaurant = await GetRestaurant(id);
            if (restaurant == null)
                return false;

            _context.RestaurantCuisines.RemoveRange(restaurant.Cuisines);
            _context.RestaurantImageUrls.RemoveRange(restaurant.ImageUrls);

            _context.Restaurants.Remove(restaurant);
            await _context.SaveChangesAsync();

            return true;
        }

        private bool RestaurantExists(int id) =>
            (_context.Restaurants?.Any(p => p.Id == id)).GetValueOrDefault();
    }
}
