namespace Task_Marketplace.Shared.Dtos.Requests.Auth.Commands;

public record LoginRequest(
    string Name,
    string Password);
