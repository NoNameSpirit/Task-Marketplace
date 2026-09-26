using Domain.Entities;
using Infrastructure.Repositories.Chats.Queries;
using MediatR;

namespace Application.Chats.Queries.GetByTaskId;

public class GetChatByTaskIdHandler : IRequestHandler<GetChatByTaskIdQuery, Chat?>
{
    private readonly IChatQueryRepository _queryRepository;

    public GetChatByTaskIdHandler(IChatQueryRepository queryRepository)
    {
        _queryRepository = queryRepository;
    }

    public async Task<Chat?> Handle(
        GetChatByTaskIdQuery request,
        CancellationToken cancellationToken = default)
    {
        return await _queryRepository.GetByTaskIdAsync(request.TaskId, cancellationToken);
    }
}
