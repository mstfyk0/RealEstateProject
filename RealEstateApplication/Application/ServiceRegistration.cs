using Application.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Application
{
    public static class ServiceRegistration
    {
        public static void AddApplicationLayer(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddScoped<IProductFeatureManager, ProductFeatureManager>();
            services.AddSingleton<IProductFeatureGroupManager, ProductFeatureGroupManager>();
            services.AddScoped<IProductManager, ProductManager>();
        }
    }
}
