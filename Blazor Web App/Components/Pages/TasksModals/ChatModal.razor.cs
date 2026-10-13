using Blazor_Web_App.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Shared.Dtos.Responses.Chats;

namespace Blazor_Web_App.Components.Pages.TasksModals;

public partial class ChatModal : ComponentBase, IDisposable
{
    [Parameter] public bool IsVisible { get; set; }
    [Parameter] public Guid TaskId { get; set; }
    [Parameter] public Guid CurrentUserId { get; set; }
    [Parameter] public EventCallback OnClose { get; set; }
    [Inject] public ApiService ApiService { get; set; } = null!;

    private ChatDto? Chat;
    private string TaskTitle = string.Empty;
    private string NewMessage = string.Empty;
    private string ErrorMessage = string.Empty;
    private bool IsLoading;
    private bool IsSending;
    private Timer? _pollingTimer;

    private const int PollingIntervalSeconds = 2;

    protected override async Task OnParametersSetAsync()
    {
        if (!IsVisible || TaskId == Guid.Empty)
        {
            StopPolling();
            return;
        }

        await LoadTitle();
        await LoadChat();

        StartPolling();
    }

    private void StartPolling()
    {
        StopPolling();

        _pollingTimer = new System.Threading.Timer(async _ =>
        {
            await InvokeAsync(async () =>
            {
                if (!IsVisible) return;
                await SilentReload();
                StateHasChanged();
            });
        }, null, TimeSpan.FromSeconds(PollingIntervalSeconds), TimeSpan.FromSeconds(PollingIntervalSeconds));
    }

    private void StopPolling()
    {
        _pollingTimer?.Dispose();
        _pollingTimer = null;
    }

    private async Task SilentReload()
    {
        if (Chat is null)
        {
            return;
        }

        var existing = await ApiService.GetChatByTaskIdAsync(TaskId);

        if (existing.IsSuccess && existing.Value is not null)
        {
            Chat = existing.Value;
        }
    }

    private async Task LoadTitle()
    {
        var result = await ApiService.GetTaskByIdAsync(TaskId);

        if (result.IsSuccess && result.Value is not null)
            TaskTitle = result.Value.Title;
    }

    private async Task LoadChat()
    {
        IsLoading = true;
        ErrorMessage = string.Empty;

        var existing = await ApiService.GetChatByTaskIdAsync(TaskId);

        if (existing.IsSuccess && existing.Value is not null)
        {
            Chat = existing.Value;
        }
        else
        {
            var created = await ApiService.CreateChatAsync(TaskId);

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
        if (string.IsNullOrWhiteSpace(NewMessage) || Chat is null) return;

        IsSending = true;

        var result = await ApiService.SendMessageAsync(Chat.Id, NewMessage, CurrentUserId);

        if (result.IsSuccess)
        {
            NewMessage = string.Empty;
            await LoadChat();
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

    public void Dispose()
    {
        StopPolling();
    }
}