using Domain.Constants;
using Shared.Dtos;
using Shared.Enums;

namespace Domain.Entities;

public class ProjectTask : Entity
{
    public string Title { get; private set; } = string.Empty;
    public string Description { get; private set; } = string.Empty;
    public decimal Price { get; private set; } = decimal.Zero;
    public ProjectTaskStatus Status { get; private set; }
    public DateTimeOffset StartsAt { get; private set; }
    public DateTimeOffset EndsAt { get; private set; }

    public Guid CustomerId { get; private set; }
    public Guid? ExecutorId { get; private set; }
    public decimal? ProjectRating { get; private set; }

    private readonly List<Guid> _respondentIds = new();
    public IReadOnlyCollection<Guid> RespondentIds
        => _respondentIds.AsReadOnly();

    private ProjectTask() { }

    public static Result<ProjectTask> Create(
        string title,
        string description,
        decimal price,
        DateTimeOffset startsAt,
        DateTimeOffset endsAt,
        Guid customerId)
    {
        var result = Validate(
            title,
            description,
            price,
            startsAt,
            endsAt,
            customerId);
        if (!result.IsSuccess)
        {
            return Result<ProjectTask>.Failure(result.Message);
        }

        var projectTask = new ProjectTask()
        {
            Id = Guid.NewGuid(),
            Title = title,
            Description = description,
            Price = price,
            StartsAt = startsAt,
            EndsAt = endsAt,
            CustomerId = customerId
        };

        return Result<ProjectTask>.Success(projectTask);
    }

    public Result Update(
        string title,
        string description,
        decimal price,
        DateTimeOffset startsAt,
        DateTimeOffset endsAt,
        Guid customerId)
    {
        if (Status == ProjectTaskStatus.InProgress || Status == ProjectTaskStatus.Done)
        {
            return Result.Failure(ErrorMessages.CannotEditInProgressOrDone);
        }

        if (customerId != CustomerId)
        {
            return Result.Failure(ErrorMessages.CustomerMustBeSame);
        }

        var result = Validate(
            title,
            description,
            price,
            startsAt,
            endsAt,
            customerId);
        if (!result.IsSuccess)
        {
            return Result.Failure(result.Message);
        }

        Title = title;
        Description = description;
        Price = price;
        StartsAt = startsAt;
        EndsAt = endsAt;

        return Result.Success();
    }

    public Result MarkAsDone()
    {
        if (Status != ProjectTaskStatus.InProgress)
        {
            return Result.Failure(ErrorMessages.ProjectMustBeInProgress);
        }

        Status = ProjectTaskStatus.Done;

        return Result.Success();
    }

    public Result RespondToTask(Guid executorId)
    {
        if (Status != ProjectTaskStatus.Published)
        {
            return Result.Failure(ErrorMessages.MustBePublishedToRespond);
        }

        if (CustomerId == executorId)
        {
            return Result.Failure(ErrorMessages.CustomerCannotRespond);
        }

        if (!_respondentIds.Contains(executorId))
        {
            _respondentIds.Add(executorId);
        }

        return Result.Success();
    }

    public Result AssignExecutor(Guid executorId, Guid currentUserId)
    {
        if (CustomerId != currentUserId)
        {
            return Result.Failure(ErrorMessages.OnlyCustomerCanAssign);
        }

        if (Status != ProjectTaskStatus.Published)
        {
            return Result.Failure(ErrorMessages.OnlyPublishedTaskCanBeAssigned);
        }

        if (!_respondentIds.Contains(executorId))
        {
            return Result.Failure(ErrorMessages.ExecutorMustBeAtRespondedCollection);
        }

        Status = ProjectTaskStatus.InProgress;
        ExecutorId = executorId;

        return Result.Success();
    }

    private static Result Validate(
        string title,
        string description,
        decimal price,
        DateTimeOffset startsAt,
        DateTimeOffset endsAt,
        Guid customerId)
    {
        if (string.IsNullOrEmpty(title))
        {
            return Result.Failure(ErrorMessages.TitleCannotBeEmpty);
        }

        if (string.IsNullOrEmpty(description))
        {
            return Result.Failure(ErrorMessages.DescriptionCannotBeEmpty);
        }

        if (price < CurrencyConstants.BasePrice)
        {
            return Result.Failure(ErrorMessages.PriceConnotBeNegative);
        }

        if (startsAt < DateTimeOffset.UtcNow || endsAt < DateTimeOffset.UtcNow)
        {
            return Result.Failure(ErrorMessages.FutureDateTime);
        }

        return Result.Success();
    }
}
