namespace Shared.Dtos;

public class Result
{
    public bool IsSuccess { get; private set; }
    public string Message { get; private set; } = string.Empty;

    public static Result Success()
    {
        return new Result
        {
            IsSuccess = true,
        };
    }

    public static Result Failure(string message)
    {
        return new Result
        {
            IsSuccess = false,
            Message = message
        };
    }
}

public class Result<T> where T : class
{
    public bool IsSuccess { get; private set; }
    public string Message { get; private set; } = string.Empty;
    public T? Value { get; private set; } = null;

    public static Result<T> Success(T value)
    {
        return new Result<T>
        {
            IsSuccess = true,
            Value = value
        };
    }

    public static Result<T> Failure(string message)
    {
        return new Result<T>
        {
            IsSuccess = false,
            Message = message
        };
    }
}

