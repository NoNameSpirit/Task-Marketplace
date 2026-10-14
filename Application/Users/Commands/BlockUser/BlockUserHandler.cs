using Domain.Constants;
using Domain.Interfaces;
using Domain.Interfaces.Users;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Enums;

namespace Application.Users.Commands.BlockUser;

public class BlockUserHandler : IRequestHandler<BlockUserCommand, Result>
{
    private readonly IUserQueryRepository _queryRepository;
    private readonly IUserCommandRepository _commandRepository;
    private readonly IUnitOfWork _unitOfWork;

    public BlockUserHandler(
        IUserQueryRepository queryRepository,
        IUserCommandRepository commandRepository,
        IUnitOfWork unitOfWork)
    {
        _queryRepository = queryRepository;
        _commandRepository = commandRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result> Handle(
        BlockUserCommand request,
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

        user.Block();

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return Result.Success();
    }
}