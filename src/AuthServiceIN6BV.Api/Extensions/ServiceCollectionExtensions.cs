using AuthServiceIN6BV.Application.Interfaces;
using AuthServiceIN6BV.Application.Services;
using AuthServiceIN6BV.Domain.Interface;
using AuthServiceIN6BV.Persistance.Repositories;
using AuthServiceIN6BV.Persistance.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace AuthServiceIN6BV.Api.Extensions;

public static class ServiceColectionExtensions
{
    public static IServiceCollection AddApplicationSerivces(this IServiceCollection services, IConfiguration configuration)
    {

        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"))
                .UseSnakeCaseNamingConvention());
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IRoleRepository, RoleRepository>();

        services.AddHealthChecks();

        return services;
    }

    public static IServiceCollection AddApiDocumentation(this IServiceCollection services)
    {
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();

        return services;
    }
}