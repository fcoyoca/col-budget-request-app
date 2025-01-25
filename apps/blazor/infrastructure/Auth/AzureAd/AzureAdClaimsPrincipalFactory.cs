using System.Security.Claims;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication.Internal;
using Microsoft.Extensions.DependencyInjection;

namespace budget_request_app.Blazor.Infrastructure.Auth.AzureAd;
internal class AzureAdClaimsPrincipalFactory : AccountClaimsPrincipalFactory<RemoteUserAccount>
{
    // Can't work with actual services in the constructor here, have to
    // use IServiceProvider, otherwise the app hangs at startup.
    // The culprit is probably HttpClient, as this class is instantiated
    // at startup while the HttpClient is being (or not even) created.
    private readonly IServiceProvider _services;

    public AzureAdClaimsPrincipalFactory(IAccessTokenProviderAccessor accessor, IServiceProvider services)
        : base(accessor) =>
        _services = services;

    public override async ValueTask<ClaimsPrincipal> CreateUserAsync(RemoteUserAccount account, RemoteAuthenticationUserOptions options)
    {
        ClaimsPrincipal? principal = await base.CreateUserAsync(account, options);
        IUserClaimsPrincipalService? princinpalService = _services.GetRequiredService<IUserClaimsPrincipalService>();

        if (principal.Identity?.IsAuthenticated is true)
        {
            try
            {
                ClaimsIdentity userIdentity = (ClaimsIdentity)principal.Identity;
                await princinpalService.SaveUserIdentity(userIdentity);
            }
            catch (Exception e)
            {
                ClaimsIdentity userIdentity = (ClaimsIdentity)principal.Identity;
                await princinpalService.LoadUserAccountAsync(userIdentity);
                //throw new UnauthorizedAccessException(e.Message);
            }
        }

        return principal;
    }
}
