using System.Collections.Generic;

namespace RestMatch.API.Application.Dtos
{
    public class GetRestaurantResponseDto : RestaurantDtoBase
    {
        public int Id { get; set; }

        public IEnumerable<GetRestaurantCuisineResponseDto> Cuisines { get; set; } = null!;
        public IEnumerable<GetRestaurantImageUrlResponseDto> ImageUrls { get; set; } = null!;
    }
}
