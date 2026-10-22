using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;

namespace Blazor_Web_App.Components.Pages.Auth;

[AllowAnonymous]
public partial class RedirectToLogin : ComponentBase
{
    [Inject] public NavigationManager Navigation { get; set; } = null!;

    private const bool IsForceNavigate = true;

    protected override void OnInitialized()
    {
        Navigation.NavigateTo("/login", IsForceNavigate);
    }
}