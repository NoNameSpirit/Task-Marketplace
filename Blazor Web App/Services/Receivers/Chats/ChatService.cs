using Blazor_Web_App.Services.LocalStorage;
using Blazor_Web_App.Services.Receivers.Chats;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.Chats;

namespace Blazor_Web_App.Services.Receivers.ProjectTasks;

public class ChatService(
    HttpClient _httpClient,
    ILocalStorageService _localStorage)
    : BaseService(_httpClient, _localStorage), IChatService
{
    public async Task<Result<ChatDto>> CreateChatAsync(
        Guid taskId,
        CancellationToken cancellationToken = default)
    {
        await SetAuthHeaderAsync(cancellationToken);

        var response = await _httpClient.PostAsync(
            $"?projectTaskId={taskId}",
            null,
            cancellationToken);

        var result = await HandleResponseAsync<ChatDto>(
           response,
           cancellationToken);

        return result;
    }

    public async Task<Result<ChatDto>> GetChatByTaskIdAsync(
        Guid taskId,
        CancellationToken cancellationToken = default)
    {
        await SetAuthHeaderAsync(cancellationToken);

        var response = await _httpClient.GetAsync(
            $"task/{taskId}",
            cancellationToken);

        var result = await HandleResponseAsync<ChatDto>(
           response,
           cancellationToken);

        return result;
    }

    public async Task<Result> SendMessageAsync(
        Guid chatId,
        string text,
        Guid senderId,
        CancellationToken cancellationToken = default)
    {
        await SetAuthHeaderAsync(cancellationToken);

        var body = new
        {
            Text = text,
            SenderId = senderId.ToString()
        };

        var response = await _httpClient.PostAsJsonAsync(
            $"{chatId}/messages",
            body,
            cancellationToken);

        var result = await HandleResponseAsync(
           response,
           cancellationToken);

        return result;
    }
}
