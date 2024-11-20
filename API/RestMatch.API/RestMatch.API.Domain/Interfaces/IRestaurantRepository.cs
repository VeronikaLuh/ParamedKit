using System.Collections.Generic;
using System.Threading.Tasks;
using RestMatch.API.Domain.Models;

namespace RestMatch.API.Domain.Interfaces
{
    public interface IRestaurantRepository
    {
        Task<ICollection<Restaurant>> GetRestaurants();
        Task<Restaurant?> GetRestaurant(int id);
        Task<bool> UpdateRestaurant(int id, Restaurant restaurant);
        Task<Restaurant> AddRestaurant(Restaurant restaurant);
        Task<bool> DeleteRestaurant(int id);
    }
}
