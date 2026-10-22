using Domain.Constants;
using Shared.Dtos.Responses;

namespace Domain.Entities;

public abstract class Entity
{
    public Guid Id { get; protected set; }
    public bool IsDeleted { get; protected set; }

    public Result Delete()
    {
        if (IsDeleted)
        {
            return Result.Failure(ErrorMessages.EntityHasAlreadyDeleted);
        }

        IsDeleted = true;

        return Result.Success();
    }
}
