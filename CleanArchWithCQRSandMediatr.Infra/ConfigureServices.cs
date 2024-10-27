using AutoMapper;
using CleanArchWithCQRSandMediatr.Domain.Repository;
using CleanArchWithCQRSandMediatr.Infra.Data;
using CleanArchWithCQRSandMediatr.Infra.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchWithCQRSandMediatr.Infra
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddInfrastructureServices(
            this IServiceCollection services, IConfiguration configuration)
            
        {
            services.AddDbContext<BlogDbContext>(options =>
                options.UseSqlite(configuration.GetConnectionString("BlogBbContext") ??
                    throw new InvalidOperationException("connection string 'BlogBbContext not found '"))
            );

            services.AddTransient<IBlogRepository, BlogRepository>();
            return services;
        }
    }
}
