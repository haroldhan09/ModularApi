using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using ModularApi.Beta.Service;
using ModuleApi.Common.Module;

namespace ModularApi.Beta;

public class BetaModule : IModule
{
    public void RegisterServices(IServiceCollection services)
    {
        services.AddScoped<IBetaService, BetaService>();
        
        services.AddMediatR(cfg => 
            cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
    }
}
