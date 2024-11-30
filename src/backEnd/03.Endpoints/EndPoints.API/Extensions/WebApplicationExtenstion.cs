using Serilog;
using Serilog.Events;
using Serilog.Sinks.SystemConsole.Themes;

namespace EndPoints.API.Extensions;

public static class WebApplicationExtenstion
{
    public static WebApplicationBuilder CreateHostBuilder(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Configuration.AddAppSettings(
            $"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.json");

        builder.AddLogger();
        builder.Host.UseSerilog(Log.Logger);

        return builder;
    }

    private static WebApplicationBuilder AddLogger(this WebApplicationBuilder builder)
    {
        Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
            .MinimumLevel.Override("Microsoft.Hosting.Lifetime", LogEventLevel.Information)
            .MinimumLevel.Override("System", LogEventLevel.Warning)
            .MinimumLevel.Override("Microsoft.AspNetCore.Authentication", LogEventLevel.Information)
            .Enrich.FromLogContext()
            .ReadFrom.Configuration(builder.Configuration)
            .WriteTo.Console(outputTemplate: "[{Timestamp:HH:mm:ss} {Level}] {SourceContext}{NewLine}{Message:lj}{NewLine}{Exception}{NewLine}", theme: AnsiConsoleTheme.Code)
            .CreateLogger();

        builder.Services.AddLogging(loggingBuilder =>
        {
            loggingBuilder.AddSerilog();
        });

        return builder;
    }

    private static IConfigurationBuilder AddAppSettings(this IConfigurationBuilder configurationBuilder, params string[] appSettingFiles)
    {
        foreach (var item in appSettingFiles)
        {
            configurationBuilder.AddJsonFile(item, true);
        }

        return configurationBuilder;
    }
}