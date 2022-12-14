using Asisia.webapi.Models;
using Asisia.webapi.Models.Db;

namespace Asisia.webapi.Repositories
{
    public sealed class PromotionCodesRepository : RepositoryBase<PromotionCodes>
    {
        public PromotionCodesRepository(DBContext _context) : base(_context)
        {
        }
    }
}