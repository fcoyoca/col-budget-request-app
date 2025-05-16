using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Identity.Web;
using Microsoft.IdentityModel.Tokens;
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
            .AddMicrosoftIdentityWebApi(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true, ValidateAudience = true, 
                    ValidAudience = config["SecuritySettings:AzureAd:Audience"], 
                    ValidIssuers = new List<string>() { $"https://login.microsoftonline.com/common/v2.0", $"https://sts.windows.net/common/" },
                };
                options.Events = new AzureAdJwtBearerEvents(logger, config);
            }, msIdentityOptions => config.GetSection("SecuritySettings:AzureAd").Bind(msIdentityOptions));
        
         

        return services;
    }
}
