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
            CreateMap<Restaurant, RestaurantDto>().ReverseMap();
            CreateMap<RestaurantImageUrl, ImageUrlDto>().ReverseMap();
            CreateMap<RestaurantCuisine, RestaurantCuisineDto>().ReverseMap();
            CreateMap<CuisineType, CuisineTypeDto>().ReverseMap();
        }
    }
}
