using Microsoft.AspNetCore.Mvc;
using Asisia.webapi.Models.Db;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Formatter;
using Microsoft.AspNetCore.OData.Results;
using Microsoft.AspNetCore.OData.Deltas;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Asisia.webapi.Services;

namespace Asisia.webapi.Controllers;

 
public sealed class RequestController : BaseController<Request, IGenericService<Request>>
{
    private readonly IGenericService<Person> _personService;
    private readonly IGenericService<Users> _usersService;

    public RequestController(ILogger<Request> logger,  
        IGenericService<Request> service) : base(logger, service)
    {
        //this._personService = personService;
        //this._usersService = usersService;
    }    

/*
    public override IActionResult Patch(ODataQueryOptions<Request> options, 
        [FromODataUri] Guid key, [FromBody] System.Text.Json.JsonElement data)
    {
        try
        {
            var j = Newtonsoft.Json.Linq.JObject.Parse(data.ToString());

            var o = j.ToObject<Request>();

            var delta = new Delta<Request>( typeof(Request));

            var changedData = data.ToObject<Request>();
            
            var currentData = base._service.GetById(key).Queryable.FirstOrDefault();

            foreach (var prop in changedData.GetType().GetProperties())
            {
                if (data.TryGetProperty(prop.Name, out var value)) {
                    delta.TrySetPropertyValue(prop.Name, prop.GetValue(changedData));
                }
            }

            var entity = base._service.GetById(key).Queryable.FirstOrDefault();

            if (entity == null)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            
            delta.Patch(entity);

            base._service.Update(key, entity);

            base._service.Save();
            
            var result = options.ApplyTo(_service.GetAll().Where(x => x.Id == key), new ODataQuerySettings
                {

                    HandleNullPropagation = HandleNullPropagationOption.True
                })
                as IQueryable<dynamic>;

            return Ok(result.AsQueryable());
        }
        catch (System.Exception)
        {
            
            throw;
        }
    }
 
   //[ProducesResponseType(typeof(ValidationProblemDetails), 400)]
    public override IActionResult Post([FromBody] System.Text.Json.JsonElement data)
    {
        var entity = data.ToObject<Request>();

        if (entity != null)
        {
            entity.AdduserNavigation = null;

            ModelState.Clear();

            TryValidateModel(entity); 
        }
        
        if (!ModelState.IsValid)
        {
            return ValidationFailed();
        }

        if (entity != null)
        {
            if (!TryValidateModel(entity.Person, nameof(Person)))
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
            }
            
            var prop = typeof(Request).GetProperty("Id");
            Guid _id = (Guid)prop.GetValue(entity);

            var result = base._service.Update(_id, entity);

            if (result == null)
                base._service.Insert(entity);
    
            try
            {
                base._service.Save();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Ok(result ?? entity);
        }

        return BadRequest("Null body!");
    }
*/
/*
    protected override IQueryable<Request> AddNew()
    {
        List<Request> result = new List<Request>();

        var obj = base._service.Create();

        obj.Person = _personService.Create();

        obj.AdduserNavigation = new Users();

        obj.Curcode = "TRY  ";

        var _userId = obj.Adduser;

        var _au = _usersService.GetAll().Where(x => x.Id == _userId).Select(x => new { x.Username, x.Fullname }).FirstOrDefault();

        obj.AdduserNavigation.Username = _au?.Username;

        obj.AdduserNavigation.Fullname = _au?.Fullname;

        result.Add(obj);

        return result.AsQueryable();
    }
*/  
}
 
