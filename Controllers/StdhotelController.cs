using Asisia.webapi.Services;
using Asisia.webapi.Models.Db;

namespace Asisia.webapi.Controllers;

 
public sealed class StdhotelController : BaseController<Stdhotel, IGenericService<Stdhotel>>
{ 
    public StdhotelController(ILogger<Stdhotel> logger,  
        IGenericService<Stdhotel> service) : base(logger, service)
    {
        
    }  
   
}