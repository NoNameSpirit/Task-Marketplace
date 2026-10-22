using Shared.Enums;

namespace Shared.Dtos.Requests.Users;

public record class ChangeRoleUserDto(
    UserRole NewRole);