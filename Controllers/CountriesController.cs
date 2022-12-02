using Microsoft.AspNetCore.Mvc;
using Asisia.webapi.Repositories;
using Asisia.webapi.Models.Db;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Formatter;
using Microsoft.AspNetCore.OData.Extensions;

namespace Asisia.webapi.Controllers;

//[ApiController]
//[Route("[controller]")]
public sealed class CountriesController : BaseController<Country, IGenericRepository<Country>>
{ 
    public CountriesController(ILogger<Country> logger, DBContext context, 
        IGenericRepository<Country> repository) : base(logger, context, repository)
    {
        
    }  
   
}