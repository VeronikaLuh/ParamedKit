using System.Collections.Generic;
using System.Threading.Tasks;
using RestMatch.API.Application.Dtos;
using RestMatch.API.Application.Interfaces;
using RestMatch.API.Domain.Interfaces;
using AutoMapper;
using RestMatch.API.Domain.Models;
using RestMatch.Azure.BlobStorage;
using System;
using System.Runtime.InteropServices;
using System.Linq;

namespace RestMatch.API.Application.Services
{
    public class RestaurantService : IRestaurantService
    {
        private readonly IMapper _mapper;
        private readonly IRestaurantRepository _repo;
        private readonly IAzureStorage _blobStorage;

        public RestaurantService(IMapper mapper, IRestaurantRepository repository, IAzureStorage blobStorage)
        {
            _mapper = mapper;
            _repo = repository;
            _blobStorage = blobStorage;
        }

        public async Task<PagedEntities<RestaurantDto>> GetRestaurants(
            string? location,
            List<int>? cuisine,
            int? lowestPrice,
            int? highestPrice,
            string? sortOrder,
            int? pageNumber,
            int? pageSize)
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
            {
                return null;
            }

            return _mapper.Map<RestaurantDto>(restaurant);
        }

        public async Task<bool> UpdateRestaurant(int id, AddRestaurantDto dto)
        {
            var existingRestaurant = await _repo.GetRestaurant(id)
                ?? throw new ArgumentException($"Restaurant with ID {id} not found.");

            var incomingUrls = dto.Images
                .Where(i => !string.IsNullOrEmpty(i.Url))
                .Select(i => i.Url)
                .ToList();

            var redundantUrls = existingRestaurant.ImageUrls
                .Where(existing => !incomingUrls.Contains(existing.Url))
                .Select(i => i.Url)
                .ToList();

            foreach (var redundantUrl in redundantUrls)
            {
                await _blobStorage.DeleteAsync(redundantUrl, ContainerEnum.Restaurant);
            }

            var newUrls = new List<string>();

            foreach (var image in dto.Images.Where(i => string.IsNullOrEmpty(i.Url)))
            {
                var byteImage = Convert.FromBase64String(image.ImageBase64);
                var result = await _blobStorage.UploadAsync(byteImage, dto.Name, ContainerEnum.Restaurant);
                newUrls.Add(result.Blob.Uri);
            }

            var updatedImageUrls = incomingUrls
                .Concat(newUrls)
                .Select(url => new RestaurantImageUrl { Url = url })
                .ToList();

            var restaurant = _mapper.Map<Restaurant>(dto);

            restaurant.ImageUrls = updatedImageUrls;

            return await _repo.UpdateRestaurant(id, restaurant);
        }

        public async Task<RestaurantDto> AddRestaurant(AddRestaurantDto dto)
        {
            var restaurant = _mapper.Map<Restaurant>(dto);

            var imageUrls = new List<RestaurantImageUrl>();

            foreach (var image in dto.Images)
            {
                var byteImage = Convert.FromBase64String(image.ImageBase64);

                var result = await _blobStorage.UploadAsync(byteImage, dto.Name, ContainerEnum.Restaurant);

                imageUrls.Add(new(result.Blob.Uri));
            }

            restaurant.ImageUrls = imageUrls;

            var newRestaurant = await _repo.AddRestaurant(restaurant);

            return _mapper.Map<RestaurantDto>(newRestaurant);
        }

        public async Task<bool> DeleteRestaurant(int id)
            => await _repo.DeleteRestaurant(id);

        public async Task<PagedEntities<Restaurant>?> GetRestaurantRecomendation(int userId, int pageNumber, int pageSize)
        {
            var recomendedRestaurants = await _repo.GetRecomendedRestaurants(userId, pageNumber, pageSize);

            if (recomendedRestaurants == null)
                return null;

            return recomendedRestaurants;
        }
    }
}
