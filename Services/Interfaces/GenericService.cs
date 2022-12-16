using Microsoft.AspNetCore.OData.Results;

namespace Asisia.webapi.Services
{

    public interface IGenericService<TEntity> where TEntity : class
    {
        IQueryable<TEntity> GetAll();
        SingleResult<TEntity> GetById(Guid id);
        TEntity? Insert(TEntity obj);
        TEntity? Update(object id, TEntity changedData);
        void Delete(object id);
        void Save();
        TEntity Create();
        bool IsExists(Guid id);
    }
}