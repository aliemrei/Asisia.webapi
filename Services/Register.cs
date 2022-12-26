using Asisia.webapi.Models.Db;
using Asisia.webapi.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Services;

public static class Register
{
    public static WebApplicationBuilder RegisterDBContexts(this WebApplicationBuilder builder)
    {
        builder.Services.AddDbContext<Asisia.webapi.Models.Db.DBContext>(options =>
        {
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));

            options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);

        }, Microsoft.Extensions.DependencyInjection.ServiceLifetime.Scoped);

        builder.Services.AddDbContext<Asisia.webapi.Models.DbDesign.DBDesignContext>(options =>
        {
            options.UseSqlServer(builder.Configuration.GetConnectionString("DesignConnection"));

            options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);

        }, Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton);

        return builder;
    }

    private static void RegisterGenericServices(IServiceCollection services)
    {
        services.AddScoped<IGenericRepository<Person>, PersonRepository>();
        services.AddScoped<IGenericService<Person>, ServiceBase<Person>>();


        services.AddScoped<IGenericRepository<RequestClients>, RequestClientRepository>();
        services.AddScoped<IGenericService<RequestClients>, ServiceBase<RequestClients>>();


        services.AddScoped<IGenericRepository<ProjectGroup>, ProjectGroupRepository>();
        services.AddScoped<IGenericService<ProjectGroup>, ServiceBase<ProjectGroup>>();

              services.AddScoped<IGenericRepository<UserProjectDetails>, RepositoryBase<UserProjectDetails>>();
        services.AddScoped<IGenericService<Country>, ServiceBase<Country>>();


        services.AddScoped<IGenericRepository<Country>, CountyRepository>();
        services.AddScoped<IGenericService<Country>, ServiceBase<Country>>();


        services.AddScoped<IGenericRepository<Resources>, ResourcesRepository>();
        services.AddScoped<IGenericService<Resources>, ServiceBase<Resources>>();


        services.AddScoped<IGenericRepository<Curcode>, CurrenciesRepository>();
        services.AddScoped<IGenericService<Curcode>, ServiceBase<Curcode>>();


        services.AddScoped<IGenericRepository<VwLocations>, VwLocationsRepository>();
        services.AddScoped<IGenericService<VwLocations>, ServiceBase<VwLocations>>();


        services.AddScoped<IGenericRepository<PromotionCodes>, RepositoryBase<PromotionCodes>>();
        services.AddScoped<IGenericService<PromotionCodes>, ServiceBase<PromotionCodes>>();


        services.AddScoped<IGenericRepository<Users>, RepositoryBase<Users>>();
        services.AddScoped<IGenericService<Users>, ServiceBase<Users>>();


        services.AddScoped<IGenericRepository<UserProjectDetails>, RepositoryBase<UserProjectDetails>>();
        services.AddScoped<IGenericService<UserProjectDetails>, ServiceBase<UserProjectDetails>>();


        services.AddScoped<IGenericRepository<Agency>, RepositoryBase<Agency>>();
        services.AddScoped<IGenericService<Agency>, ServiceBase<Agency>>();

        services.AddScoped<IGenericRepository<Stdhotel>, RepositoryBase<Stdhotel>>();
        services.AddScoped<IGenericService<Stdhotel>, ServiceBase<Stdhotel>>();
    }

    public static IServiceCollection  RegisterODataServices(this IServiceCollection services)
    {
       
        services.AddScoped<IGenericRepository<Request>, RequestRepository>();
        services.AddScoped<IGenericService<Request>, RequestService>();


        services.AddScoped<IGenericRepository<RequestDetail>, RequestDetailRepository>();
        services.AddScoped<IGenericService<RequestDetail>, RequestDetailService>();


        services.AddScoped<IGenericRepository<ProjectGroupdetail>, ProjectGroupDetailRepository>();
        services.AddScoped<IGenericService<ProjectGroupdetail>, ProjectGroupdetailService>();
        
        RegisterGenericServices(services);
        

        return services;
    }
}