using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.AspNetCore.Mvc.Controllers;
using Asisia.webapi.Controllers;
using Asisia.webapi.Models.Db;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using Asisia.webapi.Services;
using Asisia.webapi.Models;

public class BaseControllerFeatureProvider : IApplicationFeatureProvider<ControllerFeature>
{
    public void PopulateFeature(IEnumerable<ApplicationPart> parts, ControllerFeature feature)
    {
        // This is designed to run after the default ControllerTypeProvider, 
        // so the list of 'real' controllers has already been populated.
        var sysParts = parts.First() as dynamic;
        foreach (TypeInfo entityType in sysParts.Types)
        {
            var typeName = entityType.Name + "Controller";

            if (entityType.FullName!.StartsWith("Asisia.webapi.Models.Db") && !feature.Controllers.Any(t => t.Name == typeName))
            {
                if (entityType.IsSubclassOf(typeof(EntityBase)))
                {
                    var service = Type.GetType("Asisia.webapi.Services.IGenericService`1[Asisia.webapi.Models.Db." + entityType.Name + "]").GetTypeInfo();


                    var entType = entityType.AsType();
                    var srvType = service.AsType();

                    var controllerType = typeof(BaseController<,>)
                        .MakeGenericType(entType, srvType).GetTypeInfo();
                    feature.Controllers.Add(controllerType);
                }
            }
            else 
            {

            }
        }

        /*
        var sysParts = parts.First() as dynamic;
             foreach (TypeInfo entityType in sysParts.Types)
             {
                 var typeName = entityType.Name + "Controller";


                 if (entityType.FullName!.StartsWith("Asisia.webapi.Models.Db") && !feature.Controllers.Any(t => t.Name == typeName))
                 {
                     var controllerType = typeof(GenericController<>)
                         .MakeGenericType(entityType.AsType()).GetTypeInfo();
                     feature.Controllers.Add(controllerType);


                 }
             }

         */
        /*
        foreach (var entityType in EntityTypes.Types)
        {
            var typeName = entityType.Name + "Controller";
            if (!feature.Controllers.Any(t => t.Name == typeName))
            {
                // There's no 'real' controller for this entity, so add the generic version.
                var controllerType = typeof(GenericController<>)
                    .MakeGenericType(entityType.AsType()).GetTypeInfo();
                feature.Controllers.Add(controllerType);
            }
        }
        */
    }
}

public static class EntityTypes
{
    public static IReadOnlyList<TypeInfo> Types => new List<TypeInfo>()
    {
        typeof(Agency).GetTypeInfo(),

    };


}