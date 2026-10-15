using Shared.Dtos.Responses;
using Shared.Dtos.Responses.Chats;

namespace Blazor_Web_App.Services.Receivers.Chats;

public interface IChatService
{
    Task<Result<ChatDto>> CreateChatAsync(Guid taskId, CancellationToken cancellationToken = default);

    Task<Result<ChatDto>> GetChatByTaskIdAsync(Guid taskId, CancellationToken cancellationToken = default);

    Task<Result> SendMessageAsync(Guid chatId, string text, Guid senderId, CancellationToken cancellationToken = default);
}