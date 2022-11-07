namespace Asisia.webapi.Repositories
{

    public interface IGenericRepository<TEntity> where TEntity : class
    {
        IQueryable<TEntity> GetAll();
        TEntity GetById(object id);
        void Insert(TEntity obj);
        void Update(object id, TEntity obj);
        void Delete(object id);
        void Save();
    }
}