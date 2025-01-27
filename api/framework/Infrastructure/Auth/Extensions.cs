using FSH.Framework.Infrastructure.Auth.AzureAd;
using FSH.Framework.Infrastructure.Auth.Jwt;
using FSH.Framework.Infrastructure.Authh;
using FSH.Framework.Infrastructure.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FSH.Framework.Infrastructure.Auth;
internal static class Extensions
{
    internal static IServiceCollection ConfigureAuth(this IServiceCollection services, IConfiguration config)
    {
        services.ConfigureIdentity();
        services.Configure<SecuritySettings>(config.GetSection(nameof(SecuritySettings)));
        return config["SecuritySettings:Provider"].Equals("AzureAd", StringComparison.OrdinalIgnoreCase)
            ? services.ConfigureAzureAdAuth(config)
            : services.ConfigureJwtAuth();
    }
}
