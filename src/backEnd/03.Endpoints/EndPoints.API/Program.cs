using EndPoints.API;
using EndPoints.API.Extensions;
using Zamin.Extensions.DependencyInjection;

var builder = WebApplicationExtenstion.CreateHostBuilder(args);

builder.RunWithSerilogExceptionHandling(() =>
{
    var app = builder.AddZaminSerilog(c =>
    {
        c.ApplicationName = builder.Configuration.GetValue<string>("ApplicationName");
        c.ServiceName = builder.Configuration.GetValue<string>("ServiceId");
        c.ServiceVersion = builder.Configuration.GetValue<string>("ServiceVersion");
    }).ConfigureServices().ConfigurePipeline();

    app.Run();
});