using AutoMapper;
using RestMatch.API.Application.Dtos;
using RestMatch.API.Domain.Models;

namespace RestMatch.API.Application.Helper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Restaurant, RestaurantDto>().ReverseMap();
            CreateMap<Restaurant, AddRestaurantDto>().ReverseMap();
            CreateMap<RestaurantImageUrl, ImageUrlDto>().ReverseMap();
            CreateMap<RestaurantImageUrl, ImageDto>().ReverseMap();
            CreateMap<RestaurantCuisine, RestaurantCuisineDto>().ReverseMap();
            CreateMap<CuisineType, CuisineTypeDto>().ReverseMap();
        }
    }
}
