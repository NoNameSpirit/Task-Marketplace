using Application.Mappers;
using Domain.Interfaces.Users;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.Users;

namespace Task_Marketplace.Application.Handlers.Users.Queries.GetAll;

public class GetAllUsersHandler : IRequestHandler<GetAllUsersQuery, Result<PagedResult<UserDto>>>
{
    private readonly IUserQueryRepository _queryRepository;

    public GetAllUsersHandler(IUserQueryRepository queryRepository)
    {
        _queryRepository = queryRepository;
    }

    public async Task<Result<PagedResult<UserDto>>> Handle(
        GetAllUsersQuery request,
        CancellationToken cancellationToken = default)
    {
        var pagedResult = await _queryRepository.GetAllAsync(
            request.Page,
            request.PageSize,
            cancellationToken);

        return Result<PagedResult<UserDto>>.Success(UserMapper.ToPagedDto(pagedResult));
    }
}