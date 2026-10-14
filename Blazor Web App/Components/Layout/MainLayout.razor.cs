using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;

namespace Blazor_Web_App.Components.Layout;

public partial class MainLayout : LayoutComponentBase
{
    [Inject] public AuthenticationStateProvider AuthStateProvider { get; set; } = null!;
    [Inject] public NavigationManager Nav { get; set; } = null!;

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (!firstRender) return;

        var state = await AuthStateProvider.GetAuthenticationStateAsync();

        if (!state.User.Identity?.IsAuthenticated ?? true)
        {
            Nav.NavigateTo("/login");
        }
    }
}