using Microsoft.EntityFrameworkCore;
using RestMatch.API.Domain.Enums;
using RestMatch.API.Domain.Interfaces;
using RestMatch.API.Domain.Models;
using RestMatch.API.Domain.Models.Recomendations;
using RestMatch.API.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq.Dynamic.Core;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace RestMatch.API.Infrastructure.Repositories
{
    public class RestaurantCriteriasRepository : IRestaurantCriteriasRepository
    {
        private readonly ApplicationDbContext _context;
        public RestaurantCriteriasRepository(ApplicationDbContext contex)
        {
            _context = contex;
        }

        public async Task<PagedEntities<RestaurantIdRate>> GetRestaurantCalculatedRate(int userId, List<int> cuisinesIds, int pageNumber, int pageSize)
        {
            var cuisineNames = cuisinesIds.Select(x => ((Cuisine)x).ToString());

            var userPriceAndLocation = _context.UserSelectedCriterias.FirstOrDefault(x => x.Id == userId);

            var orderedResult = _context.Restaurants
                .Where(x => ((x.UpperPrice + x.LowerPrice) / 2) <= ((userPriceAndLocation.LowestPrice + userPriceAndLocation.HighestPrice) / 2) && x.City != userPriceAndLocation.Location)
                .Select(x => x.Id);

            var list = await _context.Set<RestaurantCriteria>()
                .Select("new (RestaurantId, " + cuisineNames.Aggregate((current, next) => $"{current} + {next}") + " as Rate)")
                .Where($"@0.Contains(RestaurantId)", orderedResult).OrderBy("Rate descending")
                .Skip((pageNumber - 1) * pageSize).Take(pageSize).ToDynamicListAsync();

            int firstCount = await orderedResult.CountAsync();
            var secondOrderedResult = _context.Restaurants
                .Where(x => ((x.UpperPrice + x.LowerPrice) / 2) > ((userPriceAndLocation.LowestPrice + userPriceAndLocation.HighestPrice) / 2) && x.City != userPriceAndLocation.Location)
                .Select(x => x.Id);
            if (list.Count < pageSize)
            {
                var count = pageSize - list.Count;
                var secondList = await _context.Set<RestaurantCriteria>()
                    .Select("new (RestaurantId, " + cuisineNames.Aggregate((current, next) => $"{current} + {next}") + " as Rate)")
                    .Where($"@0.Contains(RestaurantId)", secondOrderedResult).OrderBy("Rate descending")
                    .Skip((pageNumber - 1) * pageNumber - firstCount).Take(count).ToDynamicListAsync();
                list.AddRange(secondList);
            }
            int secondCount = await secondOrderedResult.CountAsync();
            int totalCount = firstCount + secondCount;
            var totalPages = (int)Math.Ceiling(totalCount / (double)pageSize);

            var result = list
                .Select(dynamicObj => new RestaurantIdRate
                {
                    RestaurantId = dynamicObj.RestaurantId,
                    Rate = (double)dynamicObj.Rate
                }).ToList();

            return new PagedEntities<RestaurantIdRate>()
            {
                TotalPages = totalPages,
                Entities = result
            };
        }

        public async Task<RestaurantCriteria> GetRestaurantCriteriaAsync(int restaurantId)
        {
            var restaurantCriteria = await _context.RestaurantCriterias.FirstOrDefaultAsync(x => x.RestaurantId == restaurantId);
            if (restaurantCriteria == null)
                return null;

            return restaurantCriteria;
        }

        public async Task<bool> UpdateRestaurantCriteriaAsync(int rate, List<int> userSelectedCriterias, int restaurantId)
        {
            var restaurantCriteria = await _context.RestaurantCriterias.FirstOrDefaultAsync(x => x.RestaurantId == restaurantId);

            if (restaurantCriteria == null)
                return false;

            var type = restaurantCriteria.GetType();
            var listOfCriterias = userSelectedCriterias.Select(x => ((Cuisine)x).ToString());

            foreach (var property in type.GetProperties())
            {
                if (listOfCriterias.Contains(property.Name))
                {
                    int count = 1;
                    foreach (var property1 in type.GetProperties())
                    {
                        if (property1.Name == "CountOfRate" + property.Name)
                        {
                            count = (int)property1.GetValue(restaurantCriteria) + 1;
                            property1.SetValue(restaurantCriteria, count);
                            double updatedRate = ((double)property.GetValue(restaurantCriteria) * (count - 1) + rate) / count;
                            property.SetValue(restaurantCriteria, updatedRate);
                        }
                    }
                }
            }

            _context.RestaurantCriterias.Update(restaurantCriteria);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
