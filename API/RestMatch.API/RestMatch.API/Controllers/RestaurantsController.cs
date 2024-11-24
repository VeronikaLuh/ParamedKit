using Microsoft.AspNetCore.Mvc;
using RestMatch.API.Domain.Models;
using RestMatch.API.Application.Dtos;
using RestMatch.API.Application.Interfaces;
using RestMatch.API.Domain.Interfaces;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using RestMatch.API.Domain.Models.Recomendations;

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
        public async Task<ActionResult<PagedEntities<Restaurant>>> GetUserRecommendations([FromRoute] int faceUserId, [FromQuery] int pageNumber, [FromQuery] int pageSize)
        {
            var result = await _service.GetRestaurantRecomendation(faceUserId, pageNumber, pageSize);

            if (result == null)
            {
                return NoContent();
            }

            return Ok(result);
        }

        [HttpGet]
        [ProducesResponseType(typeof(PagedEntities<GetRestaurantResponseDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<ActionResult<PagedEntities<GetRestaurantResponseDto>>> GetRestaurants(
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
                return NoContent();

            return Ok(restaurants);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(GetRestaurantResponseDto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GetRestaurantResponseDto>> GetRestaurant(int id)
        {
            var restaurant = await _service.GetRestaurant(id);
            if (restaurant == null)
                return NotFound($"{nameof(Restaurant)} wasn't found");

            return Ok(restaurant);
        }

        [HttpGet("imageUrls/{id}")]
        [ProducesResponseType(typeof(GetRestaurantImageUrlResponseDto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GetRestaurantImageUrlResponseDto>> GetRestaurantImageUrl(int id)
        {
            var imageUrl = await _service.GetRestaurantImageUrl(id);
            if (imageUrl == null)
                return NotFound($"{nameof(RestaurantImageUrl)} wasn't found");

            return Ok(imageUrl);
        }

        [HttpGet("cuisines/{id}")]
        [ProducesResponseType(typeof(GetRestaurantCuisineResponseDto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GetRestaurantCuisineResponseDto>> GetRestaurantCuisine(int id)
        {
            var cuisine = await _service.GetRestaurantCuisine(id);
            if (cuisine == null)
                return NotFound($"{nameof(RestaurantCuisine)} wasn't found");

            return Ok(cuisine);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> PutRestaurant(int id, PutRestaurantRequestDto dto)
        {
            if (!await _service.UpdateRestaurant(id, dto))
                return NotFound($"{nameof(Restaurant)} wasn't found");

            return NoContent();
        }

        [HttpPut("imageUrls/{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> PutRestaurantImageUrl(int id, PutRestaurantImageUrlRequestDto dto)
        {
            if (!await _service.UpdateRestaurantImageUrl(id, dto))
                return NotFound($"{nameof(RestaurantImageUrl)} wasn't found");

            return NoContent();
        }

        [HttpPost]
        [ProducesResponseType(typeof(GetRestaurantResponseDto), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<GetRestaurantResponseDto>> PostRestaurant(PostRestaurantRequestDto dto)
        {
            var restaurant = await _service.AddRestaurant(dto);
            return CreatedAtAction(nameof(GetRestaurant), new { id = restaurant.Id }, restaurant);
        }

        [HttpPost("{restaurantId}/imageUrls")]
        [ProducesResponseType(typeof(GetRestaurantImageUrlResponseDto), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GetRestaurantImageUrlResponseDto>> PostRestaurantImageUrl(int restaurantId, PostRestaurantImageUrlRequestDto dto)
        {
            var imageUrl = await _service.AddRestaurantImageUrl(restaurantId, dto);
            if (imageUrl == null)
                return NotFound($"{nameof(Restaurant)} wasn't found");

            return CreatedAtAction(nameof(GetRestaurantImageUrl), new { id = imageUrl.Id }, imageUrl);
        }

        [HttpPost("{restaurantId}/cuisines")]
        [ProducesResponseType(typeof(GetRestaurantCuisineResponseDto), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GetRestaurantCuisineResponseDto>> PostRestaurantCuisine(int restaurantId, PostRestaurantCuisineRequestDto dto)
        {
            var cuisine = await _service.AddRestaurantCuisine(restaurantId, dto);
            if (cuisine == null)
                return NotFound($"{nameof(Restaurant)} or {nameof(CuisineType)} weren't found");

            return CreatedAtAction(nameof(GetRestaurantCuisine), new { id = cuisine.Id }, cuisine);
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

        [HttpDelete("imageUrls/{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteRestaurantImageUrl(int id)
        {
            if (!await _service.DeleteRestaurantImageUrl(id))
                return NotFound($"{nameof(RestaurantImageUrl)} wasn't found");

            return NoContent();
        }

        [HttpDelete("cuisines/{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteRestaurantCuisine(int id)
        {
            if (!await _service.DeleteRestaurantCuisine(id))
                return NotFound($"{nameof(RestaurantCuisine)} wasn't found");

            return NoContent();
        }
    }
}
