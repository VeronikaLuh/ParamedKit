using RestMatch.API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestMatch.API.Application.Interfaces
{
    public interface IFavouritesService
    {
        Task AddNewFavourite(int userId, int restaurantId);
        Task<List<Favourite>?> GetFavourites(int userId);
        Task DeleteFromFavourites(int favouriteId);
    }
}
