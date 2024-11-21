using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RestMatch.API.Domain.Interfaces;
using RestMatch.API.Domain.Models;
using RestMatch.API.Infrastructure.Data;

namespace RestMatch.API.Infrastructure.Repositories
{
    public class CuisineTypeRepository : ICuisineTypeRepository
    {
        private readonly ApplicationDbContext _context;

        public CuisineTypeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ICollection<CuisineType>> GetCuisineTypes() =>
            await _context.Cuisines.ToListAsync();
    }
}
