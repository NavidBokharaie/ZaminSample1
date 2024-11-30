using EndPoints.API.Extensions.DependencyInjection.Swaggers.Extentions;
using EndPoints.API.Extensions.DependencyInjection.UserInfoService.Extensions;
using Infra.Data.Sql.Commands.Common;
using Infra.Data.Sql.Commands.Common.AuditableShadowProperty;
using Infra.Data.Sql.Queries.Common;
using Microsoft.EntityFrameworkCore;
using Serilog;
using System.Globalization;
using Zamin.Extensions.DependencyInjection;
using Zamin.Extensions.Events.Outbox.Dal.EF.Interceptors;
using Zamin.Infra.Data.Sql.Commands.Interceptors;

namespace EndPoints.API;

public static class HostingExtensions
{
    public static WebApplication ConfigureServices(this WebApplicationBuilder builder)
    {
        #region ConnectionStrings

        string commandConnectionString = builder.Configuration.GetConnectionString("Command_ConnectionString");
        string queryConnectionString = builder.Configuration.GetConnectionString("Query_ConnectionString");

        #endregion

        #region Services

        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();

        builder.Services.AddSaappSwagger(builder.Configuration);
        //builder.Services.AddIdentityServer(builder.Configuration);

        #endregion

        #region Framework

        builder.Services.AddZaminParrotTranslator(builder.Configuration, "Translator");

        builder.Services.AddSaappUserInfoService(builder.Configuration);

        builder.Services.AddZaminAutoMapperProfiles(option =>
        {
            option.AssmblyNamesForLoadProfiles = "Infra";
        });

        builder.Services.AddZaminMicrosoftSerializer();

        builder.Services.AddZaminInMemoryCaching();
        builder.Services.AddZaminApiCore("Core.ApplicationServices", "Core.Contracts", "Core.Domain", "Infra.Data.Sql.Commands", "Infra.Data.Sql.Queries");

        #endregion

        #region DbContext

        builder.Services.AddScoped<SetPersianYeKeInterceptor>();

        //builder.Services.AddDbContext<BasicInfoCommandDbContext>((sp, c) => c.UseSqlServer(commandConnectionString)
        //.AddInterceptors(sp.GetRequiredService<SetPersianYeKeInterceptor>(), sp.GetRequiredService<AggregateExcludableAddAuditDataInterceptor>(), new AddAuditDataInterceptor()));
        //builder.Services.AddDbContext<BasicInfoQueryDbContext>(c => c.UseSqlServer(queryConnectionString));

        builder.Services.AddDbContext<ZaminSample1CommandDbContext>((sp, c) => c.UseSqlServer(commandConnectionString,
                options =>
                {
                    options.MigrationsHistoryTable("__EFMigrationsHistory", "dbo");
                })
        .AddInterceptors(sp.GetRequiredService<SetPersianYeKeInterceptor>(), new AddSaappAuditDataInterceptor(), new AddOutBoxEventItemInterceptor()));
        builder.Services.AddDbContext<ZaminSample1QueryDbContext>(c => c.UseSqlServer(queryConnectionString));

        #endregion

        #region Cors

        builder.Services.AddCors(policy =>
        {
            policy.AddPolicy("Default", p =>
            {
                p.AllowAnyHeader().AllowAnyMethod().SetIsOriginAllowed(o => true).AllowCredentials();
            });
        });

        #endregion

        return builder.Build();
    }

    public static WebApplication ConfigurePipeline(this WebApplication app)
    {
        app.UseZaminApiExceptionHandler();
        app.UseSerilogRequestLogging();

        app.UseSaappSwaggerUI();

        app.Use((context, next) =>
        {
            // Fetch the default culture from the application's configuration
            var defaultCultureConfig = app.Configuration.GetValue<string>("Culture:DefaultCulture");
            if (string.IsNullOrEmpty(defaultCultureConfig))
            {
                throw new InvalidOperationException("DefaultCulture is not configured properly.");
            }

            var defaultCulture = new CultureInfo(defaultCultureConfig);
            var enCultureDateTimeFormat = new CultureInfo("en-US").DateTimeFormat;

            // Set the default culture but override its DateTimeFormat with en-US's DateTimeFormat
            defaultCulture.DateTimeFormat = enCultureDateTimeFormat;

            CultureInfo.CurrentCulture = defaultCulture;
            CultureInfo.CurrentUICulture = defaultCulture;

            return next.Invoke();
        });

        app.UseHttpsRedirection();

        app.UseCors("Default");

        //var identityServerEnabled = app.UseIdentityServer();

        //if (identityServerEnabled)
        //{
        //    app.MapControllers().RequireAuthorization();
        //}
        //else
        //{
        app.MapControllers();
        //}

        return app;
    }
}