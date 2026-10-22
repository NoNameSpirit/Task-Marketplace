using Shared.Enums;

namespace Shared.Dtos.Responses;

public interface IResult
{
    bool IsSuccess { get; }
}

public class Result : IResult
{
    public bool IsSuccess { get; private set; }
    public string Message { get; private set; } = string.Empty;
    public ErrorType Error { get; private set; }

    public static Result Success()
    {
        return new Result
        {
            IsSuccess = true,
        };
    }

    public static Result Failure(
        string message,
        ErrorType error = ErrorType.Failure)
    {
        return new Result
        {
            IsSuccess = false,
            Message = message,
            Error = error
        };
    }

    public override bool Equals(object? obj)
    {
        if (obj is not Result other)
        {
            return false;
        }

        var isEqual = other.IsSuccess == IsSuccess
            && other.Message == Message
            && other.Error == Error;

        return isEqual;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(IsSuccess, Message, Error);
    }
}

public class Result<T> : IResult
    where T : class
{
    public bool IsSuccess { get; private set; }
    public string Message { get; private set; } = string.Empty;
    public T? Value { get; private set; } = null;
    public ErrorType Error { get; private set; }

    public static Result<T> Success(T value)
    {
        return new Result<T>
        {
            IsSuccess = true,
            Value = value
        };
    }

    public static Result<T> Failure(
        string message,
        ErrorType error = ErrorType.Failure)
    {
        return new Result<T>
        {
            IsSuccess = false,
            Message = message,
            Error = error
        };
    }

    public override bool Equals(object? obj)
    {
        if (obj is not Result<T> other)
        {
            return false;
        }

        var isEqual = other.IsSuccess == IsSuccess
            && other.Message == Message
            && other.Error == Error
            && EqualityComparer<T?>.Default.Equals(other.Value, Value);

        return isEqual;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(IsSuccess, Message, Error);
    }
}

