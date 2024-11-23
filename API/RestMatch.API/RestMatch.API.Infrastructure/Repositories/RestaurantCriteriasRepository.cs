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

        public async Task<List<RestaurantIdRate>> GetRestaurantCalculatedRate(List<int> cuisinesIds, int? page = 1)
        {
            var cuisineNames = cuisinesIds.Select(x => ((Cuisine)x).ToString());

            var query = await _context.Set<RestaurantCriteria>()
                .Select("new (RestaurantId, " + cuisineNames.Aggregate((current, next) => $"{current} + {next}") + " as Rate)")
                .ToDynamicListAsync();

            var result = query
                .Select(dynamicObj => new RestaurantIdRate
                {
                    RestaurantId = dynamicObj.RestaurantId,
                    Rate = (double)dynamicObj.Rate
                })
                .OrderByDescending(x => x.Rate)
                .ToList();
            return result;
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

            if(restaurantCriteria == null)
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
                        if(property1.Name == "CountOfRate" + property.Name)
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
