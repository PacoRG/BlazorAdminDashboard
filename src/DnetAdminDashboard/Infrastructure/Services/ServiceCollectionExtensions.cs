using DnetAdminDashboard.Infrastructure.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace DnetAdminDashboard.Infrastructure.Services
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDnetAdminDashboard(this IServiceCollection services)
        {
            services.AddScoped(typeof(IThemeMessageService<>), typeof(ThemeMessageService<>));

            return services;
        }
    }
}
