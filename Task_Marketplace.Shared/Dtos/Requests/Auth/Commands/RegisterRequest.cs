using Shared.Enums;

namespace Task_Marketplace.Shared.Dtos.Requests.Auth.Commands;

public record RegisterRequest(
    string Name,
    string Password,
    UserRole Role);
