using Asisia.webapi.Models.dbo;

namespace Asisia.webapi.Repositories
{
    public sealed class RequestRepository : RepositoryBase<REQUEST>
    {
        public override IQueryable<REQUEST> GetAll()
        {
            var result = base.GetAll();

            return result.AsQueryable();;
        }
    }
}