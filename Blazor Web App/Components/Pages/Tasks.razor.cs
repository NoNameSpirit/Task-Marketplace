using Blazor_Web_App.Modals;
using Blazor_Web_App.Resources;
using Blazor_Web_App.Services.Receivers;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.Extensions.Localization;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;
using Shared.Enums;
using System.Security.Claims;

namespace Blazor_Web_App.Components.Pages;

public partial class Tasks : ComponentBase
{
    [Inject] public BaseService ApiService { get; set; } = null!;
    [Inject] public AuthenticationStateProvider AuthStateProvider { get; set; } = null!;
    [Inject] public NavigationManager Nav { get; set; } = null!;
    [Inject] public IStringLocalizer<SharedResources> Loc { get; set; } = null!;

    private const int PageSize = 10;
    private const int FirstPage = 1;

    private readonly ModalState _createModal = new();
    private readonly ModalState _responsesModal = new();
    private readonly ModalState _chatModal = new();
    private readonly ModalState _rateModal = new();
    private readonly ModalState _editModal = new();
    private readonly ModalState _attachmentsModal = new();

    private List<ProjectTaskDto>? ListTasks;
    private Guid CurrentUserId;
    private int CurrentPage = FirstPage;
    private int TotalPages = FirstPage;
    private bool IsLoading;
    private bool IsCustomer;
    private bool IsExecutor;
    private bool _initialized;
    private string ErrorMessage = string.Empty;
    private string PageTitleTextKey = ResourceKeys.MyTasks;
    private string _searchQuery = string.Empty;
    private ProjectTaskDto? _editingTask;
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

        IsCustomer = state.User.IsInRole(nameof(UserRole.Customer));
        IsExecutor = state.User.IsInRole(nameof(UserRole.Executor));
        PageTitleTextKey = IsCustomer ? ResourceKeys.MyTasks : ResourceKeys.AvailableTasks;
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

        Result<PagedResult<ProjectTaskDto>> result;

        if (!string.IsNullOrWhiteSpace(_searchQuery))
        {
            result = await ApiService.SearchTasksAsync(_searchQuery, CurrentPage, PageSize);
        }
        else if (IsCustomer)
        {
            result = await ApiService.GetMyTasksAsync(CurrentUserId, CurrentPage, PageSize);
        }
        else if (IsExecutor)
        {
            result = await ApiService.GetPublishedTasksAsync(CurrentPage, PageSize);
        }
        else
        {
            ErrorMessage = "Unknown role";
            IsLoading = false;
            return;
        }

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

    private async Task HandleRespond(Guid taskId)
    {
        var result = await ApiService.RespondToTaskAsync(taskId);

        if (result.IsSuccess)
        {
            await LoadTasks();
        }
        else
        {
            ErrorMessage = result.Message;
        }
    }

    private async Task HandleTaskCreated()
    {
        CurrentPage = FirstPage;
        await LoadTasks();
    }

    private async Task HandleTaskDeleted(Guid taskId)
    {
        await LoadTasks();
    }

    private async Task HandleCancel(Guid taskId)
    {
        var result = await ApiService.CancelTaskAsync(taskId);

        if (result.IsSuccess)
        {
            await LoadTasks();
        }
        else
        {
            ErrorMessage = result.Message;
        }
    }

    private async Task HandleRated()
    {
        _rateModal.Close();
        await LoadTasks();
    }

    private async Task GoToPage(int page)
    {
        if (page < FirstPage || page > TotalPages) return;

        CurrentPage = page;

        await LoadTasks();
    }

    private void OpenResponsesModal(Guid taskId, string title)
    {
        _responsesModal.Open(taskId, title);
    }

    private void OpenChatModal(Guid taskId)
    {
        _chatModal.Open(taskId);
    }

    private void OpenRateModal(Guid taskId)
    {
        _rateModal.Open(taskId);
    }

    private void ShowCreateModal()
    {
        _createModal.Open(Guid.Empty);
    }

    private async Task HandleSearch()
    {
        CurrentPage = FirstPage;
        await LoadTasks();
    }

    private async Task ClearSearch()
    {
        _searchQuery = string.Empty;
        CurrentPage = FirstPage;
        await LoadTasks();
    }

    private void OpenEditModal(Guid taskId)
    {
        _editingTask = ListTasks?.FirstOrDefault(t => t.Id == taskId);

        if (_editingTask is null)
        {
            return;
        }

        _editModal.Open(taskId);
    }

    private async Task HandleTaskUpdated()
    {
        _editModal.Close();

        await LoadTasks();
    }
}