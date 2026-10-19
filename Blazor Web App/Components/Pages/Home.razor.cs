using Blazor_Web_App.Resources;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;

namespace Blazor_Web_App.Components.Pages;

[Authorize]
public partial class Home : ComponentBase
{
    [Inject] public IStringLocalizer<SharedResources> Localizer { get; set; } = null!;
}