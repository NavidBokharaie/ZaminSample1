using EndPoints.API.Extensions.DependencyInjection.IdentityServer.Options;

namespace EndPoints.API.Extensions.DependencyInjection.IdentityServer.Extentions;

public static class IdentityServerServiceExtension
{
    public static IServiceCollection AddIdentityServer(this IServiceCollection services, IConfiguration configuration, string sectionName = "IdentityServer")
    {
        var oAuthOption = configuration.GetSection(sectionName).Get<OAuthOption>();

        if (oAuthOption is not null && oAuthOption.Enabled && !oAuthOption.FakeUser)
        {
            services.AddAuthentication()
                .AddJwtBearer(o =>
                {
                    o.Authority = oAuthOption.Authority;
                    o.Audience = oAuthOption.Audience;
                    o.RequireHttpsMetadata = oAuthOption.RequireHttpsMetadata;
                    o.BackchannelHttpHandler = new HttpClientHandler { ServerCertificateCustomValidationCallback = delegate { return true; } };
                    o.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters()
                    {
                        ValidateAudience = oAuthOption.ValidateAudience,
                        ValidateIssuer = oAuthOption.ValidateIssuer,
                        ValidateIssuerSigningKey = oAuthOption.ValidateIssuerSigningKey
                    };
                });

            services.AddAuthorization(options =>
            {
                options.AddPolicy("ApiScope", policy =>
                {
                    policy.RequireAuthenticatedUser();
                    policy.RequireClaim("scope", oAuthOption.Scopes);
                });
            });
        }

        return services;
    }

    public static bool UseIdentityServer(this WebApplication app, string sectionName = "IdentityServer")
    {
        var oAuthOption = app.Configuration.GetSection(sectionName).Get<OAuthOption>();

        if (oAuthOption is not null && oAuthOption.Enabled && !oAuthOption.FakeUser)
        {
            app.UseAuthentication();
            app.UseAuthorization();
        }

        return oAuthOption is not null && oAuthOption.Enabled && !oAuthOption.FakeUser;
    }

}
