using Microsoft.AspNetCore.Mvc;
using Asisia.webapi.Repositories;
using Asisia.webapi.Models.Db;

namespace Asisia.webapi.Controllers;

[ApiController]
[Route("[controller]")]
public sealed class ProjectGroupDetailController : BaseController<ProjectGroupdetail, IGenericRepository<ProjectGroupdetail>>
{ 
    public ProjectGroupDetailController(ILogger<ProjectGroupdetail> logger, Models.DBContext context, 
        IGenericRepository<ProjectGroupdetail> repository) : base(logger, context, repository)
    {
        
    }     
}