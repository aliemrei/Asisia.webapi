using Microsoft.AspNetCore.OData.Deltas;
using Microsoft.AspNetCore.OData.Results;

namespace Asisia.webapi.Services
{

    public interface IGenericService<TEntity> where TEntity : class
    {
        IQueryable<TEntity> GetAll();
        SingleResult<TEntity> GetById(Guid id);
        TEntity? Insert(TEntity obj, System.Text.Json.JsonElement data);
        TEntity? Attach(TEntity obj, System.Text.Json.JsonElement data);
        TEntity? Update(object id, TEntity changedData, System.Text.Json.JsonElement data);
        void Delete(object id);
        void Save();
        TEntity Create();
        bool IsExists(Guid id);
        IQueryable<TEntity> AddNew();
        Delta<TEntity> GetDelta(TEntity changedData, TEntity data);
        Delta<TEntity> GetDelta(System.Text.Json.JsonElement data);
        bool ValidateForInsert(TEntity? obj);
        bool ValidateForUpdate(TEntity? obj);
        bool ValidateForDelete(TEntity? obj);
    }
}