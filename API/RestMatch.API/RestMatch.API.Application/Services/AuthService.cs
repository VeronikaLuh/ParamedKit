using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Authentication;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using RestMatch.API.Application.Dtos;
using RestMatch.API.Application.Interfaces;
using RestMatch.API.Domain.Interfaces;
using RestMatch.API.Domain.Models.UserModels;

namespace RestMatch.API.Application.Services
{
    internal class AuthService(IUserRepository _userRepository, IConfiguration _configuration) : IAuthService
    {
        public async Task<string> RegisterUser(RegisterDto registerDto)
        {
            var userWithSameEmail = await _userRepository.FindUserByExpression(i => i.Email == registerDto.Email);

            if (userWithSameEmail != null)
            {
                throw new AuthenticationException($"Email {registerDto.Email} is already in use");
            }

            var userWithSameNickname = await _userRepository.FindUserByExpression(i => i.Nickname == registerDto.Nickname);

            if (userWithSameNickname != null)
            {
                throw new AuthenticationException($"Nickname {registerDto.Nickname} is already in use");
            }

            CreatePasswordHash(registerDto.Password, out byte[] passwordHash, out byte[] passwordSalt);

            var user = new User()
            {
                Email = registerDto.Email,
                FirstName = registerDto.FirstName,
                LastName = registerDto.LastName,
                Nickname = registerDto.Nickname,
                UserRoleId = 1
            };

            await _userRepository.CreateUser(user);
            await _userRepository.SaveChangesAsync();

            return BuildToken(user);
        }

        public async Task<string> LoginUser(LoginDto loginDto)
        {
            var user = await _userRepository.FindUserByExpression(i => i.Nickname == loginDto.Nickname)
                ?? throw new AuthenticationException($"User with that nickname doesn`t exist");
            
            byte[] passwordHash = JsonConvert.DeserializeObject<byte[]>(user.PasswordHash);
            byte[] passwordSalt = JsonConvert.DeserializeObject<byte[]>(user.PasswordSalt);

            if (!VerifyPasswordHash(loginDto.Password, passwordHash, passwordSalt))
            {
                throw new AuthenticationException("Log in failure. Try to verify your credentials.");
            }

            return BuildToken(user);
        }

        public string BuildToken(User user)
        {
            var claims = new List<Claim>
            {
                new("sub", user.Id.ToString()),
                new(ClaimTypes.Name, user.Nickname),
                new(ClaimTypes.Email, user.Email),
                new(ClaimTypes.Role, user.Role.ToString())
            };

            var securityKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(
                _configuration.GetSection("AppSettings:Secret").Value));

            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature);

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        private static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using var hmac = new HMACSHA256();

            passwordSalt = hmac.Key;
            passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
        }

        private static bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using var hmac = new HMACSHA256(passwordSalt);

            var computeHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            return computeHash.SequenceEqual(passwordHash);
        }
    }
}
