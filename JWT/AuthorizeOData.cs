using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Security.Claims;

namespace Asisia.webapi.JWT;
public class AuthorizeODataAttribute : TypeFilterAttribute
{
    public AuthorizeODataAttribute(string claimType, string claimValue) : base(typeof(AuthorizeODataFilter))
    {
        Arguments = new object[] { new Claim(claimType, claimValue) };
    }
}

public class AuthorizeODataFilter : IAuthorizationFilter
{
    readonly Claim _claim;

    public AuthorizeODataFilter(Claim claim)
    {
        _claim = claim;
    }

    public void OnAuthorization(AuthorizationFilterContext context)
    {
        var hasClaim = context.HttpContext.User?.Identity?.IsAuthenticated ?? false; // context.HttpContext.User.Claims.Any(c => c.Type == _claim.Type && c.Value == _claim.Value);
        if (!hasClaim)
        {
            context.Result = new ForbidResult();
        }
    }
}