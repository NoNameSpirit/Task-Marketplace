using Domain.Constants;
using Domain.Interfaces.Users;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Enums;

namespace Task_Marketplace.Application.Handlers.Users.Commands.ChangeRole;

public class ChangeRoleHandler : IRequestHandler<ChangeRoleCommand, Result>
{
    private readonly IUserQueryRepository _queryRepository;

    public ChangeRoleHandler(IUserQueryRepository queryRepository)
    {
        _queryRepository = queryRepository;
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

        var result = user.ChangeRole(request.NewRole);

        if (!result.IsSuccess)
        {
            return Result.Failure(result.Message, ErrorType.Validation);
        }

        return Result.Success();
    }
}