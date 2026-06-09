
using Demo.Application.Contracts;
using Demo.Infrastructure.Data;
using Demo.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using Demo.Infrastructure.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Infrastructure.Extensions
{
    public static class DependencyInjections
    {
      
            public static IServiceCollection AddInfrastructureDependency(this IServiceCollection services)
            {
            services.AddScoped<IApplicationUnitOfWork, ApplicationUnitOfWork>();
            services.AddScoped<IProductRepository, ProductRepository >();

               //services.AddScoped<IMembership, ImprovedMembership>(); // One instance per http life cycle
                //                                                       //builder.Services.AddSingleton<IMembership, ImprovedMembership>();
                //                                                       //builder.Services.AddTransient<IMembership, ImprovedMembership>();

                //services.AddKeyedScoped<IMembership, Membership>("Setup 1");
                //services.AddKeyedScoped<IMembership, ImprovedMembership>("Setup 2");

                //builder.Services.AddScoped<IMembership, ImprovedMembership>(s => new ImprovedMembership("trial"));
                return services;
            
        }
    }
}
