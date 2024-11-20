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

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<GetRestaurantResponseDto>> PostRestaurant(PostRestaurantRequestDto dto)
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
