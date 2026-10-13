using Blazor_Web_App.Services;
using Blazor_Web_App.Services.LocalStorage;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Shared.Dtos.Responses.Users;

namespace Blazor_Web_App.Components.Layout;

public partial class MainLayout : LayoutComponentBase
{
    [Inject] public AuthenticationStateProvider AuthStateProvider { get; set; } = null!;
    [Inject] public NavigationManager Nav { get; set; } = null!;
    [Inject] public ILocalStorageService LocalStorage { get; set; } = null!;

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (!firstRender) return;

        var state = await AuthStateProvider.GetAuthenticationStateAsync();

        if (!state.User.Identity?.IsAuthenticated ?? true)
        {
            Nav.NavigateTo("/login");
        }
    }

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