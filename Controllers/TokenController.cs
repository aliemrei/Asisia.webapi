
using Asisia.webapi.JWT;
using Asisia.webapi.Models;
using Asisia.webapi.Models.Db;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;

[Route("/v2")]
[ApiController]
[AllowAnonymous]
[Route("[controller]")]
public class TokenController : ControllerBase
 
{
    private readonly DBContext Context;
    private string Hash(string input)
    {
        using (SHA1Managed sha1 = new SHA1Managed())
        {
            var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(input));
            var sb = new StringBuilder(hash.Length * 2);

            foreach (byte b in hash)
            {
                // can be "x2" if you want lowercase
                sb.Append(b);
            }

            return sb.ToString();
        }
    }

    public TokenController(DBContext context)
    {
        Context = context;
    }

    [HttpPost]
    [Route("token")]
    [AllowAnonymous]
    
    public async Task<ActionResult<dynamic>> Authenticate([FromBody] LoginUserModel model)
    {
        var user = Context.Users.IgnoreQueryFilters().FirstOrDefault(x => x.Username == model.Username && x.Corp.Intid == model.CorpId);

        if (user == null || user.Password != Hash(model.Password))
            return NotFound(new { message = "User or password invalid" });

        var token = TokenService.CreateToken(user);

        user.Password = "";
        return new
        {
            user = new LogedUserModel { username = user.Username, email = user.Email, fullName = user.Fullname, tel = user.Tel1 },
            access_token = token
        };
    }

    [HttpGet]
    [Route("authenticated")]
    [Authorize]
    public string Authenticated() => String.Format("Authenticated - {0}", User.Identity.Name);
    
}