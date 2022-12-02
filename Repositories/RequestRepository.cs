using Asisia.webapi.Models;
using Asisia.webapi.Models.Db;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Repositories
{
    public sealed class RequestRepository : RepositoryBase<Request>
    {
    
        public RequestRepository(DBContext _context) : base(_context)
        {
        }

        public override IQueryable<Request> GetAll()
        {
            var result = base.GetAll();

            return result.AsQueryable();
        }

        

        [EnableQuery]
        public IQueryable<Request>  GetRequest(Guid key)
        {
            IQueryable<Request> result = GetAll().Where(p => p.Id == key);

            return result;
        }
    }
}