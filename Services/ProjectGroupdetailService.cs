
using Asisia.webapi.Models.Db;
using Asisia.webapi.Repositories;

namespace Asisia.webapi.Services;

public sealed class ProjectGroupdetailService : ServiceBase<ProjectGroupdetail>
{
    public ProjectGroupdetailService(IGenericRepository<ProjectGroupdetail> _repository) : base(_repository)
    {
    }
}