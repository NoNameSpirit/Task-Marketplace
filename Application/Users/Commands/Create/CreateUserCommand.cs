using Domain.Entities;
using Domain.Enums.User;
using Domain.Shared;
using MediatR;

namespace Application.Users.Commands.CreateUser;

public record CreateUserCommand(
    string Name,
    UserRole Role) : IRequest<Result<User>>;
