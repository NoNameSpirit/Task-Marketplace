using Domain.Entities;
using MediatR;

namespace Application.Users.Queries.GetById;

public record GetUserByIdQuery(
    Guid UserId) : IRequest<User?>;