using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.Users;

namespace Application.Users.Queries.GetById;

public record GetUserByIdQuery(
    Guid UserId) : IRequest<Result<UserDto>>;