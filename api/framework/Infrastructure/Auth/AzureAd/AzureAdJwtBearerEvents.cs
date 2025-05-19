using System.Security.Claims;
using budget_request_app.Shared.Authorization;
using Finbuckle.MultiTenant;
using FSH.Framework.Core.Exceptions;
using FSH.Framework.Core.Identity.Users.Abstractions;
using FSH.Framework.Infrastructure.Identity.Users.Services;
using FSH.Framework.Infrastructure.Tenant.Persistence;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Identity.Web;
using Serilog;

internal class AzureAdJwtBearerEvents : JwtBearerEvents
{
    private readonly ILogger _logger;
    private readonly IConfiguration _config;

    public AzureAdJwtBearerEvents(ILogger logger, IConfiguration config) =>
        (_logger, _config) = (logger, config);

    public override Task AuthenticationFailed(AuthenticationFailedContext context)
    {
        _logger.AuthenticationFailed(context.Exception);
        return base.AuthenticationFailed(context);
    }

    public override Task MessageReceived(MessageReceivedContext context)
    {
        var token = context.Token;
        //_logger.LogInformation("Received token: {Token}", token);
        //Console.WriteLine("Received token: {Token}", token);
    
        // Verify token format
        if (!string.IsNullOrEmpty(token))
        {
            var parts = token.Split('.');
            if (parts.Length != 3)
            {
                //_logger.LogError("Invalid token format - expected 3 parts, got {Count}", parts.Length);
                
                Console.WriteLine("Invalid token format - expected 3 parts, got {Count}", parts.Length);
            }
        }
    
        return base.MessageReceived(context);

    }

    /// <summary>
    /// This method contains the logic that validates the user's tenant and normalizes claims.
    /// </summary>
    /// <param name="context">The validated token context.</param>
    /// <returns>A task.</returns>
    public override async Task TokenValidated(TokenValidatedContext context)
    {
        var principal = context.Principal;
        string? issuer = principal?.GetIssuer();
        string? objectId = principal?.GetObjectId();
        _logger.TokenValidationStarted(objectId, issuer);

        if (principal is null || issuer is null || objectId is null)
        {
            _logger.TokenValidationFailed(objectId, issuer);
            throw new UnauthorizedException("Authentication Failed.");
        }

        // Lookup the tenant using the issuer.
        // TODO: we should probably cache this (root tenant and tenant per issuer)
        var tenantDb = context.HttpContext.RequestServices.GetRequiredService<TenantDbContext>();
        // var tenant = issuer == _config["SecuritySettings:AzureAd:RootIssuer"]
        //     ? await tenantDb.TenantInfo.FindAsync(TenantConstants.Root.Id)
        //     : await tenantDb.TenantInfo.FirstOrDefaultAsync(t => t.Issuer == issuer);

        var tenant = await tenantDb.TenantInfo.FindAsync(TenantConstants.Root.Id);
        
        
        
        if (tenant is null)
        {
            _logger.TokenValidationFailed(objectId, issuer);
        
            // The caller was not from a trusted issuer - throw to block the authentication flow.
            throw new UnauthorizedException("Authentication Failed.");
        }

        // The caller comes from an admin-consented, recorded issuer.
        var identity = principal.Identities.First();
        identity.AddClaim(new Claim("tenant", tenant.Id));
        //// Adding tenant claim.
        //identity.AddClaim(new Claim(GPClaims.Tenant, tenant.Id));

        // Set new tenant info to the HttpContext so the right connectionstring is used.
        context.HttpContext.SetTenantInfo(tenant, false);
        
        // Lookup local user or create one if none exist.
        string userId = await context.HttpContext.RequestServices.GetRequiredService<IUserService>()
            .GetOrCreateFromPrincipalAsync(principal);

        // We use the nameidentifier claim to store the user id.
        var idClaim = principal.FindFirst(ClaimTypes.NameIdentifier);
        identity.TryRemoveClaim(idClaim);
        identity.AddClaim(new Claim(ClaimTypes.NameIdentifier, userId));

        // And the email claim for the email.
        var upnClaim = principal.FindFirst(ClaimTypes.Upn);
        if (upnClaim is not null)
        {
            var emailClaim = principal.FindFirst(ClaimTypes.Email);
            identity.TryRemoveClaim(emailClaim);
            identity.AddClaim(new Claim(ClaimTypes.Email, upnClaim.Value));
        }

        _logger.TokenValidationSucceeded(objectId, issuer);
    }
}
internal static class AzureAdJwtBearerEventsLoggingExtensions
{
    public static void AuthenticationFailed(this ILogger logger, Exception e) =>
        logger.Error("Authentication failed Exception: {e}", e);

    public static void TokenReceived(this ILogger logger) =>
        logger.Debug("Received a bearer token");

    public static void TokenValidationStarted(this ILogger logger, string? userId, string? issuer) =>
        logger.Debug("Token Validation Started for User: {userId} Issuer: {issuer}", userId, issuer);

    public static void TokenValidationFailed(this ILogger logger, string? userId, string? issuer) =>
        logger.Warning("Tenant is not registered User: {userId} Issuer: {issuer}", userId, issuer);

    public static void TokenValidationSucceeded(this ILogger logger, string userId, string issuer) =>
        logger.Debug("Token validation succeeded: User: {userId} Issuer: {issuer}", userId, issuer);
}
