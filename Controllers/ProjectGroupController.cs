using Microsoft.AspNetCore.Mvc;
using Asisia.webapi.Repositories;
using Asisia.webapi.Models.Db;
using Microsoft.AspNetCore.OData.Query;

namespace Asisia.webapi.Controllers;


public sealed class ProjectGroupController : BaseController<ProjectGroup, IGenericRepository<ProjectGroup>>
{ 
    public ProjectGroupController(ILogger<ProjectGroup> logger, DBContext context, 
        IGenericRepository<ProjectGroup> repository) : base(logger, context, repository)
    {
        
    }  

    [HttpGet]
    [EnableQuery]
    public IActionResult GetRequestProjectGroups()
    {
        if (Guid.TryParse(Request.HttpContext.User.Claims.FirstOrDefault(x => x.Type == "userId")?.Value, out var userId))
        {
            IQueryable<ProjectGroup> result = _context.ProjectGroup.Where(p => p.UserProjects.Any(ug => ug.Userid == userId));

            return Ok(result);
        }
        return StatusCode(403);
    }   
}