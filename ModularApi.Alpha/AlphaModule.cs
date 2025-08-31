using Microsoft.Extensions.DependencyInjection;
using ModularApi.Alpha.Service;
using ModuleApi.Common.Module;

namespace ModularApi.Alpha;

public class AlphaModule : IModule
{
    public void RegisterServices(IServiceCollection services)
    {
        services.AddScoped<IAlphaService, AlphaService>();
    }
}
