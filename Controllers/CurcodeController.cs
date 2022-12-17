using Asisia.webapi.Services;
using Asisia.webapi.Models.Db;

namespace Asisia.webapi.Controllers;


public sealed class CurcodeController : BaseController<Curcode, IGenericService<Curcode>>
{ 
    public CurcodeController(ILogger<Curcode> logger,  
        IGenericService<Curcode> service) : base(logger, service)
    {
        
    }     
}
