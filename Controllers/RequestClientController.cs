using Microsoft.AspNetCore.Mvc;
using Asisia.webapi.Repositories;
using Asisia.webapi.Models.Db;

namespace Asisia.webapi.Controllers;

public sealed class RequestClientController : BaseController<RequestClients, IGenericRepository<RequestClients>>
{
    public RequestClientController(ILogger<RequestClients> logger, DBContext context, 
        IGenericRepository<RequestClients> repository) : base(logger, context, repository)
    {
        
    }     
}
