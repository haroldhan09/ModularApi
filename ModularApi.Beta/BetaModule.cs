using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using ModularApi.Beta.Service;

namespace ModularApi.Beta;

public static class BetaModule
{
    public static void InitializeServices(IServiceCollection services)
    {
        services.AddScoped<IBetaService, BetaService>();
        
        services.AddMediatR(cfg => 
            cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
    }
}
