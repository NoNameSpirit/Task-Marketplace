using Domain.Entities;
using Domain.Shared;
using Infrastructure.Repositories.Users.Queries;
using MediatR;

namespace Application.Users.Queries.SearchByName;

public class SearchUsersHandler : IRequestHandler<SearchUsersQuery, PagedResult<User>>
{
    private readonly IUserQueryRepository _queryRepository;

    public SearchUsersHandler(IUserQueryRepository queryRepository)
    {
        _queryRepository = queryRepository;
    }

    public async Task<PagedResult<User>> Handle(
        SearchUsersQuery request,
        CancellationToken cancellationToken = default)
    {
        return await _queryRepository.SearchByNameAsync(request.SearchQuery, request.Page, request.PageSize, cancellationToken);
    }
}