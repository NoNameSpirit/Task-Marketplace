using Domain.Entities;
using Infrastructure.Repositories.Users.Queries;
using MediatR;

namespace Application.Users.Queries.GetById;

public class GetUserByIdHandler : IRequestHandler<GetUserByIdQuery, User?>
{
    private readonly IUserQueryRepository _queryRepository;

    public GetUserByIdHandler(IUserQueryRepository queryRepository)
    {
        _queryRepository = queryRepository;
    }

    public async Task<User?> Handle(
        GetUserByIdQuery request,
        CancellationToken cancellationToken = default)
    {
        return await _queryRepository.GetByIdAsync(request.UserId, cancellationToken);
    }
}