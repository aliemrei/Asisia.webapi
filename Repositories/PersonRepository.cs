using Asisia.webapi.Models;
using Asisia.webapi.Models.Db;

namespace Asisia.webapi.Repositories
{
    public sealed class PersonRepository : RepositoryBase<Person>
    {
        public PersonRepository(DBContext _context) : base(_context)
        {
        }
    }
}