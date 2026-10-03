using Blazor_Web_App.Services;
using Microsoft.AspNetCore.Components;
using Shared.Dtos.Responses.ProjectTasks;
using Shared.Enums;

namespace Blazor_Web_App.Components.Pages.TasksModals;

public partial class TaskCard : ComponentBase
{
    [Parameter, EditorRequired] public ProjectTaskDto ProjectTask { get; set; } = null!;
    [Parameter] public bool IsExecutor { get; set; }
    [Parameter] public bool IsCustomer { get; set; }
    [Parameter] public bool IsResponded { get; set; }
    [Parameter] public EventCallback<Guid> OnDeleted { get; set; }
    [Parameter] public EventCallback<Guid> OnRespond { get; set; }
    [Parameter] public EventCallback<Guid> OnOpenChat { get; set; }
    [Parameter] public EventCallback<Guid> OnMarkDone { get; set; }
    [Parameter] public EventCallback<Guid> OnCancel { get; set; }
    [Parameter] public EventCallback<Guid> OnEdit { get; set; }
    [Inject] public ApiService ApiService { get; set; } = null!;

    private bool ShowEditButton
         => IsCustomer
         && ProjectTask.Status != ProjectTaskStatus.InProgress
         && ProjectTask.Status != ProjectTaskStatus.Done
         && ProjectTask.Status != ProjectTaskStatus.Cancelled;

    private bool ShowDeleteButton
        => IsCustomer
        && ProjectTask.Status != ProjectTaskStatus.Done
        && ProjectTask.Status != ProjectTaskStatus.Cancelled;

    private bool ShowRespondButton
        => IsExecutor && ProjectTask.Status == ProjectTaskStatus.Published;

    private bool ShowChatButton
        => ProjectTask.Status == ProjectTaskStatus.InProgress;

    private bool ShowMarkDoneButton
        => IsCustomer && ProjectTask.Status == ProjectTaskStatus.InProgress;

    private bool ShowCancelButton
        => IsCustomer
        && ProjectTask.Status != ProjectTaskStatus.Done
        && ProjectTask.Status != ProjectTaskStatus.Cancelled;

    private async Task HandleRespond()
    {
        await OnRespond.InvokeAsync(ProjectTask.Id);
    }

    private async Task HandleDelete()
    {
        var result = await ApiService.DeleteTaskAsync(ProjectTask.Id);

        if (result.IsSuccess)
        {
            await OnDeleted.InvokeAsync(ProjectTask.Id);
        }
    }

    private async Task HandleOpenChat()
    {
        await OnOpenChat.InvokeAsync(ProjectTask.Id);
    }

    private async Task HandleMarkDone()
    {
        await OnMarkDone.InvokeAsync(ProjectTask.Id);
    }

    private async Task HandleCancel()
    {
        await OnCancel.InvokeAsync(ProjectTask.Id);
    }

    private async Task HandleEdit()
    {
        await OnEdit.InvokeAsync(ProjectTask.Id);
    }
}