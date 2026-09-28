using Shared.Enums;

namespace Web_Api.Dtos.Users;

public record class CreateUserDto(
    string Name,
    UserRole Role);
