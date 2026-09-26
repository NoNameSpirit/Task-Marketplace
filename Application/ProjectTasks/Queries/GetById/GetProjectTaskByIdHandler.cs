using Domain.Entities;
using Infrastructure.Repositories.ProjectTasks.Queries;
using MediatR;

namespace Application.ProjectTasks.Queries.GetProjectTaskById;

public class GetProjectTaskByIdHandler : IRequestHandler<GetProjectTaskByIdQuery, ProjectTask?>
{
    private readonly IProjectTaskQueryRepository _queryRepository;

    public GetProjectTaskByIdHandler(IProjectTaskQueryRepository queryRepository)
    {
        _queryRepository = queryRepository;
    }

    public async Task<ProjectTask?> Handle(
        GetProjectTaskByIdQuery request,
        CancellationToken cancellationToken = default)
    {
        return await _queryRepository.GetByIdAsync(request.TaskId, cancellationToken);
    }
}
