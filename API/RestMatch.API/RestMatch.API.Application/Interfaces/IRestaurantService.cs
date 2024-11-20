using System.Collections.Generic;
using System.Threading.Tasks;
using RestMatch.API.Application.Dtos;

namespace RestMatch.API.Application.Interfaces
{
    public interface IRestaurantService
    {
        Task<ICollection<GetRestaurantResponseDto>> GetRestaurants();
        Task<GetRestaurantResponseDto?> GetRestaurant(int id);
        Task<bool> UpdateRestaurant(int id, PutRestaurantRequestDto dto);
        Task<GetRestaurantResponseDto> AddRestaurant(PostRestaurantRequestDto dto);
        Task<bool> DeleteRestaurant(int id);
    }
}
