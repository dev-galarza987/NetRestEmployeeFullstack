using Microsoft.EntityFrameworkCore;
using RestEmployee.Shared.Database;

namespace RestEmployee.Shared.Extentions;

public static class Extentions
{
    public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options => options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));
        return services;
    }
}