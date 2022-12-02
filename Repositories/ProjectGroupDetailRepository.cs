using Asisia.webapi.Models;
using Asisia.webapi.Models.Db;
namespace Asisia.webapi.Repositories
{
    public sealed class ProjectGroupDetailRepository : RepositoryBase<ProjectGroupdetail>
    {
        public ProjectGroupDetailRepository(DBContext _context) : base(_context)
        {
        }
    }
}