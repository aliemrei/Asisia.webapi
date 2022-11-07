using Microsoft.AspNetCore.Mvc;
using Asisia.webapi.Repositories;
using Asisia.webapi.Models.dbo;

namespace Asisia.webapi.Controllers;

[ApiController]
[Route("[controller]")]
public sealed class ProjectGroupController : BaseController<PROJECT_GROUP, IGenericRepository<PROJECT_GROUP>>
{ 
    public ProjectGroupController(ILogger<PROJECT_GROUP> logger, Models.DBContext context, 
        IGenericRepository<PROJECT_GROUP> repository) : base(logger, context, repository)
    {
        
    }     
}