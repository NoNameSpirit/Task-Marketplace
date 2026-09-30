using Application.Mappers;
using Domain.Constants;
using Domain.Interfaces.Users;
using MediatR;
using Shared.Dtos;
using Shared.Dtos.Users;
using Shared.Enums;

namespace Application.Users.Queries.GetById;

public class GetUserByIdHandler : IRequestHandler<GetUserByIdQuery, Result<UserDto>>
{
    private readonly IUserQueryRepository _queryRepository;

    public GetUserByIdHandler(IUserQueryRepository queryRepository)
    {
        _queryRepository = queryRepository;
    }

    public async Task<Result<UserDto>> Handle(
        GetUserByIdQuery request,
        CancellationToken cancellationToken = default)
    {
        var user = await _queryRepository.GetByIdAsync(
            request.UserId,
            cancellationToken);

        if (user is null)
        {
            return Result<UserDto>.Failure(
                ErrorMessages.UserNotFound,
                ErrorType.NotFound);
        }

        return Result<UserDto>.Success(UserMapper.ToDto(user));
    }
}