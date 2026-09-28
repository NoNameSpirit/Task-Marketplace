using Domain.Entities;
using MediatR;
using Shared.Dtos;
using Shared.Enums;

namespace Application.Users.Commands.CreateUser;

public record CreateUserCommand(
    string Name,
    UserRole Role) : IRequest<Result<User>>;
