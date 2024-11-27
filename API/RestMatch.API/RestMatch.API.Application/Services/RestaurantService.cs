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

        public async Task<PagedEntities<RestaurantDto>> GetRestaurants(
            string? location,
            List<int>? cuisine,
            int? lowestPrice,
            int? highestPrice,
            string? sortOrder,
            int pageNumber,
            int pageSize)
        {
            var pagedRestaurants = await _repo.GetRestaurants(location, cuisine, lowestPrice, highestPrice, sortOrder, pageNumber, pageSize);
            return new PagedEntities<RestaurantDto>()
            {
                TotalPages = pagedRestaurants.TotalPages,
                Entities = _mapper.Map<List<RestaurantDto>>(pagedRestaurants.Entities)
            };
        }

        public async Task<RestaurantDto?> GetRestaurant(int id)
        {
            var restaurant = await _repo.GetRestaurant(id);
            if (restaurant == null)
                return null;

            return _mapper.Map<RestaurantDto>(restaurant);
        }

        public async Task<RestaurantImageUrlDto?> GetRestaurantImageUrl(int id)
        {
            var imageUrl = await _repo.GetRestaurantImageUrl(id);
            if (imageUrl == null)
                return null;

            return _mapper.Map<RestaurantImageUrlDto>(imageUrl);
        }

        public async Task<RestaurantCuisineDto?> GetRestaurantCuisine(int id)
        {
            var cuisine = await _repo.GetRestaurantCuisine(id);
            if (cuisine == null)
                return null;

            return _mapper.Map<RestaurantCuisineDto>(cuisine);
        }

        public async Task<bool> UpdateRestaurant(int id, RestaurantDto dto)
        {
            var restaurant = _mapper.Map<Restaurant>(dto);
            return await _repo.UpdateRestaurant(id, restaurant);
        }

        public async Task<bool> UpdateRestaurantImageUrl(int id, RestaurantImageUrlDto dto)
        {
            var imageUrl = _mapper.Map<RestaurantImageUrl>(dto);
            return await _repo.UpdateRestaurantImageUrl(id, imageUrl);
        }

        public async Task<RestaurantDto> AddRestaurant(RestaurantDto dto)
        {
            var restaurant = _mapper.Map<Restaurant>(dto);
            var newRestaurant = await _repo.AddRestaurant(restaurant);
            return _mapper.Map<RestaurantDto>(newRestaurant);
        }

        public async Task<RestaurantImageUrlDto?> AddRestaurantImageUrl(int restaurantId, RestaurantImageUrlDto dto)
        {
            var imageUrl = _mapper.Map<RestaurantImageUrl>(dto);
            var newimageUrl = await _repo.AddRestaurantImageUrl(restaurantId, imageUrl);
            if (newimageUrl == null)
                return null;

            return _mapper.Map<RestaurantImageUrlDto>(newimageUrl);
        }

        public async Task<RestaurantCuisineDto?> AddRestaurantCuisine(int restaurantId, RestaurantCuisineDto dto)
        {
            var newCuisine = await _repo.AddRestaurantCuisine(restaurantId, dto.TypeId);
            if (newCuisine == null)
                return null;

            return _mapper.Map<RestaurantCuisineDto>(newCuisine);
        }

        public async Task<bool> DeleteRestaurant(int id)
            => await _repo.DeleteRestaurant(id);

        public async Task<bool> DeleteRestaurantImageUrl(int id)
            => await _repo.DeleteRestaurantImageUrl(id);

        public async Task<bool> DeleteRestaurantCuisine(int id)
            => await _repo.DeleteRestaurantCuisine(id);

        public async Task<PagedEntities<Restaurant>?> GetRestaurantRecomendation(int userId, int pageNumber, int pageSize)
        {
            var recomendedRestaurants = await _repo.GetRecomendedRestaurants(userId, pageNumber, pageSize);

            if (recomendedRestaurants == null)
                return null;

            return recomendedRestaurants;
        }
    }
}
