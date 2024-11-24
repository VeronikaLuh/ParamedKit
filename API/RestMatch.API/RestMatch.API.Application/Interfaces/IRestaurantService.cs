using System.Collections.Generic;
using System.Threading.Tasks;
using RestMatch.API.Application.Dtos;
using RestMatch.API.Domain.Models;

namespace RestMatch.API.Application.Interfaces
{
    public interface IRestaurantService
    {
        Task<PagedEntities<Restaurant>?> GetRestaurantRecomendation(int userId, int pageNumber, int pageSize);
        Task<PagedEntities<GetRestaurantResponseDto>> GetRestaurants(
            string? location,
            List<int>? cuisine,
            int? lowestPrice,
            int? highestPrice,
            string? sortOrder,
            int pageNumber,
            int pageSize);
        Task<GetRestaurantResponseDto?> GetRestaurant(int id);
        Task<GetRestaurantImageUrlResponseDto?> GetRestaurantImageUrl(int id);
        Task<GetRestaurantCuisineResponseDto?> GetRestaurantCuisine(int id);
        Task<bool> UpdateRestaurant(int id, PutRestaurantRequestDto dto);
        Task<bool> UpdateRestaurantImageUrl(int id, PutRestaurantImageUrlRequestDto dto);
        Task<GetRestaurantResponseDto> AddRestaurant(PostRestaurantRequestDto dto);
        Task<GetRestaurantImageUrlResponseDto?> AddRestaurantImageUrl(int restaurantId, PostRestaurantImageUrlRequestDto dto);
        Task<GetRestaurantCuisineResponseDto?> AddRestaurantCuisine(int restaurantId, PostRestaurantCuisineRequestDto dto);
        Task<bool> DeleteRestaurant(int id);
        Task<bool> DeleteRestaurantImageUrl(int id);
        Task<bool> DeleteRestaurantCuisine(int id);
    }
}
