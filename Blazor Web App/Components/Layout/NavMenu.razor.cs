using Blazor_Web_App.Services;
using Blazor_Web_App.Services.LocalStorage;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;

namespace Blazor_Web_App.Components.Layout;

public partial class NavMenu : ComponentBase
{
    [Inject] AuthenticationStateProvider AuthStateProvider { get; set; } = null!;
    [Inject] ILocalStorageService LocalStorageService { get; set; } = null!;
    [Inject] NavigationManager NavigationManager { get; set; } = null!;

    private async Task HandleLogout()
    {
        await LocalStorageService.RemoveItemAsync("Token");
        await LocalStorageService.RemoveItemAsync("Name");
        await LocalStorageService.RemoveItemAsync("Role");

        ((CustomAuthStateProvider)AuthStateProvider).NotifyLogout();

        NavigationManager.NavigateTo("/", forceLoad: true);
    }
}
