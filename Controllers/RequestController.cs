using Microsoft.AspNetCore.Mvc;
using Asisia.webapi.Repositories;
using Asisia.webapi.Models.Db;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Formatter;
using Microsoft.AspNetCore.OData.Results;
 

namespace Asisia.webapi.Controllers;

 
public sealed class RequestController : BaseController<Request, IGenericRepository<Request>>
{ 
    public RequestController(ILogger<Request> logger, DBContext context, 
        IGenericRepository<Request> repository) : base(logger, context, repository)
    {
        
    }    

    [HttpGet]
    [EnableQuery]
    public override SingleResult<Request> Get([FromODataUri] Guid key)
    {
        IQueryable<Request> result = ((RequestRepository)_repository).GetRequest(key);

        return SingleResult.Create(result);
    }   

    [HttpGet]
    [EnableQuery]
    public override IActionResult AddNew()
    {        
        var obj = _repository.Create();

        obj.Person = _context.CreateEntity<Person>();

        obj.AdduserNavigation = new Users();

        obj.Curcode = "TRY  ";

        var _userId = obj.Adduser;

        var _au = _context.Users.Where(x => x.Id == _userId).Select(x => new { x.Username, x.Fullname }).FirstOrDefault();

        obj.AdduserNavigation.Username = _au?.Username;

        obj.AdduserNavigation.Fullname = _au?.Fullname;

        return  Ok(obj);
    }
  
}
