namespace EndPoints.API.Extensions.DependencyInjection.IdentityServer.Options;

public class OAuthOption
{
    public bool Enabled { get; set; } = false;
    public bool FakeUser { get; set; } = false;
    public string DefaultUserId { get; set; } = "-1";
    public string Authority { get; set; } = string.Empty;
    public string Audience { get; set; } = string.Empty;
    public bool RequireHttpsMetadata { get; set; } = false;
    public string[] Scopes { get; set; } = new string[] { };

    public bool ValidateAudience { get; set; } = false;
    public bool ValidateIssuer { get; set; } = false;
    public bool ValidateIssuerSigningKey { get; set; } = false;
}
