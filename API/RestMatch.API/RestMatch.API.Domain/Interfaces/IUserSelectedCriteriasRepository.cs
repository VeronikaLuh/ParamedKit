using RestMatch.API.Domain.Models.UserModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestMatch.API.Domain.Interfaces
{
    public interface IUserSelectedCriteriasRepository
    {
        Task<List<int>> GetUserSelectedCriterias(int userId);
        Task AddNewCriteria(UserSelectedCriteria userSelectedCriteria);
        Task UpdateNewCriteria(UserSelectedCriteria userSelectedCriteria, int userId);
    }
}
