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
using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
            {
                options.AddPolicy(
                    "AllowAllOrigins",
                    builder => builder
                                   
                                    .AllowAnyHeader()
                                    .AllowAnyMethod()
                                    .AllowCredentials()

                                    .SetIsOriginAllowed(origin => {
                                        return true;
                                    }));


                options.DefaultPolicyName = "AllowAllOrigins";
            });

// Add services to the container.

builder.Services.AddDbContext<Asisia.webapi.Models.Db.DBContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
    options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);

}, ServiceLifetime.Scoped);

/*
builder.Services.AddDbContextFactory<Asisia.webapi.Models.DBContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
    options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);

}, ServiceLifetime.Scoped);

 */

 builder.Services.AddHttpContextAccessor();

builder.Services.AddScoped<IGenericRepository<Request>, RequestRepository>(); 
builder.Services.AddScoped<IGenericRepository<Person>, PersonRepository>();
builder.Services.AddScoped<IGenericRepository<RequestDetail>, RequestDetailRepository>();
builder.Services.AddScoped<IGenericRepository<RequestClients>, RequestClientRepository>();
builder.Services.AddScoped<IGenericRepository<ProjectGroup>, ProjectGroupRepository>();
builder.Services.AddScoped<IGenericRepository<ProjectGroupdetail>, ProjectGroupDetailRepository>();
builder.Services.AddScoped<IGenericRepository<Country>, CountyRepository>();
builder.Services.AddScoped<IGenericRepository<Resources>, ResourcesRepository>();
builder.Services.AddScoped<IGenericRepository<Curcode>, CurrenciesRepository>();




IEdmModel modelv1 = EdmModelBuilder.GetEdmModelV1();

builder.Services.AddControllers(options => { 
        options.SuppressImplicitRequiredAttributeForNonNullableReferenceTypes = true;
    })
    .AddJsonOptions(options => {
            options.JsonSerializerOptions.PropertyNamingPolicy = null;
            options.JsonSerializerOptions.MaxDepth = 5;
    })
    .AddOData(opt => opt.Count().Filter().Expand().Select().OrderBy().SetMaxTop(1000).SkipToken().EnableQueryFeatures(null)
        //.AddRouteComponents(model0)
        //.AddRouteComponents("v1", model1)
        //.AddRouteComponents("v2{data}", model2, services => services.AddSingleton<ODataBatchHandler, DefaultODataBatchHandler>())
        .AddRouteComponents("v2", modelv1)
         
        //.Conventions.Add(new MyConvention())
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

app.UseAuthentication();

 app.UseCors("AllowAllOrigins");
 
app.MapControllers();

app.Run();


/*
dotnet ef dbcontext scaffold "Data Source=192.168.1.121;initial catalog=ASISIA_DEMO;user id=asisia;password=a.e.i1980;persist security info=True;MultipleActiveResultSets=True;App=asisia.webapi;TrustServerCertificate=True" Microsoft.EntityFrameworkCore.SqlServer -o Models/Db -c DBContext -d -f  --no-pluralize --data-annotations
*/