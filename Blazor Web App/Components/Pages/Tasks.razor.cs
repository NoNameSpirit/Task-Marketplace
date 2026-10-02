using Blazor_Web_App.Modals;
using Blazor_Web_App.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;
using Shared.Enums;
using System.Security.Claims;

namespace Blazor_Web_App.Components.Pages;

public partial class Tasks : ComponentBase
{
    [Inject] public ApiService ApiService { get; set; } = null!;
    [Inject] public AuthenticationStateProvider AuthStateProvider { get; set; } = null!;
    [Inject] public NavigationManager Nav { get; set; } = null!;

    private const int PageSize = 10;
    private const int FirstPage = 1;

    private readonly ModalState _createModal = new();
    private readonly ModalState _responsesModal = new();
    private readonly ModalState _chatModal = new();
    private readonly ModalState _rateModal = new();

    private List<ProjectTaskDto>? ListTasks;
    private Guid CurrentUserId;
    private int CurrentPage = FirstPage;
    private int TotalPages = FirstPage;
    private bool IsLoading;
    private bool IsCustomer;
    private bool IsExecutor;
    private bool _initialized;
    private string ErrorMessage = string.Empty;
    private string PageTitleText = "Tasks";

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
        PageTitleText = IsCustomer ? "My Tasks" : "Available Tasks";
        CurrentUserId = userId;

        await LoadTasks();

        StateHasChanged();
    }

    private async Task LoadTasks()
    {
        IsLoading = true;
        ErrorMessage = string.Empty;

        Result<PagedResult<ProjectTaskDto>> result;

        if (IsCustomer)
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
        var title = ListTasks?.FirstOrDefault(t => t.Id == taskId)?.Title ?? string.Empty;

        _rateModal.Open(taskId, title);
    }

    private void ShowCreateModal()
    {
        _createModal.Open(Guid.Empty);
    }
}