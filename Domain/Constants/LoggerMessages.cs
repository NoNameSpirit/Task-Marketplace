namespace Domain.Constants;

public static class LoggerMessages
{
    public const string ProjectTaskOverdue = "Overdue TaskId: {Id}, Title: {Title}, ExecutorId: {ExecutorId}";
    public const string OverdueDeadlineWorkerException = "Exception while checking deadlines {Exception}";
}
