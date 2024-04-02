using Application;
using Application.Interfaces;
using Domain.Common.ApplicationSettings;
using Domain.Common.BaseLimits;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.RateLimiting;
using Microsoft.EntityFrameworkCore;
using NpgsqlTypes;
using Persistence.Context;
using Persistence.Repositories;
using Serilog.Sinks.PostgreSQL;
using Serilog;
using System.Net;
using System.Reflection;
using Serilog.Core;
using System.Threading.RateLimiting;

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

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseNpgsql(
                    appOptions?.ConnectionString ?? "",
                    b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName))
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

            Logger log = new LoggerConfiguration()
              .WriteTo.PostgreSQL(connectionString: appOptions?.ConnectionString,
                  tableName: "Logs",
                  needAutoCreateTable: true,
                  columnOptions: new Dictionary<string, ColumnWriterBase>
                  {
                        {"message", new RenderedMessageColumnWriter(NpgsqlDbType.Text)},
                        {"message_template", new MessageTemplateColumnWriter(NpgsqlDbType.Text)},
                        {"level", new LevelColumnWriter(true , NpgsqlDbType.Varchar)},
                        {"time_stamp", new TimestampColumnWriter(NpgsqlDbType.Timestamp)},
                        {"exception", new ExceptionColumnWriter(NpgsqlDbType.Text)},
                        {"log_event", new LogEventSerializedColumnWriter(NpgsqlDbType.Json)},
                        //{"request", new RequestColumnWriter()},
                        //{"ip_address", new IpAddressColumnWriter()}
                  })
              .Enrich.FromLogContext()
              .MinimumLevel.Warning()
              .CreateLogger();

            configureHostBuilder.UseSerilog(log);

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
