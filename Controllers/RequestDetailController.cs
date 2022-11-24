using Microsoft.AspNetCore.Mvc;
using Asisia.webapi.Repositories;
using Asisia.webapi.Models.Db;

namespace Asisia.webapi.Controllers;

[ApiController]
[Route("[controller]")]
public sealed class RequestDetailController : BaseController<RequestDetail, IGenericRepository<RequestDetail>>
{ 
    public RequestDetailController(ILogger<RequestDetail> logger, Models.DBContext context, 
        IGenericRepository<RequestDetail> repository) : base(logger, context, repository)
    {
        
    }     
}
