using Domain.Entities;
using Domain.Interfaces.UserActions;
using MediatR;
using Shared.Dtos.Responses;
using System.Reflection;

namespace Application.Common;

public class UserActionLoggingBehavior<TRequest, TResponse>
    : IPipelineBehavior<TRequest, TResponse>
{
    private readonly IUserActionCommandRepository _repository;

    public UserActionLoggingBehavior(
        IUserActionCommandRepository repository)
    {
        _repository = repository;
    }

    public async Task<TResponse> Handle(
        TRequest request,
        RequestHandlerDelegate<TResponse> next,
        CancellationToken cancellationToken)
    {
        var response = await next(cancellationToken);

        if (request is not IUserCommand userCommand
            || response is IResult { IsSuccess: false })
        {
            return response;
        }

        var attribute = typeof(TRequest).GetCustomAttribute<LogActionAttribute>(false);

        if (attribute is null)
        {
            return response;
        }

        var action = UserAction.Create(
            userCommand.UserId,
            attribute.ActionType,
            attribute.EntityType);

        await _repository.AddAsync(action, cancellationToken);

        return response;
    }
}