using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace ModuleApi.Common;

public static class CommonServices
{
    public static void RegisterCommon(this IServiceCollection services)
    {
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
    }
}