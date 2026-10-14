using Domain.Constants;
using Domain.Interfaces;
using Domain.Interfaces.Users;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Enums;

namespace Application.Users.Commands.ChangeRole;

public class ChangeRoleHandler : IRequestHandler<ChangeRoleCommand, Result>
{
    private readonly IUserQueryRepository _queryRepository;
    private readonly IUserCommandRepository _commandRepository;
    private readonly IUnitOfWork _unitOfWork;

    public ChangeRoleHandler(
        IUserQueryRepository queryRepository,
        IUserCommandRepository commandRepository,
        IUnitOfWork unitOfWork)
    {
        _queryRepository = queryRepository;
        _commandRepository = commandRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result> Handle(
        ChangeRoleCommand request,
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

        user.ChangeRole(request.NewRole);

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return Result.Success();
    }
}