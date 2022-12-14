using Microsoft.AspNetCore.Mvc;
using Asisia.webapi.Repositories;
using Asisia.webapi.Models.Db;

namespace Asisia.webapi.Controllers;

public sealed class PromotionCodesController : BaseController<PromotionCodes, IGenericRepository<PromotionCodes>>
{
    public PromotionCodesController(ILogger<PromotionCodes> logger, DBContext context, 
        IGenericRepository<PromotionCodes> repository) : base(logger, context, repository)
    {
        
    }     
}
