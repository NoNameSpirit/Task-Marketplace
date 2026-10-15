using Blazor_Web_App.Services.Receivers;
using Microsoft.AspNetCore.Components;
using Shared.Dtos.Requests.ProjectTasks;
using Shared.Dtos.Responses.ProjectTasks;

namespace Blazor_Web_App.Components.Pages.TasksModals;

public partial class EditTaskModal : ComponentBase
{
    [Parameter] public bool IsVisible { get; set; }
    [Parameter] public ProjectTaskDto? Task { get; set; }
    [Parameter] public EventCallback OnUpdated { get; set; }
    [Parameter] public EventCallback OnClose { get; set; }
    [Inject] public BaseService ApiService { get; set; } = null!;

    private string Title = string.Empty;
    private string Description = string.Empty;
    private decimal Price;
    private DateTimeOffset StartsAt;
    private DateTimeOffset EndsAt;
    private bool IsSubmitting;
    private string ErrorMessage = string.Empty;

    protected override void OnParametersSet()
    {
        if (Task is null) return;

        Title = Task.Title;
        Description = Task.Description;
        Price = Task.Price;
        StartsAt = Task.StartsAt;
        EndsAt = Task.EndsAt;
    }

    private async Task Submit()
    {
        if (Task is null) return;

        IsSubmitting = true;
        ErrorMessage = string.Empty;

        var dto = new UpdateProjectTaskDto(
            Title,
            Description,
            Price,
            StartsAt,
            EndsAt);

        var result = await ApiService.UpdateTaskAsync(Task.Id, dto);

        if (result.IsSuccess)
        {
            await OnUpdated.InvokeAsync();
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