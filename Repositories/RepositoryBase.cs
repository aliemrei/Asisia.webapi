 
using Asisia.webapi.Models;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Repositories
{
    public class RepositoryBase<TEntity> : IGenericRepository<TEntity> where TEntity : class 
    {
        private DBContext _context = null;
        private DbSet<TEntity> _dbSet = null;
        public RepositoryBase()
        {
            this._context = new DBContext();
            _dbSet = _context.Set<TEntity>();
        }
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
        public virtual TEntity GetById(object id)
        {
            return _dbSet.Find(id);
        }
       
        public virtual void Insert(TEntity obj)
        {
            _dbSet.Add(obj);
        }
        public virtual void Update(object id, TEntity obj)
        {
            //_context.ChangeTracker.AutoDetectChangesEnabled = true;

            var currentData = _dbSet.Find(id);

                    // Copy book's property values to dbBook.
            _context.Entry(currentData).CurrentValues.SetValues(obj);
            
                
                //_dbSet.Update(obj);

                //_context.Entry(obj).State = EntityState.Modified;
            }
        public virtual void Delete(object id)
        {
            TEntity existing = _dbSet.Find(id);

            _dbSet.Remove(existing);
        }
        public virtual void Save()
        {
            _context.SaveChanges();
        }
    }
}