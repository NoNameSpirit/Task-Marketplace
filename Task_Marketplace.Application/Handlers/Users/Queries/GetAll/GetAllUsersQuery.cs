using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.Users;

namespace Task_Marketplace.Application.Handlers.Users.Queries.GetAll;

public record GetAllUsersQuery(
    int Page,
    int PageSize) : IRequest<Result<PagedResult<UserDto>>>;