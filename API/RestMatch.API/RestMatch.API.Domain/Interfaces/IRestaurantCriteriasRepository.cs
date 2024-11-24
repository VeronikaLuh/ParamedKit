using RestMatch.API.Domain.Models.Recomendations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestMatch.API.Domain.Interfaces
{
    public interface IRestaurantCriteriasRepository
    {
        Task<List<RestaurantIdRate>> GetRestaurantCalculatedRate(List<int> cuisinesIds, int? page = 1);
        Task<RestaurantCriteria> GetRestaurantCriteriaAsync(int restaurantId);
        Task<bool> UpdateRestaurantCriteriaAsync(int rate, List<int> userSelectedCriterias, int restaurantId);
    }
}
