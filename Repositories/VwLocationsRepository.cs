using Asisia.webapi.Models;
using Asisia.webapi.Models.Db;

namespace Asisia.webapi.Repositories
{
    public sealed class VwLocationsRepository : RepositoryBase<VwLocations>
    {
        public VwLocationsRepository(DBContext _context) : base(_context)
        {
        }
    }
}