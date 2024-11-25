using Microsoft.AspNetCore.Mvc;
using RestMatch.API.Application.Dtos;
using RestMatch.API.Application.Interfaces;

namespace RestMatch.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        public async Task<ActionResult<string>> Login(LoginDto loginDto)
        {
            var token = string.Empty;

            try
            {
                token = await _authService.LoginUser(loginDto);
            } 
            catch (Exception ex)
            {
                return Unauthorized(new { message = ex.Message });
            }

            return Ok(token);
        }

        public async Task<ActionResult<string>> Register(RegisterDto registerDto)
        {
            var token = await _authService.RegisterUser(registerDto);

            return Ok(token);
        }
    }
}
