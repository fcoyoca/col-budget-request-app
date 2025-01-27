using System.Security.Claims;
using Blazored.LocalStorage;
using budget_request_app.Blazor.Infrastructure.Api;
using Microsoft.AspNetCore.Components;

namespace budget_request_app.Blazor.Infrastructure.Auth;
public class UserClaimsPrincipalService : IUserClaimsPrincipalService
{
    private readonly ILocalStorageService _localStorageService;
    private readonly IApiClient _peronalClient;
    private readonly NavigationManager _navManager;

    public UserClaimsPrincipalService(ILocalStorageService localStorageService, IApiClient peronalClient, NavigationManager navManager)
    {
        _localStorageService = localStorageService;
        _peronalClient = peronalClient;
        _navManager = navManager;
    }

    public async Task<ClaimsIdentity> InitializedIdentity(UserDetail userDetails, ClaimsIdentity userIdentity)
    {
        if (userDetails != null)
        {
            if (!string.IsNullOrEmpty(userDetails.Email) && !userIdentity.HasClaim(c => c.Type == ClaimTypes.Email))
            {
                userIdentity.AddClaim(new Claim(ClaimTypes.Email, userDetails.Email));
            }

            if (!string.IsNullOrEmpty(userDetails.PhoneNumber) && !userIdentity.HasClaim(c => c.Type == ClaimTypes.MobilePhone))
            {
                userIdentity.AddClaim(new Claim(ClaimTypes.MobilePhone, userDetails.PhoneNumber));
            }

            if (!string.IsNullOrEmpty(userDetails.FirstName) && !userIdentity.HasClaim(c => c.Type == ClaimTypes.Name))
            {
                userIdentity.AddClaim(new Claim(ClaimTypes.Name, userDetails.FirstName));
            }

            if (!string.IsNullOrEmpty(userDetails.LastName) && !userIdentity.HasClaim(c => c.Type == ClaimTypes.Surname))
            {
                userIdentity.AddClaim(new Claim(ClaimTypes.Surname, userDetails.LastName));
            }

            //if (!userIdentity.HasClaim(c => c.Type == GPCClaims.Fullname))
            //{
            //    userIdentity.AddClaim(new Claim(GPCClaims.Fullname, $"{userDetails.FirstName} {userDetails.LastName}"));
            //}

            if (!userIdentity.HasClaim(c => c.Type == ClaimTypes.NameIdentifier))
            {
                userIdentity.AddClaim(new Claim(ClaimTypes.NameIdentifier, userDetails.Id.ToString()));
            }

            //if (!userIdentity.HasClaim(c => c.Type == ClaimTypes.Role))
            //{
            //    bool hasRoles = userIdentity.Claims.Any(p => p.Type == "roles");

            //    if (hasRoles)
            //    {
            //        string type = userIdentity.Claims.FirstOrDefault(p => p.Type == "roles")!.Value;
            //        var roles = JsonConvert.DeserializeObject<List<string>>(type);

            //        foreach (string permission in roles!.Where(p => p.Contains(GPCClaims.Permission, StringComparison.InvariantCultureIgnoreCase)))
            //        {
            //            userIdentity.AddClaim(new Claim(GPCClaims.Permission, permission));
            //        }

            //        foreach (string role in roles!.Where(p => p.Contains(GPCClaims.Role, StringComparison.InvariantCultureIgnoreCase)))
            //        {
            //            userIdentity.AddClaim(new Claim(GPCClaims.Role, role));
            //        }
            //    }
            //}

            //if (!string.IsNullOrEmpty(userDetails.ImageUrl) && !userIdentity.HasClaim(c => c.Type == GPCClaims.ImageUrl) && userDetails.ImageUrl is not null)
            //{
            //    userIdentity.AddClaim(new Claim(GPCClaims.ImageUrl, userDetails.ImageUrl));
            //}
            //var permissions = await _peronalClient.GetPermissionsAsync();

            //userIdentity.AddClaims(permissions.Select(permission => new Claim(GPCClaims.Permission, permission)));
        }

        return userIdentity;

    }

    public async Task<ClaimsIdentity> SaveUserIdentity(ClaimsIdentity claimsIdentity)
    {
        try
        {
            var id = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            var userDetails = await _peronalClient.GetUserEndpointAsync(id!.Value);

            //if (userDetails is null)
            //{
            //    throw new("You are not yet registered in the GPC Azure Database authentication identity.");
            //}

            await SaveUserAccountAsync(userDetails);

            claimsIdentity = await InitializedIdentity(userDetails, claimsIdentity);

            return claimsIdentity;
        }
        catch (Exception e)
        {
            throw new(e.Message);
        }
    }

    public async ValueTask<UserDetail> LoadUserAccountAsync(ClaimsIdentity claimsIdentity, CancellationToken cancellationToken = default)
    {
        try
        {
            var userData = await _localStorageService.GetItemAsync<UserDetail>(nameof(UserDetail), cancellationToken);

            claimsIdentity = await InitializedIdentity(userData, claimsIdentity);

            return userData;
        }
        catch (Exception e)
        {
            return new();
        }
    }

    public ValueTask SaveUserAccountAsync(UserDetail user)
    {
        return user != null
            ? PutAsync(nameof(UserDetail), user)
            : DeleteAsync(nameof(UserDetail));
    }

    ValueTask PutAsync<T>(string storeName, T value)
            => _localStorageService.SetItemAsync<T>(storeName, value);

    ValueTask DeleteAsync(string storeName) => _localStorageService.RemoveItemAsync(storeName);

    public ValueTask LogoutUserAccountAsync() => DeleteAsync(nameof(UserDetail));
}
