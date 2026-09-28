using MediatR;
using Shared.Dtos;
using Shared.Dtos.Users;

namespace Application.Users.Queries.GetAll;

public record GetAllUsersQuery(
    int Page,
    int PageSize) : IRequest<PagedResult<UserDto>>;