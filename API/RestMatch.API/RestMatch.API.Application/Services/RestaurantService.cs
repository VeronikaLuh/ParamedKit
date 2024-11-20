using System.Collections.Generic;
using System.Threading.Tasks;
using RestMatch.API.Application.Dtos;
using RestMatch.API.Application.Interfaces;
using RestMatch.API.Domain.Interfaces;
using AutoMapper;
using RestMatch.API.Domain.Models;

namespace RestMatch.API.Application.Services
{
    public class RestaurantService : IRestaurantService
    {
        private readonly IMapper _mapper;
        private readonly IRestaurantRepository _repo;

        public RestaurantService(IMapper mapper, IRestaurantRepository repository)
        {
            _mapper = mapper;
            _repo = repository;
        }

        public async Task<ICollection<GetRestaurantResponseDto>> GetRestaurants() =>
            _mapper.Map<List<GetRestaurantResponseDto>>(await _repo.GetRestaurants());

        public async Task<GetRestaurantResponseDto?> GetRestaurant(int id)
        {
            var restaurant = await _repo.GetRestaurant(id);
            if (restaurant == null)
            {
                return null;
            }
            return _mapper.Map<GetRestaurantResponseDto>(restaurant);
        }

        public async Task<bool> UpdateRestaurant(int id, PutRestaurantRequestDto dto)
        {
            var restaurant = _mapper.Map<Restaurant>(dto);
            return await _repo.UpdateRestaurant(id, restaurant);
        }

        public async Task<GetRestaurantResponseDto> AddRestaurant(PostRestaurantRequestDto dto)
        {
            var restaurant = _mapper.Map<Restaurant>(dto);
            var newRestaurant = await _repo.AddRestaurant(restaurant);
            return _mapper.Map<GetRestaurantResponseDto>(newRestaurant);
        }

        public async Task<bool> DeleteRestaurant(int id) => await _repo.DeleteRestaurant(id);
    }
}
