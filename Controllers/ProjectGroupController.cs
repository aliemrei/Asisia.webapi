using Microsoft.AspNetCore.Mvc;
using Asisia.webapi.Repositories;
using Asisia.webapi.Models.Db;

namespace Asisia.webapi.Controllers;

[ApiController]
[Route("[controller]")]
public sealed class ProjectGroupController : BaseController<ProjectGroup, IGenericRepository<ProjectGroup>>
{ 
    public ProjectGroupController(ILogger<ProjectGroup> logger, Models.DBContext context, 
        IGenericRepository<ProjectGroup> repository) : base(logger, context, repository)
    {
        
    }     
}