using budget_request_app.Blazor.Infrastructure.Auth.AzureAd;
using budget_request_app.Blazor.Infrastructure.Auth.Jwt;
using budget_request_app.Blazor.Infrastructure.Common;
using budget_request_app.Shared.Authorization;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace budget_request_app.Blazor.Infrastructure.Auth;
public static class Extensions
{
    public static IServiceCollection AddAuthentication(this IServiceCollection services, IConfiguration config)
    {
        if (config[nameof(AuthProvider)] == nameof(AuthProvider.Jwt))
        {
            services.AddScoped<AuthenticationStateProvider, JwtAuthenticationService>()
               .AddScoped(sp => (IAuthenticationService)sp.GetRequiredService<AuthenticationStateProvider>())
               .AddScoped(sp => (IAccessTokenProvider)sp.GetRequiredService<AuthenticationStateProvider>())
               .AddScoped<IAccessTokenProviderAccessor, AccessTokenProviderAccessor>()
               .AddScoped<JwtAuthenticationHeaderHandler>();
        }

        if (config[nameof(AuthProvider)] == nameof(AuthProvider.AzureAd))
        {
            services
                .AddScoped<IAuthenticationService, AzureAdAuthenticationService>()
                .AddScoped<AzureAdAuthorizationMessageHandler>()
                .AddMsalAuthentication(options =>
                {
                    config.Bind(nameof(AuthProvider.AzureAd), options.ProviderOptions.Authentication);
                    options.ProviderOptions.DefaultAccessTokenScopes.Add(config[$"{nameof(AuthProvider.AzureAd)}:{ConfigNames.ApiScope}"]!);
                    options.ProviderOptions.LoginMode = "redirect";
                })
                    .AddAccountClaimsPrincipalFactory<AzureAdClaimsPrincipalFactory>();
        }

        services.AddAuthorizationCore(RegisterPermissionClaims);
        services.AddCascadingAuthenticationState();
        return services;
    }


    private static void RegisterPermissionClaims(AuthorizationOptions options)
    {
        foreach (var permission in FshPermissions.All.Select(p => p.Name))
        {
            options.AddPolicy(permission, policy => policy.RequireClaim(FshClaims.Permission, permission));
        }
    }

    public static IHttpClientBuilder AddAuthenticationHandler(this IHttpClientBuilder builder, IConfiguration config) =>
        config[nameof(AuthProvider)] switch
        {
            // AzureAd
            nameof(AuthProvider.AzureAd) =>
                builder.AddHttpMessageHandler<AzureAdAuthorizationMessageHandler>(),

            // Jwt
            _ => builder.AddHttpMessageHandler<JwtAuthenticationHeaderHandler>()
        };
}
