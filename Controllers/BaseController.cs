using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Deltas;
using Microsoft.AspNetCore.OData.Formatter;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Results;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using Microsoft.EntityFrameworkCore;
using Asisia.webapi.Repositories;
using Asisia.webapi.Controllers.Interfaces;
using Asisia.webapi.Models;
using Asisia.webapi.JWT;
using Asisia.webapi.Models.Db;
using Newtonsoft.Json.Linq;
using Microsoft.AspNetCore.OData.Extensions;
using Microsoft.OData;
using Newtonsoft.Json;
using System.Net;
using Microsoft.AspNetCore.JsonPatch;
using System.Dynamic;
using Asisia.webapi.Services;
using Microsoft.AspNetCore.OData.Routing.Attributes;

namespace Asisia.webapi.Controllers;

[AuthorizeOData("", "")]
//[Route("v2/{controller}")] // Disabled because it uses AddRouteComponents in Program.cs
//[BaseControllerNameConvention] //To generate automaticly non exists controllers. Disabled because no need it. 
public class BaseController<TEntity, TService> : ODataController, IBaseController<TEntity, TService>
    where TEntity : EntityBase, new()
    where TService : IGenericService<TEntity>
{
    protected readonly ILogger<TEntity>? _logger = null;

    protected readonly IGenericService<TEntity> _service;

    public BaseController(ILogger<TEntity>? logger, IGenericService<TEntity> service)
    {
        _logger = logger;

        _service = service;
    }

    protected ActionResult ValidationFailed()
    {
        var err = new ODataError
        {
            Message = "Validation error",
            Details = ModelState.ToDictionary(
                        kvp => kvp.Key, //.ToCamelCase(),
                        kvp => kvp.Value.Errors.Select(e => e.ErrorMessage).ToArray()
                    ).Select(e => new ODataErrorDetail()
                    {
                        //ErrorCode = e.Key,
                        Target = e.Key,
                        Message = string.Join("\n", e.Value.ToArray())
                    }).ToList()
        };

        Response.Clear();

        Response.StatusCode = StatusCodes.Status400BadRequest;// (int)HttpStatusCode.InternalServerError;

        Response.ContentType = "application/json";

        return new ContentResult { Content = JsonConvert.SerializeObject(err) };
    }

    [EnableQuery(PageSize = 1000)]  // requires using Microsoft.AspNet.OData;
    [HttpGet]
    public virtual ActionResult<IQueryable<TEntity>> Get()
    {
        var result = _service.GetAll();

        return Ok(result);
    }

    [EnableQuery]
    [HttpGet("{key}")]
   
    public virtual SingleResult<TEntity> Get([FromODataUri] Guid key)
    {

        if (key == Guid.Empty)
        {
            IQueryable<TEntity> result = AddNew();

            return SingleResult.Create(result);
        }

        return _service.GetById((Guid)key);
    }

    [HttpPatch]

    public virtual IActionResult Patch(ODataQueryOptions<TEntity> options,
        [FromODataUri] Guid key, [FromBody] System.Text.Json.JsonElement data)
    {
        var entity = data.ToObject<TEntity>();

        var delta = _service.GetDelta(data);

        if (key == Guid.Empty)
        {
            var result = AddNew().FirstOrDefault();

            delta.Patch(result);

            return Ok(result);
        }
        else
        {
            var currentData = _service.GetById(key).Queryable.FirstOrDefault();

            if (currentData == null)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            delta.Patch(currentData);

            try
            {
                _service.Update(key, currentData, data);

                _service.Save();

                var result = options.ApplyTo(_service.GetAll().Where(b => EF.Property<Guid>(b, "Id") == key), new ODataQuerySettings
                {
                    HandleNullPropagation = HandleNullPropagationOption.True
                })
                as IQueryable<dynamic>;

                return Ok(result.AsQueryable().FirstOrDefault());
            }
            catch //(DbUpdateConcurrencyException)
            {
                throw;
            }

            return Ok(currentData);
        }
    }

    [HttpPost]
    public virtual IActionResult Post(ODataQueryOptions<TEntity> options, [FromBody] System.Text.Json.JsonElement data)
    {
        try
        {
            var entity = data.ToObject<TEntity>();

            if (!ModelState.IsValid)
            {
                return ValidationFailed();
            }

            _service.ValidateForInsert(entity);

            _service.Insert(entity, data);

            _service.Save();

            var gg = data.ToObject<Request>();

            var result = options.ApplyTo(_service.GetAll().Where(b => EF.Property<Guid>(b, "Id") == gg.Id), new ODataQuerySettings
                {
                    HandleNullPropagation = HandleNullPropagationOption.True
                })
                as IQueryable<dynamic>;

            return Ok(result.AsQueryable().FirstOrDefault());    
        }
        catch //(DbUpdateConcurrencyException)
        {
            throw;
        }

       


        /*
        if (!ModelState.IsValid)
        {
            return ValidationFailed();
        }

        if (entity != null)
        {
            TEntity result = null;

            var prop = typeof(TEntity).GetProperty("Id");
            Guid _id = (Guid)prop.GetValue(entity);

            var IsExists = _service.IsExists(_id);

            if (IsExists == false)
                result = _service.Insert(entity);

            try
            {
                _service.Save();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }

            return Ok(result ?? entity);
        }
        */

        return BadRequest("Null body!");
    }

    [HttpPut]
    [EnableQuery(AllowedQueryOptions = AllowedQueryOptions.All)]
    public virtual IActionResult Put([FromODataUri] Guid key, TEntity data)
    {
        var prop = typeof(TEntity).GetProperty("Id");

        if (!Guid.TryParse(prop.GetValue(data).ToString(), out var _id) || _id != key)
        {
            return BadRequest();
        }

        //_service.Update(key, data, null);

        //_service.Save();

        return NoContent();
    }

    [HttpDelete]
    public virtual IActionResult Delete([FromODataUri] Guid key)
    {
        var entity = _service.GetById(key);
        if (entity == null)
        {
            return NotFound($"Not found entity with id = {key}");
        }

        _service.Delete(key);

        _service.Save();

        return Ok();
    }
    [HttpGet]
    [EnableQuery]
    protected virtual IQueryable<TEntity> AddNew()
    {
       Request.GetWriterSettings().Validations = Microsoft.OData.ValidationKinds.None;

       return _service.AddNew();
    }
}