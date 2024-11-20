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

        public async Task<RestaurantImageUrl?> GetRestaurantImageUrl(int id) =>
            await _context.RestaurantImageUrls.Where(r => r.Id == id)
                .Include(r => r.Restaurant).FirstOrDefaultAsync();

        public async Task<ICollection<RestaurantCuisine>?> GetRestaurantCuisines(int restaurantId)
        {
            if (!RestaurantExists(restaurantId))
                return null;

            return await _context.RestaurantCuisines.Where(r => r.RestaurantId == restaurantId)
                .Include(r => r.Restaurant).Include(r => r.Type).ToListAsync();
        }

        public async Task<RestaurantCuisine?> GetRestaurantCuisine(int id) =>
            await _context.RestaurantCuisines.Where(r => r.Id == id)
                .Include(r => r.Restaurant).Include(r => r.Type)
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

        public async Task<bool> UpdateRestaurantImageUrl(int id, RestaurantImageUrl imageUrl)
        {
            imageUrl.Id = id;
            _context.Entry(imageUrl).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RestaurantImageUrlExists(imageUrl.Id))
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

        public async Task<RestaurantImageUrl?> AddRestaurantImageUrl(int restaurantId, RestaurantImageUrl imageUrl)
        {
            var restaurant = await GetRestaurant(restaurantId);
            if (restaurant == null)
                return null;

            imageUrl.Restaurant = restaurant;
            _context.RestaurantImageUrls.Add(imageUrl);
            await _context.SaveChangesAsync();
            return imageUrl;
        }

        public async Task<RestaurantCuisine?> AddRestaurantCuisine(int restaurantId, int cuisineTypeId)
        {
            var restaurant = await GetRestaurant(restaurantId);
            if (restaurant == null)
                return null;
            var cuisineType = await _context.Cuisines.FirstOrDefaultAsync(c => c.Id == cuisineTypeId);
            if (cuisineType == null)
                return null;

            var cuisine = new RestaurantCuisine
            {
                Restaurant = restaurant,
                Type = cuisineType
            };
            _context.RestaurantCuisines.Add(cuisine);
            await _context.SaveChangesAsync();
            return cuisine;
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

        public async Task<bool> DeleteRestaurantImageUrl(int id)
        {
            var imageUrl = await GetRestaurantImageUrl(id);
            if (imageUrl == null)
                return false;

            _context.RestaurantImageUrls.Remove(imageUrl);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> DeleteRestaurantCuisine(int id)
        {
            var cuisine = await GetRestaurantCuisine(id);
            if (cuisine == null)
                return false;

            _context.RestaurantCuisines.Remove(cuisine);
            await _context.SaveChangesAsync();

            return true;
        }

        private bool RestaurantExists(int id) =>
            (_context.Restaurants?.Any(p => p.Id == id)).GetValueOrDefault();

        private bool RestaurantImageUrlExists(int id) =>
            (_context.RestaurantImageUrls?.Any(p => p.Id == id)).GetValueOrDefault();
    }
}
