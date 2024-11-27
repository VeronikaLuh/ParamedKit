using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using RestMatch.API.Application.Dtos;
using RestMatch.API.Application.Interfaces;
using RestMatch.API.Domain.Interfaces;

namespace RestMatch.API.Application.Services
{
    public class CuisineTypeService : ICuisineTypeService
    {
        private readonly IMapper _mapper;
        private readonly ICuisineTypeRepository _repo;

        public CuisineTypeService(IMapper mapper, ICuisineTypeRepository repository)
        {
            _mapper = mapper;
            _repo = repository;
        }

        public async Task<ICollection<CuisineTypeDto>> GetCuisineTypes() =>
            _mapper.Map<List<CuisineTypeDto>>(await _repo.GetCuisineTypes());
    }
}
