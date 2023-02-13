using Microsoft.Extensions.DependencyInjection;
using PracticumProject.Repositories.Interfaces;
using PracticumProject.Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticumProject.Repositories
{
    public static class Extentions
    {
        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IChildUserRepository, ChildUserRepository>();

            return services;
        }

    }
}
