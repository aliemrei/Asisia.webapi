using Microsoft.AspNetCore.Mvc;
using Asisia.webapi.Repositories;
using Asisia.webapi.Models.dbo;

namespace Asisia.webapi.Controllers;

[ApiController]
[Route("[controller]")]
public sealed class RequestClientController : BaseController<REQUEST_CLIENTS, IGenericRepository<REQUEST_CLIENTS>>
{
    public RequestClientController(ILogger<REQUEST_CLIENTS> logger, Models.DBContext context, 
        IGenericRepository<REQUEST_CLIENTS> repository) : base(logger, context, repository)
    {
        
    }     
}
