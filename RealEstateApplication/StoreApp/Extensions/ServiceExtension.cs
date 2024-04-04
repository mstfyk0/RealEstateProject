
using Application.Interfaces;
using Application.Manager;
using Microsoft.EntityFrameworkCore;
using Persistence;
using Persistence.Repositories;


namespace RealEstateApp.Extensions
{
    public static class ServiceExtension
    {
        public static void ConfigureDbContext(this IServiceCollection services
        , IConfiguration configuration)
        {
            services.AddDbContext<RepositoryContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("mssqlconnection"), b => b.MigrationsAssembly("RealEstateApp"));

                options.EnableSensitiveDataLogging(true);

            });
        }

        public static void ConfigureRepositoryRegistration(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryManager, RepositoryManager>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProductFeatureRepository, ProductFeatureRepository>();
            services.AddScoped<IProductFeatureGroupRepository, ProductFeatureGroupRepository>();
        
        }

        public static void ConfigureServiceRegistration(this IServiceCollection services)
        {


            services.AddScoped<IServiceManager, ServiceManager>();
            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<IProductFeatureServices, ProductFeatureManager>();
            services.AddScoped<IProductFeatureGroupServices, ProductFeatureGroupManager>();
        }

        public static void ConfigurRouting(this IServiceCollection services)
        {
            services.AddRouting(options =>
            {
                options.LowercaseUrls = true;
                options.AppendTrailingSlash = false;


            });

        }

    }
}