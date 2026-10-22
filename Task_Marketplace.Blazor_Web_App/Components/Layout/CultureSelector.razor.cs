using Blazor_Web_App.Constants;
using Blazor_Web_App.Services.Culture;
using Microsoft.AspNetCore.Components;

namespace Blazor_Web_App.Components.Layout;

public partial class CultureSelector : ComponentBase
{
    [Inject] public ICultureService CultureService { get; set; } = null!;
    [Inject] public NavigationManager Nav { get; set; } = null!;

    private string _current = CultureConstants.Default;

    protected override async Task OnInitializedAsync()
    {
        _current = await CultureService.GetCultureAsync();
        CultureService.Apply(_current);
    }

    private async Task OnCultureChanged(ChangeEventArgs e)
    {
        var next = e.Value?.ToString();

        if (string.IsNullOrEmpty(next) || next == _current)
        {
            return;
        }

        await CultureService.SetCultureAsync(next);

        Nav.NavigateTo(Nav.Uri, forceLoad: true);
    }
}