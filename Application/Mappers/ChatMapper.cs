using Domain.Entities;
using Shared.Dtos.Responses.Chats;

namespace Application.Mappers;

public static class ChatMapper
{
    public static ChatDto ToDto(Chat entity)
    {
        return new ChatDto(
            entity.Id,
            entity.ProjectTaskId,
            entity.Messages.Select(m => new MessageDto(
                m.Id,
                m.UserId,
                m.Text,
                m.SentAt)
            ).ToList()
        );
    }
}
