using Domain.Entities;
using Domain.Shared;
using MediatR;

namespace Application.Users.Queries.SearchByName;

public record SearchUsersQuery(
    string SearchQuery,
    int Page,
    int PageSize) : IRequest<PagedResult<User>>;