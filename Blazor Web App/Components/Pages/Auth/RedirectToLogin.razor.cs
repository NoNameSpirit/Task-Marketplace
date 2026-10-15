using Microsoft.AspNetCore.Components;

namespace Blazor_Web_App.Components.Pages.Auth;

public partial class RedirectToLogin : ComponentBase
{
    [Inject] public NavigationManager Navigation { get; set; } = null!;

    private bool _isForseNavigate = true;

    protected override void OnInitialized()
    {
        Navigation.NavigateTo("/login", _isForseNavigate);
    }
}
