using Microsoft.AspNetCore.Mvc;
using Microsoft.OData;
using Microsoft.AspNetCore.OData.Extensions;

public static class CommonExtensions
{
  public const string DefaultODataErrorMessage = "A server error occurred.";

  public static ODataError CreateODataError(this SerializableError serializableError, bool isDevelopment)
  {
    // ReSharper disable once InvokeAsExtensionMethod
    var convertedError = SerializableErrorExtensions.CreateODataError(serializableError);
    var error = new ODataError();
    if (isDevelopment)
    {
      error = convertedError;
    }
    else
    {
      // Sanitise the exposed data when in release mode.
      // We do not want to give the public access to stack traces, etc!
      
      error.Message = DefaultODataErrorMessage;

      if (error.Details.Count() > 0)
          error.Message = error.Details.First().Message;

      error.Details = new[] { new ODataErrorDetail { Message = convertedError.Message } };
    }

    return error;
  }

  public static ODataError CreateODataError(this Exception ex, bool isDevelopment)
  {
    var error = new ODataError();

    if (!isDevelopment)
    {
      error.Message = ex.Message;
      error.InnerError = new ODataInnerError(ex);
    }
    else
    {
      error.Message = DefaultODataErrorMessage;
      error.Details = new[] { new ODataErrorDetail { Message = ex.Message } };
      if (error.Details.Count() > 0)
          error.Message = error.Details.First().Message;
    }

    return error;
  }
}