using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Application
{
    public static class StartupApplication
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        { 

            // ... 
            return services;
        }
    }
}