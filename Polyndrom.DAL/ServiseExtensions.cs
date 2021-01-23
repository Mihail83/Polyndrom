using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Polyndrom.DAL;
using Polyndrom.DAL.EF;
using Polyndrom.BLL.Interfaces;
using Polyndrom.DAL.Repository;

namespace Polyndrom.DAL
{
    public static class ServiseExtensions
    {
        public static IServiceCollection RegisterDALServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<UserContext>(option => option.UseSqlServer(configuration.GetConnectionString("DefaultConnection2")));
            services.AddScoped<IRepository, UserRepository>();
            return services;
        }
    }
}