using RestMatch.API.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestMatch.API.Domain.Interfaces
{
    public interface IFavouritesRepository
    {
        Task AddNewFavourite(int restaurantId, int userId);
        Task<List<Favourite>> GetFavourites(int userId);
        Task RemoveFromFavourites(int favouriteId);
    }
}
    