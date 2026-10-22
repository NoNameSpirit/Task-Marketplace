using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.Users;

namespace Application.Users.Queries.GetUsers;

public record GetUsersQuery(
    int Page,
    int PageSize) : IRequest<Result<PagedResult<UserDto>>>;