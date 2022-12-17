using Asisia.webapi.Models.Db;
using Asisia.webapi.Repositories;

namespace Asisia.webapi.Services;

public static class Register
{
    public static IServiceCollection  RegisterODataServices(this IServiceCollection services)
    {
        services.AddScoped<IGenericRepository<Request>, RequestRepository>();
        services.AddScoped<IGenericService<Request>, RequestService>(serviceProvider =>
              new RequestService(serviceProvider.GetRequiredService<IGenericRepository<Request>>()));


        services.AddScoped<IGenericRepository<RequestDetail>, RequestDetailRepository>();
        services.AddScoped<IGenericService<RequestDetail>, RequestDetailService>(serviceProvider =>
              new RequestDetailService(serviceProvider.GetRequiredService<IGenericRepository<RequestDetail>>()));


        services.AddScoped<IGenericRepository<Person>, PersonRepository>();
        services.AddScoped<IGenericService<Person>, ServiceBase<Person>>(serviceProvider =>
              new ServiceBase<Person>(serviceProvider.GetRequiredService<IGenericRepository<Person>>()));


        services.AddScoped<IGenericRepository<RequestClients>, RequestClientRepository>();
        services.AddScoped<IGenericService<RequestClients>, ServiceBase<RequestClients>>(serviceProvider =>
              new ServiceBase<RequestClients>(serviceProvider.GetRequiredService<IGenericRepository<RequestClients>>()));


        services.AddScoped<IGenericRepository<ProjectGroup>, ProjectGroupRepository>();
        services.AddScoped<IGenericService<ProjectGroup>, ServiceBase<ProjectGroup>>(serviceProvider =>
              new ServiceBase<ProjectGroup>(serviceProvider.GetRequiredService<IGenericRepository<ProjectGroup>>()));


        services.AddScoped<IGenericRepository<ProjectGroupdetail>, ProjectGroupDetailRepository>();
        services.AddScoped<IGenericService<ProjectGroupdetail>, ProjectGroupdetailService>(serviceProvider =>
              new ProjectGroupdetailService(serviceProvider.GetRequiredService<IGenericRepository<ProjectGroupdetail>>()));


        services.AddScoped<IGenericRepository<UserProjectDetails>, RepositoryBase<UserProjectDetails>>();
        services.AddScoped<IGenericService<Country>, ServiceBase<Country>>(serviceProvider =>
              new ServiceBase<Country>(serviceProvider.GetRequiredService<IGenericRepository<Country>>()));


        services.AddScoped<IGenericRepository<Country>, CountyRepository>();
        services.AddScoped<IGenericService<Country>, ServiceBase<Country>>(serviceProvider =>
              new ServiceBase<Country>(serviceProvider.GetRequiredService<IGenericRepository<Country>>()));


        services.AddScoped<IGenericRepository<Resources>, ResourcesRepository>();
        services.AddScoped<IGenericService<Resources>, ServiceBase<Resources>>(serviceProvider =>
              new ServiceBase<Resources>(serviceProvider.GetRequiredService<IGenericRepository<Resources>>()));


        services.AddScoped<IGenericRepository<Curcode>, CurrenciesRepository>();
        services.AddScoped<IGenericService<Curcode>, ServiceBase<Curcode>>(serviceProvider =>
              new ServiceBase<Curcode>(serviceProvider.GetRequiredService<IGenericRepository<Curcode>>()));


        services.AddScoped<IGenericRepository<VwLocations>, VwLocationsRepository>();
        services.AddScoped<IGenericService<VwLocations>, ServiceBase<VwLocations>>(serviceProvider =>
              new ServiceBase<VwLocations>(serviceProvider.GetRequiredService<IGenericRepository<VwLocations>>()));


        services.AddScoped<IGenericRepository<PromotionCodes>, RepositoryBase<PromotionCodes>>();
        services.AddScoped<IGenericService<PromotionCodes>, ServiceBase<PromotionCodes>>(serviceProvider =>
              new ServiceBase<PromotionCodes>(serviceProvider.GetRequiredService<IGenericRepository<PromotionCodes>>()));


        services.AddScoped<IGenericRepository<Users>, RepositoryBase<Users>>();
        services.AddScoped<IGenericService<Users>, ServiceBase<Users>>(serviceProvider =>
              new ServiceBase<Users>(serviceProvider.GetRequiredService<IGenericRepository<Users>>()));


        services.AddScoped<IGenericRepository<UserProjectDetails>, RepositoryBase<UserProjectDetails>>();
        services.AddScoped<IGenericService<UserProjectDetails>, ServiceBase<UserProjectDetails>>(serviceProvider =>
              new ServiceBase<UserProjectDetails>(serviceProvider.GetRequiredService<IGenericRepository<UserProjectDetails>>()));


        services.AddScoped<IGenericRepository<Agency>, RepositoryBase<Agency>>();
        services.AddScoped<IGenericService<Agency>, ServiceBase<Agency>>(serviceProvider =>
              new ServiceBase<Agency>(serviceProvider.GetRequiredService<IGenericRepository<Agency>>()));

        return services;
    }
}