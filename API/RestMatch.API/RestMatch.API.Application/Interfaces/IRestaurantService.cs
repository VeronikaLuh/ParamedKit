using System.Collections.Generic;
using System.Threading.Tasks;
using RestMatch.API.Application.Dtos;

namespace RestMatch.API.Application.Interfaces
{
    public interface IRestaurantService
    {
        Task<ICollection<GetRestaurantResponseDto>> GetRestaurants();
        Task<GetRestaurantResponseDto?> GetRestaurant(int id);
        Task<ICollection<GetRestaurantImageUrlResponseDto>?> GetRestaurantImageUrls(int restaurantId);
        Task<GetRestaurantImageUrlResponseDto?> GetRestaurantImageUrl(int id);
        Task<ICollection<GetRestaurantCuisineResponseDto>?> GetRestaurantCuisines(int restaurantId);
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
