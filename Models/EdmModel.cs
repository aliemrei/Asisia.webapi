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
        builder.EntitySet<Country>("Countries");
        builder.EntitySet<Resources>("Resources");
        builder.EntitySet<Curcode>("Currencies");

        builder.EntityType<ProjectGroup>().Collection
                .Function("GetRequestProjectGroups")
                .ReturnsCollectionFromEntitySet<ProjectGroup>("ProjectGroup");

        builder.EntitySet<ProjectGroupdetail>("ProjectGroupDetail");

        builder.EntityType<ProjectGroupdetail>().Collection
            .Function("GetRequestProjectGroupDetails")
            .ReturnsCollectionFromEntitySet<ProjectGroupdetail>("ProjectGroupDetail")
            .Parameter<Guid>("ProjectId");

        builder.EntityType<Request>().Collection
                .Function("AddNew")
                .ReturnsCollectionFromEntitySet<Request>("Request");

        builder.EntityType<Country>().Collection
               .Function("AddNew")
               .ReturnsCollectionFromEntitySet<Country>("Countries");


        EdmEntityContainer container = new EdmEntityContainer(builder.Namespace, builder.ContainerName);

        EdmModel model = (EdmModel)builder.GetEdmModel();

        return model;

    }
}