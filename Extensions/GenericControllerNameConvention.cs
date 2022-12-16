using Asisia.webapi.Controllers;
using Microsoft.AspNetCore.Mvc.ApplicationModels;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
public class BaseControllerNameConvention : Attribute, IControllerModelConvention
{
    public void Apply(ControllerModel controller)
    {
        try
        {
            if (controller.ControllerType.GenericTypeArguments.Length == 0 || controller.ControllerType.GetGenericTypeDefinition() !=
                    typeof(BaseController<,>))
            {
                // Not a GenericController, ignore.
                return;
            }

            var entityType = controller.ControllerType.GenericTypeArguments[0];
            controller.ControllerName = entityType.Name;
        }
        catch (System.Exception)
        {
            return;
        }

    }
}