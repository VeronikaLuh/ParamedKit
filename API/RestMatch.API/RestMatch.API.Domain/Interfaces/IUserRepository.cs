using RestMatch.API.Domain.Enums;
using RestMatch.API.Domain.Models.UserModels;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace RestMatch.API.Domain.Interfaces
{
    public interface IUserRepository
    {
        Task CreateUser(User user, IEnumerable<Roles> roles);

        Task<User?> FindUserByExpression(Expression<Func<User, bool>> expression);

        Task SaveChangesAsync();

        Task<IEnumerable<Role>> GetUserRoles(int id);
    }
}
