using RestMatch.API.Application.Dtos;
using RestMatch.API.Domain.Models.UserModels;
using System.Threading.Tasks;

namespace RestMatch.API.Application.Interfaces
{
    public interface IAuthService
    {
        string BuildToken(User user);
        Task<string> LoginUser(LoginDto loginDto);
        Task<string> RegisterUser(RegisterDto registerDto);
    }
}