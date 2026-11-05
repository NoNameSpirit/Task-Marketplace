using Domain.Entities;

namespace Task_Marketplace.Application.Interfaces.Repositories.ProjectTasks;

public interface IProjectTaskCommandRepository
{
    Task AddAsync(ProjectTask projectTask, CancellationToken cancellationToken = default);
    Task UpdateAsync(ProjectTask projectTask, CancellationToken cancellationToken = default);
    Task DeleteAsync(Guid projectTaskId, CancellationToken cancellationToken = default);
}
