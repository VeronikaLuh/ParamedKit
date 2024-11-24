using RestMatch.API.Application.Dtos;
using RestMatch.API.Application.Interfaces;
using RestMatch.API.Domain.Interfaces;
using RestMatch.API.Domain.Models;
using RestMatch.API.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestMatch.API.Application.Services
{
    public class RateService: IRateService
    {
        private readonly IUserSelectedCriteriasRepository _userSelectedCriteriasRepository;
        private readonly IReviewRepository _reviewRepository;
        private readonly IRestaurantCriteriasRepository _restaurantCriteriasRepository;
        private readonly IRestaurantRepository _restaurantRepository;
        public RateService(
            IUserSelectedCriteriasRepository userSelectedCriteriasRepository, 
            IReviewRepository reviewRepository, 
            IRestaurantCriteriasRepository restaurantCriteriasRepository, 
            IRestaurantRepository restaurantRepository)
        {
            _userSelectedCriteriasRepository = userSelectedCriteriasRepository;
            _reviewRepository = reviewRepository;
            _restaurantCriteriasRepository = restaurantCriteriasRepository;
            _restaurantRepository = restaurantRepository;
        }

        public async Task CreateReviewRerate(CreateReviewDto model)
        {
            var review = new Review() 
            {
                RestaurantId = model.RestaurantId,
                Rating = model.Rating,
                CreatedAt = DateTime.Now,
                Text = model.Text,
                Title = model.Title,
                UserId = model.UserId,
            };
            await _reviewRepository.CreateNewReview(review);

            var restaurant = await _restaurantRepository.GetRestaurant(model.RestaurantId);
            restaurant.Rating = (restaurant.Rating * restaurant.CountOfRate + model.Rating) / (restaurant.CountOfRate + 1);
            restaurant.CountOfRate += 1;
            await _restaurantRepository.UpdateRestaurant(model.RestaurantId, restaurant);

            var userSelectedCriterias = await _userSelectedCriteriasRepository.GetUserSelectedCriterias(model.UserId);

            var result = await _restaurantCriteriasRepository.UpdateRestaurantCriteriaAsync(model.Rating, userSelectedCriterias, model.RestaurantId);

        }
    }
}
