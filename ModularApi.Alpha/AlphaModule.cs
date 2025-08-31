using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using ModularApi.Alpha.Service;

namespace ModularApi.Alpha;

public static class AlphaModule
{
    public static void InitializeServices(IServiceCollection services)
    {
        services.AddScoped<IAlphaService, AlphaService>();
    }
}
