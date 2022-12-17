using Asisia.webapi.Services;
using Asisia.webapi.Models.Db;

namespace Asisia.webapi.Controllers;


public sealed class CountryController : BaseController<Country, IGenericService<Country>>
{ 
    public CountryController(ILogger<Country> logger,  
        IGenericService<Country> service) : base(logger, service)
    {
        
    }  
   
}