using Blazor_Web_App.Resources;
using Blazor_Web_App.Services.Receivers.ProjectTasks;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;

namespace Blazor_Web_App.Components.Pages.TasksModals;

public partial class RateExecutorModal : ComponentBase
{
    [Inject] public IProjectTaskService ProjectTaskService { get; set; } = null!;
    [Inject] public IStringLocalizer<SharedResources> Localizer { get; set; } = null!;

    private const int MinRating = 1;
    private const int MaxRating = 5;

    [Parameter] public bool IsVisible { get; set; }

    [Parameter] public Guid TaskId { get; set; }

    [Parameter] public EventCallback OnCompleted { get; set; }

    [Parameter] public EventCallback OnClose { get; set; }

    private int SelectedRating = MinRating;
    private bool IsSubmitting;
    private string ErrorMessage = string.Empty;

    protected override void OnParametersSet()
    {
        if (IsVisible)
        {
            SelectedRating = MinRating;
            ErrorMessage = string.Empty;
        }
    }

    private async Task Submit()
    {
        await Send(SelectedRating);
    }

    private async Task Skip()
    {
        await Send(null);
    }

    private async Task Send(int? rating)
    {
        IsSubmitting = true;
        ErrorMessage = string.Empty;

        var result = await ProjectTaskService.MarkAsDoneAsync(TaskId, rating);

        if (result.IsSuccess)
        {
            await OnCompleted.InvokeAsync();
            await CloseModal();
        }
        else
        {
            ErrorMessage = result.Message;
        }

        IsSubmitting = false;
    }

    private async Task CloseModal()
    {
        IsVisible = false;
        await OnClose.InvokeAsync();
    }
}