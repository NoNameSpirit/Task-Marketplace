using Shared.Enums;

namespace Web_Api.Dtos.Users;

public record RegisterUserDto(
    string Name,
    string Password,
    UserRole Role);
