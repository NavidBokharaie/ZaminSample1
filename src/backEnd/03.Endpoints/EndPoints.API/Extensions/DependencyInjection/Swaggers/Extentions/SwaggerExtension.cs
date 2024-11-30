using EndPoints.API.Extensions.DependencyInjection.Swaggers.Filters;
using EndPoints.API.Extensions.DependencyInjection.Swaggers.Options;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerUI;

namespace EndPoints.API.Extensions.DependencyInjection.Swaggers.Extentions;

public static class SwaggerExtension
{
    public static IServiceCollection AddSaappSwagger(this IServiceCollection services, IConfiguration configuration, string sectionName = "Swagger")
    {
        var swaggerOption = configuration.GetSection(sectionName).Get<SwaggerOption>();

        if (swaggerOption != null && swaggerOption.SwaggerDoc is not null && swaggerOption.Enabled == true)
        {
            services.AddSwaggerGen(o =>
            {
                o.SwaggerDoc(swaggerOption.SwaggerDoc.Name, new OpenApiInfo
                {
                    Title = swaggerOption.SwaggerDoc.Title,
                    Version = swaggerOption.SwaggerDoc.Version
                });

                var oAuthOption = configuration.GetSection("OAuth").Get<SwaggerOAuthOption>();
                if (oAuthOption is not null && oAuthOption.Enabled)
                {
                    o.AddSecurityDefinition("Oauth2", new OpenApiSecurityScheme
                    {
                        Name = "Authorization",
                        Description = "Oauth2",
                        BearerFormat = "Bearer <token>",
                        In = ParameterLocation.Header,
                        Type = SecuritySchemeType.OAuth2,
                        Flows = new OpenApiOAuthFlows
                        {
                            AuthorizationCode = new OpenApiOAuthFlow
                            {
                                AuthorizationUrl = new Uri(oAuthOption.AuthorizationUrl),
                                TokenUrl = new Uri(oAuthOption.TokenUrl),
                                Scopes = oAuthOption.Scopes
                            }
                        },
                    }); ;

                    o.OperationFilter<AddParamsToHeader>();
                }
            });
        }
        return services;
    }

    public static void UseSaappSwaggerUI(this WebApplication app, string sectionName = "Swagger")
    {
        var swaggerOption = app.Configuration.GetSection(sectionName).Get<SwaggerOption>();

        if (swaggerOption is not null && swaggerOption.SwaggerDoc is not null && swaggerOption.Enabled == true)
        {
            app.UseSwagger();
            app.UseSwaggerUI(option =>
            {
                option.DocExpansion(DocExpansion.None);
                option.SwaggerEndpoint(swaggerOption.SwaggerDoc.URL, swaggerOption.SwaggerDoc.Title);
                option.RoutePrefix = string.Empty;
                option.OAuthUsePkce();
            });
        }
    }
}