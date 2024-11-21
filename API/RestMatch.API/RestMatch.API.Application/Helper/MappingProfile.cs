using System.Linq;
using AutoMapper;
using RestMatch.API.Application.Dtos;
using RestMatch.API.Domain.Models;

namespace RestMatch.API.Application.Helper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Restaurant, GetRestaurantResponseDto>();
            CreateMap<PutRestaurantRequestDto, Restaurant>();
            CreateMap<PostRestaurantRequestDto, Restaurant>();
            CreateMap<RestaurantImageUrl, GetRestaurantImageUrlResponseDto>();
            CreateMap<PutRestaurantImageUrlRequestDto, RestaurantImageUrl>();
            CreateMap<PostRestaurantImageUrlRequestDto, RestaurantImageUrl>();
            CreateMap<RestaurantCuisine, GetRestaurantCuisineResponseDto>();
            CreateMap<CuisineType, GetCuisineTypeResponseDto>();
        }
    }
}
