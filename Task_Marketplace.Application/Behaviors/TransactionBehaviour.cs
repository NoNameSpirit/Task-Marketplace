using Domain.Interfaces;
using MediatR;
using Shared.Dtos.Responses;

namespace Application.Behaviors;

public class TransactionBehaviour<TRequest, TResponse>
    : IPipelineBehavior<TRequest, TResponse>
    where TRequest : notnull
{
    private readonly IUnitOfWork _unitOfWork;

    public TransactionBehaviour(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<TResponse> Handle(
        TRequest request,
        RequestHandlerDelegate<TResponse> next,
        CancellationToken cancellationToken = default)
    {
        var response = await next(cancellationToken);

        if (response is IResult { IsSuccess: false })
        {
            return response;
        }

        if (typeof(TRequest).Name.EndsWith("Query"))
        {
            return response;
        }

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return response;
    }
}
