using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Namotion.Reflection;
using RestMatch.API.Application.Dtos;
using RestMatch.API.Application.Interfaces;
using System.Security.Claims;

namespace RestMatch.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RateController : ControllerBase
    {
        private readonly IRateService _rateService;
        public RateController(IRateService rateService)
        {
            _rateService = rateService;
        }

        [HttpGet("{restaurantId}")]
        public async Task<ActionResult<IEnumerable<ReviewDto>>> GetAllReviews([FromRoute] int restaurantId)
        {
            var reviews = await _rateService.GetAllReviews(restaurantId);

            return Ok(reviews);
        }

        [HttpPost]
        [Authorize]
        public async Task<ActionResult> CreateNewRewiew([FromBody]ReviewDto model)
        {
            var userId = (User.Identity as ClaimsIdentity).FindFirst(ClaimTypes.NameIdentifier)?.Value;

            Console.WriteLine(userId);

            model.User = new()
            {
                Id = int.Parse(userId),
            };

            await _rateService.CreateReviewRerate(model);
            return Ok();
        }

        [HttpDelete("{reviewId}")]
        [Authorize]
        public async Task<ActionResult> DeleteReview([FromRoute] int reviewId)
        {
            var userId = (User.Identity as ClaimsIdentity).FindFirst(ClaimTypes.NameIdentifier)?.Value;

            await _rateService.DeleteReview(reviewId, int.Parse(userId));

            return Ok();
        }
    }
}
