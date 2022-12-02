using Asisia.webapi.Models;
using Asisia.webapi.Models.Db;

namespace Asisia.webapi.Repositories
{
    public sealed class CurrenciesRepository : RepositoryBase<Curcode>
    {
        public CurrenciesRepository(DBContext _context) : base(_context)
        {
        }
    }
}