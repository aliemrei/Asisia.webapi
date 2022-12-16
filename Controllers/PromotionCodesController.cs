using Microsoft.AspNetCore.Mvc;
using Asisia.webapi.Services;
using Asisia.webapi.Models.Db;

namespace Asisia.webapi.Controllers;

public sealed class PromotionCodesController : BaseController<PromotionCodes, IGenericService<PromotionCodes>>
{
    public PromotionCodesController(ILogger<PromotionCodes> logger, 
        IGenericService<PromotionCodes> service) : base(logger, service)
    {
        
    }     
}
