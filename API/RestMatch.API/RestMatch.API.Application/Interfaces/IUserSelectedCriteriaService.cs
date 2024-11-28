using RestMatch.API.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestMatch.API.Application.Interfaces
{
    public interface IUserSelectedCriteriaService
    {
        Task AddNewCriteria(UserSelectedCriteiaDto userSelectedCriteiaDto, int userId);
        Task UpdateUserCriterias(UserSelectedCriteiaDto userSelectedCriteiaDto, int userId);
    }
}
