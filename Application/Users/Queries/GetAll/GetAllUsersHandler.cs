using Application.Mappers;
using Domain.Interfaces.Users;
using MediatR;
using Shared.Dtos;
using Shared.Dtos.Users;

namespace Application.Users.Queries.GetAll;

public class GetAllUsersHandler : IRequestHandler<GetAllUsersQuery, PagedResult<UserDto>>
{
    private readonly IUserQueryRepository _queryRepository;

    public GetAllUsersHandler(IUserQueryRepository queryRepository)
    {
        _queryRepository = queryRepository;
    }

    public async Task<PagedResult<UserDto>> Handle(
        GetAllUsersQuery request,
        CancellationToken cancellationToken = default)
    {
        var pagedResult = await _queryRepository.GetAllAsync(
            request.Page,
            request.PageSize,
            cancellationToken);

        return UserMapper.ToPagedDto(pagedResult);
    }
}