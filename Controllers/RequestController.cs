using Microsoft.AspNetCore.Mvc;
using Asisia.webapi.Repositories;
using Asisia.webapi.Models.Db;

namespace Asisia.webapi.Controllers;

[ApiController]
[Route("[controller]")]
public sealed class RequestController : BaseController<Request, IGenericRepository<Request>>
{ 
    public RequestController(ILogger<Request> logger, Models.DBContext context, 
        IGenericRepository<Request> repository) : base(logger, context, repository)
    {
        
    }     
}
