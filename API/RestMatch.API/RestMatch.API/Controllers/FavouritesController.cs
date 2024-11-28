using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestMatch.API.Application.Helper;
using RestMatch.API.Application.Interfaces;
using RestMatch.API.Domain.Models;

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
        [Authorize(AuthenticationSchemes = "Bearer")]
        public async Task<ActionResult> AddNewFavourite([FromRoute]int restaurantId)
        {
            var token = Request.Headers["Authorization"].ToString().Replace("Bearer ", "");
            var userId = TokenDecode.GetUserIdFromToken(token);

            if (userId == null)
            {
                return BadRequest("Can`t find user id in token");
            }
            await _favouritesService.AddNewFavourite(userId.Value, restaurantId);
            return Ok();
        }

        [HttpGet]
        [Authorize(AuthenticationSchemes = "Bearer")]
        public async Task<ActionResult<IEnumerable<Favourite>>> GetFavourites()
        {
            var token = Request.Headers["Authorization"].ToString().Replace("Bearer ", "");
            Console.WriteLine(token);
            if(token != null)
            {
                var userId = TokenDecode.GetUserIdFromToken(token);

                if (userId == null)
                {
                    return BadRequest("Can`t find user id in token");
                }
                var favourites = await _favouritesService.GetFavourites(userId.Value);
                if (favourites == null)
                {
                    return NoContent();
                }

                return Ok(favourites);
            }
            return BadRequest();
        }

        [HttpDelete]
        [Route("{favouriteId:int}")]
        [Authorize(AuthenticationSchemes = "Bearer")]
        public async Task<ActionResult> RemoveFromFavourites([FromRoute] int favouriteId)
        {
            await _favouritesService.DeleteFromFavourites(favouriteId);
            return Ok();
        }
    }
}
