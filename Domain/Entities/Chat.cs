using Domain.Constants;
using Shared.Dtos.Responses;

namespace Domain.Entities;

public class Chat : Entity
{
    public Guid ProjectTaskId { get; private set; }

    private readonly List<Message> _messages = new();
    public IReadOnlyCollection<Message> Messages
        => _messages.AsReadOnly();

    private Chat() { }

    public static Result<Chat> Create(Guid projectTaskId)
    {
        var chat = new Chat()
        {
            Id = Guid.NewGuid(),
            ProjectTaskId = projectTaskId,
        };

        return Result<Chat>.Success(chat);
    }

    public Result AddMessage(
        string text,
        Guid senderId)
    {
        if (string.IsNullOrEmpty(text))
        {
            return Result.Failure(ErrorMessages.MessageTextCannotBeEmpty);
        }

        var message = new Message(
            text,
            senderId,
            Id,
            DateTimeOffset.UtcNow);

        _messages.Add(message);

        return Result.Success();
    }
}
