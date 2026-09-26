using Domain.Shared;
using Infrastructure.Repositories.Users.Commands;
using MediatR;

namespace Application.Users.Commands.Delete;

public class DeleteUserHandler : IRequestHandler<DeleteUserCommand, Result>
{
    private readonly IUserCommandRepository _commandRepository;

    public DeleteUserHandler(IUserCommandRepository commandRepository)
    {
        _commandRepository = commandRepository;
    }

    public async Task<Result> Handle(
        DeleteUserCommand request,
        CancellationToken cancellationToken = default)
    {
        await _commandRepository.DeleteAsync(request.UserId, cancellationToken);

        return Result.Success();
    }
}