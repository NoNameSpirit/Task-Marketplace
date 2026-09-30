using Domain.Constants;
using Microsoft.AspNetCore.Mvc;
using Shared.Dtos;
using Shared.Enums;

namespace Web_Api.Extensions;

public static class ResultExtensions
{
    public static IActionResult ToResponse(
        this Result result,
        ControllerBase controllerBase)
    {
        if (result.IsSuccess)
        {
            return controllerBase.NoContent();
        }

        var (statusCode, title) = StatusSelector(result.Error);

        return controllerBase.Problem(
            detail: result.Message,
            statusCode: statusCode,
            title: title);
    }

    public static IActionResult ToResponse<T>(
        this Result<T> result,
        ControllerBase controllerBase) where T : class
    {
        if (result.IsSuccess)
        {
            return controllerBase.Ok(result.Value);
        }

        var (statusCode, title) = StatusSelector(result.Error);

        return controllerBase.Problem(
            detail: result.Message,
            statusCode: statusCode,
            title: title);
    }

    private static (int StatusCode, string Title) StatusSelector(ErrorType error)
    {
        return error switch
        {
            ErrorType.NotFound => (StatusCodes.Status404NotFound, ErrorMessages.NotFound),
            ErrorType.Validation => (StatusCodes.Status400BadRequest, ErrorMessages.Validation),
            ErrorType.Conflict => (StatusCodes.Status409Conflict, ErrorMessages.Conflict),
            ErrorType.Unauthorized => (StatusCodes.Status401Unauthorized, ErrorMessages.Unauthorized),
            ErrorType.Forbidden => (StatusCodes.Status403Forbidden, ErrorMessages.Forbidden),
            _ => (StatusCodes.Status500InternalServerError, ErrorMessages.ServerError)
        };
    }
}
