using Microsoft.AspNetCore.Mvc;
using Asisia.webapi.Repositories;
using Asisia.webapi.Models.Db;

namespace Asisia.webapi.Controllers;

[ApiController]
[Route("[controller]")]
public sealed class PersonController : BaseController<Person, IGenericRepository<Person>>
{ 
    public PersonController(ILogger<Person> logger, Models.DBContext context, 
        IGenericRepository<Person> repository) : base(logger, context, repository)
    {
        
    }     
}
