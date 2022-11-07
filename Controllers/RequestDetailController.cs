using Microsoft.AspNetCore.Mvc;
using Asisia.webapi.Repositories;
using Asisia.webapi.Models.dbo;

namespace Asisia.webapi.Controllers;

[ApiController]
[Route("[controller]")]
public sealed class RequestDetailController : BaseController<REQUEST_DETAIL, IGenericRepository<REQUEST_DETAIL>>
{ 
    public RequestDetailController(ILogger<REQUEST_DETAIL> logger, Models.DBContext context, 
        IGenericRepository<REQUEST_DETAIL> repository) : base(logger, context, repository)
    {
        
    }     
}
