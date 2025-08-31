using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace ModuleApi.Common;

public static class CommonServices
{
    public static void InitializeServices(IServiceCollection services)
    {
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
    }
}