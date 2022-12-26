using Asisia.webapi.Repositories;
using Microsoft.AspNetCore.OData;
using Microsoft.EntityFrameworkCore;
using Asisia.webapi.Models;

using Microsoft.OData.Edm;
using Microsoft.AspNetCore.Diagnostics;
using System.Net;
using Newtonsoft.Json;
using Asisia.webapi.Models.Db;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Asisia.webapi.JWT;
using Microsoft.OData;
using Asisia.webapi.Services;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

using System.Linq;




var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
            {
                options.AddPolicy(
                    "AllowAllOrigins",
                    builder => builder

                                    .AllowAnyHeader()
                                    .AllowAnyMethod()
                                    .AllowCredentials()

                                    .SetIsOriginAllowed(origin =>
                                    {
                                        return true;
                                    }));


                options.DefaultPolicyName = "AllowAllOrigins";
            });

// Add services to the container.

builder.RegisterDBContexts();

builder.Services.AddHttpContextAccessor();

builder.Services.RegisterODataServices();

builder.Services.AddControllers()
    .ConfigureApplicationPartManager(manager =>
    {
        //manager.FeatureProviders.Add(new BaseControllerFeatureProvider()); //To auto generate non-exitst odata controllers 
    })
    .AddJsonOptions(options =>
    {

        options.JsonSerializerOptions.PropertyNamingPolicy = null; // to don't change property names lowercase
        //options.JsonSerializerOptions.DictionaryKeyPolicy = null;
        //options.JsonSerializerOptions.WriteIndented = true;
        //options.JsonSerializerOptions.MaxDepth = 5;
    })
    .AddOData(opt => opt.Count().Filter().Expand().Select().OrderBy().SetMaxTop(1000).SkipToken().EnableQueryFeatures(null)


        .AddRouteComponents("v2", EdmModelBuilder.GetEdmModelV1(), action =>
                {

                    // To convert Guid.Empty values to "" (empty string);
                    action.AddSingleton(typeof(ODataPayloadValueConverter), pvc => new CustomPayloadValueConverter());
                    // To handle gets model datas
                    //action.AddSingleton<IODataDeserializerProvider, CustomResourceDeserializerProvider>();
                })


    );

var key = Encoding.ASCII.GetBytes(Settings.Secret);
builder.Services.AddAuthentication(x =>
{
    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(x =>
{
    x.RequireHttpsMetadata = false;
    x.SaveToken = true;
    x.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(key),
        ValidateIssuer = false,
        ValidateAudience = false
    };

});


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.DefaultModelsExpandDepth(-1);
    });
}

//Convert errors a json object and change error's content if the environment state is development

app.UseExceptionHandler(appBuilder =>
  {
      appBuilder.Use(async (context, next) =>
      {
          var error = context.Features[typeof(IExceptionHandlerFeature)] as IExceptionHandlerFeature;
          if (error?.Error != null)
          {
              if (error.Error is DbUpdateException || error.Error?.InnerException is DbUpdateException)
              {
                  context.Response.StatusCode = (int)HttpStatusCode.BadRequest;
              }
              else
              {
                  context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
              }

              context.Response.ContentType = "application/json";

              var response = error.Error.CreateODataError(app.Environment.IsDevelopment());
              await context.Response.WriteAsync(JsonConvert.SerializeObject(response));
          }

          // when no error, do next.
          else await next();
      });
  });


app.UseHttpsRedirection();

app.UseAuthorization();

app.UseAuthentication();

app.UseCors("AllowAllOrigins");

app.MapControllers();

app.Run();


/*

don't forget to change  <!--<Nullable>enable</Nullable>--> to  <Nullable>enable</Nullable> in the .csproj file before execute the code

dotnet ef dbcontext scaffold "Data Source=192.168.1.121;initial catalog=ASISIA_DEMO;user id=asisia;password=a.e.i1980;persist security info=True;MultipleActiveResultSets=True;App=asisia.webapi;TrustServerCertificate=True" Microsoft.EntityFrameworkCore.SqlServer -o Models/Db -c DBContext -d -f  --no-pluralize --data-annotations
dotnet ef dbcontext scaffold "Data Source=192.168.1.121;initial catalog=ASISIA_DESIGN;user id=asisia;password=a.e.i1980;persist security info=True;MultipleActiveResultSets=True;App=asisia.webapi.design;TrustServerCertificate=True" Microsoft.EntityFrameworkCore.SqlServer -o Models/DbDesign -c DBDesignContext -d -f  --no-pluralize --data-annotations

*/