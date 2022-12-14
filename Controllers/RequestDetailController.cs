using Microsoft.AspNetCore.Mvc;
using Asisia.webapi.Repositories;
using Asisia.webapi.Models.Db;
using Microsoft.AspNetCore.OData.Extensions;
using Microsoft.OData.UriParser;
using Microsoft.OData;
using Microsoft.AspNetCore.Mvc.Routing;

namespace Asisia.webapi.Controllers;

public sealed class RequestDetailController : BaseController<RequestDetail, IGenericRepository<RequestDetail>>
{ 
    public RequestDetailController(ILogger<RequestDetail> logger, DBContext context, 
        IGenericRepository<RequestDetail> repository) : base(logger, context, repository)
    {
        
    }    
}
