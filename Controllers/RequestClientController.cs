using Microsoft.AspNetCore.Mvc;
using Asisia.webapi.Repositories;
using Asisia.webapi.Models.Db;

namespace Asisia.webapi.Controllers;

[ApiController]
[Route("[controller]")]
public sealed class RequestClientController : BaseController<RequestClients, IGenericRepository<RequestClients>>
{
    public RequestClientController(ILogger<RequestClients> logger, Models.DBContext context, 
        IGenericRepository<RequestClients> repository) : base(logger, context, repository)
    {
        
    }     
}
