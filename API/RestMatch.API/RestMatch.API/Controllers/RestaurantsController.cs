using Microsoft.AspNetCore.Mvc;
using RestMatch.API.Domain.Models;
using RestMatch.API.Application.Dtos;
using RestMatch.API.Application.Interfaces;

namespace RestMatch.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantsController : ControllerBase
    {
        private readonly IRestaurantService _service;

        public RestaurantsController(IRestaurantService service)
        {
            _service = service;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<ActionResult<ICollection<GetRestaurantResponseDto>>> GetRestaurants()
        {
            var restaurants = await _service.GetRestaurants();
            if (restaurants.Count == 0)
            {
                return NoContent();
            }
            return Ok(restaurants);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GetRestaurantResponseDto>> GetRestaurant(int id)
        {
            var restaurant = await _service.GetRestaurant(id);
            if (restaurant == null)
            {
                return NotFound($"{nameof(Restaurant)} wasn't found");
            }
            return Ok(restaurant);
        }

        [HttpGet("imageUrls/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GetRestaurantImageUrlResponseDto>> GetRestaurantImageUrl(int id)
        {
            var imageUrls = await _service.GetRestaurantImageUrl(id);
            if (imageUrls == null)
                return NotFound($"{nameof(RestaurantImageUrl)} wasn't found");

            return Ok(imageUrls);
        }

        [HttpGet("{restaurantId}/imageUrls")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ICollection<GetRestaurantImageUrlResponseDto>>> GetRestaurantImageUrls(int restaurantId)
        {
            var imageUrls = await _service.GetRestaurantImageUrls(restaurantId);
            if (imageUrls == null)
                return NotFound($"{nameof(Restaurant)} wasn't found");

            if (imageUrls.Count == 0)
                return NoContent();

            return Ok(imageUrls);
        }

        [HttpGet("cuisines/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GetRestaurantCuisineResponseDto>> GetRestaurantCuisine(int id)
        {
            var cuisine = await _service.GetRestaurantCuisine(id);
            if (cuisine == null)
                return NotFound($"{nameof(RestaurantCuisine)} wasn't found");

            return Ok(cuisine);
        }

        [HttpGet("{restaurantId}/cuisines")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ICollection<GetRestaurantCuisineResponseDto>>> GetRestaurantCuisines(int restaurantId)
        {
            var cuisines = await _service.GetRestaurantCuisines(restaurantId);
            if (cuisines == null)
                return NotFound($"{nameof(Restaurant)} wasn't found");

            if (cuisines.Count == 0)
                return NoContent();

            return Ok(cuisines);
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
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<GetRestaurantResponseDto>> PostRestaurant(PostRestaurantRequestDto dto)
        {
            var restaurant = await _service.AddRestaurant(dto);
            return CreatedAtAction(nameof(GetRestaurant), new { id = restaurant.Id }, restaurant);
        }

        [HttpPost("{restaurantId}/imageUrls")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GetRestaurantResponseDto>> PostRestaurantImageUrl(int restaurantId, PostRestaurantImageUrlRequestDto dto)
        {
            var imageUrl = await _service.AddRestaurantImageUrl(restaurantId, dto);
            if (imageUrl == null)
                return NotFound($"{nameof(Restaurant)} wasn't found");

            return CreatedAtAction(nameof(GetRestaurantImageUrl), new { id = imageUrl.Id }, imageUrl);
        }

        [HttpPost("{restaurantId}/cuisines")]
        [ProducesResponseType(StatusCodes.Status201Created)]
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
