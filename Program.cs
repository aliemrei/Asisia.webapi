using Asisia.webapi.Repositories;
using Microsoft.AspNetCore.OData;
using Microsoft.EntityFrameworkCore;
using Asisia.webapi.Models;
 
using Microsoft.OData.Edm;
using Microsoft.AspNetCore.Diagnostics;
using System.Net;
using Newtonsoft.Json;
using Asisia.webapi.Models.dbo;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<Asisia.webapi.Models.DBContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
    options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);

});

builder.Services.AddSingleton<IGenericRepository<REQUEST>, RequestRepository>();
builder.Services.AddSingleton<IGenericRepository<PERSON>, PersonRepository>();
builder.Services.AddSingleton<IGenericRepository<REQUEST_DETAIL>, RequestDetailRepository>();
builder.Services.AddSingleton<IGenericRepository<REQUEST_CLIENTS>, RequestClientRepository>();
builder.Services.AddSingleton<IGenericRepository<PROJECT_GROUP>, ProjectGroupRepository>();
builder.Services.AddSingleton<IGenericRepository<PROJECT_GROUPDETAIL>, ProjectGroupDetailRepository>();


IEdmModel modelv1 = EdmModelBuilder.GetEdmModelV1();

builder.Services.AddControllers(options => options.SuppressImplicitRequiredAttributeForNonNullableReferenceTypes = true)
    .AddOData(opt => opt.Count().Filter().Expand().Select().OrderBy().SetMaxTop(1000).SkipToken().EnableQueryFeatures(null)
        //.AddRouteComponents(model0)
        //.AddRouteComponents("v1", model1)
        //.AddRouteComponents("v2{data}", model2, services => services.AddSingleton<ODataBatchHandler, DefaultODataBatchHandler>())
        .AddRouteComponents("odata", modelv1)
        //.Conventions.Add(new MyConvention())
    );

  

 
 
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
/*
app.UseExceptionHandler(appBuilder =>
  {
    appBuilder.Use(async (context, next) =>
    {
      var error = context.Features[typeof(IExceptionHandlerFeature)] as IExceptionHandlerFeature;
      if (error?.Error != null)
      {
        context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
        context.Response.ContentType = "application/json";

        var response = error.Error.CreateODataError(app.Environment.IsDevelopment());
        await context.Response.WriteAsync(JsonConvert.SerializeObject(response));
      }

      // when no error, do next.
      else await next();
    });
  });
  */
 

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();


/*
dotnet ef dbcontext scaffold "Data Source=192.168.1.121;initial catalog=ASISIA_DEMO;user id=asisia;password=a.e.i1980;persist security info=True;MultipleActiveResultSets=True;App=asisia.webapi" Microsoft.EntityFrameworkCore.SqlServer -o Models/Db -c DBContext -d -f --use-database-names --no-pluralize
*/