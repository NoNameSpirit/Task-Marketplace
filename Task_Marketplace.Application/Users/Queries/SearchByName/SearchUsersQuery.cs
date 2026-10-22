using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.Users;

namespace Application.Users.Queries.SearchByName;

public record SearchUsersQuery(
    string SearchQuery,
    int Page,
    int PageSize) : IRequest<Result<PagedResult<UserDto>>>;