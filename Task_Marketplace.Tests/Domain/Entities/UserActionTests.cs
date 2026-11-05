using Domain.Entities;
using FluentAssertions;
using Shared.Enums;
using Xunit;

namespace Task_Marketplace.Tests.Domain.Entities;

public class UserActionTests
{
    [Fact]
    public void Create_CorrectData_ReturnSuccess()
    {
        var userId = Guid.NewGuid();
        var actionType = UserActionType.CreatedChat;
        var entityType = "entityType";
        var entityId = Guid.NewGuid();

        var result = UserAction.Create(userId, actionType, entityType, entityId);

        result.IsSuccess.Should().BeTrue();
        result.Value!.UserId.Should().Be(userId);
        result.Value!.ActionType.Should().Be(actionType);
        result.Value!.EntityType.Should().Be(entityType);
        result.Value!.EntityId.Should().Be(entityId);
    }
}
