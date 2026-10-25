using Domain.Interfaces.Users;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.Users;

namespace Task_Marketplace.Application.Handlers.Users.Queries.GetUsers;

public class GetUsersHandler : IRequestHandler<GetUsersQuery, Result<PagedResult<UserDto>>>
{
    private readonly IUserQueryRepository _userRepository;

    public GetUsersHandler(IUserQueryRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<Result<PagedResult<UserDto>>> Handle(
        GetUsersQuery request,
        CancellationToken cancellationToken = default)
    {
        var paged = await _userRepository.GetPagedAsync(
            request.Page,
            request.PageSize,
            cancellationToken);

        var dtos = paged.Collection
            .Select(u => new UserDto
            (
                u.Id,
                u.Name,
                u.Role,
                u.Rating,
                u.IsBlocked
            ))
            .ToList();

        var result = PagedResult<UserDto>.Create(
            dtos,
            paged.Page,
            paged.PageSize,
            paged.TotalCount);

        return Result<PagedResult<UserDto>>.Success(result);
    }
}