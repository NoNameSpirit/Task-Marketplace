using Domain.Entities;
using FluentAssertions;
using Xunit;

namespace Task_Marketplace.Tests.Domain.Entities;

public class TaskResponseTests
{
    [Fact]
    public void Create_CorrectData_ReturnSuccess()
    {
        var taskId = Guid.NewGuid();
        var executorId = Guid.NewGuid();

        var result = TaskResponse.Create(taskId, executorId);

        result.IsSuccess.Should().BeTrue();
        result.Value!.TaskId.Should().Be(taskId);
        result.Value!.ExecutorId.Should().Be(executorId);
    }
}