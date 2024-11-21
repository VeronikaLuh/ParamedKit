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
                return null;

            return _mapper.Map<GetRestaurantResponseDto>(restaurant);
        }

        public async Task<GetRestaurantImageUrlResponseDto?> GetRestaurantImageUrl(int id)
        {
            var imageUrl = await _repo.GetRestaurantImageUrl(id);
            if (imageUrl == null)
                return null;

            return _mapper.Map<GetRestaurantImageUrlResponseDto>(imageUrl);
        }

        public async Task<GetRestaurantCuisineResponseDto?> GetRestaurantCuisine(int id)
        {
            var cuisine = await _repo.GetRestaurantCuisine(id);
            if (cuisine == null)
                return null;

            return _mapper.Map<GetRestaurantCuisineResponseDto>(cuisine);
        }

        public async Task<bool> UpdateRestaurant(int id, PutRestaurantRequestDto dto)
        {
            var restaurant = _mapper.Map<Restaurant>(dto);
            return await _repo.UpdateRestaurant(id, restaurant);
        }

        public async Task<bool> UpdateRestaurantImageUrl(int id, PutRestaurantImageUrlRequestDto dto)
        {
            var imageUrl = _mapper.Map<RestaurantImageUrl>(dto);
            return await _repo.UpdateRestaurantImageUrl(id, imageUrl);
        }

        public async Task<GetRestaurantResponseDto> AddRestaurant(PostRestaurantRequestDto dto)
        {
            var restaurant = _mapper.Map<Restaurant>(dto);
            var newRestaurant = await _repo.AddRestaurant(restaurant);
            return _mapper.Map<GetRestaurantResponseDto>(newRestaurant);
        }

        public async Task<GetRestaurantImageUrlResponseDto?> AddRestaurantImageUrl(int restaurantId, PostRestaurantImageUrlRequestDto dto)
        {
            var imageUrl = _mapper.Map<RestaurantImageUrl>(dto);
            var newimageUrl = await _repo.AddRestaurantImageUrl(restaurantId, imageUrl);
            if (newimageUrl == null)
                return null;

            return _mapper.Map<GetRestaurantImageUrlResponseDto>(newimageUrl);
        }

        public async Task<GetRestaurantCuisineResponseDto?> AddRestaurantCuisine(int restaurantId, PostRestaurantCuisineRequestDto dto)
        {
            var newCuisine = await _repo.AddRestaurantCuisine(restaurantId, dto.TypeId);
            if (newCuisine == null)
                return null;

            return _mapper.Map<GetRestaurantCuisineResponseDto>(newCuisine);
        }

        public async Task<bool> DeleteRestaurant(int id)
            => await _repo.DeleteRestaurant(id);

        public async Task<bool> DeleteRestaurantImageUrl(int id)
            => await _repo.DeleteRestaurantImageUrl(id);

        public async Task<bool> DeleteRestaurantCuisine(int id)
            => await _repo.DeleteRestaurantCuisine(id);
    }
}
