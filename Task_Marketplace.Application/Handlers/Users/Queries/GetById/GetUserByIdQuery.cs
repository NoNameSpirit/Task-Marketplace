using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.Users;

namespace Task_Marketplace.Application.Handlers.Users.Queries.GetById;

public record GetUserByIdQuery(
    Guid UserId) : IRequest<Result<UserDto>>;