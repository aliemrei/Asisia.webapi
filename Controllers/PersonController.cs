using Microsoft.AspNetCore.Mvc;
using Asisia.webapi.Services;
using Asisia.webapi.Models.Db;

namespace Asisia.webapi.Controllers;


public sealed class PersonController : BaseController<Person, IGenericService<Person>>
{ 
    public PersonController(ILogger<Person> logger,   
        IGenericService<Person> service) : base(logger, service)
    {
        
    }     
}
