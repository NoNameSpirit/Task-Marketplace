using Domain.Constants;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.Users;
using Shared.Enums;
using Task_Marketplace.Application.Interfaces.Repositories.Users;
using Task_Marketplace.Application.Mappers;

namespace Task_Marketplace.Application.Handlers.Users.Queries.SearchByName;

public class SearchUsersHandler : IRequestHandler<SearchUsersQuery, Result<PagedResult<UserDto>>>
{
    private readonly IUserQueryRepository _queryRepository;

    public SearchUsersHandler(IUserQueryRepository queryRepository)
    {
        _queryRepository = queryRepository;
    }

    public async Task<Result<PagedResult<UserDto>>> Handle(
        SearchUsersQuery request,
        CancellationToken cancellationToken = default)
    {
        var pagedResult = await _queryRepository.SearchByNameAsync(request.SearchQuery, request.Page, request.PageSize, cancellationToken);

        if (pagedResult is null)
        {
            return Result<PagedResult<UserDto>>.Failure(
                ErrorMessages.UserNotFound,
                ErrorType.NotFound);
        }

        return Result<PagedResult<UserDto>>.Success(UserMapper.ToPagedDto(pagedResult));
    }
}