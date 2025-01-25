using System.Globalization;
using Blazored.LocalStorage;
using budget_request_app.Blazor.Infrastructure.Api;
using budget_request_app.Blazor.Infrastructure.Auth;
using budget_request_app.Blazor.Infrastructure.Auth.Jwt;
using budget_request_app.Blazor.Infrastructure.Common;
using budget_request_app.Blazor.Infrastructure.Notifications;
using budget_request_app.Blazor.Infrastructure.Preferences;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MudBlazor;
using MudBlazor.Services;

namespace budget_request_app.Blazor.Infrastructure;
public static class Extensions
{
    private const string ClientName = "FullStackHero.API";
    public static IServiceCollection AddClientServices(this IServiceCollection services, IConfiguration config)
    {
        services.AddMudServices(configuration =>
        {
            configuration.SnackbarConfiguration.PositionClass = Defaults.Classes.Position.BottomRight;
            configuration.SnackbarConfiguration.HideTransitionDuration = 100;
            configuration.SnackbarConfiguration.ShowTransitionDuration = 100;
            configuration.SnackbarConfiguration.VisibleStateDuration = 3000;
            configuration.SnackbarConfiguration.ShowCloseIcon = false;
        });
        services.AutoRegisterInterfaces<IAppService>();
        services.AddBlazoredLocalStorage();
        services.AddAuthentication(config);
        services.AddTransient<IApiClient, ApiClient>();
        services.AddHttpClient(ClientName, client =>
        {
            client.DefaultRequestHeaders.AcceptLanguage.Clear();
            client.DefaultRequestHeaders.AcceptLanguage.ParseAdd(CultureInfo.DefaultThreadCurrentCulture?.TwoLetterISOLanguageName);
            client.BaseAddress = new Uri(config["ApiBaseUrl"]!);
        })
           .AddHttpMessageHandler<JwtAuthenticationHeaderHandler>()
           .Services
           .AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient(ClientName));
        services.AddTransient<IClientPreferenceManager, ClientPreferenceManager>();
        services.AddTransient<IPreference, ClientPreference>();
        services.AddNotifications();
        return services;

    }

    public static IServiceCollection AutoRegisterInterfaces<T>(this IServiceCollection services)
    {
        var @interface = typeof(T);

        var types = @interface
            .Assembly
            .GetExportedTypes()
            .Where(t => t.IsClass && !t.IsAbstract)
            .Select(t => new
            {
                Service = t.GetInterface($"I{t.Name}"),
                Implementation = t
            })
            .Where(t => t.Service != null);

        foreach (var type in types)
        {
            if (@interface.IsAssignableFrom(type.Service))
            {
                services.AddTransient(type.Service, type.Implementation);
            }
        }

        return services;
    }
}
