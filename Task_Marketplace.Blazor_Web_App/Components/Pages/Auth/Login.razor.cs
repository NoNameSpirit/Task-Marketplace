using Blazor_Web_App.Resources;
using Blazor_Web_App.Services;
using Blazor_Web_App.Services.LocalStorage;
using Blazor_Web_App.Services.Receivers.Auth;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.Extensions.Localization;
using Shared.Dtos.Responses.Users;
using Task_Marketplace.Shared.Dtos.Requests.Auth.Commands;

namespace Blazor_Web_App.Components.Pages.Auth;

[AllowAnonymous]
public partial class Login : ComponentBase
{
    [Inject] public IAuthService AuthService { get; set; } = null!;
    [Inject] public ILocalStorageService LocalStorageService { get; set; } = null!;
    [Inject] public AuthenticationStateProvider AuthStateProvider { get; set; } = null!;
    [Inject] public NavigationManager NavigationManager { get; set; } = null!;
    [Inject] public IStringLocalizer<SharedResources> Localizer { get; set; } = null!;

    private const string IndexUri = "/";

    protected string Name { get; set; } = string.Empty;

    protected string Password { get; set; } = string.Empty;

    protected string ErrorMessage { get; set; } = string.Empty;

    protected bool IsSuccess { get; set; }

    protected bool IsLoading { get; set; }

    public async Task HandleLogin()
    {
        IsLoading = true;
        ErrorMessage = string.Empty;

        var loginDto = new LoginRequest(Name, Password);
        var result = await AuthService.LoginAsync(loginDto);

        if (result.IsSuccess)
        {
            await LocalStorageService.SetItemAsync(nameof(AuthDto.Token), result.Value!.Token);
            await LocalStorageService.SetItemAsync(nameof(AuthDto.Name), result.Value.Name);
            await LocalStorageService.SetItemAsync(nameof(AuthDto.Role), result.Value.Role.ToString());
            await LocalStorageService.SetItemAsync(nameof(AuthDto.Id), result.Value.Id.ToString());

            ((CustomAuthStateProvider)AuthStateProvider).NotifyLogin(
                result.Value.Name,
                result.Value.Role.ToString(),
                result.Value.Id.ToString());

            NavigationManager.NavigateTo(IndexUri);
        }
        else
        {
            ErrorMessage = result.Message;
        }

        IsLoading = false;
    }
}