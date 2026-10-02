using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.Users;

namespace Application.Users.Queries.GetAll;

public record GetAllUsersQuery(
    int Page,
    int PageSize) : IRequest<Result<PagedResult<UserDto>>>;