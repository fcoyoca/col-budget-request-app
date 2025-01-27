using budget_request_app.Blazor.Infrastructure.Api;

namespace budget_request_app.Blazor.Infrastructure.Auth;

public interface IAuthenticationService
{
    AuthProvider ProviderType { get; }
    void NavigateToExternalLogin(string returnUrl);

    Task<bool> LoginAsync(string tenantId, TokenGenerationCommand request);

    Task LogoutAsync();

    Task ReLoginAsync(string returnUrl);
}
