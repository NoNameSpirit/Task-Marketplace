using Domain.Entities;
using Shared.Dtos.Chats;

namespace Application.Mappers;

public static class ChatMapper
{
    public static ChatDto ToDto(Chat entity)
    {
        return new ChatDto(
            entity.Id,
            entity.Messages.Select(m => new MessageDto(
                m.Id,
                m.UserId,
                m.Text)
            ).ToList()
        );
    }
}
