using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestMatch.API.Application.Dtos;
using RestMatch.API.Application.Helper;
using RestMatch.API.Application.Interfaces;

namespace RestMatch.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserSelectedCriteriaController : ControllerBase
    {
        private readonly IUserSelectedCriteriaService _userSelectedCriteriaService;
        public UserSelectedCriteriaController(IUserSelectedCriteriaService userSelectedCriteriaService)
        {
            _userSelectedCriteriaService = userSelectedCriteriaService;
        }

        [HttpPost]
        [Authorize(AuthenticationSchemes = "Bearer")]
        public async Task<ActionResult> AddUserCriteias([FromBody] UserSelectedCriteiaDto userSelectedCriteiaDto)
        {
            var token = Request.Headers["Authorization"].ToString().Replace("Bearer ", "");
            var userId = TokenDecode.GetUserIdFromToken(token);

            if (userId == null)
            {
                return BadRequest("Can`t find user id in token");
            }

            await _userSelectedCriteriaService.AddNewCriteria(userSelectedCriteiaDto, userId.Value);
            return Ok();
        }

        [HttpPut]
        [Authorize(AuthenticationSchemes = "Bearer")]
        public async Task<ActionResult> UpdateUserCriteias([FromBody] UserSelectedCriteiaDto userSelectedCriteiaDto)
        {
            var token = Request.Headers["Authorization"].ToString().Replace("Bearer ", "");
            var userId = TokenDecode.GetUserIdFromToken(token);

            if (userId == null)
            {
                return BadRequest("Can`t find user id in token");
            }

            await _userSelectedCriteriaService.UpdateUserCriterias(userSelectedCriteiaDto, userId.Value);
            return Ok();
        }
    }
}
