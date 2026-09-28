using MediatR;
using Shared.Dtos;
using Shared.Dtos.Users;

namespace Application.Users.Queries.SearchByName;

public record SearchUsersQuery(
    string SearchQuery,
    int Page,
    int PageSize) : IRequest<Result<PagedResult<UserDto>>>;