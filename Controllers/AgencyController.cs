using Asisia.webapi.Services;
using Asisia.webapi.Models.Db;

namespace Asisia.webapi.Controllers;

 
public sealed class AgencyController : BaseController<Agency, IGenericService<Agency>>
{ 
    public AgencyController(ILogger<Agency> logger,  
        IGenericService<Agency> service) : base(logger, service)
    {
        
    }  
   
}