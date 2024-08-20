namespace Elsa.API.Extensions;

public static class AppServiceExtensions
{
    public static IServiceCollection AddAPPServices(this IServiceCollection services, IConfiguration config)
    {
        services.AddAPIServices(config);

        return services;
    }
}
