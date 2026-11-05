using FastEndpoints;

namespace Web_Api.Controllers.Chats;

public class ChatGroup : Group
{
    public ChatGroup()
    {
        Configure("api/chat", ep =>
        {
            ep.Description(b => b.WithTags("Chats"));
        });
    }
}