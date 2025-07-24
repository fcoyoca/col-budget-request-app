using System.Security.Claims;
using budget_request_app.Shared.Authorization;
using FSH.Framework.Core.Exceptions;
using FSH.Framework.Core.Identity.Users.Abstractions;
using Google.Protobuf;
using Newtonsoft.Json;

namespace FSH.Framework.Infrastructure.Identity.Users.Services;
public class CurrentUser : ICurrentUser, ICurrentUserInitializer
{
    private ClaimsPrincipal? _user;

    public string? Name => _user?.Identity?.Name;

    private Guid _userId = Guid.Empty;

    public Guid GetUserId()
    {
        return IsAuthenticated()
            ? Guid.Parse(_user?.GetUserId() ?? Guid.Empty.ToString())
            : _userId;
    }

    public string? GetUserEmail() =>
        IsAuthenticated()
            ? _user!.GetEmail()
            : string.Empty;

    public bool IsAuthenticated() =>
        _user?.Identity?.IsAuthenticated is true;

    public bool IsInRole(string role) =>
        _user?.IsInRole(role) is true;

    public IEnumerable<Claim>? GetUserClaims() =>
        _user?.Claims;

    public IEnumerable<ClaimsIdentity>? GetUserIdentity()
    {
        ClaimsIdentity claimsIdentity = (ClaimsIdentity)_user.Identity;

        if (!claimsIdentity!.HasClaim(c => c.Type == ClaimTypes.Role))
        {
            bool hasRoles = claimsIdentity.Claims.Any(p => p.Type == "roles");
            List<string> permissions = new();

            if (hasRoles)
            {
                string type = claimsIdentity.Claims.FirstOrDefault(p => p.Type == "roles")!.Value;
                var roles = JsonConvert.DeserializeObject<List<string>>(type);

                foreach (string permission in roles!.Where(p => p.Contains(FshClaims.Permission, StringComparison.InvariantCultureIgnoreCase)))
                {
                    permissions.Add(permission);
                    claimsIdentity.AddClaim(new Claim(FshClaims.Permission, permission));
                }
            }

            if (!permissions!.Any())
            {
                //throw new UnauthorizedAccessException(mesage);
            }
        }

        return _user?.Identities;
    }

    public string? GetTenant() =>
        IsAuthenticated() ? _user?.GetTenant() : string.Empty;

    public void SetCurrentUser(ClaimsPrincipal user)
    {
        if (_user != null)
        {
            throw new FshException("Method reserved for in-scope initialization");
        }

        _user = user;
    }

    public void SetCurrentUserId(string userId)
    {
        if (_userId != Guid.Empty)
        {
            throw new FshException("Method reserved for in-scope initialization");
        }

        if (!string.IsNullOrEmpty(userId))
        {
            _userId = Guid.Parse(userId);
        }
    }
}
