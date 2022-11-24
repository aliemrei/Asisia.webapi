using Asisia.webapi.Models.Db;

namespace Asisia.webapi.Repositories
{
    public sealed class RequestRepository : RepositoryBase<Request>
    {
        public override IQueryable<Request> GetAll()
        {
            var result = base.GetAll();

            return result.AsQueryable();;
        }
    }
}