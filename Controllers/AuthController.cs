using Asisia.webapi.Models.Db;
using Asisia.webapi.Models.DbDesign;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace Asisia.webapi.Controllers;


[ApiController]
[Route("v2/[controller]")]
public class AuthController : ControllerBase
{
    private readonly ILogger<AuthController> _logger;
    private readonly DBDesignContext _designContext;
    private readonly DBContext _context;

    public AuthController(ILogger<AuthController> logger,
           DBDesignContext designContext, DBContext context)
    {
        _logger = logger;

        this._designContext = designContext;

        this._context = context;
    }

    [HttpGet]
    public IActionResult Get(string name)
    {

        if (Guid.TryParse(User?.Claims?.FirstOrDefault(x => x.Type == "userId")?.Value, out var userId))
        {
            

            var auth =_context.UserRoles
                    .Where(u => u.Userid == userId)
                    .SelectMany(u => u.Role.RoleAuth.Select(ra => new { 
                        ra.Modulename, 
                        Canadd = Convert.ToInt32(ra.Canadd), 
                        Candelete = Convert.ToInt32(ra.Candelete), 
                        Canedit = Convert.ToInt32(ra.Canedit), 
                        Canexport = Convert.ToInt32(ra.Canexport), 
                        Canlist = Convert.ToInt32(ra.Canlist), 
                        Canprint = Convert.ToInt32(ra.Canprint), 
                        Canview = Convert.ToInt32(ra.Canview)  
                    }) )
                    .Where(g => g.Modulename == name)
                    .GroupBy(g => g.Modulename)
                    .Select(ra =>  new { 
                        Modulename = ra.Key, 
                        Canadd = ra.Max(x => x.Canadd),
                        Candelete = ra.Max(x => x.Candelete),
                        Canedit = ra.Max(x => x.Canedit),
                        Canexport = ra.Max(x => x.Canexport),
                        Canlist = ra.Max(x => x.Canlist),
                        Canprint = ra.Max(x => x.Canprint),
                        Canview = ra.Max(x => x.Canview)
                    }).FirstOrDefault();
                    
            var design = _designContext.Designes.FirstOrDefault(x => x.Name == name);

          

            return Ok(new {
                Design = design?.Design,
                auth.Modulename,
                Canadd = auth.Canadd == 1,
                Candelete = auth.Candelete  == 1,
                Canedit = auth.Canedit == 1,
                Canexport = auth.Canexport == 1,
                Canlist = auth.Canlist == 1,
                Canprint = auth.Canprint == 1,
                Canview = auth.Canview == 1
            });
        }

        return BadRequest(new Exception("Login error!"));
    }

/*
    [HttpGet(Name = "UserMenu")]
    public IActionResult UserMenu()
    {
        
        return Ok(_designContext.CustomMenu.Select(x => new {
            text = x.Text,
            authname = x.Authname,
            icon = x.Icon,
            id = x.Id,
            inverseParent = x.InverseParent,
            parent = x.Parent,
            parentid = x.Parentid
            
        }).ToList());
    }
    */
}
