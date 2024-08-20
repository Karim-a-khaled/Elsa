namespace Elsa.API.Extensions;

public static class APIServiceExtensions
{
    public static IServiceCollection AddAPIServices(this IServiceCollection services, IConfiguration config)
    {
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();

        return services;
    }

    public static IApplicationBuilder AddUsings(this IApplicationBuilder app)
    {

        app.UseSwagger();
        app.UseSwaggerUI();
        app.UseHttpsRedirection();

        return app;
    }
}
