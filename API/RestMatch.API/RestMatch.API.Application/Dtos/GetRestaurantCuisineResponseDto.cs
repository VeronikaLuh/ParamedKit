namespace RestMatch.API.Application.Dtos
{
    public class GetRestaurantCuisineResponseDto : RestaurantCuisineDtoBase
    {
        public int Id { get; set; }
        public int RestaurantId { get; set; }
    }
}
