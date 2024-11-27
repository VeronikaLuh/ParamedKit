using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestMatch.API.Application.Helper
{
    public static class TokenDecode
    {
        public static int? GetUserIdFromToken(string token)
        {
            var handler = new JwtSecurityTokenHandler();
            var jsonToken = handler.ReadToken(token) as JwtSecurityToken;

            var userId = jsonToken.Payload["sub"];
            Console.WriteLine(userId);
            if (userId != null)
            {
                return Int32.Parse(userId.ToString());
            }
            return null;
        }
    }
}
