using Microsoft.AspNetCore.OData.Results;

namespace Asisia.webapi.Repositories
{

    public interface IGenericRepository<TEntity> where TEntity : class
    {
        IQueryable<TEntity> GetAll();
        SingleResult<TEntity> GetById(Guid id);
        void Insert(TEntity obj);
        TEntity? Update(object id, TEntity obj);
        void Delete(object id);
        void Save();
        TEntity Create();
    }
}