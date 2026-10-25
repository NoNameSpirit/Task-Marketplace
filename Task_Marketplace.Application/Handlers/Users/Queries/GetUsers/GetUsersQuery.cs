using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.Users;

namespace Task_Marketplace.Application.Handlers.Users.Queries.GetUsers;

public record GetUsersQuery(
    int Page,
    int PageSize) : IRequest<Result<PagedResult<UserDto>>>;