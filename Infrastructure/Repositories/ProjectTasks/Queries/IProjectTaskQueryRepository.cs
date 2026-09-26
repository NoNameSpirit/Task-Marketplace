using Domain.Entities;
using Domain.Shared;

namespace Infrastructure.Repositories.ProjectTasks.Queries;

public interface IProjectTaskQueryRepository
{
    Task<ProjectTask?> GetByIdAsync(Guid projectTaskId, CancellationToken cancellationToken = default);
    Task<IReadOnlyCollection<ProjectTask>> GetOverdueAsync(CancellationToken cancellationToken = default);
    Task<PagedResult<ProjectTask?>> GetByCustomerIdAsync(Guid CustomerId, int page, int pageSize, CancellationToken cancellationToken = default);
    Task<PagedResult<ProjectTask?>> GetPublishedAsync(int page, int pageSize, CancellationToken cancellationToken = default);
}
