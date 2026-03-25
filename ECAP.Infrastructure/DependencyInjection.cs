using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace ECAP.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        // Nanti koneksi Database (Supabase) dan Security (JWT/BCrypt) didaftarkan di sini
        return services;
    }
}