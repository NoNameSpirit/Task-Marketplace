using Application.Common;
using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces.UserActions;
using MediatR;
using Shared.Dtos.Responses;
using System.Reflection;

namespace Application.Behaviors;

public class UserActionLoggingBehavior<TRequest, TResponse>
    : IPipelineBehavior<TRequest, TResponse>
    where TRequest : notnull
{
    private readonly IUserActionCommandRepository _repository;
    private readonly ICurrentUser _currentUser;

    public UserActionLoggingBehavior(
        IUserActionCommandRepository repository,
        ICurrentUser currentUser)
    {
        _repository = repository;
        _currentUser = currentUser;
    }

    public async Task<TResponse> Handle(
        TRequest request,
        RequestHandlerDelegate<TResponse> next,
        CancellationToken cancellationToken)
    {
        var response = await next(cancellationToken);

        if (response is IResult { IsSuccess: false })
        {
            return response;
        }

        var attribute = typeof(TRequest).GetCustomAttribute<LogActionAttribute>(false);

        if (attribute is null)
        {
            return response;
        }

        var action = UserAction.Create(
            _currentUser.Id,
            attribute.ActionType,
            attribute.EntityType);

        await _repository.AddAsync(action.Value!, cancellationToken);

        return response;
    }
}