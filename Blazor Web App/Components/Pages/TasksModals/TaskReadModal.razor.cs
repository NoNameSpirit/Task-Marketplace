using Blazor_Web_App.Resources;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using Shared.Dtos.Responses.ProjectTasks;

namespace Blazor_Web_App.Components.Pages.TasksModals;

public partial class TaskReadModal : ComponentBase
{
    [Inject] public IStringLocalizer<SharedResources> Localizer { get; set; } = null!;

    public const string PriceFormat = "0.00";

    [Parameter] public bool IsVisible { get; set; }
    [Parameter] public ProjectTaskDto? ProjectTask { get; set; }
    [Parameter] public EventCallback OnClose { get; set; }

    private async Task HandleClose()
    {
        await OnClose.InvokeAsync();
    }
}
