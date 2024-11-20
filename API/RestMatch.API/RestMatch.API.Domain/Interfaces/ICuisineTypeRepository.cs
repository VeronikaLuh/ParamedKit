using System.Collections.Generic;
using System.Threading.Tasks;
using RestMatch.API.Domain.Models;

namespace RestMatch.API.Domain.Interfaces
{
    public interface ICuisineTypeRepository
    {
        Task<ICollection<CuisineType>> GetCuisineTypes();
    }
}
