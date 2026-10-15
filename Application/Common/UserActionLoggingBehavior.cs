using Domain.Entities;
using Domain.Interfaces;
using Domain.Interfaces.UserActions;
using MediatR;
using Shared.Dtos.Responses;
using System.Reflection;

namespace Application.Common;

public class UserActionLoggingBehavior<TRequest, TResponse>
    : IPipelineBehavior<TRequest, TResponse>
    where TRequest : notnull
{
    private readonly IUserActionCommandRepository _repository;
    private readonly IUnitOfWork _unitOfWork;

    public UserActionLoggingBehavior(
        IUserActionCommandRepository repository,
        IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
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

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return response;
    }
}