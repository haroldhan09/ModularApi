using Microsoft.Extensions.DependencyInjection;

namespace ModuleApi.Common.Module;

/// <summary>
/// Interface to register a module on startup. Must be referenced by the Api project
/// </summary>
public interface IModule
{
    void RegisterServices(IServiceCollection services);
}