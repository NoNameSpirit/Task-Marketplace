using MediatR;
using Shared.Dtos;
using Shared.Dtos.Users;

namespace Application.Users.Queries.GetById;

public record GetUserByIdQuery(
    Guid UserId) : IRequest<Result<UserDto>>;