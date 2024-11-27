using System.Collections.Generic;
using System.Threading.Tasks;
using RestMatch.API.Application.Dtos;
using RestMatch.API.Domain.Models;

namespace RestMatch.API.Application.Interfaces
{
    public interface IRestaurantService
    {
        Task<PagedEntities<Restaurant>?> GetRestaurantRecomendation(int userId, int pageNumber, int pageSize);
        Task<PagedEntities<RestaurantDto>> GetRestaurants(
            string? location,
            List<int>? cuisine,
            int? lowestPrice,
            int? highestPrice,
            string? sortOrder,
            int pageNumber,
            int pageSize);
        Task<RestaurantDto?> GetRestaurant(int id);
        Task<RestaurantImageUrlDto?> GetRestaurantImageUrl(int id);
        Task<RestaurantCuisineDto?> GetRestaurantCuisine(int id);
        Task<bool> UpdateRestaurant(int id, RestaurantDto dto);
        Task<bool> UpdateRestaurantImageUrl(int id, RestaurantImageUrlDto dto);
        Task<RestaurantDto> AddRestaurant(RestaurantDto dto);
        Task<RestaurantImageUrlDto?> AddRestaurantImageUrl(int restaurantId, RestaurantImageUrlDto dto);
        Task<RestaurantCuisineDto?> AddRestaurantCuisine(int restaurantId, RestaurantCuisineDto dto);
        Task<bool> DeleteRestaurant(int id);
        Task<bool> DeleteRestaurantImageUrl(int id);
        Task<bool> DeleteRestaurantCuisine(int id);
    }
}
