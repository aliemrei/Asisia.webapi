using System.Reflection;
using Asisia.webapi.Controllers;
using Asisia.webapi.Models;
using Asisia.webapi.Models.Db;
using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder;
 

namespace Asisia.webapi.Models;

public static class EdmModelBuilder
{
 

    public static IEdmModel GetEdmModelV1()
    {
        var builder = new ODataConventionModelBuilder();

        builder.EntitySet<Request>("Request");
        builder.EntitySet<Person>("Person");
        builder.EntitySet<RequestDetail>("RequestDetail");
        builder.EntitySet<RequestClients>("RequestClient");
        builder.EntitySet<ProjectGroup>("ProjectGroup");
        builder.EntitySet<ProjectGroupdetail>("ProjectGroupDetail");


        return builder.GetEdmModel();

    }
}