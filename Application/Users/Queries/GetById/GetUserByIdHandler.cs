using Domain.Constants;
using Domain.Entities;
using Domain.Interfaces.Users;
using Domain.Shared;
using MediatR;

namespace Application.Users.Queries.GetById;

public class GetUserByIdHandler : IRequestHandler<GetUserByIdQuery, Result<User>>
{
    private readonly IUserQueryRepository _queryRepository;

    public GetUserByIdHandler(IUserQueryRepository queryRepository)
    {
        _queryRepository = queryRepository;
    }

    public async Task<Result<User>> Handle(
        GetUserByIdQuery request,
        CancellationToken cancellationToken = default)
    {
        var user = await _queryRepository.GetByIdAsync(request.UserId, cancellationToken);

        if (user is null)
        {
            return Result<User>.Failure(ErrorMessages.UserNotFound);
        }

        return Result<User>.Success(user);
    }
}