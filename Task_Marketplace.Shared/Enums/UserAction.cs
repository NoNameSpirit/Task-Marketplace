namespace Shared.Enums;

public enum UserActionType
{
    Registered,
    LoggedIn,
    CreatedTask,
    UpdatedTask,
    DeletedTask,
    CancelledTask,
    RespondedToTask,
    AssignedExecutor,
    MarkedTaskDone,
    SentMessage,
    CreatedChat,
    DeletedChat,
    UserBlocked,
    UserUnblocked,
    UserRoleChanged,
    UserDeleted
}