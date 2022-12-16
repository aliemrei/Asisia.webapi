
using Asisia.webapi.Models.Db;
using Asisia.webapi.Repositories;

namespace Asisia.webapi.Services;

public sealed class RequestService : ServiceBase<Request>
{
    public RequestService(IGenericRepository<Request> _repository) : base(_repository)
    {
    }
}