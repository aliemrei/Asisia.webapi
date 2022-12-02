using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using Asisia.webapi.Models.Db;
using Microsoft.IdentityModel.Tokens;

namespace Asisia.webapi.JWT;

public static class TokenService
{
    private const double EXPIRE_HOURS = 8;
        
    public static string CreateToken(Users user)
    {
        var key = Encoding.ASCII.GetBytes(Settings.Secret);
        var tokenHandler = new JwtSecurityTokenHandler();
        var descriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new Claim[]
            {
                new Claim("userId", user.Id.ToString()),
                new Claim(ClaimTypes.Name, user.Username.ToString()),
                new Claim(ClaimTypes.Role, "user" ),
                new Claim("corpId", user.Corpid.ToString())
            }),
            Expires = DateTime.UtcNow.AddHours(EXPIRE_HOURS),
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature),
            
        };
        var token = tokenHandler.CreateToken(descriptor);
 
        return tokenHandler.WriteToken(token);
    }
 
}