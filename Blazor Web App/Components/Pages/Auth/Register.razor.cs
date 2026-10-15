using Blazor_Web_App.Resources;
using Blazor_Web_App.Services;
using Blazor_Web_App.Services.LocalStorage;
using Blazor_Web_App.Services.Receivers;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.Extensions.Localization;
using Shared.Dtos.Requests.Users;
using Shared.Dtos.Responses.Users;
using Shared.Enums;

namespace Blazor_Web_App.Components.Pages.Auth;

public partial class Register : ComponentBase
{
    [Inject] public BaseService ApiService { get; set; } = null!;
    [Inject] public ILocalStorageService LocalStorageService { get; set; } = null!;
    [Inject] public AuthenticationStateProvider AuthStateProvider { get; set; } = null!;
    [Inject] public NavigationManager NavigationManager { get; set; } = null!;
    [Inject] public IStringLocalizer<SharedResources> Loc { get; set; } = null!;

    protected string PageTitle
        => nameof(Register);
    protected string Login { get; set; } = string.Empty;
    protected string Password { get; set; } = string.Empty;
    protected UserRole Role { get; set; } = UserRole.Customer;
    protected string ErrorMessage { get; set; } = string.Empty;
    protected bool IsSuccess { get; set; }
    protected bool IsLoading { get; set; }

    public async Task HandleRegister()
    {
        IsLoading = true;
        ErrorMessage = string.Empty;

        var registerUserDto = new RegisterUserDto(Login, Password, Role);

        var registerResult = await ApiService.RegisterAsync(registerUserDto);

        if (registerResult.IsSuccess)
        {
            await LocalStorageService.SetItemAsync(nameof(AuthDto.Token), registerResult.Value!.Token);
            await LocalStorageService.SetItemAsync(nameof(AuthDto.Name), registerResult.Value!.Name);
            await LocalStorageService.SetItemAsync(nameof(AuthDto.Role), registerResult.Value!.Role.ToString());
            await LocalStorageService.SetItemAsync(nameof(AuthDto.Id), registerResult.Value.Id.ToString());

            ((CustomAuthStateProvider)AuthStateProvider).NotifyLogin(
                registerResult.Value!.Name,
                registerResult.Value!.Role,
                registerResult.Value.Id.ToString());

            NavigationManager.NavigateTo("/");
        }
        else
        {
            ErrorMessage = registerResult.Message;
        }

        IsSuccess = registerResult.IsSuccess;
        IsLoading = false;
    }
}
