using Application.Common;
using Domain.Entities;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Enums;

namespace Application.ProjectTasks.Commands.DeleteProjectTask;

[LogAction(UserActionType.DeletedTask, nameof(ProjectTask))]
public record DeleteProjectTaskCommand(
    Guid TaskId,
    Guid CurrentUserId) : IRequest<Result>, IUserCommand
{
    public Guid UserId => CurrentUserId;
}
