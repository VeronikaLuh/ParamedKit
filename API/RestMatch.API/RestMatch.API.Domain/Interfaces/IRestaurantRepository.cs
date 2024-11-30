using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestMatch.API.Domain.Models;

namespace RestMatch.API.Domain.Interfaces
{
    public interface IRestaurantRepository
    {
        Task<PagedEntities<Restaurant>?> GetRecomendedRestaurants(int userId, int pageNumber, int pageSize);
        Task<PagedEntities<Restaurant>> GetRestaurants(
            string? location,
            List<int>? cuisines,
            int? lowestPrice,
            int? highestPrice,
            string? sortOrder,
            int? pageNumber,
            int? pageSize);
        Task<Restaurant?> GetRestaurant(int id);
        Task<bool> UpdateRestaurant(int id, Restaurant restaurant);
        Task<Restaurant> AddRestaurant(Restaurant restaurant);
        Task<bool> DeleteRestaurant(int id);
    }
}
