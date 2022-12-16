using Microsoft.AspNetCore.Mvc;
using Asisia.webapi.Services;
using Asisia.webapi.Models.Db;

namespace Asisia.webapi.Controllers;


public sealed class CurrenciesController : BaseController<Curcode, IGenericService<Curcode>>
{ 
    public CurrenciesController(ILogger<Curcode> logger,  
        IGenericService<Curcode> service) : base(logger, service)
    {
        
    }     
}
