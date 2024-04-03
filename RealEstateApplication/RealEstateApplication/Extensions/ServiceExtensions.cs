using Application;
using Application.Interfaces;
using Domain.Common.ApplicationSettings;
using Domain.Common.BaseLimits;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.RateLimiting;
using Persistence.Context;
using Persistence.Repositories;
using Serilog;
using System.Net;
using System.Reflection;
using Serilog.Core;
using System.Threading.RateLimiting;
using Microsoft.EntityFrameworkCore;

namespace RealEstateApplication.Extensions
{
    public static class ServiceExtensions
    {
        public static void AddApplicationLayer(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddScoped<IProductFeatureManager, ProductFeatureManager>();
            services.AddScoped<IProductFeatureGroupManager, ProductFeatureGroupManager>();
            services.AddScoped<IProductManager, ProductManager>();
        }

        public static void AddPersistance(this IServiceCollection services, IConfiguration configuration, IHostEnvironment hostEnvironment)
        {
            var appOptions = configuration.GetSection(nameof(AppOptions)).Get<AppOptions>();

            services.AddDbContext<ProductDbContext>(options =>
                options.UseSqlServer(
                    appOptions?.ConnectionString ?? "",
                    b => b.MigrationsAssembly(typeof(ProductDbContext).Assembly.FullName))
            );

            services.AddTransient(typeof(IGeneralRepositoryAsync<>), typeof(GeneralRepositoryAsync<>));
            services.AddTransient<IProductFeatureRepositoryAsync, ProductFeatureRepositoryAsync>();
            services.AddTransient<IProductFeatureGroupRepositoryAsync, ProductFeatureGroupRepositoryAsync>();
            services.AddTransient<IProductRepositoryAsync, ProductRepositoryAsync>();

        }

        public static void AddBootstrapper(this IServiceCollection services, IConfiguration configuration, IHostEnvironment hostEnvironment, ConfigureHostBuilder configureHostBuilder)
        {
            #region AppSettings           

            services.Configure<RateLimit>(configuration.GetSection(nameof(RateLimit)));

            var appOptions = configuration.GetSection(nameof(AppOptions)).Get<AppOptions>();
            RateLimit rateLimit = configuration.GetSection("RateLimit").Get<RateLimit>();

            #endregion

            #region Web Api 
            services.Configure<ApiBehaviorOptions>(options =>
            {
                options.SuppressModelStateInvalidFilter = true;
            });

            
            Logger logger = new LoggerConfiguration()
                .MinimumLevel.Information()
                .WriteTo.MSSqlServer(appOptions?.ConnectionString, "Logs")
                .CreateLogger();

            configureHostBuilder.UseSerilog(logger);

            services.AddRateLimiter(options =>
            {
                options.AddSlidingWindowLimiter(nameof(rateLimit.StandartSliding), _options =>
                {
                    _options.Window = TimeSpan.FromMinutes(rateLimit.StandartSliding.FromMinute);
                    _options.PermitLimit = rateLimit.StandartSliding.PermitLimit;
                    _options.QueueProcessingOrder = QueueProcessingOrder.OldestFirst;
                    _options.QueueLimit = rateLimit.StandartSliding.QueueLimit;
                    _options.SegmentsPerWindow = rateLimit.StandartSliding.SegmentsPerWindow;
                });

                options.RejectionStatusCode = (int)HttpStatusCode.TooManyRequests;
            });
            #endregion

            #region Application

            services.AddApplicationLayer();

            #endregion

            #region Persistance

            services.AddPersistance(configuration, hostEnvironment);

            #endregion
        }
    }
}
