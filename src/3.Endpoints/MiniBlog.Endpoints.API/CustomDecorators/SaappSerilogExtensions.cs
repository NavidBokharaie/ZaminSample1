using Serilog;

namespace MiniBlog.Endpoints.API;

public static class SaappSerilogExtensions
{
	public static void RunWithSerilogExceptionHandling(
		this WebApplicationBuilder builder,
		Action action,
		string startUpMessage = "Starting up",
		string exceptionMessage = "Unhandled exception",
		string shutdownMessage = "Shutdown complete")
	{
		Log.Logger = new LoggerConfiguration().ReadFrom.Configuration(builder.Configuration)
			.CreateBootstrapLogger();

		Log.Information(startUpMessage);
		try
		{
			action();
		}
		catch (Exception ex)
		{
			string messageTemplate = exceptionMessage;
			Log.Fatal(ex, messageTemplate);
		}
		finally
		{
			Log.Information(shutdownMessage);
			Log.CloseAndFlush();
		}
	}
}