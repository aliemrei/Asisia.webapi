using Microsoft.AspNetCore.Mvc;

namespace Asisia.webapi.Controllers;

[BaseControllerNameConvention] // Sets the controller name based on typeof(T).Name
[Route("v2/{controller}")]
public class GenericController<T> : Controller
{
    [HttpGet]
    public IActionResult Get()
    {
        return Content($"Hello from a generic {typeof(T).Name} controller.");
    }
}
