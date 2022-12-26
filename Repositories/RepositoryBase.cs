 
using Asisia.webapi.Models;
using Asisia.webapi.Models.Db;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Results;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable, IGenericRepository<TEntity> where TEntity : class, new() 
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
        public virtual TEntity? Insert(TEntity obj)
        {
            _dbSet.Add(obj);

            return obj;
        }
        public virtual TEntity? Attach(TEntity obj)
        {
            _dbSet.Attach(obj);

            return obj;
        }

        public virtual TEntity? Update(object id, TEntity changedData)
        {
            var currentData = _dbSet.Find(id);

            if (currentData != null)
            {
                var dbEntityEntry = _context.Entry(changedData);
                
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
            catch (Microsoft.EntityFrameworkCore.DbUpdateException ex)
            {
                throw new Exception((ex.InnerException?.Message ?? ex.Message), ex); 
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

        public virtual bool IsExists(Guid id)
        {
            return _dbSet.Any<TEntity>(b => EF.Property<Guid>(b, "Id") == id);
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}