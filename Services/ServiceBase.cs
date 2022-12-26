 
using Asisia.webapi.Models;
using Asisia.webapi.Models.Db;
using Asisia.webapi.Repositories;
using Microsoft.AspNetCore.OData.Deltas;
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

        public virtual TEntity? Insert(TEntity obj,System.Text.Json.JsonElement data)
        {
            if (ValidateForInsert(obj))
                return _repository.Insert(obj);

            return null;   
        }
        public virtual TEntity? Attach(TEntity obj,System.Text.Json.JsonElement data)
        {
            if (obj != null)
            {
                var prop = typeof(TEntity).GetProperty("Id");
                Guid _id = (Guid)prop.GetValue(obj);

                var IsExists = this.IsExists(_id);

                if (IsExists == false)
                    return _repository.Attach(obj);
            }

            return null;   
        }
        public virtual TEntity? Update(object id, TEntity changedData, System.Text.Json.JsonElement data)
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
        public virtual TEntity Create() 
        {
            return _repository.Create();
        }

        public virtual bool IsExists(Guid id)
        {
            return _repository.IsExists(id);
        }

        public virtual  IQueryable<TEntity> AddNew()
        {
            List<TEntity> result = new List<TEntity>();

            var obj = this.Create();

            result.Add(obj);

            return result.AsQueryable();
        }

        public virtual Delta<TEntity> GetDelta(TEntity changedData, TEntity data)
        {
            var delta = new Delta<TEntity>(typeof(TEntity));

            foreach (var prop in changedData.GetType().GetProperties())
            {
                var dataProp = data.GetType().GetProperty(prop.Name);

                if (dataProp != null)
                {
                    delta.TrySetPropertyValue(prop.Name, prop.GetValue(changedData));
                }
            }

            return delta;
        }
        
        public virtual Delta<TEntity> GetDelta(System.Text.Json.JsonElement data)
        {
            var delta = new Delta<TEntity>(typeof(TEntity));

            var changedData = data.ToObject<TEntity>();

            foreach (var prop in changedData.GetType().GetProperties())
            {
                if (data.TryGetProperty(prop.Name, out var value))
                {
                    delta.TrySetPropertyValue(prop.Name, prop.GetValue(changedData));
                }
            }

            return delta;
        }

        public virtual bool ValidateForInsert(TEntity? obj)
        {
            if (obj != null)
            {
                var prop = typeof(TEntity).GetProperty("Id");
                Guid _id = (Guid)prop.GetValue(obj);

                var IsExists = this.IsExists(_id);

                return IsExists == false;
            }

            return false;
        }

        public virtual bool ValidateForDelete(TEntity? obj)
        {
            return true;
        }

        public virtual bool ValidateForUpdate(TEntity? obj)
        {
            return true;
        }
    }
}