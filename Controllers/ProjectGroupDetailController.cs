using Microsoft.AspNetCore.Mvc;
using Asisia.webapi.Repositories;
using Asisia.webapi.Models.dbo;

namespace Asisia.webapi.Controllers;

[ApiController]
[Route("[controller]")]
public sealed class ProjectGroupDetailController : BaseController<PROJECT_GROUPDETAIL, IGenericRepository<PROJECT_GROUPDETAIL>>
{ 
    public ProjectGroupDetailController(ILogger<PROJECT_GROUPDETAIL> logger, Models.DBContext context, 
        IGenericRepository<PROJECT_GROUPDETAIL> repository) : base(logger, context, repository)
    {
        
    }     
}