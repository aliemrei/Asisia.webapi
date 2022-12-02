using Asisia.webapi.Models;
using Asisia.webapi.Models.Db;

namespace Asisia.webapi.Repositories
{
    public sealed class RequestDetailRepository : RepositoryBase<RequestDetail>
    {
        public RequestDetailRepository(DBContext _context) : base(_context)
        {
        }
    }
}