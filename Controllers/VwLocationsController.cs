using Microsoft.AspNetCore.Mvc;
using Asisia.webapi.Repositories;
using Asisia.webapi.Models.Db;

namespace Asisia.webapi.Controllers;


public sealed class VwLocationsController : BaseController<VwLocations, IGenericRepository<VwLocations>>
{ 
    public VwLocationsController(ILogger<VwLocations> logger, DBContext context, 
        IGenericRepository<VwLocations> repository) : base(logger, context, repository)
    {
        
    }     
}
