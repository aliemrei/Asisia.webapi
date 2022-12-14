using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

public class ValidationError
    {
        public ValidationError(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public string Name { get; }

        public string Description { get; }
    }

    public class JsonErrorResponse<T>
    {
        private readonly HttpContext _context;
        private readonly T _error;
        private readonly int _statusCode;

        public JsonErrorResponse(HttpContext context, T error, int statusCode)
        {
            _context = context;
            _error = error;
            _statusCode = statusCode;
        }

        public Task WriteAsync()
        {
            _context.Response.ContentType = "application/json";
            _context.Response.StatusCode = _statusCode;

            return _context.Response.WriteAsync(_error.ToString());
        }
    }

    public class ValidationProblemDetails : ProblemDetails
    {
        public const int ValidationStatusCode = (int)HttpStatusCode.BadRequest;

        public ValidationProblemDetails(ICollection<ValidationError> validationErrors)
        {
            ValidationErrors = validationErrors;

            Status = ValidationStatusCode;
            Title = "Request Validation Error";
            Instance = "CT Portal";
        }

        public ICollection<ValidationError> ValidationErrors { get; }

        public string RequestId => Guid.NewGuid().ToString();
    }

    public class ValidationProblemDetailsResult : IActionResult
    {
        public async Task ExecuteResultAsync(ActionContext context)
        {
            var modelStateEntries = context.ModelState
                .Where(e => e.Value.Errors.Count > 0)
                .ToArray();

            var errors = new List<ValidationError>();

            if (modelStateEntries.Any())
            {
                foreach (var (key, value) in modelStateEntries)
                {
                    errors.AddRange(value.Errors
                        .Select(modelStateError => new ValidationError(
                            name: key,
                            description: modelStateError.ErrorMessage)));
                }
            }

            await new JsonErrorResponse<ValidationProblemDetails>(
                context: context.HttpContext,
                error: new ValidationProblemDetails(errors),
                statusCode: ValidationProblemDetails.ValidationStatusCode).WriteAsync();
        }
    }

    public class SnakeCaseNamingPolicy : JsonNamingPolicy
    {
        public override string ConvertName(string name) => name.ToSnakeCase();
    }

    public static class JsonSerializationExtensions
    {
        private static readonly SnakeCaseNamingStrategy _snakeCaseNamingStrategy
            = new SnakeCaseNamingStrategy();

        private static readonly JsonSerializerSettings _snakeCaseSettings = new JsonSerializerSettings
        {
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = _snakeCaseNamingStrategy
            }
        };

        public static string ToSnakeCase<T>(this T instance)
        {
            return JsonConvert.SerializeObject(instance, _snakeCaseSettings);
        }

        // https://stackoverflow.com/a/58575386
        public static string ToSnakeCase(this string @string)
        {
            if (@string == null)
            {
                throw new ArgumentNullException(paramName: nameof(@string));
            }

            return _snakeCaseNamingStrategy.GetPropertyName(@string, false);
        }
    }