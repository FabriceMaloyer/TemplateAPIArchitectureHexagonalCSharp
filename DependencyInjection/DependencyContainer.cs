using Application;
using Application.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjection
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddHexagonalServices(this IServiceCollection services)
        {
            // Register your application services
            services.AddScoped<IUserApplication, UserApplicationService>();

            // Add more registrations here

            return services;
        }
    }
}