using Microsoft.AspNetCore.Mvc;
using Asisia.webapi.Repositories;
using Asisia.webapi.Models.dbo;

namespace Asisia.webapi.Controllers;

[ApiController]
[Route("[controller]")]
public sealed class PersonController : BaseController<PERSON, IGenericRepository<PERSON>>
{ 
    public PersonController(ILogger<PERSON> logger, Models.DBContext context, 
        IGenericRepository<PERSON> repository) : base(logger, context, repository)
    {
        
    }     
}
