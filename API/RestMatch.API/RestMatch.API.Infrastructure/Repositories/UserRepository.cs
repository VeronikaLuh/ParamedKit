using Microsoft.EntityFrameworkCore;
using RestMatch.API.Domain.Interfaces;
using RestMatch.API.Domain.Models.UserModel;
using RestMatch.API.Domain.Models.UserModels;
using RestMatch.API.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RestMatch.API.Infrastructure.Repositories
{
    internal class UserRepository(ApplicationDbContext _context) : IUserRepository
    {
        public async Task CreateUser(User user)
        {
            await _context.Users.AddAsync(user);
        }

        public async Task<User?> FindUserByExpression(Expression<Func<User, bool>> expression)
        {
            return await _context.Users.FirstOrDefaultAsync(expression);
        }

        public async Task<IEnumerable<Role>> GetUserRole(int id)
        {
            var user = await _context.Users.Include(i => i.Role).FirstOrDefaultAsync(i => i.Id == id);

            return user.Role;
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
