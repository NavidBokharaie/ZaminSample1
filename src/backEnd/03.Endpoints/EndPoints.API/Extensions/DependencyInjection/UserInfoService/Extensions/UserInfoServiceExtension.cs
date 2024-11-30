using EndPoints.API.Extensions.DependencyInjection.IdentityServer.Options;
using Zamin.Extensions.DependencyInjection;
using Zamin.Extensions.UsersManagement.Abstractions;
using IConfiguration = Microsoft.Extensions.Configuration.IConfiguration;

namespace EndPoints.API.Extensions.DependencyInjection.UserInfoService.Extensions;

public class UserInfoServiceExtension : IUserInfoService
{

    private readonly string _defaultUserId;

    public UserInfoServiceExtension() : this("1")
    {

    }
    public UserInfoServiceExtension(string defaultUserId)
    {
        _defaultUserId = defaultUserId;
    }
    public string GetClaim(string claimType)
    {
        return claimType;
    }

    public string GetFirstName()
    {
        return "FirstName";
    }

    public string GetLastName()
    {
        return "LastName";
    }

    public string GetUserAgent()
    {
        return "1";
    }

    public string GetUserIp()
    {
        return "0.0.0.0";
    }

    public string GetUsername()
    {
        return "Username";
    }

    public bool HasAccess(string access)
    {
        return true;
    }

    public bool IsCurrentUser(string userId)
    {
        return true;
    }

    public string UserId()
    {
        return _defaultUserId;
    }

    public string UserIdOrDefault() => _defaultUserId;

    public string UserIdOrDefault(string defaultValue) => defaultValue;
}


public static class UserInfoServiceCollectionExtensions
{
    private static IServiceCollection AddSaappFakeUserService(this IServiceCollection services, string defaultUserId = "1")
    {
        services.AddSingleton<IUserInfoService>(sp => new UserInfoServiceExtension(defaultUserId));
        return services;
    }

    public static IServiceCollection AddSaappUserInfoService(this IServiceCollection services, IConfiguration configuration, string sectionName = "IdentityServer")
    {
        var userInfoServiceOption = configuration.GetSection(sectionName).Get<OAuthOption>();

        if (userInfoServiceOption is not null && userInfoServiceOption.Enabled)
            if (userInfoServiceOption.FakeUser)
                services.AddSaappFakeUserService(userInfoServiceOption.DefaultUserId);
            else
                services.AddZaminWebUserInfoService(c => { c.DefaultUserId = userInfoServiceOption.DefaultUserId; }, false);

        return services;
    }
}