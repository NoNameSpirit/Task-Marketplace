using Domain.Entities;
using Domain.Shared;
using MediatR;

namespace Application.Users.Queries.GetById;

public record GetUserByIdQuery(
    Guid UserId) : IRequest<Result<User>>;