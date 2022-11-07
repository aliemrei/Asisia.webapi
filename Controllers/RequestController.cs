using Microsoft.AspNetCore.Mvc;
using Asisia.webapi.Repositories;
using Asisia.webapi.Models.dbo;

namespace Asisia.webapi.Controllers;

[ApiController]
[Route("[controller]")]
public sealed class RequestController : BaseController<REQUEST, IGenericRepository<REQUEST>>
{ 
    public RequestController(ILogger<REQUEST> logger, Models.DBContext context, 
        IGenericRepository<REQUEST> repository) : base(logger, context, repository)
    {
        
    }     
}
