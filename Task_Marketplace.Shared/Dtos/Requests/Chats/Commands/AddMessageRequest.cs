namespace Task_Marketplace.Shared.Dtos.Requests.Chats.Commands;

public record class AddMessageRequest(
    Guid Id,
    string Text);
