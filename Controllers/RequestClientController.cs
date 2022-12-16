using Microsoft.AspNetCore.Mvc;
using Asisia.webapi.Services;
using Asisia.webapi.Models.Db;

namespace Asisia.webapi.Controllers;

public sealed class RequestClientController : BaseController<RequestClients, IGenericService<RequestClients>>
{
    public RequestClientController(ILogger<RequestClients> logger,  
        IGenericService<RequestClients> service) : base(logger, service)
    {
        
    }     
}
