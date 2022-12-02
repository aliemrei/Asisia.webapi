using Asisia.webapi.Models;
using Asisia.webapi.Models.Db;

namespace Asisia.webapi.Repositories
{
    public sealed class RequestClientRepository : RepositoryBase<RequestClients>
    {
        public RequestClientRepository(DBContext _context) : base(_context)
        {
        }
    }
}