﻿using Application;
using Application.InterfaceQuery;
using Infrastructure.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjection
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddHexagonalServices(this IServiceCollection services)
        {
            // Register your application services
            services.AddScoped<IUserApplication, UserApplicationService>();
            services.AddScoped<IUserRepository, UserRepository>();

            // Add more registrations here

            return services;
        }
    }
}