using Domain.Constants;
using Domain.Interfaces;
using Domain.Interfaces.Users;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Enums;

namespace Application.Users.Commands.Delete;

public class DeleteUserHandler : IRequestHandler<DeleteUserCommand, Result>
{
    private readonly IUserQueryRepository _queryRepository;
    private readonly IUserCommandRepository _commandRepository;
    private readonly IUnitOfWork _unitOfWork;

    public DeleteUserHandler(
        IUserQueryRepository queryRepository,
        IUserCommandRepository commandRepository,
        IUnitOfWork unitOfWork)
    {
        _queryRepository = queryRepository;
        _commandRepository = commandRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result> Handle(
        DeleteUserCommand request,
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

        user.Delete();

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return Result.Success();
    }
}