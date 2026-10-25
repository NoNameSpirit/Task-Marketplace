using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;

namespace Task_Marketplace.Application.Handlers.ProjectTasks.Queries.GetResponses;

public record GetTaskResponsesQuery(
    Guid TaskId) : IRequest<Result<List<TaskResponseDto>>>;