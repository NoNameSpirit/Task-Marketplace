using Domain.Entities;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;

namespace Domain.Interfaces.ProjectTasks;

public interface IProjectTaskQueryRepository
{
    Task<ProjectTask?> GetByIdAsync(Guid projectTaskId, CancellationToken cancellationToken = default);
    Task<IReadOnlyCollection<ProjectTask>> GetOverdueAsync(CancellationToken cancellationToken = default);
    Task<PagedResult<ProjectTask>> GetByCustomerIdAsync(Guid CustomerId, int page, int pageSize, CancellationToken cancellationToken = default);
    Task<PagedResult<ProjectTask>> GetPublishedAsync(int page, int pageSize, CancellationToken cancellationToken = default);
    Task<List<TaskResponseDto>> GetResponsesByTaskIdAsync(Guid taskId, CancellationToken cancellationToken = default);
    Task<ProjectTask?> GetTrackedByIdAsync(Guid projectTaskId, CancellationToken cancellationToken = default);
    Task<PagedResult<ProjectTask>> GetByExecutorIdAsync(Guid executorId, int page, int pageSize, CancellationToken cancellationToken = default);
    Task<IReadOnlyCollection<decimal>> GetRatingsByExecutorAsync(Guid executorId, CancellationToken cancellationToken = default);
}
