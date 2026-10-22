using Domain.Constants;
using Shared.Dtos.Responses;
using Shared.Enums;

namespace Application.Services.Hasher;

public class PasswordHasher : IPasswordHasher
{
    public Result<string> Hash(string password)
    {
        if (string.IsNullOrEmpty(password))
        {
            return Result<string>.Failure(
                ErrorMessages.PasswordCannotBeEmpty,
                ErrorType.Validation);
        }

        var passwordHash = BCrypt.Net.BCrypt.HashPassword(password);

        return Result<string>.Success(passwordHash);
    }

    public Result Verify(string password, string passwordHash)
    {
        if (string.IsNullOrEmpty(password))
        {
            return Result.Failure(
                ErrorMessages.PasswordCannotBeEmpty,
                ErrorType.Validation);
        }

        if (string.IsNullOrEmpty(passwordHash))
        {
            return Result.Failure(
                ErrorMessages.PasswordHashCannotBeEmpty,
                ErrorType.Validation);
        }

        var isVerified = BCrypt.Net.BCrypt.Verify(password, passwordHash);

        if (!isVerified)
        {
            return Result.Failure(
                ErrorMessages.IncorrectLoginOrPassword,
                ErrorType.Validation);
        }

        return Result.Success();
    }
}
