﻿using budget_request_app.Blazor.Client.Components;
using budget_request_app.Blazor.Infrastructure.Api;
using budget_request_app.Shared.Authorization;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace budget_request_app.Blazor.Client.Pages.Auth;

public partial class SelfRegister
{
    private readonly RegisterUserCommand _createUserRequest = new();
    private FshValidation? _customValidation;
    private bool BusySubmitting { get; set; }

    [Inject]
    private IApiClient UsersClient { get; set; } = default!;

    private string Tenant { get; set; } = TenantConstants.Root.Id;

    private bool _passwordVisibility;
    private InputType _passwordInput = InputType.Password;
    private string _passwordInputIcon = Icons.Material.Filled.VisibilityOff;

    private async Task SubmitAsync()
    {
        BusySubmitting = true;

        var response = await ApiHelper.ExecuteCallGuardedAsync(
            () => UsersClient.SelfRegisterUserEndpointAsync(Tenant, _createUserRequest),
            Toast, Navigation,
            _customValidation);

        if (response != null)
        {
            Toast.Add($"user {response.UserId} registered.", Severity.Success);
            Navigation.NavigateTo("/login");
        }

        BusySubmitting = false;
    }

    private void TogglePasswordVisibility()
    {
        if (_passwordVisibility)
        {
            _passwordVisibility = false;
            _passwordInputIcon = Icons.Material.Filled.VisibilityOff;
            _passwordInput = InputType.Password;
        }
        else
        {
            _passwordVisibility = true;
            _passwordInputIcon = Icons.Material.Filled.Visibility;
            _passwordInput = InputType.Text;
        }
    }
}
