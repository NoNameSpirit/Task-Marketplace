using Shared.Enums;

namespace Task_Marketplace.Shared.Dtos.Requests.Users.Commands;

public record class ChangeRoleUserRequest(
    Guid Id,
    UserRole NewRole);