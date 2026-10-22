using Domain.Entities;
using Domain.Interfaces.ProjectTasks;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories.ProjectTasks;

public class ProjectTaskCommandRepository : IProjectTaskCommandRepository
{
    private readonly AppDbContext _context;

    public ProjectTaskCommandRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(
        ProjectTask projectTask,
        CancellationToken cancellationToken = default)
    {
        await _context.ProjectTasks.AddAsync(projectTask, cancellationToken);
    }

    public async Task UpdateAsync(
        ProjectTask projectTask,
        CancellationToken cancellationToken = default)
    {
        _context.ProjectTasks.Update(projectTask);
    }

    public async Task DeleteAsync(
        Guid projectTaskId,
        CancellationToken cancellationToken = default)
    {
        var deletedProjectTask = await _context.ProjectTasks
            .FirstOrDefaultAsync(p => p.Id == projectTaskId, cancellationToken);

        if (deletedProjectTask is not null)
        {
            deletedProjectTask.Delete();
        }
    }
}
