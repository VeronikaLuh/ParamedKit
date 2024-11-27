using RestMatch.API.Domain.Models;
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
        Task<PagedEntities<RestaurantIdRate>> GetRestaurantCalculatedRate(int userId, List<int> cuisinesIds, int pageNumber, int pageSize);
        Task<RestaurantCriteria> GetRestaurantCriteriaAsync(int restaurantId);
        Task<bool> UpdateRestaurantCriteriaAsync(int rate, List<int> userSelectedCriterias, int restaurantId);
    }
}
