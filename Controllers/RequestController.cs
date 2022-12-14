using Microsoft.AspNetCore.Mvc;
using Asisia.webapi.Repositories;
using Asisia.webapi.Models.Db;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Formatter;
using Microsoft.AspNetCore.OData.Results;
using Microsoft.AspNetCore.OData.Deltas;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Asisia.webapi.Controllers;

 
public sealed class RequestController : BaseController<Request, IGenericRepository<Request>>
{ 
    public RequestController(ILogger<Request> logger, DBContext context, 
        IGenericRepository<Request> repository,
        IGenericRepository<Person> repositoryPerson,
        IGenericRepository<RequestClients> repositoryClients,
        IGenericRepository<RequestDetail> repositoryRequestDetail) : base(logger, context, repository)
    {
        
    }    

    public override IActionResult Patch(ODataQueryOptions<Request> options, 
        [FromODataUri] Guid key, [FromBody] System.Text.Json.JsonElement data)
    {
        try
        {
            
        
            var j = Newtonsoft.Json.Linq.JObject.Parse(data.ToString());

            var o = j.ToObject<Request>();

            var delta = new Delta<Request>( typeof(Request));

            var changedData = data.ToObject<Request>();
            
            var currentData = _repository.GetById(key).Queryable.FirstOrDefault();

            foreach (var prop in changedData.GetType().GetProperties())
            {
                if (data.TryGetProperty(prop.Name, out var value)) {
                    delta.TrySetPropertyValue(prop.Name, prop.GetValue(changedData));
                }
            }

            var entity = _repository.GetById(key).Queryable.FirstOrDefault();

            if (entity == null)
            {
                return NotFound();
            }
            
            delta.Patch(entity);

            _repository.Update(key, entity);

            _repository.Save();
            
            var result = options.ApplyTo(_context.Request.Where(x => x.Id == key), new ODataQuerySettings
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

        /*
        var r = Ok(result.AsQueryable());

        var resultList = new List<object>();

         foreach (var item in (dynamic)r.Value)
            {
                if (item is Request)
                {
                    resultList.Add((Request)item);
                }
                else if (item.GetType().Name == "SelectAllAndExpand`1")
                {
                    var entityProperty = item.GetType().GetProperty("Instance");
                    resultList.Add((dynamic)entityProperty.GetValue(item));
                }
            }
 
 
/*
        var j = JsonConvert.SerializeObject(r.Value, Formatting.None,
                                new JsonSerializerSettings()
                                { 
                                    re
                                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                                });
*/
        

        //var singleReult = SingleResult.Create<dynamic>((IQueryable<dynamic>)result);

        /*
        var resultList = new List<object>();

         foreach (var item in result)
            {
                if (item is Request)
                {
                    resultList.Add((Request)item);
                }
                else if (item.GetType().Name == "SelectAllAndExpand`1")
                {
                    var entityProperty = item.GetType().GetProperty("Instance");
                    resultList.Add((dynamic)entityProperty.GetValue(item));
                }
            }
        */



/*
        
  
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        

        var entity = _repository.GetById(key).Queryable.FirstOrDefault();
        if (entity == null)
        {
            return NotFound();
        }

        data.Patch(entity);

        if (!TryValidateModel(entity))
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
        }

        _repository.Update(key, entity);

        try
        {
            _repository.Save();
        }
        catch (DbUpdateConcurrencyException)
        {  
            throw;
        }

        return Ok(entity);
        */
    }
 
   //[ProducesResponseType(typeof(ValidationProblemDetails), 400)]
    public override IActionResult Post([FromBody] Request data)
    {
        if (data != null)
        {
            data.AdduserNavigation = null;

            ModelState.Clear();

            TryValidateModel(data); 
        }
        
        if (!ModelState.IsValid)
        {
            return ValidationFailed();
        }

        if (data != null)
        {
            if (!TryValidateModel(data.Person, nameof(Person)))
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
            }
            
            var prop = typeof(Request).GetProperty("Id");
            Guid _id = (Guid)prop.GetValue(data);

            var result = _repository.Update(_id, data);

            if (result == null)
                _repository.Insert(data);
    
            try
            {
                _repository.Save();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Ok(result ?? data);
        }

        return BadRequest("Null body!");
    }

    protected override IQueryable<Request> AddNew()
    {
        List<Request> result = new List<Request>();

        var obj = _repository.Create();

        obj.Person = _context.CreateEntity<Person>();

        obj.AdduserNavigation = new Users();

        obj.Curcode = "TRY  ";

        var _userId = obj.Adduser;

        var _au = _context.Users.Where(x => x.Id == _userId).Select(x => new { x.Username, x.Fullname }).FirstOrDefault();

        obj.AdduserNavigation.Username = _au?.Username;

        obj.AdduserNavigation.Fullname = _au?.Fullname;

        result.Add(obj);

        return result.AsQueryable();
    }

    
}

public static class ODataQueryOptionsExtensions
{
    public static Expression ToExpression<TElement>(this FilterQueryOption filter)
    {
        IQueryable queryable = Enumerable.Empty<TElement>().AsQueryable();
        queryable = filter.ApplyTo(queryable, new ODataQuerySettings());
        return queryable.Expression;
    }
}
