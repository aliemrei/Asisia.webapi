using System.Reflection;
using Asisia.webapi.Controllers;
using Asisia.webapi.Models;
using Asisia.webapi.Models.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder;


namespace Asisia.webapi.Models;

public static class EdmModelBuilder
{


    public static IEdmModel GetEdmModelV1()
    {
        ODataConventionModelBuilder builder = new ODataConventionModelBuilder();

        AddEntities(builder);

        builder.EntityType<ProjectGroup>().Collection
                .Function("GetRequestProjectGroups")
                .ReturnsCollectionFromEntitySet<ProjectGroup>("ProjectGroup");

        builder.EntitySet<ProjectGroupdetail>("ProjectGroupDetail");

        builder.EntityType<ProjectGroupdetail>().Collection
            .Function("GetRequestProjectGroupDetails")
            .ReturnsCollectionFromEntitySet<ProjectGroupdetail>("ProjectGroupDetail")
            .Parameter<Guid>("ProjectId");

        return builder.GetEdmModel();
    }

    public static void AddEntities(ODataConventionModelBuilder builder)
    {
        var contextType = typeof(DBContext);
        var properties = contextType.GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance)
            .Where(x => x.PropertyType.IsGenericType)
            .ToArray();

        var entitySetMethod = typeof(ODataConventionModelBuilder).GetMethod(nameof(ODataConventionModelBuilder.EntitySet));

        var dbSetProperties = properties.Where(x => x.PropertyType.GetGenericTypeDefinition() == typeof(DbSet<>)).ToArray();
        foreach (var property in dbSetProperties.OrderBy(x => x.Name))
        {
            var dbSetType = property.PropertyType.GetGenericArguments().FirstOrDefault();
            var isKeyless = dbSetType.GetCustomAttributes(typeof(KeylessAttribute), false).Any();
            if (isKeyless == false)
            {
                var entitySetMethodGeneric = entitySetMethod.MakeGenericMethod(dbSetType);
                entitySetMethodGeneric?.Invoke(builder, new[] { dbSetType.Name });
                
            }
            /* key özelliği olmayanlar
            else
            {
                //var keyProperty = DetermineKeyProperty(dbSetType);
                var tt = dbSetType.GetProperty("Id");
                if (tt != null )
                
                {
                        
                    EntityTypeConfiguration entityType = builder.AddEntityType(dbSetType);
                    entityType.HasKey(tt);
                    builder.AddEntitySet(dbSetType.Name, entityType);
                }
            }
            */
        }
    }

    
}