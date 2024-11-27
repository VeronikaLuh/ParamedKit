using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RestMatch.API.Domain.Enums;
using RestMatch.API.Domain.Interfaces;
using RestMatch.API.Domain.Models;
using RestMatch.API.Infrastructure.Data;

namespace RestMatch.API.Infrastructure.Repositories
{
    public class RestaurantRepository : IRestaurantRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IUserSelectedCriteriasRepository _userSelectedCriteriasRepository;
        private readonly IRestaurantCriteriasRepository _restaurantCriteriasRepository;

        public RestaurantRepository(ApplicationDbContext context, IUserSelectedCriteriasRepository userSelectedCriteriasRepository, IRestaurantCriteriasRepository restaurantCriteriasRepository)
        {
            _context = context;
            _userSelectedCriteriasRepository = userSelectedCriteriasRepository;
            _restaurantCriteriasRepository = restaurantCriteriasRepository;
        }

        public async Task<PagedEntities<Restaurant>> GetRestaurants(
            string? location,
            List<int>? cuisines,
            int? lowestPrice,
            int? highestPrice,
            string? sortOrder,
            int pageNumber,
            int pageSize)
        {
            var query = _context.Restaurants.Select(x => x);

            if (location != null)
            {
                query = FilterLocation(query, location);
            }
            if (lowestPrice != null || highestPrice != null)
            {
                query = FilterPrice(query, lowestPrice, highestPrice);
            }

            query = query.Include(r => r.Cuisines);

            if (cuisines != null && cuisines.Count != 0)
            {
                query = FilterCuisines(query, cuisines);
            }

            query = sortOrder switch
            {
                "name_asc" => query.OrderBy(p => p.Name),
                "name_desc" => query.OrderByDescending(p => p.Name),
                "rating_asc" => query.OrderBy(p => p.Rating),
                "rating_desc" => query.OrderByDescending(p => p.Rating),
                "lower_price_asc" => query.OrderBy(p => p.LowerPrice),
                "lower_price_desc" => query.OrderByDescending(p => p.LowerPrice),
                "upper_price_asc" => query.OrderBy(p => p.UpperPrice),
                "upper_price_desc" => query.OrderByDescending(p => p.UpperPrice),
                _ => query.OrderBy(p => p.Name),
            };

            int totalCount = await query.CountAsync();
            var totalPages = (int)Math.Ceiling(totalCount / (double)pageSize);
            var restaurants = await query
                .Skip((pageNumber - 1) * pageSize).Take(pageSize)
                .Include(r => r.ImageUrls).ToListAsync();
            return new PagedEntities<Restaurant>()
            {
                TotalPages = totalPages,
                Entities = restaurants
            };
        }

        private IQueryable<Restaurant> FilterLocation(IQueryable<Restaurant> query, string location)
        {
            return from restaurant in query
                   where restaurant.City == location
                   select restaurant;
        }

        private IQueryable<Restaurant> FilterPrice(IQueryable<Restaurant> query, int? lowestPrice, int? highestPrice)
        {
            return from restaurant in query
                   where (lowestPrice != null ? restaurant.LowerPrice >= lowestPrice : true) &&
                       (highestPrice != null ? restaurant.UpperPrice <= highestPrice : true)
                   select restaurant;
        }

        private IQueryable<Restaurant> FilterCuisines(IQueryable<Restaurant> query, List<int>? cuisines)
        {
            return query.Select(x => x).Include(r => r.Cuisines).Where(c => c.Cuisines.Any(r => cuisines.Contains(r.TypeId)));
        }

        public async Task<Restaurant?> GetRestaurant(int id)
        {
            return await _context.Restaurants
                .Include(r => r.Cuisines)
                .Include(r => r.ImageUrls)
                .FirstOrDefaultAsync(i => i.Id == id);

        }

        public async Task<bool> UpdateRestaurant(int id, Restaurant restaurant)
        {
            var oldRestaurant = await GetRestaurant(id);

            if (oldRestaurant == null)
            {
                return false;
            }

            _context.Entry(oldRestaurant).CurrentValues.SetValues(restaurant);

            var existingCuisines = oldRestaurant.Cuisines.ToList();
            var updatedCuisines = restaurant.Cuisines.ToList();

            var cuisinesToRemove = existingCuisines
                .Where(ec => !updatedCuisines.Any(uc => uc.Id == ec.Id))
                .ToList();
            _context.RestaurantCuisines.RemoveRange(cuisinesToRemove);

            foreach (var updatedCuisine in updatedCuisines)
            {
                var existingCuisine = existingCuisines.FirstOrDefault(ec => ec.Id == updatedCuisine.Id);
                if (existingCuisine != null)
                {
                    _context.Entry(existingCuisine).CurrentValues.SetValues(updatedCuisine);
                }
                else
                {
                    oldRestaurant.Cuisines.Add(updatedCuisine);
                }
            }

            var existingImageUrls = oldRestaurant.ImageUrls.ToList();
            var updatedImageUrls = restaurant.ImageUrls.ToList();

            var imageUrlsToRemove = existingImageUrls
                .Where(ei => !updatedImageUrls.Any(ui => ui.Id == ei.Id))
                .ToList();
            _context.RestaurantImageUrls.RemoveRange(imageUrlsToRemove);

            foreach (var updatedImageUrl in updatedImageUrls)
            {
                var existingImageUrl = existingImageUrls.FirstOrDefault(ei => ei.Id == updatedImageUrl.Id);
                if (existingImageUrl != null)
                {
                    _context.Entry(existingImageUrl).CurrentValues.SetValues(updatedImageUrl);
                }
                else
                {
                    oldRestaurant.ImageUrls.Add(updatedImageUrl);
                }
            }

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RestaurantExists(restaurant.Id))
                {
                    return false;
                }

                throw;
            }

            return true;
        }

        public async Task<Restaurant> AddRestaurant(Restaurant restaurant)
        {
            restaurant.Id = 0;
            _context.Restaurants.Add(restaurant);
            _context.RestaurantCuisines.AddRange(restaurant.Cuisines);
            _context.RestaurantImageUrls.AddRange(restaurant.ImageUrls);
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

        public async Task<PagedEntities<Restaurant>?> GetRecomendedRestaurants(int userId, int pageNumber, int pageSize)
        {
            var userSelectedCriteria = await _userSelectedCriteriasRepository.GetUserSelectedCriterias(userId);
            if (userSelectedCriteria == null)
            {
                return null;
            }

            var restaurantsAndRates = await _restaurantCriteriasRepository.GetRestaurantCalculatedRate(userId, userSelectedCriteria, pageNumber, pageSize);

            var restaurantsIds = restaurantsAndRates.Entities.Select(x => (int)x.RestaurantId);

            var unsortedRecomendedRestaurants = await _context.Restaurants.Select(x => x).Where(r => restaurantsIds.Contains(r.Id)).ToListAsync();

            var recomendedRestaurants = restaurantsAndRates.Entities.Select(x => unsortedRecomendedRestaurants.FirstOrDefault(e => e.Id == (int)x.RestaurantId)).ToList();
            foreach (var item in restaurantsAndRates.Entities)
            {
                Console.WriteLine($"Id: {item.RestaurantId} Rate: {item.Rate}");
            }

            return new PagedEntities<Restaurant>()
            {
                TotalPages = restaurantsAndRates.TotalPages,
                Entities = recomendedRestaurants!
            };
        }
    }
}
