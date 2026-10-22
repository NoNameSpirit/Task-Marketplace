using Domain.Constants;
using Domain.Entities;
using FluentAssertions;
using Shared.Dtos.Responses;
using Xunit;

namespace Task_Marketplace.Tests.Domain.Entities;

public class ChatTests
{
    [Fact]
    public void Create_Success_ReturnSuccess()
    {
        var projectTaskId = Guid.NewGuid();

        var result = Chat.Create(projectTaskId);

        result.IsSuccess.Should().BeTrue();
        result.Should().NotBeNull();
        result.Value!.ProjectTaskId.Should().Be(projectTaskId);
    }


    [Fact]
    public void AddMessage_IncorrectData_ReturnFailureValidation()
    {
        var expectedResult = Result.Failure(ErrorMessages.MessageTextCannotBeEmpty);

        var chat = Chat.Create(Guid.NewGuid()).Value!;
        var result = chat.AddMessage(string.Empty, Guid.NewGuid());

        result.Should().NotBeNull();
        result.Should().Be(expectedResult);
    }

    [Fact]
    public void AddMessage_CorrectData_ReturnSuccess()
    {
        var expectedResult = Result.Success();

        var chat = Chat.Create(Guid.NewGuid()).Value!;
        var result = chat.AddMessage("text", Guid.NewGuid());

        result.Should().NotBeNull();
        result.Should().Be(expectedResult);
    }
}


