using System.Collections.Generic;
using System.Threading.Tasks;
using RestMatch.API.Application.Dtos;

namespace RestMatch.API.Application.Interfaces
{
    public interface ICuisineTypeService
    {
        Task<ICollection<GetCuisineTypeResponseDto>> GetCuisineTypes();
    }
}
