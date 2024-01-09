using BlogPlanet.Application.Contracts;
using BlogPlanet.Presistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BlogPlanet.Presistence;
public static class PresistanceContainer
{
    public static IServiceCollection AddPresistence(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(
            configuration.GetConnectionString("defaultConnection")
            ));
        services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
        services.AddScoped(typeof(IBlogRepository), typeof(BlogRepository));

        return services;
    }
}
