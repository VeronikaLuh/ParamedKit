using RestMatch.API.Application.Dtos;
using RestMatch.API.Application.Interfaces;
using RestMatch.API.Domain.Interfaces;
using RestMatch.API.Domain.Models.UserModels;
using RestMatch.API.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestMatch.API.Application.Services
{
    public class UserSelectedCriteriaService: IUserSelectedCriteriaService
    {
        private readonly IUserSelectedCriteriasRepository _repository;
        public UserSelectedCriteriaService(IUserSelectedCriteriasRepository repository)
        {
            _repository = repository;
        }

        public async Task AddNewCriteria(UserSelectedCriteiaDto userSelectedCriteiaDto, int userId)
        {
            var newCriteria = new UserSelectedCriteria
            {
                CreatedAt = DateTime.Now,
                CuisineId = userSelectedCriteiaDto.CuisineId,
                HighestPrice = userSelectedCriteiaDto.HighestPrice,
                LowestPrice = userSelectedCriteiaDto.LowestPrice,
                Location = userSelectedCriteiaDto.Location,
                UserId = userId,
            };

            await _repository.AddNewCriteria(newCriteria);
        }

        public async Task UpdateUserCriterias(UserSelectedCriteiaDto userSelectedCriteiaDto, int userId)
        {
            var newCriteria = new UserSelectedCriteria
            {
                ModifiedAt = DateTime.Now,
                CuisineId = userSelectedCriteiaDto.CuisineId,
                HighestPrice = userSelectedCriteiaDto.HighestPrice,
                LowestPrice = userSelectedCriteiaDto.LowestPrice,
                Location = userSelectedCriteiaDto.Location,
            };

            await _repository.UpdateNewCriteria(newCriteria, userId);
        }
    }
}
