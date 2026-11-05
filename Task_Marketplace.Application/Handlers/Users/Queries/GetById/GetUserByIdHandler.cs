using Domain.Constants;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.Users;
using Shared.Enums;
using Task_Marketplace.Application.Interfaces.Repositories.Users;
using Task_Marketplace.Application.Mappers;

namespace Task_Marketplace.Application.Handlers.Users.Queries.GetById;

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