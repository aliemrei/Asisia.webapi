using System.Buffers;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.OData;
using Newtonsoft.Json;

 
 
public class ActionExecutingContextChecker : ActionFilterAttribute
{
    private ICollection<object?> model;
    public override void OnActionExecuting(ActionExecutingContext context)
    {
        /*
        manual validation!
        var vcontext = new ValidationContext(context.ActionArguments.Values, serviceProvider: null, items: null);
        var validationResults = new List<ValidationResult>();

        bool isValid = Validator.TryValidateObject(context.ActionArguments.Values, vcontext, validationResults, true);
        */

        this.model = context.ActionArguments?.Values;

        if (model != null)
            SetDefaultValues(model);
            
        var modelState = context.ModelState;

        if (!modelState.IsValid)
        {
            var errs = modelState.Values
                 .SelectMany(x => x.Errors.Where(e => e.Exception != null)
                 .Select(e => (e.Exception != null ? e.Exception.GetBaseException() : new Exception(e.ErrorMessage))))
                 .ToList();

            if (errs.Count() > 0)
                throw (Exception)errs.First();
            else 
            {
                ValidationFailed(context);
                // base.OnActionExecuting(context); 
            }

           // context.Result = new UnprocessableEntityObjectResult(context.ModelState); //new BadRequestObjectResult(modelState);
        }
        else
          base.OnActionExecuting(context);
    }

    private void SetDefaultValues(ICollection<object> model)
    {
        
    }
    private void ValidationFailed(ActionExecutingContext context)
    {
        this.model = context.ActionArguments?.Values;

        var modelState = context.ModelState;

        context.HttpContext.Response.Clear();

        context.HttpContext.Response.StatusCode = StatusCodes.Status400BadRequest;// (int)HttpStatusCode.InternalServerError;

        context.HttpContext.Response.ContentType = "application/json";
                
        var err = new ODataError 
                {
                    Message = "Validation error",
                    Details = modelState.ToDictionary(
                        kvp => kvp.Key, //.ToCamelCase(),
                        kvp => kvp.Value.Errors.Select(e => e.ErrorMessage).ToArray()
                    ).Select(e => new ODataErrorDetail() {
                        //ErrorCode = e.Key,
                        Target = e.Key,
                        Message = string.Join("\n", e.Value.ToArray())
                    }).ToList()
                };

        context.Result = new ContentResult { Content = JsonConvert.SerializeObject(err) };
    } 
}
