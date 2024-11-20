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
            CreateMap<RestaurantImageUrl, GetRestaurantImageUrlResponseDto>()
                .ForMember(dest => dest.RestaurantId, opt => opt.MapFrom(src => src.Restaurant.Id));
            CreateMap<PutRestaurantImageUrlRequestDto, RestaurantImageUrl>();
            CreateMap<PostRestaurantImageUrlRequestDto, RestaurantImageUrl>();
            CreateMap<RestaurantCuisine, GetRestaurantCuisineResponseDto>()
                .ForMember(dest => dest.RestaurantId, opt => opt.MapFrom(src => src.Restaurant.Id))
                .ForMember(dest => dest.TypeId, opt => opt.MapFrom(src => src.Type.Id));
            CreateMap<CuisineType, GetCuisineTypeResponseDto>();
        }
    }
}
