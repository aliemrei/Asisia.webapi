using Microsoft.AspNetCore.Mvc;
using Asisia.webapi.Repositories;
using Asisia.webapi.Models.Db;

namespace Asisia.webapi.Controllers;


public sealed class CurrenciesController : BaseController<Curcode, IGenericRepository<Curcode>>
{ 
    public CurrenciesController(ILogger<Curcode> logger, DBContext context, 
        IGenericRepository<Curcode> repository) : base(logger, context, repository)
    {
        
    }     
}
