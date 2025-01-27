using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Identity.Web;
using Serilog;

namespace FSH.Framework.Infrastructure.Auth.AzureAd;

internal static class Extensions
{
    internal static IServiceCollection ConfigureAzureAdAuth(this IServiceCollection services, IConfiguration config)
    {
        var logger = Log.ForContext(typeof(AzureAdJwtBearerEvents));

        services
            .AddAuthorization()
            .AddAuthentication(authentication =>
            {
                authentication.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                authentication.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddMicrosoftIdentityWebApi(
                jwtOptions => jwtOptions.Events = new AzureAdJwtBearerEvents(logger, config),
                msIdentityOptions => config.GetSection("SecuritySettings:AzureAd").Bind(msIdentityOptions));

        return services;
    }
}
