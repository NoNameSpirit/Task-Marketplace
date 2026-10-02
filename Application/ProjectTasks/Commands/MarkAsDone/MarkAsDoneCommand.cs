using Application.Common;
using Domain.Entities;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Enums;

namespace Application.ProjectTasks.Commands.MarkAsDone;

[LogAction(UserActionType.MarkedTaskDone, nameof(ProjectTask))]
public record MarkAsDoneCommand(
    Guid TaskId,
    Guid CurrentUserId,
    decimal? Rating) : IRequest<Result>, IUserCommand
{
    public Guid UserId => CurrentUserId;
}