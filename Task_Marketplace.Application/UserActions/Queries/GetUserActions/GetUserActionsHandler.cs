using Domain.Interfaces.UserActions;
using Domain.Interfaces.Users;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.UserActions;

namespace Application.UserActions.Queries.GetUserActions;

public class GetUserActionsHandler
    : IRequestHandler<GetUserActionsQuery, Result<PagedResult<UserActionDto>>>
{
    private readonly IUserActionQueryRepository _actionRepository;
    private readonly IUserQueryRepository _userRepository;

    public GetUserActionsHandler(
        IUserActionQueryRepository actionRepository,
        IUserQueryRepository userRepository)
    {
        _actionRepository = actionRepository;
        _userRepository = userRepository;
    }

    public async Task<Result<PagedResult<UserActionDto>>> Handle(
        GetUserActionsQuery request,
        CancellationToken cancellationToken = default)
    {
        var paged = await _actionRepository.GetAsync(
            request.UserId,
            request.ActionType,
            request.Page,
            request.PageSize,
            cancellationToken);

        if (paged.TotalCount == 0)
        {
            return Result<PagedResult<UserActionDto>>.Success(
                PagedResult<UserActionDto>.Empty(request.Page, request.PageSize));
        }

        var userIds = paged.Collection
            .Select(a => a.UserId)
            .Distinct()
            .ToList();

        var users = await _userRepository.GetNamesByIdsAsync(userIds, cancellationToken);

        var dtos = paged.Collection
            .Select(a => new UserActionDto
            {
                Id = a.Id,
                UserId = a.UserId,
                UserName = users.TryGetValue(a.UserId, out var name) ? name : "Unknown",
                ActionType = a.ActionType,
                EntityType = a.EntityType,
                PerformedAt = a.PerformedAt
            })
            .ToList();

        var result = PagedResult<UserActionDto>.Create(
            dtos,
            paged.Page,
            paged.PageSize,
            paged.TotalCount);

        return Result<PagedResult<UserActionDto>>.Success(result);
    }
}