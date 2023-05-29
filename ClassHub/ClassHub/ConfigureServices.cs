using Application.Interfaces;
using ClassHubUI.Services;

namespace ClassHubUI
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddWebUIServices(this IServiceCollection services)
        {
            services.AddScoped<ICurrentUserService, CurrentUserService>();

            services.AddHttpContextAccessor();
            return services;
        }
    }
}
