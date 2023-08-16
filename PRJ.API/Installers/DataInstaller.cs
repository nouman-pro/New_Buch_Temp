using Microsoft.AspNetCore.Mvc.Authorization;
using System.Text.Json;

namespace PRJ.API.Installers;
public class DataInstaller : IInstaller
{
    public void InstallServices(IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<MainContext>(opt => opt.UseSqlServer(ConfigurationStrings.DBConntectionString));

      //  services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen(option =>
        {
            option.SwaggerDoc("v1", new OpenApiInfo { Title = "IntellyHealth", Version = "v1" });
        });
        services.AddControllers();
        services.AddCors();

        services.AddControllers(options =>
        {
            //options.Filters.Add(typeof(ExceptionFilter));

            var policy = new AuthorizationPolicyBuilder()
                            .RequireAuthenticatedUser()
                            .Build();
            options.Filters.Add(new AuthorizeFilter(policy));
        })
           .AddJsonOptions(
               options =>
               {
                   options.JsonSerializerOptions.PropertyNameCaseInsensitive = true;
                   options.JsonSerializerOptions.PropertyNamingPolicy = null;
                   options.JsonSerializerOptions.DictionaryKeyPolicy = JsonNamingPolicy.CamelCase;
                   options.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
               })

         .ConfigureApiBehaviorOptions(options =>
          {
              options.InvalidModelStateResponseFactory = context =>
              {
                  return new BadRequestObjectResult(new RequestValidationFilter(context))
                  {
                      StatusCode = 400
                  };
              };
          });
    }
}
