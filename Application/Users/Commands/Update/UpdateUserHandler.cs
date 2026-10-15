using Domain.Constants;
using Domain.Interfaces;
using Domain.Interfaces.Users;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Enums;

namespace Application.Users.Commands.Update;

public class UpdateUserHandler : IRequestHandler<UpdateUserCommand, Result>
{
    private readonly IUserQueryRepository _queryRepository;
    private readonly IUserCommandRepository _commandRepository;
    private readonly IUnitOfWork _unitOfWork;

    public UpdateUserHandler(
        IUserQueryRepository queryRepository,
        IUserCommandRepository commandRepository,
        IUnitOfWork unitOfWork)
    {
        _queryRepository = queryRepository;
        _commandRepository = commandRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result> Handle(
        UpdateUserCommand request,
        CancellationToken cancellationToken = default)
    {
        var user = await _queryRepository.GetByIdAsync(request.UserId, cancellationToken);

        if (user is null)
        {
            return Result.Failure(
                ErrorMessages.UserNotFound,
                ErrorType.NotFound);
        }

        var result = user.Update(request.Name);

        if (!result.IsSuccess)
        {
            return Result.Failure(result.Message);
        }

        await _commandRepository.UpdateAsync(user, cancellationToken);

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return Result.Success();
    }
}
