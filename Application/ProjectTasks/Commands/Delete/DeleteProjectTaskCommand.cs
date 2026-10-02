using MediatR;
using Shared.Dtos.Responses;

namespace Application.ProjectTasks.Commands.DeleteProjectTask;

public record DeleteProjectTaskCommand(
    Guid TaskId) : IRequest<Result>;
