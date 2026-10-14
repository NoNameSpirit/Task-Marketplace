using Domain.Constants;
using Domain.Interfaces;
using Domain.Interfaces.Users;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Enums;

namespace Application.Users.Commands.UnblockUser;

public class UnblockUserHandler : IRequestHandler<UnblockUserCommand, Result>
{
    private readonly IUserQueryRepository _queryRepository;
    private readonly IUserCommandRepository _commandRepository;
    private readonly IUnitOfWork _unitOfWork;

    public UnblockUserHandler(
        IUserQueryRepository queryRepository,
        IUserCommandRepository commandRepository,
        IUnitOfWork unitOfWork)
    {
        _queryRepository = queryRepository;
        _commandRepository = commandRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result> Handle(
        UnblockUserCommand request,
        CancellationToken cancellationToken = default)
    {
        var user = await _queryRepository.GetTrackedByIdAsync(
            request.TargetUserId,
            cancellationToken);

        if (user is null)
        {
            return Result.Failure(
                ErrorMessages.UserNotFound,
                ErrorType.NotFound);
        }

        user.Unblock();

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return Result.Success();
    }
}