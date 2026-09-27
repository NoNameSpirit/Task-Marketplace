using Domain.Entities;
using Domain.Interfaces.Users;
using Domain.Shared;
using MediatR;

namespace Application.Users.Commands.CreateUser;

public class CreateUserHandler : IRequestHandler<CreateUserCommand, Result<User>>
{
    private readonly IUserCommandRepository _commandRepository;

    public CreateUserHandler(IUserCommandRepository commandRepository)
    {
        _commandRepository = commandRepository;
    }

    public async Task<Result<User>> Handle(
        CreateUserCommand request,
        CancellationToken cancellationToken = default)
    {
        var result = User.Create(request.Name, request.Role);

        if (!result.IsSuccess)
        {
            return Result<User>.Failure(result.Message);
        }

        await _commandRepository.AddAsync(result.Value!, cancellationToken);

        return Result<User>.Success(result.Value!);
    }
}