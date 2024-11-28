using Microsoft.EntityFrameworkCore;
using RestMatch.API.Domain.Interfaces;
using RestMatch.API.Domain.Models.UserModels;
using RestMatch.API.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestMatch.API.Infrastructure.Repositories
{
    public class UserSelectedCriteriasRepository : IUserSelectedCriteriasRepository
    {
        private readonly ApplicationDbContext _context;
        public UserSelectedCriteriasRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<int>> GetUserSelectedCriterias(int userId)
        {
            return await (from selectedUserCriterias in _context.UserSelectedCriterias
                   where selectedUserCriterias.UserId == userId
                   select selectedUserCriterias.CuisineId).ToListAsync();
        }

        public async Task AddNewCriteria(UserSelectedCriteria userSelectedCriteria)
        {
            await _context.UserSelectedCriterias.AddAsync(userSelectedCriteria);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateNewCriteria(UserSelectedCriteria userSelectedCriteria, int userId)
        {
            var selectedCriteria = await _context.UserSelectedCriterias.FirstOrDefaultAsync(x => x.UserId == userId);

            if (selectedCriteria == null)
            {
                return;
            }

            selectedCriteria.LowestPrice = userSelectedCriteria.LowestPrice;
            selectedCriteria.HighestPrice = userSelectedCriteria.HighestPrice;
            selectedCriteria.Location = userSelectedCriteria.Location;
            selectedCriteria.CuisineId = userSelectedCriteria.CuisineId;
            selectedCriteria.ModifiedAt = DateTime.UtcNow;

            _context.UserSelectedCriterias.Update(selectedCriteria);
            await _context.SaveChangesAsync();
        }
    }
}
