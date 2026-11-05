using Domain.Constants;
using Domain.Entities;
using FluentAssertions;
using Shared.Dtos.Responses;
using Shared.Enums;
using Xunit;

namespace Task_Marketplace.Tests.Domain.Entities;

public class ProjectTaskTests
{
    private const string _title = "title";
    private const string _description = "description";
    private const decimal _price = 10.0m;
    private DateTimeOffset _startsAt = DateTimeOffset.UtcNow.AddDays(2);
    private DateTimeOffset _endsAt = DateTimeOffset.UtcNow.AddDays(10);
    private Guid _customerId = Guid.NewGuid();
    private Guid _executorId = Guid.NewGuid();

    [Fact]
    public void Create_EmptyTitle_ReturnFailure()
    {
        var expectedResult = Result<ProjectTask>.Failure(ErrorMessages.TitleCannotBeEmpty);

        var result = ProjectTask.Create(string.Empty, _description, _price, _startsAt, _endsAt, _customerId);

        result.Should().Be(expectedResult);
    }

    [Fact]
    public void Create_EmptyDescription_ReturnFailure()
    {
        var expectedResult = Result<ProjectTask>.Failure(ErrorMessages.DescriptionCannotBeEmpty);

        var result = ProjectTask.Create(_title, string.Empty, _price, _startsAt, _endsAt, _customerId);

        result.Should().Be(expectedResult);
    }

    [Fact]
    public void Create_NegativePrice_ReturnFailure()
    {
        var expectedResult = Result<ProjectTask>.Failure(ErrorMessages.PriceCannotBeNegative);

        var result = ProjectTask.Create(_title, _description, -100, _startsAt, _endsAt, _customerId);

        result.Should().Be(expectedResult);
    }

    [Fact]
    public void Create_PastStartsOrEndsDate_ReturnFailure()
    {
        var expectedResult = Result<ProjectTask>.Failure(ErrorMessages.FutureDateTime);

        var result = ProjectTask.Create(_title, _description, _price, DateTimeOffset.UtcNow.AddDays(-1), _endsAt, _customerId);

        result.Should().Be(expectedResult);
    }

    [Fact]
    public void Create_EndsDateLowerThanStartsDate_ReturnFailure()
    {
        var expectedResult = Result<ProjectTask>.Failure(ErrorMessages.EndDateMustBeAfterStartDate);

        var result = ProjectTask.Create(_title, _description, _price, _startsAt, _startsAt.AddDays(-1), _customerId);

        result.Should().Be(expectedResult);
    }

    [Fact]
    public void Create_CorrectData_ReturnSuccess()
    {
        var result = ProjectTask.Create(_title, _description, _price, _startsAt, _endsAt, _customerId);

        result.IsSuccess.Should().BeTrue();
        result.Value.Should().NotBeNull();
    }

    [Fact]
    public void Update_IncorrectStatus_ReturnFailure()
    {
        var expectedResult = Result.Failure(ErrorMessages.CannotEditInThisStatus);
        var task = ProjectTask.Create(_title, _description, _price, _startsAt, _endsAt, _customerId).Value!;

        task.Cancel(_customerId);

        var result = task.Update(_title, _description, _price, _startsAt, _endsAt, _customerId);

        result.Should().Be(expectedResult);
    }

    [Fact]
    public void Update_IncorrectCustomerId_ReturnFailure()
    {
        var expectedResult = Result.Failure(ErrorMessages.CustomerMustBeSame);
        var task = ProjectTask.Create(_title, _description, _price, _startsAt, _endsAt, _customerId).Value!;

        var result = task.Update(_title, _description, _price, _startsAt, _endsAt, Guid.NewGuid());

        result.Should().Be(expectedResult);
    }

    [Fact]
    public void Update_CorrectData_ReturnSuccess()
    {
        var expectedResult = Result.Success();
        var newTitle = "new title";
        var newDescription = "new desc";
        var newPrice = 20m;
        var task = ProjectTask.Create(_title, _description, _price, _startsAt, _endsAt, _customerId).Value!;

        var result = task.Update(newTitle, newDescription, newPrice, _startsAt, _endsAt, _customerId);

        result.Should().Be(expectedResult);
        task.Title.Should().Be(newTitle);
        task.Description.Should().Be(newDescription);
        task.Price.Should().Be(newPrice);
    }

    [Fact]
    public void Cancel_IncorrectCustomerId_ReturnFailure()
    {
        var expectedResult = Result.Failure(ErrorMessages.OnlyCustomerCanCancel);
        var task = ProjectTask.Create(_title, _description, _price, _startsAt, _endsAt, _customerId).Value!;

        var result = task.Cancel(Guid.NewGuid());

        result.Should().Be(expectedResult);
    }

    [Fact]
    public void Cancel_AlreadyCancelled_ReturnFailure()
    {
        var expectedResult = Result.Failure(ErrorMessages.CannotCancelDoneOrCancelled);
        var task = ProjectTask.Create(_title, _description, _price, _startsAt, _endsAt, _customerId).Value!;

        task.Cancel(_customerId);

        var result = task.Cancel(_customerId);

        result.Should().Be(expectedResult);
    }

    [Fact]
    public void Cancel_CorrectData_ReturnSuccess()
    {
        var expectedResult = Result.Success();
        var task = ProjectTask.Create(_title, _description, _price, _startsAt, _endsAt, _customerId).Value!;

        var result = task.Cancel(_customerId);

        result.Should().Be(expectedResult);
        task.Status.Should().Be(ProjectTaskStatus.Cancelled);
    }

    [Fact]
    public void MarkAsDone_OtherCustomerId_ReturnFailure()
    {
        var expectedResult = Result.Failure(ErrorMessages.OnlyCustomerCanRate);
        var task = ProjectTask.Create(_title, _description, _price, _startsAt, _endsAt, _customerId).Value!;

        var result = task.MarkAsDone(Guid.NewGuid(), 1m);

        result.Should().Be(expectedResult);
    }

    [Fact]
    public void MarkAsDone_NegativeRating_ReturnFailure()
    {
        var expectedResult = Result.Failure(string.Format(
            ErrorMessages.InvalidRatingValue,
            RatingConstants.MinRating,
            RatingConstants.MaxRating));
        var task = ProjectTask.Create(_title, _description, _price, _startsAt, _endsAt, _customerId).Value!;

        task.RespondToTask(_executorId);
        task.AssignExecutor(_executorId, _customerId);

        var result = task.MarkAsDone(_customerId, -1);

        result.Should().Be(expectedResult);
    }

    [Fact]
    public void MarkAsDone_WrongStatus_ReturnFailure()
    {
        var expectedResult = Result.Failure(ErrorMessages.ProjectMustBeInProgress);
        var task = ProjectTask.Create(_title, _description, _price, _startsAt, _endsAt, _customerId).Value!;

        var result = task.MarkAsDone(_customerId, 5m);

        result.Should().Be(expectedResult);
    }

    [Fact]
    public void MarkAsDone_CorrectData_ReturnSuccess()
    {
        var expectedResult = Result.Success();
        var projectRating = 5m;
        var task = ProjectTask.Create(_title, _description, _price, _startsAt, _endsAt, _customerId).Value!;

        task.RespondToTask(_executorId);
        task.AssignExecutor(_executorId, _customerId);

        var result = task.MarkAsDone(_customerId, projectRating);

        result.Should().Be(expectedResult);
        task.Status.Should().Be(ProjectTaskStatus.Done);
        task.ProjectRating.Should().Be(projectRating);
    }

    [Fact]
    public void RespondToTask_ProjectIsNotPublished_ReturnFailure()
    {
        var expectedResult = Result.Failure(ErrorMessages.MustBePublishedToRespond);
        var task = ProjectTask.Create(_title, _description, _price, _startsAt, _endsAt, _customerId).Value!;

        task.Cancel(_customerId);

        var result = task.RespondToTask(_executorId);

        result.Should().Be(expectedResult);
    }

    [Fact]
    public void RespondToTask_CustomerIdAsExecutor_ReturnFailure()
    {
        var expectedResult = Result.Failure(ErrorMessages.CustomerCannotRespond);
        var task = ProjectTask.Create(_title, _description, _price, _startsAt, _endsAt, _customerId).Value!;

        var result = task.RespondToTask(_customerId);

        result.Should().Be(expectedResult);
    }

    [Fact]
    public void RespondToTask_ExecutorAlreadyRespondToThisTask_ReturnFailure()
    {
        var expectedResult = Result.Failure(ErrorMessages.AlreadyResponded);
        var task = ProjectTask.Create(_title, _description, _price, _startsAt, _endsAt, _customerId).Value!;

        task.RespondToTask(_executorId);

        var result = task.RespondToTask(_executorId);

        result.Should().Be(expectedResult);
    }

    [Fact]
    public void RespondToTask_CorrectData_ReturnSuccess()
    {
        var expectedResult = Result.Success();
        var task = ProjectTask.Create(_title, _description, _price, _startsAt, _endsAt, _customerId).Value!;

        var result = task.RespondToTask(_executorId);

        result.Should().Be(expectedResult);
        task.Responses.Should().ContainSingle(r => r.ExecutorId == _executorId);
    }

    [Fact]
    public void AssignExecutor_IncorrectCustomerId_ReturnFailure()
    {
        var expectedResult = Result.Failure(ErrorMessages.OnlyCustomerCanAssign);
        var task = ProjectTask.Create(_title, _description, _price, _startsAt, _endsAt, _customerId).Value!;

        var result = task.AssignExecutor(Guid.NewGuid(), Guid.NewGuid());

        result.Should().Be(expectedResult);
    }

    [Fact]
    public void AssignExecutor_TaskIsNotPublished_ReturnFailure()
    {
        var expectedResult = Result.Failure(ErrorMessages.OnlyPublishedTaskCanBeAssigned);
        var task = ProjectTask.Create(_title, _description, _price, _startsAt, _endsAt, _customerId).Value!;

        task.Cancel(_customerId);

        var result = task.AssignExecutor(Guid.NewGuid(), _customerId);

        result.Should().Be(expectedResult);
    }

    [Fact]
    public void AssignExecutor_ExecutorIsNotExists_ReturnFailure()
    {
        var expectedResult = Result.Failure(ErrorMessages.ExecutorMustBeAtRespondedCollection);
        var task = ProjectTask.Create(_title, _description, _price, _startsAt, _endsAt, _customerId).Value!;

        var result = task.AssignExecutor(Guid.NewGuid(), _customerId);

        result.Should().Be(expectedResult);
    }

    [Fact]
    public void AssignExecutor_CorrectData_ReturnSuccess()
    {
        var expectedResult = Result.Success();
        var task = ProjectTask.Create(_title, _description, _price, _startsAt, _endsAt, _customerId).Value!;

        task.RespondToTask(_executorId);

        var result = task.AssignExecutor(_executorId, _customerId);

        result.Should().Be(expectedResult);
        task.Status.Should().Be(ProjectTaskStatus.InProgress);
        task.ExecutorId.Should().Be(_executorId);
    }
}