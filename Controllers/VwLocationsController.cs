using Microsoft.AspNetCore.Mvc;
using Asisia.webapi.Services;
using Asisia.webapi.Models.Db;

namespace Asisia.webapi.Controllers;


public sealed class VwLocationsController : BaseController<VwLocations, IGenericService<VwLocations>>
{ 
    public VwLocationsController(ILogger<VwLocations> logger,  
        IGenericService<VwLocations> service) : base(logger, service)
    {
        
    }     
}
