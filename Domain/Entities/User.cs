using Domain.Constants;
using Domain.Enums.User;
using Domain.Shared;

namespace Domain.Entities;

public class User : Entity
{
    public string Name { get; private set; } = string.Empty;
    public UserRole Role { get; private set; }
    public decimal? Rating { get; internal set; }

    private User() { }

    public static Result<User> Create(
        string name,
        UserRole role)
    {
        if (string.IsNullOrEmpty(name))
        {
            return Result<User>.Failure(ErrorMessages.UserNameCannotBeEmpty);
        }

        var user = new User()
        {
            Id = Guid.NewGuid(),
            Name = name,
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
}
