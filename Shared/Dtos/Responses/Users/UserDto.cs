using Shared.Enums;

namespace Shared.Dtos.Responses.Users;

public record class UserDto(
    Guid Id,
    string Name,
    UserRole Role,
    decimal? Rating);
