 
using Asisia.webapi.Models;
using Asisia.webapi.Models.Db;
using Asisia.webapi.Repositories;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Results;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Services
{
    public class ServiceBase<TEntity> : IGenericService<TEntity> where TEntity : class, new() 
    {
        protected IGenericRepository<TEntity>  _repository = null;

        public ServiceBase(IGenericRepository<TEntity>  _repository)
        {
            this._repository = _repository;
        }

        [EnableQuery(PageSize = 15)]
        public virtual IQueryable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }
        [EnableQuery]
        public virtual SingleResult<TEntity> GetById(Guid id)
        {
            return _repository.GetById(id);
        }
        public virtual TEntity? Insert(TEntity obj)
        {
            return _repository.Insert(obj);
        }
        public virtual TEntity? Update(object id, TEntity changedData)
        {
            return _repository.Update(id, changedData);
        }
        public virtual void Delete(object id)
        {
            _repository.Delete(id);

        }
        public virtual void Save()
        {
            _repository.Save();
        }
        public TEntity Create() 
        {
            return _repository.Create();
        }

        public virtual bool IsExists(Guid id)
        {
            return _repository.IsExists(id);
        }
    }
}