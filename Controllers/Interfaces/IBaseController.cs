using Asisia.webapi.Models;
using Asisia.webapi.Repositories;
using Asisia.webapi.Services;

namespace Asisia.webapi.Controllers.Interfaces;


public interface IBaseController<TEntity, TService>
    where TEntity : EntityBase
    where TService : IGenericService<TEntity>
{

}
