using Domain.Entities;

namespace Infrastructure.Repositories.ProjectTasks.Commands;

public interface IProjectTaskCommandRepository
{
    Task AddAsync(ProjectTask projectTask, CancellationToken cancellationToken = default);
    Task UpdateAsync(ProjectTask projectTask, CancellationToken cancellationToken = default);
    Task DeleteAsync(ProjectTask projectTask, CancellationToken cancellationToken = default);
}
