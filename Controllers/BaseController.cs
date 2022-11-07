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

namespace Asisia.webapi.Controllers;


public class BaseController<TEntity, TRepository> :  ODataController, IBaseController<TEntity, TRepository>
    where TEntity     :   EntityBase
    where TRepository :   IGenericRepository<TEntity>
{
    protected readonly ILogger<TEntity>? _logger = null;
    protected readonly Models.DBContext _context;
    protected readonly IGenericRepository<TEntity> _repository;

    public BaseController(ILogger<TEntity>? logger, DBContext context, IGenericRepository<TEntity> repository)
    {
        _logger = logger;
        _context = context;
        _repository = repository;
    }

    private bool IsExists(Guid id)
    {
        return _repository.GetById(id) != null;
    }

    [EnableQuery(PageSize=10)]  // requires using Microsoft.AspNet.OData;
    [HttpGet]
    public virtual async Task<ActionResult<IQueryable<TEntity>>> Get()
    {
        return Ok(_repository.GetAll());  
    }

    [EnableQuery]
    [HttpGet("{key}")]
    public virtual async Task<IActionResult> Get([FromODataUri] Guid key)
    {
        var entity = _repository.GetById(key);
        if (entity == null)
        {
            return NotFound($"Not found entity with id = {key}");
        }

        return Ok(entity);
    }
     

    
    [HttpPatch]
    public virtual async Task<IActionResult> Patch([FromODataUri] Guid key, Delta<TEntity> data)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        var entity = _repository.GetById(key);
        if (entity == null)
        {
            return NotFound();
        }
        data.Patch(entity);
        
        try
        {
                _context.SaveChanges();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!IsExists(key))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }
        return Updated(entity);
    }

 
    //[ODataRoute("({key})")]
    [HttpPut]
    [EnableQuery(AllowedQueryOptions = AllowedQueryOptions.All)]
    public virtual async Task<IActionResult> Put([FromODataUri] Guid key, TEntity data)
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

    [HttpPost]
    public virtual async Task<ActionResult<TEntity>> Post(TEntity data)
    {
        _repository.Insert(data);
       
        _repository.Save();

        var prop = typeof(TEntity).GetProperty("ID");
        var _id = prop.GetValue(data).ToString();

        return CreatedAtAction("Get", new { key = _id }, data);
    }

    [HttpDelete]
    public virtual async Task<IActionResult> Delete([FromODataUri] Guid key)
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
}