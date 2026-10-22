using Domain.Constants;
using Shared.Dtos.Responses;
using Shared.Enums;

namespace Domain.Entities;

public class User : Entity
{
    public string Name { get; private set; } = string.Empty;
    public UserRole Role { get; private set; }
    public string PasswordHash { get; private set; } = string.Empty;
    public decimal? Rating { get; private set; }
    public bool IsBlocked { get; private set; }

    private User() { }

    public static Result<User> Create(
        string name,
        string passwordhash,
        UserRole role)
    {
        if (string.IsNullOrEmpty(name))
        {
            return Result<User>.Failure(ErrorMessages.UserNameCannotBeEmpty);
        }

        if (string.IsNullOrEmpty(passwordhash))
        {
            return Result<User>.Failure(ErrorMessages.PasswordHashCannotBeEmpty);
        }

        if (role == UserRole.Admin)
        {
            return Result<User>.Failure(ErrorMessages.AdminRoleCannotSetup);
        }

        var user = new User()
        {
            Id = Guid.NewGuid(),
            Name = name,
            PasswordHash = passwordhash,
            Role = role,
        };

        return Result<User>.Success(user);
    }

    public Result Update(
        string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            return Result.Failure(ErrorMessages.UserNameCannotBeEmpty);
        }

        Name = name;

        return Result.Success();
    }

    public void RecalculateRating(
        IReadOnlyCollection<decimal> projectRatings)
    {
        if (projectRatings.Count == RatingConstants.ZeroCount)
        {
            Rating = RatingConstants.NoRating;
            return;
        }

        Rating = projectRatings.Average();
    }

    public void Block()
    {
        IsBlocked = true;
    }

    public void Unblock()
    {
        IsBlocked = false;
    }

    public Result ChangeRole(UserRole role)
    {
        if (role == UserRole.Admin)
        {
            return Result.Failure(ErrorMessages.AdminRoleCannotSetup);
        }

        Role = role;

        return Result.Success();
    }
}
