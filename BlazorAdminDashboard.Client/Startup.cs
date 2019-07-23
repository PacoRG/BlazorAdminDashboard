using BlazorAdminDashboard.Client.Infrastructure.HelperClasses;
using BlazorAdminDashboard.Client.Shared.Theme;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorAdminDashboard.Client
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton(typeof(IThemeMessageService<ThemeConfigData>), typeof(ThemeMessageService<ThemeConfigData>));

            services.AddEnvironmentConfiguration<Startup>(() => new EnvironmentChooser("Development")
                    .Add("localhost", "Development")
                    .Add("mydomain.com", "Production", false));
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");

            app.InitEnvironmentConfiguration();
        }
    }
}
