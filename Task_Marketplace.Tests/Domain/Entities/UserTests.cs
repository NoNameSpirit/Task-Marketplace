using Domain.Constants;
using Domain.Entities;
using FluentAssertions;
using Shared.Dtos.Responses;
using Shared.Enums;
using Xunit;

namespace Task_Marketplace.Tests.Domain.Entities;

public class UserTests
{

    public const string _name = "Name";
    public const string _passwordhash = "Hash";
    public const UserRole _role = UserRole.Executor;

    [Fact]
    public void Create_NameIsEmpty_ReturnFailure()
    {
        var expectedResult = Result<User>.Failure(ErrorMessages.UserNameCannotBeEmpty);

        var result = User.Create(string.Empty, _passwordhash, _role);

        result.Should().Be(expectedResult);
    }

    [Fact]
    public void Create_HashIsEmpty_ReturnFailure()
    {
        var expectedResult = Result<User>.Failure(ErrorMessages.PasswordHashCannotBeEmpty);

        var result = User.Create(_name, string.Empty, _role);

        result.Should().Be(expectedResult);
    }

    [Fact]
    public void Create_RoleIsAdmin_ReturnFailure()
    {
        var expectedResult = Result<User>.Failure(ErrorMessages.AdminRoleCannotSetup);

        var result = User.Create(_name, _passwordhash, UserRole.Admin);

        result.Should().Be(expectedResult);
    }

    [Fact]
    public void Create_CorrectData_ReturnSuccess()
    {
        var result = User.Create(_name, _passwordhash, _role);

        result.IsSuccess.Should().BeTrue();
        result.Value!.Name.Should().Be(_name);
        result.Value!.PasswordHash.Should().Be(_passwordhash);
        result.Value!.Role.Should().Be(_role);
    }

    [Fact]
    public void Update_NameIsEmpty_ReturnFailure()
    {
        var expectedResult = Result.Failure(ErrorMessages.UserNameCannotBeEmpty);
        var user = User.Create(_name, _passwordhash, _role).Value!;

        var result = user.Update(string.Empty);

        result.Should().Be(expectedResult);
    }

    [Fact]
    public void Update_CorrectData_ReturnSuccess()
    {
        var expectedResult = Result.Success();
        var newName = "newName";
        var user = User.Create(_name, _passwordhash, _role).Value!;

        var result = user.Update(newName);

        result.Should().Be(expectedResult);
        user.Name.Should().Be(newName);
    }

    [Fact]
    public void RecalculateRating_ListOfRatingWithData_ReturnAverage()
    {
        var listOfRating = new List<decimal> { 1.0m, 2.0m };
        var avgRating = listOfRating.Average();

        var user = User.Create(_name, _passwordhash, _role).Value!;

        user.RecalculateRating(listOfRating);

        user.Rating.Should().Be(avgRating);
    }

    [Fact]
    public void RecalculateRating_EmptyListOfRating_ReturnAverage()
    {
        var listOfRating = new List<decimal>();

        var user = User.Create(_name, _passwordhash, _role).Value!;

        user.RecalculateRating(listOfRating);

        user.Rating.Should().Be(RatingConstants.NoRating);
    }

    [Fact]
    public void ChangeRole_RoleIsAdmin_ReturnFailure()
    {
        var expectedResult = Result.Failure(ErrorMessages.AdminRoleCannotSetup);

        var user = User.Create(_name, _passwordhash, _role).Value!;

        var result = user.ChangeRole(UserRole.Admin);

        result.Should().Be(expectedResult);
    }

    [Fact]
    public void ChangeRole_RoleIsNotAdmin_ReturnSuccess()
    {
        var expectedResult = Result.Success();

        var user = User.Create(_name, _passwordhash, _role).Value!;

        var result = user.ChangeRole(UserRole.Customer);

        result.Should().Be(expectedResult);
    }
}
