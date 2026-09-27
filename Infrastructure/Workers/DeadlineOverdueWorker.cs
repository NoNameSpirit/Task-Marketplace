using Domain.Constants;
using Domain.Interfaces.ProjectTasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Workers;

public class DeadlineOverdueWorker : BackgroundService
{
    private readonly IServiceScopeFactory _serviceScopeFactory;
    private readonly ILogger<DeadlineOverdueWorker> _logger;

    public DeadlineOverdueWorker(
        IServiceScopeFactory serviceScopeFactory,
        ILogger<DeadlineOverdueWorker> logger)
    {
        _serviceScopeFactory = serviceScopeFactory;
        _logger = logger;
    }

    protected async override Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            try
            {
                using var scope = _serviceScopeFactory.CreateScope();

                var queryRepository = scope.ServiceProvider.GetRequiredService<IProjectTaskQueryRepository>();

                var projectTasks = await queryRepository.GetOverdueAsync(stoppingToken);

                foreach (var projectTask in projectTasks)
                {
                    _logger.LogInformation(LoggerMessages.ProjectTaskOverdue,
                        projectTask.Id,
                        projectTask.Title,
                        projectTask.ExecutorId);
                }

                await Task.Delay(TimeSpan.FromHours(1), stoppingToken);
            }
            catch (Exception ex)
            {
                _logger.LogError(LoggerMessages.OverdueDeadlineWorkerException,
                       ex.Message);
            }
        }
    }
}
