using System;
using project_net.Model.context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace project_net.configurations
{
    public static class Databaseconfig
    {

        public static IServiceCollection Databaseconfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration["SQLSERVERConnection:connectionString"];
            if (string.IsNullOrEmpty(connectionString)) {
                throw new ArgumentNullException(nameof(connectionString), "nao foi possivel connectar");
            }
            services.AddDbContext<MSSQLcontext>(options =>
            {
                options.UseSqlServer(connectionString);
            });
            return services;
        }
    }
}
