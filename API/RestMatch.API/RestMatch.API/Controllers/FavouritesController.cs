using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestMatch.API.Application.Interfaces;

namespace RestMatch.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FavouritesController : ControllerBase
    {
        private readonly IFavouritesService _favouritesService;
        public FavouritesController(IFavouritesService favouritesService)
        {
            _favouritesService = favouritesService;
        }

        [HttpPost]
        [Route("{restaurantId:int}")]
        public async Task<ActionResult> AddNewFavourite([FromRoute]int restaurantId)
        {
            int mockedUserId = 1;
            await _favouritesService.AddNewFavourite(mockedUserId, restaurantId);
            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult> GetFavourites()
        {
            int mockedUserId = 1;
            var favourites = await _favouritesService.GetFavourites(mockedUserId);
            if (favourites == null)
            {
                return NoContent();
            }

            return Ok(favourites);
        }

        [HttpDelete]
        [Route("{restaurantId:int}")]
        public async Task<ActionResult> RemoveFromFavourites([FromRoute] int restaurantId)
        {
            int mockedUserId = 1;
            await _favouritesService.DeleteFromFavourites(mockedUserId, restaurantId);
            return Ok();
        }
    }
}
