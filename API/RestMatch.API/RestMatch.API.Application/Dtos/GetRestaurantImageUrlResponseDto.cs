namespace RestMatch.API.Application.Dtos
{
    public class GetRestaurantImageUrlResponseDto : RestaurantImageUrlDtoBase
    {
        public int Id { get; set; }
        public int RestaurantId { get; set; }
    }
}
