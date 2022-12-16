using Microsoft.AspNetCore.Mvc;
using Asisia.webapi.Services;
using Asisia.webapi.Models.Db;
using Microsoft.AspNetCore.OData.Query;

namespace Asisia.webapi.Controllers;


public sealed class ProjectGroupController : BaseController<ProjectGroup, IGenericService<ProjectGroup>>
{ 
    public ProjectGroupController(ILogger<ProjectGroup> logger,  
        IGenericService<ProjectGroup> service) : base(logger, service)
    {
        
    }  

    [HttpGet]
    [EnableQuery]
    public IActionResult GetRequestProjectGroups()
    {
        if (Guid.TryParse(Request.HttpContext.User.Claims.FirstOrDefault(x => x.Type == "userId")?.Value, out var userId))
        {
            IQueryable<ProjectGroup> result = _service.GetAll().Where(p => p.UserProjects.Any(ug => ug.Userid == userId));

            return Ok(result);
        }
        return StatusCode(403);
    }   
}