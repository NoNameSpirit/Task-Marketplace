using Domain.Entities;
using Domain.Shared;
using MediatR;

namespace Application.Users.Queries.GetAll;

public record GetAllUsersQuery(
    int Page,
    int PageSize) : IRequest<PagedResult<User>>;