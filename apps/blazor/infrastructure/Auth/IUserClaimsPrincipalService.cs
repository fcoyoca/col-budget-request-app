using System.Security.Claims;
using budget_request_app.Blazor.Infrastructure.Api;
using budget_request_app.Blazor.Infrastructure.Common;

namespace budget_request_app.Blazor.Infrastructure.Auth;

public interface IUserClaimsPrincipalService : IAppService
{
    Task<ClaimsIdentity> InitializedIdentity(UserDetail userDetails, ClaimsIdentity userIdentity);
    Task<ClaimsIdentity> SaveUserIdentity(ClaimsIdentity claimsIdentity);
    ValueTask<UserDetail> LoadUserAccountAsync(ClaimsIdentity claimsIdentity, CancellationToken cancellationToken = default);
    ValueTask SaveUserAccountAsync(UserDetail user);
    ValueTask LogoutUserAccountAsync();
}
