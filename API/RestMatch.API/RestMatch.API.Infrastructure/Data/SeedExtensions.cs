using System;
using System.Collections.Generic;
using System.Linq;
using RestMatch.API.Domain.Models;

namespace RestMatch.API.Infrastructure.Data
{
    public static class SeedExtensions
    {
        public static void Initialize(IServiceProvider serviceProvider, ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Restaurants.Any())
                return;

            // Add dummy restaurants with price ranges
            List<Restaurant> restaurants = [
                new()
                {
                    Name = "The Golden Oak",
                    Country = "Fictivia",
                    City = "Oakland",
                    Address = "123 Forest Lane, Oakland",
                    Rating = 4.3,
                    LowerPrice = 20,
                    UpperPrice = 50,
                    OpeningTime = new TimeSpan(10, 0, 0),
                    ClosingTime = new TimeSpan(22, 0, 0),
                    PhoneNumber = "+1 234-567-8901",
                    AboutText = "A cozy restaurant in the heart of the forest, offering seasonal dishes.",
                    MenuUrl = "https://www.goldenoak.com/menu"
                },
                new()
                {
                    Name = "Luna’s Bistro",
                    Country = "Etherea",
                    City = "Moonlight",
                    Address = "45 Crescent Drive, Moonlight",
                    Rating = 4.7,
                    LowerPrice = 30,
                    UpperPrice = 75,
                    OpeningTime = new TimeSpan(11, 0, 0),
                    ClosingTime = new TimeSpan(23, 0, 0),
                    PhoneNumber = "+2 345-678-9012",
                    AboutText = "Serving fusion dishes with a magical twist.",
                    MenuUrl = "https://www.lunabistro.com/menu"
                },
                new()
                {
                    Name = "Crimson Barrel",
                    Country = "Fictivia",
                    City = "Redstone",
                    Address = "89 Ironwood Avenue, Redstone",
                    Rating = 4.5,
                    LowerPrice = 50,
                    UpperPrice = 150,
                    OpeningTime = new TimeSpan(12, 0, 0),
                    ClosingTime = new TimeSpan(23, 30, 0),
                    PhoneNumber = "+3 567-890-1234",
                    AboutText = "A steakhouse specializing in rare cuts and wines.",
                    MenuUrl = "https://www.crimsonbarrel.com/menu"
                },
                new()
                {
                    Name = "The Velvet Spoon",
                    Country = "Arcadia",
                    City = "Glimmerstone",
                    Address = "25 Sparkling Rd, Glimmerstone",
                    Rating = 4.2,
                    LowerPrice = 40,
                    UpperPrice = 80,
                    OpeningTime = new TimeSpan(8, 30, 0),
                    ClosingTime = new TimeSpan(20, 0, 0),
                    PhoneNumber = "+4 678-901-2345",
                    AboutText = "Upscale dining with an elegant atmosphere.",
                    MenuUrl = "https://www.velvetspoon.com/menu"
                },
                new()
                {
                    Name = "Seaside Grill",
                    Country = "Nautica",
                    City = "Oceanview",
                    Address = "101 Beachfront Blvd, Oceanview",
                    Rating = 4.6,
                    LowerPrice = 25,
                    UpperPrice = 60,
                    OpeningTime = new TimeSpan(9, 0, 0),
                    ClosingTime = new TimeSpan(21, 30, 0),
                    PhoneNumber = "+5 890-123-4567",
                    AboutText = "Fresh seafood and grill dishes with an ocean view.",
                    MenuUrl = "https://www.seasidegrill.com/menu"
                }
            ];
            foreach (var item in restaurants)
            {
                item.CreatedAt = DateTime.UtcNow;
                item.ModifiedAt = DateTime.UtcNow;
            }
            context.Restaurants.AddRange(restaurants);

            // Add dummy image urls
            string prefix = "http://example.com/";
            foreach (var item in restaurants)
            {
                string postfix = item.Name.ToLower().Replace(" ", "_");
                int imgCount = Random.Shared.Next(1, 3);
                for (int i = 0; i < imgCount; i++)
                {
                    var imageUrl = new RestaurantImageUrl()
                    {
                        Url = prefix + postfix + i.ToString(),
                        Restaurant = item,
                        CreatedAt = DateTime.UtcNow,
                        ModifiedAt = DateTime.UtcNow
                    };
                    context.RestaurantImageUrls.Add(imageUrl);
                }
            }

            // Add dummy cuisines
            var cuisineTypes = context.Cuisines.ToList();
            foreach (var item in restaurants)
            {
                // Coping list to prevent duplicate RestaurantCuisine
                var avaibleCuisineTypes = cuisineTypes.ToList();
                // WARN: Do not set maxValue in Random.Next to value more than cuisineTypes.Count
                for (int i = 0; i < Random.Shared.Next(1, 3); i++)
                {
                    int index = Random.Shared.Next(avaibleCuisineTypes.Count);
                    var type = avaibleCuisineTypes[index];
                    avaibleCuisineTypes.RemoveAt(index);
                    var restaurantCuisine = new RestaurantCuisine()
                    {
                        Restaurant = item,
                        Type = type,
                        CreatedAt = DateTime.UtcNow,
                        ModifiedAt = DateTime.UtcNow
                    };
                    context.RestaurantCuisines.Add(restaurantCuisine);
                }
            }

            context.SaveChanges();
        }
    }
}
