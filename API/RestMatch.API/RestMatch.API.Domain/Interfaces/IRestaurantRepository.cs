using System.Collections.Generic;
using System.Threading.Tasks;
using RestMatch.API.Domain.Models;

namespace RestMatch.API.Domain.Interfaces
{
    public interface IRestaurantRepository
    {
        Task<ICollection<Restaurant>> GetRestaurants();
        Task<Restaurant?> GetRestaurant(int id);
        Task<RestaurantImageUrl?> GetRestaurantImageUrl(int id);
        Task<bool> UpdateRestaurant(int id, Restaurant restaurant);
        Task<bool> UpdateRestaurantImageUrl(int id, RestaurantImageUrl imageUrl);
        Task<Restaurant> AddRestaurant(Restaurant restaurant);
        Task<RestaurantImageUrl?> AddRestaurantImageUrl(int restaurantId, RestaurantImageUrl imageUrl);
        Task<bool> DeleteRestaurant(int id);
        Task<bool> DeleteRestaurantImageUrl(int id);
    }
}
