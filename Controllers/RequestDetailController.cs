using Microsoft.AspNetCore.Mvc;
using Asisia.webapi.Services;
using Asisia.webapi.Models.Db;
using Microsoft.AspNetCore.OData.Extensions;
using Microsoft.OData.UriParser;
using Microsoft.OData;
using Microsoft.AspNetCore.Mvc.Routing;

namespace Asisia.webapi.Controllers;

public sealed class RequestDetailController : BaseController<RequestDetail, IGenericService<RequestDetail>>
{ 
    public RequestDetailController(ILogger<RequestDetail> logger, 
        IGenericService<RequestDetail> service) : base(logger, service)
    {
        
    }    
}
