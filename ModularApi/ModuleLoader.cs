using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace ModuleApi.Common.Module;

internal static class ModuleLoader
{
    [DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof(ModularApi.Alpha.AlphaModule))]
    [DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof(ModularApi.Beta.BetaModule))]
    public static void AddModules(this IServiceCollection services)
    {
        LoadMissingAssemblies();
        
        var types = AppDomain.CurrentDomain.GetAssemblies()
            .SelectMany(x => x.GetTypes())
            .Where(x => x is { IsClass: true, IsAbstract: false })
            .Where(x => typeof(IModule).IsAssignableFrom(x))
            .ToList();

        foreach (var type in types)
        {
            if (Activator.CreateInstance(type) is IModule minimalModule)
                minimalModule.RegisterServices(services);
        }
    }

    private static void LoadMissingAssemblies()
    {
        var loaded = AppDomain.CurrentDomain.GetAssemblies().ToList();
        var referenced = Assembly.GetExecutingAssembly().GetReferencedAssemblies();

        foreach (var assemblyName in referenced)
        {
            if (loaded.Any(x => x.GetName().Name == assemblyName.Name))
                continue;
            
            try
            {
                Assembly.Load(assemblyName);
            }
            catch(Exception) { }
        }
    }
}
