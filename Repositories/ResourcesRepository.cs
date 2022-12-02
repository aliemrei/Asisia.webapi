using Asisia.webapi.Models;
using Asisia.webapi.Models.Db;

namespace Asisia.webapi.Repositories
{
    public sealed class ResourcesRepository : RepositoryBase<Resources>
    {
        public ResourcesRepository(DBContext _context) : base(_context)
        {
        }
    }
}