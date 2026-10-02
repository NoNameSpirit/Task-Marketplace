using Shared.Enums;

namespace Shared.Dtos.Responses.UserActions;

public record class UserActionDto
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public string UserName { get; set; } = string.Empty;
    public UserActionType ActionType { get; set; }
    public string EntityType { get; set; } = string.Empty;
    public DateTimeOffset PerformedAt { get; set; }
}