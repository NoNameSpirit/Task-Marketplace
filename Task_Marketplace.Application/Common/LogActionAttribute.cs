using Shared.Enums;

namespace Application.Common;

[AttributeUsage(AttributeTargets.Class)]
public sealed class LogActionAttribute : Attribute
{
    public UserActionType ActionType { get; }
    public string EntityType { get; }

    public LogActionAttribute(
        UserActionType actionType,
        string entityType)
    {
        ActionType = actionType;
        EntityType = entityType;
    }
}