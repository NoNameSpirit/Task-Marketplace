using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;

namespace Application.ProjectTasks.Queries.GetResponses;

public record GetTaskResponsesQuery(
    Guid TaskId) : IRequest<Result<List<TaskResponseDto>>>;