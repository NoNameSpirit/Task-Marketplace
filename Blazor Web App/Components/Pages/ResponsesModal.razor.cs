using Blazor_Web_App.Services;
using Microsoft.AspNetCore.Components;
using Shared.Dtos.Responses.ProjectTasks;

namespace Blazor_Web_App.Components.Pages;

public partial class ResponsesModal : ComponentBase
{
    [Parameter] public bool IsVisible { get; set; }
    [Parameter] public Guid TaskId { get; set; }
    [Parameter] public string TaskTitle { get; set; } = string.Empty;
    [Parameter] public EventCallback OnAssigned { get; set; }
    [Parameter] public EventCallback OnClose { get; set; }
    [Inject] public ApiService ApiService { get; set; } = null!;

    private List<TaskResponseDto>? Responses;
    private Guid _assigningId;
    private bool IsLoading;
    private bool IsAssigning;
    private string ErrorMessage = string.Empty;

    protected override async Task OnParametersSetAsync()
    {
        if (IsVisible && TaskId != Guid.Empty)
        {
            await LoadResponses();
        }
    }

    private async Task LoadResponses()
    {
        IsLoading = true;
        ErrorMessage = string.Empty;

        var result = await ApiService.GetTaskResponsesAsync(TaskId);

        if (result.IsSuccess)
        {
            Responses = result.Value;
        }
        else
        {
            ErrorMessage = result.Message;
        }

        IsLoading = false;
    }

    private async Task HandleAssign(Guid executorId)
    {
        IsAssigning = true;
        _assigningId = executorId;

        var result = await ApiService.AssignExecutorAsync(TaskId, executorId);

        if (result.IsSuccess)
        {
            await OnAssigned.InvokeAsync();
            Close();
        }
        else
        {
            ErrorMessage = result.Message;
        }

        IsAssigning = false;
        _assigningId = Guid.Empty;
    }

    private void Close()
    {
        IsVisible = false;
        OnClose.InvokeAsync();
    }
}