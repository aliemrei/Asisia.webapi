using Asisia.webapi.Models;
using Asisia.webapi.Models.Db;

namespace Asisia.webapi.Repositories
{
    public sealed class ProjectGroupRepository : RepositoryBase<ProjectGroup>
    {
        public ProjectGroupRepository(DBContext _context) : base(_context)
        {
        }
    }
}