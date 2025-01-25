﻿using budget_request_app.Blazor.Infrastructure.Themes;
using budget_request_app.Blazor.Infrastructure.Preferences;
using MudBlazor;

namespace budget_request_app.Blazor.Client.Layout;

public partial class NotFound
{
    private ClientPreference? _themePreference;
    private MudTheme _theme = new FshTheme();
    private bool _isDarkMode;

    protected override async Task OnInitializedAsync()
    {
        _themePreference = await ClientPreferences.GetPreference() as ClientPreference;
        if (_themePreference == null) _themePreference = new ClientPreference();
        SetCurrentTheme(_themePreference);
    }

    private void SetCurrentTheme(ClientPreference themePreference)
    {
        _isDarkMode = themePreference.IsDarkMode;
        //_currentTheme = new FshTheme();
        //if (themePreference.IsDarkMode)
        //{
        //    _currentTheme.
        //}
        //_currentTheme.Palette.Primary = themePreference.PrimaryColor;
        //_currentTheme.Palette.Secondary = themePreference.SecondaryColor;
        //_currentTheme.LayoutProperties.DefaultBorderRadius = $"{themePreference.BorderRadius}px";
        //_currentTheme.LayoutProperties.DefaultBorderRadius = $"{themePreference.BorderRadius}px";
        //_rightToLeft = themePreference.IsRTL;
    }
}
