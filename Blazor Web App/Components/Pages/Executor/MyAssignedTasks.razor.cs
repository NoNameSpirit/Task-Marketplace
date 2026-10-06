using Blazor_Web_App.Modals;
using Blazor_Web_App.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Shared.Dtos.Responses.ProjectTasks;
using Shared.Enums;
using System.Security.Claims;

namespace Blazor_Web_App.Components.Pages.Executor;

public partial class MyAssignedTasks : ComponentBase
{
    [Inject] public ApiService ApiService { get; set; } = null!;
    [Inject] public AuthenticationStateProvider AuthStateProvider { get; set; } = null!;
    [Inject] public NavigationManager Nav { get; set; } = null!;

    private const int PageSize = 10;
    private const int FirstPage = 1;

    private List<ProjectTaskDto>? ListTasks;
    private Guid CurrentUserId;
    private Guid _chatTaskId;
    private int CurrentPage = FirstPage;
    private int TotalPages = FirstPage;
    private bool IsLoading;
    private bool IsChatModalOpen;
    private bool _initialized;
    private string ErrorMessage = string.Empty;
    private readonly ModalState _attachmentsModal = new();
    private ProjectTaskDto? _attachmentsModalTask;


    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (!firstRender || _initialized) return;

        _initialized = true;

        var state = await AuthStateProvider.GetAuthenticationStateAsync();

        if (!state.User.Identity?.IsAuthenticated ?? true)
        {
            Nav.NavigateTo("/login");
            return;
        }

        var idClaim = state.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

        if (!Guid.TryParse(idClaim, out var userId))
        {
            Nav.NavigateTo("/login");
            return;
        }

        CurrentUserId = userId;

        await LoadTasks();

        StateHasChanged();
    }

    private void OpenAttachmentsModal(Guid taskId)
    {
        _attachmentsModalTask = ListTasks?.FirstOrDefault(t => t.Id == taskId);
        _attachmentsModal.Open(taskId);
    }

    private bool ComputeCanUpload()
    {
        if (_attachmentsModalTask is null) return false;

        var isParticipant = _attachmentsModalTask.CustomerId == CurrentUserId
                            || _attachmentsModalTask.ExecutorId == CurrentUserId;

        var isOpen = _attachmentsModalTask.Status != ProjectTaskStatus.Done
                  && _attachmentsModalTask.Status != ProjectTaskStatus.Cancelled;

        return isParticipant && isOpen;
    }

    private async Task LoadTasks()
    {
        IsLoading = true;
        ErrorMessage = string.Empty;

        var result = await ApiService.GetAssignedTasksAsync(CurrentUserId, CurrentPage, PageSize);

        if (result.IsSuccess && result.Value is not null)
        {
            ListTasks = result.Value.Collection.ToList();
            TotalPages = (int)Math.Ceiling((double)result.Value.TotalCount / PageSize);

            if (TotalPages < FirstPage)
            {
                TotalPages = FirstPage;
            }
        }
        else
        {
            ErrorMessage = result.Message;
            ListTasks = new List<ProjectTaskDto>();
        }

        IsLoading = false;
    }

    private async Task GoToPage(int page)
    {
        if (page < FirstPage || page > TotalPages) return;

        CurrentPage = page;

        await LoadTasks();
    }

    private void OpenChatModal(Guid taskId)
    {
        _chatTaskId = taskId;
        IsChatModalOpen = true;
    }
}