using Blazor_Web_App.Services;
using Blazor_Web_App.Services.LocalStorage;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Shared.Dtos.Requests.Users;
using Shared.Dtos.Responses.Users;

namespace Blazor_Web_App.Components.Pages;

public partial class Login : ComponentBase
{
    [Inject] public ApiService ApiService { get; set; } = null!;
    [Inject] public ILocalStorageService LocalStorageService { get; set; } = null!;
    [Inject] public AuthenticationStateProvider AuthStateProvider { get; set; } = null!;
    [Inject] public NavigationManager NavigationManager { get; set; } = null!;

    protected string Name { get; set; } = string.Empty;
    protected string Password { get; set; } = string.Empty;
    protected string ErrorMessage { get; set; } = string.Empty;
    protected bool IsSuccess { get; set; }
    protected bool IsLoading { get; set; }

    public async Task HandleLogin()
    {
        IsLoading = true;
        ErrorMessage = string.Empty;

        var loginDto = new LoginDto(Name, Password);
        var result = await ApiService.LoginAsync(loginDto);

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

            NavigationManager.NavigateTo("/");
        }
        else
        {
            ErrorMessage = result.Message ?? "Invalid credentials";
        }

        IsLoading = false;
    }
}
