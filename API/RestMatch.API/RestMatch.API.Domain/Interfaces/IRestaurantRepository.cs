using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestMatch.API.Domain.Models;

namespace RestMatch.API.Domain.Interfaces
{
    public interface IRestaurantRepository
    {
        Task<List<Restaurant>?> GetRecomendedRestaurants(int userId, int? page = 1);
        Task<ICollection<Restaurant>> GetRestaurants(
            string? location,
            List<int>? cuisines,
            int? lowestPrice,
            int? highestPrice,
            string? sortOrder);
        Task<Restaurant?> GetRestaurant(int id);
        Task<RestaurantImageUrl?> GetRestaurantImageUrl(int id);
        Task<RestaurantCuisine?> GetRestaurantCuisine(int id);
        Task<bool> UpdateRestaurant(int id, Restaurant restaurant);
        Task<bool> UpdateRestaurantImageUrl(int id, RestaurantImageUrl imageUrl);
        Task<Restaurant> AddRestaurant(Restaurant restaurant);
        Task<RestaurantImageUrl?> AddRestaurantImageUrl(int restaurantId, RestaurantImageUrl imageUrl);
        Task<RestaurantCuisine?> AddRestaurantCuisine(int restaurantId, int cuisineTypeId);
        Task<bool> DeleteRestaurant(int id);
        Task<bool> DeleteRestaurantImageUrl(int id);
        Task<bool> DeleteRestaurantCuisine(int id);
    }
}
