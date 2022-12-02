using Microsoft.AspNetCore.Mvc;
using Asisia.webapi.Repositories;
using Asisia.webapi.Models.Db;

namespace Asisia.webapi.Controllers;


public sealed class ResourcesController : BaseController<Resources, IGenericRepository<Resources>>
{ 
    public ResourcesController(ILogger<Resources> logger, DBContext context, 
        IGenericRepository<Resources> repository) : base(logger, context, repository)
    {
        
    }     
}
