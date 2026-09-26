using Domain.Entities;

namespace Infrastructure.Repositories.ProjectTasks.Commands;

public interface IProjectTaskCommandRepository
{
    Task AddAsync(ProjectTask projectTask, CancellationToken cancellationToken = default);
    Task UpdateAsync(ProjectTask projectTask, CancellationToken cancellationToken = default);
    Task DeleteAsync(Guid projectTaskId, CancellationToken cancellationToken = default);
}
