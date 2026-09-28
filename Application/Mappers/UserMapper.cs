using Domain.Entities;
using Shared.Dtos;
using Shared.Dtos.Users;

namespace Application.Mappers;

public static class UserMapper
{
    public static UserDto ToDto(User entity)
    {
        return new UserDto(
            entity.Id,
            entity.Name,
            entity.Role,
            entity.Rating);
    }

    public static PagedResult<UserDto> ToPagedDto(PagedResult<User> paged)
    {
        var dtos = paged.Collection
            .Select(ToDto)
            .ToList();

        var pagedResult = PagedResult<UserDto>.Create(
            dtos,
            paged.Page,
            paged.PageSize,
            paged.TotalCount);

        return pagedResult;
    }
}
