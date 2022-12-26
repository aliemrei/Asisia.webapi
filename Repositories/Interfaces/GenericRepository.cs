using Microsoft.AspNetCore.OData.Results;

namespace Asisia.webapi.Repositories
{

    public interface IGenericRepository<TEntity> where TEntity : class
    {
        IQueryable<TEntity> GetAll();
        SingleResult<TEntity> GetById(Guid id);
        TEntity? Insert(TEntity obj);
        TEntity? Attach(TEntity obj);
        TEntity? Update(object id, TEntity changedData);
        void Delete(object id);
        void Save();
        TEntity Create();
        bool IsExists(Guid id);
    }
}