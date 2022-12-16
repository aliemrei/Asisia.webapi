using Microsoft.AspNetCore.Mvc;
using Asisia.webapi.Services;
using Asisia.webapi.Models.Db;

namespace Asisia.webapi.Controllers;


public sealed class ResourcesController : BaseController<Resources, IGenericService<Resources>>
{ 
    public ResourcesController(ILogger<Resources> logger,  
        IGenericService<Resources> service) : base(logger, service)
    {
        
    }     
}
