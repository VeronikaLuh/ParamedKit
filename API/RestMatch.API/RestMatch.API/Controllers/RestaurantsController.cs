using Microsoft.AspNetCore.Mvc;
using RestMatch.API.Domain.Models;
using RestMatch.API.Application.Dtos;
using RestMatch.API.Application.Interfaces;
using RestMatch.API.Domain.Interfaces;
using RestMatch.API.Application.Helper;
using Microsoft.AspNetCore.Authorization;

namespace RestMatch.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantsController : ControllerBase
    {
        private readonly IRestaurantService _service;
        private readonly IRestaurantCriteriasRepository _restaurantCriteriasRepository;

        public RestaurantsController(IRestaurantService service, IRestaurantCriteriasRepository restaurantCriteriasRepository)
        {
            _service = service;
            _restaurantCriteriasRepository = restaurantCriteriasRepository;
        }

        [HttpGet]
        [Route("hello/{faceUserId:int}")]
        [Authorize(AuthenticationSchemes = "Bearer")]
        public async Task<ActionResult<PagedEntities<Restaurant>>> GetUserRecommendations([FromQuery] int pageNumber, [FromQuery] int pageSize)
        {
            var token = Request.Headers["Authorization"].ToString().Replace("Bearer ", "");
            var userId = TokenDecode.GetUserIdFromToken(token);

            if (userId == null)
            {
                return BadRequest("Can`t find user id in token");
            }

            var result = await _service.GetRestaurantRecomendation(userId.Value, pageNumber, pageSize);

            if (result == null)
            {
                return NoContent();
            }

            return Ok(result);
        }

        [HttpGet]
        [ProducesResponseType(typeof(PagedEntities<RestaurantDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<ActionResult<PagedEntities<RestaurantDto>>> GetRestaurants(
            [FromQuery] string? location,
            [FromQuery] List<int>? cuisine,
            [FromQuery] int? lowestPrice,
            [FromQuery] int? highestPrice,
            [FromQuery] string? sortOrder,
            [FromQuery] int pageNumber,
            [FromQuery] int pageSize)
        {
            var restaurants = await _service.GetRestaurants(location, cuisine, lowestPrice, highestPrice, sortOrder, pageNumber, pageSize);
            
            if (restaurants.Entities.Count == 0)
            {
                return NoContent();
            }

            return Ok(restaurants);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(RestaurantDto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<RestaurantDto>> GetRestaurant(int id)
        {
            var restaurant = await _service.GetRestaurant(id);

            if (restaurant == null)
            {
                return NotFound($"{nameof(Restaurant)} wasn't found");
            }

            return Ok(restaurant);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> PutRestaurant(int id, AddRestaurantDto dto)
        {
            if (!await _service.UpdateRestaurant(id, dto))
            {
                return NotFound($"{nameof(Restaurant)} wasn't found");
            }

            return NoContent();
        }

        [HttpPost]
        [ProducesResponseType(typeof(RestaurantDto), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<RestaurantDto>> PostRestaurant(AddRestaurantDto dto)
        {
            var restaurant = await _service.AddRestaurant(dto);

            return CreatedAtAction(nameof(GetRestaurant), new { id = restaurant.Id }, restaurant);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteRestaurant(int id)
        {
            if (!await _service.DeleteRestaurant(id))
                return NotFound($"{nameof(Restaurant)} wasn't found");

            return NoContent();
        }
    }
}
