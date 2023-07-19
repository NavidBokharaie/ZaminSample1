using Serilog;

namespace MiniBlog.Endpoints.API.CustomDecorators
{
    public static class SaappSerialLoggerExtensions
    {
        public static void RunWithSerilogExceptionHandling(this WebApplicationBuilder builder, Action action, string startUpMessage = "Starting up", string exceptionMessage = "Unhandled exception", string shutdownMessage = "Shutdown complete")
        {
            Log.Logger = new LoggerConfiguration().ReadFrom.Configuration(builder.Configuration).CreateBootstrapLogger();
            Log.Information(startUpMessage);
            try
            {
                action();
            }
            catch (Exception exception)
            {
                Log.Fatal(exception, exceptionMessage);
            }
            finally
            {
                Log.Information(shutdownMessage);
                Log.CloseAndFlush();
            }
        }
    }
}
