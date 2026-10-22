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

    public static UserAction Create(
        Guid userId,
        UserActionType actionType,
        string entityType,
        Guid? entityId = null)
    {
        return new UserAction
        {
            Id = Guid.NewGuid(),
            UserId = userId,
            ActionType = actionType,
            EntityType = entityType,
            EntityId = entityId,
            PerformedAt = DateTimeOffset.UtcNow
        };
    }
}