using Serilog;

namespace MiniBlog.Endpoints.API.Extenstions;

public static class ProgramExtensions
{
	public static WebApplicationBuilder CreateHostBuilder(string[] args, params string[] appSettingFiles)
	{
		var builder = WebApplication.CreateBuilder(args);

		builder.Configuration.AddAppSettings(appSettingFiles);

		builder.AddLogger(appSettingFiles);

		builder.Host.UseSerilog(Log.Logger);


		return builder;
	}


	public static WebApplicationBuilder AddLogger(this WebApplicationBuilder builder, string[] appSettingFiles)
	{
		Log.Logger = new LoggerConfiguration()
			.ReadFrom.Configuration(builder.Configuration)
			.CreateLogger();

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