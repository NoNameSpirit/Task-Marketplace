using Shared.Dtos.Responses;
using Shared.Enums;

namespace Domain.Entities;

public class UserAction : Entity
{
    public Guid UserId { get; private set; }
    public UserActionType ActionType { get; private set; }
    public string EntityType { get; private set; } = string.Empty;
    public Guid? EntityId { get; private set; }
    public DateTimeOffset PerformedAt { get; private set; }

    private UserAction() { }

    public static Result<UserAction> Create(
        Guid userId,
        UserActionType actionType,
        string entityType,
        Guid? entityId = null)
    {
        var userAction = new UserAction
        {
            Id = Guid.NewGuid(),
            UserId = userId,
            ActionType = actionType,
            EntityType = entityType,
            EntityId = entityId,
            PerformedAt = DateTimeOffset.UtcNow
        };

        return Result<UserAction>.Success(userAction);
    }
}