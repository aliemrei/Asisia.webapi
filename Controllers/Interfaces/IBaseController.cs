using Asisia.webapi.Models;
using Asisia.webapi.Repositories;

namespace Asisia.webapi.Controllers.Interfaces;


public interface IBaseController<TEntity, TRepository>
    where TEntity           :   EntityBase
    where TRepository             :   IGenericRepository<TEntity>
{
 
}
