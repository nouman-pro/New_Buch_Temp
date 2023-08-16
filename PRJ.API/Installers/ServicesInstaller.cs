




using Microsoft.Extensions.DependencyInjection;

namespace PRJ.API.Installers;
public class ServicesInstaller : IInstaller
{
    public void InstallServices(IServiceCollection services, IConfiguration configuration)
    {
        //services.AddTransient<ExceptionHandling>();
        services.AddSingleton<DapperContext>();
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddAutoMapper(typeof(AutoMapperProfile));
        services.AddScoped(typeof(IRepository<>), typeof(Repository<>));


       // services.AddScoped<IUserService, UserService>();
       
    }
}
