using Domain.Entities;
using Domain.Interfaces.UserActions;
using MediatR;

namespace Application.Common;

public class UserActionLoggingBehavior<TRequest, TResponse>
    : IPipelineBehavior<TRequest, TResponse>
    where TRequest : notnull
{
    private readonly IUserActionCommandRepository _repository;

    public UserActionLoggingBehavior(IUserActionCommandRepository repository)
    {
        _repository = repository;
    }

    public async Task<TResponse> Handle(
        TRequest request,
        RequestHandlerDelegate<TResponse> next,
        CancellationToken cancellationToken)
    {
        var response = await next();

        if (request is not IUserCommand userCommand)
        {
            return response;
        }

        var attribute = typeof(TRequest)
            .GetCustomAttributes(typeof(LogActionAttribute), false)
            .OfType<LogActionAttribute>()
            .FirstOrDefault();

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