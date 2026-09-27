using Domain.Constants;
using Domain.Entities;
using Domain.Shared;
using Infrastructure.Repositories.Users.Queries;
using MediatR;

namespace Application.Users.Queries.SearchByName;

public class SearchUsersHandler : IRequestHandler<SearchUsersQuery, Result<PagedResult<User>>>
{
    private readonly IUserQueryRepository _queryRepository;

    public SearchUsersHandler(IUserQueryRepository queryRepository)
    {
        _queryRepository = queryRepository;
    }

    public async Task<Result<PagedResult<User>>> Handle(
        SearchUsersQuery request,
        CancellationToken cancellationToken = default)
    {
        var user = await _queryRepository.SearchByNameAsync(request.SearchQuery, request.Page, request.PageSize, cancellationToken);

        if (user is null)
        {
            return Result<PagedResult<User>>.Failure(ErrorMessages.UserNotFound);
        }

        return Result<PagedResult<User>>.Success(user);
    }
}