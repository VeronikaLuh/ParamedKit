using System;
using System.Collections.Generic;

namespace RestMatch.API.Application.Dtos
{
    public class AddRestaurantDto
    {
        public int? Id { get; set; }

        public string Name { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public double Rating { get; set; }
        public int LowerPrice { get; set; }
        public int UpperPrice { get; set; }
        public TimeSpan OpeningTime { get; set; }
        public TimeSpan ClosingTime { get; set; }
        public string PhoneNumber { get; set; } = string.Empty;
        public string AboutText { get; set; } = string.Empty;
        public string MenuUrl { get; set; } = string.Empty;

        public IEnumerable<RestaurantCuisineDto> Cuisines { get; set; } = null!;
        public IEnumerable<ImageDto> Images { get; set; } = null!;
    }
}
