using Domain.Constants;
using Domain.Interfaces.Users;
using MediatR;
using Shared.Dtos;

namespace Application.Users.Commands.Update;

public class UpdateUserHandler : IRequestHandler<UpdateUserCommand, Result>
{
    private readonly IUserQueryRepository _queryRepository;
    private readonly IUserCommandRepository _commandRepository;

    public UpdateUserHandler(
        IUserQueryRepository queryRepository,
        IUserCommandRepository commandRepository)
    {
        _queryRepository = queryRepository;
        _commandRepository = commandRepository;
    }

    public async Task<Result> Handle(
        UpdateUserCommand request,
        CancellationToken cancellationToken = default)
    {
        var user = await _queryRepository.GetByIdAsync(request.UserId, cancellationToken);

        if (user is null)
        {
            return Result.Failure(ErrorMessages.UserNotFound);
        }

        var result = user.Update(request.Name);

        if (!result.IsSuccess)
        {
            return Result.Failure(result.Message);
        }

        await _commandRepository.UpdateAsync(user, cancellationToken);

        return Result.Success();
    }
}
