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

namespace Asisia.webapi.Controllers;

[AuthorizeOData("","")]
public class BaseController<TEntity, TRepository> :  ODataController, IBaseController<TEntity, TRepository>
    where TEntity     :   EntityBase, new()
    where TRepository :   IGenericRepository<TEntity>
{
    protected readonly ILogger<TEntity>? _logger = null;
    protected readonly DBContext _context;
    protected readonly IGenericRepository<TEntity> _repository;

    public BaseController(ILogger<TEntity>? logger, DBContext context, IGenericRepository<TEntity> repository)
    {
        _logger = logger;
        _context = context;
        _repository = repository;
    }

    [EnableQuery(PageSize=1000)]  // requires using Microsoft.AspNet.OData;
    [HttpGet]
    public virtual ActionResult<IQueryable<TEntity>> Get()
    {
        var result = _repository.GetAll();

        return Ok(result);  
    }

    [EnableQuery]
    [HttpGet("{key}")]
    public virtual SingleResult<TEntity> Get([FromODataUri] Guid key)
    {
        var result = _repository.GetById(key); 
 
        return result; 
    }
    
    [HttpPatch]
    public virtual IActionResult Patch([FromODataUri] Guid key, Delta<TEntity> data)
    {
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
    }

    [HttpPost]
    public virtual IActionResult Post([FromBody] TEntity data)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        if (data != null)
        {
            var prop = typeof(TEntity).GetProperty("Id");
            Guid _id = (Guid)prop.GetValue(data);

            var result = _repository.Update(_id, data);

            if (result == null)
                _repository.Insert(data);
    
            try
            {
                    _repository.Save();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }

            return Ok(result ?? data);
        }

        return BadRequest("Null body!");
    }
   
    [HttpPut]
    [EnableQuery(AllowedQueryOptions = AllowedQueryOptions.All)]
    public virtual IActionResult Put([FromODataUri] Guid key, TEntity data)
    {
        var prop = typeof(TEntity).GetProperty("ID");
         
        if (!Guid.TryParse(prop.GetValue(data).ToString(), out var _id) || _id != key)
        {
            return BadRequest();
        }

        _repository.Update(key, data);

        _repository.Save();

        return NoContent();
    }
    
    [HttpDelete]
    public virtual IActionResult Delete([FromODataUri] Guid key)
    {
        var entity = _repository.GetById(key);
        if (entity == null)
        {
            return NotFound($"Not found entity with id = {key}");
        }

        _repository.Delete(key);

        _repository.Save();

        return Ok();
    }
    [HttpGet]
    [EnableQuery]
    public virtual IActionResult AddNew()
    {
        Request.GetWriterSettings().Validations = Microsoft.OData.ValidationKinds.None;

        var obj = _repository.Create();

        return Ok(obj);
    }
}