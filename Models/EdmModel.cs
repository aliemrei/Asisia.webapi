using System.Reflection;
using Asisia.webapi.Controllers;
using Asisia.webapi.Models;
using Asisia.webapi.Models.dbo;
using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder;
 

namespace Asisia.webapi.Models;

public static class EdmModelBuilder
{
 

    public static IEdmModel GetEdmModelV1()
    {
        var builder = new ODataConventionModelBuilder();

        builder.EntitySet<REQUEST>("Request");
        builder.EntitySet<PERSON>("Person");
        builder.EntitySet<REQUEST_DETAIL>("RequestDetail");
        builder.EntitySet<REQUEST_CLIENTS>("RequestClient");
        builder.EntitySet<PROJECT_GROUP>("ProjectGroup");
        builder.EntitySet<PROJECT_GROUPDETAIL>("ProjectGroupDetail");


        return builder.GetEdmModel();

    }
}