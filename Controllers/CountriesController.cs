using Microsoft.AspNetCore.Mvc;
using Asisia.webapi.Services;
using Asisia.webapi.Models.Db;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Formatter;
using Microsoft.AspNetCore.OData.Extensions;

namespace Asisia.webapi.Controllers;

//[ApiController]
//[Route("[controller]")]
public sealed class CountriesController : BaseController<Country, IGenericService<Country>>
{ 
    public CountriesController(ILogger<Country> logger,  
        IGenericService<Country> service) : base(logger, service)
    {
        
    }  
   
}