using Microsoft.AspNetCore.Mvc;
using Asisia.webapi.Repositories;
using Asisia.webapi.Models.Db;

namespace Asisia.webapi.Controllers;

public sealed class RequestDetailController : BaseController<RequestDetail, IGenericRepository<RequestDetail>>
{ 
    public RequestDetailController(ILogger<RequestDetail> logger, DBContext context, 
        IGenericRepository<RequestDetail> repository) : base(logger, context, repository)
    {
        
    }     
}
