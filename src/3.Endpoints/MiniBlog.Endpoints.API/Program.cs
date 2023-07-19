using MiniBlog.Endpoints.API;
using MiniBlog.Endpoints.API.Extenstions;
using Zamin.Extensions.DependencyInjection;

var builder = ProgramExtensions.CreateHostBuilder(args, "appsettings.json", "appsettings.Development.json", "appsettings.saapp.json", "appsettings.serilog.json");


builder.RunWithSerilogExceptionHandling(() =>
{
    builder.AddZaminSerilog(c =>
    {
        c.ApplicationName = "Miniblog";
        c.ServiceName = "MiniblogService";
        c.ServiceVersion = "1.0";
    });

    var app = builder.ConfigureServices().ConfigurePipeline();

    app.Run();
});