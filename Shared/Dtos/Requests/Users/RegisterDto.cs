using Shared.Enums;

namespace Shared.Dtos.Requests.Users;

public record RegisterUserDto(
    string Name,
    string Password,
    UserRole Role);
