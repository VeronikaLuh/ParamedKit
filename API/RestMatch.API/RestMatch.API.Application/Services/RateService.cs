using RestMatch.API.Application.Dtos;
using RestMatch.API.Application.Interfaces;
using RestMatch.API.Domain.Enums;
using RestMatch.API.Domain.Interfaces;
using RestMatch.API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestMatch.API.Application.Services
{
    public class RateService: IRateService
    {
        private readonly IUserSelectedCriteriasRepository _userSelectedCriteriasRepository;
        private readonly IReviewRepository _reviewRepository;
        private readonly IRestaurantCriteriasRepository _restaurantCriteriasRepository;
        private readonly IRestaurantRepository _restaurantRepository;
        private readonly IUserRepository _userRepository;
        public RateService(
            IUserSelectedCriteriasRepository userSelectedCriteriasRepository, 
            IReviewRepository reviewRepository, 
            IRestaurantCriteriasRepository restaurantCriteriasRepository, 
            IRestaurantRepository restaurantRepository,
            IUserRepository userRepository)
        {
            _userSelectedCriteriasRepository = userSelectedCriteriasRepository;
            _reviewRepository = reviewRepository;
            _restaurantCriteriasRepository = restaurantCriteriasRepository;
            _restaurantRepository = restaurantRepository;
            _userRepository = userRepository;
        }

        public async Task CreateReviewRerate(ReviewDto model)
        {
            var review = new Review() 
            {
                RestaurantId = model.RestaurantId,
                Rating = model.Rating,
                CreatedAt = DateTime.Now,
                Text = model.Text,
                Title = model.Title,
                UserId = model.User.Id,
            };
            await _reviewRepository.CreateNewReview(review);
            await _reviewRepository.SaveChangesAsync();

            var restaurant = await _restaurantRepository.GetRestaurant(model.RestaurantId);
            restaurant.Rating = (restaurant.Rating * restaurant.CountOfRate + model.Rating) / (restaurant.CountOfRate + 1);
            restaurant.CountOfRate += 1;
            await _restaurantRepository.UpdateRestaurant(model.RestaurantId, restaurant);

            var userSelectedCriterias = await _userSelectedCriteriasRepository.GetUserSelectedCriterias(model.User.Id);

            await _restaurantCriteriasRepository.UpdateRestaurantCriteriaAsync(model.Rating, userSelectedCriterias, model.RestaurantId);
        }

        public async Task<IEnumerable<ReviewDto>> GetAllReviews(int restaurantId)
        {
            var reviews = await _reviewRepository.GetReviews(i => i.RestaurantId == restaurantId);

            return reviews.Select(entity => new ReviewDto
            {
                Id = entity.Id,
                RestaurantId = entity.RestaurantId,
                Rating = entity.Rating,
                Text = entity.Text,
                Title = entity.Title,
                User = new()
                {
                    Id = entity.User.Id,
                    NickName = entity.User.Nickname,
                    ImageUrl = entity.User.ImageUrl
                }
            });
        }

        public async Task DeleteReview(int reviewId, int userId)
        {
            var review = await _reviewRepository.GetReviewById(reviewId)
                ?? throw new ArgumentException("Review with such id does not exist");

            var user = await _userRepository.FindUserByExpression(i => i.Id == userId);

            if (user.Id != userId)
            {
                var isUserAdmin = user.Role.Select(i => i.RoleName).Contains(Roles.Admin.ToString());

                if (!isUserAdmin)
                {
                    throw new UnauthorizedAccessException("User has no rights");
                }
            }

            _reviewRepository.DeleteReview(review);
            await _reviewRepository.SaveChangesAsync();
        }
    }
}
