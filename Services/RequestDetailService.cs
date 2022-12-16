
using Asisia.webapi.Models.Db;
using Asisia.webapi.Repositories;

namespace Asisia.webapi.Services;

public sealed class RequestDetailService : ServiceBase<RequestDetail>
{
    public RequestDetailService(IGenericRepository<RequestDetail> _repository) : base(_repository)
    {
    }
}