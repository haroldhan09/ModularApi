using ModularApi.Alpha;
using ModularApi.Beta;
using ModuleApi.Common;

namespace ModularApi;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        CommonServices.InitializeServices(builder.Services);
        
        // This should be loaded dynamically
        AlphaModule.InitializeServices(builder.Services);
        BetaModule.InitializeServices(builder.Services);

        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        
        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}