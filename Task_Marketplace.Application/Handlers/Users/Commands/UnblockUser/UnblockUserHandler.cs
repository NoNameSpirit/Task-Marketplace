using Domain.Constants;
using Domain.Interfaces.Users;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Enums;

namespace Task_Marketplace.Application.Handlers.Users.Commands.UnblockUser;

public class UnblockUserHandler : IRequestHandler<UnblockUserCommand, Result>
{
    private readonly IUserQueryRepository _queryRepository;

    public UnblockUserHandler(IUserQueryRepository queryRepository)
    {
        _queryRepository = queryRepository;
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

        return Result.Success();
    }
}