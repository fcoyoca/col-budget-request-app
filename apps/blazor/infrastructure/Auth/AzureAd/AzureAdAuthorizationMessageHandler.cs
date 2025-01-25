using budget_request_app.Blazor.Infrastructure.Common;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.Extensions.Configuration;

namespace budget_request_app.Blazor.Infrastructure.Auth.AzureAd;
public class AzureAdAuthorizationMessageHandler : AuthorizationMessageHandler
{
    public AzureAdAuthorizationMessageHandler(IAccessTokenProvider provider, NavigationManager navigation, IConfiguration config)
        : base(provider, navigation)
    {
        ConfigureHandler(
            new[] { config[ConfigNames.ApiBaseUrl]! },
            new[] { config[$"{nameof(AuthProvider.AzureAd)}:{ConfigNames.ApiScope}"] });
    }
}
