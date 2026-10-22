using Blazor_Web_App.Services;
using Blazor_Web_App.Services.LocalStorage;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Shared.Dtos.Responses.Users;

namespace Blazor_Web_App.Components.Layout;

public partial class NavMenu : ComponentBase
{
    [Inject] public ILocalStorageService LocalStorage { get; set; } = null!;
    [Inject] public AuthenticationStateProvider AuthStateProvider { get; set; } = null!;
    [Inject] public NavigationManager Nav { get; set; } = null!;

    private async Task HandleLogout()
    {
        await LocalStorage.RemoveItemAsync(nameof(AuthDto.Token));
        await LocalStorage.RemoveItemAsync(nameof(AuthDto.Name));
        await LocalStorage.RemoveItemAsync(nameof(AuthDto.Role));
        await LocalStorage.RemoveItemAsync(nameof(AuthDto.Id));

        ((CustomAuthStateProvider)AuthStateProvider).NotifyLogout();

        Nav.NavigateTo("/login");
    }
}