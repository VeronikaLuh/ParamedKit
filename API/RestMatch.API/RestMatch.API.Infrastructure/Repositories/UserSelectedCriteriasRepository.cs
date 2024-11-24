using Microsoft.EntityFrameworkCore;
using RestMatch.API.Domain.Interfaces;
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
    }
}
