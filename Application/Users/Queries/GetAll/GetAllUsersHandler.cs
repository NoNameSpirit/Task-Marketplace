using Domain.Entities;
using Domain.Shared;
using Infrastructure.Repositories.Users.Queries;
using MediatR;

namespace Application.Users.Queries.GetAll;

public class GetAllUsersHandler : IRequestHandler<GetAllUsersQuery, PagedResult<User>>
{
    private readonly IUserQueryRepository _queryRepository;

    public GetAllUsersHandler(IUserQueryRepository queryRepository)
    {
        _queryRepository = queryRepository;
    }

    public async Task<PagedResult<User>> Handle(
        GetAllUsersQuery request,
        CancellationToken cancellationToken = default)
    {
        return await _queryRepository.GetAllAsync(request.Page, request.PageSize, cancellationToken);
    }
}