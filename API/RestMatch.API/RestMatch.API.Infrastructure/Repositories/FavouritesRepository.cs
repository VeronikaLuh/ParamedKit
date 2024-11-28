using Microsoft.EntityFrameworkCore;
using RestMatch.API.Domain.Interfaces;
using RestMatch.API.Domain.Models;
using RestMatch.API.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestMatch.API.Infrastructure.Repositories
{
    public class FavouritesRepository: IFavouritesRepository
    {
        private readonly ApplicationDbContext _context;
        public FavouritesRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddNewFavourite(int restaurantId, int userId)
        {
            var result = await _context.Favourites.AddAsync( new Domain.Models.Favourite
            {
                RestaurantId = restaurantId,
                UserId = userId,
                CreatedAt = DateTime.Now,
            });
            await _context.SaveChangesAsync();
        }

        public async Task<List<Favourite>> GetFavourites(int userId)
        {
            var favourites = await _context.Favourites.Where(x => x.UserId == userId).Select(x => x).Include(x => x.Restaurant).ToListAsync();

            return favourites;
        }

        public async Task RemoveFromFavourites(int favouriteId)
        {
            var favourite = await _context.Favourites.FirstOrDefaultAsync(x => x.Id == favouriteId);

            if (favourite != null)
            {
                _context.Favourites.Remove(favourite);
                await _context.SaveChangesAsync();
            }
        }
    }
}
