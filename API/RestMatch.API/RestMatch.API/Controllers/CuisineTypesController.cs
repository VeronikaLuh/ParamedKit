using Microsoft.AspNetCore.Mvc;
using RestMatch.API.Application.Dtos;
using RestMatch.API.Application.Interfaces;

namespace RestMatch.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CuisineTypesController : ControllerBase
    {
        private readonly ICuisineTypeService _service;

        public CuisineTypesController(ICuisineTypeService service)
        {
            _service = service;
        }

        [HttpGet]
        [ProducesResponseType(typeof(ICollection<GetCuisineTypeResponseDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<ActionResult<ICollection<GetCuisineTypeResponseDto>>> GetCuisineTypes()
        {
            var cuisineTypes = await _service.GetCuisineTypes();
            if (cuisineTypes.Count == 0)
                return NoContent();

            return Ok(cuisineTypes);
        }
    }
}
