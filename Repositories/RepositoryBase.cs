 
using Asisia.webapi.Models;
using Asisia.webapi.Models.Db;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Results;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Repositories
{
    public class RepositoryBase<TEntity> : IGenericRepository<TEntity> where TEntity : class, new() 
    {
        protected DBContext _context = null;
        protected DbSet<TEntity> _dbSet = null;

        public RepositoryBase(DBContext _context)
        {
            this._context = _context;

            _dbSet = _context.Set<TEntity>();
        }
         
        [EnableQuery(PageSize = 15)]
        public virtual IQueryable<TEntity> GetAll()
        {
            return _dbSet.AsQueryable<TEntity>();
        }
        [EnableQuery]
        public virtual SingleResult<TEntity> GetById(Guid id)
        {
            return SingleResult.Create(_dbSet.Where<TEntity>(b => EF.Property<Guid>(b, "Id") == id));
        }

        public virtual void Insert(TEntity obj)
        {
            _dbSet.Add(obj);
        }
        public virtual TEntity? Update(object id, TEntity obj)
        {
            var currentData = _dbSet.Find(id);

            if (currentData != null)
            {
                var dbEntityEntry = _context.Entry(obj);
                
                dbEntityEntry.OriginalValues.SetValues(currentData);
        
                foreach (var property in dbEntityEntry.OriginalValues.Properties)
                {
                    var prop = dbEntityEntry.Property(property.Name);
                    var original = prop.OriginalValue;
                    var current = prop.CurrentValue; //_context.Entry(obj).Property(property.Name).CurrentValue;
                    if ((original == null && current != null) || (current == null && original != null) || 
                        (original != null && !original.Equals(current)))
                        prop.IsModified = true;
                }

                return dbEntityEntry.Entity;
            }

            return null;
        }
        public virtual void Delete(object id)
        {
            TEntity? existing = _dbSet.Find(id);
            if (existing != null)
                _dbSet.Remove(existing);

        }
        public virtual void Save()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (System.Exception)
            {
                
                throw;
            }
            
        }

        public TEntity Create() 
        {
            return _context.CreateEntity<TEntity>();
        }
    }
}