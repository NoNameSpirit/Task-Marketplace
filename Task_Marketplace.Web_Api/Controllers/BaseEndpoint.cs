using FastEndpoints;
using Shared.Dtos.Responses;
using Web_Api.Extensions;

namespace Web_Api.Controllers;

public abstract class BaseEndpoint<TRequest, TResponse>
    : Endpoint<TRequest, TResponse>
    where TRequest : notnull
{
    private const bool IsFailure = true;

    public async Task<bool> SendIfFailureAsync(
       Result result,
       CancellationToken cancellationToken = default)
    {
        if (result.IsSuccess)
        {
            return !IsFailure;
        }

        var (statusCode, title) = ResultExtensions.StatusSelector(result.Error);

        await Send.ResultAsync(TypedResults.Problem(
            detail: result.Message,
            statusCode: statusCode,
            title: title));

        return IsFailure;
    }

    public async Task<bool> SendIfFailureAsync<T>(
        Result<T> result,
        CancellationToken cancellationToken = default)
        where T : class
    {
        if (result.IsSuccess)
        {
            return !IsFailure;
        }

        var (statusCode, title) = ResultExtensions.StatusSelector(result.Error);

        await Send.ResultAsync(TypedResults.Problem(
            detail: result.Message,
            statusCode: statusCode,
            title: title));

        return IsFailure;
    }
}
