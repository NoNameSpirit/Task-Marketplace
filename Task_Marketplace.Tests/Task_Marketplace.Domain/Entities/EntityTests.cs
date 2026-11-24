using Domain.Constants;
using Domain.Entities;
using FluentAssertions;
using Shared.Dtos.Responses;
using Xunit;

namespace Task_Marketplace.Tests.Domain.Entities;

public class EntityTests
{
    private class DummyClass : Entity;

    [Fact]
    public void Delete_IsNotDeleted_ReturnSuccess()
    {
        var dummy = new DummyClass();
        var expectedResult = Result.Success();

        var result = dummy.Delete();

        result.Should().NotBeNull();
        result.Should().Be(expectedResult);
    }

    [Fact]
    public void Delete_AlreadyDeleted_ReturnFailure()
    {
        var dummy = new DummyClass();
        var expectedResult = Result.Failure(ErrorMessages.EntityHasAlreadyDeleted);

        dummy.Delete();
        var result = dummy.Delete();

        result.Should().NotBeNull();
        result.Should().Be(expectedResult);
    }
}
