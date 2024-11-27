using RestMatch.API.Application.Interfaces;
using RestMatch.API.Domain.Interfaces;
using RestMatch.API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestMatch.API.Application.Services
{
    public class FavouritesService: IFavouritesService
    {
        private readonly IFavouritesRepository _favouritesRepository;
        public FavouritesService(IFavouritesRepository favouritesRepository)
        {
            _favouritesRepository = favouritesRepository;
        }

        public async Task AddNewFavourite(int userId, int restaurantId)
        {
            await _favouritesRepository.AddNewFavourite(restaurantId, userId);
        }

        public async Task<List<Favourite>?> GetFavourites(int userId)
        {
            var favourites = await _favouritesRepository.GetFavourites(userId);

            if(favourites == null)
            {
                return null;
            }

            return favourites;
        }

        public async Task DeleteFromFavourites(int favouriteId)
        {
            await _favouritesRepository.RemoveFromFavourites(favouriteId);
        }
    }
}
