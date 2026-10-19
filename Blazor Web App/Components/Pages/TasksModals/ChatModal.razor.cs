using Blazor_Web_App.Resources;
using Blazor_Web_App.Services.Receivers.Chats;
using Blazor_Web_App.Services.Receivers.ProjectTasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.Extensions.Localization;
using Shared.Dtos.Responses.Chats;

namespace Blazor_Web_App.Components.Pages.TasksModals;

public partial class ChatModal : ComponentBase, IDisposable
{
    [Inject] public IChatService ChatService { get; set; } = null!;
    [Inject] public IProjectTaskService ProjectTaskService { get; set; } = null!;
    [Inject] public IStringLocalizer<SharedResources> Localizer { get; set; } = null!;

    private const int PollingIntervalSeconds = 2;

    [Parameter] public bool IsVisible { get; set; }

    [Parameter] public Guid TaskId { get; set; }

    [Parameter] public Guid CurrentUserId { get; set; }

    [Parameter] public EventCallback OnClose { get; set; }

    private ChatDto? Chat;
    private string TaskTitle = string.Empty;
    private string NewMessage = string.Empty;
    private string ErrorMessage = string.Empty;
    private bool IsLoading;
    private bool IsSending;
    private CancellationTokenSource? _cancellationTokenSource;
    private PeriodicTimer? _periodicTimer;
    private Guid? _currentTaskId;
    private bool _disposed;

    protected override async Task OnParametersSetAsync()
    {
        if (!IsVisible || TaskId == Guid.Empty)
        {
            StopPolling();
            _currentTaskId = null;
            return;
        }

        if (_currentTaskId == TaskId && _periodicTimer is not null)
        {
            return;
        }

        StopPolling();
        _currentTaskId = TaskId;

        await LoadTitle();
        await LoadChat();

        StartPolling();
    }

    private void StartPolling()
    {
        if (_periodicTimer is not null)
        {
            return;
        }

        _cancellationTokenSource = new CancellationTokenSource();
        var cancellationToken = _cancellationTokenSource.Token;

        var timer = new PeriodicTimer(TimeSpan.FromSeconds(PollingIntervalSeconds));
        _periodicTimer = timer;

        _ = Task.Run(async () =>
        {
            try
            {
                while (await timer.WaitForNextTickAsync(cancellationToken))
                {
                    if (!IsVisible || _disposed)
                    {
                        break;
                    }

                    await SilentReload();
                    await InvokeAsync(StateHasChanged);
                }
            }
            catch (OperationCanceledException) { }
            catch (ObjectDisposedException) { }
        },
        cancellationToken);
    }

    private async Task SilentReload()
    {
        if (Chat is null)
        {
            return;
        }

        var existing = await ChatService.GetChatByTaskIdAsync(TaskId);

        if (existing.IsSuccess && existing.Value is not null)
        {
            Chat = existing.Value;
        }
    }

    private async Task LoadTitle()
    {
        var result = await ProjectTaskService.GetTaskByIdAsync(TaskId);

        if (result.IsSuccess && result.Value is not null)
        {
            TaskTitle = result.Value.Title;
        }
    }

    private async Task LoadChat()
    {
        IsLoading = true;
        ErrorMessage = string.Empty;

        var existing = await ChatService.GetChatByTaskIdAsync(TaskId);

        if (existing.IsSuccess && existing.Value is not null)
        {
            Chat = existing.Value;
        }
        else
        {
            var created = await ChatService.CreateChatAsync(TaskId);

            if (!created.IsSuccess)
            {
                ErrorMessage = created.Message;
                IsLoading = false;
                return;
            }

            Chat = created.Value;
        }

        IsLoading = false;
    }

    private async Task Send()
    {
        if (string.IsNullOrWhiteSpace(NewMessage) || Chat is null)
        {
            return;
        }

        IsSending = true;

        var result = await ChatService.SendMessageAsync(Chat.Id, NewMessage, CurrentUserId);

        if (result.IsSuccess)
        {
            NewMessage = string.Empty;
            await SilentReload();
        }
        else
        {
            ErrorMessage = result.Message;
        }

        IsSending = false;
    }

    private async Task Close()
    {
        StopPolling();

        IsVisible = false;
        await OnClose.InvokeAsync();
    }

    private async Task HandleKeyDown(KeyboardEventArgs e)
    {
        if (e.Key == "Enter")
        {
            await Send();
        }
    }

    protected virtual void Dispose(bool disposing)
    {
        if (_disposed)
        {
            return;
        }

        if (disposing)
        {
            StopPolling();
        }

        _disposed = true;
    }

    private void StopPolling()
    {
        if (_cancellationTokenSource is not null)
        {
            _cancellationTokenSource.Cancel();
            _cancellationTokenSource.Dispose();
            _cancellationTokenSource = null;
        }

        if (_periodicTimer is not null)
        {
            _periodicTimer.Dispose();
            _periodicTimer = null;
        }
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
}