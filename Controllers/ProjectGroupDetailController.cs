using Microsoft.AspNetCore.Mvc;
using Asisia.webapi.Services;
using Asisia.webapi.Models.Db;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Formatter;

namespace Asisia.webapi.Controllers;


public sealed class ProjectGroupDetailController : BaseController<ProjectGroupdetail, IGenericService<ProjectGroupdetail>>
{
    private readonly IGenericService<UserProjectDetails> _upd_Service;

    public ProjectGroupDetailController(ILogger<ProjectGroupdetail> logger,   
        IGenericService<ProjectGroupdetail> service,
        IGenericService<UserProjectDetails> upd_service) : base(logger, service)
    {
        _upd_Service = upd_service;
    }   

    [HttpGet]
    [EnableQuery(MaxExpansionDepth = 4)]
    public async Task<ActionResult> GetRequestProjectGroupDetails([FromODataUri]  Guid ProjectId, Guid? ProjectDetailId)
    {
        var isThereUserProjectDetailLimitation = false;

        if (Guid.TryParse(User.Claims.FirstOrDefault(x => x.Type == "userId")?.Value, out var userId))
        {
            isThereUserProjectDetailLimitation = _upd_Service.GetAll()
                .Where(x => x.Userid == userId && x.ProjectGroupdetail.ProjectGroupid == ProjectId)
                .Any();
        }

        var q = _service.GetAll()
            .Where(x => x.ProjectGroupid == ProjectId 
                    && x.Isdisabled == false 
                    && (ProjectDetailId == null || (x.DontMerge == true && ProjectDetailId != null) || x.Id == ProjectDetailId)
                    && (isThereUserProjectDetailLimitation == false || x.UserProjectDetails.Select(u => u.Userid).Contains(userId))
                  )
            .Select(x => new
            {
                Id = x.Id,
                Hotelid = x.Hotelid,
                Tourid = x.Tourid,
                Ticketid = x.Ticketid,
                Description = x.Description != null ? x.Description : (x.Hotel.Name != null ? x.Hotel.Name : (x.Tour.Description != null ? x.Tour.Description : null))
            })
            .AsQueryable();


        return Ok(q);
    }  
}