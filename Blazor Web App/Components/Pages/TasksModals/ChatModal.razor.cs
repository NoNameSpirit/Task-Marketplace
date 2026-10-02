using Blazor_Web_App.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Shared.Dtos.Responses.Chats;

namespace Blazor_Web_App.Components.Pages.TasksModals;

public partial class ChatModal : ComponentBase
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

    protected override async Task OnParametersSetAsync()
    {
        if (!IsVisible || TaskId == Guid.Empty) return;

        await LoadTitle();
        await LoadChat();
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
}