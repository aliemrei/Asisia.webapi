using Asisia.webapi.Models;
using Asisia.webapi.Models.Db;

namespace Asisia.webapi.Repositories
{
    public sealed class CountyRepository : RepositoryBase<Country>
    {
        public CountyRepository(DBContext _context) : base(_context)
        {
        }
    }
}